using Mysqlx.Notice;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using Capture = Emgu.CV.Capture;
using System.Drawing.Imaging;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.GPU;
using Emgu.CV.ML;

namespace FacialRecognitionServer
{
    public partial class ManageFaces : Form
    {
        //Variables 
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);

        //HaarCascade Library
        HaarCascade faceDetected;

        //For Camera as WebCams 
        Capture camera;

        //Images List if Stored
        Image<Bgr, Byte> Frame;

        Image<Gray, byte> result;
        Image<Gray, byte> TrainedFace = null;
        Image<Gray, byte> grayFace = null;

        //List 
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();

        List<string> labels = new List<string>();
        List<string> users = new List<string>();

        int Count, NumLables, t;
        string name, names = null;

        public ManageFaces()
        {
            InitializeComponent();

            faceDetected = new HaarCascade("haarcascade_frontalface_alt.xml");

            try
            {
                string Labelsinf = File.ReadAllText(Application.StartupPath + "/Faces/Faces.txt");
                string[] Labels = Labelsinf.Split(',');

                NumLables = Convert.ToInt16(Labels[0]);
                Count = NumLables;

                string FacesLoad;

                for (int i = 1; i < NumLables + 1; i++)
                {
                    FacesLoad = "face" + i + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/Faces/" + FacesLoad));
                    labels.Add(Labels[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Database Folder is empty..!, please Register Face");
            }
        }

        private void btnScanFace_Click(object sender, EventArgs e)
        {
            camera = new Capture();
            camera.QueryFrame();

            Application.Idle += new EventHandler(FrameProcedure);

            btnScanFace.Enabled = false;

            btnAddDetected.Enabled = true;
            btnopen.Enabled = true;
            txtFirstName.Focus();
        }
        private void FrameProcedure(object sender, EventArgs e)
        {
            users.Add("");
            lblCountAllFaces.Text = "0";

            Frame = camera.QueryFrame().Resize(320, 240, INTER.CV_INTER_CUBIC);
            grayFace = Frame.Convert<Gray, Byte>();

            MCvAvgComp[][] faceDetectedShow = grayFace.DetectHaarCascade(faceDetected, 1.2, 10,
                HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            foreach (MCvAvgComp f in faceDetectedShow[0])
            {
                t += 1;

                result = Frame.Copy(f.rect).Convert<Gray, Byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                Frame.Draw(f.rect, new Bgr(Color.Green), 3);

                if (trainingImages.ToArray().Length != 0)
                {
                    MCvTermCriteria termCriterias = new MCvTermCriteria(Count, 0.001);
                    EigenObjectRecognizer recognizer =
                        new EigenObjectRecognizer(trainingImages.ToArray(),
                        labels.ToArray(), 3000,
                        ref termCriterias);

                    name = recognizer.Recognize(result);
                    Frame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));

                }
                users[t - 1] = name;
                users.Add("");
                //Set the number of faces detected on the scene
                lblCountAllFaces.Text = faceDetectedShow[0].Length.ToString();
                users.Add("");

            }

            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < faceDetectedShow[0].Length; nnn++)
            {
                names = names + users[nnn] + ", ";
            }

            //Show the faces procesed and recognized
            pictureBoxDetectFace.Image = Frame.ToBitmap();
            lblName.Text = names;
            names = "";
            users.Clear();
        }

        private void btnAddDetected_Click(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtFirstName.Text.Length < 2 || txtFirstName.Text == string.Empty)
            {
                MessageBox.Show("Please enter name of person");
            }
            else
            {
                Count += 1;
                grayFace = camera.QueryGrayFrame().Resize(320, 240, INTER.CV_INTER_CUBIC);
                MCvAvgComp[][] DetectedFace = grayFace.DetectHaarCascade(faceDetected, 1.2, 10,
                    HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                foreach (MCvAvgComp f in DetectedFace[0])
                {

                    TrainedFace = Frame.Copy(f.rect).Convert<Gray, Byte>();
                    break;
                }

                TrainedFace = result.Resize(100, 100, INTER.CV_INTER_CUBIC);

                trainingImages.Add(TrainedFace);
                pictureBoxDetected.Image = TrainedFace.ToBitmap();

                labels.Add(txtFirstName.Text);

                File.WriteAllText(Application.StartupPath + "/faces/Faces.txt", trainingImages.ToArray().Length.ToString() + ",");

                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/faces/Face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/faces/Faces.txt", labels.ToArray()[i - 1] + ",");
                }

                MessageBox.Show("Face Stored.");
                txtFirstName.Text = "";
                txtFirstName.Focus();

            }
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = Application.StartupPath + "/faces/",
                UseShellExecute = true,
                Verb = "open"
            });

        }
    }
}