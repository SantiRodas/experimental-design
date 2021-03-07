﻿using Experiment.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment
{
    public partial class FirstScreen : Form
    {

        // -----------------------------------------------------------------------------------------

        // Constants

        public const int SIZE1 = 10;
        public const int SIZE2 = 1000;
        public const int SIZE3 = 10000;
        public const int SIZE4 = 100000;
        public const int SIZE5 = 1000000;

        public const int DEFAULTREPETITIONS = 100;

        // -----------------------------------------------------------------------------------------

        // Relations with the Controller class of the namespace model

        private Controller controller;

        // -----------------------------------------------------------------------------------------

        // Constructor method of the first screen

        public FirstScreen()
        {
            InitializeComponent();

            numberRepetitions.Enabled = false;

            controller = new Controller();
        }

        // -----------------------------------------------------------------------------------------

        // Validation method of the number of repetitions.

        private void validationNumberRepetitions(object sender, EventArgs e)
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

        private void validationNumberRepetitions2(object sender, EventArgs e)
        {
            if (repetitionOption2.Checked == true)
            {
                numberRepetitions.Enabled = true;
                numberRepetitions.Text = null;
            }
        }

        // -----------------------------------------------------------------------------------------

        // Clean method that allow erase all the window

        private void cleanWindow(object sender, EventArgs e)
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

        private void startExperiment(object sender, EventArgs e)
        {

            // *****  Some variables of the system  *****

            int size = 0;
            int repetitions = 0;
            int order = 0;

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
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please try to write a number");
                }
            }
            else
            {
                MessageBox.Show("Please try to select the number of repetitions");
            }

            // *****  Validation of the order  *****

            if (orderOption1.Checked)
            {
                order = 1;
            } 
            else if (orderOption2.Checked)
            {
                order = 2;
            }
            else if (orderOption3.Checked)
            {
                order = 3;
            }
            else
            {
                MessageBox.Show("Please try to select the order of the array");
            }

            controller.experiment(size, repetitions, order);

        }

        // -----------------------------------------------------------------------------------------

    }
}
