using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void imgcal_Click(object sender, EventArgs e)
        {
            CalendarDialog cal = new CalendarDialog();
            cal.StartPosition = FormStartPosition.CenterScreen;
            if (cal.ShowDialog() == DialogResult.OK)
                txtBirthDate.Text = cal.DateSelection.SelectionStart.ToString("dd-MMM-yyyy");

        }
    }
}
