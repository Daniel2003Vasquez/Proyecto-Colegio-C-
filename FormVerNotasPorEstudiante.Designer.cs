namespace ProyectoTercerCorte
{
    partial class FormVerNotasPorEstudiante
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentificacionVNE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarM = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Forte", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(100, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(643, 73);
            this.label6.TabIndex = 60;
            this.label6.Text = "Ver Notas Estudiante";
            // 
            // txtIdentificacionVNE
            // 
            this.txtIdentificacionVNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacionVNE.Location = new System.Drawing.Point(51, 159);
            this.txtIdentificacionVNE.Name = "txtIdentificacionVNE";
            this.txtIdentificacionVNE.Size = new System.Drawing.Size(277, 30);
            this.txtIdentificacionVNE.TabIndex = 64;
            this.txtIdentificacionVNE.Leave += new System.EventHandler(this.txtIdentificacionVNE_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(47, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Identificación:";
            // 
            // btnRegistrarM
            // 
            this.btnRegistrarM.Location = new System.Drawing.Point(348, 159);
            this.btnRegistrarM.Name = "btnRegistrarM";
            this.btnRegistrarM.Size = new System.Drawing.Size(94, 30);
            this.btnRegistrarM.TabIndex = 62;
            this.btnRegistrarM.Text = "Buscar";
            this.btnRegistrarM.UseVisualStyleBackColor = true;
            this.btnRegistrarM.Click += new System.EventHandler(this.btnRegistrarM_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormVerNotasPorEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 581);
            this.Controls.Add(this.txtIdentificacionVNE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrarM);
            this.Controls.Add(this.label6);
            this.Name = "FormVerNotasPorEstudiante";
            this.Text = "FormParaVerNotasPorEstudiante";
            this.Load += new System.EventHandler(this.FormVerNotasPorEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentificacionVNE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarM;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}