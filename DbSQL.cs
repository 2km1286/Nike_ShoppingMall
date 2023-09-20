 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace BMSmall
{
    public class DbSQL
    {
        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu3; uid = edu3; pwd = edukornec!@#");
        SqlDataAdapter sda; 
        public void Open()
        {
            try
            {
                sqlcon.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            sqlcon.Close();
        }
        public DataSet selectall()
        {
            try
            {
                DataSet ds = new DataSet();

                string query = "select *from userList ";
                sda = new SqlDataAdapter(query, sqlcon);
                sda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    return ds;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
        
        
    }


}
