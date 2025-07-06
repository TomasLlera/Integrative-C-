using System;
using System.Collections.Generic;
using Models._4;
using Repository;

namespace Classes._4
{
    internal class ProductCRUD
    {
        private List<Product> productList = new List<Product>();

        public ProductCRUD()
        {
            LoadProducts();
        }

        public void LoadProducts()
        {
            productList = Repository<Product>.ObtenerTodos("product");
        }

        public void SaveProducts()
        {
            Repository<Product>.GuardarLista("product", productList);
        }

        public void CreateProduct()
        {
            try
            {
                Product product = new Product();

                Console.WriteLine("Product ID:");
                product.Id = int.Parse(ValidInput(IsNumeric: true));

                Console.WriteLine("Product Name:");
                product.Name = ValidInput(IsString: true);

                Console.WriteLine("Product Price:");
                product.Price = decimal.Parse(ValidInput(IsNumeric: true));

                Console.WriteLine("Product Stock:");
                product.Stock = int.Parse(ValidInput(IsNumeric: true));

                productList.Add(product);
                SaveProducts();
                Console.WriteLine("The product was created successfully.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"[ERROR] {e.Message}");
            }
        }

        public void ShowProducts()
        {
            Console.WriteLine("\n╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                       PRODUCT LIST                     ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════╣");

            if (productList.Count == 0)
            {
                Console.WriteLine("║                 [INFO] No products found.              ║");
            }
            else
            {
                foreach (var p in productList)
                {
                    string line = $"ID: {p.Id} | Name: {p.Name} | Price: {p.Price:C} | Stock: {p.Stock}";
                    // Ajusta el padding para mantener el ancho del cuadro
                    Console.WriteLine("║ " + line.PadRight(54) + " ║");
                }
            }

            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
        }

        public void ModifyProduct()
        {
            ShowProducts();
            Console.WriteLine("Enter the ID of the product to modify:");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("[ERROR] Invalid input. Please enter a valid number.");
                return;
            }

            var product = productList.Find(p => p.Id == id);
            if (product == null)
            {
                Console.WriteLine("[ERROR] Product not found.");
                return;
            }

            Console.WriteLine($"\nCurrent Name: {product.Name}");
            Console.Write("→ New Name: ");
            product.Name = ValidInput(IsString: true);

            Console.WriteLine($"\nCurrent Price: {product.Price:C}");
            Console.Write("→ New Price: ");
            product.Price = decimal.Parse(ValidInput(IsNumeric: true));

            Console.WriteLine($"\nCurrent Stock: {product.Stock}");
            Console.Write("→ New Stock: ");
            product.Stock = int.Parse(ValidInput(IsNumeric: true));

            SaveProducts();
            Console.WriteLine("\nProduct updated successfully.\n");
        }

        public void DeleteProduct()
        {
            ShowProducts();
            Console.WriteLine("Enter the ID of the product to delete:");
            int id = int.Parse(Console.ReadLine());

            var product = productList.Find(p => p.Id == id);
            if (product == null)
            {
                Console.WriteLine("[ERROR] Product not found.");
                return;
            }

            productList.Remove(product);
            SaveProducts();
            Console.WriteLine("Product deleted successfully.\n");
        }

        public static string ValidInput(bool IsString = false, bool IsNumeric = false)
        {
            string input;
            bool isValid = false;

            do
            {
                input = Console.ReadLine();
                if (IsNumeric && decimal.TryParse(input, out _))
                {
                    isValid = true;
                }
                else if (IsString && !string.IsNullOrWhiteSpace(input))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("[ERROR] Invalid input. Try again:");
                }
            } while (!isValid);

            return input;
        }
    }
}