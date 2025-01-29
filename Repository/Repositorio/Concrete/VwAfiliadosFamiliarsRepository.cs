using ApiIosep.Models.DTOs.Afiliados;
using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Repositorio.Concrete
{
    public class VwAfiliadosFamiliarsRepository : BaseRepository<VwAfiliadosFamiliar>, IVwAfiliadosFamiliarsRepository
    {
        public VwAfiliadosFamiliarsRepository(IOSEPContext context) : base(context)
        {

        }

        public async Task<List<GrupoFamiliarDTO>> GetGrupoFamiliarDTO(string cuil)
            => await table.Where(x => x.CuilaBuscar == cuil
                && x.Anulado == false).OrderBy(x => x.IdTipoFamiliar).
            Select(x => new GrupoFamiliarDTO
            {
                AfiliadoID = x.IdAfiliado,
                Familiar = x.TipoFamiliar.Trim(),
                Nombre = x.Nombre.Trim(),
                Cuil = x.Cuil,
                FechaNacimiento = x.FechadeNacimiento,
                Estado = x.MotivoBaja.Trim(),
                Sexo = x.Sexo.Trim(),
            }).ToListAsync();
    }
}
