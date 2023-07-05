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
            this.compareSelectedFilesButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.filePath1.Enabled = false;
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Location = new System.Drawing.Point(12, 76);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(960, 236);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.TabStop = false;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel.Text = "Test mode";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // FileDifferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(984, 338);
            this.Controls.Add(this.dataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectBaseFileButton;
        private System.Windows.Forms.TextBox filePath1;
        private System.Windows.Forms.TextBox filePath2;
        private System.Windows.Forms.Button selectModFileButton;
        private System.Windows.Forms.Button compareSelectedFilesButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}