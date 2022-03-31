using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CorreiosWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string cep = txt.Text;
            CorreiosWS.objeto obj = new CorreiosWS.objeto();
            var resultado = obj.numero;
            TextReader reader = new StringReader(resultado.ToString());

            DataSet ds = new DataSet();

            ds.ReadXml(reader);

            dataGrid.DataSource = ds.Tables[2];
        }
    }
}
