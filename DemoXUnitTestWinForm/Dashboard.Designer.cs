namespace DemoXUnitTestWinForm {
    partial class Dashboard {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            groupBox1 = new GroupBox();
            ResultTextBox = new TextBox();
            DivideButton = new Button();
            MultiplyButton = new Button();
            SubtractButton = new Button();
            AddButton = new Button();
            SecondNumericUpDown = new NumericUpDown();
            FirstNumericUpDown = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            UsersComboBox = new ComboBox();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            AddPersonButton = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SecondNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirstNumericUpDown).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ResultTextBox);
            groupBox1.Controls.Add(DivideButton);
            groupBox1.Controls.Add(MultiplyButton);
            groupBox1.Controls.Add(SubtractButton);
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(SecondNumericUpDown);
            groupBox1.Controls.Add(FirstNumericUpDown);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculator Section";
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(174, 217);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(100, 23);
            ResultTextBox.TabIndex = 13;
            // 
            // DivideButton
            // 
            DivideButton.FlatStyle = FlatStyle.Flat;
            DivideButton.Location = new Point(19, 246);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(94, 29);
            DivideButton.TabIndex = 11;
            DivideButton.Text = "Divide";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += DivideButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.FlatStyle = FlatStyle.Flat;
            MultiplyButton.Location = new Point(19, 211);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(94, 29);
            MultiplyButton.TabIndex = 10;
            MultiplyButton.Text = "Multiply";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // SubtractButton
            // 
            SubtractButton.FlatStyle = FlatStyle.Flat;
            SubtractButton.Location = new Point(19, 176);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(94, 29);
            SubtractButton.TabIndex = 9;
            SubtractButton.Text = "Subtract";
            SubtractButton.UseVisualStyleBackColor = true;
            SubtractButton.Click += SubtractButton_Click;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Location = new Point(19, 141);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SecondNumericUpDown
            // 
            SecondNumericUpDown.Location = new Point(158, 100);
            SecondNumericUpDown.Name = "SecondNumericUpDown";
            SecondNumericUpDown.Size = new Size(137, 23);
            SecondNumericUpDown.TabIndex = 7;
            // 
            // FirstNumericUpDown
            // 
            FirstNumericUpDown.Location = new Point(158, 57);
            FirstNumericUpDown.Name = "FirstNumericUpDown";
            FirstNumericUpDown.Size = new Size(137, 23);
            FirstNumericUpDown.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 188);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 2;
            label3.Text = "Reult";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 102);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 1;
            label2.Text = "Second Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 59);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 0;
            label1.Text = "First Number";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(UsersComboBox);
            groupBox2.Controls.Add(LastNameTextBox);
            groupBox2.Controls.Add(FirstNameTextBox);
            groupBox2.Controls.Add(AddPersonButton);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(349, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 316);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Database Section";
            // 
            // UsersComboBox
            // 
            UsersComboBox.FormattingEnabled = true;
            UsersComboBox.Location = new Point(104, 51);
            UsersComboBox.Name = "UsersComboBox";
            UsersComboBox.Size = new Size(159, 25);
            UsersComboBox.TabIndex = 15;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(137, 150);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(126, 23);
            LastNameTextBox.TabIndex = 14;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(137, 99);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(126, 23);
            FirstNameTextBox.TabIndex = 13;
            // 
            // AddPersonButton
            // 
            AddPersonButton.FlatStyle = FlatStyle.Flat;
            AddPersonButton.Location = new Point(94, 246);
            AddPersonButton.Name = "AddPersonButton";
            AddPersonButton.Size = new Size(131, 29);
            AddPersonButton.TabIndex = 12;
            AddPersonButton.Text = "Add Person";
            AddPersonButton.UseVisualStyleBackColor = true;
            AddPersonButton.Click += AddPersonButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 59);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 3;
            label4.Text = "Users";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 102);
            label5.Name = "label5";
            label5.Size = new Size(88, 17);
            label5.TabIndex = 4;
            label5.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 153);
            label6.Name = "label6";
            label6.Size = new Size(80, 17);
            label6.TabIndex = 5;
            label6.Text = "Last Name";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 342);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SecondNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirstNumericUpDown).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Button DivideButton;
        private Button MultiplyButton;
        private Button SubtractButton;
        private Button AddButton;
        private NumericUpDown SecondNumericUpDown;
        private NumericUpDown FirstNumericUpDown;
        private Label label3;
        private Label label2;
        private Button AddPersonButton;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ResultTextBox;
        private ComboBox UsersComboBox;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
    }
}
