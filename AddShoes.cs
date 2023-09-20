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
using System.Xml.Linq;

namespace BMSmall
{
    public partial class AddShoes : Form
    {
       //bulk 쿼리 권한 문제
        private void searchname()
        {
            string query = "select *from ShoesInfo where Name='" + txtSearch.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            SqlCommandBuilder sbd = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        
        public AddShoes()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu3; uid = edu3; pwd = edukornec!@#");

        private void btnAddShoes_Click(object sender, EventArgs e)
        {
            if(txtShoesName.Text == "" || txtShoesPrice.Text == "")
            {
                MessageBox.Show("상품명과 가격을 모두 기입해주세요.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = "C:\\";
                open.Filter = "Image Files (*.png)|*.png|All Files(*.*)|*.*";
                open.FilterIndex = 1;

                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (open.CheckFileExists)
                    {
                        sqlcon.Open();
                        string CorrectFilename = System.IO.Path.GetFileName(open.FileName);
                        SqlCommand command = new SqlCommand("INSERT INTO ShoesInfo (ID,Path,Name,Price,State) VALUES ((Select isnull(Max(ID),0) +1 from ShoesInfo),'\\Images\\" + CorrectFilename + "','"+txtShoesName.Text+"','"+txtShoesPrice.Text+"','재고있음')", sqlcon);
                        command.ExecuteNonQuery();
                        sqlcon.Close();
                        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        System.IO.File.Copy(open.FileName, paths + "\\Images\\" + CorrectFilename);
                        MessageBox.Show("업로드 완료","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void AddShoes_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            string query = "select *from ShoesInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            SqlCommandBuilder sbd = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void ckSold_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSold.Checked)
            {
                txtShoesState.Text = "판매완료";
            }
            else
            {
                txtShoesState.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dataGridView1.AllowUserToAddRows = false;
                string query = "select *from ShoesInfo";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                SqlCommandBuilder sbd = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                searchname();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtUpdateName.Text == "")
            {
                MessageBox.Show("상품명을 입력해주세요" ,"Warnning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {   
                    if(ckRM.Checked || ckSold.Checked)
                    {
                        ShoesDetail shoesDetail = new ShoesDetail();

                        sqlcon.Open();
                        string query = "update ShoesInfo set State ='" + txtShoesState.Text + "',Detail = '" + txtDetail.Text + "'where Name = '" + txtUpdateName.Text + "';";
                        SqlCommand cmd = new SqlCommand(query, sqlcon);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("정상적으로 변경되었습니다", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sqlcon.Close();
                        shoesDetail.populate();
                        
                    }
                    else
                    {
                        MessageBox.Show("제품 상태를 체크해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform loginform = new Loginform();
            loginform.ShowDialog();
        }

        private void ckRM_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRM.Checked)
            {
                txtShoesState.Text = "재고있음";
            }
            else
            {
                txtShoesState.Text = "";
            }
        }
    }
}
