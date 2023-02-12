using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            string opt;
            bool check = true;
            do
            {
                Console.WriteLine("\n1. Qrup elave et");
                Console.WriteLine("2.Bütün qruplara bax");
                Console.WriteLine("3.Verilmis point araligindaki qruplara bax");
                Console.WriteLine("4.Verilmis nömresi qrupa bax");
                Console.WriteLine("5.Verilmis qruplar uzre axtaris et");
                Console.WriteLine("0.Menudan cix");

                Console.WriteLine("\n.Secim edin");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Elave edeceyiniz qrupu daxil edin");
                        var Groups = course.AddGroup();
                        break;
                    case "2":
                        Groups = course.Groups();
                        break;
                    case "3":
                        Groups= course.GetGroupsByPointRange();
                        break;
                    case "4":
                        Groups= course.GetGroupByNo();
                        break;
                    case "5":
                        Groups = course.Search();
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi.");
                        check= false;
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin.");
                        break;
                }
            }
                while (check) ;
        } 
    }
}
