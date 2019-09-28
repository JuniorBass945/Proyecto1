using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_telefonica
{
    public partial class Agenda : Form
    {
        List<Persona> Personas = new List<Persona>();
        private int edit = -1;

        
        public Agenda()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no funciona. Solo es de adorno");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su contacto se ha guardado correctamente.");
            
            Persona per = new Persona();

            

            per.Nombre = txtNombre.Text;
            per.Apellido = txtApellido.Text;
            per.Edad = txtEdad.Text;
            per.Pais = txtPais.Text;
            per.Provincia = txtProvincia.Text;
            per.Fecha_Nacimiento = txtFecha.Text;
            per.Direccion = txtDireccion.Text;
            per.Cell = txtCell.Text;
            per.Tel = txtTel.Text;

          
            if (edit > -1)
            {
                Personas [edit] = per;
                edit = -1;
            }
            else
            {
                Personas.Add(per);
            }
           
            RefrescarGrid();
            Clear();
        }

        private void RefrescarGrid()
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Personas;
        }

        private void DgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvDatos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow Seleccion = dgvDatos.SelectedRows[0];
            int Sel = dgvDatos.Rows.IndexOf(Seleccion);

            Persona per = Personas[Sel];
            edit = Sel;
            txtNombre.Text = per.Nombre;
            txtApellido.Text = per.Apellido;
            txtEdad.Text = per.Edad;
            txtPais.Text = per.Pais;
            txtProvincia.Text = per.Provincia;
            txtDireccion.Text = per.Direccion;
            txtCell.Text = per.Direccion;
            txtTel.Text = per.Tel;
            txtFecha.Text = per.Fecha_Nacimiento;
        }

        private void Clear()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtPais.Text = "";
            txtProvincia.Text = "";
            txtDireccion.Text = "";
            txtCell.Text = "";
            txtTel.Text = "";
            txtFecha.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            edit = -1;
            Clear();
            RefrescarGrid();
        }

        private void red(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no funciona. Solo es adorno.😢");
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)

        {
            if (edit > -1)
            {
                Personas.RemoveAt(edit);
                edit = -1;
                Clear();
                RefrescarGrid();
            }

            else { MessageBox.Show("Debe dar doble click al registro que desea eliminar");
            }
        }

    }
}
