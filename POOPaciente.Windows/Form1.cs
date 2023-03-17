using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOPaciente.Datos;
using POOPaciente.Entidades;

namespace POOPaciente.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Repositorio repo = new Repositorio();
        private List<Personas> lista;
        private int cantidad;

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            repo.Guardar();
            DialogResult dr = MessageBox.Show("¿Desea salir del program?", "confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevo frm = new FrmNuevo();
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Personas personas = frm.GetPersona();
            repo.Agregar(personas);
            DataGridViewRow r = costruirFila();
            SetearFila(r, personas, repo);
            AgregarFila(r);
            cantidad = repo.Getcantidad();
            mostrarTotal();
            repo.Guardar();
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dataGridView1.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Personas persona, Repositorio repo)
        {
            r.Cells[colPaciente.Index].Value = persona.MostrarNombre();
            r.Cells[ColCategoria.Index].Value = repo.CategoriaIMC(persona);

            r.Cells[ColSexo.Index].Value = persona.sexo;
            r.Cells[ColEdad.Index].Value = persona.GetSacarEdad().ToString();
            r.Cells[ColAltura.Index].Value = persona.Altura.ToString();
            r.Cells[ColPeso.Index].Value = persona.Peso.ToString();

            r.Tag = persona;
        }

        private DataGridViewRow costruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGridView1);
            return r;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dataGridView1.SelectedRows[0];
            Personas personas = r.Tag as Personas;
            DialogResult dr = MessageBox.Show("¿Desea eliminar a a la persona?", "seleccione", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }

            repo.Borrar(personas);
            dataGridView1.Rows.Remove(r);
            cantidad = repo.Getcantidad();
            repo.Guardar();
            mostrarTotal();
        }

        private void mostrarTotal()
        {
            CantidadtextBox.Text = cantidad.ToString();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dataGridView1.SelectedRows[0];
            Personas personas = r.Tag as Personas;
            FrmNuevo frm = new FrmNuevo();
            frm.SetPersona(personas);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            personas = frm.GetPersona();
            repo.Editar(personas);
            SetearFila(r, personas, repo);
            repo.Guardar();
            MessageBox.Show("la edicion fue realizada");
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            lista = repo.GetLista();
            mostrarlista();
        }

        private void mostrarlista()
        {
            dataGridView1.Rows.Clear();
            foreach (var persona in lista)
            {
                var r = costruirFila();
                SetearFila(r, persona, repo);
                AgregarFila(r);
            }
        }

        private void GuardartoolStripButton1_Click(object sender, EventArgs e)
        {
            ManejadorDeArchivosSecuenciales.GuardarArchivoSecuencial(repo.GetLista());
            MessageBox.Show("se guardaron los datos", "mensaje", MessageBoxButtons.OK);
        }

        private void tsbOrdenar_Click(object sender, EventArgs e)
        {

        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orden = Ordenar.Acendente;
            lista = repo.GetOrden(orden);
            mostrarlista();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orden = Ordenar.Decendente;
            lista = repo.GetOrden(orden);
            mostrarlista();
        }

        private void masculinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filtro = Sexo.Masculino;
            lista = repo.FiltrarLista(filtro);
            mostrarlista();
        }

        private void femeninoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filtro = Sexo.Femenino;
            lista = repo.FiltrarLista(filtro);
            mostrarlista();
        }
    }
}
