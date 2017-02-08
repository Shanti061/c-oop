using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> miniDictionary = new Dictionary<string, string>();
            string check, desc;
            //bool found;
            char response;
            miniDictionary.Add("a", "A is the first alphabet.");
            miniDictionary.Add("b", "B is the first alphabet.");
            miniDictionary.Add("c", "C is the first alphabet.");
            miniDictionary.Add("d", "D is the first alphabet.");

            Console.WriteLine("Enter k to check the keyword, \n d to see the description,\n l to look up a value, \n c to count the values in list, \n x to exit");
             response = Convert.ToChar(Console.ReadLine().ToUpper());

            do {

                switch (response) {
                    case 'K':
                        Console.WriteLine("Write a key value to check: ");
                        check = Console.ReadLine();
                       
                        //found = miniDictionary.TryGetValue("a", out check);
                        if (miniDictionary.ContainsKey(check))
                        {
                            Console.WriteLine(check + " is in the dictionary");
                        }
                        else {
                            Console.WriteLine("not in the dictionary");
                        }
                        break;

                    case 'D':
                        Console.WriteLine("Enter the key value for description");
                        desc = Console.ReadLine();
                        if (miniDictionary.ContainsValue(desc)) {
                            Console.WriteLine(desc+ " is in the dictionary");
                        }
                        else {
                            Console.WriteLine("not in the dictionary");
                        }

                        break;

                    default:
                        break;
                }
                Console.WriteLine("Enter k to check the keyword, \n d to see the description,\n l to look up a value, \n c to count the values in list, \n x to exit");
                response = Convert.ToChar(Console.ReadLine().ToUpper());

            } while (response != 'X');
        }
    }
}
