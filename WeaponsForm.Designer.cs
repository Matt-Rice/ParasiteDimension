namespace Thing
{
    partial class WeaponsForm
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
            skillPanel = new Panel();
            saveButton = new Button();
            damageTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            weaponNameTextBox = new TextBox();
            addButton = new Button();
            label3 = new Label();
            weaponListBox = new ListBox();
            label2 = new Label();
            label1 = new Label();
            skillPanel.SuspendLayout();
            SuspendLayout();
            // 
            // skillPanel
            // 
            skillPanel.Controls.Add(saveButton);
            skillPanel.Controls.Add(damageTextBox);
            skillPanel.Controls.Add(label5);
            skillPanel.Controls.Add(label4);
            skillPanel.Controls.Add(weaponNameTextBox);
            skillPanel.Location = new Point(259, 99);
            skillPanel.Name = "skillPanel";
            skillPanel.Size = new Size(324, 379);
            skillPanel.TabIndex = 12;
            skillPanel.Visible = false;
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
            // damageTextBox
            // 
            damageTextBox.Location = new Point(170, 59);
            damageTextBox.Name = "damageTextBox";
            damageTextBox.PlaceholderText = "Value";
            damageTextBox.Size = new Size(128, 31);
            damageTextBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 20);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 2;
            label5.Text = "Damage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 20);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 1;
            label4.Text = "Weapon Name";
            // 
            // weaponNameTextBox
            // 
            weaponNameTextBox.Location = new Point(12, 59);
            weaponNameTextBox.Name = "weaponNameTextBox";
            weaponNameTextBox.PlaceholderText = "Weapon Name";
            weaponNameTextBox.Size = new Size(128, 31);
            weaponNameTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(127, 484);
            addButton.Name = "addButton";
            addButton.Size = new Size(79, 34);
            addButton.TabIndex = 11;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 71);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 10;
            label3.Text = "Weapons List";
            // 
            // weaponListBox
            // 
            weaponListBox.FormattingEnabled = true;
            weaponListBox.ItemHeight = 25;
            weaponListBox.Location = new Point(26, 99);
            weaponListBox.Name = "weaponListBox";
            weaponListBox.Size = new Size(180, 379);
            weaponListBox.TabIndex = 9;
            weaponListBox.SelectedIndexChanged += weaponListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 11);
            label2.Name = "label2";
            label2.Size = new Size(197, 54);
            label2.TabIndex = 8;
            label2.Text = "Weapons";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 7;
            // 
            // WeaponsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 551);
            Controls.Add(skillPanel);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(weaponListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WeaponsForm";
            Text = "WeaponsForm";
            skillPanel.ResumeLayout(false);
            skillPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel skillPanel;
        private Button saveButton;
        private TextBox damageTextBox;
        private Label label5;
        private Label label4;
        private TextBox weaponNameTextBox;
        private Button addButton;
        private Label label3;
        private ListBox weaponListBox;
        private Label label2;
        private Label label1;
    }
}