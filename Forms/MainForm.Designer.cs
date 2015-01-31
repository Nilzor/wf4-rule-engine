namespace Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.MarriedCheckBox = new System.Windows.Forms.CheckBox();
            this.GenderDropDown = new System.Windows.Forms.ComboBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RulesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SalutationTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Firstname", true));
            this.FirstNameTextBox.Location = new System.Drawing.Point(6, 34);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(126, 20);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Name", true));
            this.LastNameTextBox.Location = new System.Drawing.Point(146, 34);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personBindingSource, "BirthDate", true));
            this.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDatePicker.Location = new System.Drawing.Point(5, 78);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(252, 20);
            this.BirthDatePicker.TabIndex = 2;
            // 
            // MarriedCheckBox
            // 
            this.MarriedCheckBox.AutoSize = true;
            this.MarriedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.personBindingSource, "Married", true));
            this.MarriedCheckBox.Location = new System.Drawing.Point(6, 104);
            this.MarriedCheckBox.Name = "MarriedCheckBox";
            this.MarriedCheckBox.Size = new System.Drawing.Size(72, 17);
            this.MarriedCheckBox.TabIndex = 3;
            this.MarriedCheckBox.Text = "Is Married";
            this.MarriedCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenderDropDown
            // 
            this.GenderDropDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Gender", true));
            this.GenderDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderDropDown.FormattingEnabled = true;
            this.GenderDropDown.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderDropDown.Location = new System.Drawing.Point(5, 140);
            this.GenderDropDown.Name = "GenderDropDown";
            this.GenderDropDown.Size = new System.Drawing.Size(121, 21);
            this.GenderDropDown.TabIndex = 4;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(6, 222);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(111, 23);
            this.ExecuteButton.TabIndex = 5;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(189, 253);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(111, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "&First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "&Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Birth date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender:";
            // 
            // RulesButton
            // 
            this.RulesButton.Location = new System.Drawing.Point(7, 193);
            this.RulesButton.Name = "RulesButton";
            this.RulesButton.Size = new System.Drawing.Size(111, 23);
            this.RulesButton.TabIndex = 11;
            this.RulesButton.Text = "Rules...";
            this.RulesButton.UseVisualStyleBackColor = true;
            this.RulesButton.Click += new System.EventHandler(this.RulesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Controls.Add(this.FirstNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BirthDatePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MarriedCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GenderDropDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 171);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // SalutationTextBox
            // 
            this.SalutationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Salutation", true));
            this.SalutationTextBox.Location = new System.Drawing.Point(149, 222);
            this.SalutationTextBox.Name = "SalutationTextBox";
            this.SalutationTextBox.Size = new System.Drawing.Size(127, 20);
            this.SalutationTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Salutation:";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(SharedLibrary.Person);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 288);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SalutationTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RulesButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ExecuteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Salutation demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.CheckBox MarriedCheckBox;
        private System.Windows.Forms.ComboBox GenderDropDown;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button RulesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SalutationTextBox;
        private System.Windows.Forms.Label label5;
    }
}

