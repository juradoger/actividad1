using ComputadoraBSS;
using ComputadoraVistas;
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
using ComputadoraBss;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComputadoraVistas.ComputadoraVista
{
    public partial class ComputadoraListarVista : Form
    {
        public ComputadoraListarVista()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        ComputadoraBSS.ComputadoraBss bssp = new ComputadoraBSS.ComputadoraBss();
        private void ComputadoraListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bssp.ListarComputadorasBss();
        }
        public static int IdPersonaSeleccionada = 0;
        ComputadoraBSS.ComputadoraBss bss = new ComputadoraBSS.ComputadoraBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ComputadoraListarVista fr = new ComputadoraListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Computadora persona = bss.ObtenerIdBss(IdPersonaSeleccionada);

            }
        }
        ComputadoraBSS.ComputadoraBss bssz = new ComputadoraBSS.ComputadoraBss();
        private void button2_Click(object sender, EventArgs e)
        {
            int IdComputadoraSelecciionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta persona?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarCompBss(IdComputadoraSelecciionada);
                dataGridView1.DataSource = bssz.ListarComputadorasBss();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComputadoraInsertarVista fr = new ComputadoraInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarComputadorasBss();
            }
        }
    }
}
