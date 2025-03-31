namespace GradeCalculatorApplication
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
            this.label1 = new Label();
            this.inputScore = new TextBox();
            this.calculateButton = new Button();
            this.clearButton = new Button();
            this.resultLabel = new Label();

            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your score (0-100):";

            // 
            // inputScore
            // 
            this.inputScore.Location = new Point(200, 37);
            this.inputScore.Name = "inputScore";
            this.inputScore.Size = new Size(150, 23);
            this.inputScore.TabIndex = 1;

            // 
            // calculateButton
            // 
            this.calculateButton.Location = new Point(44, 80);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new Size(135, 30);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Grade";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new EventHandler(this.CalculateButton_Click);

            // 
            // clearButton
            // 
            this.clearButton.Location = new Point(215, 80);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new Size(135, 30);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new EventHandler(this.ClearButton_Click);

            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new Point(44, 140);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new Size(0, 15);
            this.resultLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            this.resultLabel.ForeColor = Color.Black;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 250);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inputScore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputScore;
        private Button calculateButton;
        private Button clearButton;
        private Label resultLabel;
    }
}
