using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new FileDifferenceForm();
            form.Owner = this;
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new FileModificationForm();
            form.Owner = this;
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Show();
            }
        }

        
    }
}
