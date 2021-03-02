using System;
using System.Data;
using System.Windows.Forms;

namespace FacturaEnOrigen
{
    public partial class FacturaOrigen : Form
    {
        private string IdComandaVenta;
        public FacturaOrigen(string idComandaVenta)
        {
            InitializeComponent();
            IdComandaVenta = idComandaVenta;

            dataGridView1.Rows.Clear();

            DataTable dt = new DataTable();

            DataColumn UnitatDC = new DataColumn("unidad")
            {
                Caption = "Ud"
            };

            DataColumn DescripcioLiniaDC = new DataColumn("DescripcioLinia")
            {
                Caption = "Descripción"
            };

            DataColumn PreuDC = new DataColumn("Text")
            {
                Caption = "Precio"
            };

            DataColumn OrigenDC = new DataColumn("Unitats")
            {
                Caption = "Origen"
            };

            DataColumn AnteriorDC = new DataColumn("Anterior")
            {
                Caption = "Anterior"
            };
            DataColumn MesDC = new DataColumn("Mes")
            {
                Caption = "Mes"
            };

            dt.Columns.Add(UnitatDC);
            dt.Columns.Add(DescripcioLiniaDC);
            dt.Columns.Add(PreuDC);
            dt.Columns.Add(OrigenDC);
            dt.Columns.Add(AnteriorDC);
            dt.Columns.Add(MesDC);

            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderText = dt.Columns[col.HeaderText].Caption;
            }
        }
    }
}
