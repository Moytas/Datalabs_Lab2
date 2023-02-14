using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Dog : Animal
    {
        public Dog(string name,int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }
    }
}
