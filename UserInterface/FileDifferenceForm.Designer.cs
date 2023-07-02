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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("asd");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("123");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("123");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("123");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("123");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("123");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("123");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("123");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("123");
            this.selectBaseFileButton = new System.Windows.Forms.Button();
            this.filePath1 = new System.Windows.Forms.TextBox();
            this.filePath2 = new System.Windows.Forms.TextBox();
            this.selectModFileButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.resultListView = new System.Windows.Forms.ListView();
            this.compareSelectedFilesButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginExample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModificationExample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectBaseFileButton
            // 
            this.selectBaseFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.selectBaseFileButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectBaseFileButton.Location = new System.Drawing.Point(88, 12);
            this.selectBaseFileButton.Name = "selectBaseFileButton";
            this.selectBaseFileButton.Size = new System.Drawing.Size(223, 39);
            this.selectBaseFileButton.TabIndex = 2;
            this.selectBaseFileButton.Text = "Выбрать Исходный Файл";
            this.selectBaseFileButton.UseVisualStyleBackColor = true;
            this.selectBaseFileButton.Click += new System.EventHandler(this.SelectBaseFileButton_Click);
            // 
            // filePath1
            // 
            this.filePath1.Enabled = false;
            this.filePath1.Font = new System.Drawing.Font("Consolas", 10F);
            this.filePath1.Location = new System.Drawing.Point(88, 51);
            this.filePath1.Name = "filePath1";
            this.filePath1.ReadOnly = true;
            this.filePath1.Size = new System.Drawing.Size(223, 23);
            this.filePath1.TabIndex = 2;
            this.filePath1.TabStop = false;
            this.filePath1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // filePath2
            // 
            this.filePath2.Enabled = false;
            this.filePath2.Font = new System.Drawing.Font("Consolas", 10F);
            this.filePath2.Location = new System.Drawing.Point(454, 51);
            this.filePath2.Name = "filePath2";
            this.filePath2.ReadOnly = true;
            this.filePath2.Size = new System.Drawing.Size(223, 23);
            this.filePath2.TabIndex = 3;
            this.filePath2.TabStop = false;
            this.filePath2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // selectModFileButton
            // 
            this.selectModFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.selectModFileButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectModFileButton.Location = new System.Drawing.Point(454, 12);
            this.selectModFileButton.Name = "selectModFileButton";
            this.selectModFileButton.Size = new System.Drawing.Size(223, 39);
            this.selectModFileButton.TabIndex = 3;
            this.selectModFileButton.Text = "Выбрать Модифицированный Файл";
            this.selectModFileButton.UseVisualStyleBackColor = true;
            this.selectModFileButton.Click += new System.EventHandler(this.SelectModFileButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // resultListView
            // 
            this.resultListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.resultListView.FullRowSelect = true;
            this.resultListView.GridLines = true;
            this.resultListView.HideSelection = false;
            this.resultListView.HotTracking = true;
            this.resultListView.HoverSelection = true;
            this.resultListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.resultListView.Location = new System.Drawing.Point(12, 175);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(760, 235);
            this.resultListView.TabIndex = 10;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            // 
            // compareSelectedFilesButton
            // 
            this.compareSelectedFilesButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.compareSelectedFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.compareSelectedFilesButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compareSelectedFilesButton.Location = new System.Drawing.Point(314, 12);
            this.compareSelectedFilesButton.Name = "compareSelectedFilesButton";
            this.compareSelectedFilesButton.Size = new System.Drawing.Size(136, 157);
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
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Address,
            this.OriginExample,
            this.ModificationExample});
            this.dataGridView.Location = new System.Drawing.Point(750, -102);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(589, 235);
            this.dataGridView.TabIndex = 11;
            // 
            // Index
            // 
            this.Index.HeaderText = "#";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // OriginExample
            // 
            this.OriginExample.HeaderText = "Origin";
            this.OriginExample.Name = "OriginExample";
            this.OriginExample.ReadOnly = true;
            // 
            // ModificationExample
            // 
            this.ModificationExample.HeaderText = "Modification";
            this.ModificationExample.Name = "ModificationExample";
            this.ModificationExample.ReadOnly = true;
            // 
            // FileDifferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(784, 436);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.filePath2);
            this.Controls.Add(this.selectModFileButton);
            this.Controls.Add(this.filePath1);
            this.Controls.Add(this.compareSelectedFilesButton);
            this.Controls.Add(this.selectBaseFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FileDifferenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сравнение файлов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.Button compareSelectedFilesButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginExample;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModificationExample;
    }
}