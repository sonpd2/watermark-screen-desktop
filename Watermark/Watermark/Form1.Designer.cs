namespace Watermark
{
    partial class Watermark
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 300000;
            timer1.Tick += updateTimer_Tick;
            // 
            // Watermark
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(259, 111);
            Font = new Font("Microsoft Sans Serif", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Watermark";
            Opacity = 0.2D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            TransparencyKey = Color.Gray;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            Paint += Watermark_Paint;
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Timer timer1;
    }
}