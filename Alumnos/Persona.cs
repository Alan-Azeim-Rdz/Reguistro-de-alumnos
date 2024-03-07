using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    internal class Persona : NombrePersona
    {
        protected string FechaDeNacimiento;

        public string fechadenacimiento
        {
            get { return FechaDeNacimiento; }
            set { FechaDeNacimiento = value; }
        }

        //constructor

        public Persona() : base()
        {
            fechadenacimiento = "";
        }

        public Persona(string Nombre, string ApellidoPaterno, string ApellidoMaterno, string FechaNacimiento) : base(Nombre,ApellidoPaterno,ApellidoMaterno) 
        {
            this.fechadenacimiento = FechaNacimiento ;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString() + "\n" + fechadenacimiento;
        }

    }
}
