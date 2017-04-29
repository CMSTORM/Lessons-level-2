using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    class Program
    {
        static void Main(string[] args)
        {
            //float f = 0.123346f;
            //decimal d = 1.31231231231233M;
            //decimal b = 1.1231231246789M;
            //decimal c = d + b;
            //Console.WriteLine(c);
            //Console.ReadLine();
            //double infinity = Double.PositiveInfinity;
            //Console.WriteLine(infinity);
            //Console.ReadLine();

            //uint a = 52130;
            //sbyte b = -115;
            //int c = 4825932;
            //ushort v = 97;
            //int d = -100000;
            //uint n = 200000;
            //byte h = 254;
            //ulong i = 9041241241;
            //sbyte p = 112;
            //sbyte o = -44;
            //long q = -10000000;
            //int k = 19999;
            //ulong m = 123456789123456789;

            //float a = 12.345f;
            //double b = 34.56789023;
            //double c = 8941.1234567;
            //decimal g = 1231241245.1241268351625312M;

            //decimal a = decimal.Parse(Console.ReadLine());
            //decimal b = decimal.Parse(Console.ReadLine());
            //decimal c = a + b;


            //int c = 0x100;

            //char c = '\x48';







            //bool isMale = false;
            //Console.WriteLine("Male or Female");
            //string i = Console.ReadLine();
            //if (i == "Male")
            //{
            //    isMale = true;
            //    Console.WriteLine(isMale);
            //}
            //else
            //{
            //    Console.WriteLine(isMale);
            //}



            //Console.ReadLine();

            //string a = "1";
            //string b = "2";
            //string v = a + b;
            //Console.WriteLine(v);



            //string c = "The \"use\" of quotations causes difficulties.";
            //Console.WriteLine(c);

            //Console.WriteLine(@"                oo     oo         ");
            //Console.WriteLine(@"               o    o    o        ");
            //Console.WriteLine(@"                o       o         ");
            //Console.WriteLine(@"                  o   o           ");
            //Console.WriteLine(@"                    o             ");

            //Console.WriteLine("            ©                                  ");
            //Console.WriteLine("           © ©                                 ");
            //Console.WriteLine("          ©   ©                                ");
            //Console.WriteLine("         ©     ©                               ");
            //Console.WriteLine("        ©       ©                              ");
            //Console.WriteLine("       ©         ©                             ");
            //Console.WriteLine("      ©           ©                            ");
            //Console.WriteLine("     ©             ©                           ");
            //Console.WriteLine("    © © © © © © © © ©                          ");

            Crew crew = new Crew();
            Console.Write("How big is your crew:");
            int number = int.Parse(Console.ReadLine());
            int[] countOfCrew = new int[number];
            foreach (int eachOfTheCrew in countOfCrew)
            {
                Console.Write("Name:");
                crew.Name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Last Name:");

                crew.LastName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Male or female(m/f)");
                crew.Gender = char.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("How old is he/she:");
                crew.Old = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("His Unique number:");
                crew.UniqueNumber = long.Parse(Console.ReadLine());
            }
            string b = crew.Name + crew.LastName + crew.Gender + crew.Old + crew.UniqueNumber;
            for (int i = 0; i < countOfCrew.Length ; i++)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();

          Console.ReadLine();

        }

  class  Crew
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public char Gender { get; set; }
            public int Old { get; set; }
            public long UniqueNumber { get; set; }

        }   







    }
}
