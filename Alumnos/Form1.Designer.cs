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
            label1.Location = new Point(67, 11);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre(s)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 11);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 11);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(47, 46);
            TxtNombre.Margin = new Padding(3, 2, 3, 2);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(110, 23);
            TxtNombre.TabIndex = 3;
            // 
            // TxtApellidoPaterno
            // 
            TxtApellidoPaterno.Location = new Point(195, 46);
            TxtApellidoPaterno.Margin = new Padding(3, 2, 3, 2);
            TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            TxtApellidoPaterno.Size = new Size(110, 23);
            TxtApellidoPaterno.TabIndex = 4;
            // 
            // TxtApellidoMaterno
            // 
            TxtApellidoMaterno.Location = new Point(340, 46);
            TxtApellidoMaterno.Margin = new Padding(3, 2, 3, 2);
            TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            TxtApellidoMaterno.Size = new Size(110, 23);
            TxtApellidoMaterno.TabIndex = 5;
            // 
            // CreateB
            // 
            CreateB.Location = new Point(542, 270);
            CreateB.Margin = new Padding(3, 2, 3, 2);
            CreateB.Name = "CreateB";
            CreateB.Size = new Size(82, 22);
            CreateB.TabIndex = 6;
            CreateB.Text = "Create";
            CreateB.UseVisualStyleBackColor = true;
            CreateB.Click += CreateB_Click;
            // 
            // TimeDateFechaNacimiento
            // 
            TimeDateFechaNacimiento.Format = DateTimePickerFormat.Short;
            TimeDateFechaNacimiento.Location = new Point(47, 107);
            TimeDateFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            TimeDateFechaNacimiento.Name = "TimeDateFechaNacimiento";
            TimeDateFechaNacimiento.Size = new Size(219, 23);
            TimeDateFechaNacimiento.TabIndex = 7;
            // 
            // FechaDeNacimiento
            // 
            FechaDeNacimiento.AutoSize = true;
            FechaDeNacimiento.Location = new Point(47, 90);
            FechaDeNacimiento.Name = "FechaDeNacimiento";
            FechaDeNacimiento.Size = new Size(117, 15);
            FechaDeNacimiento.TabIndex = 8;
            FechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // TextResult
            // 
            TextResult.AutoSize = true;
            TextResult.Location = new Point(24, 245);
            TextResult.Name = "TextResult";
            TextResult.Size = new Size(0, 15);
            TextResult.TabIndex = 9;
            // 
            // TxtMatricula
            // 
            TxtMatricula.Location = new Point(47, 191);
            TxtMatricula.Margin = new Padding(3, 2, 3, 2);
            TxtMatricula.Name = "TxtMatricula";
            TxtMatricula.Size = new Size(110, 23);
            TxtMatricula.TabIndex = 10;
            // 
            // TxtCarrera
            // 
            TxtCarrera.Location = new Point(195, 191);
            TxtCarrera.Margin = new Padding(3, 2, 3, 2);
            TxtCarrera.Name = "TxtCarrera";
            TxtCarrera.Size = new Size(110, 23);
            TxtCarrera.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 160);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 13;
            label4.Text = "Matricula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(214, 160);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 14;
            label5.Text = "Carrera";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(364, 160);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 15;
            label6.Text = "Promedio";
            // 
            // domainUpDown1
            // 
            domainUpDown1.AllowDrop = true;
            domainUpDown1.Items.Add("           10");
            domainUpDown1.Items.Add("          9");
            domainUpDown1.Items.Add("         8");
            domainUpDown1.Items.Add("        7");
            domainUpDown1.Items.Add("      6");
            domainUpDown1.Items.Add("     5");
            domainUpDown1.Items.Add("    4");
            domainUpDown1.Items.Add("   3");
            domainUpDown1.Items.Add("  2");
            domainUpDown1.Items.Add("1");
            domainUpDown1.Location = new Point(340, 192);
            domainUpDown1.Margin = new Padding(3, 2, 3, 2);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.ReadOnly = true;
            domainUpDown1.Size = new Size(132, 23);
            domainUpDown1.Sorted = true;
            domainUpDown1.TabIndex = 11;
            domainUpDown1.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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
