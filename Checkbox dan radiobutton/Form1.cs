using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_dan_radiobutton
{
    public partial class Form1 : Form
    {
        string music,film;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { music = "Pop"; }
            else if (checkBox2.Checked)
            { music = "Jazz"; }
            else { music = "Pop,Jazz"; }
            if (radioButton1.Checked)
            { film = "Action"; }
            else { film = "Komedi"; }
            MessageBox.Show("Anda menyukai musik jenis " + music + " dan film bergenre " + film +"");
        }
    }
}
