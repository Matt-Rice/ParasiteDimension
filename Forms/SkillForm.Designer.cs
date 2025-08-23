namespace Thing
{
    partial class SkillForm
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
            label1 = new Label();
            label2 = new Label();
            skillListBox = new ListBox();
            label3 = new Label();
            addButton = new Button();
            skillPanel = new Panel();
            saveSkillButton = new Button();
            valueTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            skillNameTextBox = new TextBox();
            deleteButton = new Button();
            closeButton = new Button();
            skillPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 29);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(272, 9);
            label2.Name = "label2";
            label2.Size = new Size(118, 54);
            label2.TabIndex = 1;
            label2.Text = "Skills";
            // 
            // skillListBox
            // 
            skillListBox.FormattingEnabled = true;
            skillListBox.ItemHeight = 25;
            skillListBox.Location = new Point(27, 97);
            skillListBox.Name = "skillListBox";
            skillListBox.Size = new Size(180, 379);
            skillListBox.TabIndex = 2;
            skillListBox.SelectedIndexChanged += SkillListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 69);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 3;
            label3.Text = "Skill List";
            // 
            // addButton
            // 
            addButton.Location = new Point(27, 482);
            addButton.Name = "addButton";
            addButton.Size = new Size(79, 34);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // skillPanel
            // 
            skillPanel.Controls.Add(saveSkillButton);
            skillPanel.Controls.Add(valueTextBox);
            skillPanel.Controls.Add(label5);
            skillPanel.Controls.Add(label4);
            skillPanel.Controls.Add(skillNameTextBox);
            skillPanel.Location = new Point(260, 97);
            skillPanel.Name = "skillPanel";
            skillPanel.Size = new Size(324, 379);
            skillPanel.TabIndex = 6;
            skillPanel.Visible = false;
            // 
            // saveSkillButton
            // 
            saveSkillButton.Location = new Point(96, 132);
            saveSkillButton.Name = "saveSkillButton";
            saveSkillButton.Size = new Size(112, 34);
            saveSkillButton.TabIndex = 4;
            saveSkillButton.Text = "Save Skill";
            saveSkillButton.UseVisualStyleBackColor = true;
            saveSkillButton.Click += saveButton_Click;
            // 
            // valueTextBox
            // 
            valueTextBox.Location = new Point(170, 59);
            valueTextBox.Name = "valueTextBox";
            valueTextBox.PlaceholderText = "Value";
            valueTextBox.Size = new Size(128, 31);
            valueTextBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 20);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 2;
            label5.Text = "Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 20);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 1;
            label4.Text = "Skill Name";
            // 
            // skillNameTextBox
            // 
            skillNameTextBox.Location = new Point(12, 59);
            skillNameTextBox.Name = "skillNameTextBox";
            skillNameTextBox.PlaceholderText = "Skill Name";
            skillNameTextBox.Size = new Size(128, 31);
            skillNameTextBox.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(130, 482);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(77, 34);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(606, 494);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(78, 34);
            closeButton.TabIndex = 8;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // SkillForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 540);
            Controls.Add(closeButton);
            Controls.Add(deleteButton);
            Controls.Add(skillPanel);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(skillListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SkillForm";
            Text = "Skill List";
            Load += SkillForm_Load;
            skillPanel.ResumeLayout(false);
            skillPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox skillListBox;
        private Label label3;
        private Button addButton;
        private Panel skillPanel;
        private TextBox valueTextBox;
        private Label label5;
        private Label label4;
        private TextBox skillNameTextBox;
        private Button saveSkillButton;
        private Button deleteButton;
        private Button closeButton;
    }
}