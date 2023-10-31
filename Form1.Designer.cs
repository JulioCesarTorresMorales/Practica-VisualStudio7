namespace Practica7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            valor = new TextBox();
            Resultado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 36);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 80);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresa Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 147);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 2;
            label3.Text = "Opciones de Conversion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 258);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 3;
            label4.Text = "Resultado en Grados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 283);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 4;
            label5.Text = "Equivalente en Grados:";
            // 
            // valor
            // 
            valor.Location = new Point(376, 72);
            valor.Name = "valor";
            valor.Size = new Size(131, 23);
            valor.TabIndex = 5;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(288, 313);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(104, 23);
            Resultado.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(222, 175);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 8;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(376, 175);
            button2.Name = "button2";
            button2.Size = new Size(124, 34);
            button2.TabIndex = 9;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(299, 218);
            button3.Name = "button3";
            button3.Size = new Size(124, 34);
            button3.TabIndex = 10;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Resultado);
            Controls.Add(valor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Conversiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox valor;
        private TextBox Resultado;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}