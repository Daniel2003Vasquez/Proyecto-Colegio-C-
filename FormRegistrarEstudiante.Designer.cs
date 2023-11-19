namespace ProyectoTercerCorte
{
    partial class FormRegistrarEstudiante
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
            this.btnCancelarE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentidicacionE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarE = new System.Windows.Forms.Button();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefonoE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreoE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboGeneroE = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarE
            // 
            this.btnCancelarE.Location = new System.Drawing.Point(638, 392);
            this.btnCancelarE.Name = "btnCancelarE";
            this.btnCancelarE.Size = new System.Drawing.Size(123, 44);
            this.btnCancelarE.TabIndex = 8;
            this.btnCancelarE.Text = "Cancelar";
            this.btnCancelarE.UseVisualStyleBackColor = true;
            this.btnCancelarE.Click += new System.EventHandler(this.btnCancelarR_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Forte", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(95, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(617, 73);
            this.label6.TabIndex = 41;
            this.label6.Text = "Registrar Estudiante";
            // 
            // txtIdentidicacionE
            // 
            this.txtIdentidicacionE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidicacionE.Location = new System.Drawing.Point(463, 158);
            this.txtIdentidicacionE.Name = "txtIdentidicacionE";
            this.txtIdentidicacionE.Size = new System.Drawing.Size(309, 30);
            this.txtIdentidicacionE.TabIndex = 2;
            this.txtIdentidicacionE.Leave += new System.EventHandler(this.txtIdentidicacionE_Leave_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Identificación";
            // 
            // btnRegistrarE
            // 
            this.btnRegistrarE.Location = new System.Drawing.Point(483, 392);
            this.btnRegistrarE.Name = "btnRegistrarE";
            this.btnRegistrarE.Size = new System.Drawing.Size(123, 44);
            this.btnRegistrarE.TabIndex = 7;
            this.btnRegistrarE.Text = "Registrar";
            this.btnRegistrarE.UseVisualStyleBackColor = true;
            this.btnRegistrarE.Click += new System.EventHandler(this.btnRegistrarM_Click);
            // 
            // txtNombreE
            // 
            this.txtNombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreE.Location = new System.Drawing.Point(37, 158);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(331, 30);
            this.txtNombreE.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nombre Completo";
            // 
            // txtTelefonoE
            // 
            this.txtTelefonoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoE.Location = new System.Drawing.Point(463, 245);
            this.txtTelefonoE.Name = "txtTelefonoE";
            this.txtTelefonoE.Size = new System.Drawing.Size(309, 30);
            this.txtTelefonoE.TabIndex = 4;
            this.txtTelefonoE.Leave += new System.EventHandler(this.txtIdentidicacionE_Leave_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // txtCorreoE
            // 
            this.txtCorreoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoE.Location = new System.Drawing.Point(37, 328);
            this.txtCorreoE.Name = "txtCorreoE";
            this.txtCorreoE.Size = new System.Drawing.Size(331, 30);
            this.txtCorreoE.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Correo";
            // 
            // DateFechaNacimiento
            // 
            this.DateFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFechaNacimiento.Location = new System.Drawing.Point(37, 245);
            this.DateFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateFechaNacimiento.Name = "DateFechaNacimiento";
            this.DateFechaNacimiento.Size = new System.Drawing.Size(331, 30);
            this.DateFechaNacimiento.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(463, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Género Biológico";
            // 
            // comboGeneroE
            // 
            this.comboGeneroE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboGeneroE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboGeneroE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGeneroE.FormattingEnabled = true;
            this.comboGeneroE.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.comboGeneroE.Location = new System.Drawing.Point(463, 328);
            this.comboGeneroE.Name = "comboGeneroE";
            this.comboGeneroE.Size = new System.Drawing.Size(309, 30);
            this.comboGeneroE.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormRegistrarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 581);
            this.Controls.Add(this.comboGeneroE);
            this.Controls.Add(this.DateFechaNacimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreoE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefonoE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelarE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdentidicacionE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrarE);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrarEstudiante";
            this.Text = "FormRegistrarEstudiante";
            this.Load += new System.EventHandler(this.FormRegistrarEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentidicacionE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefonoE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreoE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateFechaNacimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboGeneroE;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}