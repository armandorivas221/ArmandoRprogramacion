
using System.Windows.Forms;


namespace Armando01.VISTA
{
    partial class FrmAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        
        
        private System.ComponentModel.IContainer component = null;
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (component != null))
            {
                component.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponents()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtIv1 = new System.Windows.Forms.TextBox();
            this.txtNompreDeproduco = new System.Windows.Forms.TextBox();
            this.txtPresioProducto3 = new System.Windows.Forms.TextBox();
            this.txtTotl = new System.Windows.Forms.TextBox();
            this.butto1 = new System.Windows.Forms.Button();
            this.labe5 = new System.Windows.Forms.Label();
            this.labe6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labe8 = new System.Windows.Forms.Label();
            this.labe9 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labe4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Presio del producto";
            // 
            // label4
            // 
            this.label14.AutoSize = true;
            this.labe114.Location = new System.Drawing.Point(39, 354);
            this.label1.Name = "label4";
            this.labl3.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "SI EL PRODUCTO TIENE UN PRECIO MENOR o IGUAL 50 NO TENDRÁ DESCUENTO\t\t|\t<=50",
            "",
            "SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100 TENDRÁ UN DESCUENTO\t|\t " +
                ">0.50 and <",
            "\t\t\t\t\t\t\t\t\t",
            "",
            "SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL A 100 O MENOR QUE 101 TENDRÁ UN\t|\t>=" +
                " 100 and <101",
            "DESCUENTO DEL 0.10",
            "",
            "SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL 101 Y MENOR QUE 150 TENDRÁ UN\t|\t>= 1" +
                "01 and <150",
            "DESCUENTO DEL 0.20",
            "",
            "SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRÁ UN DESCUENTO DEL 0.50\t\t|\t>= 150" +
                ""});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 154);
            this.listBox1.TabIndex = 4;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(284, 230);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 23);
            this.txtIva.TabIndex = 5;
            // 
            // txtNompreDeproducto
            // 
            this.txtNompreDeproducto.Location = new System.Drawing.Point(284, 268);
            this.txtNompreDeproducto.Name = "txtNompreDeproducto";
            this.txtNompreDeproducto.Size = new System.Drawing.Size(100, 23);
            this.txtNompreDeproducto.TabIndex = 6;
            // 
            // txtPresioProducto
            // 
            this.txtPresioProducto.Location = new System.Drawing.Point(284, 311);
            this.txtPresioProducto.Name = "txtPresioProducto";
            this.txtPresioProducto.Size = new System.Drawing.Size(100, 23);
            this.txtPresioProducto.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(284, 354);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total sin iva:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "iva agregar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "total sin descuento y con iva incluido:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total a pagar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(668, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Coca";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(668, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "100";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(668, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "13";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(668, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "113";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(668, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "113";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPresioProducto);
            this.Controls.Add(this.txtNompreDeproducto);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lael4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuario";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ListBox listBox2;
        private TextBox txtIv1;
        private TextBox txtNompreDeproduco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Label labe4;
        private System.Windows.Forms.Label lbel4;
        private System.Windows.Forms.ListBox listBx1;
        private System.Windows.Forms.TextBox txtva;
        private System.Windows.Forms.TextBox txtNompreDeproucto;
        private System.Windows.Forms.TextBox txtPresoProducto;
        private System.Windows.Forms.TextBox txtToal;
        private System.Windows.Forms.Button buttn1;
        private System.Windows.Forms.Label lael5;
        private System.Windows.Forms.Label labl6;
        private System.Windows.Forms.Label lael7;
        private System.Windows.Forms.Label lael8;
        private System.Windows.Forms.Label lael9;
        private System.Windows.Forms.Label lbel10;
        private System.Windows.Forms.Label labl11;
        private System.Windows.Forms.Label labe12;
        private System.Windows.Forms.Label labe13;
        private System.Windows.Forms.Label label14;
        private object txtPresioProducto3;

        public TextBox TexBox { get; private set; }

        private TextBox txtTotl;
        private Button butto1;
        private Label labe5;
        private Label labe6;
        private Label label;
        private Label labe8;
        private Label labe9;
        private Label label0;
        private Control lael4;
        private object labl3;
        private object labe114;
    }
}