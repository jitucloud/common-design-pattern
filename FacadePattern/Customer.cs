using System;
namespace FacadePattern
{
    public class Customer
    {

        public Customer(String nameString)
        {
            name = nameString;
        }
        private string name;

        public string Name 
        {
            get { return name; }
        }
   
    }
}
