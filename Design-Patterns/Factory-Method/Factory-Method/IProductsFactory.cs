namespace Factory_Method
{
    public interface IProductsFactory
    {
        ElectronicProductBase CreateProduct(Products product);
    }
}
