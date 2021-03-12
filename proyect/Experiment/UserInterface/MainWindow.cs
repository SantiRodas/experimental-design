using Experiment.Model;
using System;
using System.Collections;
using System.Threading;
using System.Windows.Forms;

namespace Experiment.UserInterface
{
    public partial class MainWindow : Form
    {

        // -----------------------------------------------------------------------------------------

        // Constants

        public const int SIZE1 = 10;
        public const int SIZE2 = 100;
        public const int SIZE3 = 1000;
        public const int SIZE4 = 10000;
        public const int SIZE5 = 100000;

        public const int DEFAULTREPETITIONS = 100;

        // -----------------------------------------------------------------------------------------

        // Relations with the Controller class of the namespace model

        private ExperimentManager expManager;

        // -----------------------------------------------------------------------------------------

        // Constructor method of the first screen

        public MainWindow()
        {
            InitializeComponent();

            numberRepetitions.Enabled = false;

            expManager = new ExperimentManager();
        }

        // -----------------------------------------------------------------------------------------

        // Validation method of the number of repetitions.

        private void ValidationNumberRepetitions(object sender, EventArgs e)
        {
            if (repetitionOption1.Checked == true)
            {
                numberRepetitions.Enabled = false;
                numberRepetitions.Text = null;
            }
            else
            {
                numberRepetitions.Enabled = true;
            }
        }

        // -----------------------------------------------------------------------------------------

        // Validation method of the number of repetitions 2.

        private void ValidationNumberRepetitions2(object sender, EventArgs e)
        {
            if (repetitionOption2.Checked == true)
            {
                numberRepetitions.Enabled = true;
                numberRepetitions.Text = null;
            }
        }

        // -----------------------------------------------------------------------------------------

        // Clean method that allow erase all the window

        private void CleanWindow(object sender, EventArgs e)
        {
            sizeOption1.Checked = false;
            sizeOption2.Checked = false;
            sizeOption3.Checked = false;
            sizeOption4.Checked = false;
            sizeOption5.Checked = false;

            repetitionOption1.Checked = false;
            repetitionOption2.Checked = false;
            numberRepetitions.Text = null;
            numberRepetitions.Enabled = false;

            orderOption1.Checked = false;
            orderOption2.Checked = false;
            orderOption3.Checked = false;
        }

        // -----------------------------------------------------------------------------------------

        // Start method

        private void StartExperiment(object sender, EventArgs e)
        {

            // *****  Some variables of the system  *****

            int size = 0;
            int repetitions = 0;
            Order order;

            // *****  Validation of the size  *****

            if (sizeOption1.Checked)
            {
                size = SIZE1;
            }
            else if (sizeOption2.Checked)
            {
                size = SIZE2;
            }
            else if (sizeOption3.Checked)
            {
                size = SIZE3;
            }
            else if (sizeOption4.Checked)
            {
                size = SIZE4;
            }
            else if (sizeOption5.Checked)
            {
                size = SIZE5;
            }
            else
            {
                MessageBox.Show("Please try to select a size");
                return;
            }

            // *****  Validation of the repetitions  *****

            if (repetitionOption1.Checked)
            {
                repetitions = DEFAULTREPETITIONS;
            }
            else if (repetitionOption2.Checked)
            {
                try
                {
                    repetitions = Int32.Parse(numberRepetitions.Text);

                    if (repetitions <= 100)
                    {
                        MessageBox.Show("Please try to write a number over 100");
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please try to write a number");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please try to select the number of repetitions");
                return;
            }

            // *****  Validation of the order  *****

            if (orderOption1.Checked)
            {
                order = Order.Increasing;
            } 
            else if (orderOption2.Checked)
            {
                order = Order.Decreasing;
            }
            else if (orderOption3.Checked)
            {
                order = Order.Random;
            }
            else
            {
                MessageBox.Show("Please try to select the order of the array");
                return;
            }

            Object[] expInfo = new object[3];

            expInfo[0] = size;
            expInfo[1] = repetitions;
            expInfo[2] = order;

            Thread experimentThread = new Thread(new ParameterizedThreadStart(RunExperiment));
            expManager.CurrentRepetitionsCount = 0;
            experimentThread.Priority = ThreadPriority.Highest;
            experimentThread.Start(expInfo);

            repProgressBar.Value = 0;
            repProgressBar.Maximum = repetitions;
            totalRepLabel.Text = "" + repetitions;
            currentRepLabel.Text = "990";

            while (expManager.CurrentRepetitionsCount < repetitions)
            {
                int currentReps = expManager.CurrentRepetitionsCount;
                currentRepLabel.Text = "" + currentReps;
                repProgressBar.Value = currentReps;
                Application.DoEvents();//Can be improve by the use of threads
            }

            repProgressBar.Value = repetitions;
            currentRepLabel.Text = "" + repetitions;

        }

        public void RunExperiment(Object expInfo)
        {
            Object[] expInfoReal = (Object[])expInfo;

            expManager.StartExperiment((int)expInfoReal[0],(int)expInfoReal[1],(Order)expInfoReal[2]);
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.AddExtension = false;
            sfd.Filter = "Text File (*.txt) |*.txt |Comma Separated Value File (*.csv) |*.csv";
            sfd.FilterIndex = 2;

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string PathAndFileName = sfd.FileName;

                expManager.SaveDataToFile(PathAndFileName);

            }

        }

        // -----------------------------------------------------------------------------------------

    }
}
