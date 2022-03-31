using System;
using System.Data;
using System.Windows.Forms;

namespace Exportar_Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

        private void btnExportar_Click(object sender, EventArgs e)
        {

            if (dgvDados.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dgvDados.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvDados.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvDados.Rows.Count-1; i++)
                    {
                        for (int j = 0; j < dgvDados.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvDados.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;

                    //Excel.Worksheet newWorksheet;
                    //newWorksheet = (Excel.Worksheet)this.Application.Worksheets.Add();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }
        //
        private void carregaGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Codigo", typeof(int));
                dt.Columns.Add("UF", typeof(string));
                dt.Columns.Add("Municipio", typeof(string));
                dt.Columns.Add("Rua", typeof(string));
                dt.Columns.Add("CEP", typeof(string));

                DataRow dr = dt.NewRow();

                dr["Codigo"] = 1;
                dr["UF"] = "ES";
                dr["Municipio"] = "Vitória";
                dr["Rua"] = "Alvorada";
                dr["CEP"] = "09547-070";

                dt.Rows.Add(dr);
                dr = dt.NewRow();

                dr["Codigo"] = 2;
                dr["UF"] = "BA";
                dr["Municipio"] = "Salvador";
                dr["Rua"] = "Projetada";
                dr["CEP"] = "02468-030";

                dt.Rows.Add(dr);
                dr = dt.NewRow();

                dr["Codigo"] = 3;
                dr["UF"] = "MG";
                dr["Municipio"] = "Recreio";
                dr["Rua"] = "Engenho";
                dr["CEP"] = "07164-050";

                dt.Rows.Add(dr);
                dgvDados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            XcelApp.Quit();
            this.Close();
        }
    }
}
