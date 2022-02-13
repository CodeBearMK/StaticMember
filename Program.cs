namespace static_member
{
    class Program
    {
        static void Main(string[] args)
        {
            Performer person1 = new Performer();
            person1.Name = "陸一中";
            Console.WriteLine("姓名:{0}", person1.Name);
            Console.WriteLine("第 {0} 位表演者", Performer.Num);
            Console.WriteLine("------------------------------");
            Performer person2 = new Performer("蔡竹男");
            Console.WriteLine("姓名:{0}", person2.Name);
            Console.WriteLine("第 {0} 位表演者", Performer.Num);
            Console.WriteLine("==============================");
            Performer.ShowNum();
            Console.Read();
        }
    }
}