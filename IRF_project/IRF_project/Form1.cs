using IRF_project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace IRF_project
{
    public partial class Form1 : Form
    {
        List<Customer> customers = new List<Customer>();
        List<CustomerMetric> customerMetrics = new List<CustomerMetric>();


        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        int countdown = 60;
        public Form1()
        {
            InitializeComponent();
            customers = GetCustomers(@"C:\Temp\Customers.csv");
            timer1.Interval = 5000;
            timer1.Start();
        }


        public List<Customer> GetCustomers(string csvpath)
        {

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    if (line[0] != "Name")

                    {
                        customers.Add(new Customer()
                        {
                            name = (line[0]),
                            gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                            email = (line[2]),
                            weight = int.Parse(line[3]),
                            heightFeet = int.Parse(line[4]),
                            heightInches = int.Parse(line[5]),
                            leadSource = (line[6]),

                        });
                    }
                }

                return customers;


            }
      
        }

        private void Import_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customers;

        }

        private int WeightChange(int weight) 
        {
            return Convert.ToInt16(Math.Round(weight / 2.5, 0, MidpointRounding.AwayFromZero));

        }

        private int HeightChange(int heightFeet, int heightInches)
        {
            return Convert.ToInt16(Math.Round(heightFeet * 30.48 + heightInches*2.54, 0, MidpointRounding.AwayFromZero));
        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            customerMetrics.Clear();
            foreach (var item in customers)
            {
                customerMetrics.Add(new CustomerMetric()
                {
                    name = item.name,
                    gender = item.gender,
                    email = item.email,
                    weight = WeightChange(item.weight),
                    height = HeightChange(item.heightFeet, item.heightInches),
                    leadSource = item.leadSource

                });

            }

            dataGridView1.DataSource = customerMetrics;

        }

        private void Generate_Excel_Click(object sender, EventArgs e)
        {
            try
            {
                xlApp = new Excel.Application();

                xlWB = xlApp.Workbooks.Add(Missing.Value);

                xlSheet = xlWB.ActiveSheet;

                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
        private void CreateTable()
        {


            string[] headers = new string[] {
                "Name",
                "Gender",
                "E-mail",
                "Weight",
                "Heigth",
                "Lead source"};

            for (int i = 0; i < headers.Length; i++)
            xlSheet.Cells[1, i+1] = headers[i];

            object[,] values = new object[customerMetrics.Count, headers.Length];

            int counter = 0;
            foreach (var item in customerMetrics)
            {
                values[counter, 0] = item.name;
                values[counter, 1] = item.gender;
                values[counter, 2] = item.email;
                values[counter, 3] = item.weight;
                values[counter, 4] = item.height;
                values[counter, 5] = item.leadSource;
                counter++;
            }
            xlSheet.get_Range(
             GetCell(2, 1),
             GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;


            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.Columns.AutoFit();
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            countdown = 60;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown-=5;
            if (countdown == 0) Application.Exit();
        }
    }

}
