using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    //clase papá es la cabeza de la clase
    public class Persona
    {
        //String=Texto Int=Numero Entero
        public string Nombre { get; set; }
        public int Edad { get; set; }

        //Get y Set es para tomar y dar datos
        public string   Nacimiento { get; set; }
        public Persona(string nombre, int edad, string nacimiento)
        {
            //Caja de texto y afectara las clases posteriores
            Nombre = nombre;
            Edad = edad;
            Nacimiento = nacimiento;
        }
        
    }

    //clase hija 
    //Aqui se podra ver los diferentes tipos de carga de personas Aluno, Empleado y Docente
    public class Alumno
    {
        public string Carrera { get; set; }
        public int Matricula { get; set; }


        public Alumno(string nombre, int edad, string nacimiento, string carrera, int matricula)
        {
            
            Carrera = carrera;
            Matricula = matricula;

        }

    }

    //clase hija
    public class Empleado
    {

        public string Carrera { get; set; }
        public int Matricula { get; set; }

        public int Sueldo { get; set; }

        public Empleado(string nombre, int edad, string nacimiento, string carrera, int matricula, int sueldo)
        {

            Carrera = carrera;
            Matricula = matricula;
            Sueldo = sueldo;
        }

    }

    //clase hija
    public class Docente
    {

        public string Carrera { get; set; }
        public int Matricula { get; set; }

        public int Sueldo { get; set; }

        public Docente(string nombre, int edad, string nacimiento, string carrera, int matricula, int sueldo)
        {

            Carrera = carrera;
            Matricula = matricula;
            Sueldo = sueldo;
        }
    }
}

