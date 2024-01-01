using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Diagnostics;
using System.Text;

namespace CameraDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine($"{CurrentImagesTaken.Count}");

        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        List<Image> CurrentImagesTaken = new List<Image>();

        int ImagePageNumber = 0;

        // 
        string DinoNoConnetion = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "resources\\NoConnectionDino.jpg");

        private void SettingsInitialise()
        {
            // picture box settings 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
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
            Console.WriteLine($"IMAGE TAKEN : {DateTime.Now}");
        }

        Boolean PressedViewGallery = false;
        private void viewGalleryBTN_Click(object sender, EventArgs e)
        {
            if (!PressedViewGallery)
            {
                GalleryPanel.Visible = true;
                PressedViewGallery = true;
                try
                {
                    pictureBox3.Image = CurrentImagesTaken[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR : {ex.Message}");
                }
            }
            else if (PressedViewGallery == true)
            {
                GalleryPanel.Visible = false;
                PressedViewGallery = false;
            }
        }

        private void NextImgBTN_Click(object sender, EventArgs e)
        {
            byte[] ImageData;
            if (ImagePageNumber != CurrentImagesTaken.Count)
            {
                Console.WriteLine($"Current Page on {ImagePageNumber} out of {CurrentImagesTaken.Count}");
                pictureBox3.Image = CurrentImagesTaken[ImagePageNumber];
                ImagePageNumber += 1;


                // creating the image into a byte
                using (MemoryStream ms = new MemoryStream())
                {
                    CurrentImagesTaken[ImagePageNumber].Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    ImageData = ms.ToArray();
                    Console.WriteLine(ImageData);
                }

                // Creating the byte into an image
                using (MemoryStream ms = new MemoryStream(ImageData))
                {
                    Image TempImage = Image.FromStream(ms);

                    pictureBox2.Image = TempImage;

                }
            }
        }

        private void BackImg_Click(object sender, EventArgs e)
        {
            if (ImagePageNumber != 0)
            {
                Console.WriteLine($"Current Page on {ImagePageNumber} out of {CurrentImagesTaken.Count}");
                ImagePageNumber -= 1;
                pictureBox3.Image = CurrentImagesTaken[ImagePageNumber];

            }
        }
    }
}