namespace Costo_Arroz_Pilado
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
            this.button_Pilado = new System.Windows.Forms.Button();
            this.button_Cascara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Pilado
            // 
            this.button_Pilado.Location = new System.Drawing.Point(73, 66);
            this.button_Pilado.Name = "button_Pilado";
            this.button_Pilado.Size = new System.Drawing.Size(75, 39);
            this.button_Pilado.TabIndex = 0;
            this.button_Pilado.Text = "Costo Arroz Pilado";
            this.button_Pilado.UseVisualStyleBackColor = true;
            this.button_Pilado.Click += new System.EventHandler(this.button_Pilado_Click);
            // 
            // button_Cascara
            // 
            this.button_Cascara.Location = new System.Drawing.Point(229, 66);
            this.button_Cascara.Name = "button_Cascara";
            this.button_Cascara.Size = new System.Drawing.Size(75, 39);
            this.button_Cascara.TabIndex = 1;
            this.button_Cascara.Text = "Costo Arroz Cascara";
            this.button_Cascara.UseVisualStyleBackColor = true;
            this.button_Cascara.Click += new System.EventHandler(this.button_Cascara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 173);
            this.Controls.Add(this.button_Cascara);
            this.Controls.Add(this.button_Pilado);
            this.Name = "Form1";
            this.Text = "Costo de arroz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Pilado;
        private System.Windows.Forms.Button button_Cascara;
    }
}

