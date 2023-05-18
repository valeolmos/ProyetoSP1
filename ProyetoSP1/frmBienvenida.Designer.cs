namespace ProyetoSP1
{
    partial class frmBienvenida
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.cmdBienvenido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(92, 103);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(278, 29);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido al sistema";
            // 
            // cmdBienvenido
            // 
            this.cmdBienvenido.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdBienvenido.Location = new System.Drawing.Point(190, 135);
            this.cmdBienvenido.Name = "cmdBienvenido";
            this.cmdBienvenido.Size = new System.Drawing.Size(75, 23);
            this.cmdBienvenido.TabIndex = 1;
            this.cmdBienvenido.Text = "Bienvenido";
            this.cmdBienvenido.UseVisualStyleBackColor = false;
            this.cmdBienvenido.Click += new System.EventHandler(this.cmdBienvenido_Click);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(459, 255);
            this.Controls.Add(this.cmdBienvenido);
            this.Controls.Add(this.lblBienvenido);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmBienvenida";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button cmdBienvenido;
    }
}

