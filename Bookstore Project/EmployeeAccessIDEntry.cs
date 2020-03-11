//Brandon Dorjkhand
//CIS 3309
//Lab Project 2 Bookstore
// 2/19/2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Project
{
    public partial class EmployeeAccessIDEntry : Form
    {
        public EmployeeAccessIDEntry()
        {
            InitializeComponent();
        }
        BookStoreClass bs = new BookStoreClass();


        //code for when user enters access id
        private void btnEnter_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtAccNum.Text);


            if (id > 9999 && id < 100000)
            {
                if (bs.EmployeeList.findEmployeeInList(id))
                {
                    // Record located.  Go to form to allow user to enter pin
                    // Display next form as a dialog box (a modal form)
                    Form PinIDEntryForm = new EmployeePinForm();
                    this.Visible = false;
                    PinIDEntryForm.ShowDialog();
                    this.Close();   // no longer need this form so we can close it
                }
                else
                {
                    MessageBox.Show("ID not Found please re-enter");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a 5 digit number");
            }
       
        }

        private void txtAccNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
