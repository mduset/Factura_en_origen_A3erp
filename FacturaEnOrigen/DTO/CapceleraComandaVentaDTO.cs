using System;
using System.Collections;

namespace FacturaEnOrigen.DTO
{
    class CapceleraComandaVentaDTO
    {
        public string CodiClient { get; set; }
        public string NifClient { get; set; }
        public string NomClient { get; set; }
        public string Observacions { get; set; }
        public Decimal CostBrut { get; set; }
        public Decimal IdComandaVenta { get; set; }
        public DateTime Data { get; set; }
        public string Referencia { get; set; }
        public Decimal NumDoc { get; set; }

        // Metodes per filtrar
        public DateTime? DataInici { get; set; } = null;
        public DateTime? DataFi { get; set; } = null;

        public ArrayList ObtenirCapceleraValorsGrid()
        {
            ArrayList row = new ArrayList();
            row.Add("Fecha");
            row.Add("Número documento");
            row.Add("Referencia");
            row.Add("Nombre cliente");
            row.Add("ID pedido");

            return row;
        }
        public ArrayList ObtenirValorsGrid()
        {
            ArrayList row = new ArrayList();
            row.Add(Data.ToString("dd/MM/yyyy"));
            row.Add(NumDoc);
            row.Add(Referencia);
            row.Add(NomClient);
            row.Add(IdComandaVenta);

            return row;
        }
    }
}
