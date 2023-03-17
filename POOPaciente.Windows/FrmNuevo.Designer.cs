
namespace POOPaciente.Windows
{
    partial class FrmNuevo
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
            this.AlturatextBox = new System.Windows.Forms.TextBox();
            this.PesotextBox = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.Label();
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FemeninoradioButton = new System.Windows.Forms.RadioButton();
            this.MasculinoradioButton = new System.Windows.Forms.RadioButton();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Documentotextbox = new System.Windows.Forms.TextBox();
            this.SegundoNombretextbox = new System.Windows.Forms.TextBox();
            this.PrimerNombretextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AlturatextBox
            // 
            this.AlturatextBox.Location = new System.Drawing.Point(139, 242);
            this.AlturatextBox.Name = "AlturatextBox";
            this.AlturatextBox.Size = new System.Drawing.Size(100, 20);
            this.AlturatextBox.TabIndex = 47;
            // 
            // PesotextBox
            // 
            this.PesotextBox.Location = new System.Drawing.Point(158, 202);
            this.PesotextBox.Name = "PesotextBox";
            this.PesotextBox.Size = new System.Drawing.Size(100, 20);
            this.PesotextBox.TabIndex = 46;
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(51, 249);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(34, 13);
            this.Altura.TabIndex = 45;
            this.Altura.Text = "Altura";
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Location = new System.Drawing.Point(54, 209);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(31, 13);
            this.Peso.TabIndex = 44;
            this.Peso.Text = "Peso";
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.Location = new System.Drawing.Point(158, 130);
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(100, 20);
            this.ApellidotextBox.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Apellido";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(349, 268);
            this.FechadateTimePicker.MaxDate = new System.DateTime(2023, 3, 14, 0, 0, 0, 0);
            this.FechadateTimePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(107, 20);
            this.FechadateTimePicker.TabIndex = 41;
            this.FechadateTimePicker.Value = new System.DateTime(2023, 3, 14, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Edad";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FemeninoradioButton);
            this.panel1.Controls.Add(this.MasculinoradioButton);
            this.panel1.Location = new System.Drawing.Point(369, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 98);
            this.panel1.TabIndex = 39;
            // 
            // FemeninoradioButton
            // 
            this.FemeninoradioButton.AutoSize = true;
            this.FemeninoradioButton.Checked = true;
            this.FemeninoradioButton.Location = new System.Drawing.Point(16, 55);
            this.FemeninoradioButton.Name = "FemeninoradioButton";
            this.FemeninoradioButton.Size = new System.Drawing.Size(71, 17);
            this.FemeninoradioButton.TabIndex = 1;
            this.FemeninoradioButton.TabStop = true;
            this.FemeninoradioButton.Text = "Femenino";
            this.FemeninoradioButton.UseVisualStyleBackColor = true;
            // 
            // MasculinoradioButton
            // 
            this.MasculinoradioButton.AutoSize = true;
            this.MasculinoradioButton.Location = new System.Drawing.Point(16, 21);
            this.MasculinoradioButton.Name = "MasculinoradioButton";
            this.MasculinoradioButton.Size = new System.Drawing.Size(73, 17);
            this.MasculinoradioButton.TabIndex = 0;
            this.MasculinoradioButton.Text = "Masculino";
            this.MasculinoradioButton.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(214, 340);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 62);
            this.Cancelbutton.TabIndex = 37;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(52, 340);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 62);
            this.OKbutton.TabIndex = 38;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Documentotextbox
            // 
            this.Documentotextbox.Location = new System.Drawing.Point(167, 167);
            this.Documentotextbox.MaxLength = 9;
            this.Documentotextbox.Name = "Documentotextbox";
            this.Documentotextbox.Size = new System.Drawing.Size(100, 20);
            this.Documentotextbox.TabIndex = 36;
            // 
            // SegundoNombretextbox
            // 
            this.SegundoNombretextbox.Location = new System.Drawing.Point(158, 87);
            this.SegundoNombretextbox.Name = "SegundoNombretextbox";
            this.SegundoNombretextbox.Size = new System.Drawing.Size(100, 20);
            this.SegundoNombretextbox.TabIndex = 34;
            // 
            // PrimerNombretextbox
            // 
            this.PrimerNombretextbox.Location = new System.Drawing.Point(158, 45);
            this.PrimerNombretextbox.Name = "PrimerNombretextbox";
            this.PrimerNombretextbox.Size = new System.Drawing.Size(100, 20);
            this.PrimerNombretextbox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "SegundoNombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "PrimerNombre";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.AlturatextBox);
            this.Controls.Add(this.PesotextBox);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.ApellidotextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Documentotextbox);
            this.Controls.Add(this.SegundoNombretextbox);
            this.Controls.Add(this.PrimerNombretextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNuevo";
            this.Text = "FrmNuevo";
            this.Load += new System.EventHandler(this.FrmNuevo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AlturatextBox;
        private System.Windows.Forms.TextBox PesotextBox;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton FemeninoradioButton;
        private System.Windows.Forms.RadioButton MasculinoradioButton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.TextBox Documentotextbox;
        private System.Windows.Forms.TextBox SegundoNombretextbox;
        private System.Windows.Forms.TextBox PrimerNombretextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}