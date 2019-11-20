namespace Alumnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblSemestre = new System.Windows.Forms.Label();
            this.TxtSemestre = new System.Windows.Forms.TextBox();
            this.LblCarrera = new System.Windows.Forms.Label();
            this.TxtCarrera = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.Ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblCalificacion = new System.Windows.Forms.Label();
            this.TxtCalificacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ep)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Location = new System.Drawing.Point(17, 30);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(65, 17);
            this.LblMatricula.TabIndex = 0;
            this.LblMatricula.Text = "Matricula";
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(131, 30);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(100, 22);
            this.TxtMatricula.TabIndex = 1;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(17, 75);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(62, 17);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(131, 75);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 22);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LblSemestre
            // 
            this.LblSemestre.AutoSize = true;
            this.LblSemestre.Location = new System.Drawing.Point(17, 120);
            this.LblSemestre.Name = "LblSemestre";
            this.LblSemestre.Size = new System.Drawing.Size(72, 17);
            this.LblSemestre.TabIndex = 4;
            this.LblSemestre.Text = "Semestre:";
            // 
            // TxtSemestre
            // 
            this.TxtSemestre.Location = new System.Drawing.Point(131, 117);
            this.TxtSemestre.Name = "TxtSemestre";
            this.TxtSemestre.Size = new System.Drawing.Size(100, 22);
            this.TxtSemestre.TabIndex = 5;
            // 
            // LblCarrera
            // 
            this.LblCarrera.AutoSize = true;
            this.LblCarrera.Location = new System.Drawing.Point(17, 165);
            this.LblCarrera.Name = "LblCarrera";
            this.LblCarrera.Size = new System.Drawing.Size(60, 17);
            this.LblCarrera.TabIndex = 6;
            this.LblCarrera.Text = "Carrera:";
            // 
            // TxtCarrera
            // 
            this.TxtCarrera.Location = new System.Drawing.Point(131, 162);
            this.TxtCarrera.Name = "TxtCarrera";
            this.TxtCarrera.Size = new System.Drawing.Size(100, 22);
            this.TxtCarrera.TabIndex = 7;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(17, 208);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(68, 17);
            this.LblTelefono.TabIndex = 8;
            this.LblTelefono.Text = "Telefono:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(131, 208);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 22);
            this.TxtTelefono.TabIndex = 9;
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAccept.Location = new System.Drawing.Point(20, 291);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(211, 49);
            this.BtnAccept.TabIndex = 12;
            this.BtnAccept.Text = "&Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.ButtonAceptar_Click);
            // 
            // Ep
            // 
            this.Ep.ContainerControl = this;
            // 
            // LblCalificacion
            // 
            this.LblCalificacion.AutoSize = true;
            this.LblCalificacion.Location = new System.Drawing.Point(17, 253);
            this.LblCalificacion.Name = "LblCalificacion";
            this.LblCalificacion.Size = new System.Drawing.Size(83, 17);
            this.LblCalificacion.TabIndex = 11;
            this.LblCalificacion.Text = "Calificacion:";
            // 
            // TxtCalificacion
            // 
            this.TxtCalificacion.Location = new System.Drawing.Point(131, 253);
            this.TxtCalificacion.Name = "TxtCalificacion";
            this.TxtCalificacion.Size = new System.Drawing.Size(100, 22);
            this.TxtCalificacion.TabIndex = 10;
            this.TxtCalificacion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCalificacion_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(252, 366);
            this.Controls.Add(this.TxtCalificacion);
            this.Controls.Add(this.LblCalificacion);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.TxtCarrera);
            this.Controls.Add(this.LblCarrera);
            this.Controls.Add(this.TxtSemestre);
            this.Controls.Add(this.LblSemestre);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.LblMatricula);
            this.Name = "Form1";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblSemestre;
        private System.Windows.Forms.TextBox TxtSemestre;
        private System.Windows.Forms.Label LblCarrera;
        private System.Windows.Forms.TextBox TxtCarrera;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.ErrorProvider Ep;
        private System.Windows.Forms.TextBox TxtCalificacion;
        private System.Windows.Forms.Label LblCalificacion;
    }
}

