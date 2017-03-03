using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CS_Lesson9
{
    public class BasePhone
    {
        private Thread _thread;
        private int _time;
        public List<Contact> Contacts { get; private set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Weight { get; set; }
        public DimensionsProperty Dimensions { get; set; }

        public BasePhone()
        {
            Contacts = new List<Contact>();
        }

        protected virtual void StartCall(Contact contact, int numberIndex)
        {
            var number = contact.PhoneNumbers[numberIndex];
            Console.WriteLine($"Phone to {contact.Name} ({number})");

            _time = new Random().Next(5, 35);

            _thread = new Thread(Calling);
            _thread.Start();
            Thread.Sleep(_time*1000);
            _thread.Abort();
            Console.WriteLine("End call.");
        }

        void Calling()
        {
            for (int i = 0; i < _time; i++)
            {
                Console.WriteLine($"Seconds: {i+1}");
                Thread.Sleep(1000);
            }
        }

        public class DimensionsProperty
        {
            public float Height { get; set; }
            public float Width { get; set; }
            public float Thickness { get; set; }
        }
    }
}
