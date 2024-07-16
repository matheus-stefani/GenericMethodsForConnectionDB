namespace SpassoCasaERPDesktop
{
    partial class Form1
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputIdN = new System.Windows.Forms.TextBox();
            this.inputNomeS = new System.Windows.Forms.TextBox();
            this.inputEndS = new System.Windows.Forms.TextBox();
            this.inputEmailS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.inputTelefoneS = new System.Windows.Forms.MaskedTextBox();
            this.inputValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(230, 386);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço";
            // 
            // inputIdN
            // 
            this.inputIdN.Location = new System.Drawing.Point(224, 68);
            this.inputIdN.Name = "inputIdN";
            this.inputIdN.Size = new System.Drawing.Size(100, 20);
            this.inputIdN.TabIndex = 4;
            // 
            // inputNomeS
            // 
            this.inputNomeS.Location = new System.Drawing.Point(224, 131);
            this.inputNomeS.Name = "inputNomeS";
            this.inputNomeS.Size = new System.Drawing.Size(160, 20);
            this.inputNomeS.TabIndex = 5;
            // 
            // inputEndS
            // 
            this.inputEndS.Location = new System.Drawing.Point(224, 190);
            this.inputEndS.Name = "inputEndS";
            this.inputEndS.Size = new System.Drawing.Size(160, 20);
            this.inputEndS.TabIndex = 6;
            // 
            // inputEmailS
            // 
            this.inputEmailS.Location = new System.Drawing.Point(224, 313);
            this.inputEmailS.Name = "inputEmailS";
            this.inputEmailS.Size = new System.Drawing.Size(160, 20);
            this.inputEmailS.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefone";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(399, 386);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(532, 386);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 12;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // inputTelefoneS
            // 
            this.inputTelefoneS.Location = new System.Drawing.Point(224, 253);
            this.inputTelefoneS.Mask = "(99)99999-9999";
            this.inputTelefoneS.Name = "inputTelefoneS";
            this.inputTelefoneS.Size = new System.Drawing.Size(100, 20);
            this.inputTelefoneS.TabIndex = 13;
            // 
            // inputValor
            // 
            this.inputValor.Location = new System.Drawing.Point(504, 214);
            this.inputValor.Name = "inputValor";
            this.inputValor.Size = new System.Drawing.Size(160, 20);
            this.inputValor.TabIndex = 15;
            this.inputValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.inputValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputValor_KeyDown);
            this.inputValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputValor_KeyPress);
            this.inputValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputValor_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(504, 130);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.inputValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputTelefoneS);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputEmailS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputEndS);
            this.Controls.Add(this.inputNomeS);
            this.Controls.Add(this.inputIdN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputIdN;
        private System.Windows.Forms.TextBox inputNomeS;
        private System.Windows.Forms.TextBox inputEndS;
        private System.Windows.Forms.TextBox inputEmailS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.MaskedTextBox inputTelefoneS;
        private System.Windows.Forms.TextBox inputValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

