using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson9
{
    public class Human
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} Address: {Address} Age: {Age}";
        }
    }
}
