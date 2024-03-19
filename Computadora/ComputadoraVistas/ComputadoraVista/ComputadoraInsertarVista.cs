using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputadoraBss;
using ComputadoraDAL;
using ComputadoraModelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComputadoraVistas.ComputadoraVista
{
    public partial class ComputadoraInsertarVista : Form
    {

        public ComputadoraInsertarVista()
        {
            InitializeComponent();
        }
       
        private void ComputadoraInsertarVista_Load(object sender, EventArgs e)
        {

        }
        ComputadoraBSS.ComputadoraBss bss = new ComputadoraBSS.ComputadoraBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Computadora p = new Computadora();
            p.nombre = textBox1.Text;
            p.descripcion = textBox2.Text;
            p.precio = Convert.ToInt32(textBox3.Text);
            p.fechafabricacion = dateTimePicker1.Value;
            bss.InsertarComputadoraBss(p);

            MessageBox.Show("Registro Exitoso!");
        }
    }
}
