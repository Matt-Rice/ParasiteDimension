namespace Thing.Forms
{
    partial class InitiativeForm
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
            initiativeListBox = new ListBox();
            label1 = new Label();
            turnLabel = new Label();
            nextButton = new Button();
            SuspendLayout();
            // 
            // initiativeListBox
            // 
            initiativeListBox.FormattingEnabled = true;
            initiativeListBox.ItemHeight = 25;
            initiativeListBox.Location = new Point(28, 120);
            initiativeListBox.Name = "initiativeListBox";
            initiativeListBox.Size = new Size(180, 404);
            initiativeListBox.TabIndex = 0;
            initiativeListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 81);
            label1.TabIndex = 1;
            label1.Text = "Turn Order";
            // 
            // turnLabel
            // 
            turnLabel.AutoSize = true;
            turnLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            turnLabel.Location = new Point(229, 120);
            turnLabel.Name = "turnLabel";
            turnLabel.Size = new Size(272, 54);
            turnLabel.TabIndex = 2;
            turnLabel.Text = "Current Turn:";
            // 
            // nextButton
            // 
            nextButton.Location = new Point(307, 191);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(112, 34);
            nextButton.TabIndex = 4;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // InitiativeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 537);
            Controls.Add(nextButton);
            Controls.Add(turnLabel);
            Controls.Add(label1);
            Controls.Add(initiativeListBox);
            Name = "InitiativeForm";
            Text = "InitiativeForm";
            Load += InitiativeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox initiativeListBox;
        private Label label1;
        private Label turnLabel;
        private Button nextButton;
    }
}