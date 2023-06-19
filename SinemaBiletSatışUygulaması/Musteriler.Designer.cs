namespace SinemaBiletSatışUygulaması
{
    partial class Musteriler
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 58);
            label1.Name = "label1";
            label1.Size = new Size(98, 18);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 87);
            label2.Name = "label2";
            label2.Size = new Size(119, 18);
            label2.TabIndex = 1;
            label2.Text = "Müşteri Soyadi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lavender;
            label3.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 122);
            label3.Name = "label3";
            label3.Size = new Size(126, 18);
            label3.TabIndex = 2;
            label3.Text = "Müşteri Telefon :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lavender;
            label4.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 162);
            label4.Name = "label4";
            label4.Size = new Size(121, 18);
            label4.TabIndex = 3;
            label4.Text = "Müşteri E-Mail :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(148, 121);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(72, 228);
            button1.Name = "button1";
            button1.Size = new Size(80, 36);
            button1.TabIndex = 8;
            button1.Text = "Tamam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Tamam;
            // 
            // button2
            // 
            button2.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(158, 228);
            button2.Name = "button2";
            button2.Size = new Size(90, 36);
            button2.TabIndex = 9;
            button2.Text = "Iptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += İptal;
            // 
            // Musteriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(265, 304);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Musteriler";
            Text = "Musteriler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}