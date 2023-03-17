using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOPaciente.Entidades;

namespace POOPaciente.Windows
{
    public partial class FrmNuevo : Form
    {
        public FrmNuevo()
        {
            InitializeComponent();
        }

        private void FrmNuevo_Load(object sender, EventArgs e)
        {

        }
        private bool Edicion = false;
        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
            if (personas!=null)
            {
                Edicion = true;
                PrimerNombretextbox.Text = personas.PrimerNombre;
                SegundoNombretextbox.Text = personas.SegundoNombre;
                ApellidotextBox.Text = personas.Apellido;
                Documentotextbox.Text = personas.Documento.ToString();
                Documentotextbox.Enabled = false;
                if (personas.sexo==Sexo.Masculino)
                {
                    MasculinoradioButton.Checked = true;
                }
                else
                {
                    FemeninoradioButton.Checked = true;
                }

                FechadateTimePicker.Value = personas.Edad;
                PesotextBox.Text = personas.Peso.ToString();
                AlturatextBox.Text = personas.Altura.ToString();

            }
        }
        private Personas personas;

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (validardatos())
            {
                if (personas == null)
                {
                    personas = new Personas();
                }
                personas.PrimerNombre = PrimerNombretextbox.Text;
                personas.SegundoNombre = SegundoNombretextbox.Text;
                personas.Apellido = ApellidotextBox.Text;
                personas.Documento = long.Parse(Documentotextbox.Text);

                personas.sexo = FemeninoradioButton.Checked ? Sexo.Femenino : Sexo.Masculino;
                personas.Edad = FechadateTimePicker.Value.Date;
                personas.Altura = double.Parse(AlturatextBox.Text);
                personas.Peso = double.Parse(PesotextBox.Text);

                DialogResult = DialogResult.OK;
            }
        }

        internal Personas GetPersona()
        {
            return personas;
        }

        private bool validardatos()
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrEmpty(PrimerNombretextbox.Text))
            {
                valido = false;
                errorProvider1.SetError(PrimerNombretextbox, "los datos tiene que ser un string (caracter)");
            }
            else if (int.TryParse(PrimerNombretextbox.Text, out int PrimerNombre))
            {
                valido = false;
                errorProvider1.SetError(PrimerNombretextbox, "los datos tienen que ser un caracter");

            }


            if (int.TryParse(SegundoNombretextbox.Text, out int SegundoNombre))
            {
                valido = false;
                errorProvider1.SetError(SegundoNombretextbox, "los datos tienen que ser un caracter");
            }


            if (string.IsNullOrEmpty(ApellidotextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(ApellidotextBox, "los datos tiene que ser un caracter");
            }
            else if (int.TryParse(ApellidotextBox.Text, out int Apellido))
            {
                valido = false;
                errorProvider1.SetError(ApellidotextBox, "los datos tiene que ser un caracter");
            }

            if (!Edicion)
            {
                if (!long.TryParse(Documentotextbox.Text, out long Documento))
                {
                    valido = false;
                    errorProvider1.SetError(Documentotextbox, "el documneto esta mal ingresado");

                }

                else if (Documento < Documentotextbox.MaxLength)
                {
                    valido = false;
                    errorProvider1.SetError(Documentotextbox, "el documento debe tener menos de 9 valores");
                } 
            }
            if (FechadateTimePicker.Value.Date > DateTime.Now.Date)
            {
                valido = false;
                errorProvider1.SetError(FechadateTimePicker, "la fecha no es valida");
            }
            else if (string.IsNullOrEmpty(PesotextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(PesotextBox, "los datos tiene que ser caracter ");
            }
            if (!int.TryParse(PesotextBox.Text, out int Peso))
            {
                valido = false;
                errorProvider1.SetError(PesotextBox, "los datos tiene que ser un caracter ");

            }
            else if (string.IsNullOrEmpty(AlturatextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(AlturatextBox, "los datos tiene que ser caracter ");

            }
            if (!int.TryParse(AlturatextBox.Text, out int Altura))
            {
                valido = false;
                errorProvider1.SetError(AlturatextBox, "los datos tiene que ser un caracter ");

            }
            return valido;

        }

        internal void SetPersona(Personas persona)
        {
            personas = persona;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult  = DialogResult.Cancel;
        }

    }
}
