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
        protected string ID;
        protected string Career;
        protected double Average;
        public string id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string carrer
        {
            get { return Career; }
            set { Career = value; }
        }
        public double average
        {
            get { return Average; }
            set { Average = value; }
        }

        //constructor

        public Estudiante() : base()
        {
            id = "";
            carrer = "";
            average = 0;

        }

        public Estudiante(string name, string namefather, string namemother, string dateofbirth, string ID1, string Career1, double Average1) : base(name, namefather, namemother, dateofbirth)
        {
            this.id = ID1 ;
            this.carrer = Career1;
            this.average = Average1;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString() + "\n Id: " + id + "\n Carrera: " + carrer + "\n Promedio: " + average;
        }



    }
}