using Microsoft.AspNetCore.Mvc;
using veterinaria.infretruture.DBContex;
using veterinaria.infretruture.Model;
using Veteriania.API.DTOS;
using tallermecanico.domain.Entityes;

namespace CRUD_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class VacunaController : ControllerBase
    {
        private readonly VeterinariaContex _context;

        public VacunaController(VeterinariaContex context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllVacunas()
        {
            var vacunas = _context.Vacunas.ToList();

            var dtoList = vacunas.Select(v => new VacunaDto
            {
              
                NombreVacuna = v.NombreVacuna,
                FechaAplicacion = v.FechaAplicacion,
                Veterinario = v.Veterinario,
                MascotaId = v.MascotaId
            }).ToList();

            return Ok(dtoList);
        }

        [HttpGet("{id}")]
        public IActionResult GetVacunaById(int id)
        {
            var vacuna = _context.Vacunas.FirstOrDefault(v => v.VacunaId == id);
            if (vacuna == null)
                return NotFound();

            return Ok(vacuna);
        }

        [HttpPost]
        public IActionResult CreateVacuna([FromBody] VacunaDto dto)
        {
            var vacuna = new VacunaModel
            {
                NombreVacuna = dto.NombreVacuna,
                FechaAplicacion = dto.FechaAplicacion,
                Veterinario = dto.Veterinario,
                MascotaId = dto.MascotaId
            };

            _context.Add(vacuna);
            _context.SaveChanges();

            return Ok(dto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVacuna(int id, [FromBody] VacunaDto dto)
        {
            var vacuna = _context.Vacunas.FirstOrDefault(v => v.VacunaId  == id);
            if (vacuna == null)
                return NotFound();

            vacuna.NombreVacuna = dto.NombreVacuna;
            vacuna.FechaAplicacion = dto.FechaAplicacion;
            vacuna.Veterinario = dto.Veterinario;
            vacuna.MascotaId = dto.MascotaId;

            _context.Update(vacuna);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVacuna(int id)
        {
            var vacuna = _context.Vacunas.FirstOrDefault(v => v.VacunaId  == id);
            if (vacuna == null)
                return NotFound();

            _context.Vacunas.Remove(vacuna);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
