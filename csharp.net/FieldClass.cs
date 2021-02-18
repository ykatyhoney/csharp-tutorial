using System;
namespace csharp.net
{
    public class FieldClass
    {
        private string name = "John Doe";
        private int age = 42;

        public void Describe()
        {
            string description = this.name + "is" + this.age + "years old..";
            Console.WriteLine(description);
            
        }
     
    }
}

