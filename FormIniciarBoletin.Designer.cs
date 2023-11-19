namespace ProyectoTercerCorte
{
    partial class FormIniciarBoletin
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
            this.txtIdentificacionB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 40.2F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(190, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 73);
            this.label3.TabIndex = 64;
            this.label3.Text = "Buscar Boletin";
            // 
            // txtIdentificacionB
            // 
            this.txtIdentificacionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacionB.Location = new System.Drawing.Point(25, 128);
            this.txtIdentificacionB.Name = "txtIdentificacionB";
            this.txtIdentificacionB.Size = new System.Drawing.Size(277, 30);
            this.txtIdentificacionB.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Identificación:";
            // 
            // btnRegistrarB
            // 
            this.btnRegistrarB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarB.Location = new System.Drawing.Point(308, 125);
            this.btnRegistrarB.Name = "btnRegistrarB";
            this.btnRegistrarB.Size = new System.Drawing.Size(144, 33);
            this.btnRegistrarB.TabIndex = 61;
            this.btnRegistrarB.Text = "Buscar";
            this.btnRegistrarB.UseVisualStyleBackColor = true;
            this.btnRegistrarB.Click += new System.EventHandler(this.btnRegistrarB_Click);
            // 
            // FormIniciarBoletin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdentificacionB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrarB);
            this.Name = "FormIniciarBoletin";
            this.Text = "FormIniciarBoletin";
            this.Load += new System.EventHandler(this.FormIniciarBoletin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificacionB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarB;
    }
}