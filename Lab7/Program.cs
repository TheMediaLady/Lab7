using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a valid Name: ");
            string name = Console.ReadLine();
            try 
            {
                var patternN = @"^[A-Z][a-zA-Z]{1,29}$";
                bool result = Regex.IsMatch(name, patternN);
                
                {
                Console.WriteLine("Name is valid!");
                Console.ReadLine();
                }
                if (!result)
                {
                 Console.WriteLine("Sorry, name is not valid!");
                 throw new Exception();
                 Console.ReadLine();
                }
             }
               catch(Exception ex1)
               {
                Console.WriteLine("ex1");
               }

             Console.Write("Please enter a valid email:  ");
             string email = Console.ReadLine();
             try 
	{	        
		
	}
	          catch (Exception ex1)
	{

		       throw new Exception();
	}
             {
                var patternE = @"^[a-zA-Z0-9]+\@[\da-zA-Z0-9]+\.[a-z]{1,7}$";
                bool entry = Regex.IsMatch(email, patternE);
                {
                Console.WriteLine("Email is valid!");
                Console.ReadLine();
                }
                if (!entry)
                {
                 Console.WriteLine("Sorry, email is not valid!");
                 throw new Exception();
                 Console.ReadLine();
                }
              }
               catch(Exception ex2)
               {
                Console.WriteLine("ex2");
               }

             Console.Write("Please enter a valid phone number: ");
             int phone = Console.ReadLine();
             try 
            {
                var patternP = @"^[0-9]{3}+\-[0-9]{3}+\-[0-9]{4}$";
                bool number = Regex.IsMatch(phone, patternP);
                
                {
                Console.WriteLine("Phone number is valid!");
                Console.ReadLine();
                }
                if (!number)
                {
                 Console.WriteLine("Sorry, phone number is not valid!");
                 throw new Exception();
                 Console.ReadLine();
                }
             }
               catch(Exception ex3)
               {
                Console.WriteLine("ex3");
               }
             Console.Write("Please enter a valid date (mm/dd/yy): ");
            string date = Console.ReadLine();
            try 
            {
                var patternD = @"^[0-9]{2}+\/[0-9]{2}+\/[0-9]{2}$";
                bool day = Regex.IsMatch(date, patternD);
                
                {
                Console.WriteLine("Date is valid!");
                Console.ReadLine();
                }
                if (!day)
                {
                 Console.WriteLine("Sorry, Date is not valid!");
                 throw new Exception();
                 Console.ReadLine();
                }
             }
               catch(Exception ex4)
               {
                Console.WriteLine("ex4");
               }
        }
    }
}
