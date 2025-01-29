using ApiIosep.Models.IOSEP;
using ApiIosep.Models.IOSEPweb;
using ApiIosep.Models.Persona;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Models.Creditos;

namespace ApiIosep.Repositorio.Concrete
{
    public class AfiliadosRespository : BaseRepository<Afiliado>, IAfiliadosRespository
    {
        public IOSEPContext _context;
        public IOSEPwebContext _webContext;
        public AfiliadosRespository(IOSEPContext context, IOSEPwebContext webContext) : base(context)
        {
            _context = context;
            _webContext = webContext;
        }

        public async Task<List<AfiliadoVM>> GetAfiliadoVM()
        => await table.Where(x => x.IosepSalud)
                    .Take(15)
                    .Select(s => new AfiliadoVM
                    {
                        IdAfiliado = s.IdAfiliado,
                        Cuil = s.Cuil,
                        Nombre = s.Nombre.Trim(),
                        Titular = s.Cuil == s.CuilTitular,
                        IdMotivoBaja = s.IdMotivoBaja,
                        A_Numero = s.A_Numero.Trim(),
                        cTitular = s.CuilTitular,
                        nTitular = table.Where(w => w.Cuil == s.CuilTitular).Select(a => a.Nombre).FirstOrDefault()
                        //nTitular =  await GetNombreTitular(s.CuilTitular)
                    })
                    .OrderBy(o => o.Nombre)
                    .ToListAsync();
        public string GetNombreTitular(string cuil)
            => table.Where(w => w.Cuil == cuil).Select(a => a.Nombre).FirstOrDefault();

        public async Task<List<AfiliadoVM>> GetAfiliadoVM(string filter)
            => await table.Where(x => x.IosepSalud &&
                          (x.Cuil.Contains(filter)
                          || x.A_Numero.Contains(filter))
                      )
                      .Select(s => new AfiliadoVM
                      {
                          IdAfiliado = s.IdAfiliado,
                          Cuil = s.Cuil,
                          Nombre = s.Nombre.Trim(),
                          Titular = s.Cuil == s.CuilTitular,
                          IdMotivoBaja = s.IdMotivoBaja,
                          A_Numero = s.A_Numero.Trim(),
                          cTitular = s.CuilTitular,
                          nTitular = table.Where(w => w.Cuil == s.CuilTitular).Select(a => a.Nombre).FirstOrDefault()
                      })
                      .Take(15)
                      .OrderBy(o => o.Nombre)
                      .ToListAsync();


        public async Task<List<int>> GetAfiliadoVMListId(string filter)
           => await table.Where(x => x.IosepSalud &&
                         (x.Cuil.Contains(filter)
                         || x.A_Numero.Contains(filter))
                     )
                     .Select(s => s.IdAfiliado)
                     .Take(15)
                     .ToListAsync();

        public async Task<List<AfiliadoVM>> GetAfiliadoVMByIdAfiliado(int id)
            => await table.Where(x => x.IdAfiliado == id
                      )
                      .Select(s => new AfiliadoVM
                      {
                          IdAfiliado = s.IdAfiliado,
                          Cuil = s.Cuil,
                          Nombre = s.Nombre.Trim(),
                          Titular = s.Cuil == s.CuilTitular,
                          IdMotivoBaja = s.IdMotivoBaja,
                          A_Numero = s.A_Numero.Trim(),
                          cTitular = s.CuilTitular,
                          nTitular = table.Where(w => w.Cuil == s.CuilTitular).Select(a => a.Nombre).FirstOrDefault()
                      })
                      .Take(15)
                      .OrderBy(o => o.Nombre)
                      .ToListAsync();

        public async Task<List<AfiliadoVM>> GetAfiliadoVMByNombre(string filter, bool iosep)
        => await table.Where(x => x.IosepSalud == iosep && x.Nombre.ToLower().Contains(filter))
                      .Select(s => new AfiliadoVM
                      {
                          IdAfiliado = s.IdAfiliado,
                          Cuil = s.Cuil,
                          Nombre = s.Nombre.Trim(),
                          Titular = s.Cuil == s.CuilTitular,
                          IdMotivoBaja = s.IdMotivoBaja,
                          A_Numero = s.A_Numero.Trim(),
                          cTitular = s.CuilTitular,
                          nTitular = table.Where(w => w.Cuil == s.CuilTitular).Select(a => a.Nombre).FirstOrDefault()
                      })
                      .Take(15)
                      .OrderBy(o => o.Nombre)
                      .ToListAsync();
        public async Task<List<int>> GetAfiliadoVMByNombreByNombre(string filter)
        => await table.Where(x => x.Nombre.ToLower().Contains(filter))
                     .Select(s => s.IdAfiliado)
                     .Take(15)
                     .ToListAsync();

        public async Task<Afiliado> GetAfiliadoById(int id)
        => await table.Include(s => s.Sexo).FirstOrDefaultAsync(f => f.IdAfiliado == id);

        public async Task<bool> ExistAfiliado(int id)
         => await table.AnyAsync(a => a.IdAfiliado == id);
        public async Task<string> GetCuilTitularById(int id)
       => await table.AsNoTracking().Where(f => f.IdAfiliado == id).Select(a => a.CuilTitular).FirstOrDefaultAsync();

        public async Task<List<Afiliado>> GetGrupoFamiliarByIdAfiliado(int idAfiliado)
        {
            var cuilTitular = await GetAfiliadoById(idAfiliado);
            return await table.Where(a => a.CuilTitular == cuilTitular.CuilTitular.ToString()).ToListAsync();
        }

        public async Task<List<Afiliado>> GetAfiliadosIOSEPSalud()
            => await table
            .AsNoTracking()
            .Where(w => w.IosepSalud && w.CuilTitular == w.Cuil && w.IdMotivoBaja == 0)
            .ToListAsync();

        public async Task<List<int>> GetAfiliadoExistCompList(string filter)
            => await table
            .Where(afiliado => !afiliado.IosepSalud &&
                       afiliado.Nombre.ToLower().Contains(filter))
                        .Join(
                        _context.comprobantes,
                        afiliado => afiliado.IdAfiliado,
                        comprobanteaf => comprobanteaf.IdAfiliado,
                        (afiliado, comprobanteaf) => new { Afiliado = afiliado, Comprobante = comprobanteaf }
                        )
                        .Where(joinedData => joinedData.Comprobante.IdDetalle == 19 ||
                         joinedData.Comprobante.IdDetalle == 5 ||
                         joinedData.Comprobante.IdDetalle == 11 ||
                         joinedData.Comprobante.IdDetalle == 21)
            .Select(joinedData => joinedData.Afiliado.IdAfiliado
                         ).ToListAsync();

        public async Task<int> GetIdAfiliadoByCuil(string cuil)
            => await table.Where(a => a.Cuil == cuil).Select(a => a.IdAfiliado).FirstOrDefaultAsync();

        public async Task<Aporte> GetAportesAfiliado(string cuil)
        {
            var afiliado = await _context.Afiliados
        .FirstOrDefaultAsync(af => af.Cuil == cuil && !af.Anulado && af.IdMotivoBaja == 0);

            if (afiliado == null) return null;

            var aporte = await _webContext.Aportes
                .Where(a => a.Cuil == afiliado.Cuil)
                .OrderByDescending(a => a.FechaCrea)
                .FirstOrDefaultAsync();

            return aporte; 
        }
        public async Task<LugarPagoDTO> GetAportesAfiliadoPorNombre(Aporte LugarPago, string CodLugarPago, Datum aporte)
        {
            var CreditoTomado = 0;
            var NombreLP = await _context.Tipo_LugarPagos.Where(a => a.Codigo == CodLugarPago && !a.Anulado).Select(a => a.Nombre).FirstOrDefaultAsync();
            NombreLP ??= ""; 
            var x = new LugarPagoDTO
            {
                Id = LugarPago.IdAporte,
                Control = aporte.nroControl.Trim(),
                LugarPago = CodLugarPago.Trim(),
                NombreLugar = NombreLP.Trim(),
                Planta = LugarPago.Planta.Trim(),
                ANumero = LugarPago.ANumero.Trim(),
                Cuil = LugarPago.Cuil.Trim(),
                Afiliado = LugarPago.Afiliado.Trim(),
                Otro = LugarPago.Otro.Trim(),
                NumeroBeneficio = LugarPago.NumeroBeneficio.Trim(),
                Codigo = LugarPago.Codigo.Trim(),
                CodigoJubilado = LugarPago.CodigoJubilado.Trim(),
                HaberJubilado = decimal.Parse(aporte.haberesSinAportes),
                Aporte = decimal.Parse(aporte.haberesConAportes),
                ConAporteDescontado = decimal.Parse(aporte.liquido),
                CreditoTomado = CreditoTomado,
                Disponible = aporte.maximoDescuento
            };
            return x; 
        }

        public async Task<LugarPagoDTO> GetAportesJubilado(Aporte LugarPago)
        {
            var CreditoTomado = 0;
            var NombreLP = await _context.Tipo_LugarPagos.Where(a => a.IdPago.ToString() == LugarPago.LugarPago && !a.Anulado).Select(a => new { a.Nombre, a.Codigo }).FirstOrDefaultAsync();
             
            var x = new LugarPagoDTO
            {
                Id = LugarPago.IdAporte,
                Control = LugarPago.Control.Trim(),
                LugarPago = NombreLP.Codigo.Trim(),
                NombreLugar = NombreLP.Nombre.Trim(),
                Planta = LugarPago.Planta.Trim(),
                ANumero = LugarPago.ANumero.Trim(),
                Cuil = LugarPago.Cuil.Trim(),
                Afiliado = LugarPago.Afiliado.Trim(),
                Otro = LugarPago.Otro.Trim(),
                NumeroBeneficio = LugarPago.NumeroBeneficio.Trim(),
                Codigo = LugarPago.Codigo.Trim(),
                CodigoJubilado = LugarPago.CodigoJubilado.Trim(),
                HaberJubilado = LugarPago.HaberJubilado,
                Aporte = LugarPago.Aporte1,
                ConAporteDescontado = LugarPago.HaberJubilado,
                CreditoTomado = CreditoTomado,
                Disponible = LugarPago.HaberJubilado - CreditoTomado
            };
            return x;
        }
        public async Task<Afiliado?> GetAfiliadoCreditos(string cuil)
        {
            return await _context.Afiliados.Where(x => x.Cuil == cuil).FirstOrDefaultAsync(); 
        }
        public async Task<Afiliado?> GetIdAfiliadoByAnumero(int ANumero)
        {
            return await _context.Afiliados.Where(x => x.A_Numero == ANumero.ToString() && x.IdMotivoBaja == 0 && x.Cuil == x.CuilTitular).FirstOrDefaultAsync();
        }
        public async Task<AfiliadosLugarPago?> GetLugarPagoJubiladoByIdAfiliado(int idAfiliado)
        {
            return await _context.AfiliadosLugarPagos
                .Where(x => x.IdAfiliado == idAfiliado && !x.Anulado)
                .OrderByDescending(x => x.IdAfiliadosLugarPago)
                .FirstOrDefaultAsync();
        }
    }
}
