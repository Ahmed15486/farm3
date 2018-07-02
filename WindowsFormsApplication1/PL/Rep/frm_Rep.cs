using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL.Rep
{
    public partial class frm_Rep : Form
    {
        public frm_Rep()
        {
            InitializeComponent();
        }

        private void btn_Items_Rep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_Items";
            rep.Rep_TABLE_SCHEMA = "dbo";

            
            rep.Show();
        }

        private void btn_IO_rep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_IO";
            rep.Rep_TABLE_SCHEMA = "dbo";

            
            rep.Show();
        }

        private void btn_Ven_rep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_Ven";
            rep.Rep_TABLE_SCHEMA = "dbo";

            
            rep.Show();
        }

        private void btn_Cust_rep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_Cust";
            rep.Rep_TABLE_SCHEMA = "dbo";

            
            rep.Show();
        }

        private void btn_Pur_rep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_Pur";
            rep.Rep_TABLE_SCHEMA = "dbo";

            
            rep.Show();
        }

        private void btn_Pur_D_rep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_PurD";
            rep.Rep_TABLE_SCHEMA = "dbo";

            
            rep.Show();
        }

        private void btn_Sal_rep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_Sal";
            rep.Rep_TABLE_SCHEMA = "dbo";

            
            rep.Show();
        }

        private void btn_Sal_D_rep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_SalD";
            rep.Rep_TABLE_SCHEMA = "dbo";

            
            rep.Show();
        }

        private void btn_Money_In_rep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_PayIn";
            rep.Rep_TABLE_SCHEMA = "dbo";

            
            rep.Show();
        }

        private void btn_Money_Out_rep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_PayOut";
            rep.Rep_TABLE_SCHEMA = "dbo";

            
            rep.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_Products";
            rep.Rep_TABLE_SCHEMA = "dbo";
                  
            rep.Show();
        }

        private void btn_SWRep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_SW";
            rep.Rep_TABLE_SCHEMA = "dbo";
            
            rep.Show();
        }

        private void btn_SWDRep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_SWD";
            rep.Rep_TABLE_SCHEMA = "dbo";

            
            rep.Show();
        }

        private void btn_ItemsDeathRep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_ProductsDeath";
            rep.Rep_TABLE_SCHEMA = "dbo";
         
            rep.Show();
        }

        private void btn_Sold_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_RepDes rep = new frm_RepDes();
            rep.Rep_TABLE_NAME = "viw_ProductsSold";
            rep.Rep_TABLE_SCHEMA = "dbo";

            rep.Show();
        }
    }
}
