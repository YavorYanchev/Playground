using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualDI
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            IMailSender mailSender = new MockMailSender();
            FormHandler formHandler = new FormHandler(mailSender);
            formHandler.Handle("test@test.com");

            Console.ReadLine();
        }
    }
}
