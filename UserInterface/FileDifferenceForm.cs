using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using DiffEngine;
using DiffEngine.DTO;

namespace UserInterface
{
    public partial class FileDifferenceForm : Form
    {
        public FileDifferenceForm()
        {
            InitializeComponent();
        }
        #region Variables
        private string baseFilePath { get { return filePath1.Text; } }
        private string modFilePath { get { return filePath2.Text; } }

        private BinaryComparer binaryComparer;
        #endregion

        #region Events
        private void OnLoad(object sender, EventArgs e)
        {

        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        private string GetFileName()
        {
            string fileName = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.Combine($"{Application.StartupPath.ToString()}\\Test");
            openFileDialog.Filter = "(BIN)|*.bin";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }

            return fileName;
        }

        private void SelectBaseFileButton_Click(object sender, EventArgs e)
        {
            filePath1.Text = GetFileName();
        }

        private void SelectModFileButton_Click(object sender, EventArgs e)
        {
            filePath2.Text = GetFileName();
        }

        private void compareSelectedFilesButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            if (!baseFilePath.Equals(string.Empty) && !modFilePath.Equals(string.Empty))
            {
                binaryComparer = new BinaryComparer(baseFilePath, modFilePath);
                PrintResult(binaryComparer.PerformComparision());
            }
            else
                MessageBox.Show("Выберите файлы для сравнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void PrintResult(ComparisionResult comparisionResult)
        {
            switch(comparisionResult.comparisionResultType)
            {
                case ComparisionResultType.None:
                    MessageBox.Show($"Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                
                case ComparisionResultType.Equal:
                    MessageBox.Show($"Файлы идентичны", "Результат",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                
                case ComparisionResultType.DifferentSize:
                    MessageBox.Show($"Файлы различных размеров", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                
                case ComparisionResultType.HaveDifferences:
                    AddToDataGridView(comparisionResult);
                    break;
            }
        }

        private void AddToDataGridView(ComparisionResult comparisionResult)
        {
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = comparisionResult.differences.Length;

            dataGridView.Columns.Add("address", "Адрес");
            
            for (int i = 0; i < 16; i++)
                dataGridView.Columns.Add($"f1{i:X}", $"{i:X}");
            
            dataGridView.Columns.Add("space", " ");
            
            for (int i = 0; i < 16; i++)
                dataGridView.Columns.Add($"f2{i:X}", $"{i:X}");
            
            for (int i = 0; i < comparisionResult.differences.Length; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = comparisionResult.differences[i].Address.ToString("X8");
                
                byte[] arr1 = comparisionResult.differences[i].BaseLine;
                byte[] arr2 = comparisionResult.differences[i].ModifiedLine;

                for (int j = 0; j < 16; j++)
                {
                    dataGridView.Rows[i].Cells[j + 1].Value = ByteToString(arr1[j]);
                    dataGridView.Rows[i].Cells[j + 18].Value = ByteToString(arr2[j]);

                    if (arr1[j] != arr2[j])
                    {
                        dataGridView.Rows[i].Cells[j + 1].Style.BackColor = Color.FromArgb(34, 139, 34);
                        dataGridView.Rows[i].Cells[j + 18].Style.BackColor = Color.FromArgb(184, 134, 11);
                        dataGridView.Rows[i].Cells[j + 1].Style.ForeColor = Color.White;
                        dataGridView.Rows[i].Cells[j + 18].Style.ForeColor = Color.White;
                    }
                }

                toolStripProgressBar1.Value = i;
            }
                        
            toolStripProgressBar1.Value = 0;
            dataGridView.Columns[0].Width = 60;
        }

        private string ByteToString(byte value)
        {
            return BitConverter.ToString(BitConverter.GetBytes(value)).Split('-')[0];
        }
    }
}