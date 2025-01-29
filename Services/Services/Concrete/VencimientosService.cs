using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;
using ApiIosep.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Services.Concrete
{
    public class VencimientosService : IVencimientosService
    {
        private IVencimientosPeriodosFacturacionRepository _facturacionRepository;
        public VencimientosService(IVencimientosPeriodosFacturacionRepository facturacionRepository) {
            
        _facturacionRepository = facturacionRepository;

        }

        public async Task<List<VencimientosPeriodosFacturacion>> GetVencimientos(string periodos,bool futuros)
        {
            if (futuros)
                return await _facturacionRepository.GetVencimientoFuturo(periodos);

            return await _facturacionRepository.GetVencimiento(periodos);
        }

        public async Task<VencimientosPeriodosFacturacion> GetVencimientos(int id)
        {
            return await _facturacionRepository.GetById(id);
        }

        public async Task<VencimientosPeriodosFacturacion> GetVencxPeriodo(string periodo)
        {
            return await _facturacionRepository.GetVencimientoPerio(periodo);
        }

        public async Task<bool> PutVencimientos(VencimientosPeriodosFacturacion vencimientos)
        {

            try
            {
                await _facturacionRepository.Update(vencimientos);
                await _facturacionRepository.Save();

                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }

        }

        public async Task<VencimientosPeriodosFacturacion> PostVencimientos(VencimientosPeriodosFacturacion vencimientos)
        {
            try
            {
                await _facturacionRepository.Insert(vencimientos);
                await _facturacionRepository.Save();
                return vencimientos;
            }
            catch (DbUpdateConcurrencyException)
            {
                vencimientos.idPeriodo = 0;
                return vencimientos;
            }
        }
        
        public async Task<bool> DeleteVencimientos(int id)
        {
            var vencimientos = await _facturacionRepository.GetById(id);
            if (vencimientos == null)
            {
                return false;
            }

            await _facturacionRepository.Delete(id);
            await _facturacionRepository.Save();

            return true;
        }
    }
}
