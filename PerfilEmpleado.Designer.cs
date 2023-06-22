
namespace ActividadIII_Formulario.CapaView
{
    partial class PerfilEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtidentidad = new System.Windows.Forms.TextBox();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dgvempleado = new System.Windows.Forms.DataGridView();
            this.cmbdepto = new System.Windows.Forms.ComboBox();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "identidad";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(169, 20);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // txtidentidad
            // 
            this.txtidentidad.Location = new System.Drawing.Point(169, 58);
            this.txtidentidad.Name = "txtidentidad";
            this.txtidentidad.Size = new System.Drawing.Size(121, 20);
            this.txtidentidad.TabIndex = 6;
            // 
            // txtpuesto
            // 
            this.txtpuesto.Location = new System.Drawing.Point(169, 163);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(121, 20);
            this.txtpuesto.TabIndex = 9;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(333, 160);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dgvempleado
            // 
            this.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleado.Location = new System.Drawing.Point(25, 204);
            this.dgvempleado.Name = "dgvempleado";
            this.dgvempleado.Size = new System.Drawing.Size(720, 150);
            this.dgvempleado.TabIndex = 11;
            // 
            // cmbdepto
            // 
            this.cmbdepto.FormattingEnabled = true;
            this.cmbdepto.Location = new System.Drawing.Point(169, 129);
            this.cmbdepto.Name = "cmbdepto";
            this.cmbdepto.Size = new System.Drawing.Size(121, 21);
            this.cmbdepto.TabIndex = 12;
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(169, 95);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(200, 20);
            this.dtfecha.TabIndex = 13;
            // 
            // PerfilEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.cmbdepto);
            this.Controls.Add(this.dgvempleado);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtpuesto);
            this.Controls.Add(this.txtidentidad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PerfilEmpleado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PerfilEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtidentidad;
        private System.Windows.Forms.TextBox txtpuesto;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvempleado;
        private System.Windows.Forms.ComboBox cmbdepto;
        private System.Windows.Forms.DateTimePicker dtfecha;
    }
}