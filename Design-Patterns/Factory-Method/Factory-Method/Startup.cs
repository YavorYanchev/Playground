using System;

namespace Factory_Method
{
    class Startup
    {
        static void Main(string[] args)
        {
            ProductsFactory factory = new ProductsFactory();
            ElectronicProductBase product;
            foreach (Products prod in Enum.GetValues(typeof(Products)))
            {
                product = factory.CreateProduct(prod);
                Console.WriteLine("Name: {0} ,Description: {1}", product.Name, product.Description);
            }
            Console.WriteLine();
        }
    }
}
