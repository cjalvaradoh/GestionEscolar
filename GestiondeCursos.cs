using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Escolar
{
    public partial class GestiondeCursos : Form
    {
        private List<Curso> cursos = new List<Curso>();
        private List<Profesor> profesores = new List<Profesor>();

        public GestiondeCursos()
        {
            InitializeComponent();
        }

        private void GestiondeCursos_Load(object sender, EventArgs e)
        {
            // Cargar datos de ejemplo (puedes cargar desde una base de datos o archivo).
            cursos.Add(new Curso("Matemáticas", "MATH101", "Curso de matemáticas básicas"));
            cursos.Add(new Curso("Historia", "HIST101", "Curso de historia mundial"));
            profesores.Add(new Profesor("Juan Pérez"));
            profesores.Add(new Profesor("María López"));

            // Llenar la lista de cursos ofrecidos.
            RefreshCursosList();

            RefreshProfesoresList();
        }
        private void RefreshProfesoresList()
        {
            // Limpiar la lista y volver a llenarla con la información actualizada.
            lstProfesores.Items.Clear();
            foreach (Profesor profesor in profesores)
            {
                lstProfesores.Items.Add(profesor.Nombre);
            }
        }
        private void RefreshCursosList()
        {
            // Limpiar la lista y volver a llenarla con la información actualizada.
            lstCursosOfrecidos.Items.Clear();
            foreach (Curso curso in cursos)
            {
                lstCursosOfrecidos.Items.Add(curso.ToString());
            }
        }

        private void btnRegistrarCurso_Click_1(object sender, EventArgs e)
        {
            // Obtener datos del formulario.
            string nombre = txtNombreCurso.Text;
            string codigo = txtCodigoCurso.Text;
            string descripcion = txtDescripcionCurso.Text;

            // Validar los datos de entrada (puedes agregar validaciones más robustas).
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Por favor, ingrese el nombre y el código del curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear un nuevo curso y agregarlo a la lista.
            Curso nuevoCurso = new Curso(nombre, codigo, descripcion);
            cursos.Add(nuevoCurso);

            // Actualizar la lista de cursos ofrecidos.
            RefreshCursosList();

            // Limpiar los cuadros de texto.
            txtNombreCurso.Clear();
            txtCodigoCurso.Clear();
            txtDescripcionCurso.Clear();
        }

        private void btnAsignarProfesor_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un curso y un profesor.
            if (lstCursosOfrecidos.SelectedIndex == -1 || lstProfesores.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un curso y un profesor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asignar el profesor seleccionado al curso seleccionado.
            int cursoIndex = lstCursosOfrecidos.SelectedIndex;
            int profesorIndex = lstProfesores.SelectedIndex;
            cursos[cursoIndex].ProfesorAsignado = profesores[profesorIndex];

            // Actualizar la lista de cursos ofrecidos con la información actualizada.
            RefreshCursosList();
        }

        private void lstCursosOfrecidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {

        }
    }
}
