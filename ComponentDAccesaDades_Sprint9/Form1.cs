using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioteclaDeClases;

namespace ComponentDAccesaDades_Sprint9
{
    public partial class Form1 : Form
    {
        Class1 bdc = new Class1();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            bdc.Connectar();
            dtgMain.DataSource = bdc.PortarTaula("Species");
        }
    }
}
