using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaClases
{
    public partial class Form1 : Form
    {
        Cliente cl;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl.ape = textBox1.Text;
            cl.nom = textBox2.Text;
            cl.IdCli = 1;
            label3.Text = cl.ape + cl.nom; 
            
        }

    }
}
