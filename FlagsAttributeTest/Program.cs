using System;
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

            //bool cancreate = ((Permission.Create & user.Permission) == Permission.Create);
            bool cancreate = user.Permission.HasPermission(Permission.Create);
            bool canread = ((Permission.Read & user.Permission) == Permission.Read);
            bool canupdate = ((Permission.Update & user.Permission) == Permission.Update);
            bool candelete = ((Permission.Delete & user.Permission) == Permission.Delete);

            Console.WriteLine("can create :" + cancreate);
            Console.WriteLine("can read :" + canread);
            Console.WriteLine("can update :" + canupdate);
            Console.WriteLine("can delete :" + candelete);

        }
    }
}
