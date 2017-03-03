using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson9
{
    public enum TypeGroup
    {
        Work, Family, Sport, Friends
    }

    public class Contact : Human
    {
        public List<string> PhoneNumbers { get; set; }
        public TypeGroup TypeGroup { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Type group: {TypeGroup} Email: {Email}\nPhones: {GetNumbers()}\n";
        }

        private string GetNumbers()
        {
            var numbers = new StringBuilder();
            PhoneNumbers.ForEach(s => numbers.Append($"{s}\n"));

            numbers.Remove(numbers.Length - 2, 1);

            return numbers.ToString();
        }
    }
}
