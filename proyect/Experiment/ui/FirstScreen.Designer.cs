
namespace Experiment
{
    partial class screen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(screen));
            this.label1 = new System.Windows.Forms.Label();
            this.sizeOption1 = new System.Windows.Forms.RadioButton();
            this.sizeOption2 = new System.Windows.Forms.RadioButton();
            this.sizeOption3 = new System.Windows.Forms.RadioButton();
            this.sizeOption4 = new System.Windows.Forms.RadioButton();
            this.sizeOption5 = new System.Windows.Forms.RadioButton();
            this.container1 = new System.Windows.Forms.GroupBox();
            this.container2 = new System.Windows.Forms.GroupBox();
            this.numberRepetitions = new System.Windows.Forms.TextBox();
            this.repetitionOption2 = new System.Windows.Forms.RadioButton();
            this.repetitionOption1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.container3 = new System.Windows.Forms.GroupBox();
            this.orderOption3 = new System.Windows.Forms.RadioButton();
            this.orderOption2 = new System.Windows.Forms.RadioButton();
            this.orderOption1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.container1.SuspendLayout();
            this.container2.SuspendLayout();
            this.container3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the size of the array";
            // 
            // sizeOption1
            // 
            this.sizeOption1.AutoSize = true;
            this.sizeOption1.Location = new System.Drawing.Point(9, 38);
            this.sizeOption1.Name = "sizeOption1";
            this.sizeOption1.Size = new System.Drawing.Size(37, 17);
            this.sizeOption1.TabIndex = 1;
            this.sizeOption1.TabStop = true;
            this.sizeOption1.Text = "10";
            this.sizeOption1.UseVisualStyleBackColor = true;
            // 
            // sizeOption2
            // 
            this.sizeOption2.AutoSize = true;
            this.sizeOption2.Location = new System.Drawing.Point(9, 61);
            this.sizeOption2.Name = "sizeOption2";
            this.sizeOption2.Size = new System.Drawing.Size(52, 17);
            this.sizeOption2.TabIndex = 2;
            this.sizeOption2.TabStop = true;
            this.sizeOption2.Text = "1.000";
            this.sizeOption2.UseVisualStyleBackColor = true;
            // 
            // sizeOption3
            // 
            this.sizeOption3.AutoSize = true;
            this.sizeOption3.Location = new System.Drawing.Point(9, 84);
            this.sizeOption3.Name = "sizeOption3";
            this.sizeOption3.Size = new System.Drawing.Size(58, 17);
            this.sizeOption3.TabIndex = 3;
            this.sizeOption3.TabStop = true;
            this.sizeOption3.Text = "10.000";
            this.sizeOption3.UseVisualStyleBackColor = true;
            // 
            // sizeOption4
            // 
            this.sizeOption4.AutoSize = true;
            this.sizeOption4.Location = new System.Drawing.Point(9, 107);
            this.sizeOption4.Name = "sizeOption4";
            this.sizeOption4.Size = new System.Drawing.Size(64, 17);
            this.sizeOption4.TabIndex = 4;
            this.sizeOption4.TabStop = true;
            this.sizeOption4.Text = "100.000";
            this.sizeOption4.UseVisualStyleBackColor = true;
            // 
            // sizeOption5
            // 
            this.sizeOption5.AutoSize = true;
            this.sizeOption5.Location = new System.Drawing.Point(9, 130);
            this.sizeOption5.Name = "sizeOption5";
            this.sizeOption5.Size = new System.Drawing.Size(73, 17);
            this.sizeOption5.TabIndex = 5;
            this.sizeOption5.TabStop = true;
            this.sizeOption5.Text = "1.000.000";
            this.sizeOption5.UseVisualStyleBackColor = true;
            // 
            // container1
            // 
            this.container1.Controls.Add(this.sizeOption2);
            this.container1.Controls.Add(this.sizeOption5);
            this.container1.Controls.Add(this.label1);
            this.container1.Controls.Add(this.sizeOption4);
            this.container1.Controls.Add(this.sizeOption1);
            this.container1.Controls.Add(this.sizeOption3);
            this.container1.Location = new System.Drawing.Point(12, 1);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(175, 163);
            this.container1.TabIndex = 6;
            this.container1.TabStop = false;
            this.container1.Text = ".";
            // 
            // container2
            // 
            this.container2.Controls.Add(this.numberRepetitions);
            this.container2.Controls.Add(this.repetitionOption2);
            this.container2.Controls.Add(this.repetitionOption1);
            this.container2.Controls.Add(this.label2);
            this.container2.Location = new System.Drawing.Point(193, 30);
            this.container2.Name = "container2";
            this.container2.Size = new System.Drawing.Size(203, 85);
            this.container2.TabIndex = 7;
            this.container2.TabStop = false;
            this.container2.Text = ".";
            // 
            // numberRepetitions
            // 
            this.numberRepetitions.Location = new System.Drawing.Point(108, 57);
            this.numberRepetitions.Name = "numberRepetitions";
            this.numberRepetitions.Size = new System.Drawing.Size(89, 20);
            this.numberRepetitions.TabIndex = 3;
            // 
            // repetitionOption2
            // 
            this.repetitionOption2.AutoSize = true;
            this.repetitionOption2.Location = new System.Drawing.Point(9, 58);
            this.repetitionOption2.Name = "repetitionOption2";
            this.repetitionOption2.Size = new System.Drawing.Size(100, 17);
            this.repetitionOption2.TabIndex = 2;
            this.repetitionOption2.TabStop = true;
            this.repetitionOption2.Text = "More than 100: ";
            this.repetitionOption2.UseVisualStyleBackColor = true;
            this.repetitionOption2.CheckedChanged += new System.EventHandler(this.validationNumberRepetitions2);
            // 
            // repetitionOption1
            // 
            this.repetitionOption1.AutoSize = true;
            this.repetitionOption1.Location = new System.Drawing.Point(9, 35);
            this.repetitionOption1.Name = "repetitionOption1";
            this.repetitionOption1.Size = new System.Drawing.Size(86, 17);
            this.repetitionOption1.TabIndex = 1;
            this.repetitionOption1.TabStop = true;
            this.repetitionOption1.Text = "Default (100)";
            this.repetitionOption1.UseVisualStyleBackColor = true;
            this.repetitionOption1.CheckedChanged += new System.EventHandler(this.validationNumberRepetitions);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select the number of repetitions";
            // 
            // container3
            // 
            this.container3.Controls.Add(this.orderOption3);
            this.container3.Controls.Add(this.orderOption2);
            this.container3.Controls.Add(this.orderOption1);
            this.container3.Controls.Add(this.label3);
            this.container3.Location = new System.Drawing.Point(402, 1);
            this.container3.Name = "container3";
            this.container3.Size = new System.Drawing.Size(149, 115);
            this.container3.TabIndex = 8;
            this.container3.TabStop = false;
            this.container3.Text = ".";
            // 
            // orderOption3
            // 
            this.orderOption3.AutoSize = true;
            this.orderOption3.Location = new System.Drawing.Point(9, 88);
            this.orderOption3.Name = "orderOption3";
            this.orderOption3.Size = new System.Drawing.Size(65, 17);
            this.orderOption3.TabIndex = 7;
            this.orderOption3.TabStop = true;
            this.orderOption3.Text = "Random";
            this.orderOption3.UseVisualStyleBackColor = true;
            // 
            // orderOption2
            // 
            this.orderOption2.AutoSize = true;
            this.orderOption2.Location = new System.Drawing.Point(9, 65);
            this.orderOption2.Name = "orderOption2";
            this.orderOption2.Size = new System.Drawing.Size(112, 17);
            this.orderOption2.TabIndex = 6;
            this.orderOption2.TabStop = true;
            this.orderOption2.Text = "Largest to smallest";
            this.orderOption2.UseVisualStyleBackColor = true;
            // 
            // orderOption1
            // 
            this.orderOption1.AutoSize = true;
            this.orderOption1.Location = new System.Drawing.Point(9, 42);
            this.orderOption1.Name = "orderOption1";
            this.orderOption1.Size = new System.Drawing.Size(110, 17);
            this.orderOption1.TabIndex = 5;
            this.orderOption1.TabStop = true;
            this.orderOption1.Text = "Smallest to largest";
            this.orderOption1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select the initial order";
            // 
            // image1
            // 
            this.image1.Image = ((System.Drawing.Image)(resources.GetObject("image1.Image")));
            this.image1.Location = new System.Drawing.Point(-6, 123);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(646, 258);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image1.TabIndex = 9;
            this.image1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(557, 30);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startExperiment);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(557, 59);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 11;
            this.cleanButton.Text = "Clean";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanWindow);
            // 
            // screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 381);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.container3);
            this.Controls.Add(this.container2);
            this.Controls.Add(this.container1);
            this.Controls.Add(this.image1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Experiment";
            this.container1.ResumeLayout(false);
            this.container1.PerformLayout();
            this.container2.ResumeLayout(false);
            this.container2.PerformLayout();
            this.container3.ResumeLayout(false);
            this.container3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sizeOption1;
        private System.Windows.Forms.RadioButton sizeOption2;
        private System.Windows.Forms.RadioButton sizeOption3;
        private System.Windows.Forms.RadioButton sizeOption4;
        private System.Windows.Forms.RadioButton sizeOption5;
        private System.Windows.Forms.GroupBox container1;
        private System.Windows.Forms.GroupBox container2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton repetitionOption1;
        private System.Windows.Forms.RadioButton repetitionOption2;
        private System.Windows.Forms.TextBox numberRepetitions;
        private System.Windows.Forms.GroupBox container3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton orderOption3;
        private System.Windows.Forms.RadioButton orderOption2;
        private System.Windows.Forms.RadioButton orderOption1;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cleanButton;
    }
}

