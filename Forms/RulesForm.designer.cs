
namespace Forms
{
    partial class RulesForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.RulesGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DesignerRadioButton = new System.Windows.Forms.RadioButton();
            this.StaticRadioButton = new System.Windows.Forms.RadioButton();
            this.DynamicRadioButton = new System.Windows.Forms.RadioButton();
            this.rulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruleSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thenValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elseValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RulesGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(650, 260);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RulesGrid
            // 
            this.RulesGrid.AllowUserToResizeRows = false;
            this.RulesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RulesGrid.AutoGenerateColumns = false;
            this.RulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RulesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priorityDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.thenValueDataGridViewTextBoxColumn,
            this.elseValueDataGridViewTextBoxColumn});
            this.RulesGrid.DataSource = this.rulesBindingSource;
            this.RulesGrid.Location = new System.Drawing.Point(138, 12);
            this.RulesGrid.Name = "RulesGrid";
            this.RulesGrid.RowHeadersVisible = false;
            this.RulesGrid.Size = new System.Drawing.Size(592, 242);
            this.RulesGrid.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DynamicRadioButton);
            this.groupBox1.Controls.Add(this.StaticRadioButton);
            this.groupBox1.Controls.Add(this.DesignerRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rule source";
            // 
            // DesignerRadioButton
            // 
            this.DesignerRadioButton.AutoSize = true;
            this.DesignerRadioButton.Location = new System.Drawing.Point(9, 28);
            this.DesignerRadioButton.Name = "DesignerRadioButton";
            this.DesignerRadioButton.Size = new System.Drawing.Size(82, 17);
            this.DesignerRadioButton.TabIndex = 0;
            this.DesignerRadioButton.TabStop = true;
            this.DesignerRadioButton.Text = "VS designer";
            this.DesignerRadioButton.UseVisualStyleBackColor = true;
            this.DesignerRadioButton.CheckedChanged += new System.EventHandler(this.DesignerRadioButton_CheckedChanged);
            // 
            // StaticRadioButton
            // 
            this.StaticRadioButton.AutoSize = true;
            this.StaticRadioButton.Location = new System.Drawing.Point(9, 51);
            this.StaticRadioButton.Name = "StaticRadioButton";
            this.StaticRadioButton.Size = new System.Drawing.Size(56, 17);
            this.StaticRadioButton.TabIndex = 1;
            this.StaticRadioButton.TabStop = true;
            this.StaticRadioButton.Text = "Coded";
            this.StaticRadioButton.UseVisualStyleBackColor = true;
            this.StaticRadioButton.CheckedChanged += new System.EventHandler(this.StaticRadioButton_CheckedChanged);
            // 
            // DynamicRadioButton
            // 
            this.DynamicRadioButton.AutoSize = true;
            this.DynamicRadioButton.Location = new System.Drawing.Point(9, 74);
            this.DynamicRadioButton.Name = "DynamicRadioButton";
            this.DynamicRadioButton.Size = new System.Drawing.Size(74, 17);
            this.DynamicRadioButton.TabIndex = 2;
            this.DynamicRadioButton.TabStop = true;
            this.DynamicRadioButton.Text = "This editor";
            this.DynamicRadioButton.UseVisualStyleBackColor = true;
            this.DynamicRadioButton.CheckedChanged += new System.EventHandler(this.DynamicRadioButton_CheckedChanged);
            // 
            // rulesBindingSource
            // 
            this.rulesBindingSource.DataMember = "Rules";
            this.rulesBindingSource.DataSource = this.ruleSettingsBindingSource;
            // 
            // ruleSettingsBindingSource
            // 
            this.ruleSettingsBindingSource.DataSource = typeof(Forms.RuleSettings);
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            // 
            // thenValueDataGridViewTextBoxColumn
            // 
            this.thenValueDataGridViewTextBoxColumn.DataPropertyName = "ThenValue";
            this.thenValueDataGridViewTextBoxColumn.HeaderText = "Then";
            this.thenValueDataGridViewTextBoxColumn.Name = "thenValueDataGridViewTextBoxColumn";
            // 
            // elseValueDataGridViewTextBoxColumn
            // 
            this.elseValueDataGridViewTextBoxColumn.DataPropertyName = "ElseValue";
            this.elseValueDataGridViewTextBoxColumn.HeaderText = "Else";
            this.elseValueDataGridViewTextBoxColumn.Name = "elseValueDataGridViewTextBoxColumn";
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(737, 286);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RulesGrid);
            this.Name = "RulesForm";
            this.ShowIcon = false;
            this.Text = "Simple rule editor";
            ((System.ComponentModel.ISupportInitialize)(this.RulesGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RulesGrid;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.BindingSource ruleSettingsBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DynamicRadioButton;
        private System.Windows.Forms.RadioButton StaticRadioButton;
        private System.Windows.Forms.RadioButton DesignerRadioButton;
        private System.Windows.Forms.BindingSource rulesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thenValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elseValueDataGridViewTextBoxColumn;
    }
}