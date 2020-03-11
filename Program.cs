using System;

namespace MakeupMethodsMadisonEcrement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Name is Madison Frances Ecrement. Version = 36");
            Console.WriteLine("Please Enter Any String Of Characters.");
            string name = Console.ReadLine();

            void duplicateThis(string s, int nn, char cc)
            {
                for (int i = 0; i < nn; i++)
                {
                    Console.Write(s+cc);
                }
            }

            bool notValidNum = true;
            bool notValidChar = true;
            char c=' ';
            int n = 0;

            while (notValidNum || notValidChar)
            {
                try
                {
                    Console.WriteLine("Type Any Integer Number Between 3 to 6.");
                    string num = Console.ReadLine();

                    //Is it a number?
                    if (int.TryParse(num, out n))
                    {
                        // is it between 3 and 6?
                        if(3 <= n && n <= 6)
                        {
                            notValidNum = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry.");
                    }

                    Console.WriteLine("Type any character not a space");
                    string character = Console.ReadLine();

                    if (char.TryParse(character, out c))
                    {
                        if (!char.IsWhiteSpace(c))
                        {
                            notValidChar = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry.");
                    }                                      
                }
                catch (Exception)
                {
                    Console.WriteLine("");
                }
            }

            duplicateThis(name, n, c);


            // Console.WriteLine(number);


        }
    }
}
