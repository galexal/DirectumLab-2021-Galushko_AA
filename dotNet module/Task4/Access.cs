using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Access
    {
        [Flags, Serializable]
        public enum AccessRights : byte
        {
            View = 1,
            Run = 2,
            Add = 4,
            Edit = 8,
            Ratify = 16,
            Delete = 32,
            AccessDenied = 64
        }

        public static void PrintAccessRights(AccessRights accessRights)
        {
            Console.WriteLine(accessRights.HasFlag(AccessRights.AccessDenied)
                ? AccessRights.AccessDenied : accessRights);
        }

        public static string GetAccessRights(AccessRights accessRights)
        {
            return (accessRights.HasFlag(AccessRights.AccessDenied)
                ? AccessRights.AccessDenied : accessRights).ToString();
        }
    }
}
