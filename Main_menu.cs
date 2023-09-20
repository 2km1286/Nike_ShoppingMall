using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MetroSet_UI.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BMSmall
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
            
        }
        
        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public void btnBuy_Click_Event(object sender, EventArgs e)
        {

            Control control = sender as Control;
            TableLayoutPanelCellPosition position = tblShoes.GetPositionFromControl(control);// 컨트롤로 셀 포지션 지정
            UscDetail uscDetail = new UscDetail();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM ShoesInfo", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ShoesDetail shoesdetail = new ShoesDetail();
            
            string stateNow = "재고있음";
            int count = position.Row;
            try
            {
                /*if (count < 9 && dt.Rows[count][4].ToString() == stateSold)
                {

                    shoesdetail.Show();

                    shoesdetail.picBigShoes.Image = Image.FromFile(paths + dt.Rows[count]["Path"].ToString());
                    uscDetail.lblName.Text = dt.Rows[count]["Name"].ToString();
                    uscDetail.lblPrice.Text = dt.Rows[count]["Price"].ToString();
                    uscDetail.lblPrice.Text = String.Format("{0:n0}", double.Parse(uscDetail.lblPrice.Text));
                    uscDetail.btnBuy.BackColor = Color.Gray;
                    uscDetail.btnBuy.Text = "※재고소진※";
                    uscDetail.btnBuy.ForeColor = Color.Gray;
                    uscDetail.btnBuy.Enabled = false;
                    shoesdetail.lblCartUser.Text = lblUser.Text;
                    shoesdetail.txtHidePrice.Text = uscDetail.lblPrice.Text;
                    shoesdetail.txtHideName.Text = uscDetail.lblName.Text;
                    uscDetail.txtDetail.Text = dt.Rows[count]["Detail"].ToString();
                    shoesdetail.panel2.Controls.Add(uscDetail);
                    shoesdetail.checkCart();
                }*/
                if (count < 9 && dt.Rows[count][4].ToString() == stateNow)
                {
                    shoesdetail.Show();
                    shoesdetail.picBigShoes.Image = Image.FromFile(paths + dt.Rows[count]["Path"].ToString());
                    uscDetail.lblName.Text = dt.Rows[count]["Name"].ToString();
                    uscDetail.lblPrice.Text = dt.Rows[count]["Price"].ToString();
                    uscDetail.lblPrice.Text = String.Format("{0:n0}", double.Parse(uscDetail.lblPrice.Text));
                    uscDetail.btnBuy.Text = "즉시 구매하기";
                    uscDetail.lblState.ForeColor = Color.Blue;
                    shoesdetail.panel2.Controls.Add(uscDetail);
                    shoesdetail.lblUser.Text = lblUser.Text;
                    shoesdetail.txtHidePrice.Text = uscDetail.lblPrice.Text;
                    shoesdetail.txtHideName.Text = uscDetail.lblName.Text;
                    uscDetail.txtDetail.Text = dt.Rows[count]["Detail"].ToString();
                    shoesdetail.panel2.Controls.Add(uscDetail);
                    shoesdetail.checkCart();
                    
                }
            }
            catch
            {
                throw;
            }
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            tblShoes.Hide();
            
        }


        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu3; uid = edu3; pwd = edukornec!@#");
        private void lblShop_Click(object sender, EventArgs e)
        {
           
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM ShoesInfo", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
           
            int count = 0;
            count = (int)dt.Rows.Count;
            
            string stateSold = "판매완료";
            string stateNow = "재고있음";
            tblShoes.Show();
            

            try
            {
                for (int i = 0; i <  count; i++)
                {
                    GetShoes getShoes = new GetShoes();
                 
                    getShoes.ClickShoesBuy_Evnet += new EventHandler(btnBuy_Click_Event);
                    /*getShoes.pictureBox1.Image = Image.FromFile(paths + dt.Rows[i]["Path"].ToString());
                    getShoes.lblSname.Text = dt.Rows[i]["Name"].ToString();
                    getShoes.lblPrice.Text = dt.Rows[i]["Price"].ToString();*/
                    if (dt.Rows[i][4].ToString() == stateSold)
                    {
                        getShoes.pictureBox1.Image = Image.FromFile(paths + dt.Rows[i]["Path"].ToString());
                        getShoes.lblSname.Text = dt.Rows[i]["Name"].ToString();
                        getShoes.lblPrice.Text = dt.Rows[i]["Price"].ToString();
                        getShoes.lblPrice.Text = String.Format("{0:n0}", double.Parse(getShoes.lblPrice.Text));
                        getShoes.lblSell.Text = stateSold;
                        getShoes.lblSell.ForeColor = Color.Red;
                        getShoes.btnBuy.Hide();

                        tblShoes.Controls.Add(getShoes);
                    }
                    else if(dt.Rows[i][4].ToString() == stateNow)
                    {
                        getShoes.pictureBox1.Image = Image.FromFile(paths + dt.Rows[i]["Path"].ToString());
                        getShoes.lblSname.Text = dt.Rows[i]["Name"].ToString();
                        getShoes.lblPrice.Text = dt.Rows[i]["Price"].ToString();
                        getShoes.lblPrice.Text = String.Format("{0:n0}", double.Parse(getShoes.lblPrice.Text));
                        getShoes.lblSell.Text = stateNow;
                        getShoes.btnBuy.Text = " 구매하기";
                        getShoes.lblSell.ForeColor = Color.Blue;
                        tblShoes.Controls.Add(getShoes);
                    }

                    /*tblShoes.Controls.Add(getShoes);*/
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /*public void checkCart()
        {
            SqlDataAdapter sda2 = new SqlDataAdapter("select shoesName, shoesSize, shoesPrice from userSheet where userName = '" + lblUser.Text + "'", sqlcon);
            DataTable dt = new DataTable();
            sda2.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                picWarning.Show();

            }
            else
            {
                picWarning.Hide();
            }


        }*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform loginform = new Loginform();
            
            loginform.txtID.Text = "";
            loginform.txtPass.Text = "";
            loginform.Show();
        }

        private void lblSheet_Click(object sender, EventArgs e)
        {
            UserCart userCart = new UserCart();
            
            userCart.Show();
            userCart.lblUser.Text = lblUser.Text;
            userCart.UserGridview();
            userCart.Cost();
        }
    }
}
