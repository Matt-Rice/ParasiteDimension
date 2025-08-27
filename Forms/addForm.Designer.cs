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
            label10 = new Label();
            damageTextBox = new TextBox();
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
            saveButton.Location = new Point(1029, 678);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(97, 52);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += Save_Click;
            // 
            // descriptionBox
            // 
            descriptionBox.Location = new Point(30, 278);
            descriptionBox.Margin = new Padding(4, 5, 4, 5);
            descriptionBox.Multiline = true;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.PlaceholderText = "Description";
            descriptionBox.Size = new Size(263, 411);
            descriptionBox.TabIndex = 11;
            descriptionBox.TextChanged += descriptionBox_TextChanged;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(30, 182);
            nameBox.Margin = new Padding(4, 5, 4, 5);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.Size = new Size(263, 31);
            nameBox.TabIndex = 10;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(100, 248);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(102, 25);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "Description";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(120, 152);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 25);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(903, 678);
            cancelButton.Margin = new Padding(4, 5, 4, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(97, 52);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // enemyLabel
            // 
            enemyLabel.AutoSize = true;
            enemyLabel.Location = new Point(454, 153);
            enemyLabel.Margin = new Padding(4, 0, 4, 0);
            enemyLabel.Name = "enemyLabel";
            enemyLabel.Size = new Size(77, 25);
            enemyLabel.TabIndex = 13;
            enemyLabel.Text = "Enemies";
            enemyLabel.Click += enemyLabel_Click;
            // 
            // enemyListBox
            // 
            enemyListBox.FormattingEnabled = true;
            enemyListBox.ItemHeight = 25;
            enemyListBox.Location = new Point(361, 182);
            enemyListBox.Name = "enemyListBox";
            enemyListBox.Size = new Size(274, 404);
            enemyListBox.TabIndex = 14;
            enemyListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            titleLabel.Location = new Point(283, 8);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(597, 106);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "Battle Creator";
            // 
            // addEnemyButton
            // 
            addEnemyButton.Location = new Point(523, 613);
            addEnemyButton.Name = "addEnemyButton";
            addEnemyButton.Size = new Size(111, 58);
            addEnemyButton.TabIndex = 16;
            addEnemyButton.Text = "Add Enemy";
            addEnemyButton.UseVisualStyleBackColor = true;
            addEnemyButton.Click += addEnemyButton_Click;
            // 
            // deleteEnemyButton
            // 
            deleteEnemyButton.Location = new Point(361, 617);
            deleteEnemyButton.Name = "deleteEnemyButton";
            deleteEnemyButton.Size = new Size(131, 52);
            deleteEnemyButton.TabIndex = 18;
            deleteEnemyButton.Text = "Delete Enemy";
            deleteEnemyButton.UseVisualStyleBackColor = true;
            deleteEnemyButton.Click += deleteEnemyButton_Click;
            // 
            // enemyPanel
            // 
            enemyPanel.Controls.Add(label10);
            enemyPanel.Controls.Add(damageTextBox);
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
            enemyPanel.Location = new Point(680, 182);
            enemyPanel.Margin = new Padding(4, 5, 4, 5);
            enemyPanel.Name = "enemyPanel";
            enemyPanel.Size = new Size(524, 490);
            enemyPanel.TabIndex = 51;
            enemyPanel.Visible = false;
            enemyPanel.Paint += enemyPanel_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(379, 40);
            label10.Name = "label10";
            label10.Size = new Size(118, 25);
            label10.TabIndex = 87;
            label10.Text = "Damage Amt";
            // 
            // damageTextBox
            // 
            damageTextBox.Location = new Point(397, 68);
            damageTextBox.Name = "damageTextBox";
            damageTextBox.Size = new Size(66, 31);
            damageTextBox.TabIndex = 86;
            // 
            // saveEnemyButton
            // 
            saveEnemyButton.Location = new Point(289, 432);
            saveEnemyButton.Margin = new Padding(4, 5, 4, 5);
            saveEnemyButton.Name = "saveEnemyButton";
            saveEnemyButton.Size = new Size(116, 38);
            saveEnemyButton.TabIndex = 85;
            saveEnemyButton.Text = "Save Enemy";
            saveEnemyButton.UseVisualStyleBackColor = true;
            saveEnemyButton.Click += saveEnemyButton_Click;
            // 
            // enduranceTextBox
            // 
            enduranceTextBox.Location = new Point(156, 403);
            enduranceTextBox.Name = "enduranceTextBox";
            enduranceTextBox.Size = new Size(109, 31);
            enduranceTextBox.TabIndex = 84;
            // 
            // enduranceLabel
            // 
            enduranceLabel.AutoSize = true;
            enduranceLabel.Location = new Point(162, 375);
            enduranceLabel.Name = "enduranceLabel";
            enduranceLabel.Size = new Size(94, 25);
            enduranceLabel.TabIndex = 83;
            enduranceLabel.Text = "Endurance";
            // 
            // weaponsButton
            // 
            weaponsButton.Location = new Point(156, 442);
            weaponsButton.Margin = new Padding(4, 5, 4, 5);
            weaponsButton.Name = "weaponsButton";
            weaponsButton.Size = new Size(100, 38);
            weaponsButton.TabIndex = 82;
            weaponsButton.Text = "Weapons";
            weaponsButton.UseVisualStyleBackColor = true;
            weaponsButton.Click += weaponsButton_Click;
            // 
            // skillsButton
            // 
            skillsButton.Location = new Point(43, 432);
            skillsButton.Margin = new Padding(4, 5, 4, 5);
            skillsButton.Name = "skillsButton";
            skillsButton.Size = new Size(74, 38);
            skillsButton.TabIndex = 81;
            skillsButton.Text = "Skills";
            skillsButton.UseVisualStyleBackColor = true;
            skillsButton.Click += skillsButton_Click;
            // 
            // intelligenceTextBox
            // 
            intelligenceTextBox.Location = new Point(318, 327);
            intelligenceTextBox.Name = "intelligenceTextBox";
            intelligenceTextBox.Size = new Size(105, 31);
            intelligenceTextBox.TabIndex = 80;
            intelligenceTextBox.TextChanged += intelligenceTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(322, 293);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 79;
            label7.Text = "Intelligence";
            label7.Click += label7_Click;
            // 
            // knowledgeTextBox
            // 
            knowledgeTextBox.Location = new Point(156, 327);
            knowledgeTextBox.Name = "knowledgeTextBox";
            knowledgeTextBox.Size = new Size(109, 31);
            knowledgeTextBox.TabIndex = 78;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(156, 293);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 77;
            label8.Text = "Knowledge";
            // 
            // charismaTextBox
            // 
            charismaTextBox.Location = new Point(11, 327);
            charismaTextBox.Name = "charismaTextBox";
            charismaTextBox.Size = new Size(106, 31);
            charismaTextBox.TabIndex = 76;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 293);
            label9.Name = "label9";
            label9.Size = new Size(85, 25);
            label9.TabIndex = 75;
            label9.Text = "Charisma";
            // 
            // agilityTextBox
            // 
            agilityTextBox.Location = new Point(318, 242);
            agilityTextBox.Name = "agilityTextBox";
            agilityTextBox.Size = new Size(105, 31);
            agilityTextBox.TabIndex = 74;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 208);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 73;
            label6.Text = "Agility";
            label6.Click += label6_Click;
            // 
            // willpowerTextBox
            // 
            willpowerTextBox.Location = new Point(156, 242);
            willpowerTextBox.Name = "willpowerTextBox";
            willpowerTextBox.Size = new Size(116, 31);
            willpowerTextBox.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 208);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 71;
            label4.Text = "Willpower";
            // 
            // strengthTextBox
            // 
            strengthTextBox.Location = new Point(11, 242);
            strengthTextBox.Name = "strengthTextBox";
            strengthTextBox.Size = new Size(106, 31);
            strengthTextBox.TabIndex = 70;
            strengthTextBox.TextChanged += strengthTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 208);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 69;
            label5.Text = "Strength";
            // 
            // movementTextBox
            // 
            movementTextBox.Location = new Point(273, 152);
            movementTextBox.Name = "movementTextBox";
            movementTextBox.PlaceholderText = "MV";
            movementTextBox.Size = new Size(38, 31);
            movementTextBox.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 157);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 67;
            label2.Text = "Movement";
            // 
            // armorTextBox
            // 
            armorTextBox.Location = new Point(129, 152);
            armorTextBox.Name = "armorTextBox";
            armorTextBox.PlaceholderText = "AM";
            armorTextBox.Size = new Size(38, 31);
            armorTextBox.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 157);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 65;
            label3.Text = "Armor";
            // 
            // minusWoundButton
            // 
            minusWoundButton.BackColor = Color.Red;
            minusWoundButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minusWoundButton.Location = new Point(379, 108);
            minusWoundButton.Name = "minusWoundButton";
            minusWoundButton.Size = new Size(34, 38);
            minusWoundButton.TabIndex = 64;
            minusWoundButton.Text = " - ";
            minusWoundButton.TextAlign = ContentAlignment.MiddleLeft;
            minusWoundButton.UseVisualStyleBackColor = false;
            minusWoundButton.Click += minusWoundButton_Click;
            // 
            // plusWoundButton
            // 
            plusWoundButton.BackColor = Color.LimeGreen;
            plusWoundButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plusWoundButton.Location = new Point(340, 108);
            plusWoundButton.Name = "plusWoundButton";
            plusWoundButton.Size = new Size(33, 38);
            plusWoundButton.TabIndex = 63;
            plusWoundButton.Text = "+";
            plusWoundButton.TextAlign = ContentAlignment.MiddleLeft;
            plusWoundButton.UseVisualStyleBackColor = false;
            plusWoundButton.Click += plusWoundButton_Click;
            // 
            // currentWoundsTextBox
            // 
            currentWoundsTextBox.Location = new Point(294, 107);
            currentWoundsTextBox.Name = "currentWoundsTextBox";
            currentWoundsTextBox.PlaceholderText = "WD";
            currentWoundsTextBox.Size = new Size(38, 31);
            currentWoundsTextBox.TabIndex = 62;
            // 
            // currentWoundsLabel
            // 
            currentWoundsLabel.AutoSize = true;
            currentWoundsLabel.Location = new Point(159, 112);
            currentWoundsLabel.Name = "currentWoundsLabel";
            currentWoundsLabel.Size = new Size(141, 25);
            currentWoundsLabel.TabIndex = 61;
            currentWoundsLabel.Text = "Current Wounds";
            // 
            // maxWoundsTextBox
            // 
            maxWoundsTextBox.Location = new Point(113, 107);
            maxWoundsTextBox.Name = "maxWoundsTextBox";
            maxWoundsTextBox.PlaceholderText = "WD";
            maxWoundsTextBox.Size = new Size(38, 31);
            maxWoundsTextBox.TabIndex = 60;
            // 
            // maxWoundsLabel
            // 
            maxWoundsLabel.AutoSize = true;
            maxWoundsLabel.Location = new Point(7, 112);
            maxWoundsLabel.Name = "maxWoundsLabel";
            maxWoundsLabel.Size = new Size(116, 25);
            maxWoundsLabel.TabIndex = 59;
            maxWoundsLabel.Text = "Max Wounds";
            // 
            // minusHpButton
            // 
            minusHpButton.BackColor = Color.Red;
            minusHpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minusHpButton.Location = new Point(340, 63);
            minusHpButton.Name = "minusHpButton";
            minusHpButton.Size = new Size(34, 38);
            minusHpButton.TabIndex = 58;
            minusHpButton.Text = " - ";
            minusHpButton.TextAlign = ContentAlignment.MiddleLeft;
            minusHpButton.UseVisualStyleBackColor = false;
            minusHpButton.Click += minusHpButton_Click;
            // 
            // plusHpButton
            // 
            plusHpButton.BackColor = Color.LimeGreen;
            plusHpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plusHpButton.Location = new Point(301, 62);
            plusHpButton.Name = "plusHpButton";
            plusHpButton.Size = new Size(33, 38);
            plusHpButton.TabIndex = 57;
            plusHpButton.Text = "+";
            plusHpButton.TextAlign = ContentAlignment.MiddleLeft;
            plusHpButton.UseVisualStyleBackColor = false;
            plusHpButton.Click += plusHpButton_Click;
            // 
            // currentHpTextBox
            // 
            currentHpTextBox.Location = new Point(256, 62);
            currentHpTextBox.Name = "currentHpTextBox";
            currentHpTextBox.PlaceholderText = "HP";
            currentHpTextBox.Size = new Size(38, 31);
            currentHpTextBox.TabIndex = 56;
            // 
            // currentHpLabel
            // 
            currentHpLabel.AutoSize = true;
            currentHpLabel.Location = new Point(156, 68);
            currentHpLabel.Name = "currentHpLabel";
            currentHpLabel.Size = new Size(98, 25);
            currentHpLabel.TabIndex = 55;
            currentHpLabel.Text = "Current HP";
            // 
            // maxHpBox
            // 
            maxHpBox.Location = new Point(96, 62);
            maxHpBox.Name = "maxHpBox";
            maxHpBox.PlaceholderText = "HP";
            maxHpBox.Size = new Size(54, 31);
            maxHpBox.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 68);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 53;
            label1.Text = "Max HP";
            // 
            // enemyNameTextBox
            // 
            enemyNameTextBox.Location = new Point(133, 12);
            enemyNameTextBox.Name = "enemyNameTextBox";
            enemyNameTextBox.PlaceholderText = "Enemy Name";
            enemyNameTextBox.Size = new Size(178, 31);
            enemyNameTextBox.TabIndex = 52;
            // 
            // enemyNameLabel
            // 
            enemyNameLabel.AutoSize = true;
            enemyNameLabel.Location = new Point(11, 18);
            enemyNameLabel.Name = "enemyNameLabel";
            enemyNameLabel.Size = new Size(122, 25);
            enemyNameLabel.TabIndex = 51;
            enemyNameLabel.Text = " Enemy Name";
            // 
            // addForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 750);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Label label10;
        private TextBox damageTextBox;
    }
}