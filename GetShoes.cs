using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMSmall
{
    public partial class GetShoes : UserControl
    {
        
        public event EventHandler ClickShoesBuy_Evnet;
        
        public GetShoes()
        {
            InitializeComponent();
            
            btnBuy.Click += btnBuy_Click_Event;
            
        }

    

        private void btnBuy_Click_Event(object sender, EventArgs e)
        {
            if(this.ClickShoesBuy_Evnet != null)
            {
                this.ClickShoesBuy_Evnet(this, e);
            }

        }
    }
}
