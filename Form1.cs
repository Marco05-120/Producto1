using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto1
{
    public partial class Form1 : Form
    {
        private Repositorio<Estudiante> repo;

        public Form1()
        {
            InitializeComponent();
            repo = new Repositorio<Estudiante>(10);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text),
                Calificacion = double.Parse(txtCalificacion.Text)
            };

            if (repo.Agregar(est))
                MessageBox.Show("Estudiante agregado");
            else
                MessageBox.Show("No hay espacio disponible");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstEstudiantes.Items.Clear();
            foreach (var est in repo.Listar())
            {
                lstEstudiantes.Items.Add(est.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idBuscar = int.Parse(txtId.Text);
            Estudiante[] estudiantes = repo.Listar();

            Estudiante encontrado = BusquedaRecursiva.BuscarPorId(estudiantes, idBuscar);
            if (encontrado != null)
                MessageBox.Show("Encontrado: " + encontrado.ToString());
            else
                MessageBox.Show("No encontrado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = lstEstudiantes.SelectedIndex;
            if (repo.Eliminar(index))
                MessageBox.Show("Eliminado");
            else
                MessageBox.Show("No se pudo eliminar");
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = Calculos.Promedio(repo.Listar());
            MessageBox.Show("Promedio general: " + promedio);
        }
    }
}
