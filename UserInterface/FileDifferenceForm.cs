using System;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiffEngine;
using DiffEngine.DTO;
using System.Collections.Generic;
using System.Drawing;

namespace UserInterface
{
    public partial class FileDifferenceForm : Form
    {
        #region Variables
        private string baseFilePath { get { return filePath1.Text; } }
        private string modFilePath { get { return filePath2.Text; } }

        private BinaryComparer binaryComparer;
        private ComparisionResult comparisionResult;
        #endregion

        public FileDifferenceForm()
        {
            InitializeComponent();
        }
        #region Events
        private void OnLoad(object sender, EventArgs e)
        {

        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion
        private string Compare(string baseFile, string modFile)
        {
            FileStream fs1 = new FileStream(baseFile, FileMode.Open, FileAccess.Read);
            FileStream fs2 = new FileStream(modFile, FileMode.Open, FileAccess.Read);

            var bits1 = new byte[(int)fs1.Length];
            var bits2 = new byte[(int)fs2.Length];
            fs1.Read(bits1, 0, (int)fs1.Length);
            fs2.Read(bits2, 0, (int)fs2.Length);

            var len = (int)fs1.Length;
            
            for (int ix = 0; ix < len; ix += 16)
            {
                var cnt = Math.Min(16, len - ix);
                var line1 = new byte[cnt];
                var line2 = new byte[cnt];

                Array.Copy(bits1, ix, line1, 0, cnt);
                Array.Copy(bits2, ix, line2, 0, cnt);
                
                // Write address + hex + ascii
                for (int jx = 0; jx < cnt; jx++)
                {
                    if (line1[jx] != line2[jx])
                    {
                        Console.Write($"{ix:X8}:  {BitConverter.ToString(BitConverter.GetBytes(line1[jx])).Split('-')[0]} {BitConverter.ToString(BitConverter.GetBytes(line2[jx])).Split('-')[0]}  |  ");
                        Console.WriteLine(BitConverter.ToString(line1));
                    }
                }
            }
            return string.Empty;
        }

        private string GetFileName()
        {
            string fileName = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            saveResultStripButton.Visible = false;
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

        private string SaveFileName()
        {
            string fileName = string.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Path.Combine($"{Application.StartupPath.ToString()}\\Test");
            saveFileDialog.Filter = "(BIN)|*.bin";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
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
            saveResultStripButton.Visible = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
           
            if (!baseFilePath.Equals(string.Empty) && !modFilePath.Equals(string.Empty))
            {
                //Compare(baseFilePath, modFilePath);
                binaryComparer = new BinaryComparer(baseFilePath, modFilePath);
                comparisionResult = binaryComparer.PerformComparision();
                PrintResults(comparisionResult);
                if (comparisionResult.comparisionResultType == ComparisionResultType.HaveDifferences)
                {
                    saveResultStripButton.Visible = true;
                }
                
            }
            else
                MessageBox.Show("Выберите файлы для сравнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void PrintResults(ComparisionResult comparisionResult)
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

            dataGridView1.Columns.Add("address", "Адрес");
            
            for (int i = 0; i < 16; i++)
                dataGridView1.Columns.Add($"f1{i:X}", $"{i:X}");
            dataGridView1.Columns.Add("space", "");
            for (int i = 0; i < 16; i++)
                dataGridView1.Columns.Add($"f2{i:X}", $"{i:X}");

            for (int i = 0; i < comparisionResult.differences.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = comparisionResult.differences[i].Address.ToString("X8");
                string[] arr1 = comparisionResult.differences[i].originExample.Split('-');
                string[] arr2 = comparisionResult.differences[i].modificationExample.Split('-');
                for (int j = 0; j < 16; j++)
                {
                    dataGridView1.Rows[i].Cells[j + 1].Value = arr1[j];
                    if (j == comparisionResult.differences[i].Position)
                    {
                        dataGridView1.Rows[i].Cells[j + 1].Style.BackColor = Color.FromArgb(34, 139, 34);
                        dataGridView1.Rows[i].Cells[j + 1].Style.ForeColor = Color.White;
                    }

                }
                for (int j = 17; j < 33; j++)
                {
                    dataGridView1.Rows[i].Cells[j + 1].Value = arr2[j - 17];
                    if (j - 17 == comparisionResult.differences[i].Position)
                    {
                        dataGridView1.Rows[i].Cells[j + 1].Style.BackColor = Color.FromArgb(106, 90, 205);
                        dataGridView1.Rows[i].Cells[j + 1].Style.ForeColor = Color.White;
                    }
                }
                toolStripProgressBar1.Value = i;
                dataGridView1.Columns[0].Width = 60;
            }
            toolStripProgressBar1.Value = 0;
        }

        private void saveResultStripButton_Click(object sender, EventArgs e)
        {
            string saveFile = SaveFileName();
            if (saveFile != string.Empty)
            {
                binaryComparer.SaveComparisionResults(comparisionResult, saveFile);
                saveResultStripButton.Visible = false;
                /*filePath1.Text = string.Empty;
                filePath2.Text = string.Empty;
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();*/
                Application.Exit();
            }
        }
    }
}