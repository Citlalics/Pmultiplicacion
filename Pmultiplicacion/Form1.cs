using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmultiplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crear elobjeto  
            Multip mcion = new Multip();
            mcion.num1 = int.Parse(txt1.Text);
            mcion.num2 = int.Parse(txt2.Text);

            txtResult.Text = mcion.Multi().ToString();
        }
    }
}
