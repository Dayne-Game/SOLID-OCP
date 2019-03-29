using System;

namespace test {
    class Program {
        static void Main (string[] args) {
            IUser p1 = new Person ();
            p1.Name = "Dayne";
            //p1.MyRole = "Admin";
            Console.WriteLine ($"{p1.Name} \n");

            IUserMyRole p2 = new Person2 ();
            p2.Name = "Dayne";
            p2.MyRole = "Admin";
            Console.WriteLine ($"{p2.Name} \n");
            Console.WriteLine ($"{p2.MyRole} \n");
        }
    }
}