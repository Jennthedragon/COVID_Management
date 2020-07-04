﻿namespace COVID_Management
{
    partial class Form2
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
            this.covidManagerLabel = new System.Windows.Forms.Label();
            this.covidCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // covidManagerLabel
            // 
            this.covidManagerLabel.AutoSize = true;
            this.covidManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.covidManagerLabel.Location = new System.Drawing.Point(14, 11);
            this.covidManagerLabel.Name = "covidManagerLabel";
            this.covidManagerLabel.Size = new System.Drawing.Size(462, 46);
            this.covidManagerLabel.TabIndex = 14;
            this.covidManagerLabel.Text = "COVID-19 Questionnaire";
            // 
            // covidCheckedListBox
            // 
            this.covidCheckedListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.covidCheckedListBox.FormattingEnabled = true;
            this.covidCheckedListBox.Items.AddRange(new object[] {
            "Fever(feeling hot to the touch, a temperature of 37.8 degrees Celsius or higher)",
            "Chills",
            "Cough that\'s new or worsening(continuous, more than usual)",
            "Barking cough, making a whistling noise when breathing(croup)",
            "Shortness of breath(out of breath, unable to breathe deeply)",
            "Sore throat",
            "Difficulty swallowing",
            "Runny nose(not related to seasonal allergies or other known causes or conditions)" +
                "",
            "Stuffy or congested nose(not related to seasonal allergies or other known causes " +
                "or conditions)",
            "Lost sense of taste or smell",
            "Pink eye(conjunctivitis)",
            "Headache that’s unusual or long lasting",
            "Digestive issues like nausea/vomiting, diarrhea, stomach pain (not related to oth" +
                "er known causes or conditions)",
            "Muscle aches that are unusual or long lasting",
            "Extreme tiredness that is unusual(fatigue, lack of energy)",
            "Falling down often",
            "For young children and infants: sluggishness or lack of appetite",
            "None of the above "});
            this.covidCheckedListBox.Location = new System.Drawing.Point(14, 64);
            this.covidCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.covidCheckedListBox.Name = "covidCheckedListBox";
            this.covidCheckedListBox.Size = new System.Drawing.Size(872, 424);
            this.covidCheckedListBox.TabIndex = 15;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(802, 519);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(84, 29);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.covidCheckedListBox);
            this.Controls.Add(this.covidManagerLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label covidManagerLabel;
        private System.Windows.Forms.CheckedListBox covidCheckedListBox;
        private System.Windows.Forms.Button submitButton;
    }
}