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

namespace IRF_project
{
    public partial class Form1 : Form
    {
        List<Customers> Customers = new List<Customers>();

        public Form1()
        {
            InitializeComponent();
            Customers = GetCustomers(@"C:\Temp\Customers.csv");

        }


        public List<Customers> GetCustomers(string csvpath)
        {

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    Customers.Add(new Customers()
                    {
                        Name = (line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        Email = (line[2]),
                        Weight = int.Parse(line[3]),
                        Height = float.Parse(line[4]),
                        Lead_Source = (line[5]),

                        //Ide még jönnének cuccok
                    });
                }
            }

            return Customers;


        }
        private void Import_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Customers;
        }
    }
}
