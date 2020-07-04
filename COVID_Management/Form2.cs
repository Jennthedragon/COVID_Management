using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(covidCheckedListBox.SelectedItems.Count > 0)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Close();
            }
            else
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Close();
            }



        }
    }
}
