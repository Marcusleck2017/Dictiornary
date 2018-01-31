using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> prefixes = new Dictionary<string, double>()
        {
            {"nm", 1e-9 },
            {"µm", 1e-6 },
            {"mm", 1e-3 },
            {"cm", 1e-2 },
            {"m", 1 },
            {"km", 1e3 },
            { "Mm", 1e6 },
            {"Gm", 1e9 }
        };

        public Form1()
        {
            InitializeComponent();
            foreach (string k in prefixes.Keys)
            {
                comboBox1.Items.Add(k);
                comboBox2.Items.Add(k);
            }
            comboBox1.SelectedIndex = 4;
            comboBox2.SelectedIndex = 4;
            update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
