namespace CameraDetection
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
            pictureBox1 = new PictureBox();
            AvailableCameras = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(50, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 297);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AvailableCameras
            // 
            AvailableCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            AvailableCameras.FormattingEnabled = true;
            AvailableCameras.Location = new Point(50, 58);
            AvailableCameras.Name = "AvailableCameras";
            AvailableCameras.Size = new Size(121, 23);
            AvailableCameras.TabIndex = 1;
            AvailableCameras.SelectedValueChanged += AvailableCameras_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 63);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Selected video capture";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(AvailableCameras);
            Controls.Add(pictureBox1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "🍛🍛";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox AvailableCameras;
        private Button button1;
        private Button button2;
        private TextBox HeightTB;
        private TextBox WidthTB;
        private Button button3;
        private Label label1;
    }
}