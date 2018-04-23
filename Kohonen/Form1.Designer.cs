namespace Kohonen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrainButton = new System.Windows.Forms.Button();
            this.ChartButton = new System.Windows.Forms.Button();
            this.LearningRateTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EwsuTB = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExtraLearingRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(50, 118);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(149, 47);
            this.TrainButton.TabIndex = 0;
            this.TrainButton.Text = "Trenuj";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(50, 183);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(149, 47);
            this.ChartButton.TabIndex = 1;
            this.ChartButton.Text = "Wykres";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // LearningRateTB
            // 
            this.LearningRateTB.Location = new System.Drawing.Point(99, 20);
            this.LearningRateTB.Name = "LearningRateTB";
            this.LearningRateTB.Size = new System.Drawing.Size(100, 22);
            this.LearningRateTB.TabIndex = 2;
            this.LearningRateTB.Text = "0,1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "wsu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "eWsuD";
            // 
            // EwsuTB
            // 
            this.EwsuTB.Location = new System.Drawing.Point(99, 76);
            this.EwsuTB.Name = "EwsuTB";
            this.EwsuTB.Size = new System.Drawing.Size(100, 22);
            this.EwsuTB.TabIndex = 4;
            this.EwsuTB.Text = "0,1";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(50, 242);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(149, 47);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Resetuj";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "eWsu";
            // 
            // ExtraLearingRate
            // 
            this.ExtraLearingRate.Location = new System.Drawing.Point(99, 48);
            this.ExtraLearingRate.Name = "ExtraLearingRate";
            this.ExtraLearingRate.Size = new System.Drawing.Size(100, 22);
            this.ExtraLearingRate.TabIndex = 7;
            this.ExtraLearingRate.Text = "0,9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExtraLearingRate);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EwsuTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LearningRateTB);
            this.Controls.Add(this.ChartButton);
            this.Controls.Add(this.TrainButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Button ChartButton;
        private System.Windows.Forms.TextBox LearningRateTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EwsuTB;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExtraLearingRate;
    }
}

