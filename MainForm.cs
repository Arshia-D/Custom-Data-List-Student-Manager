using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CustomDataList
{
    public partial class MainForm : Form
    {
        protected string AppPathSTR = @"C:\Users\" + Environment.UserName + @"\Documents\Custom Data List\";
        protected string AppFileSTR = @"saved data.txt";

        DataTable dataTable = new DataTable();

        public MainForm()
        {
            InitializeComponent();

            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Number", typeof(string));
            dataTable.Columns.Add("Score", typeof(string));

            LIST_Students.DataSource = dataTable;            

            TXT_Load.Text = Path.Combine(AppPathSTR, AppFileSTR);

            if (!File.Exists(Path.Combine(AppPathSTR, AppFileSTR)))
            {
                var FSN = new FileStream(Path.Combine(AppPathSTR, AppFileSTR), FileMode.Create);
                FSN.Close();
            }
        }

        private void BTN_Load_Click(object sender, EventArgs e)
        {
            TryClearList();
            try
            {
                var lines = File.ReadAllLines(Path.Combine(AppPathSTR, AppFileSTR));
                foreach (var line in lines)
                {
                    var fields = line.Split('|');
                    if (fields.Length == 4)
                    {
                        var firstName = fields[0];
                        var lastName = fields[1];
                        var studentNumber = fields[2];
                        if (!float.TryParse(fields[3], out float averageScore))
                        {
                            Console.WriteLine(
                                $"Invalid averageScore for student '{firstName}': '{fields[3]}'. Skipping...");
                            continue;
                        }

                        dataTable.Rows.Add(firstName, lastName, studentNumber, averageScore);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid data format: '{line}'. Skipping...");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{AppFileSTR}' not found.");
            }
            catch (IOException error)
            {
                Console.WriteLine($"Error reading file '{AppFileSTR}': {error.Message}");
            }
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if (TXT_Name.Text.Equals("") || TXT_Last.Text.Equals("") || TXT_Num.Text.Equals("") || TXT_Score.Text.Equals(""))
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                dataTable.Rows.Add(TXT_Name.Text, TXT_Last.Text, TXT_Num.Text, TXT_Score.Text);

                TXT_Name.Text = "";
                TXT_Last.Text = "";
                TXT_Num.Text = "";
                TXT_Score.Text = "";
            }
        }

        private void BTN_RemIndex_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_Index.Text != "0")
                {
                    TryRemoveIndex(int.Parse(TXT_Index.Text) - 1);
                }
                else
                {
                    MessageBox.Show("Please provide a valid number.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please provide a valid number.");
            }
        }

        private void BTN_RemFirst_Click(object sender, EventArgs e)
        {
            TryRemoveIndex(0);
        }

        private void BTN_RemLast_Click(object sender, EventArgs e)
        {
            int listNum = dataTable.Rows.Count;
            TryRemoveIndex(listNum - 1);
        }

        private void TryRemoveIndex(int inIndex)
        {
            try
            {
                if (LIST_Students.Rows.Count >= inIndex)
                {
                    DataView dataView = dataTable.DefaultView;
                    DataTable NewTable = dataView.ToTable();
                    dataTable = NewTable;
                    LIST_Students.DataSource = dataTable;

                    dataTable.Rows.RemoveAt(inIndex);
                
                }
                else
                {
                    MessageBox.Show("Please provide a valid number.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurred!");
            }
        }

        private void TryClearList()
        {
            if (LIST_Students.Rows.Count != 0)
            {
                dataTable.Clear();
            }
        }

        private void BTN_Clear_Data_Grid_Click(object sender, EventArgs e)
        {
            TryClearList();
        }

        private void BTN_Clear_File_Click(object sender, EventArgs e)
        {
            ClearDataFile();
            MessageBox.Show("Cleared!");
        }

        private void ClearDataFile()
        {
            try
            {
                File.WriteAllText(Path.Combine(AppPathSTR, AppFileSTR), string.Empty);
                Console.WriteLine($"File '{AppFileSTR}' cleared.");
            }
            catch (IOException error)
            {
                Console.WriteLine($"Error clearing file '{AppFileSTR}': {error.Message}");
            }
        }

        private void SortDataGridView(string propertyName, string direction)
        {
            DataView dv = dataTable.DefaultView;
            dv.Sort = propertyName + " " + direction;
            DataTable sortedDT = dv.ToTable();
            dataTable = sortedDT;
            LIST_Students.DataSource = dataTable;
        }

        private void BTN_Sort_Click(object sender, EventArgs e)
        {
            switch (COMBO_Items.SelectedItem.ToString())
            {
                case "First Name":
                    {
                        if (COMBO_Direction.SelectedItem.ToString().Equals("Ascending"))
                        {
                            SortDataGridView("FirstName", "asc");
                        }
                        else
                        {
                            SortDataGridView("FirstName", "desc");
                        }
                        break;
                    }
                case "Last Name":
                    {
                        if (COMBO_Direction.SelectedItem.ToString().Equals("Ascending"))
                        {
                            SortDataGridView("LastName", "asc");
                        }
                        else
                        {
                            SortDataGridView("LastName", "desc");
                        }
                        break;
                    }
                case "Number":
                    {
                        if (COMBO_Direction.SelectedItem.ToString().Equals("Ascending"))
                        {
                            SortDataGridView("Number", "asc");
                        }
                        else
                        {
                            SortDataGridView("Number", "desc");
                        }
                        break;
                    }
                case "Score":
                    {
                        if (COMBO_Direction.SelectedItem.ToString().Equals("Ascending"))
                        {
                            SortDataGridView("Score", "asc");
                        }
                        else
                        {
                            SortDataGridView("Score", "desc");
                        }
                        break;
                    }
            }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            ClearDataFile();
            DataView baseView = dataTable.DefaultView;
            int Rows = baseView.Table.Rows.Count;
            for (int i = 0; i < Rows; i++)
            {
                using (StreamWriter sr = new StreamWriter(Path.Combine(AppPathSTR, AppFileSTR), true))
                    sr.WriteLine(baseView.Table.Rows[i][0] + "|" + baseView.Table.Rows[i][1] + "|" + baseView.Table.Rows[i][2] + "|" + baseView.Table.Rows[i][3]);
            }
        }
    }
}
