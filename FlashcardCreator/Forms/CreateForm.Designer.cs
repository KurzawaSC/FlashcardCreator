namespace FlashcardCreator
{
    partial class CreateForm
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
            wordTextBox = new TextBox();
            exampleTextBox = new TextBox();
            exampleLabel = new Label();
            descriptionLabel = new Label();
            answerLabel = new Label();
            answerTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // wordLabel
            // 
            wordLabel.AutoSize = true;
            wordLabel.Location = new Point(313, 30);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(45, 20);
            wordLabel.TabIndex = 0;
            wordLabel.Text = "Word";
            // 
            // wordTextBox
            // 
            wordTextBox.Location = new Point(313, 62);
            wordTextBox.Name = "wordTextBox";
            wordTextBox.Size = new Size(125, 27);
            wordTextBox.TabIndex = 1;
            // 
            // exampleTextBox
            // 
            exampleTextBox.Location = new Point(313, 140);
            exampleTextBox.Name = "exampleTextBox";
            exampleTextBox.Size = new Size(237, 27);
            exampleTextBox.TabIndex = 2;
            // 
            // exampleLabel
            // 
            exampleLabel.AutoSize = true;
            exampleLabel.Location = new Point(313, 102);
            exampleLabel.Name = "exampleLabel";
            exampleLabel.Size = new Size(110, 20);
            exampleLabel.TabIndex = 3;
            exampleLabel.Text = "Example of use";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(313, 179);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(85, 20);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description";
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new Point(313, 261);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(57, 20);
            answerLabel.TabIndex = 5;
            answerLabel.Text = "Answer";
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(313, 295);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(125, 27);
            answerTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(316, 214);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(234, 27);
            descriptionTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Lime;
            saveButton.Location = new Point(424, 339);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Red;
            cancelButton.Location = new Point(313, 339);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(577, 411);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(answerTextBox);
            Controls.Add(answerLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(exampleLabel);
            Controls.Add(exampleTextBox);
            Controls.Add(wordTextBox);
            Controls.Add(wordLabel);
            Name = "CreateForm";
            Text = "createForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label wordLabel;
        private TextBox wordTextBox;
        private TextBox exampleTextBox;
        private Label exampleLabel;
        private Label descriptionLabel;
        private Label answerLabel;
        private TextBox answerTextBox;
        private TextBox descriptionTextBox;
        private Button saveButton;
        private Button cancelButton;
    }
}