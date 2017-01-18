using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class AccessUser:IUser
    {
        private SqlConnection conn=null;
        public AccessUser()
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;  //获取配置文件中的连接字符串
            conn = new SqlConnection(connStr);
        }

        #region 新增用户
        /// <summary>
        ///  新增用户
        /// </summary>
        /// <param name="user">用户实体</param>
        public void Insert(User user)
        {

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"insert into login values(@Id,@Name)";
            cmd.Parameters.Add(new SqlParameter("@Id", user.ID));
            cmd.Parameters.Add(new SqlParameter("@Name", user.Name));
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
        public string GetUser(int id)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select Id,Name from login Where Id=@Id";
            cmd.Parameters.Add(new SqlParameter("@Id", id));

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
