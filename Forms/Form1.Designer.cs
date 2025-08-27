namespace Thing
{
    partial class ParasiteDimension
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParasiteDimension));
            battleListBox = new ListBox();
            newButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            titleLabel = new Label();
            battleLabel = new Label();
            textBox1 = new TextBox();
            refreshButton = new Button();
            SuspendLayout();
            // 
            // battleListBox
            // 
            battleListBox.FormattingEnabled = true;
            battleListBox.ItemHeight = 15;
            battleListBox.Location = new Point(12, 97);
            battleListBox.Name = "battleListBox";
            battleListBox.Size = new Size(163, 229);
            battleListBox.TabIndex = 0;
            battleListBox.SelectedIndexChanged += battleListBox_SelectedIndexChanged;
            // 
            // newButton
            // 
            newButton.Location = new Point(125, 332);
            newButton.Name = "newButton";
            newButton.Size = new Size(50, 23);
            newButton.TabIndex = 1;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(71, 332);
            editButton.Name = "editButton";
            editButton.Size = new Size(48, 23);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(15, 332);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(50, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold);
            titleLabel.Location = new Point(49, 9);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(712, 54);
            titleLabel.TabIndex = 16;
            titleLabel.Text = "Parasite Dimension Battle Manager";
            titleLabel.Click += titleLabel_Click;
            // 
            // battleLabel
            // 
            battleLabel.AutoSize = true;
            battleLabel.Location = new Point(71, 79);
            battleLabel.Name = "battleLabel";
            battleLabel.Size = new Size(42, 15);
            battleLabel.TabIndex = 17;
            battleLabel.Text = "Battles";
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(482, 97);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(279, 171);
            textBox1.TabIndex = 18;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(49, 370);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 19;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // ParasiteDimension
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(refreshButton);
            Controls.Add(textBox1);
            Controls.Add(battleLabel);
            Controls.Add(titleLabel);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(battleListBox);
            Name = "ParasiteDimension";
            Text = "ParasiteDimension";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox battleListBox;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private Label titleLabel;
        private Label battleLabel;
        private TextBox textBox1;
        private Button refreshButton;
    }
}
