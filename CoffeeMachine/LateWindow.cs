using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMachine
{
    public partial class LateWindow : Form
    {
        //Form1 mo1 = new Form1();
        public LateWindow()
        {
            InitializeComponent();
        }

        private bool okButton = false;
        public bool OKButtonClicked
        {
            get { return okButton; }
        }

        public void ok_Click(object sender, EventArgs e)
        {

            okButton = true;
            this.Close();
        }

        private void nook_Click(object sender, EventArgs e)
        {
            okButton = false;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LateWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
