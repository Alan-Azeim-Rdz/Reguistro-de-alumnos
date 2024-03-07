using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Alumnos
{
    internal class Estudiante: Persona
    {
        protected string Matricula;
        protected string Carrera;
        protected double Promedio;
        public string matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }
        public string carrera
        {
            get { return Carrera; }
            set { Carrera = value; }
        }
        public double promedio
        {
            get { return Promedio; }
            set { Promedio = value; }
        }

        //constructor

        public Estudiante() : base()
        {
            matricula = "";
            carrera = "";
            promedio = 0;

        }

        public Estudiante(string Nombre, string ApellidoPaterno, string ApellidoMaterno, string FechaNacimiento, string Matricula1, string Carrera1, double Promedio1) : base(Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento)
        {
            this.matricula = Matricula1 ;
            this.carrera = Carrera1 ;
            this.promedio = Promedio1 ;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString() + "\n Matricula: " + matricula + "\n Carrera: " + carrera + "\n Promedio: " + promedio;
        }



    }
}