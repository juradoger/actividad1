using ComputadoraModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComputadoraVistas.ComputadoraVista
{
    public partial class ComputadoraEditarvista : Form
    {
        public ComputadoraEditarvista()
        {
            InitializeComponent();
        }
        int idx = 0;
        Computadora comp = new Computadora();
        ComputadoraBSS.ComputadoraBss bssp = new ComputadoraBSS.ComputadoraBss();
        public ComputadoraEditarvista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        private void ComputadoraEditarvista_Load(object sender, EventArgs e)
        {
            comp = bssp.ObtenerIdBss(idx);
            textBox1.Text = comp.nombre;
            textBox2.Text = comp.descripcion;
            textBox3.Text = Convert.ToString(comp.precio);
            dateTimePicker1.Value = comp.fechafabricacion;
        }
        ComputadoraBSS.ComputadoraBss bss = new ComputadoraBSS.ComputadoraBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Computadora p = new Computadora();
            var x = textBox3.Text;
            p.idcomputadora = idx;
            p.nombre = textBox1.Text;
            p.descripcion = textBox2.Text;
            p.precio = Convert.ToDecimal(textBox3.Text);
            p.fechafabricacion = dateTimePicker1.Value;
            bss.EditarComputadoraBss(p);

            MessageBox.Show("Registro Exitoso!");
        }
    }
}
