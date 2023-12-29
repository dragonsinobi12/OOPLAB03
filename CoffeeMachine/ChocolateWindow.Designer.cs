namespace CoffeeMachine
{
    partial class ChocolateWindow
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
            ok = new Button();
            nook = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ok
            // 
            ok.Location = new Point(124, 311);
            ok.Name = "ok";
            ok.Size = new Size(75, 23);
            ok.TabIndex = 0;
            ok.Text = "ยืนยัน";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // nook
            // 
            nook.Location = new Point(254, 311);
            nook.Name = "nook";
            nook.Size = new Size(75, 23);
            nook.TabIndex = 1;
            nook.Text = "ยกเลิก";
            nook.UseVisualStyleBackColor = true;
            nook.Click += nook_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chocolate;
            pictureBox1.Location = new Point(134, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "ส่วนประกอบของช็อคโกเล็ต";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "ช็อคโกเล็ต ประกอบด้วย น้ำ 300g,ช็อคโกเล็ต 20g";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // ChocolateWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 362);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(nook);
            Controls.Add(ok);
            Name = "ChocolateWindow";
            Text = "ChocolateWindow";
            Load += ChocolateWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ok;
        private Button nook;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}