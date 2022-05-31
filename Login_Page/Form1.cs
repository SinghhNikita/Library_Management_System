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

namespace Login_Page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            if(txtUsername.Text=="Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtPassword.Text=="Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void pictureBoxYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC7btqG2Ww0_2LwuQxpvo2HQ");
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/CodeWithHarry");
        }

        private void pictureBoxInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/codewithharry/");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           // if(txtUsername.Text=="Admin" && txtPassword.Text=="Pass")
           // {
              //  new Dashboard().Show();
              //  this.Hide();

                //Response.Redirect("Dashboard.cs");
          //  }
           // else
           // {
               // MessageBox.Show("Invalid username or password");
                //Response.write("Invalid Login Details");
            //}
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI\\SQLEXPRESS01 ; database=library ;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from loginTable where username='" + txtUsername.Text + "' and pass='" + txtPassword.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count !=0)
            {
              this.Hide();
              Dashboard dsa = new Dashboard();
              dsa.Show();
            }
            else
           {
              MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

        }
    }
}
