using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGM_Management_System
{
    public partial class frm_View_Student_Details : Form
    {
        public frm_View_Student_Details()
        {
            InitializeComponent();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Do You Want To LogOut", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                frm_Student_Login Obj = new frm_Student_Login();
                Obj.Show();
                this.Hide();
            }
        }

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_S_SGM_Mgt_System_dbDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this._S_SGM_Mgt_System_dbDataSet1.Student_Details);

        }

        private void btn_Add_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details Obj = new frm_Add_Student_Details();
            Obj.Show();
            this.Hide();
        }
    }
}
