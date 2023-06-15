namespace EncuentasForm
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btImprimirResultados = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(166, 115);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(152, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Registro de Encuesta";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btImprimirResultados
            // 
            this.btImprimirResultados.Location = new System.Drawing.Point(166, 190);
            this.btImprimirResultados.Name = "btImprimirResultados";
            this.btImprimirResultados.Size = new System.Drawing.Size(152, 40);
            this.btImprimirResultados.TabIndex = 1;
            this.btImprimirResultados.Text = "Imprimir Resultados";
            this.btImprimirResultados.UseVisualStyleBackColor = true;
            this.btImprimirResultados.Click += new System.EventHandler(this.btImprimirResultados_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btImprimirResultados);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btImprimirResultados;
        private System.Windows.Forms.Button button3;
    }
}

