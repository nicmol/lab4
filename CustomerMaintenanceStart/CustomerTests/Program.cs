using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerTests

{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerAll();      
                        
        }

        static void TestCustomerConstructors()
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer("firstName", "lastName", "email@test.com");
 
            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting: ' , ' Actual: " + c1.GetDisplayText());
            Console.WriteLine("Overloaded constructor.  Expecting: firstName lastName, email@test.com. Actual: " + c2.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerPropertyGetters()
        {
            Customer c1 = new Customer("Nicolette", "Molitor", "molitorn@my.lanecc.edu");

            Console.WriteLine("Testing getters");
            Console.WriteLine("firstName.  Expecting: Nicolette. Actual: " + c1.FirstName);
            Console.WriteLine("lastName.  Expecting: Molitor. Actual: " + c1.LastName);
            Console.WriteLine("email.  Expecting: molitorn@my.lanecc.edu. Actual: " + c1.Email);
            Console.WriteLine();
        }

        static void TestCustomerPropertySetters()
        {
            Customer c1 = new Customer();

            Console.WriteLine("Testing setters");
            c1.FirstName = "Nicolette";
            c1.LastName = "Molitor";
            c1.Email = "molitorn@my.lanecc.edu";
            Console.WriteLine("Expecting: Nicolette Molitor, molitorn@my.lanecc.edu. Actual: " + c1.GetDisplayText());
            Console.WriteLine();
        }
        static void TestCustomerGetDisplayText()
        {
            Customer c1 = new Customer("firstName", "lastName", "email@test.com");

            Console.WriteLine("Testing GetDisplayText");
            Console.WriteLine("Expecting: firstName lastName, email@test.com. Actual:  " + c1.GetDisplayText());            
            Console.WriteLine();
        }


        static void TestCustomerAll()
        {
            TestCustomerConstructors();
            TestCustomerPropertyGetters();
            TestCustomerPropertySetters();
            TestCustomerGetDisplayText();

            Console.WriteLine();            
            Console.ReadLine();
        }
    }
}


