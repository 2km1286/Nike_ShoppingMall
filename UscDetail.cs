using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BMSmall
{
    public partial class UscDetail : UserControl
    {
      
        


        public UscDetail()
        {
            InitializeComponent();
            
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            DirectBuy directBuy = new DirectBuy();
            directBuy.Show();
            directBuy.lblTotalPrice.Hide();
            directBuy.lblTotal.Hide();
        }
    }
 }

