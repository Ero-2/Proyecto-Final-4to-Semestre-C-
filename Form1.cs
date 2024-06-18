using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_RIOJAS
{
    public partial class Form1 : Form
    {

        private DataBaseHandler databaseHandler;
        private JsonHandler<YourDataClass> jsonHandler;
        private XmlHandler<YourDataClass> xmlHandler;
        private CsvHandler<YourDataClass> csvHandler;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "server=(localdb)\\ErickGarcia; database=Erick; integrated security=true";
            databaseHandler = new DataBaseHandler(connectionString);
            jsonHandler = new JsonHandler<YourDataClass>();
            xmlHandler = new XmlHandler<YourDataClass>();
            csvHandler = new CsvHandler<YourDataClass>();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            var data = databaseHandler.GetAllData();
            dataGridView1.DataSource = data;
        }

        private void SaveJsonButton_Click(object sender, EventArgs e)
        {
            var data = (List<YourDataClass>)dataGridView1.DataSource;
            jsonHandler.Save("data.json", data);
        }

        private void LoadJsonButton_Click(object sender, EventArgs e)
        {
            var data = jsonHandler.Load("data.json");
            dataGridView1.DataSource = data;
        }

        private void SaveXmlButton_Click(object sender, EventArgs e)
        {
            var data = (List<YourDataClass>)dataGridView1.DataSource;
            xmlHandler.Save("data.xml", data);
        }

        private void LoadXmlButton_Click(object sender, EventArgs e)
        {
            var data = xmlHandler.Load("data.xml");
            dataGridView1.DataSource = data;
        }

        private void SaveCsvButton_Click(object sender, EventArgs e)
        {
            var data = (List<YourDataClass>)dataGridView1.DataSource;
            csvHandler.Save("data.csv", data);
        }

        private void LoadCsvButton_Click(object sender, EventArgs e)
        {
            var data = csvHandler.Load("data.csv");
            dataGridView1.DataSource = data;

        }
    }
}
