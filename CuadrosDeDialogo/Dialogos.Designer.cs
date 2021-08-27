namespace CuadrosDeDialogo
{
    partial class Dialogos
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
            this.baceptar = new System.Windows.Forms.Button();
            this.baceptar_cancelar = new System.Windows.Forms.Button();
            this.bsi_no = new System.Windows.Forms.Button();
            this.berror = new System.Windows.Forms.Button();
            this.binterrogacion = new System.Windows.Forms.Button();
            this.bexclamcion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baceptar
            // 
            this.baceptar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.baceptar.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baceptar.Location = new System.Drawing.Point(95, 83);
            this.baceptar.Name = "baceptar";
            this.baceptar.Size = new System.Drawing.Size(200, 80);
            this.baceptar.TabIndex = 0;
            this.baceptar.Text = "Aceptar";
            this.baceptar.UseVisualStyleBackColor = false;
            this.baceptar.Click += new System.EventHandler(this.baceptar_Click);
            // 
            // baceptar_cancelar
            // 
            this.baceptar_cancelar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.baceptar_cancelar.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baceptar_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baceptar_cancelar.Location = new System.Drawing.Point(324, 83);
            this.baceptar_cancelar.Name = "baceptar_cancelar";
            this.baceptar_cancelar.Size = new System.Drawing.Size(200, 80);
            this.baceptar_cancelar.TabIndex = 1;
            this.baceptar_cancelar.Text = "Aceptar/Cancelar";
            this.baceptar_cancelar.UseVisualStyleBackColor = false;
            this.baceptar_cancelar.Click += new System.EventHandler(this.baceptar_cancelar_Click);
            // 
            // bsi_no
            // 
            this.bsi_no.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bsi_no.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsi_no.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bsi_no.Location = new System.Drawing.Point(556, 83);
            this.bsi_no.Name = "bsi_no";
            this.bsi_no.Size = new System.Drawing.Size(200, 80);
            this.bsi_no.TabIndex = 2;
            this.bsi_no.Text = "Si/No";
            this.bsi_no.UseVisualStyleBackColor = false;
            this.bsi_no.Click += new System.EventHandler(this.bsi_no_Click);
            // 
            // berror
            // 
            this.berror.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.berror.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berror.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.berror.Location = new System.Drawing.Point(556, 271);
            this.berror.Name = "berror";
            this.berror.Size = new System.Drawing.Size(200, 80);
            this.berror.TabIndex = 5;
            this.berror.Text = "Error";
            this.berror.UseVisualStyleBackColor = false;
            this.berror.Click += new System.EventHandler(this.berror_Click);
            // 
            // binterrogacion
            // 
            this.binterrogacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.binterrogacion.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binterrogacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.binterrogacion.Location = new System.Drawing.Point(324, 271);
            this.binterrogacion.Name = "binterrogacion";
            this.binterrogacion.Size = new System.Drawing.Size(200, 80);
            this.binterrogacion.TabIndex = 4;
            this.binterrogacion.Text = "Interrogación";
            this.binterrogacion.UseVisualStyleBackColor = false;
            this.binterrogacion.Click += new System.EventHandler(this.binterrogacion_Click);
            // 
            // bexclamcion
            // 
            this.bexclamcion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bexclamcion.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexclamcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bexclamcion.Location = new System.Drawing.Point(95, 271);
            this.bexclamcion.Name = "bexclamcion";
            this.bexclamcion.Size = new System.Drawing.Size(200, 80);
            this.bexclamcion.TabIndex = 3;
            this.bexclamcion.Text = "Exclamación";
            this.bexclamcion.UseVisualStyleBackColor = false;
            this.bexclamcion.Click += new System.EventHandler(this.bexclamcion_Click);
            // 
            // Dialogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.berror);
            this.Controls.Add(this.binterrogacion);
            this.Controls.Add(this.bexclamcion);
            this.Controls.Add(this.bsi_no);
            this.Controls.Add(this.baceptar_cancelar);
            this.Controls.Add(this.baceptar);
            this.Name = "Dialogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadros de Dialogo en C#";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button baceptar;
        private System.Windows.Forms.Button baceptar_cancelar;
        private System.Windows.Forms.Button bsi_no;
        private System.Windows.Forms.Button berror;
        private System.Windows.Forms.Button binterrogacion;
        private System.Windows.Forms.Button bexclamcion;
    }
}

