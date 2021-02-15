using System;
using System.Collections.Generic;
using System.Text;

namespace FlagsAttributeTest
{
    //[Flags]
    //public enum Permission
    //{
    //    None = 0,
    //    Create = 1,
    //    Read = 2,
    //    Update = 4,
    //    Delete = 8
    //}

    public static class Enumerator
    {
        [Flags]
        public enum Permission
        {
            None = 0,
            Create = 1,
            Read = 2,
            Update = 4,
            Delete = 8
        }

        //checks if the value contains the provided type
        public static bool HasPermission<T>(this System.Enum type, T value)
        {
            try
            {
                return (((int)(object)type & (int)(object)value) == (int)(object)value);
            }
            catch
            {
                return false;
            }
        }
    }
}
