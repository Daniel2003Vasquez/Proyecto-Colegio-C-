namespace ProyectoTercerCorte
{
    partial class FormRegistrarNotas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1Notas = new System.Windows.Forms.Panel();
            this.btnBuscarejo = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 40.2F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(28, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(785, 73);
            this.label3.TabIndex = 59;
            this.label3.Text = "Registrar Nota Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Identificación:";
            // 
            // panel1Notas
            // 
            this.panel1Notas.Location = new System.Drawing.Point(-1, 186);
            this.panel1Notas.Name = "panel1Notas";
            this.panel1Notas.Size = new System.Drawing.Size(856, 384);
            this.panel1Notas.TabIndex = 55;
            // 
            // btnBuscarejo
            // 
            this.btnBuscarejo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarejo.Location = new System.Drawing.Point(321, 125);
            this.btnBuscarejo.Name = "btnBuscarejo";
            this.btnBuscarejo.Size = new System.Drawing.Size(144, 33);
            this.btnBuscarejo.TabIndex = 60;
            this.btnBuscarejo.Text = "Buscar";
            this.btnBuscarejo.UseVisualStyleBackColor = true;
            this.btnBuscarejo.Click += new System.EventHandler(this.btnBuscarejo_Click);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(25, 128);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(277, 30);
            this.txtIdentificacion.TabIndex = 61;
            // 
            // FormRegistrarNotas
            // 
            this.ClientSize = new System.Drawing.Size(855, 581);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.btnBuscarejo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1Notas);
            this.Name = "FormRegistrarNotas";
            this.Load += new System.EventHandler(this.FormRegistrarNotas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentificacionNE;
        private System.Windows.Forms.Panel panelNotas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1Notas;
        private System.Windows.Forms.Button btnBuscarejo;
        private System.Windows.Forms.TextBox txtIdentificacion;
    }
}