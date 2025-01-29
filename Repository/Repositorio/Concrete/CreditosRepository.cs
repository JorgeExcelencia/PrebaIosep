using ApiIosep.Models.CtaCte.MovDet;
using ApiIosep.Models.IOSEP;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models.Models.Creditos;
using Models.Models.DTOs;
using Models.Models.DTOs.CreditosDTO;
using Repository.Repositorio.Interfaces;
using System.Runtime.CompilerServices;

namespace Repository.Repositorio.Concrete
{
    public class CreditosRepository : ICreditosRepository
    {
        public IOSEPContext _context;
        public CreditosRepository(IOSEPContext context)
        {
            _context = context;
        }
        public async Task<CreditosLotes?> GetCreditosLotesByID(int id)
        {
            return await _context.CreditosLotes.Where(x => x.IdLote == id).FirstOrDefaultAsync();
        }
        public async Task<List<CreditosCredito>> GetCreditosPorPeriodo(DateTime fecha, int idConcepto)
        {
            var inicioMes = new DateTime(fecha.Year, fecha.Month, 1);
            var finMes = inicioMes.AddMonths(1).AddDays(-1);
            return await _context.CreditosCredito.Where(x =>  x.CodigoCredito == idConcepto.ToString()
            && x.FechaCrea >= inicioMes &&
            x.FechaCrea <= finMes && !x.Anulado).OrderByDescending(x => x.FechaCrea).ToListAsync();
        }
        public async Task<List<CreditosCredito>> GetAllCreditos()
        {
            return await _context.CreditosCredito.ToListAsync();
        }
        public async Task<List<CreditosConcCred>> GetConceptoCredito()
        {
            return await _context.CreditosConcCred.Where(x => x.Fecha_baja == null && (x.IdConcCred == 630 || x.IdConcCred == 631 || x.IdConcCred == 638)).ToListAsync();
        }
        public async Task<CreditosSalarioAfiliado?> GetIngresoFamiliarById(int idAfiliado)
        {
            return await _context.CreditosSalarioAfiliado.Where(x => x.IdAfiliado == idAfiliado && !x.Anulado).FirstOrDefaultAsync();
        }
        public async Task<CreditosSalarioAfiliado?> GetIngresoFamiliarByIdSalario(int idSalario)
        {
            return await _context.CreditosSalarioAfiliado.Where(x => x.IdSalario == idSalario && !x.Anulado).FirstOrDefaultAsync();
        }
        public async Task<CreditosSalarioAfiliado?> GetIngresoFamiliarByIdAfiliado(int idafiliado)
        {
            return await _context.CreditosSalarioAfiliado.Where(x => x.IdAfiliado == idafiliado && !x.Anulado).OrderByDescending(x => x.IdSalario).FirstOrDefaultAsync();
        }
        public void ActualizarSalarioAfiliado(CreditosSalarioAfiliado salario, decimal monto, DateTime Hasta)
        {
            salario.Monto = monto;
            salario.Hasta = Hasta == new DateTime(1900, 01, 01) ? salario.Hasta : Hasta;
            _context.SaveChanges();
        }
        public void AnularSalarioAfiliado(CreditosSalarioAfiliado salario)
        {
            salario.Anulado = true;
            salario.FechaAnula = DateTime.Now;
            _context.SaveChanges();
        }

        public async Task<List<CreditosDetalle>> GetDetalleCreditoById(int idCredito)
        {
            return await _context.CreditosDetalle.Where(x => x.IdCredito == idCredito && !x.Anulado).ToListAsync();
        }
        public async Task<CreditosDetalle?> GetDetalleCreditoByIdYNumCuota(int idCredito, string numCuota)
        {
            return await _context.CreditosDetalle.FirstOrDefaultAsync(s =>
                    s.IdCredito == idCredito
                    && s.NroCredito.Trim() == numCuota.Trim() && s.Saldo == 0); 
        }
        public async Task<List<CreditosDetalle>> GetDetalleCreditoByIdDetalle(int idDetalleCredito)
        {
            return await _context.CreditosDetalle.Where(x => x.IdDetalleCredito == idDetalleCredito && !x.Anulado).ToListAsync();
        }
        public async Task<CreditosCredito> GetCreditoByIdCredito(int idCredito)
        {
            return await _context.CreditosCredito.Where(x => x.IdCredito == idCredito && !x.Anulado).FirstOrDefaultAsync();
        }
        public async Task<CreditosCredito> GetCreditoByNroCreditoMigracion(string NroCredito, int idafiliado)
        {
            return await _context.CreditosCredito.Where(x => x.NroCreditoMigracion == NroCredito && !x.Anulado && x.IdAfiliado == idafiliado).FirstOrDefaultAsync();
        }
        public async Task<bool> ExisteCreditoByIdAfiliado(int idafiliado)
        {
            return await _context.CreditosCredito.Where(x => x.IdAfiliado == idafiliado && !x.Anulado).AnyAsync();
        }
        public async Task<List<CreditosCredito>> GetCreditoByConceptoCodigo(string codigo)
        {
            return await _context.CreditosCredito.Where(x => x.CodigoCredito == codigo && !x.Anulado).ToListAsync();
        }

        public async Task<List<CreditoOrden>> GetCreditosYDetalleCreditos(int idAfiliado)
        {
            var creditos = await (from cc in _context.CreditosCredito
                                  join cd in _context.CreditosDetalle
                                  on cc.IdCredito equals cd.IdCredito
                                  where cc.IdAfiliado == idAfiliado && !cc.Anulado && cd.Saldo == 0
                                  group new { cc, cd } by new { cc.IdCredito, cc.Denomina, cc.CodigoCredito, cc.Cuotas, cc.ImporteTotal, cc.FechaCrea, cd.Saldo } into g
                                  select new CreditoOrden
                                  {
                                      FechaCrea = g.Key.FechaCrea,
                                      IdCredito = g.Key.IdCredito,
                                      Denomina = g.Key.Denomina + " " + g.Key.CodigoCredito,
                                      NumCuota = g.Min(x => x.cd.NroCredito) + "/" + g.Key.Cuotas,
                                      ImporteTotal = g.Key.ImporteTotal,
                                      Pagado = g.Key.Saldo
                                  }).ToListAsync();

            // Obtener las órdenes y mapearlas al modelo común
            var ordenes = await _context.Ordenes
                .Where(x => x.IdAfiliado == idAfiliado && !x.Anulada)
                .Select(x => new CreditoOrden
                {
                    FechaCrea = x.Fecha_Emision,
                    IdCredito = x.IdOrden,
                    Denomina = x.TipoOrden + " - " + x.Numero,
                    NumCuota = "1/1", // Puedes ajustar según la lógica necesaria
                    ImporteTotal = x.Importe,
                    Pagado = x.Importe
                }).ToListAsync();

            // Combinar ambas listas y ordenarlas por FechaCrea
            var resultado = creditos
                .Concat(ordenes)
                .OrderByDescending(c => c.FechaCrea)
                .ToList();

            return resultado;
        }



        public async Task CancelarCreditoPago(int idCredito)
        {
            // Busca el crédito que coincida con el ID proporcionado y no esté ya anulado
            var credito = await _context.CreditosCredito
                .Where(x => x.IdCredito == idCredito && !x.Anulado).FirstAsync();

            // Si el crédito existe, actualiza su estado
            if (credito != null)
            {
                credito.Cancelado = true; // Marca como "cancelado"
                await _context.SaveChangesAsync(); // Guarda los cambios en la base de datos
            }
        }
        public async Task<decimal> CalcularSaldoCuota(int idDetalleCredito)
        {
            return _context.CreditosDetalle
           .Where(p => p.IdDetalleCredito == idDetalleCredito && !p.Anulado)
           .ToList() // Trae los datos a memoria
           .Sum(p => p.Saldo);
        }

        public async Task<CreditosCredito> CrearCredito(CreditosCreditoDTO creditoDTO)
        {
            CreditosCredito credito = new CreditosCredito
            {
                Cuotas = creditoDTO.Cuotas,
                Denomina = creditoDTO.Denomina,
                CodigoCredito = creditoDTO.CodigoCredito,
                IdAfiliado = creditoDTO.IdAfiliado,
                ImporteTotal = creditoDTO.ImporteTotal,
                IdLote = creditoDTO.IdLote,
                Anulado = false,
                FechaCrea = creditoDTO.FechaCrea
            };
            _context.CreditosCredito.Add(credito);
            _context.SaveChanges();
            return credito;
        }

        public void CrearCreditoDetalle(CreditosDetalleDTO creditoDTO)
        {
            var detalle = new CreditosDetalle
            {
                ImporteCuota = creditoDTO.ImporteCuota,
                IdCredito = creditoDTO.IdCredito,
                NroCredito = creditoDTO.NroCredito,
                CodMovimiento = creditoDTO.CodMovimiento,
                Anulado = false,
                Periodo = creditoDTO.Periodo,
                IdDetalle = creditoDTO.IdDetalle,
                Subcodigo = creditoDTO.Subcodigo ?? "" 
            };
            _context.CreditosDetalle.Add(detalle);
            _context.SaveChanges();
        }
        public async Task AgregarNuevoIngresoFamiliar(CreditosSalarioAfiliadoDTO creditoIngresoFamiliarDTO)
        {
            var detalle = new CreditosSalarioAfiliado
            {
                IdAfiliado = creditoIngresoFamiliarDTO.IdAfiliado,
                Desde = creditoIngresoFamiliarDTO.Desde,
                Hasta = new DateTime(1900, 01, 01),
                Monto = creditoIngresoFamiliarDTO.Monto,
                FechaCrea = DateTime.Now
            };
            _context.CreditosSalarioAfiliado.Add(detalle);
            _context.SaveChanges();
        }
        public async Task<CreditosSalarioAfiliado> CompararIngresoFamiliar(int IdAfiliado, Datum data)
        {
            var compara = await _context.CreditosSalarioAfiliado.Where(x => x.IdAfiliado == IdAfiliado && x.Monto != data.maximoDescuento && !x.Anulado)
                .OrderByDescending(x => x.IdSalario)
                .FirstOrDefaultAsync();
            return compara;
        }
        public void ActualizarMargenSalarialJubilado(CreditosSalarioAfiliado salario)
        {
            var detalle = new CreditosSalarioAfiliado
            {
                IdSalario = salario.IdSalario, 
                MaximoDescuento = salario.MaximoDescuento,
                Monto = salario.Monto,
                Desde = DateTime.Now
            }; 
            _context.SaveChanges();
        }
        public void ActualizarSalarioAfiliadoDGI(CreditosSalarioAfiliado salario, Datum data)
        {
            salario.Monto = data.maximoDescuento;
            salario.NroControl = data.nroControl;
            salario.IDLugarDePago = data.lugarDePago;
            salario.Desde = DateTime.Now;
            salario.Antiguedad = data.antiguedad;
            salario.HaberConAportes = Decimal.Parse(data.haberesConAportes) / 100;
            salario.HaberSinAportes = Decimal.Parse(data.haberesSinAportes) / 100;
            salario.TotalDescuentos = Decimal.Parse(data.totalDescuentos) / 100;
            salario.Liquido = Decimal.Parse(data.liquido) / 100;
            salario.MaximoDescuento = data.maximoDescuento;

            salario.Hasta = new DateTime(1900, 01, 01);
            _context.SaveChanges();
        }
        public async Task AgregarNuevoIngresoFamiliarDGI(CreditosSalarioAfiliadoDTO creditoIngresoFamiliarDTO)
        {
            var detalle = new CreditosSalarioAfiliado
            {
                IdAfiliado = creditoIngresoFamiliarDTO.IdAfiliado,
                Desde = creditoIngresoFamiliarDTO.Desde,
                Hasta = new DateTime(1900, 01, 01),
                Monto = creditoIngresoFamiliarDTO.MaximoDescuento,
                NroControl = creditoIngresoFamiliarDTO.NroControl,
                IDLugarDePago = creditoIngresoFamiliarDTO.IDLugarDePago,
                Antiguedad = creditoIngresoFamiliarDTO.Antiguedad,
                HaberConAportes = creditoIngresoFamiliarDTO.HaberConAportes,
                HaberSinAportes = creditoIngresoFamiliarDTO.HaberSinAportes,
                TotalDescuentos = creditoIngresoFamiliarDTO.TotalDescuentos,
                Liquido = creditoIngresoFamiliarDTO.Liquido,
                MaximoDescuento = creditoIngresoFamiliarDTO.MaximoDescuento,
                FechaCrea = DateTime.Now
            };
            _context.CreditosSalarioAfiliado.Add(detalle);
            _context.SaveChanges();
        }
        public void GrabarFichacta(List<CreditosFichactaDTO> registros)
        {
            foreach (var item in registros)
            {
                CreditosFichacta registroFicha = new CreditosFichacta
                {
                    Periodo = item.Periodo,
                    IdAfiliado = item.IdAfiliado,
                    Nombre = item.Nombre,
                    TipoDNI = item.TipoDNI,
                    DNI = item.DNI,
                    NumBeneficiario = item.NumBeneficiario,
                    LugarPago = item.LugarPago,
                    Estado = item.Estado,
                    CodigoCredito = item.CodigoCredito,
                    SubCodigo = item.SubCodigo,
                    NroCredito = item.NroCredito,
                    Cuotas = item.Cuotas,
                    CuotasPendientes = item.CuotasPendientes,
                    Fecha = item.Fecha,
                    ImporteCuota = item.ImporteCuota,
                    PagoAcumulado = item.PagoAcumulado,
                    MontoCredito = item.MontoCredito
                };
                _context.CreditosFichacta.Add(registroFicha);
            }
            _context.SaveChanges();
        }

        public void GrabarAnexo(List<CreditosAnexoDTO> registros)
        {
            foreach (var item in registros)
            {
                CreditosAnexo registroAnexo = new CreditosAnexo
                {
                    Control = item.Control,
                    LugarPago = item.LugarPago,
                    Planta = item.Planta,
                    Cuil = item.Cuil,
                    Dni = item.Dni,
                    Nombre = item.Nombre,
                    Sexo = item.Sexo,
                    Periodo = item.Periodo,
                    TotalHaber = item.TotalHaber,
                    CodigoCred = item.CodigoCred,
                    Importe = item.Importe,
                    Anulado = false,
                    EstadoImporte = false
                };
                _context.CreditosAnexo.Add(registroAnexo);
            }
            _context.SaveChanges();
        }

        public void GrabarNoEfectuados(List<CreditosNoEfectuadosDTO> registros)
        {
            foreach (var item in registros)
            {
                var credito = new CreditosNoEfectuados
                {
                    LugarPago = item.LugarPago,
                    A_Numero = item.A_Numero,
                    Nombre = item.Nombre,
                    Periodo = item.Periodo,
                    Codigo = item.Codigo,
                    Importe = item.Importe,
                    NroCuota = item.NroCuota,
                    TotalCuota = item.TotalCuota,
                    IdMotivo = item.IdMotivo,
                    Cuil = item.Cuil,
                    Dni = item.Dni,
                    NroControl = item.NroControl,
                    Planta = item.Planta,
                    Anulado = false
                };
                _context.CreditosNoEfectuados.Add(credito);
            }
            _context.SaveChanges();
        }

        public Task<List<ResultadoOrdenCoseguro>> GetDetalleLote(int pageNumber, int pageSize)
        {
            return _context.ResultadoOrdenCoseguro
                .OrderBy(l => l.Nropaq) // Ordena por el número de paquete
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
        public async Task<List<CreditosFichacta>> BuscarDatosFichaCuenta(string periodo, int pageNumber, int pageSize)
        {
            var credFichacta = await (from cnf in _context.CreditosFichacta
                                      where cnf.Periodo == periodo && !cnf.Anulado
                                      select new CreditosFichacta
                                      {
                                          NroCredito = cnf.NroCredito,
                                          CodigoCredito = cnf.CodigoCredito,
                                          IdAfiliado = cnf.IdAfiliado,
                                          Nombre = cnf.Nombre.TrimEnd(),
                                          Cuotas = cnf.Cuotas,
                                          ImporteCuota = cnf.ImporteCuota,
                                          CuotasPendientes = cnf.CuotasPendientes,
                                          MontoCredito = cnf.MontoCredito,
                                          PagoAcumulado = cnf.PagoAcumulado,
                                          LoteCargado = cnf.LoteCargado
                                      })
                                 .Skip((pageNumber - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToListAsync();

            return credFichacta;

        }
        public async Task<CreditosFichacta?> GetDatoFichaCta(FichactaDto fichacta)
        {
            var dato = await _context.CreditosFichacta.FirstOrDefaultAsync(
            s => s.NroCredito == fichacta.NroCredito && s.CodigoCredito == fichacta.CodigoCredito && !s.LoteCargado && !s.Anulado);
            return dato;
        }

        public void ImpactarPagoFichacta(CreditosDetalle pagoFichacta, CreditosFichacta impactarCredito, decimal importeCuota)
        {
            pagoFichacta.Saldo = (-1) * importeCuota;
            impactarCredito.LoteCargado = true;
            _context.SaveChanges();
        }
        public void GrabarMigracion(List<CreditosHcablTcrDTO> registros)
        {
            foreach (var item in registros)
            {
                CreditosHcablTcr registro = new CreditosHcablTcr
                {
                    Identif = item.Identif,
                    Nropaq = item.Nropaq,
                    Credito = item.Credito,
                    Mes = item.Mes,
                    Anio = item.Anio,
                    Cantdoc = item.Cantdoc,
                    Totimpcu = item.Totimpcu,
                    Cantocu = item.Cantocu,
                    Impotctr = item.Impotctr,
                    Identific = item.Identific,
                    Iden_fecha = item.Iden_fecha,
                    Iden_hora = item.Iden_hora,
                    Error1 = "",
                    Error2 = "",
                    Error3 = "",
                    Error4 = "",
                    Error9 = "",
                    Fecproc = item.Fecproc
                };
                _context.CreditosHcablTcr.Add(registro);
            }
            _context.SaveChanges();
        }
        public async Task<List<object>> BuscarDatosAnexo(string periodo, int pageNumber, int pageSize)
        {
            var credFichacta = await (from cnf in _context.CreditosFichacta
                                      join cc in _context.CreditosConcCred
                                      on cnf.CodigoCredito equals cc.IdConcCred.ToString()
                                      where cnf.Periodo == periodo && !cnf.Anulado
                                      select new
                                      {
                                          cnf.NroCredito,
                                          CodigoCredito = cnf.CodigoCredito,
                                          cnf.IdAfiliado,
                                          Nombre = cnf.Nombre.TrimEnd(),
                                          cnf.Cuotas,
                                          cnf.ImporteCuota,
                                          cnf.CuotasPendientes,
                                          cnf.MontoCredito,
                                          cnf.PagoAcumulado,
                                          cnf.LoteCargado
                                      })
                           .Skip((pageNumber - 1) * pageSize)
                           .Take(pageSize)
                           .ToListAsync();
            return credFichacta.Cast<object>().ToList();
        }
        public async Task<List<object>> BuscarDatosNoEfectuados(string periodo, int pageNumber, int pageSize)
        {
            var credFichacta = await (from cnf in _context.CreditosNoEfectuados
                                      join cm in _context.CreditosMotivoNoefec on cnf.IdMotivo equals cm.IdMotivo
                                      join cc in _context.CreditosConcCred on cnf.Codigo equals cc.IdConcCred.ToString()
                                      where cnf.Periodo == periodo && !cnf.Anulado
                                      select new
                                      {
                                          A_Numero = cnf.A_Numero,
                                          cnf.Periodo,
                                          Codigo = cnf.Codigo + " - " + cc.Desc_conc,
                                          Nombre = cnf.Nombre.TrimEnd(),
                                          NroCuota = int.Parse(cnf.NroCuota) + "/" + int.Parse(cnf.TotalCuota),
                                          cnf.Importe,
                                          cm.Descripcion
                                      }).Skip((pageNumber - 1) * pageSize)
                                        .Take(pageSize)
                                        .ToListAsync();
            return credFichacta.Cast<object>().ToList();
        }

        public async Task<List<CreditoImprimirDto>> GetCreditosAsync(int idAfiliado)
        {
            var creditos = await (from credito in _context.CreditosCredito
                                  where credito.IdAfiliado == idAfiliado && !credito.Anulado
                                  select credito).ToListAsync();

            var afiliados = await (from afiliado in _context.Afiliados
                                   join domicilio in _context.DomiciliosDDJJs on afiliado.IdAfiliado equals domicilio.IdAfiliado
                                   join localidad in _context.Localidades on domicilio.IdLocalidad equals localidad.IdLocalidad
                                   where afiliado.IdAfiliado == idAfiliado && !afiliado.Anulado && !domicilio.Anulado && !localidad.Anulado
                                   select new AfiliadoDetalleImprimirDto
                                   {
                                       IdAfiliado = afiliado.IdAfiliado,
                                       NombreAfiliado = afiliado.Nombre,
                                       CuilTitular = afiliado.CuilTitular,
                                       A_Numero = afiliado.A_Numero ?? "",
                                       Domicilio = domicilio.Domicilio ?? "",
                                       IdLocalidad = localidad.IdLocalidad,
                                       CodigoPostal = localidad.CodigoPostal,
                                       NombreLocalidad = localidad.Nombre
                                   }).ToListAsync();

            var resultado = from c in creditos
                            join a in afiliados on c.IdAfiliado equals a.IdAfiliado
                            select new CreditoImprimirDto
                            {
                                IdCredito = c.IdCredito,
                                Cuotas = c.Cuotas,
                                ImporteTotal = c.ImporteTotal,
                                Denomina = c.Denomina,
                                CodigoCredito = c.CodigoCredito,
                                IdAfiliado = c.IdAfiliado,
                                IdLote = c.IdLote,
                                FormaPago = c.FormaPago,
                                Anulado = c.Anulado,
                                FechaCrea = c.FechaCrea.ToString("yyyy-MM-dd"),
                                Cancelado = c.Cancelado,
                                NroCreditoMigracion = c.NroCreditoMigracion,
                                NombreAfiliado = a.NombreAfiliado,
                                CuilTitular = a.CuilTitular,
                                A_Numero = a.A_Numero,
                                Domicilio = a.Domicilio,
                                IdLocalidad = a.IdLocalidad,
                                CodigoPostal = a.CodigoPostal,
                                NombreLocalidad = a.NombreLocalidad
                            };

            return resultado.ToList();
        }

        public async Task<List<CreditosNoEfectuados>> BuscarDatosNoEfectuadosXFallecidos()
        {
            var NoEfectuadosXFallecidos = await (from cnf in _context.CreditosNoEfectuados
                                                 join af in _context.Afiliados on cnf.A_Numero.ToString() equals af.A_Numero.ToString()
                                                 where af.Cuil == af.CuilTitular && af.IdMotivoBaja == 4
                                                 select new CreditosNoEfectuados
                                                 {
                                                     IdNoefect = cnf.IdNoefect,
                                                     NroControl = cnf.NroControl,
                                                     Planta = cnf.Planta,
                                                     LugarPago = cnf.LugarPago,
                                                     A_Numero = cnf.A_Numero,
                                                     Nombre = cnf.Nombre,
                                                     Periodo = cnf.Periodo,
                                                     Codigo = cnf.Codigo,
                                                     Importe = cnf.Importe,
                                                     NroCuota = cnf.NroCuota,
                                                     TotalCuota = cnf.TotalCuota,
                                                     Cuil = cnf.Cuil,
                                                     Dni = cnf.Dni,
                                                     Sexo = cnf.Sexo,
                                                     IdMotivo = cnf.IdMotivo,
                                                     Anulado = cnf.Anulado
                                                 }).ToListAsync();
            return NoEfectuadosXFallecidos;
        }
        public async Task<string> CancelarCreditosAfiliado(List<CreditosNoEfectuadosDTO> creditosNoEfect)
        {
            foreach (var item in creditosNoEfect)
            {
                var afiliado =  _context.Afiliados.Where(x => x.A_Numero.ToString() == item.A_Numero.ToString()
                && x.Cuil == x.CuilTitular && x.IdMotivoBaja == 4).FirstOrDefault();
                if (afiliado != null)
                {
                    var credito = await _context.CreditosCredito.Where(x => x.IdAfiliado == afiliado.IdAfiliado
                    && !x.Anulado && !x.Cancelado).ToListAsync();

                    CreditosMotivoCancelado creditosCancelado = new CreditosMotivoCancelado();
                    foreach (var itemCred in credito)
                    {  
                        creditosCancelado.descripcionMotivo = "Cancelado por fallecimiento";
                        creditosCancelado.Anulado = false;
                        creditosCancelado.idCredito = itemCred.IdCredito;
                        creditosCancelado.idMotivo = 4;
                        _context.CreditosMotivoCancelado.Add(creditosCancelado);                        
                    }
                }
            }
            await _context.SaveChangesAsync();
            return "";
        }
        public async Task<decimal> CalcularImporteCuotasPendientes(CreditosCreditoDTO credito)
        {
            var resul= await _context.CreditosDetalle
                .Where(x => x.IdCredito == credito.IdCredito && !x.Anulado && x.Saldo == 0)
                .SumAsync(x => x.ImporteCuota);
            return resul;
        }
        public async Task<List<CreditosCredito>> GetListCreditosByIdAfiliado(int idAfiliado)
        {
            return await _context.CreditosCredito
                .Where(x => x.IdAfiliado == idAfiliado && !x.Anulado && !x.Cancelado)
                .ToListAsync();
        }
        public async Task<string> CancelarCreditoPorUnificar(UnificacionCreditosDto credito)
        {
            foreach (var item in credito.Creditos)
            {
                var creditoExistente = await _context.CreditosCredito.FindAsync(item.IdCredito);
                if (creditoExistente != null)
                {
                    creditoExistente.Cancelado = true;
                    _context.CreditosCredito.Update(creditoExistente);

                    CreditosMotivoCancelado creditosCancelado = new CreditosMotivoCancelado();

                    creditosCancelado.descripcionMotivo = "Cancelado por fallecimiento";
                    creditosCancelado.idCredito = item.IdCredito;
                    creditosCancelado.idMotivo = 4;
                    creditosCancelado.Anulado = false;
                    _context.CreditosMotivoCancelado.Add(creditosCancelado);
                }
            }
            await _context.SaveChangesAsync();
            return "";
        }
        public async Task AgregarNuevoGarante(int idAfiliadoGarante, int idAfiliadoDeudor, string cuilOperador)
        {
            var detalle = new CreditosGarante
            {
                IdAfiliadoGarante = idAfiliadoGarante,
                IdAfiliadoDeudor = idAfiliadoDeudor,
                FechaCrea = DateTime.Now,
                Anulado = false,
                OperadorCrea = "Sistema" 
            }; 
            _context.CreditosGarante.Add(detalle);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> ExisteGarante(int idAfiliadoGarante, int idAfiliadoDeudor)
        {
            return await _context.CreditosGarante.Where(x => x.IdAfiliadoGarante == idAfiliadoGarante 
            && x.IdAfiliadoDeudor == idAfiliadoDeudor && !x.Anulado).AnyAsync();
        }
        public async Task CancelarCreditoPorVincularDeudor(int idCredito, string descMotivo)
        {
                // Busca el crédito que coincida con el ID proporcionado y no esté ya anulado
                var credito = await _context.CreditosCredito
                    .Where(x => x.IdCredito == idCredito && !x.Anulado).FirstAsync();

                // Si el crédito existe, actualiza su estado
                if (credito != null)
                {
                    credito.Cancelado = true; // Marca como "cancelado"
                CreditosMotivoCancelado creditosCancelado = new CreditosMotivoCancelado();

                creditosCancelado.descripcionMotivo = descMotivo;
                creditosCancelado.idCredito = idCredito;
                creditosCancelado.idMotivo = 5;
                creditosCancelado.Anulado = false;
                _context.CreditosMotivoCancelado.Add(creditosCancelado);
                await _context.SaveChangesAsync(); // Guarda los cambios en la base de datos
                }
        }
        public async Task<Afiliado> GetAfiliadoByID(int idAfiliado)
        {
            return await _context.Afiliados
                .Where(x => x.IdAfiliado == idAfiliado && !x.Anulado).FirstAsync(); 
        }

        public async Task CrearCreditoExtraJudicial(int idCredito)
        {
             
        }
    }
}
