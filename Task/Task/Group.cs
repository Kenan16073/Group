using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Group:Course
    {
        string _no;
        double _avgpoint;    

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if (value.Length ==4 && char.IsUpper(value[0])
)
                {
                    _no = value;

                }
                else
                {
                    Console.WriteLine("Zehmet olmasa tekrar daxil edin");
                }
            }
        }
        public double Avgpoint
        {
            get
            {
                return _avgpoint;
            }
            set
            {
                if(value<0&&value>100)
                    _avgpoint= value;
            }
        }

       


        


    }
}
