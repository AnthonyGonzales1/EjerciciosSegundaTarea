using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroBiblia.Entidades;
using RegistroBiblia.BLL;
using RegistroBiblia.DAL;


namespace RegistroBiblia
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Libros libros = LlenaClase();
            bool Paso = false;

            if (IDLibronumericUpDown.Value == 0)
                Paso = BLL.LibrosBLL.Guardar(libros);

        }
        private Libros LlenaClase() {

            Libros libros = new Libros();

            libros.IDLibro = Convert.ToInt32(IDLibronumericUpDown.Value);
            libros.Descripcion = DescripciontextBox.Text;
            libros.siglas = SiglastextBox.Text;
            libros.IDtipo = Convert.ToInt32(IDTiponumericUpDown.Value);

            return libros;

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IDLibronumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            SiglastextBox.Clear();
            IDTiponumericUpDown.Value = 0;

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDLibronumericUpDown.Value);
            Libros libros = BLL.LibrosBLL.Buscar(id);

            if (libros != null)
            {
                IDLibronumericUpDown.Value = libros.IDLibro;
                DescripciontextBox.Text = libros.Descripcion;
                SiglastextBox.Text = libros.siglas;
                IDTiponumericUpDown.Value = libros.IDtipo;

            }

            else
                MessageBox.Show("No se encontro", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDLibronumericUpDown.Value);

            if (BLL.LibrosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo Eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

