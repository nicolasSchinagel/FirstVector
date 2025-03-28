namespace VetoresND
{
    partial class FormRandom
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
            lblText1 = new Label();
            txtrandom = new TextBox();
            btngerar = new Button();
            SuspendLayout();
            // 
            // lblText1
            // 
            lblText1.AutoSize = true;
            lblText1.Location = new Point(12, 39);
            lblText1.Name = "lblText1";
            lblText1.Size = new Size(183, 15);
            lblText1.TabIndex = 0;
            lblText1.Text = "Os números aleatórios pares são :";
            // 
            // txtrandom
            // 
            txtrandom.Enabled = false;
            txtrandom.Location = new Point(250, 22);
            txtrandom.Multiline = true;
            txtrandom.Name = "txtrandom";
            txtrandom.ReadOnly = true;
            txtrandom.Size = new Size(271, 91);
            txtrandom.TabIndex = 1;
            // 
            // btngerar
            // 
            btngerar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btngerar.Location = new Point(299, 250);
            btngerar.Name = "btngerar";
            btngerar.Size = new Size(142, 122);
            btngerar.TabIndex = 2;
            btngerar.Text = "GERAR";
            btngerar.UseVisualStyleBackColor = true;
            btngerar.Click += btngerar_Click;
            // 
            // FormRandom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btngerar);
            Controls.Add(txtrandom);
            Controls.Add(lblText1);
            Name = "FormRandom";
            Text = "FormRandom";
            Load += FormRandom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText1;
        private TextBox txtrandom;
        private Button btngerar;
    }
}