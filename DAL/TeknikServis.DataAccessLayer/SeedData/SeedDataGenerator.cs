using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeknikServis.DataAccessLayer.Context;
using TeknikServis.EntityLayer.ConcreteModels;

namespace TeknikServis.DataAccessLayer.SeedData
{
    public static class SeedDataGenerator
    {
        public static async Task SeedAsync()
        {
            using (var db = new TeknikServisContext())
            {
                db.Database.Initialize(false);

                if (db.Customers.Count() <= 100 || db.Departments.Count() <= 10 || db.Categories.Count() <= 25)
                {
                    var customerCountToGenerate = 100 - db.Customers.Count();
                    var departmentCountToGenerate = 10 - db.Departments.Count();
                    var categoryCountToGenerate = 25 - db.Categories.Count();
                    GenerateCategoriesAndProducts(categoryCountToGenerate);
                    GenerateCustomers(customerCountToGenerate);
                    GenerateDepartmentsAndEmployees(departmentCountToGenerate);
                    await db.SaveChangesAsync();
                }

                #region Faker Generation Methods

                void GenerateDepartmentsAndEmployees(int departmentCountToGenerate)
                {
                    var faker = new Faker();

                    var departmentNames = new[]
                    {
                            "IT", "HR", "Finance", "Sales", "Marketing",
                            "Logistics", "Production", "R&D", "Customer Service", "Quality Assurance"
                        };

                    var existingDepartments = db.Departments.Select(d => d.DepartmentName).ToList();
                    var remainingDepartments = departmentNames.Except(existingDepartments).ToList();

                    int missingDepartments = Math.Max(departmentCountToGenerate, 0);

                    foreach (var departmentName in remainingDepartments.Take(missingDepartments))
                    {
                        var department = new Department
                        {
                            DepartmentName = departmentName,
                            DepartmentDescription = EnsureMaxLength(faker.Lorem.Sentence(), 100)
                        };

                        db.Departments.Add(department);
                        db.SaveChanges();

                        int employeeCount = faker.Random.Number(3, 7);

                        for (int i = 0; i < employeeCount; i++)
                        {
                            var employee = new Employee
                            {
                                EmployeeFirstName = EnsureMaxLength(faker.Name.FirstName(), 50),
                                EmployeeLastName = EnsureMaxLength(faker.Name.LastName(), 50),
                                Department = (byte)department.DepartmentId, // Departman ID'si ile ilişkilendir
                                EmployeeProfilePhoto = faker.Internet.Avatar(),
                                EmployeeMail = EnsureMaxLength(faker.Internet.Email(), 50),
                                EmployeePhoneNumber = GeneratePhoneNumber()
                            };

                            db.Employees.Add(employee);
                        }
                    }

                    db.SaveChanges();
                }

                void GenerateCustomers(int customerCountToGenerate)
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

                    var bankNames = new[] { "Akbank", "Yapı Kredi", "Garanti", "Ziraat", "Vakıfbank",
                                                        "Halkbank", "TEB", "ING", "Şekerbank", "QNB Finansbank" };

                    for (int i = 0; i < customerCountToGenerate; i++)
                    {
                        var pickedCity = faker.PickRandom(cityDistrictMap.Keys.ToList());
                        var pickedDistrict = faker.PickRandom(cityDistrictMap[pickedCity]);
                        var pickedBank = faker.PickRandom(bankNames);

                        var customer = new Customer
                        {
                            CustomerFirstName = EnsureMaxLength(faker.Name.FirstName(), 50),
                            CustomerLastName = EnsureMaxLength(faker.Name.LastName(), 50),
                            CustomerPhoneNumber = GeneratePhoneNumber(),
                            CustomerEmail = EnsureMaxLength(faker.Internet.Email(), 50),
                            CustomerAddress = EnsureMaxLength(faker.Address.FullAddress(), 250),
                            CustomerCity = EnsureMaxLength(pickedCity, 50),
                            CustomerDistrict = EnsureMaxLength(pickedDistrict, 50),
                            CustomerTaxNumber = faker.Random.Number(100000000, 999999999).ToString(),
                            CustomerTaxOffice = EnsureMaxLength(faker.Company.CompanyName(), 50),
                            CustomerStatus = faker.Random.Bool().ToString(),
                            CustomerBank = EnsureMaxLength(pickedBank, 50)
                        };

                        db.Customers.Add(customer);
                    }

                    db.SaveChanges();
                }

                void GenerateCategoriesAndProducts(int categoryCountToGenerate)
                {
                    var faker = new Faker();

                    // Marka isimleri
                    var productBrands = new[]
                    {
                        "Apple", "Samsung", "Sony", "LG Electronics", "Microsoft", "Dell", "Lenovo", "HP", "Asus", "Acer",
                        "Panasonic", "Philips", "Bosch", "Siemens", "Arçelik", "Beko", "Whirlpool", "General Electric",
                        "Xiaomi", "Huawei", "Toshiba", "Nokia", "Casio", "Temu", "Canon"
                    };

                    // Kategori ve ürün ilişkisi
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

                    // Veritabanında var olan kategoriler
                    var existingCategories = db.Categories.Select(c => c.CategoryName).ToList();
                    var remainingCategories = categoryProducts.Keys.Except(existingCategories).ToList();

                    // Eksik kategorileri tamamlama
                    int missingCategories = Math.Max(categoryCountToGenerate, 0);

                    foreach (var categoryName in remainingCategories.Take(missingCategories))
                    {
                        var category = new Category
                        {
                            CategoryName = EnsureMaxLength(categoryName, 50)
                        };
                        db.Categories.Add(category);
                    }

                    db.SaveChanges();

                    // Ürün ekleme işlemi
                    foreach (var category in db.Categories.ToList())
                    {
                        if (!categoryProducts.ContainsKey(category.CategoryName)) continue;

                        var productsForCategory = categoryProducts[category.CategoryName];

                        // Her kategoriye rastgele miktarda ürün ekleme
                        int productCount = faker.Random.Number(3, 7);

                        for (int i = 0; i < productCount; i++)
                        {
                            var product = new Product
                            {
                                ProductName = faker.PickRandom(productsForCategory),
                                ProductBrand = faker.PickRandom(productBrands),
                                ProductPurchasePrice = decimal.Parse(faker.Commerce.Price(100, 1000)),
                                ProductSalePrice = decimal.Parse(faker.Commerce.Price(1000, 2000)),
                                Stock = (short)faker.Random.Number(1, 100),
                                ProductStatus = faker.Random.Bool(),
                                Category = category.CategoryId
                            };

                            db.Products.Add(product);
                        }
                    }

                    db.SaveChanges();
                }

                string EnsureMaxLength(string value, int maxLength)
                {
                    if (string.IsNullOrEmpty(value)) return value;
                    return value.Length <= maxLength ? value : value.Substring(0, maxLength);
                }

                string GeneratePhoneNumber()
                {
                    var faker = new Faker();
                    int areaCode = faker.Random.Number(100, 999);
                    int centralOfficeCode = faker.Random.Number(100, 999);
                    int lineNumberPart1 = faker.Random.Number(10, 99);
                    int lineNumberPart2 = faker.Random.Number(10, 99);

                    return $"({areaCode}) {centralOfficeCode}-{lineNumberPart1}{lineNumberPart2}";
                }

                #endregion


            }
        }
    }
}
