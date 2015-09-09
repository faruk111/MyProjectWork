using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.DLL
{
    class MemberGateWay
    {
        public string Insert(MemberModel member)
        {
            string url = @"server=faruk\SQLEXPRESS; database=library; integrated security=true";
            SqlConnection connection = new SqlConnection(url);

            connection.Open();

            string query = string.Format("insert into member_table values ('{0}','{1}','{2}','{3}','{4}','{5}')", member.Id, member.Name, member.Type, member.EntryDate, member.Address, member.Contact);
            SqlCommand command = new SqlCommand(query, connection);


            int affectedrow = command.ExecuteNonQuery();
            if (affectedrow > 0)
                return "successful";
            else
            {
                return "some error";
            }
        }
    }
}
