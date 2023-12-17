using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Diagnostics;

namespace CameraDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        List<Image> CurrentImagesTaken = new List<Image>();

        // 
        string DinoNoConnetion = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "resources\\NoConnectionDino.jpg");

        private void SettingsInitialise()
        {
            // picture box settings 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void PopulatingComboBox()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                AvailableCameras.Items.Add(filterInfo.Name);
            }
            AvailableCameras.SelectedIndex = 0;
        }

        private void InitialiseWebCam()
        {
            if (filterInfoCollection.Count > 0)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[AvailableCameras.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
            }
            else
            {
                MessageBox.Show("Can't connect to video device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populating the Available for ComboBox
            PopulatingComboBox();
            SettingsInitialise();
            // Setting up the Web Camera when page loads
            InitialiseWebCam();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Updating the picutrebox with a new frame.
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void AvailableCameras_SelectedValueChanged(object sender, EventArgs e)
        {
            // Checks if the videoCaptureObject isn't empty and that its running in order to change
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.SignalToStop();
                pictureBox1.Image = Image.FromFile(DinoNoConnetion);
                InitialiseWebCam();
            }
            else if (videoCaptureDevice == null)
            {
                pictureBox1.Image = Image.FromFile(DinoNoConnetion);
            }
            else { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(DinoNoConnetion);
            videoCaptureDevice.SignalToStop();
            Thread.Sleep(250);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var TakenImage = pictureBox1.Image;
            CurrentImagesTaken.Add(TakenImage);
            pictureBox2.Image = TakenImage;

        }

        private void viewGalleryBTN_Click(object sender, EventArgs e)
        {

        }


        int ImagePageNumber = 0;
        private void NextImgBTN_Click(object sender, EventArgs e)
        {
            if (ImagePageNumber != CurrentImagesTaken.Count)
            {
                pictureBox3.Image = CurrentImagesTaken[ImagePageNumber];
                ImagePageNumber += 1;
            }
        }
    }
}