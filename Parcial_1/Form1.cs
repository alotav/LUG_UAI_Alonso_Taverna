using BLL;
using Entity;

namespace Parcial_1
{
    public partial class Form1 : Form
    {
        private TipoDeportesBusiness tipoDeportesBusiness = new TipoDeportesBusiness();
        private Entrada entrada = new Entrada();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.ModificarMarcador(Convert.ToInt32(tbModif.Text), Convert.ToInt32(tbMarcadorLocal.Text), Convert.ToInt32(tbMarcadorVis.Text));

            actualizarDgv();
            MessageBox.Show("Los marcadores fueron modificados.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.eliminarPartido(Convert.ToInt32(tbIdPartido.Text));
            actualizarDgv();
            MessageBox.Show("Partido eliminado exitosamente");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDgv();
            comboDeportes.DataSource = null;
            comboDeportes.DataSource = tipoDeportesBusiness.getAll();
            comboDeportes.ValueMember = "IdDeporte";
            comboDeportes.DisplayMember = "Descripcion";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Partido partido = new Partido();
                partido.Deporte = new Deporte();
                partido.Deporte.IdDeporte = (comboDeportes.SelectedItem as Deporte).IdDeporte;

                partido.EquipoLocal = tbEquipoLocal.Text;
                partido.EquipoVisitante = tbEquipoVisitante.Text;
                partido.FechaRegistro = DateTime.Now;
                partido.FechaPartido = dtpFechaPartido.Value;
                partido.MarcadorLocal = 0;
                partido.MarcadorVisitante = 0;

                entrada.guardarEntrada(partido);

                actualizarDgv();
                MessageBox.Show("Partido cargado correctamente");
                //MessageBox.Show(Convert.ToString(comboDeportes.SelectedIndex));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void actualizarDgv()
        {
            dgvPartidos.DataSource = null;
            dgvPartidos.DataSource = entrada.getAll();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboDeportes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
