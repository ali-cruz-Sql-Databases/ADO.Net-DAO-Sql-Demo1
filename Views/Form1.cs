using SqlConnectionClassTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlConnectionClassTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Consultas consulta = new Consultas();
            RespuestaDataTable response = new RespuestaDataTable();

            response = consulta.ConsultaPeople();


            dataGridView1.DataSource = consulta.ConsultaPeople().dt;
        }
    }
}
