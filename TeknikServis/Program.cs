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
            SeedDataGenerator.Seed(25, 100).Wait();
            Application.Run(new Form1());
        }

        public static class SeedDataGenerator
        {
            static List<Category> categories = new List<Category>();
            static List<Product> products = new List<Product>();
            static List<string> brands = new List<string>();

            public static async Task Seed(int maxCategoryCount, int maxCustomerCount)
            {
                using (var db = new TeknikServisDBEntities())
                {
                    db.Database.Initialize(false);

                    if (!db.Category.Any())
                    {
                        GenerateBrands(25);
                        GenerateCategoriesAndProducts(maxCategoryCount);
                        await db.SaveChangesAsync();
                    }

                    if (!db.Customer.Any())
                    {
                        GenerateCustomers(maxCustomerCount);
                        await db.SaveChangesAsync();
                    }

                    void GenerateCustomers(int customerCount)
                    {
                        var faker = new Faker();

                        var bankNames = new[] { "Akbank", "Yapı Kredi", "Garanti", "Ziraat", "Vakıfbank", "Halkbank", "TEB", "ING", "Şekerbank", "QNB Finansbank" };

                        for (int i = 0; i < maxCustomerCount; i++)
                        {
                            var customer = new Customer
                            {
                                CustomerFirstName = faker.Name.FirstName(),
                                CustomerLastName = faker.Name.LastName(),
                                CustomerPhoneNumber = faker.Phone.PhoneNumber(),
                                CustomerEmail = faker.Internet.Email(),
                                CustomerAddress = faker.Address.FullAddress(),
                                CustomerCity = faker.Address.City(),
                                CustomerDistrict = faker.Address.County(),
                                CustomerTaxNumber = faker.Random.Number(100000000, 999999999).ToString(),
                                CustomerTaxOffice = faker.Company.CompanyName(),
                                CustomerStatus = faker.Random.Bool().ToString(),
                                CustomerBank = faker.PickRandom(bankNames)
                            };
                            db.Customer.Add(customer);
                        }
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

                        // Generate categories
                        foreach (var categoryName in categoryProducts.Keys.Take(categoryCount))
                        {
                            var category = new Category
                            {
                                CategoryName = categoryName
                            };
                            categories.Add(category);
                            db.Category.Add(category);
                        }

                        db.SaveChanges(); // Save categories first

                        // Generate products for each category
                        foreach (var category in categories)
                        {
                            var productsForCategory = categoryProducts[category.CategoryName];
                            int productCount = faker.Random.Number(1, 5); // Randomize product count (1-5 per category)

                            for (int i = 0; i < productCount; i++)
                            {
                                var product = new Product
                                {
                                    ProductName = faker.PickRandom(productsForCategory),
                                    ProductBrand = faker.PickRandom(brands), // Use a random brand from the 25 brands
                                    ProductPurchasePrice = decimal.Parse(faker.Commerce.Price(100, 1000)), // Prices between 100-1000
                                    ProductSalePrice = decimal.Parse(faker.Commerce.Price(1000, 2000)), // Prices between 1000-2000
                                    Stock = (short)faker.Random.Number(1, 100), // Stock between 1-100
                                    ProductStatus = faker.Random.Bool(),
                                    Category = category.CategoryId // Associate with the correct category
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
