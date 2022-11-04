namespace WindowsPresentacion
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
            this.bttnVerMedicos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnMostrarPacientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bttnMostrarClinicos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnVerMedicos
            // 
            this.bttnVerMedicos.Location = new System.Drawing.Point(30, 32);
            this.bttnVerMedicos.Name = "bttnVerMedicos";
            this.bttnVerMedicos.Size = new System.Drawing.Size(117, 49);
            this.bttnVerMedicos.TabIndex = 0;
            this.bttnVerMedicos.Text = "Ver Medicos";
            this.bttnVerMedicos.UseVisualStyleBackColor = true;
            this.bttnVerMedicos.Click += new System.EventHandler(this.bttnVerMedicos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 192);
            this.dataGridView1.TabIndex = 1;
            // 
            // bttnMostrarPacientes
            // 
            this.bttnMostrarPacientes.Location = new System.Drawing.Point(192, 32);
            this.bttnMostrarPacientes.Name = "bttnMostrarPacientes";
            this.bttnMostrarPacientes.Size = new System.Drawing.Size(129, 49);
            this.bttnMostrarPacientes.TabIndex = 2;
            this.bttnMostrarPacientes.Text = "Mostrar Pacientes";
            this.bttnMostrarPacientes.UseVisualStyleBackColor = true;
            this.bttnMostrarPacientes.Click += new System.EventHandler(this.bttnMostrarPacientes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver Habitaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(30, 394);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1026, 180);
            this.listBox1.TabIndex = 4;
            // 
            // bttnMostrarClinicos
            // 
            this.bttnMostrarClinicos.Location = new System.Drawing.Point(30, 337);
            this.bttnMostrarClinicos.Name = "bttnMostrarClinicos";
            this.bttnMostrarClinicos.Size = new System.Drawing.Size(117, 37);
            this.bttnMostrarClinicos.TabIndex = 5;
            this.bttnMostrarClinicos.Text = "Ver Med.Clinicos";
            this.bttnMostrarClinicos.UseVisualStyleBackColor = true;
            this.bttnMostrarClinicos.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 586);
            this.Controls.Add(this.bttnMostrarClinicos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttnMostrarPacientes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttnVerMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnVerMedicos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnMostrarPacientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bttnMostrarClinicos;
    }
}

