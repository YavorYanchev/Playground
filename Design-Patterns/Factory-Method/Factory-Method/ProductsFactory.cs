using System;

namespace Factory_Method
{
    public class ProductsFactory : IProductsFactory
    {
        public ProductsFactory()
        {
            Console.WriteLine("Creating Products Factory");
        }

        public ElectronicProductBase CreateProduct(Products product)
        {
            switch (product)
            {
                case Products.Phone:
                    return new MobilePhone();

                case Products.Laptop:
                    return new Laptop();

                case Products.MP3:
                    return new MP3Player();

                default:
                    return new GenericProduct();
            }
        }
    }
}
