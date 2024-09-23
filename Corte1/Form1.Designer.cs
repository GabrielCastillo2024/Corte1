namespace Corte1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCiudades = new System.Windows.Forms.ComboBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarEdad = new System.Windows.Forms.Button();
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.btnMostrarPersonas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(24, 29);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(165, 22);
            this.txtNombres.TabIndex = 0;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(12, 162);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(268, 22);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // cmbCiudades
            // 
            this.cmbCiudades.FormattingEnabled = true;
            this.cmbCiudades.Items.AddRange(new object[] {
            "Mexico",
            "Guatemala",
            "Salvador",
            "Nicaragua",
            "Honduras",
            "Costa Rica"});
            this.cmbCiudades.Location = new System.Drawing.Point(283, 29);
            this.cmbCiudades.Name = "cmbCiudades";
            this.cmbCiudades.Size = new System.Drawing.Size(121, 24);
            this.cmbCiudades.TabIndex = 4;
            this.cmbCiudades.SelectedIndexChanged += new System.EventHandler(this.cmbCiudades_SelectedIndexChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(24, 87);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(165, 22);
            this.txtApellidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(37, 211);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 42);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnMostrarEdad
            // 
            this.btnMostrarEdad.Location = new System.Drawing.Point(584, 12);
            this.btnMostrarEdad.Name = "btnMostrarEdad";
            this.btnMostrarEdad.Size = new System.Drawing.Size(118, 43);
            this.btnMostrarEdad.TabIndex = 8;
            this.btnMostrarEdad.Text = "Mostrar edad";
            this.btnMostrarEdad.UseVisualStyleBackColor = true;
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.ItemHeight = 16;
            this.lstPersonas.Location = new System.Drawing.Point(339, 130);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(420, 308);
            this.lstPersonas.TabIndex = 9;
            // 
            // btnMostrarPersonas
            // 
            this.btnMostrarPersonas.Location = new System.Drawing.Point(572, 80);
            this.btnMostrarPersonas.Name = "btnMostrarPersonas";
            this.btnMostrarPersonas.Size = new System.Drawing.Size(130, 36);
            this.btnMostrarPersonas.TabIndex = 10;
            this.btnMostrarPersonas.Text = "button1";
            this.btnMostrarPersonas.UseVisualStyleBackColor = true;
            this.btnMostrarPersonas.Click += new System.EventHandler(this.btnMostrarPersonas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.btnMostrarPersonas);
            this.Controls.Add(this.lstPersonas);
            this.Controls.Add(this.btnMostrarEdad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.cmbCiudades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtNombres);
            this.Name = "Form1";
            this.Text = "Registro de edades GECC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCiudades;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarEdad;
        private System.Windows.Forms.ListBox lstPersonas;
        private System.Windows.Forms.Button btnMostrarPersonas;
    }
}

