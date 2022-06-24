using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bank_dbEntities1 dbe = new bank_dbEntities1();
            if(usrtxt.Text !=String.Empty || passtext.Text != String.Empty)
            {
                var user1 = dbe.Admin_table.FirstOrDefault(a => a.Username.Equals(usrtxt.Text));
                if(user1 != null)
                {
                     if(user1.Password.Equals(passtext.Text))
                    {
                        Menu m1 = new Menu();
                        m1.ShowDialog();
                    }
                     else
                    {
                        MessageBox.Show("Password incorrect");
                    }


                } else
                {
                    MessageBox.Show("null value");
                }


            }  
            else
            {
                MessageBox.Show("entrer le nom d'utilisateur et le moss de pass");
            }
        }
    }
}
