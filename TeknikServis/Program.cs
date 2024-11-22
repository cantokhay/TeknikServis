using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SeedDataGenerator.Seed(25).Wait();
            Application.Run(new Form1());
        }

        public static class SeedDataGenerator
        {
            static List<Category> categories = new List<Category>();
            static List<Product> products = new List<Product>();
            static List<Customer> customers = new List<Customer>();
            static List<string> brands = new List<string>();

            public static async Task Seed(int maxCategoryCount)
            {
                using (var db = new TeknikServisDBEntitiesLaptop())
                {
                    db.Database.Initialize(false);

                    if (!db.Category.Any())
                    {
                        GenerateCustomers(10);
                        GenerateBrands(25);
                        GenerateCategoriesAndProducts(maxCategoryCount);
                        await db.SaveChangesAsync();
                    }

                    string EnsureMaxLength(string value, int maxLength)
                    {
                        if (string.IsNullOrEmpty(value)) return value;
                        return value.Length <= maxLength ? value : value.Substring(0, maxLength);
                    }

                    void GenerateCustomers(int customerPerBank)
                    {
                        var faker = new Faker();

                        var cityDistrictMap = new Dictionary<string, List<string>>
                        {
                            { "Istanbul", new List<string> { "Kadikoy", "Besiktas", "Sisli", "Uskudar", "Maltepe" } },
                            { "Ankara", new List<string> { "Cankaya", "Keçiören", "Mamak", "Yenimahalle", "Altındağ" } },
                            { "Izmir", new List<string> { "Bornova", "Karşıyaka", "Buca", "Balçova", "Konak" } },
                            { "Bursa", new List<string> { "Altıparmak", "Nilüfer", "Osmangazi", "Yıldırım", "Görükle" } },
                            { "Antalya", new List<string> { "Muratpaşa", "Konyaaltı", "Kepez", "Aksu", "Döşemealtı" } },
                            { "Adana", new List<string> { "Seyhan", "Çukurova", "Yüreğir", "Sarıçam", "Ceyhan" } },
                            { "Gaziantep", new List<string> { "Şahinbey", "Şehitkamil", "Oğuzeli", "Araban", "Karkamış" } },
                            { "Konya", new List<string> { "Selçuklu", "Karatay", "Meram", "Beyşehir", "Ereğli" } },
                            { "Diyarbakir", new List<string> { "Bağlar", "Kayapınar", "Sur", "Yenişehir", "Bismil" } },
                            { "Eskisehir", new List<string> { "Odunpazarı", "Tepebaşı", "Çifteler", "Sivrihisar", "Alpu" } }
                        };

                        var bankNames = new[] { "Akbank", "Yapı Kredi", "Garanti", "Ziraat", "Vakıfbank", "Halkbank", "TEB", "ING", "Şekerbank", "QNB Finansbank" };

                        foreach (var bank in bankNames)
                        {
                            for (int i = 0; i < customerPerBank; i++)
                            {
                                var pickedCity = faker.PickRandom(cityDistrictMap.Keys.ToList());
                                var pickedDistrict = faker.PickRandom(cityDistrictMap[pickedCity]);

                                var customer = new Customer
                                {
                                    CustomerFirstName = EnsureMaxLength(faker.Name.FirstName(), 50),
                                    CustomerLastName = EnsureMaxLength(faker.Name.LastName(), 50),
                                    CustomerPhoneNumber = EnsureMaxLength(faker.Phone.PhoneNumber(), 20),
                                    CustomerEmail = EnsureMaxLength(faker.Internet.Email(), 50),
                                    CustomerAddress = EnsureMaxLength(faker.Address.FullAddress(), 250),
                                    CustomerCity = EnsureMaxLength(pickedCity, 50),
                                    CustomerDistrict = EnsureMaxLength(pickedDistrict, 50),
                                    CustomerTaxNumber = faker.Random.Number(100000000, 999999999).ToString(),
                                    CustomerTaxOffice = EnsureMaxLength(faker.Company.CompanyName(), 50),
                                    CustomerStatus = faker.Random.Bool().ToString(),
                                    CustomerBank = EnsureMaxLength(bank, 50)
                                };

                                customers.Add(customer);
                                db.Customer.Add(customer);
                            }
                        }
                        db.SaveChanges();
                    }

                    void GenerateBrands(int brandCount)
                    {
                        var faker = new Faker();

                        for (int i = 0; i < brandCount; i++)
                        {
                            var brand = faker.Company.CompanyName();
                            if (brand.Length > 25) brand = brand.Substring(0, 25);
                            while (brands.Contains(brand))
                            {
                                brand = faker.Company.CompanyName();
                                if (brand.Length > 25) brand = brand.Substring(0, 25);
                            }
                            brands.Add(brand);
                        }
                    }

                    void GenerateCategoriesAndProducts(int categoryCount)
                    {
                        var faker = new Faker();

                        var categoryProducts = new Dictionary<string, string[]>
                        {
                            { "Computer", new[] { "Laptop", "Desktop", "Gaming PC", "Workstation", "Server" } },
                            { "Phone", new[] { "Smartphone", "Feature Phone", "Tablet", "Smartwatch" } },
                            { "Appliance", new[] { "Washing Machine", "Refrigerator", "Microwave", "Dishwasher" } },
                            { "Furniture", new[] { "Chair", "Table", "Sofa", "Bed", "Cabinet" } },
                            { "Electronics", new[] { "TV", "Speaker", "Headphones", "Camera", "Monitor" } },
                            { "Sports", new[] { "Football", "Tennis Racket", "Yoga Mat", "Dumbbells", "Basketball" } },
                            { "Toys", new[] { "Action Figure", "Board Game", "Doll", "Puzzle", "Toy Car" } },
                            { "Clothing", new[] { "T-Shirt", "Jeans", "Jacket", "Hat", "Sunglasses" } },
                            { "Books", new[] { "Novel", "Textbook", "Magazine", "Comic Book", "Biography" } },
                            { "Music", new[] { "Guitar", "Piano", "Drums", "Microphone", "Keyboard" } },
                            { "Automotive", new[] { "Car Battery", "Tire", "Engine Oil", "Brake Pads", "Car Wash Kit" } },
                            { "Garden", new[] { "Lawn Mower", "Shovel", "Hose", "Seeds", "Fertilizer" } },
                            { "Health", new[] { "Vitamins", "First Aid Kit", "Face Mask", "Thermometer", "Gloves" } },
                            { "Kitchen", new[] { "Blender", "Knife Set", "Frying Pan", "Toaster", "Kettle" } },
                            { "Office", new[] { "Notebook", "Pen", "Desk", "Chair", "Lamp" } },
                            { "Beauty", new[] { "Lipstick", "Foundation", "Eyeliner", "Perfume", "Nail Polish" } },
                            { "Travel", new[] { "Suitcase", "Backpack", "Travel Pillow", "Map", "Camera" } },
                            { "Fitness", new[] { "Treadmill", "Bicycle", "Rowing Machine", "Weights", "Resistance Bands" } },
                            { "Gaming", new[] { "Console", "Controller", "Headset", "Game Disk", "Mouse" } },
                            { "Pets", new[] { "Dog Food", "Cat Food", "Pet Bed", "Collar", "Aquarium" } },
                            { "Jewelry", new[] { "Ring", "Bracelet", "Necklace", "Earrings", "Watch" } },
                            { "Outdoors", new[] { "Tent", "Sleeping Bag", "Hiking Boots", "Compass", "Flashlight" } },
                            { "Baby", new[] { "Stroller", "Diapers", "Baby Bottle", "Baby Toy", "Crib" } },
                            { "Tools", new[] { "Hammer", "Drill", "Wrench", "Saw", "Screwdriver" } },
                            { "Art", new[] { "Paint", "Canvas", "Brush", "Easel", "Sketchbook" } }
                        };

                        foreach (var categoryName in categoryProducts.Keys.Take(categoryCount))
                        {
                            var category = new Category
                            {
                                CategoryName = categoryName
                            };
                            categories.Add(category);
                            db.Category.Add(category);
                        }

                        db.SaveChanges();

                        foreach (var category in categories)
                        {
                            var productsForCategory = categoryProducts[category.CategoryName];
                            int productCount = faker.Random.Number(1, 5);

                            for (int i = 0; i < productCount; i++)
                            {
                                var product = new Product
                                {
                                    ProductName = faker.PickRandom(productsForCategory),
                                    ProductBrand = faker.PickRandom(brands),
                                    ProductPurchasePrice = decimal.Parse(faker.Commerce.Price(100, 1000)),
                                    ProductSalePrice = decimal.Parse(faker.Commerce.Price(1000, 2000)),
                                    Stock = (short)faker.Random.Number(1, 100),
                                    ProductStatus = faker.Random.Bool(),
                                    Category = category.CategoryId
                                };
                                products.Add(product);
                                db.Product.Add(product);
                            }
                        }
                    }
                }
            }
        }
    }
}
