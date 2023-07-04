using System;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiffEngine;
using DiffEngine.DTO;
using System.Collections.Generic;

namespace UserInterface
{
    public partial class FileDifferenceForm : Form
    {
        #region Variables
        private string baseFilePath { get { return filePath1.Text; } }
        private string modFilePath { get { return filePath2.Text; } }

        private static string bas = $"../../../Test/Base.bin";
        private static string mod = $"../../../Test/Remade.bin";

        private BinaryComparer binaryComparer;
        private ComparisionResult comparisionResult;

        private static bool baseFileIsLoaded = false;
        private static bool modFileIsLoaded = false;
        #endregion

        public FileDifferenceForm()
        {
            InitializeComponent();
            filePath1.Text = "D:\\Projects\\BinaryFilesComparer\\Test\\Base.bin";
            filePath2.Text = "D:\\Projects\\BinaryFilesComparer\\Test\\Remade.bin";
        }
        #region Events
        private void OnLoad(object sender, EventArgs e)
        {

        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        private static async Task<string> ReadFile(string filePath)
        {
            var fs = new FileStream(filePath, FileMode.Open);
            var len = (int)fs.Length;
            var bits = new byte[len];
            fs.Read(bits, 0, len);
            // Dump 16 bytes per line
            string result = "";
            for (int index = 0; index < len; index += 16)
            {
                var cnt = Math.Min(16, len - index);
                var line = new byte[cnt];
                Array.Copy(bits, index, line, 0, cnt);
                // Write address + hex
                result += $"{index:X8}:  {BitConverter.ToString(line)}";
                Console.WriteLine(result);
            }

            return result;
        }


        private string Compare(string baseFile, string modFile)
        {
            FileStream fs1 = new FileStream(baseFile, FileMode.Open, FileAccess.Read);
            FileStream fs2 = new FileStream(modFile, FileMode.Open, FileAccess.Read);

            var bits1 = new byte[(int)fs1.Length];
            var bits2 = new byte[(int)fs2.Length];
            fs1.Read(bits1, 0, (int)fs1.Length);
            fs2.Read(bits2, 0, (int)fs2.Length);

            /*MessageBox.Show($"{int.Parse("004578D", System.Globalization.NumberStyles.HexNumber)}");
            MessageBox.Show($"{BitConverter.ToString(BitConverter.GetBytes(bits1[284557])).Split('-')[0]}");*/
            
            var len = (int)fs1.Length;
            
            for (int ix = 0; ix < len; ix += 16)
            {
                var cnt = Math.Min(16, len - ix);
                var line1 = new byte[cnt];
                var line2 = new byte[cnt];

                Array.Copy(bits1, ix, line1, 0, cnt);
                Array.Copy(bits2, ix, line2, 0, cnt);

                for (int jx = 0; jx < cnt; jx++)
                {
                    


                    if (line1[jx] != line2[jx])
                    {
                        //Console.Write($"Address:{ix:X8} Pos:{jx}  {BitConverter.ToString(BitConverter.GetBytes(line1[jx])).Split('-')[0]} {BitConverter.ToString(BitConverter.GetBytes(line2[jx])).Split('-')[0]} | ");

                        Console.WriteLine($"{ix:X8}:  {BitConverter.ToString(BitConverter.GetBytes(line1[jx])).Split('-')[0]} {BitConverter.ToString(BitConverter.GetBytes(line2[jx])).Split('-')[0]}");
                        //{Convert.ToString(jx, 16).ToUpper()} 

                        //Console.Write(BitConverter.ToString(line1));
                    }
                }
                
                // Write address + hex + ascii
               
               

                // Convert non-ascii characters to .
                /*for (int jx = 0; jx < cnt; ++jx)
                    if (line[jx] < 0x20 || line[jx] > 0x7f) 
                        line[jx] = (byte)'.';
                Console.WriteLine(Encoding.ASCII.GetString(line));*/
            }


            return string.Empty;
        }

        private string GetFileName()
        {
            string fileName = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "c:\\";
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
            dataGridView1.Rows.Clear();
            resultListView.Clear();
            Compare(bas, mod);
            if (!baseFilePath.Equals(string.Empty) || !modFilePath.Equals(string.Empty))
            {
                binaryComparer = new BinaryComparer(baseFilePath, modFilePath);
                comparisionResult = binaryComparer.PerformComparision();
                PrintResults(comparisionResult);

                //binaryComparer.SaveComparisionResults(comparisionResult, Application.ExecutablePath);
            }
            else
                MessageBox.Show("Выберите файлы для сравнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void PrintResults(ComparisionResult comparisionResult)
        {
            switch(comparisionResult.comparisionResultType)
            {
                case ComparisionResultType.None:
                    break;
                case ComparisionResultType.Equal:
                    MessageBox.Show($"Файлы идентичны", "Результат",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case ComparisionResultType.DifferentSize:
                    MessageBox.Show($"Файлы различных размеров", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case ComparisionResultType.HaveDifferences:
                    for (int i = 0; i < comparisionResult.differences.Length; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = comparisionResult.differences[i].Address;
                        dataGridView1.Rows[i].Cells[1].Value = $"От {comparisionResult.differences[i].StartIndex:X} До {(comparisionResult.differences[i].StartIndex + comparisionResult.differences[i].Length - 1):X}";
                        dataGridView1.Rows[i].Cells[2].Value = comparisionResult.differences[i].originExample;
                        dataGridView1.Rows[i].Cells[3].Value = comparisionResult.differences[i].modificationExample;
                    }

                    /*ListViewGroup baseGroup = new ListViewGroup("0", $"#{0}");
                    resultListView.Groups.Add(baseGroup);
                    resultListView.Items.Add("Адрес");
                    resultListView.Items.Add($"Позиция");
                    resultListView.Items.Add("Исходная строка");
                    resultListView.Items.Add("Модифицированная строка");*/

                    /*for (int i = 0; i < comparisionResult.differences.Length; i++)
                    {
                        Console.WriteLine($"{comparisionResult.differences[i].Address}");
                        ListViewGroup group = new ListViewGroup((i+1).ToString(), $"#{i + 1}");
                        resultListView.Groups.Add(group);
                        //ADDRESS
                        resultListView.Items.Add(comparisionResult.differences[i].Address).Group = group;
                        //POSITION
                        resultListView.Items.Add($"На позиции от {comparisionResult.differences[i].StartIndex:X} до {(comparisionResult.differences[i].StartIndex + comparisionResult.differences[i].Length):X}").Group = group;
                        //EXAMPLES
                        resultListView.Items.Add(comparisionResult.differences[i].originExample).Group = group;
                        resultListView.Items.Add(comparisionResult.differences[i].modificationExample).Group = group;
                    }*/
                    break;
            }
            
            
        }
    }
}