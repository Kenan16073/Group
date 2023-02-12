using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Versioning;
using System.Text;
using System.Text.RegularExpressions;

namespace Task
{
    internal class Course
    {
        public Group[] group=new Group[0];
        public Group[] AddGroup()
        {
            string no=Console.ReadLine();

            Console.WriteLine("Qrupun ortalama balini daxil edin.");
            double avgpoint=Convert.ToDouble(Console.ReadLine());

            Group NewGroup = new Group()
            {
                No = no,
                Avgpoint = avgpoint
            };
            Array.Resize(ref group,group.Length+1);
            group[group.Length - 1] = NewGroup;
            return group;
        }
        public Group[] Groups()
        {
            Group[] AllGroups= new Group[0];
           
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine($"Group:{group[i].No}");
                Console.WriteLine($"AvgPoint:{group[i].Avgpoint}\n");
            }
            return AllGroups;
        } 
        public Group[] GetGroupsByPointRange()
        {
            Group[] GetGroups= new Group[0];
            Console.WriteLine("MinPoint daxil edin.");
            double min=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("MaxPoint daxil edin.");
            double max = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < group.Length; i++)
            {
                if (group[i].Avgpoint >= min && group[i].Avgpoint<= max)
                {
                    Console.WriteLine($"Group:{group[i].No}");
                    Console.WriteLine($"AvgPoint:{group[i].Avgpoint}\n");
                }
            }
            return GetGroups;
        }
        public Group[] GetGroupByNo()
        {
            Group[] Findagroup = new Group[0];
            Console.WriteLine("Qrup nomresi daxil edin.");
            string groupno = Console.ReadLine();

            for (int i = 0; i < group.Length; i++)
            {
                if (group[i].No == groupno)
                {
                    Console.WriteLine($"Group:{group[i].No}");
                    Console.WriteLine($"AvgPoint:{group[i].Avgpoint}\n");
                }
                else
                {
                    Console.WriteLine("Axtardiginiz qrup yoxdur.");
                }
            }
            return Findagroup;
        }
        public Group[] Search()
        {
            Group[] GroupShow = new Group[0];
            Console.WriteLine("Axtardiginiz qrupun her hansisa simvolun daxil.");
            string str=Console.ReadLine();

            for (int i = 0; i < group.Length; i++)
            {
                if (group[i].No.Contains(str))
                {
                    Console.WriteLine($"Group:{group[i].No}");
                    Console.WriteLine($"AvgPoint:{group[i].Avgpoint}\n");
                }
                else
                {
                    Console.WriteLine("Axtardiginiz qrup yoxdur.");
                }
            }
            return GroupShow;
        }
    }
}
