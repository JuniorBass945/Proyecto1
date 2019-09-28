using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_de_productos
{
    public partial class Productos : Form
    {
        private int edit = -1;
        private List<Producto> productos = new List<Producto>();

        public Productos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Producto pro = new Producto();

            pro.Nombre = txtNombre.Text;
            pro.Precio = txtPrecio.Text;
            pro.FechaC = txtFechaC.Text;
            pro.FechaV = txtFechaV.Text;
            pro.Estado = txtEstado.Text;
            pro.Detalle = txtDetalle.Text;
            pro.Codigo = txtCodigo.Text;
            pro.Categoria = txtCategoria.Text;

            if (edit > -1)
            {
                productos[edit] = pro;
            }

            else
            {
                productos.Add(pro);
            }
            
            RefrescarGriv();
            Clear();
        }

        private void RefrescarGriv()
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = productos;
            dgvDatos.ClearSelection();

        }

        private void DgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Seleccion = dgvDatos.SelectedRows[0];
            int pos = dgvDatos.Rows.IndexOf(Seleccion);

            Producto pro = productos[pos];
            edit = pos;
            txtNombre.Text = pro.Nombre;
            txtCodigo.Text = pro.Codigo;
            txtCategoria.Text = pro.Categoria;
            txtDetalle.Text = pro.Detalle;
            txtEstado.Text = pro.Estado;
            txtPrecio.Text = pro.Precio;
            txtFechaC.Text = pro.FechaC;
            txtFechaV.Text = pro.FechaV;
        }

        private void Clear()
        {
            txtNombre.Text = "";
            txtFechaC.Text = "";
            txtFechaV.Text = "";
            txtPrecio.Text = "";
            txtEstado.Text = "";
            txtDetalle.Text = "";
            txtCodigo.Text = "";
            txtCategoria.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (edit > -1)
            {
                productos.RemoveAt(edit);
                edit = -1;
                Clear();
                RefrescarGriv();
            }
            else
            {
                MessageBox.Show("Debe dar doble click sobre el producto que desea eliminar!");
            }
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TxtDetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFechaC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFechaV_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
