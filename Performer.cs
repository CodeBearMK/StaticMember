using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_member
{
    internal class Performer
    {
        public string Name { get; set; }
        private static int num;
        public static int Num
        {
            get { return num; }
        }
        public Performer()
        {
            num++;
        }
        public Performer(string vname)
        {
            Name = vname;
            num++;
        }
        public static void ShowNum()
        {
            Console.WriteLine("目前出場總人數: {0} 人", Num);
        }
    }
}
