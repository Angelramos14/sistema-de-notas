namespace promedio
{
    partial class frmCuadroNotas
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
            this.gbNotas = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNotaTres = new System.Windows.Forms.TextBox();
            this.txtNotaDos = new System.Windows.Forms.TextBox();
            this.txtNotaUno = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblNotaTres = new System.Windows.Forms.Label();
            this.lblNotaDos = new System.Windows.Forms.Label();
            this.lblNotaUno = new System.Windows.Forms.Label();
            this.gbPromedio = new System.Windows.Forms.GroupBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPromedioFinal = new System.Windows.Forms.TextBox();
            this.gbRegistros = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.btnAgregarPromedio = new System.Windows.Forms.Button();
            this.tlpAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.gbNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbPromedio.SuspendLayout();
            this.gbRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNotas
            // 
            this.gbNotas.Controls.Add(this.pictureBox2);
            this.gbNotas.Controls.Add(this.txtNotaTres);
            this.gbNotas.Controls.Add(this.txtNotaDos);
            this.gbNotas.Controls.Add(this.txtNotaUno);
            this.gbNotas.Controls.Add(this.lblError);
            this.gbNotas.Controls.Add(this.lblNotaTres);
            this.gbNotas.Controls.Add(this.lblNotaDos);
            this.gbNotas.Controls.Add(this.lblNotaUno);
            this.gbNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNotas.Location = new System.Drawing.Point(39, 30);
            this.gbNotas.Name = "gbNotas";
            this.gbNotas.Size = new System.Drawing.Size(526, 262);
            this.gbNotas.TabIndex = 0;
            this.gbNotas.TabStop = false;
            this.gbNotas.Text = "Registro de notas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::promedio.Properties.Resources.icons8_icono_de_usuario_100;
            this.pictureBox2.Location = new System.Drawing.Point(356, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 91);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // txtNotaTres
            // 
            this.txtNotaTres.Location = new System.Drawing.Point(113, 135);
            this.txtNotaTres.Name = "txtNotaTres";
            this.txtNotaTres.Size = new System.Drawing.Size(118, 26);
            this.txtNotaTres.TabIndex = 6;
            this.tlpAyuda.SetToolTip(this.txtNotaTres, "Ingresa valores entre 1 y 10");
            // 
            // txtNotaDos
            // 
            this.txtNotaDos.Location = new System.Drawing.Point(113, 92);
            this.txtNotaDos.Name = "txtNotaDos";
            this.txtNotaDos.Size = new System.Drawing.Size(118, 26);
            this.txtNotaDos.TabIndex = 5;
            this.tlpAyuda.SetToolTip(this.txtNotaDos, "Ingresa valores entre 1 y 10");
            // 
            // txtNotaUno
            // 
            this.txtNotaUno.Location = new System.Drawing.Point(113, 47);
            this.txtNotaUno.Name = "txtNotaUno";
            this.txtNotaUno.Size = new System.Drawing.Size(118, 26);
            this.txtNotaUno.TabIndex = 4;
            this.tlpAyuda.SetToolTip(this.txtNotaUno, "Ingresa valores entre 1 y 10");
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(40, 217);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(49, 20);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "Error";
            // 
            // lblNotaTres
            // 
            this.lblNotaTres.AutoSize = true;
            this.lblNotaTres.Location = new System.Drawing.Point(40, 135);
            this.lblNotaTres.Name = "lblNotaTres";
            this.lblNotaTres.Size = new System.Drawing.Size(67, 20);
            this.lblNotaTres.TabIndex = 2;
            this.lblNotaTres.Text = "Nota 3:";
            // 
            // lblNotaDos
            // 
            this.lblNotaDos.AutoSize = true;
            this.lblNotaDos.Location = new System.Drawing.Point(40, 92);
            this.lblNotaDos.Name = "lblNotaDos";
            this.lblNotaDos.Size = new System.Drawing.Size(67, 20);
            this.lblNotaDos.TabIndex = 1;
            this.lblNotaDos.Text = "Nota 2:";
            // 
            // lblNotaUno
            // 
            this.lblNotaUno.AutoSize = true;
            this.lblNotaUno.Location = new System.Drawing.Point(37, 47);
            this.lblNotaUno.Name = "lblNotaUno";
            this.lblNotaUno.Size = new System.Drawing.Size(67, 20);
            this.lblNotaUno.TabIndex = 0;
            this.lblNotaUno.Text = "Nota 1:";
            // 
            // gbPromedio
            // 
            this.gbPromedio.Controls.Add(this.lblPromedio);
            this.gbPromedio.Controls.Add(this.txtPromedioFinal);
            this.gbPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPromedio.Location = new System.Drawing.Point(39, 315);
            this.gbPromedio.Name = "gbPromedio";
            this.gbPromedio.Size = new System.Drawing.Size(699, 100);
            this.gbPromedio.TabIndex = 1;
            this.gbPromedio.TabStop = false;
            this.gbPromedio.Text = "Promedio";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(26, 55);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(128, 20);
            this.lblPromedio.TabIndex = 1;
            this.lblPromedio.Text = "Promedio final:";
            // 
            // txtPromedioFinal
            // 
            this.txtPromedioFinal.Location = new System.Drawing.Point(160, 55);
            this.txtPromedioFinal.Name = "txtPromedioFinal";
            this.txtPromedioFinal.Size = new System.Drawing.Size(366, 26);
            this.txtPromedioFinal.TabIndex = 0;
            // 
            // gbRegistros
            // 
            this.gbRegistros.Controls.Add(this.btnSalir);
            this.gbRegistros.Controls.Add(this.btnNuevoRegistro);
            this.gbRegistros.Controls.Add(this.btnAgregarPromedio);
            this.gbRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistros.Location = new System.Drawing.Point(615, 30);
            this.gbRegistros.Name = "gbRegistros";
            this.gbRegistros.Size = new System.Drawing.Size(173, 279);
            this.gbRegistros.TabIndex = 2;
            this.gbRegistros.TabStop = false;
            this.gbRegistros.Text = "Registros";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::promedio.Properties.Resources.icons8_cerrar_ventana_32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(20, 193);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 69);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Image = global::promedio.Properties.Resources.icons8_escoba_32;
            this.btnNuevoRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoRegistro.Location = new System.Drawing.Point(20, 108);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(131, 71);
            this.btnNuevoRegistro.TabIndex = 1;
            this.btnNuevoRegistro.Text = "Nuevo Registro";
            this.btnNuevoRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // btnAgregarPromedio
            // 
            this.btnAgregarPromedio.Image = global::promedio.Properties.Resources.icons8_añadir_usuario_tipo_de_piel_masculina_7_321;
            this.btnAgregarPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPromedio.Location = new System.Drawing.Point(20, 38);
            this.btnAgregarPromedio.Name = "btnAgregarPromedio";
            this.btnAgregarPromedio.Size = new System.Drawing.Size(131, 64);
            this.btnAgregarPromedio.TabIndex = 0;
            this.btnAgregarPromedio.Text = "Agregar promedio";
            this.btnAgregarPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPromedio.UseVisualStyleBackColor = true;
            this.btnAgregarPromedio.Click += new System.EventHandler(this.btnAgregarPromedio_Click);
            // 
            // tlpAyuda
            // 
            this.tlpAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlpAyuda.ToolTipTitle = "Mensaje de Ayuda";
            // 
            // frmCuadroNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRegistros);
            this.Controls.Add(this.gbPromedio);
            this.Controls.Add(this.gbNotas);
            this.Name = "frmCuadroNotas";
            this.Text = "Sistema de notas ITR";
            this.gbNotas.ResumeLayout(false);
            this.gbNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbPromedio.ResumeLayout(false);
            this.gbPromedio.PerformLayout();
            this.gbRegistros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNotas;
        private System.Windows.Forms.GroupBox gbPromedio;
        private System.Windows.Forms.TextBox txtNotaTres;
        private System.Windows.Forms.TextBox txtNotaDos;
        private System.Windows.Forms.TextBox txtNotaUno;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblNotaTres;
        private System.Windows.Forms.Label lblNotaDos;
        private System.Windows.Forms.Label lblNotaUno;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txtPromedioFinal;
        private System.Windows.Forms.GroupBox gbRegistros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.Button btnAgregarPromedio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip tlpAyuda;
    }
}

