using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BMSmall
{
    public partial class AddUser : Form
    {
        
        public DbSQL db = new DbSQL();
        public DataSet ds = new DataSet();
        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu3; uid = edu3; pwd = edukornec!@#");

        public AddUser()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform loginform = new Loginform();
            loginform.ShowDialog();
        }

        private void lblAddCom_Click(object sender, EventArgs e)
        {
            if (btnCheck.Text != "사용가능")
            {
                MessageBox.Show("아이디 중복확인을 해주세요","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtUserID.Text == "" || txtUserPW.Text==""||txtUserPW2.Text=="")
            {
                MessageBox.Show("정보를 모두 입력해주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUserPW.Text != txtUserPW2.Text)
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다. 확인 후 다시 입력해주세요.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("insert into userList values(@Uid,@Upw)", sqlcon);
                cmd.Parameters.AddWithValue("@Uid", txtUserID.Text);
                cmd.Parameters.AddWithValue("@Upw", txtUserPW.Text);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                //ds = db.selectall();
                MessageBox.Show("회원가입을 완료했습니다. 등록한 아이디로 로그인 해주세요.","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserID.Text = "";
                txtUserPW.Text = "";
                txtUserPW2.Text = "";
                this.Hide();

                Loginform loginform = new Loginform();
                loginform.ShowDialog();
                
            }
            

        }
        private bool isValidID(string Text)
        {
            ds = db.selectall();
           
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (Text == row["userID"].ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(txtUserID.Text =="")
            {
                MessageBox.Show("아이디를 입력해주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (!isValidID(txtUserID.Text))
                {
                    MessageBox.Show("이미 존재하는 아이디 입니다", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    btnCheck.Text = "사용가능";
                    
                    MessageBox.Show("사용가능한 아이디 입니다","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
