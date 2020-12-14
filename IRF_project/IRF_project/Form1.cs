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
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfChildren = int.Parse(line[2])
                    });
                }
            }

            return Customers;


        }
        private void Import_Click(object sender, EventArgs e)
        {
        }
    }
}
