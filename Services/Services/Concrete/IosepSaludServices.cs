using ApiIosep.Models.CtaCte;
using ApiIosep.Models.DTOs;
using ApiIosep.Repositorio.Interfaces;
using ApiIosep.Services.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ApiIosep.Services.Concrete
{
    public class IosepSaludServices : IIosepSaludServices
    {
        private IVencimientosPeriodosFacturacionRepository _vencimientosPeriodosFacturacionRepository;
        private IStoredProceduresIOSEPRepository _storedProceduresIOSEPRepository;
        private IConfiguration _configuration;

        public IosepSaludServices(IVencimientosPeriodosFacturacionRepository vencimientosPeriodosFacturacionRepository,IConfiguration configuration, IStoredProceduresIOSEPRepository storedProceduresIOSEPRepository)
        {
            _vencimientosPeriodosFacturacionRepository = vencimientosPeriodosFacturacionRepository;
            _configuration = configuration;
            _storedProceduresIOSEPRepository = storedProceduresIOSEPRepository;
        }



        public async Task<Response<string>> SetVencimientoFacturacion(string Periodo, string fecven1, string fecven2, string? obs1, string? obs2, string? obs3, string? lug1, string? lug2)
        {
            Response<string> resp = new Response<string>();
            try
            {

                Periodo = Periodo.Replace("-", "");
                var VPDList = await _vencimientosPeriodosFacturacionRepository.GetVencimientosPFByPeriodo(Periodo);

                obs1 ??= "";
                obs2 ??= "";
                obs3 ??= "";
                lug1 ??= "";
                lug2 ??= "";

                DateTime date1 = DateTime.Parse(fecven1);
                DateTime date2 = DateTime.Parse(fecven1);

                foreach (var item in VPDList)
                {

                    item.Vencimiento_1 = date1;
                    item.Vencimiento_2 = date2;
                    item.Renglon_1 = obs1;
                    item.Renglon_2 = obs2;
                    item.Renglon_3 = obs3;
                    item.Lugar_de_pago1 = lug1;
                    item.Lugar_de_pago2 = lug2;

                    await _vencimientosPeriodosFacturacionRepository.Update(item);

                }
                await _vencimientosPeriodosFacturacionRepository.Save();

                resp.Error = false;
                resp.Message = "OK";

            }
            catch (Exception ex)
            {
                resp.Error = true;
                resp.Message = ex.Message;
            }

            return resp;
        }


        public DataTable GetFacturacionGlobal(int IdEmpresa, string Periodo, string Tipo)
        {
            try
            {
             
                string sucu = "0001";

                Periodo = Periodo.Replace("-", "");
                DataTable dt = new DataTable();
                using (SqlConnection cx = new SqlConnection(_configuration.GetConnectionString("WebApiDB")))
                {
                    string proc = "";
                    if (Tipo == "Afiliados")
                        proc = "iosepsalud.Pa_CtaCteProcesofacturacionAfiliados";
                    else
                        proc = "iosepsalud.Pa_CtaCteProcesofacturacionEmpresas";

                    SqlCommand cmd = new SqlCommand(proc, cx);
                    if (Tipo == "Afiliados")
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.NChar, 6)).Value = Periodo;
                        cmd.Parameters.Add(new SqlParameter("@SucursalUser", SqlDbType.NChar, 4)).Value = sucu;
                    }
                    else
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.Int)).Value = IdEmpresa;
                        cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.NChar, 6)).Value = Periodo;
                        cmd.Parameters.Add(new SqlParameter("@SucursalUser", SqlDbType.NChar, 4)).Value = sucu;

                    }

                    //cmd.Parameters.Add(new SqlParameter("@Operador", SqlDbType.NChar, 11)).Value = User.Identity.Name;

                    cmd.CommandTimeout = 0;
                    cx.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                        dt.TableName = "rows";
                    }
                    else
                        dt = null;
                    reader.Close();
                }
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dtError = new DataTable("Error");
                dtError.Columns.Add("Error");
                DataRow dr = dtError.NewRow();
                dr["Error"] = ex.Message;
                dtError.Rows.Add(dr);
                return dtError;
            }
        }


        //En progreso :D
        public DataTable GetSaldodeAfiliadoxPeriodoSinAfectar(int global, string parametro, string Tipo)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection cx = new SqlConnection(_configuration.GetConnectionString("WebApiDB")))
                {
                    string comand = "";
                    if (Tipo == "Afiliados")
                    {
                        if (global == 1)
                            comand = "Pa_CtaCte_ReimpresionGlobal";
                        else
                        {
                            comand = "pa_CtaCte_Reimpresion_Factura";
                            parametro = parametro.Replace("-", "").Replace("-", "");
                        }
                    }
                    else
                    {
                        if (global == 1)
                            comand = "Pa_CtaCte_ReimpresionGlobalEmpresas";
                        else
                        {
                            comand = "pa_CtaCte_Reimpresion_Empresas";
                            parametro = parametro.Replace("-", "").Replace("-", "");
                        }
                    }
                    SqlCommand cmd = new SqlCommand(comand, cx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (global == 1)
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Facturacion", SqlDbType.Date)).Value = DateTime.Now;
                    //cmd.Parameters.Add(new SqlParameter("@Fecha_Facturacion", SqlDbType.Date)).Value = Convert.ToDateTime("10/11/2020");
                    else
                        cmd.Parameters.Add(new SqlParameter("@CodBarra", SqlDbType.VarChar, 50)).Value = parametro;
                    cmd.CommandTimeout = 800;
                    cx.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                        dt.TableName = "rows";
                    }
                    else
                        dt = null;
                    reader.Close();
                }
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> VerificarVencimientosFacturacion(string Periodo)
        {
            try
            {
                //Periodo = Periodo.Replace("-", "");
                 await _storedProceduresIOSEPRepository.VerificarYActualizarVencimientos(Periodo);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string PrintGlobalRecibos(int Id, string P, string? O1, string? O2, string? O3, string? L1, string? L2, string F1, string F2, string Tipo, byte afecta,string user)
        {

            if (user != "20443143549" && user != "20395250427" && user != "20273907646" && user != "27248276792" && user != "20417764888")
                return "Usuario no valido";

            O1 ??= "";
            O2 ??= "";
            O3 ??= "";
            L1 ??= "";
            L2 ??= "";
            F1 ??= "";
            F2 ??= "";
            DataTable dt;
            if (afecta == 1)
                dt = GetFacturacionGlobal(Id, P, Tipo);
            else
                dt = GetSaldodeAfiliadoxPeriodoSinAfectar(1, "", Tipo);

            if (dt != null)
            {
                if (dt.TableName.ToLower() == "error")
                    return "<h3><span style='color: red'>" + dt.Rows[0][0].ToString() + "</span></h3>";

                dt.Columns.Add("Obs1");
                dt.Columns.Add("Obs2");
                dt.Columns.Add("Obs3");
                dt.Columns.Add("Lugar1");
                dt.Columns.Add("Lugar2");
                dt.Columns.Add("FecVen1");
                dt.Columns.Add("FecVen2");
                dt.Columns.Add("BarCode");

                CodBar2To5 conv2to5 = new CodBar2To5();

                foreach (DataRow dr in dt.Rows)
                {
                    dr.BeginEdit();
                    dr["Obs1"] = O1;
                    dr["Obs2"] = O2;
                    dr["Obs3"] = O3;
                    dr["Lugar1"] = L1;
                    dr["Lugar2"] = L2;
                    dr["FecVen1"] = F1;
                    dr["FecVen2"] = F2;
                    dr["BarCode"] = dr["BarCode"].ToString().Trim();
                    dr["BarCode"] = conv2to5.codbar2to5(dr["BarCode"].ToString().Trim());
                    dr.EndEdit();
                }

            }

            return "OK";    

        }

    }


}

