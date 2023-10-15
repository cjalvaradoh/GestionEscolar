using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Escolar
{
    public class Curso
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Profesor ProfesorAsignado { get; set; }

        public Curso(string nombre, string codigo, string descripcion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            if (ProfesorAsignado != null)
            {
                return $"{Nombre} ({Codigo}) - Profesor: {ProfesorAsignado.Nombre}";
            }
            else
            {
                return $"{Nombre} ({Codigo}) - Sin Profesor Asignado";
            }
        }
    }
}

