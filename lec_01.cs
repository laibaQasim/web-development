using System;

namespace lec_01
{
    class std
    {
        private string rollNo;
        private string name;
        private int age;
        public std(int a = 18, string r = "", string n = "")
        {
            Age = a;
            RollNo = r;
            Name = n;
        }
        public int Age
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string RollNo
        {
            get; set;
        }
    }
    class lec_01
    {
        static void Main(string[] args)
        {
            //create an object of class std
            std obj1 = new std(19, "bcsf20m013", "laiba qasim");
            //Console.WriteLine("rollno: " + obj1.RollNo + " name: " + obj1.Name + " age: " + obj1.Age);
            Console.WriteLine(obj1.ToString());
            ////Type casting
            //Console.WriteLine("give age: ");
            //string age_str = Console.ReadLine();
            //int age = Convert.ToInt32(age_str);
            //Console.WriteLine("age you entered is: " + age);

        }
    }
}
