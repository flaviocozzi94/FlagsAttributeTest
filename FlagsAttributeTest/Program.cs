using System;
using System.Linq;
using static FlagsAttributeTest.Enumerator;

namespace FlagsAttributeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User user = new User();
            user.Permission = Permission.Create | Permission.Delete;
            Console.WriteLine(user.Permission);

            //  Ivan Code
            int sumOfInt = 10;
            string binary = Convert.ToString(sumOfInt, 2);
            var listOfInts = binary
                .Select((v, i) => Int32.Parse(v.ToString()) * Math.Pow(2, binary.Length - 1 - i))
                .Where(x => x > 0)
                .OrderBy(x => x);

            var permissions = listOfInts.Select(x => (Permission)x).ToList();
            // end of Ivan code

            bool cancreate = user.Permission.HasPermission(Permission.Create);

            //metodo alternativo per verificare la presenza di un permesso
            //bool canread = ((Permission.Read & user.Permission) == Permission.Read);
            bool canread = user.Permission.HasPermission(Permission.Read);

            bool canupdate = user.Permission.HasPermission(Permission.Update);

            bool candelete = user.Permission.HasPermission(Permission.Delete);

            Console.WriteLine("can create :" + cancreate);
            Console.WriteLine("can read :" + canread);
            Console.WriteLine("can update :" + canupdate);
            Console.WriteLine("can delete :" + candelete);

        }
    }
}
