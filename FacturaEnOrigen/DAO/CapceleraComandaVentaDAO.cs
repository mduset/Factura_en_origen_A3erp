using FacturaEnOrigen.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace FacturaEnOrigen.DAO
{
    class CapceleraComandaVentaDAO
    {
        public List<CapceleraComandaVentaDTO> ObtenirComandesVenta(CapceleraComandaVentaDTO capceleraComandaVentaDTO)
        {
            List<CapceleraComandaVentaDTO> comandesVenta = new List<CapceleraComandaVentaDTO>();

            StringBuilder sql = new StringBuilder();
            sql.Append("select codcli, nifcli, nomcli, observaciones, totmoneda, idpedv, fecha, referencia, numdoc ");
            sql.Append("from cabepedv cpv ");
            sql.Append("where cpv.situaciondetalle not in ('SERVIDO, TOTALMENTE SERVIDO', 'SERVIDO CON ANULACIONES') ");
            sql.Append("and exists (select * from linepedi where idpedv = cpv.IDPEDV and esacabado = 'T' and eskit = 'F') "); // comandes de venta que tenen alguna línia amb producte acabat
            //sql.Append("and exists (select * from linepedi where idpedv = cpv.IDPEDV and esacabado = 'T') "); // comandes de venta que tenen alguna línia amb producte acabat

            if (capceleraComandaVentaDTO.IdComandaVenta != 0)
            {
                sql.Append("and idpedv = @idpedv ");
            }
            if (capceleraComandaVentaDTO.CodiClient != null && capceleraComandaVentaDTO.CodiClient != "")
            {
                sql.Append("and trim(codcli) = trim(@codcli) ");
            }
            if (capceleraComandaVentaDTO.NomClient != null && capceleraComandaVentaDTO.NomClient != "")
            {
                sql.Append("and LOWER(nomcli) like LOWER(@nomcli) ");
            }
            if (capceleraComandaVentaDTO.NumDoc != 0)
            {
                sql.Append("and numdoc = @numDoc ");
            }
            if (capceleraComandaVentaDTO.Referencia != null)
            {
                sql.Append("and referencia = @referencia ");
            }
            if (capceleraComandaVentaDTO.DataInici != null)
            {
                sql.Append("and fecha >= CONVERT(datetime, @dataInici, 111)  ");
            }
            if (capceleraComandaVentaDTO.DataFi != null)
            {
                sql.Append("and fecha <= CONVERT(datetime, @dataFi, 111)  ");
            }

            string connectionString = Constants.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql.ToString(), connection);
                if (capceleraComandaVentaDTO.IdComandaVenta != 0)
                {
                    command.Parameters.AddWithValue("@idpedv", capceleraComandaVentaDTO.IdComandaVenta);
                }
                if (capceleraComandaVentaDTO.CodiClient != null && capceleraComandaVentaDTO.CodiClient != "")
                {
                    command.Parameters.AddWithValue("@codcli", capceleraComandaVentaDTO.CodiClient);
                }
                if (capceleraComandaVentaDTO.NomClient != null && capceleraComandaVentaDTO.NomClient != "")
                {
                    command.Parameters.AddWithValue("@nomcli", "%" + capceleraComandaVentaDTO.NomClient + "%");
                }
                if (capceleraComandaVentaDTO.NumDoc != 0)
                {
                    command.Parameters.AddWithValue("@numDoc", capceleraComandaVentaDTO.NumDoc);
                }
                if (capceleraComandaVentaDTO.Referencia != null)
                {
                    command.Parameters.AddWithValue("@referencia", capceleraComandaVentaDTO.Referencia);
                }
                if (capceleraComandaVentaDTO.DataInici != null)
                {
                    command.Parameters.AddWithValue("@dataInici", capceleraComandaVentaDTO.DataInici);
                }
                if (capceleraComandaVentaDTO.DataFi != null)
                {
                    command.Parameters.AddWithValue("@dataFi", capceleraComandaVentaDTO.DataFi);
                }
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    CapceleraComandaVentaDTO capceleraCVDTO = null;
                    while (reader.Read())
                    {
                        capceleraCVDTO = new CapceleraComandaVentaDTO
                        {
                            CodiClient = reader.GetString(0),
                            NifClient = reader.GetString(1),
                            NomClient = reader.GetString(2),
                            IdComandaVenta = reader.GetDecimal(5)
                        };

                        if (!reader.IsDBNull(3))
                        {
                            capceleraCVDTO.Observacions = reader.GetString(3);
                        }
                        if (!reader.IsDBNull(4))
                        {
                            capceleraCVDTO.CostBrut = reader.GetDecimal(4);
                        }
                        if (!reader.IsDBNull(6))
                        {
                            capceleraCVDTO.Data = reader.GetDateTime(6);
                        }
                        if (!reader.IsDBNull(7))
                        {
                            capceleraCVDTO.Referencia = reader.GetString(7);
                        }
                        if (!reader.IsDBNull(8))
                        {
                            capceleraCVDTO.NumDoc = reader.GetDecimal(8);
                        }
                        comandesVenta.Add(capceleraCVDTO);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("CapceleraComandaVentaDAO.ObtenirComandesVenta: " + ex.Message);
                }
            }
            return comandesVenta;
        }
    }
}
