namespace FlashcardCreator
{
    partial class LearningForm
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
            wordLabel = new Label();
            exampleLabel = new Label();
            answerButton = new Button();
            nextButton = new Button();
            descriptionLabel = new Label();
            answerLabel = new Label();
            SuspendLayout();
            // 
            // wordLabel
            // 
            wordLabel.AutoSize = true;
            wordLabel.Location = new Point(409, 55);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(50, 20);
            wordLabel.TabIndex = 0;
            wordLabel.Text = "label1";
            // 
            // exampleLabel
            // 
            exampleLabel.AutoSize = true;
            exampleLabel.Location = new Point(409, 110);
            exampleLabel.Name = "exampleLabel";
            exampleLabel.Size = new Size(50, 20);
            exampleLabel.TabIndex = 1;
            exampleLabel.Text = "label2";
            // 
            // answerButton
            // 
            answerButton.BackColor = Color.Cyan;
            answerButton.Location = new Point(337, 153);
            answerButton.Name = "answerButton";
            answerButton.Size = new Size(94, 61);
            answerButton.TabIndex = 2;
            answerButton.Text = "Show Answer";
            answerButton.UseVisualStyleBackColor = false;
            answerButton.Click += answerButton_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Lime;
            nextButton.Location = new Point(450, 153);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 61);
            nextButton.TabIndex = 3;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(409, 249);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(50, 20);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "label3";
            descriptionLabel.Visible = false;
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new Point(409, 296);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(50, 20);
            answerLabel.TabIndex = 5;
            answerLabel.Text = "label4";
            answerLabel.Visible = false;
            // 
            // LearningForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(578, 408);
            Controls.Add(answerLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(nextButton);
            Controls.Add(answerButton);
            Controls.Add(exampleLabel);
            Controls.Add(wordLabel);
            Name = "LearningForm";
            Text = "LearningForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label wordLabel;
        private Label exampleLabel;
        private Button answerButton;
        private Button nextButton;
        private Label descriptionLabel;
        private Label answerLabel;
    }
}