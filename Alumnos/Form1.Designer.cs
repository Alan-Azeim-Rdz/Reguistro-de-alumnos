namespace Alumnos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtNombre = new TextBox();
            TxtApellidoPaterno = new TextBox();
            TxtApellidoMaterno = new TextBox();
            CreateB = new Button();
            TimeDateFechaNacimiento = new DateTimePicker();
            FechaDeNacimiento = new Label();
            TextResult = new Label();
            TxtMatricula = new TextBox();
            TxtCarrera = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            domainUpDown1 = new DomainUpDown();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 15);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre(s)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 15);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 15);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(54, 62);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(125, 27);
            TxtNombre.TabIndex = 3;
            // 
            // TxtApellidoPaterno
            // 
            TxtApellidoPaterno.Location = new Point(223, 62);
            TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            TxtApellidoPaterno.Size = new Size(125, 27);
            TxtApellidoPaterno.TabIndex = 4;
            // 
            // TxtApellidoMaterno
            // 
            TxtApellidoMaterno.Location = new Point(388, 62);
            TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            TxtApellidoMaterno.Size = new Size(125, 27);
            TxtApellidoMaterno.TabIndex = 5;
            // 
            // CreateB
            // 
            CreateB.Location = new Point(620, 360);
            CreateB.Name = "CreateB";
            CreateB.Size = new Size(94, 29);
            CreateB.TabIndex = 6;
            CreateB.Text = "Create";
            CreateB.UseVisualStyleBackColor = true;
            CreateB.Click += CreateB_Click;
            // 
            // TimeDateFechaNacimiento
            // 
            TimeDateFechaNacimiento.Format = DateTimePickerFormat.Short;
            TimeDateFechaNacimiento.Location = new Point(54, 143);
            TimeDateFechaNacimiento.Name = "TimeDateFechaNacimiento";
            TimeDateFechaNacimiento.Size = new Size(250, 27);
            TimeDateFechaNacimiento.TabIndex = 7;
            // 
            // FechaDeNacimiento
            // 
            FechaDeNacimiento.AutoSize = true;
            FechaDeNacimiento.Location = new Point(54, 120);
            FechaDeNacimiento.Name = "FechaDeNacimiento";
            FechaDeNacimiento.Size = new Size(146, 20);
            FechaDeNacimiento.TabIndex = 8;
            FechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // TextResult
            // 
            TextResult.AutoSize = true;
            TextResult.Location = new Point(27, 327);
            TextResult.Name = "TextResult";
            TextResult.Size = new Size(0, 20);
            TextResult.TabIndex = 9;
            // 
            // TxtMatricula
            // 
            TxtMatricula.Location = new Point(54, 255);
            TxtMatricula.Name = "TxtMatricula";
            TxtMatricula.Size = new Size(125, 27);
            TxtMatricula.TabIndex = 10;
            // 
            // TxtCarrera
            // 
            TxtCarrera.Location = new Point(223, 255);
            TxtCarrera.Name = "TxtCarrera";
            TxtCarrera.Size = new Size(125, 27);
            TxtCarrera.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 214);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 13;
            label4.Text = "Matricula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 214);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 14;
            label5.Text = "Carrera";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 214);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 15;
            label6.Text = "Promedio";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(388, 256);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(151, 27);
            domainUpDown1.TabIndex = 16;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(domainUpDown1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtCarrera);
            Controls.Add(TxtMatricula);
            Controls.Add(TextResult);
            Controls.Add(FechaDeNacimiento);
            Controls.Add(TimeDateFechaNacimiento);
            Controls.Add(CreateB);
            Controls.Add(TxtApellidoMaterno);
            Controls.Add(TxtApellidoPaterno);
            Controls.Add(TxtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtNombre;
        private TextBox TxtApellidoPaterno;
        private TextBox TxtApellidoMaterno;
        private Button CreateB;
        private DateTimePicker TimeDateFechaNacimiento;
        private Label FechaDeNacimiento;
        private Label TextResult;
        private TextBox TxtMatricula;
        private TextBox TxtCarrera;
        private Label label4;
        private Label label5;
        private Label label6;
        private DomainUpDown domainUpDown1;
    }
}
