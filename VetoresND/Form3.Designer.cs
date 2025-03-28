namespace VetoresND
{
    partial class Form3
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
            lblnota = new Label();
            txtgrade = new TextBox();
            btngerar = new Button();
            txtmedia = new TextBox();
            lblmedia = new Label();
            btncadastrar = new Button();
            lblpermissao = new Label();
            SuspendLayout();
            // 
            // lblnota
            // 
            lblnota.AutoSize = true;
            lblnota.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnota.Location = new Point(75, 83);
            lblnota.Name = "lblnota";
            lblnota.Size = new Size(177, 37);
            lblnota.TabIndex = 0;
            lblnota.Text = "Digite a nota:";
            lblnota.Click += label1_Click;
            // 
            // txtgrade
            // 
            txtgrade.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtgrade.Location = new Point(293, 83);
            txtgrade.Name = "txtgrade";
            txtgrade.Size = new Size(238, 43);
            txtgrade.TabIndex = 1;
            // 
            // btngerar
            // 
            btngerar.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btngerar.Location = new Point(396, 306);
            btngerar.Name = "btngerar";
            btngerar.Size = new Size(211, 95);
            btngerar.TabIndex = 2;
            btngerar.Text = "Gerar Média";
            btngerar.UseVisualStyleBackColor = true;
            btngerar.Click += btngerar_Click;
            // 
            // txtmedia
            // 
            txtmedia.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmedia.Location = new Point(293, 170);
            txtmedia.Name = "txtmedia";
            txtmedia.Size = new Size(238, 46);
            txtmedia.TabIndex = 3;
            // 
            // lblmedia
            // 
            lblmedia.AutoSize = true;
            lblmedia.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmedia.Location = new Point(75, 170);
            lblmedia.Name = "lblmedia";
            lblmedia.Size = new Size(188, 37);
            lblmedia.TabIndex = 4;
            lblmedia.Text = "Média da sala:";
            lblmedia.Click += label1_Click_1;
            // 
            // btncadastrar
            // 
            btncadastrar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncadastrar.Location = new Point(152, 308);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(178, 93);
            btncadastrar.TabIndex = 5;
            btncadastrar.Text = "Cadastrar nota";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // lblpermissao
            // 
            lblpermissao.AutoSize = true;
            lblpermissao.Location = new Point(630, 92);
            lblpermissao.Name = "lblpermissao";
            lblpermissao.Size = new Size(0, 15);
            lblpermissao.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 583);
            Controls.Add(lblpermissao);
            Controls.Add(btncadastrar);
            Controls.Add(lblmedia);
            Controls.Add(txtmedia);
            Controls.Add(btngerar);
            Controls.Add(txtgrade);
            Controls.Add(lblnota);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnota;
        private TextBox txtgrade;
        private Button btngerar;
        private TextBox txtmedia;
        private Label lblmedia;
        private Button btncadastrar;
        private Label lblpermissao;
    }
}