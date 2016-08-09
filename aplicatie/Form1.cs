using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicatie
{
    public partial class Form1 : Form
    {

        public List<User> listOfUsers = new List<User>();
        public Form1()
        {
            InitializeComponent();
            listOfUsers.Add(new WindowsUser(1, "Oana", "parola"));
            listOfUsers.Add(new FacebookUser(2, "Simona", "parola"));
            listOfUsers.Add(new TemporaryUser(3, "Denisa", "parola"));
            listOfUsers.Add(new WindowsUser(4, "Teodor", "parola"));
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Required field!");
            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Required field!");
            }
            else {
                foreach (var u in listOfUsers) {
                    if (u.userName.Equals(textBox1.Text)) {
                        if (u.password.Equals(textBox2.Text))
                        {
                            if (u is WindowsUser)
                            {
                                MessageBox.Show("windows user");
                            }
                            else if (u is FacebookUser)
                            {
                                MessageBox.Show("facebook user");
                            }
                            else if (u is TemporaryUser) {
                                MessageBox.Show("temporary user");
                            }else
                            {
                                MessageBox.Show("user inexistent");
                            }
                            
                        
                        }
                    }
                }
            }
        }
    }
}
