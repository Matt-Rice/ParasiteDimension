namespace Thing
{
    partial class addForm
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
            saveButton = new Button();
            descriptionBox = new TextBox();
            nameBox = new TextBox();
            descriptionLabel = new Label();
            nameLabel = new Label();
            cancelButton = new Button();
            enemyLabel = new Label();
            enemyListBox = new ListBox();
            titleLabel = new Label();
            addEnemyButton = new Button();
            deleteEnemyButton = new Button();
            enemyPanel = new Panel();
            saveEnemyButton = new Button();
            enduranceTextBox = new TextBox();
            enduranceLabel = new Label();
            weaponsButton = new Button();
            skillsButton = new Button();
            intelligenceTextBox = new TextBox();
            label7 = new Label();
            knowledgeTextBox = new TextBox();
            label8 = new Label();
            charismaTextBox = new TextBox();
            label9 = new Label();
            agilityTextBox = new TextBox();
            label6 = new Label();
            willpowerTextBox = new TextBox();
            label4 = new Label();
            strengthTextBox = new TextBox();
            label5 = new Label();
            movementTextBox = new TextBox();
            label2 = new Label();
            armorTextBox = new TextBox();
            label3 = new Label();
            minusWoundButton = new Button();
            plusWoundButton = new Button();
            currentWoundsTextBox = new TextBox();
            currentWoundsLabel = new Label();
            maxWoundsTextBox = new TextBox();
            maxWoundsLabel = new Label();
            minusHpButton = new Button();
            plusHpButton = new Button();
            currentHpTextBox = new TextBox();
            currentHpLabel = new Label();
            maxHpBox = new TextBox();
            label1 = new Label();
            enemyNameTextBox = new TextBox();
            enemyNameLabel = new Label();
            enemyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(720, 407);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(68, 31);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += Save_Click;
            // 
            // descriptionBox
            // 
            descriptionBox.Location = new Point(21, 167);
            descriptionBox.Multiline = true;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.PlaceholderText = "Description";
            descriptionBox.Size = new Size(185, 248);
            descriptionBox.TabIndex = 11;
            descriptionBox.TextChanged += descriptionBox_TextChanged;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(21, 109);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.Size = new Size(185, 23);
            nameBox.TabIndex = 10;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(70, 149);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(67, 15);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "Description";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(84, 91);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(632, 407);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(68, 31);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // enemyLabel
            // 
            enemyLabel.AutoSize = true;
            enemyLabel.Location = new Point(318, 92);
            enemyLabel.Name = "enemyLabel";
            enemyLabel.Size = new Size(51, 15);
            enemyLabel.TabIndex = 13;
            enemyLabel.Text = "Enemies";
            enemyLabel.Click += enemyLabel_Click;
            // 
            // enemyListBox
            // 
            enemyListBox.FormattingEnabled = true;
            enemyListBox.ItemHeight = 15;
            enemyListBox.Location = new Point(253, 109);
            enemyListBox.Margin = new Padding(2);
            enemyListBox.Name = "enemyListBox";
            enemyListBox.Size = new Size(193, 244);
            enemyListBox.TabIndex = 14;
            enemyListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            titleLabel.Location = new Point(198, 5);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(404, 72);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "Battle Creator";
            // 
            // addEnemyButton
            // 
            addEnemyButton.Location = new Point(366, 368);
            addEnemyButton.Margin = new Padding(2);
            addEnemyButton.Name = "addEnemyButton";
            addEnemyButton.Size = new Size(78, 35);
            addEnemyButton.TabIndex = 16;
            addEnemyButton.Text = "Add Enemy";
            addEnemyButton.UseVisualStyleBackColor = true;
            addEnemyButton.Click += addEnemyButton_Click;
            // 
            // deleteEnemyButton
            // 
            deleteEnemyButton.Location = new Point(253, 370);
            deleteEnemyButton.Margin = new Padding(2);
            deleteEnemyButton.Name = "deleteEnemyButton";
            deleteEnemyButton.Size = new Size(92, 31);
            deleteEnemyButton.TabIndex = 18;
            deleteEnemyButton.Text = "Delete Enemy";
            deleteEnemyButton.UseVisualStyleBackColor = true;
            deleteEnemyButton.Click += deleteEnemyButton_Click;
            // 
            // enemyPanel
            // 
            enemyPanel.Controls.Add(saveEnemyButton);
            enemyPanel.Controls.Add(enduranceTextBox);
            enemyPanel.Controls.Add(enduranceLabel);
            enemyPanel.Controls.Add(weaponsButton);
            enemyPanel.Controls.Add(skillsButton);
            enemyPanel.Controls.Add(intelligenceTextBox);
            enemyPanel.Controls.Add(label7);
            enemyPanel.Controls.Add(knowledgeTextBox);
            enemyPanel.Controls.Add(label8);
            enemyPanel.Controls.Add(charismaTextBox);
            enemyPanel.Controls.Add(label9);
            enemyPanel.Controls.Add(agilityTextBox);
            enemyPanel.Controls.Add(label6);
            enemyPanel.Controls.Add(willpowerTextBox);
            enemyPanel.Controls.Add(label4);
            enemyPanel.Controls.Add(strengthTextBox);
            enemyPanel.Controls.Add(label5);
            enemyPanel.Controls.Add(movementTextBox);
            enemyPanel.Controls.Add(label2);
            enemyPanel.Controls.Add(armorTextBox);
            enemyPanel.Controls.Add(label3);
            enemyPanel.Controls.Add(minusWoundButton);
            enemyPanel.Controls.Add(plusWoundButton);
            enemyPanel.Controls.Add(currentWoundsTextBox);
            enemyPanel.Controls.Add(currentWoundsLabel);
            enemyPanel.Controls.Add(maxWoundsTextBox);
            enemyPanel.Controls.Add(maxWoundsLabel);
            enemyPanel.Controls.Add(minusHpButton);
            enemyPanel.Controls.Add(plusHpButton);
            enemyPanel.Controls.Add(currentHpTextBox);
            enemyPanel.Controls.Add(currentHpLabel);
            enemyPanel.Controls.Add(maxHpBox);
            enemyPanel.Controls.Add(label1);
            enemyPanel.Controls.Add(enemyNameTextBox);
            enemyPanel.Controls.Add(enemyNameLabel);
            enemyPanel.Location = new Point(476, 109);
            enemyPanel.Name = "enemyPanel";
            enemyPanel.Size = new Size(294, 294);
            enemyPanel.TabIndex = 51;
            enemyPanel.Visible = false;
            enemyPanel.Paint += enemyPanel_Paint;
            // 
            // saveEnemyButton
            // 
            saveEnemyButton.Location = new Point(202, 259);
            saveEnemyButton.Name = "saveEnemyButton";
            saveEnemyButton.Size = new Size(81, 23);
            saveEnemyButton.TabIndex = 85;
            saveEnemyButton.Text = "Save Enemy";
            saveEnemyButton.UseVisualStyleBackColor = true;
            saveEnemyButton.Click += saveEnemyButton_Click;
            // 
            // enduranceTextBox
            // 
            enduranceTextBox.Location = new Point(134, 241);
            enduranceTextBox.Margin = new Padding(2);
            enduranceTextBox.Name = "enduranceTextBox";
            enduranceTextBox.Size = new Size(28, 23);
            enduranceTextBox.TabIndex = 84;
            // 
            // enduranceLabel
            // 
            enduranceLabel.AutoSize = true;
            enduranceLabel.Location = new Point(109, 221);
            enduranceLabel.Margin = new Padding(2, 0, 2, 0);
            enduranceLabel.Name = "enduranceLabel";
            enduranceLabel.Size = new Size(63, 15);
            enduranceLabel.TabIndex = 83;
            enduranceLabel.Text = "Endurance";
            // 
            // weaponsButton
            // 
            weaponsButton.Location = new Point(109, 265);
            weaponsButton.Name = "weaponsButton";
            weaponsButton.Size = new Size(70, 23);
            weaponsButton.TabIndex = 82;
            weaponsButton.Text = "Weapons";
            weaponsButton.UseVisualStyleBackColor = true;
            weaponsButton.Click += weaponsButton_Click_1;
            // 
            // skillsButton
            // 
            skillsButton.Location = new Point(30, 259);
            skillsButton.Name = "skillsButton";
            skillsButton.Size = new Size(52, 23);
            skillsButton.TabIndex = 81;
            skillsButton.Text = "Skills";
            skillsButton.UseVisualStyleBackColor = true;
            skillsButton.Click += skillsButton_Click_1;
            // 
            // intelligenceTextBox
            // 
            intelligenceTextBox.Location = new Point(202, 196);
            intelligenceTextBox.Margin = new Padding(2);
            intelligenceTextBox.Name = "intelligenceTextBox";
            intelligenceTextBox.Size = new Size(28, 23);
            intelligenceTextBox.TabIndex = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(179, 176);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 79;
            label7.Text = "Intelligence";
            // 
            // knowledgeTextBox
            // 
            knowledgeTextBox.Location = new Point(134, 196);
            knowledgeTextBox.Margin = new Padding(2);
            knowledgeTextBox.Name = "knowledgeTextBox";
            knowledgeTextBox.Size = new Size(28, 23);
            knowledgeTextBox.TabIndex = 78;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(109, 176);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 77;
            label8.Text = "Knowledge";
            // 
            // charismaTextBox
            // 
            charismaTextBox.Location = new Point(62, 196);
            charismaTextBox.Margin = new Padding(2);
            charismaTextBox.Name = "charismaTextBox";
            charismaTextBox.Size = new Size(28, 23);
            charismaTextBox.TabIndex = 76;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 176);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 75;
            label9.Text = "Charisma";
            // 
            // agilityTextBox
            // 
            agilityTextBox.Location = new Point(202, 145);
            agilityTextBox.Margin = new Padding(2);
            agilityTextBox.Name = "agilityTextBox";
            agilityTextBox.Size = new Size(28, 23);
            agilityTextBox.TabIndex = 74;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 125);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 73;
            label6.Text = "Agility";
            // 
            // willpowerTextBox
            // 
            willpowerTextBox.Location = new Point(134, 145);
            willpowerTextBox.Margin = new Padding(2);
            willpowerTextBox.Name = "willpowerTextBox";
            willpowerTextBox.Size = new Size(28, 23);
            willpowerTextBox.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 125);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 71;
            label4.Text = "Willpower";
            // 
            // strengthTextBox
            // 
            strengthTextBox.Location = new Point(62, 145);
            strengthTextBox.Margin = new Padding(2);
            strengthTextBox.Name = "strengthTextBox";
            strengthTextBox.Size = new Size(28, 23);
            strengthTextBox.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 125);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 69;
            label5.Text = "Strength";
            // 
            // movementTextBox
            // 
            movementTextBox.Location = new Point(191, 91);
            movementTextBox.Margin = new Padding(2);
            movementTextBox.Name = "movementTextBox";
            movementTextBox.PlaceholderText = "MV";
            movementTextBox.Size = new Size(28, 23);
            movementTextBox.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 94);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 67;
            label2.Text = "Movement";
            // 
            // armorTextBox
            // 
            armorTextBox.Location = new Point(90, 91);
            armorTextBox.Margin = new Padding(2);
            armorTextBox.Name = "armorTextBox";
            armorTextBox.PlaceholderText = "AM";
            armorTextBox.Size = new Size(28, 23);
            armorTextBox.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 65;
            label3.Text = "Armor";
            // 
            // minusWoundButton
            // 
            minusWoundButton.BackColor = Color.Red;
            minusWoundButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minusWoundButton.Location = new Point(265, 65);
            minusWoundButton.Margin = new Padding(2);
            minusWoundButton.Name = "minusWoundButton";
            minusWoundButton.Size = new Size(24, 23);
            minusWoundButton.TabIndex = 64;
            minusWoundButton.Text = " - ";
            minusWoundButton.TextAlign = ContentAlignment.MiddleLeft;
            minusWoundButton.UseVisualStyleBackColor = false;
            // 
            // plusWoundButton
            // 
            plusWoundButton.BackColor = Color.LimeGreen;
            plusWoundButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plusWoundButton.Location = new Point(238, 65);
            plusWoundButton.Margin = new Padding(2);
            plusWoundButton.Name = "plusWoundButton";
            plusWoundButton.Size = new Size(23, 23);
            plusWoundButton.TabIndex = 63;
            plusWoundButton.Text = "+";
            plusWoundButton.TextAlign = ContentAlignment.MiddleLeft;
            plusWoundButton.UseVisualStyleBackColor = false;
            // 
            // currentWoundsTextBox
            // 
            currentWoundsTextBox.Location = new Point(206, 64);
            currentWoundsTextBox.Margin = new Padding(2);
            currentWoundsTextBox.Name = "currentWoundsTextBox";
            currentWoundsTextBox.PlaceholderText = "WD";
            currentWoundsTextBox.Size = new Size(28, 23);
            currentWoundsTextBox.TabIndex = 62;
            // 
            // currentWoundsLabel
            // 
            currentWoundsLabel.AutoSize = true;
            currentWoundsLabel.Location = new Point(111, 67);
            currentWoundsLabel.Margin = new Padding(2, 0, 2, 0);
            currentWoundsLabel.Name = "currentWoundsLabel";
            currentWoundsLabel.Size = new Size(94, 15);
            currentWoundsLabel.TabIndex = 61;
            currentWoundsLabel.Text = "Current Wounds";
            // 
            // maxWoundsTextBox
            // 
            maxWoundsTextBox.Location = new Point(79, 64);
            maxWoundsTextBox.Margin = new Padding(2);
            maxWoundsTextBox.Name = "maxWoundsTextBox";
            maxWoundsTextBox.PlaceholderText = "WD";
            maxWoundsTextBox.Size = new Size(28, 23);
            maxWoundsTextBox.TabIndex = 60;
            // 
            // maxWoundsLabel
            // 
            maxWoundsLabel.AutoSize = true;
            maxWoundsLabel.Location = new Point(5, 67);
            maxWoundsLabel.Margin = new Padding(2, 0, 2, 0);
            maxWoundsLabel.Name = "maxWoundsLabel";
            maxWoundsLabel.Size = new Size(77, 15);
            maxWoundsLabel.TabIndex = 59;
            maxWoundsLabel.Text = "Max Wounds";
            // 
            // minusHpButton
            // 
            minusHpButton.BackColor = Color.Red;
            minusHpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minusHpButton.Location = new Point(238, 38);
            minusHpButton.Margin = new Padding(2);
            minusHpButton.Name = "minusHpButton";
            minusHpButton.Size = new Size(24, 23);
            minusHpButton.TabIndex = 58;
            minusHpButton.Text = " - ";
            minusHpButton.TextAlign = ContentAlignment.MiddleLeft;
            minusHpButton.UseVisualStyleBackColor = false;
            // 
            // plusHpButton
            // 
            plusHpButton.BackColor = Color.LimeGreen;
            plusHpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plusHpButton.Location = new Point(211, 37);
            plusHpButton.Margin = new Padding(2);
            plusHpButton.Name = "plusHpButton";
            plusHpButton.Size = new Size(23, 23);
            plusHpButton.TabIndex = 57;
            plusHpButton.Text = "+";
            plusHpButton.TextAlign = ContentAlignment.MiddleLeft;
            plusHpButton.UseVisualStyleBackColor = false;
            // 
            // currentHpTextBox
            // 
            currentHpTextBox.Location = new Point(179, 37);
            currentHpTextBox.Margin = new Padding(2);
            currentHpTextBox.Name = "currentHpTextBox";
            currentHpTextBox.PlaceholderText = "HP";
            currentHpTextBox.Size = new Size(28, 23);
            currentHpTextBox.TabIndex = 56;
            // 
            // currentHpLabel
            // 
            currentHpLabel.AutoSize = true;
            currentHpLabel.Location = new Point(109, 41);
            currentHpLabel.Margin = new Padding(2, 0, 2, 0);
            currentHpLabel.Name = "currentHpLabel";
            currentHpLabel.Size = new Size(66, 15);
            currentHpLabel.TabIndex = 55;
            currentHpLabel.Text = "Current HP";
            // 
            // maxHpBox
            // 
            maxHpBox.Location = new Point(67, 37);
            maxHpBox.Margin = new Padding(2);
            maxHpBox.Name = "maxHpBox";
            maxHpBox.PlaceholderText = "HP";
            maxHpBox.Size = new Size(28, 23);
            maxHpBox.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 53;
            label1.Text = "Max HP";
            // 
            // enemyNameTextBox
            // 
            enemyNameTextBox.Location = new Point(93, 7);
            enemyNameTextBox.Margin = new Padding(2);
            enemyNameTextBox.Name = "enemyNameTextBox";
            enemyNameTextBox.PlaceholderText = "Enemy Name";
            enemyNameTextBox.Size = new Size(126, 23);
            enemyNameTextBox.TabIndex = 52;
            // 
            // enemyNameLabel
            // 
            enemyNameLabel.AutoSize = true;
            enemyNameLabel.Location = new Point(8, 11);
            enemyNameLabel.Margin = new Padding(2, 0, 2, 0);
            enemyNameLabel.Name = "enemyNameLabel";
            enemyNameLabel.Size = new Size(81, 15);
            enemyNameLabel.TabIndex = 51;
            enemyNameLabel.Text = " Enemy Name";
            // 
            // addForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(enemyPanel);
            Controls.Add(deleteEnemyButton);
            Controls.Add(addEnemyButton);
            Controls.Add(titleLabel);
            Controls.Add(enemyListBox);
            Controls.Add(enemyLabel);
            Controls.Add(cancelButton);
            Controls.Add(descriptionBox);
            Controls.Add(nameBox);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Controls.Add(saveButton);
            Name = "addForm";
            Text = "Battle Creator";
            Load += addForm_Load;
            enemyPanel.ResumeLayout(false);
            enemyPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private TextBox descriptionBox;
        private TextBox nameBox;
        private Label descriptionLabel;
        private Label nameLabel;
        private Button cancelButton;
        private Label enemyLabel;
        private ListBox enemyListBox;
        private Label titleLabel;
        private Button addEnemyButton;
        private Button deleteEnemyButton;
        private Panel enemyPanel;
        private Button weaponsButton;
        private Button skillsButton;
        private TextBox intelligenceTextBox;
        private Label label7;
        private TextBox knowledgeTextBox;
        private Label label8;
        private TextBox charismaTextBox;
        private Label label9;
        private TextBox agilityTextBox;
        private Label label6;
        private TextBox willpowerTextBox;
        private Label label4;
        private TextBox strengthTextBox;
        private Label label5;
        private TextBox movementTextBox;
        private Label label2;
        private TextBox armorTextBox;
        private Label label3;
        private Button minusWoundButton;
        private Button plusWoundButton;
        private TextBox currentWoundsTextBox;
        private Label currentWoundsLabel;
        private TextBox maxWoundsTextBox;
        private Label maxWoundsLabel;
        private Button minusHpButton;
        private Button plusHpButton;
        private TextBox currentHpTextBox;
        private Label currentHpLabel;
        private TextBox maxHpBox;
        private Label label1;
        private TextBox enemyNameTextBox;
        private Label enemyNameLabel;
        private TextBox enduranceTextBox;
        private Label enduranceLabel;
        private Button saveEnemyButton;
    }
}