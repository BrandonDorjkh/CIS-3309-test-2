//Brandon Dorjkhand
//CIS 3309
//Lab Project 2 Bookstore
// 2/19/2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Project
{
    public partial class EmployeePinForm : Form
    {
        public EmployeePinForm()
        {
            InitializeComponent();
        }
        BookStoreClass bs = new BookStoreClass();
        private void txtPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int pin = Int32.Parse(txtPin.Text);
            for (int i = 0; i < 3; i++)
            {
                if (bs.EmployeeList.verifyPin(pin))
                {

                }
            }
        }
    }
}
