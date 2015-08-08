using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace  BarcodeGenarator
{

    public static class LoggedClientProfile
    {
        public static int UserProfileID { get; set; }
        public static int UserPCID { get; set; }
        public static string UserPCName { get; set; }
        public static string UserName { get; set; }
        public static string UserFullName { get; set; }
        public static int EmployeeID { get; set; }
        public static bool? IsManager { get; set; }
        public static bool LoginSuccess { get; set; }
    }
}
