using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class SqlserverDepartment:IDepartment
    {
        private SqlConnection conn=null;
        public SqlserverDepartment()
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;  //获取配置文件中的连接字符串
            conn = new SqlConnection(connStr);
        }

        #region 新增用户
        /// <summary>
        ///  新增用户
        /// </summary>
        /// <param name="user">用户实体</param>
        public void Insert(Department department) 
        {
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"insert into department values(@Id,@Name)";
            cmd.Parameters.Add(new SqlParameter("@Id", department.ID));
            cmd.Parameters.Add(new SqlParameter("@Name", department.Name));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion

        #region  查询用户
        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        public string GetDepartment(int id) 
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select Id,Name from department Where Id=@Id";
            cmd.Parameters.Add(new SqlParameter("@Id",id));

            conn.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();//返回一个dataReader，把cmd查询的结果放到sdr里面
            dt.Load(sdr); //把sdr的内容装到dt里面
            sdr.Close();
            conn.Close();
            string result = Convert.ToString(dt.Rows[0][1]);
            return result;
        }
        #endregion
    }
}
