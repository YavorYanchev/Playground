namespace Factory_Method
{
    public class MobilePhone:ElectronicProductBase
    {
        public MobilePhone()
        {
            Name = "Mobile Phone";
            Description = "Mobile phone description";
        }

        public string PhoneType { get; set; }
    }
}
