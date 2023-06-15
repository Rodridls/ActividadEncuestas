namespace EncuentasForm
{
    partial class FormRegistroDeEncuesta
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
            this.cbUsaBicicleta = new System.Windows.Forms.CheckBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.cbUsaCole = new System.Windows.Forms.CheckBox();
            this.cbUsaAuto = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIngresoDistancia = new System.Windows.Forms.TextBox();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.cbContacto = new System.Windows.Forms.CheckBox();
            this.tbContacto = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUsaBicicleta
            // 
            this.cbUsaBicicleta.AutoSize = true;
            this.cbUsaBicicleta.Location = new System.Drawing.Point(72, 54);
            this.cbUsaBicicleta.Name = "cbUsaBicicleta";
            this.cbUsaBicicleta.Size = new System.Drawing.Size(100, 17);
            this.cbUsaBicicleta.TabIndex = 0;
            this.cbUsaBicicleta.Text = "¿Usa Bicicleta?";
            this.cbUsaBicicleta.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(296, 203);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(395, 203);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // cbUsaCole
            // 
            this.cbUsaCole.AutoSize = true;
            this.cbUsaCole.Location = new System.Drawing.Point(72, 123);
            this.cbUsaCole.Name = "cbUsaCole";
            this.cbUsaCole.Size = new System.Drawing.Size(149, 17);
            this.cbUsaCole.TabIndex = 4;
            this.cbUsaCole.Text = "¿Usa Transporte Público?";
            this.cbUsaCole.UseVisualStyleBackColor = true;
            // 
            // cbUsaAuto
            // 
            this.cbUsaAuto.AutoSize = true;
            this.cbUsaAuto.Location = new System.Drawing.Point(72, 88);
            this.cbUsaAuto.Name = "cbUsaAuto";
            this.cbUsaAuto.Size = new System.Drawing.Size(106, 17);
            this.cbUsaAuto.TabIndex = 5;
            this.cbUsaAuto.Text = "¿Usa Automovil?";
            this.cbUsaAuto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUsaCole);
            this.groupBox2.Controls.Add(this.cbUsaAuto);
            this.groupBox2.Controls.Add(this.cbUsaBicicleta);
            this.groupBox2.Location = new System.Drawing.Point(23, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modo de transporte habitual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDistancia);
            this.groupBox1.Controls.Add(this.tbIngresoDistancia);
            this.groupBox1.Location = new System.Drawing.Point(386, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sobre el destino al trabajo/estudio";
            // 
            // tbIngresoDistancia
            // 
            this.tbIngresoDistancia.Location = new System.Drawing.Point(101, 29);
            this.tbIngresoDistancia.Name = "tbIngresoDistancia";
            this.tbIngresoDistancia.Size = new System.Drawing.Size(100, 20);
            this.tbIngresoDistancia.TabIndex = 0;
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Location = new System.Drawing.Point(6, 32);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(89, 13);
            this.lbDistancia.TabIndex = 1;
            this.lbDistancia.Text = "Distancia en (km)";
            // 
            // gbContacto
            // 
            this.gbContacto.Controls.Add(this.tbContacto);
            this.gbContacto.Controls.Add(this.cbContacto);
            this.gbContacto.Location = new System.Drawing.Point(386, 103);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Size = new System.Drawing.Size(357, 94);
            this.gbContacto.TabIndex = 5;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "Contacto";
            // 
            // cbContacto
            // 
            this.cbContacto.AutoSize = true;
            this.cbContacto.Location = new System.Drawing.Point(101, 19);
            this.cbContacto.Name = "cbContacto";
            this.cbContacto.Size = new System.Drawing.Size(143, 17);
            this.cbContacto.TabIndex = 0;
            this.cbContacto.Text = "¿Puede ser contactado?";
            this.cbContacto.UseVisualStyleBackColor = true;
            this.cbContacto.CheckedChanged += new System.EventHandler(this.cbContacto_CheckedChanged);
            // 
            // tbContacto
            // 
            this.tbContacto.Location = new System.Drawing.Point(59, 50);
            this.tbContacto.Name = "tbContacto";
            this.tbContacto.Size = new System.Drawing.Size(221, 20);
            this.tbContacto.TabIndex = 1;
            // 
            // FormRegistroDeEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbContacto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormRegistroDeEncuesta";
            this.Text = "FormRegistroDeEncuesta";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbContacto.ResumeLayout(false);
            this.gbContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.CheckBox cbUsaBicicleta;
        public System.Windows.Forms.CheckBox cbUsaCole;
        public System.Windows.Forms.CheckBox cbUsaAuto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDistancia;
        public System.Windows.Forms.TextBox tbIngresoDistancia;
        private System.Windows.Forms.GroupBox gbContacto;
        public System.Windows.Forms.CheckBox cbContacto;
        public System.Windows.Forms.TextBox tbContacto;
    }
}