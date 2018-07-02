using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL.G
{
    public partial class frm_ACC_Settings : Form
    {
        BL.BL.ACC_Settings a = new BL.BL.ACC_Settings();
        DataTable dt_Level_Set = new DataTable();

        public frm_ACC_Settings()
        {
            InitializeComponent();

            dt_Level_Set = a.Select_Level_Set();
            if (dt_Level_Set.Rows.Count > 0)
            {
                #region Select
                n1.Value = Convert.ToInt16(dt_Level_Set.Rows[0][2]);
                n2.Value = Convert.ToInt16(dt_Level_Set.Rows[1][2]);
                n3.Value = Convert.ToInt16(dt_Level_Set.Rows[2][2]);
                n4.Value = Convert.ToInt16(dt_Level_Set.Rows[3][2]);
                n5.Value = Convert.ToInt16(dt_Level_Set.Rows[4][2]);
                n6.Value = Convert.ToInt16(dt_Level_Set.Rows[5][2]);
                n7.Value = Convert.ToInt16(dt_Level_Set.Rows[6][2]);
                n8.Value = Convert.ToInt16(dt_Level_Set.Rows[7][2]);
                n9.Value = Convert.ToInt16(dt_Level_Set.Rows[8][2]);
                n10.Value = Convert.ToInt16(dt_Level_Set.Rows[9][2]);

                cc1.Value = Convert.ToInt16(dt_Level_Set.Rows[10][2]);
                cc2.Value = Convert.ToInt16(dt_Level_Set.Rows[11][2]);
                cc3.Value = Convert.ToInt16(dt_Level_Set.Rows[12][2]);
                cc4.Value = Convert.ToInt16(dt_Level_Set.Rows[13][2]);
                cc5.Value = Convert.ToInt16(dt_Level_Set.Rows[14][2]);
                cc6.Value = Convert.ToInt16(dt_Level_Set.Rows[15][2]);
                cc7.Value = Convert.ToInt16(dt_Level_Set.Rows[16][2]);
                cc8.Value = Convert.ToInt16(dt_Level_Set.Rows[17][2]);
                cc9.Value = Convert.ToInt16(dt_Level_Set.Rows[18][2]);
                cc10.Value = Convert.ToInt16(dt_Level_Set.Rows[19][2]);

                i1.Value = Convert.ToInt16(dt_Level_Set.Rows[20][2]);
                i2.Value = Convert.ToInt16(dt_Level_Set.Rows[21][2]);
                i3.Value = Convert.ToInt16(dt_Level_Set.Rows[22][2]);
                i4.Value = Convert.ToInt16(dt_Level_Set.Rows[23][2]);
                i5.Value = Convert.ToInt16(dt_Level_Set.Rows[24][2]);
                i6.Value = Convert.ToInt16(dt_Level_Set.Rows[25][2]);
                i7.Value = Convert.ToInt16(dt_Level_Set.Rows[26][2]);
                i8.Value = Convert.ToInt16(dt_Level_Set.Rows[27][2]);
                i9.Value = Convert.ToInt16(dt_Level_Set.Rows[28][2]);
                i10.Value = Convert.ToInt16(dt_Level_Set.Rows[29][2]);

                i21.Value = Convert.ToInt16(dt_Level_Set.Rows[30][2]);
                i22.Value = Convert.ToInt16(dt_Level_Set.Rows[31][2]);
                i23.Value = Convert.ToInt16(dt_Level_Set.Rows[32][2]);
                i24.Value = Convert.ToInt16(dt_Level_Set.Rows[33][2]);
                i25.Value = Convert.ToInt16(dt_Level_Set.Rows[34][2]);
                i26.Value = Convert.ToInt16(dt_Level_Set.Rows[35][2]);
                i27.Value = Convert.ToInt16(dt_Level_Set.Rows[36][2]);
                i28.Value = Convert.ToInt16(dt_Level_Set.Rows[37][2]);
                i29.Value = Convert.ToInt16(dt_Level_Set.Rows[38][2]);
                i210.Value = Convert.ToInt16(dt_Level_Set.Rows[39][2]);
                #endregion
            }
        }

        private void FRM_ACC_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد حفظ التغيرات ؟", "حفظ ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                #region var

                a.n1 = Convert.ToInt16(n1.Value);
                a.n2 = Convert.ToInt16(n2.Value);
                a.n3 = Convert.ToInt16(n3.Value);
                a.n4 = Convert.ToInt16(n4.Value);
                a.n5 = Convert.ToInt16(n5.Value);
                a.n6 = Convert.ToInt16(n6.Value);
                a.n7 = Convert.ToInt16(n7.Value);
                a.n8 = Convert.ToInt16(n8.Value);
                a.n9 = Convert.ToInt16(n9.Value);
                a.n10 = Convert.ToInt16(n10.Value);

                a.cc1 = Convert.ToInt16(cc1.Value);
                a.cc2 = Convert.ToInt16(cc2.Value);
                a.cc3 = Convert.ToInt16(cc3.Value);
                a.cc4 = Convert.ToInt16(cc4.Value);
                a.cc5 = Convert.ToInt16(cc5.Value);
                a.cc6 = Convert.ToInt16(cc6.Value);
                a.cc7 = Convert.ToInt16(cc7.Value);
                a.cc8 = Convert.ToInt16(cc8.Value);
                a.cc9 = Convert.ToInt16(cc9.Value);
                a.cc10 = Convert.ToInt16(cc10.Value);

                a.i1 = Convert.ToInt16(i1.Value);
                a.i2 = Convert.ToInt16(i2.Value);
                a.i3 = Convert.ToInt16(i3.Value);
                a.i4 = Convert.ToInt16(i4.Value);
                a.i5 = Convert.ToInt16(i5.Value);
                a.i6 = Convert.ToInt16(i6.Value);
                a.i7 = Convert.ToInt16(i7.Value);
                a.i8 = Convert.ToInt16(i8.Value);
                a.i9 = Convert.ToInt16(i9.Value);
                a.i10 = Convert.ToInt16(i10.Value);

                a.i21 = Convert.ToInt16(i21.Value);
                a.i22 = Convert.ToInt16(i22.Value);
                a.i23 = Convert.ToInt16(i23.Value);
                a.i24 = Convert.ToInt16(i24.Value);
                a.i25 = Convert.ToInt16(i25.Value);
                a.i26 = Convert.ToInt16(i26.Value);
                a.i27 = Convert.ToInt16(i27.Value);
                a.i28 = Convert.ToInt16(i28.Value);
                a.i29 = Convert.ToInt16(i29.Value);
                a.i210 = Convert.ToInt16(i210.Value);

                #endregion

                a.Update_Level_Set();
            }
        }
    }
}
