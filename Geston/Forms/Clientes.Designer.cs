namespace Geston
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_atualizar = new System.Windows.Forms.TextBox();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_descricaoat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_deletar = new System.Windows.Forms.TextBox();
            this.btndeletar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(65, 37);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(76, 20);
            this.descricao.TabIndex = 2;
            this.descricao.Text = "Teste";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(65, 135);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(76, 20);
            this.id.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Buscar Todos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(5, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(9, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 101);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Buscar Por ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(9, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 87);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Inserir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id";
            // 
            // txt_atualizar
            // 
            this.txt_atualizar.Location = new System.Drawing.Point(64, 239);
            this.txt_atualizar.Name = "txt_atualizar";
            this.txt_atualizar.Size = new System.Drawing.Size(76, 20);
            this.txt_atualizar.TabIndex = 12;
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(65, 302);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(75, 23);
            this.btnatualizar.TabIndex = 11;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txt_descricaoat);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(8, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 131);
            this.panel4.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descrição";
            // 
            // txt_descricaoat
            // 
            this.txt_descricaoat.Location = new System.Drawing.Point(56, 71);
            this.txt_descricaoat.Name = "txt_descricaoat";
            this.txt_descricaoat.Size = new System.Drawing.Size(76, 20);
            this.txt_descricaoat.TabIndex = 15;
            this.txt_descricaoat.Text = "Teste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Atualizar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Id";
            // 
            // txt_deletar
            // 
            this.txt_deletar.Location = new System.Drawing.Point(64, 373);
            this.txt_deletar.Name = "txt_deletar";
            this.txt_deletar.Size = new System.Drawing.Size(76, 20);
            this.txt_deletar.TabIndex = 12;
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(65, 399);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(75, 23);
            this.btndeletar.TabIndex = 11;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(8, 339);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(196, 101);
            this.panel5.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Deletar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 519);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_deletar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.txt_atualizar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_atualizar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_descricaoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_deletar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
    }
}

