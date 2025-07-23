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
            SkillListBox = new ListBox();
            label3 = new Label();
            addButton = new Button();
            skillPanel = new Panel();
            skillNameTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            valueTextBox = new TextBox();
            saveButton = new Button();
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
            // SkillListBox
            // 
            SkillListBox.FormattingEnabled = true;
            SkillListBox.ItemHeight = 25;
            SkillListBox.Location = new Point(27, 97);
            SkillListBox.Name = "SkillListBox";
            SkillListBox.Size = new Size(180, 379);
            SkillListBox.TabIndex = 2;
            SkillListBox.SelectedIndexChanged += SkillListBox_SelectedIndexChanged;
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
            addButton.Location = new Point(128, 482);
            addButton.Name = "addButton";
            addButton.Size = new Size(79, 34);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // skillPanel
            // 
            skillPanel.Controls.Add(saveButton);
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
            // skillNameTextBox
            // 
            skillNameTextBox.Location = new Point(12, 59);
            skillNameTextBox.Name = "skillNameTextBox";
            skillNameTextBox.PlaceholderText = "Skill Name";
            skillNameTextBox.Size = new Size(128, 31);
            skillNameTextBox.TabIndex = 0;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 20);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 2;
            label5.Text = "Value";
            // 
            // valueTextBox
            // 
            valueTextBox.Location = new Point(170, 59);
            valueTextBox.Name = "valueTextBox";
            valueTextBox.PlaceholderText = "Value";
            valueTextBox.Size = new Size(128, 31);
            valueTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(96, 132);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // SkillForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 540);
            Controls.Add(skillPanel);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(SkillListBox);
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
        private ListBox SkillListBox;
        private Label label3;
        private Button addButton;
        private Panel skillPanel;
        private TextBox valueTextBox;
        private Label label5;
        private Label label4;
        private TextBox skillNameTextBox;
        private Button saveButton;
    }
}