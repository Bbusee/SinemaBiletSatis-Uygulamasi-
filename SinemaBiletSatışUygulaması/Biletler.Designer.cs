namespace SinemaBiletSatışUygulaması
{
    partial class Biletler
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(112, 18);
            label1.TabIndex = 0;
            label1.Text = "Bilet Film Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 108);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 1;
            label2.Text = "Bilet Seans :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lavender;
            label3.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 141);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 2;
            label3.Text = "Bilet Fiyat :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Modern No. 20", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(50, 208);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 6;
            button1.Text = "Tamam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Tamam;
            // 
            // button2
            // 
            button2.Font = new Font("Modern No. 20", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(143, 208);
            button2.Name = "button2";
            button2.Size = new Size(87, 33);
            button2.TabIndex = 7;
            button2.Text = "Iptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += İptal;
            // 
            // Biletler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(246, 312);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Biletler";
            Text = "Biletler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}