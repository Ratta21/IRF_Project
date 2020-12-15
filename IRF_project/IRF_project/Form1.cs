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
        public Form1()
        {
            InitializeComponent();
            customers = GetCustomers(@"C:\Temp\Customers.csv");

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
                            Name = (line[0]),
                            Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                            Email = (line[2]),
                            Weight = int.Parse(line[3]),
                            HeightFeet = int.Parse(line[4]),
                            HeightInches = int.Parse(line[5]),
                            Lead_Source = (line[6]),

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
                    Name = item.Name,
                    Gender = item.Gender,
                    Email = item.Email,
                    Weight = WeightChange(item.Weight),
                    Height = HeightChange(item.HeightFeet, item.HeightInches),
                    Lead_Source = item.Lead_Source

                });

            }

            dataGridView1.DataSource = customerMetrics;

        }
    }
}
