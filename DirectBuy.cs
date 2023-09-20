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
    public partial class DirectBuy : Form
    {
        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu3; uid = edu3; pwd = edukornec!@#");
        public DirectBuy()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            tabCard.Show();
        }

        private void DirectBuy_Load(object sender, EventArgs e)
        {
            tabCard.Hide();
        }

        private void picKakao_Click(object sender, EventArgs e)
        {
            tabCard.Hide();
        }

        private void picPayco_Click(object sender, EventArgs e)
        {
            tabCard.Hide();
        }

        private void picNaver_Click(object sender, EventArgs e)
        {
            tabCard.Hide();
        }

        private void btnRealBuy_Click(object sender, EventArgs e)
        {
            UserCart userCart = new UserCart();
            
            sqlcon.Open();
            string query = "DELETE FROM userSheet WHERE userName LIKE '" +txtUser.Text + "'";   //결제 후 테이블 비움
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("결제가 완료되었습니다. 감사합니다", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userCart.Show();
            this.Close();
        }
    }
}
