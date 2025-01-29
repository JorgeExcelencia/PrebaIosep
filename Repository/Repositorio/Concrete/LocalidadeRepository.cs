using ApiIosep.Models.IOSEP;
using ApiIosep.Models.Persona.Geo;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Repositorio.Concrete
{
    public class LocalidadeRepository : BaseRepository<Localidade>, ILocalidadeRepository
    {
        public LocalidadeRepository(IOSEPContext context) : base (context)
        {
            
        }

        public async Task<List<LocalidadVW>> GetLocalidadesByIdProvincia(int IdProvincia)
            => await table.AsNoTracking()
            .Where(l => l.IdProvincia == IdProvincia && !l.Anulado)
            .OrderBy(l => l.Nombre)
            .Select(l => new LocalidadVW
            {
                IdProvincia = IdProvincia,
                IdLocalidad = l.IdLocalidad,
                CodigoPostal = l.CodigoPostal.Trim(),
                Nombre = l.Nombre.Trim() + $"({l.CodigoPostal.Trim()})"
            })
            .ToListAsync();

        public async Task<int> GetIdProvinciaByIdLocalidad(int IdLocalidad)
            => await table.AsNoTracking()
            .Where(l => l.IdLocalidad == IdLocalidad && !l.Anulado)
            .Select(l => l.IdProvincia)
            .FirstOrDefaultAsync();
        
    }
}
