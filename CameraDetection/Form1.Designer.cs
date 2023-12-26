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
            button4 = new Button();
            viewGalleryBTN = new Button();
            GalleryPanel = new Panel();
            BackImg = new Button();
            pictureBox3 = new PictureBox();
            NextImgBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            GalleryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            AvailableCameras.Cursor = Cursors.Hand;
            AvailableCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            AvailableCameras.FormattingEnabled = true;
            AvailableCameras.Location = new Point(50, 58);
            AvailableCameras.Name = "AvailableCameras";
            AvailableCameras.Size = new Size(121, 28);
            AvailableCameras.TabIndex = 1;
            AvailableCameras.SelectedValueChanged += AvailableCameras_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 63);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 2;
            label1.Text = "Selected video capture";
            // 
            // button4
            // 
            button4.Location = new Point(50, 385);
            button4.Name = "button4";
            button4.Size = new Size(105, 38);
            button4.TabIndex = 4;
            button4.Text = "Take Image";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // viewGalleryBTN
            // 
            viewGalleryBTN.Location = new Point(161, 385);
            viewGalleryBTN.Name = "viewGalleryBTN";
            viewGalleryBTN.Size = new Size(121, 38);
            viewGalleryBTN.TabIndex = 5;
            viewGalleryBTN.Text = "View images";
            viewGalleryBTN.UseVisualStyleBackColor = true;
            viewGalleryBTN.Click += viewGalleryBTN_Click;
            // 
            // GalleryPanel
            // 
            GalleryPanel.Controls.Add(BackImg);
            GalleryPanel.Controls.Add(pictureBox3);
            GalleryPanel.Controls.Add(NextImgBTN);
            GalleryPanel.Location = new Point(493, 223);
            GalleryPanel.Name = "GalleryPanel";
            GalleryPanel.Size = new Size(278, 210);
            GalleryPanel.TabIndex = 6;
            GalleryPanel.Visible = false;
            // 
            // BackImg
            // 
            BackImg.Location = new Point(41, 170);
            BackImg.Name = "BackImg";
            BackImg.Size = new Size(75, 23);
            BackImg.TabIndex = 2;
            BackImg.Text = "<-";
            BackImg.UseVisualStyleBackColor = true;
            BackImg.Click += BackImg_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(41, 33);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(194, 111);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // NextImgBTN
            // 
            NextImgBTN.Location = new Point(160, 170);
            NextImgBTN.Name = "NextImgBTN";
            NextImgBTN.Size = new Size(75, 23);
            NextImgBTN.TabIndex = 0;
            NextImgBTN.Text = "->";
            NextImgBTN.UseVisualStyleBackColor = true;
            NextImgBTN.Click += NextImgBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GalleryPanel);
            Controls.Add(viewGalleryBTN);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(AvailableCameras);
            Controls.Add(pictureBox1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "🍛🍛";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            GalleryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox AvailableCameras;
        private Button NextImgBTN;
        private Button button2;
        private TextBox HeightTB;
        private TextBox WidthTB;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button viewGalleryBTN;
        private Panel GalleryPanel;
        private PictureBox pictureBox3;
        private Button BackImg;
    }
}