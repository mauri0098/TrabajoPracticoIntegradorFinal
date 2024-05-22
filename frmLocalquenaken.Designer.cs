namespace TrabajoPracticoIntegradorFinal
{
    partial class frmLocalquenaken
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
            this.tcRegistro_Consulta = new System.Windows.Forms.TabControl();
            this.tpResitro = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumeroDeAsiento = new System.Windows.Forms.Label();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvNumeroDeAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaderegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarRegistro = new System.Windows.Forms.Button();
            this.tcRegistro_Consulta.SuspendLayout();
            this.tpResitro.SuspendLayout();
            this.tpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tcRegistro_Consulta
            // 
            this.tcRegistro_Consulta.Controls.Add(this.tpResitro);
            this.tcRegistro_Consulta.Controls.Add(this.tpConsulta);
            this.tcRegistro_Consulta.Location = new System.Drawing.Point(12, 12);
            this.tcRegistro_Consulta.Name = "tcRegistro_Consulta";
            this.tcRegistro_Consulta.SelectedIndex = 0;
            this.tcRegistro_Consulta.Size = new System.Drawing.Size(334, 244);
            this.tcRegistro_Consulta.TabIndex = 2;
            // 
            // tpResitro
            // 
            this.tpResitro.Controls.Add(this.btnVolver);
            this.tpResitro.Controls.Add(this.btnRegistrar);
            this.tpResitro.Controls.Add(this.dtpFecha);
            this.tpResitro.Controls.Add(this.txtNombre);
            this.tpResitro.Controls.Add(this.txtId);
            this.tpResitro.Controls.Add(this.lblFecha);
            this.tpResitro.Controls.Add(this.lblNombre);
            this.tpResitro.Controls.Add(this.lblNumeroDeAsiento);
            this.tpResitro.Location = new System.Drawing.Point(4, 22);
            this.tpResitro.Name = "tpResitro";
            this.tpResitro.Padding = new System.Windows.Forms.Padding(3);
            this.tpResitro.Size = new System.Drawing.Size(326, 218);
            this.tpResitro.TabIndex = 0;
            this.tpResitro.Text = "Registro";
            this.tpResitro.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(105, 126);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 32);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(142, 94);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(94, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(82, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(134, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(53, 20);
            this.txtId.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(29, 94);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(107, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha de Reservada";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNumeroDeAsiento
            // 
            this.lblNumeroDeAsiento.AutoSize = true;
            this.lblNumeroDeAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeAsiento.Location = new System.Drawing.Point(29, 24);
            this.lblNumeroDeAsiento.Name = "lblNumeroDeAsiento";
            this.lblNumeroDeAsiento.Size = new System.Drawing.Size(99, 13);
            this.lblNumeroDeAsiento.TabIndex = 7;
            this.lblNumeroDeAsiento.Text = "Numero De Asiento";
            // 
            // tpConsulta
            // 
            this.tpConsulta.Controls.Add(this.btnConsultarRegistro);
            this.tpConsulta.Controls.Add(this.dgvProducto);
            this.tpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta.Size = new System.Drawing.Size(326, 218);
            this.tpConsulta.TabIndex = 1;
            this.tpConsulta.Text = "Consulta";
            this.tpConsulta.UseVisualStyleBackColor = true;
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNumeroDeAsiento,
            this.dgvNombre,
            this.dgvFechaderegistro});
            this.dgvProducto.Location = new System.Drawing.Point(0, 6);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(319, 181);
            this.dgvProducto.TabIndex = 6;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(19, 126);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 32);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // dgvNumeroDeAsiento
            // 
            this.dgvNumeroDeAsiento.HeaderText = "Numero Asiento";
            this.dgvNumeroDeAsiento.Name = "dgvNumeroDeAsiento";
            this.dgvNumeroDeAsiento.ReadOnly = true;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            // 
            // dgvFechaderegistro
            // 
            this.dgvFechaderegistro.HeaderText = "Fecha de Registro";
            this.dgvFechaderegistro.Name = "dgvFechaderegistro";
            this.dgvFechaderegistro.ReadOnly = true;
            // 
            // btnConsultarRegistro
            // 
            this.btnConsultarRegistro.Location = new System.Drawing.Point(3, 187);
            this.btnConsultarRegistro.Name = "btnConsultarRegistro";
            this.btnConsultarRegistro.Size = new System.Drawing.Size(111, 28);
            this.btnConsultarRegistro.TabIndex = 8;
            this.btnConsultarRegistro.Text = "ConsultarRegistro";
            this.btnConsultarRegistro.UseVisualStyleBackColor = true;
            // 
            // frmLocalquenaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 268);
            this.Controls.Add(this.tcRegistro_Consulta);
            this.Name = "frmLocalquenaken";
            this.Text = "Local quenaken";
            this.tcRegistro_Consulta.ResumeLayout(false);
            this.tpResitro.ResumeLayout(false);
            this.tpResitro.PerformLayout();
            this.tpConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcRegistro_Consulta;
        private System.Windows.Forms.TabPage tpResitro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumeroDeAsiento;
        private System.Windows.Forms.TabPage tpConsulta;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroDeAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaderegistro;
        private System.Windows.Forms.Button btnConsultarRegistro;
    }
}