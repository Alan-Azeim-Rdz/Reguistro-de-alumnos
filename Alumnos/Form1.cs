namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateB_Click(object sender, EventArgs e)
        {
            string Nombre = (TxtNombre).Text;
            string ApellidoPaterno = (TxtApellidoPaterno).Text;
            string ApellidoMaterno = (TxtApellidoMaterno).Text;
            string FechaDeNacieminto = (TimeDateFechaNacimiento).Text;
            string matricuala = (TxtMatricula).Text;
            string carrera = (TxtCarrera).Text;
            double promedio = double.Parse(domainUpDown1.Text);

            Estudiante Student = new Estudiante( Nombre, ApellidoPaterno, ApellidoMaterno, FechaDeNacieminto,matricuala, carrera, promedio);

            TextResult.Text = "" + Student;
        }
    }
}
