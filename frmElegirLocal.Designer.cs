namespace TrabajoPracticoIntegradorFinal
{
    partial class frmElegirLocal
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
            this.label2 = new System.Windows.Forms.Label();
            this.rbquenaken = new System.Windows.Forms.RadioButton();
            this.gbLocales = new System.Windows.Forms.GroupBox();
            this.rbonas = new System.Windows.Forms.RadioButton();
            this.rbtobas = new System.Windows.Forms.RadioButton();
            this.btnCapacidad = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbLocales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el local donde queira Registrar su ubicacion";
            // 
            // rbquenaken
            // 
            this.rbquenaken.AutoSize = true;
            this.rbquenaken.Location = new System.Drawing.Point(6, 28);
            this.rbquenaken.Name = "rbquenaken";
            this.rbquenaken.Size = new System.Drawing.Size(88, 19);
            this.rbquenaken.TabIndex = 2;
            this.rbquenaken.TabStop = true;
            this.rbquenaken.Text = "quenaken";
            this.rbquenaken.UseVisualStyleBackColor = true;
            // 
            // gbLocales
            // 
            this.gbLocales.Controls.Add(this.rbtobas);
            this.gbLocales.Controls.Add(this.rbonas);
            this.gbLocales.Controls.Add(this.rbquenaken);
            this.gbLocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocales.Location = new System.Drawing.Point(5, 30);
            this.gbLocales.Name = "gbLocales";
            this.gbLocales.Size = new System.Drawing.Size(238, 122);
            this.gbLocales.TabIndex = 3;
            this.gbLocales.TabStop = false;
            this.gbLocales.Text = "Locales";
            // 
            // rbonas
            // 
            this.rbonas.AutoSize = true;
            this.rbonas.Location = new System.Drawing.Point(7, 53);
            this.rbonas.Name = "rbonas";
            this.rbonas.Size = new System.Drawing.Size(56, 19);
            this.rbonas.TabIndex = 3;
            this.rbonas.TabStop = true;
            this.rbonas.Text = "onas";
            this.rbonas.UseVisualStyleBackColor = true;
            // 
            // rbtobas
            // 
            this.rbtobas.AutoSize = true;
            this.rbtobas.Location = new System.Drawing.Point(7, 78);
            this.rbtobas.Name = "rbtobas";
            this.rbtobas.Size = new System.Drawing.Size(60, 19);
            this.rbtobas.TabIndex = 4;
            this.rbtobas.TabStop = true;
            this.rbtobas.Text = "tobas";
            this.rbtobas.UseVisualStyleBackColor = true;
            // 
            // btnCapacidad
            // 
            this.btnCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapacidad.Location = new System.Drawing.Point(249, 37);
            this.btnCapacidad.Name = "btnCapacidad";
            this.btnCapacidad.Size = new System.Drawing.Size(156, 65);
            this.btnCapacidad.TabIndex = 4;
            this.btnCapacidad.Text = "Informacion capacidad de cada local";
            this.btnCapacidad.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(249, 108);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(156, 44);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar Asiento";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmElegirLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 166);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCapacidad);
            this.Controls.Add(this.gbLocales);
            this.Controls.Add(this.label2);
            this.Name = "frmElegirLocal";
            this.Text = "Elegir Local";
            this.gbLocales.ResumeLayout(false);
            this.gbLocales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbquenaken;
        private System.Windows.Forms.GroupBox gbLocales;
        private System.Windows.Forms.RadioButton rbtobas;
        private System.Windows.Forms.RadioButton rbonas;
        private System.Windows.Forms.Button btnCapacidad;
        private System.Windows.Forms.Button btnRegistrar;
    }
}