using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection; //要引入反射，必须要添加的命名空间
using System.Configuration;

namespace WindowsFormsApplication1
{
    class DataAccess
    {
        //#region 未加入反射的情况 
        //private static readonly string db = "Sqlserver"; //数据库名称可替换成Access

        //public static IUser CreateUser()
        //{
        //    IUser result = null;
        //    switch (db)   //由于db的事先设置，所以此处可以根据选择实例化出响应的对象
        //    { 
        //        case "Sqlserver":
        //            result = new SqlserverUser();
        //            break;
        //        case "Access":
        //            result = new AccessUser();
        //            break;
        //    }
        //    return result;
        //}

        //public static IDepartment CreateDepartment()
        //{
        //    IDepartment result = null;
        //    switch (db)
        //    { 
        //        case "SqlServer":
        //            result = new SqlserverDepartment();
        //            break;
        //        case "Access":
        //            result = new AccessDepartment();
        //            break;
        //    }
        //    return result;
        //}
        //#endregion

        private static readonly string AssemblyName = "WindowsFormsApplication1"; //程序集名称，即这个类所在的根文件名称
        //private static readonly string db = "Sqlserver"; //数据库名称，可以替换成Access
        private static readonly string db=ConfigurationManager.AppSettings["DB"];

        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
