namespace Factory_Method
{
    public class Laptop : ElectronicProductBase
    {
        public Laptop()
        {
            Name = "Laptop";
            Description = "Laptop is a type of computer";
        }
        //DualCore or MultiCore
        public string ProcessorType { get; set; }
    }
}
