using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueryClases
{
    class Estudiante
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Curso { get; set; }
        public double Nota { get; set; }


        public Estudiante(int IdEstudiante, string Nombre, int Edad, string Curso, double Nota)
        {
            this.IdEstudiante = IdEstudiante;
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Curso = Curso;
            this.Nota = Nota;

        }

        public override string ToString()
        {
            return string.Format("IdEstudiante: {0}, Nombre: {1}, Edad: {2}, Curso: {3}, Nota: {4}", IdEstudiante, Nombre, Edad, Curso, Nota);
        }
    }

}

