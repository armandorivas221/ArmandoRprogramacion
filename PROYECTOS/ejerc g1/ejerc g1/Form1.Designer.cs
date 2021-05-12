
namespace ejerc_g1
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
            this.btonAñadir = new System.Windows.Forms.Button();
            this.dtgvDato = new System.Windows.Forms.DataGridView();
            this.textAñadir = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDato)).BeginInit();
            this.SuspendLayout();
            // 
            // btonAñadir
            // 
            this.btonAñadir.Location = new System.Drawing.Point(12, 12);
            this.btonAñadir.Name = "btonAñadir";
            this.btonAñadir.Size = new System.Drawing.Size(343, 240);
            this.btonAñadir.TabIndex = 0;
            this.btonAñadir.Text = "Añadir";
            this.btonAñadir.UseVisualStyleBackColor = true;
            this.btonAñadir.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvDato
            // 
            this.dtgvDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dtgvDato.Location = new System.Drawing.Point(441, 12);
            this.dtgvDato.Name = "dtgvDato";
            this.dtgvDato.Size = new System.Drawing.Size(347, 240);
            this.dtgvDato.TabIndex = 1;
            this.dtgvDato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textAñadir
            // 
            this.textAñadir.Location = new System.Drawing.Point(13, 273);
            this.textAñadir.Name = "textAñadir";
            this.textAñadir.Size = new System.Drawing.Size(342, 20);
            this.textAñadir.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dato";
            this.Column1.Name = "Column1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textAñadir);
            this.Controls.Add(this.dtgvDato);
            this.Controls.Add(this.btonAñadir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonAñadir;
        private System.Windows.Forms.DataGridView dtgvDato;
        private System.Windows.Forms.TextBox textAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

