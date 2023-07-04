namespace UserInterface
{
    partial class FileDifferenceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectBaseFileButton = new System.Windows.Forms.Button();
            this.filePath1 = new System.Windows.Forms.TextBox();
            this.filePath2 = new System.Windows.Forms.TextBox();
            this.selectModFileButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultListView = new System.Windows.Forms.ListView();
            this.compareSelectedFilesButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectBaseFileButton
            // 
            this.selectBaseFileButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectBaseFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectBaseFileButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectBaseFileButton.Location = new System.Drawing.Point(180, 9);
            this.selectBaseFileButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.selectBaseFileButton.Name = "selectBaseFileButton";
            this.selectBaseFileButton.Size = new System.Drawing.Size(224, 39);
            this.selectBaseFileButton.TabIndex = 2;
            this.selectBaseFileButton.Text = "Выбрать Исходный Файл";
            this.selectBaseFileButton.UseVisualStyleBackColor = false;
            this.selectBaseFileButton.Click += new System.EventHandler(this.SelectBaseFileButton_Click);
            // 
            // filePath1
            // 
            this.filePath1.Font = new System.Drawing.Font("Consolas", 10F);
            this.filePath1.Location = new System.Drawing.Point(180, 48);
            this.filePath1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.filePath1.Name = "filePath1";
            this.filePath1.ReadOnly = true;
            this.filePath1.Size = new System.Drawing.Size(224, 23);
            this.filePath1.TabIndex = 2;
            this.filePath1.TabStop = false;
            this.filePath1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // filePath2
            // 
            this.filePath2.Enabled = false;
            this.filePath2.Font = new System.Drawing.Font("Consolas", 10F);
            this.filePath2.Location = new System.Drawing.Point(546, 48);
            this.filePath2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.filePath2.Name = "filePath2";
            this.filePath2.ReadOnly = true;
            this.filePath2.Size = new System.Drawing.Size(224, 23);
            this.filePath2.TabIndex = 3;
            this.filePath2.TabStop = false;
            this.filePath2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // selectModFileButton
            // 
            this.selectModFileButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectModFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectModFileButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectModFileButton.Location = new System.Drawing.Point(546, 9);
            this.selectModFileButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.selectModFileButton.Name = "selectModFileButton";
            this.selectModFileButton.Size = new System.Drawing.Size(224, 39);
            this.selectModFileButton.TabIndex = 3;
            this.selectModFileButton.Text = "Выбрать Модифицированный Файл";
            this.selectModFileButton.UseVisualStyleBackColor = false;
            this.selectModFileButton.Click += new System.EventHandler(this.SelectModFileButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(166, 17);
            this.toolStripStatusLabel.Text = "Application work in test mode";
            // 
            // resultListView
            // 
            this.resultListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.resultListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultListView.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultListView.FullRowSelect = true;
            this.resultListView.HideSelection = false;
            this.resultListView.LabelWrap = false;
            this.resultListView.Location = new System.Drawing.Point(12, 78);
            this.resultListView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(960, 234);
            this.resultListView.TabIndex = 10;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Tile;
            // 
            // compareSelectedFilesButton
            // 
            this.compareSelectedFilesButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.compareSelectedFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.compareSelectedFilesButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compareSelectedFilesButton.Location = new System.Drawing.Point(406, 9);
            this.compareSelectedFilesButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.compareSelectedFilesButton.Name = "compareSelectedFilesButton";
            this.compareSelectedFilesButton.Size = new System.Drawing.Size(136, 63);
            this.compareSelectedFilesButton.TabIndex = 1;
            this.compareSelectedFilesButton.Text = "<= Сравнить =>";
            this.compareSelectedFilesButton.UseVisualStyleBackColor = false;
            this.compareSelectedFilesButton.Click += new System.EventHandler(this.compareSelectedFilesButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(960, 236);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Адрес";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Позиция";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Исходная строка";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Модифицированная строка";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FileDifferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(984, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.filePath2);
            this.Controls.Add(this.selectModFileButton);
            this.Controls.Add(this.filePath1);
            this.Controls.Add(this.compareSelectedFilesButton);
            this.Controls.Add(this.selectBaseFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FileDifferenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сравнение файлов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectBaseFileButton;
        private System.Windows.Forms.TextBox filePath1;
        private System.Windows.Forms.TextBox filePath2;
        private System.Windows.Forms.Button selectModFileButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.Button compareSelectedFilesButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}