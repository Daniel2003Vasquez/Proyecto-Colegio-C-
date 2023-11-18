namespace ProyectoTercerCorte
{
    partial class FormRegistrarMateria
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelarM = new System.Windows.Forms.Button();
            this.btnRegistrarM = new System.Windows.Forms.Button();
            this.comboNombreM = new System.Windows.Forms.ComboBox();
            this.labelChismoso = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre de Materia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Forte", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(150, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(547, 73);
            this.label6.TabIndex = 45;
            this.label6.Text = "Registrar Materia";
            // 
            // btnCancelarM
            // 
            this.btnCancelarM.Location = new System.Drawing.Point(543, 153);
            this.btnCancelarM.Name = "btnCancelarM";
            this.btnCancelarM.Size = new System.Drawing.Size(123, 44);
            this.btnCancelarM.TabIndex = 47;
            this.btnCancelarM.Text = "Cancelar";
            this.btnCancelarM.UseVisualStyleBackColor = true;
            this.btnCancelarM.Click += new System.EventHandler(this.btnCancelarM_Click);
            // 
            // btnRegistrarM
            // 
            this.btnRegistrarM.Location = new System.Drawing.Point(401, 153);
            this.btnRegistrarM.Name = "btnRegistrarM";
            this.btnRegistrarM.Size = new System.Drawing.Size(123, 44);
            this.btnRegistrarM.TabIndex = 46;
            this.btnRegistrarM.Text = "Registrar";
            this.btnRegistrarM.UseVisualStyleBackColor = true;
            this.btnRegistrarM.Click += new System.EventHandler(this.btnRegistrarM_Click);
            // 
            // comboNombreM
            // 
            this.comboNombreM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboNombreM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboNombreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNombreM.FormattingEnabled = true;
            this.comboNombreM.Items.AddRange(new object[] {
            "Biología",
            "Español",
            "Sociales",
            "Inglés",
            "Informática",
            "Matemáticas",
            "Programación"});
            this.comboNombreM.Location = new System.Drawing.Point(51, 159);
            this.comboNombreM.Name = "comboNombreM";
            this.comboNombreM.Size = new System.Drawing.Size(331, 30);
            this.comboNombreM.TabIndex = 48;
            // 
            // labelChismoso
            // 
            this.labelChismoso.AutoSize = true;
            this.labelChismoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChismoso.Location = new System.Drawing.Point(35, 247);
            this.labelChismoso.Name = "labelChismoso";
            this.labelChismoso.Size = new System.Drawing.Size(0, 29);
            this.labelChismoso.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.Serial});
            this.dataGridView1.Location = new System.Drawing.Point(277, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(566, 314);
            this.dataGridView1.TabIndex = 50;
            // 
            // Materia
            // 
            this.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            // 
            // Serial
            // 
            this.Serial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Serial.HeaderText = "Serial";
            this.Serial.MinimumWidth = 6;
            this.Serial.Name = "Serial";
            // 
            // FormRegistrarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelChismoso);
            this.Controls.Add(this.comboNombreM);
            this.Controls.Add(this.btnCancelarM);
            this.Controls.Add(this.btnRegistrarM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrarMateria";
            this.Text = "FormRegistrarMateria";
            this.Load += new System.EventHandler(this.FormRegistrarMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelarM;
        private System.Windows.Forms.Button btnRegistrarM;
        private System.Windows.Forms.ComboBox comboNombreM;
        private System.Windows.Forms.Label labelChismoso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
    }
}