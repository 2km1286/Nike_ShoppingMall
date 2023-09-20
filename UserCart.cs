using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMSmall
{
    public partial class UserCart : Form
    {
        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu3; uid = edu3; pwd = edukornec!@#");
        
        public UserCart()
        {
            InitializeComponent();
            this.dgvCart.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }
        private void UserCart_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // 현재 날짜 및 시간 불러오기
        }

        public void UserGridview()
        {
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select shoesName, shoesSize, shoesPrice from userSheet where userName = '" + lblUser.Text + "'", sqlcon);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvCart.DataSource = ds.Tables[0];

            sqlcon.Close();
        }


        /// <summary>
        /// GridView 가격 총합계산
        /// </summary>
        public void Cost()
        {
            try
            {
                if (dgvCart.Columns.Count > 0)
                {
                    decimal Total = 0;

                    for (int i = 0; i < dgvCart.Rows.Count; i++)
                    {
                        Total += Convert.ToDecimal(dgvCart.Rows[i].Cells["shoesPrice"].Value);
                    }

                    lblTotalPrice.Text = String.Format("{0:n0}", double.Parse(Total.ToString()));
                }
            }
            catch
            {

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBuy_Click(object sender, EventArgs e)
        {
            DirectBuy directBuy = new DirectBuy();
            directBuy.lblTotalPrice.Text = lblTotalPrice.Text;
            directBuy.txtUser.Text = lblUser.Text;
            directBuy.Show();
            this.Close();
            
        }
    }
}
