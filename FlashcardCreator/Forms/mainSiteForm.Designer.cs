namespace FlashcardCreator
{
    partial class mainSiteForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            learningButton = new Button();
            createFlashcardButton = new Button();
            browseButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 61);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Hello";
            // 
            // learningButton
            // 
            learningButton.BackColor = Color.FromArgb(128, 255, 255);
            learningButton.Location = new Point(331, 100);
            learningButton.Name = "learningButton";
            learningButton.Size = new Size(142, 29);
            learningButton.TabIndex = 1;
            learningButton.Text = "Start Learning";
            learningButton.UseVisualStyleBackColor = false;
            learningButton.Click += learningButton_Click;
            // 
            // createFlashcardButton
            // 
            createFlashcardButton.BackColor = Color.Lime;
            createFlashcardButton.Location = new Point(331, 144);
            createFlashcardButton.Name = "createFlashcardButton";
            createFlashcardButton.Size = new Size(142, 56);
            createFlashcardButton.TabIndex = 2;
            createFlashcardButton.Text = "Create new flashcard";
            createFlashcardButton.UseVisualStyleBackColor = false;
            createFlashcardButton.Click += createFlashcardButton_Click;
            // 
            // browseButton
            // 
            browseButton.BackColor = Color.FromArgb(255, 128, 255);
            browseButton.Location = new Point(331, 219);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(142, 61);
            browseButton.TabIndex = 3;
            browseButton.Text = "Browse flashcards";
            browseButton.UseVisualStyleBackColor = false;
            browseButton.Click += browseButton_Click;
            // 
            // mainSiteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(579, 404);
            Controls.Add(browseButton);
            Controls.Add(createFlashcardButton);
            Controls.Add(learningButton);
            Controls.Add(label1);
            Name = "mainSiteForm";
            Text = "Flashcard Creator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button learningButton;
        private Button createFlashcardButton;
        private Button browseButton;
    }
}
