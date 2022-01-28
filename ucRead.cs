using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataFeatures
{
    public partial class ucRead : UserControl
    {
        public ucRead()
        {
            InitializeComponent();
        }

        private void ucRead_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Select CSV file|*.csv"; // open a file dialogue from the computer
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = dialog.FileName;
                    string filePath = txtFilePath.Text;// cos stream reader can't understand filename  but FileDialog cant understant FilePath as well
                    StreamReader streamReader = new StreamReader(filePath);// Check to see whether you are using system.IO
                    string[] AllData = new string[File.ReadAllLines(filePath).Length];// AllData reads all the lines in the file
                    int line = 0;
                    while (!streamReader.EndOfStream)
                    {
                        AllData = streamReader.ReadLine().Split(',');
                        if (line < 1)
                            foreach (string col in AllData)
                            {
                                dgvDisplay.Columns.Add(col, col);
                                line++;
                            }
                        else
                        {
                            dgvDisplay.Rows.Add(AllData);
                        }
                    }
                    if (System.IO.File.Exists(txtFilePath.Text))
                    {
                        for (int i = 1; i < dgvDisplay.Columns.Count; i++)
                        {
                            string tagName = dgvDisplay.Columns[i].HeaderText;

                            List<double> values = new List<double>(dgvDisplay.Rows.Count - 1);

                            for (int j = 0; j < dgvDisplay.Rows.Count - 1; j++)
                            {
                                double doubleParseResult = 0;

                                if (double.TryParse(dgvDisplay.Rows[j].Cells[i].Value.ToString(), out doubleParseResult))
                                {
                                    values.Add(doubleParseResult);
                                }
                            }
                        }
                    }
                    streamReader.Dispose();
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show(ioEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
