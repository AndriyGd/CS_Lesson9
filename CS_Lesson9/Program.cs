using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CS_Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenovo = new MobilePhone
            {
                FleshCard = new FleshCard { MemorySize = 32, Model = "Kingston A235"},
                Model = "A895",
                Brand = "Lenovo",
                CPU = "MTK8954",
                Dimensions = new BasePhone.DimensionsProperty
                { Height = 100, Thickness = 11,  Width = 65},
                InnerStorage = 15.56f,
                RAM = "1024 Mb",
                ScreenResolution = "1024x768",
                Weight = 112
            };

            lenovo.Contacts.Add(new Contact
            {
                Address = "FHdskFJL",
                Age = 23,
                Email = "fhfhdgfdh@jlj.com",
                Name = "John",
                PhoneNumbers = new List<string> { "+30893844895", "+34734873438"},
                TypeGroup = TypeGroup.Friends
            });


            lenovo.Call(lenovo.Contacts[0], 1);
            lenovo.StartRecord();
            Thread.Sleep(5000);
            lenovo.PauseRecord();
            Thread.Sleep(2000);
            lenovo.StartRecord();
            Thread.Sleep(15000);
            lenovo.StopRecord();

            Console.ReadLine();
        }
    }
}
