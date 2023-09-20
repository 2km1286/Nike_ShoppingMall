using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static BMSmall.UscDetail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BMSmall
{
    public partial class ShoesDetail : Form
    {

        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu3; uid = edu3; pwd = edukornec!@#");
        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        UscDetail usc = new UscDetail();

        public ShoesDetail()
        {
            InitializeComponent();

            foreach (PictureBox item in this.tblAllshoes.Controls)
            {
                item.Click += Item_CheckedChanged;
            }

           //usc.selectsize += new EventHandler(Hidecb);
        }


        private void lblTossCart_Click(object sender, EventArgs e)
        {
            if (txtHidePrice.Text == "" || txtHideName.Text == "" || txtHideSize.Text == "")
            {
                MessageBox.Show("상품과 사이즈를 선택해주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(picWarning.Visible == false)
                {
                    insertCart();
                    populate();
                    Cost();
                }
                else
                {
                    MessageBox.Show("내역을 먼저 불러와주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
        }


        /*   private void Hidecb(object sender, EventArgs e)
           {
             string sizetext = ((UscDetail.selectsizeclass)e).shoesize;
             txtHideSize.Text = sizetext;
           }*/
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
    /*    private void udateUserCart()
        {
            sqlcon.Open();
            //,shoesName = '" + txtHideName.Text + "',shoesSize = '"+txtHideSize.Text+ "',shoesPrice = '"+txtHidePrice.Text+"'
            string query = "update userList set Price ='" + lblTotalPrice.Text + "'where userID = '" + lblCartUser.Text + "'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }*/


        /// <summary>
        /// 해당 row정보 Table에 insert
        /// </summary>
        private void insertCart()
        {
            sqlcon.Open();
            string query = "insert into userSheet values ('" + lblUser.Text + "','" + txtHideName.Text + "','" + txtHideSize.Text + "','" + txtHidePrice.Text + "')";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }




       /* private void passRow(string name, string price,string size)
        {
            String[] row = { name,price,size};
            dgvCart.Rows.Add(row);
        }*/

     
        private void Item_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            picBigShoes.Image = (sender as PictureBox).Image;

           
            int count = matchBox();
           
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM ShoesInfo", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            UscDetail usc = new UscDetail();
            string stateSold = "판매완료";
            string stateNow = "재고있음";
            if (count < 9 && dt.Rows[count][4].ToString() == stateSold)
            {
                
                usc.lblName.Text = dt.Rows[count]["Name"].ToString();
                usc.lblPrice.Text = dt.Rows[count]["Price"].ToString();
                usc.lblPrice.Text = String.Format("{0:n0}", double.Parse(usc.lblPrice.Text));
                usc.lblState.Text = stateSold;
                usc.lblState.ForeColor = Color.Red;
                txtHidePrice.Text = usc.lblPrice.Text;
                txtHideName.Text = usc.lblName.Text;
                
                usc.txtDetail.Text = dt.Rows[count]["Detail"].ToString();
                usc.btnBuy.BackColor = Color.Gray;
                usc.btnBuy.Text = "※재고소진";
                usc.btnBuy.ForeColor = Color.Gray;
                usc.btnBuy.Enabled = false;
                lblTossCart.Hide();
                picCart.Hide();
                lblSize.Hide();
                cbSize.Hide();
                
                

                panel2.Controls.Add(usc);
                
            }
            else if(count < 9 && dt.Rows[count][4].ToString() == stateNow)
            {
                usc.lblName.Text = dt.Rows[count]["Name"].ToString();
                usc.lblPrice.Text = dt.Rows[count]["Price"].ToString();
                usc.lblPrice.Text = String.Format("{0:n0}", double.Parse(usc.lblPrice.Text));
                usc.lblState.Text = stateNow;
                usc.lblState.ForeColor = Color.Blue;
                txtHidePrice.Text = usc.lblPrice.Text;
                txtHideName.Text = usc.lblName.Text;
                
                
                usc.txtDetail.Text = dt.Rows[count]["Detail"].ToString();
                lblTossCart.Show();
                picCart.Show();
                lblSize.Show();
                cbSize.Show();

                panel2.Controls.Add(usc);
            }

        }

        /// <summary>
        /// 실시간 gridview 반영 위해 populate
        /// </summary>
        public void populate()
        {

            SqlDataAdapter sda2 = new SqlDataAdapter("select shoesName, shoesSize, shoesPrice from userSheet where userName = '" + lblUser.Text + "'", sqlcon);
            DataSet ds = new DataSet();
            sda2.Fill(ds);
           
            dgvCart.DataSource = ds.Tables[0];

        }





        public int matchBox()
        {
            if (picBigShoes.Image == picLogo1.Image)
            {
                
                return  0;
            }
            if (picBigShoes.Image == picLogo2.Image)
            {
                
                return 1;
            }
            if (picBigShoes.Image == picLogo3.Image)
            {
                
                return 2;
            }
            if (picBigShoes.Image == picLogo4.Image)
            {
               
                return 3;
            }
            if (picBigShoes.Image == picLogo5.Image)
            {
                
                return 4;
            }
            if (picBigShoes.Image == picLogo6.Image)
            {
                
                return 5;
            }
            if (picBigShoes.Image == picLogo7.Image)
            {
                
                return 6;
            }
            else
            {
               
                return 7;
            }
        }
        public void piclogoList()
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM ShoesInfo", sqlcon);
            DataTable dt = new DataTable();
            UscDetail uscDetail = new UscDetail();
            sda.Fill(dt);

            picLogo1.Image = Image.FromFile(paths + dt.Rows[0]["Path"].ToString());
            picLogo2.Image = Image.FromFile(paths + dt.Rows[1]["Path"].ToString());
            picLogo3.Image = Image.FromFile(paths + dt.Rows[2]["Path"].ToString());
            picLogo4.Image = Image.FromFile(paths + dt.Rows[3]["Path"].ToString());
            picLogo5.Image = Image.FromFile(paths + dt.Rows[4]["Path"].ToString());
            picLogo6.Image = Image.FromFile(paths + dt.Rows[5]["Path"].ToString());
            picLogo7.Image = Image.FromFile(paths + dt.Rows[6]["Path"].ToString());
            picLogo8.Image = Image.FromFile(paths + dt.Rows[7]["Path"].ToString());
            /* if(checkBox1.Checked == true) ----->안됨
             {
                 uscDetail.picShoes.Image = Image.FromFile(paths + dt.Rows[0]["Path"].ToString());
                 panel2.Controls.Add(uscDetail);
             }*/

        }


        /// <summary>
        /// '!' 표시 카트내용 유무
        /// </summary>
        public void checkCart()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select shoesName, shoesSize, shoesPrice from userSheet where userName = '"+lblUser.Text+"'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            

            if(dt.Rows.Count > 0)
            {
                picWarning.Visible =true;
            }
            else
            {
                picWarning.Visible=false;
            }
        }

        public void ShoesDetail_Load(object sender, EventArgs e)
        {
           // DataTable dataTable = new DataTable();  
            piclogoList();
            /* dataTable.Columns.Add("제품명",typeof(string));
             dataTable.Columns.Add("가격", typeof(int));
             dgvCart.DataSource = dataTable;*/
        }
       

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 장바구니 담기버튼 색변화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTossCart_MouseEnter(object sender, EventArgs e)
        {
            lblTossCart.BackColor = Color.Wheat;
            picCart.BackColor = Color.Wheat;
        }

        private void lblTossCart_MouseLeave(object sender, EventArgs e)
        {
            lblTossCart.BackColor = Color.Silver;
            picCart.BackColor = Color.Silver;
        }



        private void lblReset_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("장바구니가 모두 비워집니다", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes) //선택 시 비워지는 옵션
            {
                ((DataTable) dgvCart.DataSource).Clear();
                lblTotalPrice.Text = "0";
                sqlcon.Open();
                string query = "DELETE FROM userSheet WHERE userName LIKE '" + lblUser.Text + "'";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            else
            {
                
            }
        
        
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHideSize.Text = cbSize.Text; //visible =  false 박스
        }


        /// <summary>
        /// 내역 불러오기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserCart_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("select shoesName, shoesSize, shoesPrice from userSheet where userName = '" + lblUser.Text + "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 1) 
            {
                MessageBox.Show("불러올 내역이 없습니다", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dgvCart.DataSource = ds.Tables[0];

                Cost();
                picWarning.Hide();
            }


        }

        /// <summary>
        /// '!'의 유무의 따른 예외 처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblBuy_Click(object sender, EventArgs e)
        {

            if (picWarning.Visible == true)
            {
                MessageBox.Show("내역을 먼저 불러와주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("select shoesName, shoesSize, shoesPrice from userSheet where userName = '" + lblUser.Text + "'", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("내역이 없습니다.장바구니에 담아주세요", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UserCart userCart = new UserCart();
                    userCart.Show();
                    userCart.lblUser.Text = lblUser.Text;
                    userCart.UserGridview();
                    userCart.Cost();
                }
               
            }
        }
    }
}
    

