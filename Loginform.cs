using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using MetroSet_UI.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMSmall
{

    public partial class Loginform : MetroSetForm
    {
        public Loginform()
        {
            InitializeComponent();
            dbsql.Open();
        }
        
        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu3; uid = edu3; pwd = edukornec!@#");
        public static DbSQL dbsql = new DbSQL();
        public DbSQL db = new DbSQL();
        public DataSet ds = new DataSet();
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoadUserInfo();
            
            if(txtID.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            else 
            {
                CheckID_PW(txtID.Text, txtPass.Text);
            }
        }
        public  void LoadUserInfo()
        {
            ds = db.selectall();
            //데이터베이스에서 사용자 정보 가져오기
        }

        private void CheckID_PW(string id, string pw)
        {
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (id == row["userID"].ToString())
                        {
                            if (pw == row["userPassword"].ToString())
                            {
                                MessageBox.Show("'" + txtID.Text + "'님 반갑습니다", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtID.Text = "";
                                txtPass.Text = "";
                                this.Hide();
                                Main_menu main_Menu = new Main_menu();
                                main_Menu.lblUser.Text = txtID.Text;
                                main_Menu.ShowDialog();

                            }
                            else
                            {
                                MessageBox.Show("비밀번호가 일치하지 않습니다. 확인 후 다시 입력해주세요", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }

                        }
                       
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }   
         
        private void btnAddShoes_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtID.Text == "NIKEADMIN" && txtPass.Text == "NIKE")
                {
                    AddShoes addShoes = new AddShoes();
                    addShoes.ShowDialog();
                }
                else
                {
                    MessageBox.Show("권한이 없는 ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

       
        private void lblJoin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }
    }
}
