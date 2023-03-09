namespace Formulario_Contactos_Arreglo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtcell = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.CONTACTO = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnumcontact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(106, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "TELÉFONO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA DE NACIMIENTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "CORREO ELECTRÓNICO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(228, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "AGENDA DE CONTACTOS";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(211, 142);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(366, 23);
            this.txtname.TabIndex = 5;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(211, 312);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(366, 23);
            this.txtcorreo.TabIndex = 6;
            // 
            // txtcell
            // 
            this.txtcell.Location = new System.Drawing.Point(211, 195);
            this.txtcell.Name = "txtcell";
            this.txtcell.Size = new System.Drawing.Size(184, 23);
            this.txtcell.TabIndex = 7;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(211, 253);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(184, 25);
            this.dtpfecha.TabIndex = 8;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsalir.Location = new System.Drawing.Point(482, 370);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(95, 42);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmostrar.Location = new System.Drawing.Point(779, 22);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(114, 38);
            this.btnmostrar.TabIndex = 10;
            this.btnmostrar.Text = "MOSTRAR";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // CONTACTO
            // 
            this.CONTACTO.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CONTACTO.FormattingEnabled = true;
            this.CONTACTO.ItemHeight = 17;
            this.CONTACTO.Location = new System.Drawing.Point(592, 85);
            this.CONTACTO.Name = "CONTACTO";
            this.CONTACTO.Size = new System.Drawing.Size(461, 327);
            this.CONTACTO.TabIndex = 11;
            this.CONTACTO.SelectedIndexChanged += new System.EventHandler(this.CONTACTO_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(459, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnumcontact
            // 
            this.txtnumcontact.Location = new System.Drawing.Point(211, 95);
            this.txtnumcontact.Name = "txtnumcontact";
            this.txtnumcontact.Size = new System.Drawing.Size(242, 23);
            this.txtnumcontact.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(68, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "N° CONTACTOS:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnumcontact);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CONTACTO);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtcell);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtname;
        private TextBox txtcorreo;
        private TextBox txtcell;
        private DateTimePicker dtpfecha;
        private Button btnsalir;
        private Button btnmostrar;
        private ListBox CONTACTO;
        private Button button1;
        private TextBox txtnumcontact;
        private Label label6;
    }
}