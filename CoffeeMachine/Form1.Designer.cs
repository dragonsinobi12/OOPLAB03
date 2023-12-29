namespace CoffeeMachine
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
            BlackCoffeeWindow = new Button();
            blackcoffee = new Button();
            mocha = new Button();
            chocoBlackCoffeeWindow = new Button();
            checkadmin = new Button();
            showitem = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)showitem).BeginInit();
            SuspendLayout();
            // 
            // BlackCoffeeWindow
            // 
            BlackCoffeeWindow.Location = new Point(124, 36);
            BlackCoffeeWindow.Name = "BlackCoffeeWindow";
            BlackCoffeeWindow.Size = new Size(163, 62);
            BlackCoffeeWindow.TabIndex = 0;
            BlackCoffeeWindow.Text = "Late";
            BlackCoffeeWindow.UseVisualStyleBackColor = true;
            BlackCoffeeWindow.Click += BlackCoffeeWindow_Click;
            // 
            // blackcoffee
            // 
            blackcoffee.Location = new Point(124, 98);
            blackcoffee.Name = "blackcoffee";
            blackcoffee.Size = new Size(163, 62);
            blackcoffee.TabIndex = 1;
            blackcoffee.Text = "Black coffee";
            blackcoffee.UseVisualStyleBackColor = true;
            blackcoffee.Click += button2_Click;
            // 
            // mocha
            // 
            mocha.Location = new Point(124, 160);
            mocha.Name = "mocha";
            mocha.Size = new Size(163, 62);
            mocha.TabIndex = 2;
            mocha.Text = "Mocha";
            mocha.UseVisualStyleBackColor = true;
            mocha.Click += mocha_Click;
            // 
            // chocoBlackCoffeeWindow
            // 
            chocoBlackCoffeeWindow.Location = new Point(124, 222);
            chocoBlackCoffeeWindow.Name = "chocoBlackCoffeeWindow";
            chocoBlackCoffeeWindow.Size = new Size(163, 62);
            chocoBlackCoffeeWindow.TabIndex = 3;
            chocoBlackCoffeeWindow.Text = "Chocolate";
            chocoBlackCoffeeWindow.UseVisualStyleBackColor = true;
            chocoBlackCoffeeWindow.Click += button4_Click;
            // 
            // checkadmin
            // 
            checkadmin.Location = new Point(266, 539);
            checkadmin.Name = "checkadmin";
            checkadmin.Size = new Size(99, 62);
            checkadmin.TabIndex = 4;
            checkadmin.Text = "Admin";
            checkadmin.UseVisualStyleBackColor = true;
            checkadmin.Click += checkadmin_Click;
            // 
            // showitem
            // 
            showitem.Location = new Point(180, 306);
            showitem.Name = "showitem";
            showitem.Size = new Size(87, 83);
            showitem.SizeMode = PictureBoxSizeMode.StretchImage;
            showitem.TabIndex = 5;
            showitem.TabStop = false;
            showitem.Click += showitem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1674527386_56811_image2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(386, 645);
            Controls.Add(showitem);
            Controls.Add(checkadmin);
            Controls.Add(chocoBlackCoffeeWindow);
            Controls.Add(mocha);
            Controls.Add(blackcoffee);
            Controls.Add(BlackCoffeeWindow);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)showitem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BlackCoffeeWindow;
        private Button blackcoffee;
        private Button mocha;
        private Button chocoBlackCoffeeWindow;
        private Button checkadmin;
        internal PictureBox showitem;
    }
}
