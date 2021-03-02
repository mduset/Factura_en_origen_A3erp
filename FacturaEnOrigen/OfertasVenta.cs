using FacturaEnOrigen.DAO;
using FacturaEnOrigen.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacturaEnOrigen
{
    public partial class OfertasVenta : Form
    {
        private CapceleraComandaVentaDTO capcelera;
        public OfertasVenta()
        {
            InitializeComponent();
            capcelera = new CapceleraComandaVentaDTO();
            if (Constants.isDebug)
            {
                debug_label.Visible = true;
            }
            if (!Constants.isPRO)
            {
                entorn_label.Visible = true;
            }
        }

        private Boolean EsCampInformat(string camp)
        {
            return (camp != null && camp != "");
        }

        private void NetejarDates()
        {
            this.capcelera.DataInici = null;
            this.capcelera.DataFi = null;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            llistatComandesVentaGrid.Rows.Clear();
            if (EsCampInformat(this.cliente.Text)) { capcelera.CodiClient = this.cliente.Text; } else { capcelera.CodiClient = ""; }
            if (EsCampInformat(this.text.Text)) { capcelera.NomClient = this.text.Text; } else { capcelera.NomClient = ""; }
            if (EsCampInformat(this.numero.Text)) { capcelera.NumDoc = Decimal.Parse(this.numero.Text); } else { capcelera.NumDoc = 0; }
            if (EsCampInformat(this.referencia.Text)) { capcelera.Referencia = this.referencia.Text; } else { capcelera.Referencia = null; }
            //if (this.hoy.Checked) { capcelera.DataInici = null; capcelera.DataFi = null; }

            CapceleraComandaVentaDAO capceleraComandaVentaDAO = new CapceleraComandaVentaDAO();
            List<CapceleraComandaVentaDTO> comandesVenta = capceleraComandaVentaDAO.ObtenirComandesVenta(capcelera);

            if (comandesVenta != null && comandesVenta.Count > 0)
            {
                Boolean primer = true;
                foreach (CapceleraComandaVentaDTO capceleraComandaVentaDTO in comandesVenta)
                {
                    if (primer)
                    {
                        ArrayList Capcelera = capceleraComandaVentaDTO.ObtenirCapceleraValorsGrid();
                        if (Capcelera != null && Capcelera.Count > 0)
                        {
                            llistatComandesVentaGrid.ColumnCount = Capcelera.Count;
                            int i = 0;
                            foreach (String columna in Capcelera)
                            {
                                llistatComandesVentaGrid.Columns[i++].Name = columna;
                            }
                        }
                        primer = false;
                    }
                    llistatComandesVentaGrid.Rows.Add(capceleraComandaVentaDTO.ObtenirValorsGrid().ToArray());
                }

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn
                {
                    HeaderText = "Detalle",
                    Name = "DET",
                    Text = "Detalle",
                    UseColumnTextForButtonValue = true
                };
                llistatComandesVentaGrid.Columns.Add(btn);
            }
        }

        private void hoy_CheckedChanged_1(object sender, EventArgs e)
        {
            if (hoy.Checked)
            {
                ultima_semana.Checked = false;
                ultimo_mes.Checked = false;
                ultimo_año.Checked = false;
                this.capcelera.DataInici = DateTime.Today;
                this.capcelera.DataFi = DateTime.Today;
            }
            else
            {
                NetejarDates();
            }
        }

        private void ultima_semana_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ultima_semana.Checked)
            {
                hoy.Checked = false;
                ultimo_mes.Checked = false;
                ultimo_año.Checked = false;
                this.capcelera.DataFi = DateTime.Today;
                this.capcelera.DataInici = DateTime.Today.AddDays(-7);
            }
            else
            {
                NetejarDates();
            }
        }

        private void ultimo_mes_CheckedChanged(object sender, EventArgs e)
        {
            if (ultimo_mes.Checked)
            {
                hoy.Checked = false;
                ultima_semana.Checked = false;
                ultimo_año.Checked = false;
                this.capcelera.DataFi = DateTime.Today;
                this.capcelera.DataInici = DateTime.Today.AddMonths(-1);
            }
            else
            {
                NetejarDates();
            }
        }

        private void ultimo_año_CheckedChanged(object sender, EventArgs e)
        {
            if (ultimo_año.Checked)
            {
                hoy.Checked = false;
                ultima_semana.Checked = false;
                ultimo_mes.Checked = false;
                if (this.capcelera.DataFi == null)
                {
                    this.capcelera.DataFi = new DateTime();
                    this.capcelera.DataInici = new DateTime();
                }
                this.capcelera.DataFi = DateTime.Today;
                this.capcelera.DataInici = DateTime.Today.AddYears(-1);
            }
            else
            {
                NetejarDates();
            }
        }

        private void llistatComandesVentaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow d = llistatComandesVentaGrid.CurrentCell.OwningRow;
            if (d.Cells[4].Value != null)
            {
                FacturaOrigen facturaOrigen = new FacturaOrigen(d.Cells[4].Value.ToString());
                facturaOrigen.Show();
            }
        }
    }
}
