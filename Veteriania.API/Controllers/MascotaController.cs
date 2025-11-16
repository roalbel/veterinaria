using Microsoft.AspNetCore.Mvc;
using veterinaria.infretruture.DBContex;
using veterinaria.infretruture.Model;
using Veteriania.API.DTOS;
using tallermecanico.domain.Entityes;

namespace CRUD_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MascotaController : ControllerBase
    {
        private readonly VeterinariaContex _context;

        public MascotaController(VeterinariaContex context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllMascotas()
        {
            var mascotas = _context.Mascotas.ToList();

            var dtoList = mascotas.Select(m => new MascotaDto
            {
                
                Nombre = m.Nombre,
                Tipo = m.Tipo,
                Raza = m.Raza,
                Edad = m.Edad,
                PropietarioId = m.PropietarioId
            }).ToList();

            return Ok(dtoList);
        }

        [HttpGet("{id}")]
        public IActionResult GetMascotaById(int id)
        {
            var mascota = _context.Mascotas.FirstOrDefault(m => m.MascotaId == id);
            if (mascota == null)
                return NotFound();

            return Ok(mascota);
        }

        [HttpPost]
        public IActionResult CreateMascota([FromBody] MascotaDto dto)
        {
            var mascota = new MascotaModel
            {
                Nombre = dto.Nombre,
                Tipo = dto.Tipo,
                Raza = dto.Raza,
                Edad = dto.Edad,
                PropietarioId = dto.PropietarioId
            };

            _context.Add(mascota);
            _context.SaveChanges();

            return Ok(dto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMascota(int id, [FromBody] MascotaDto dto)
        {
            var mascota = _context.Mascotas.FirstOrDefault(m => m.MascotaId == id);
            if (mascota == null)
                return NotFound();

            mascota.Nombre = dto.Nombre;
            mascota.Tipo = dto.Tipo;
            mascota.Raza = dto.Raza;
            mascota.Edad = dto.Edad;
            mascota.PropietarioId = dto.PropietarioId;

            _context.Update(mascota);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMascota(int id)
        {
            var mascota = _context.Mascotas.FirstOrDefault(m => m.MascotaId == id);
            if (mascota == null)
                return NotFound();

            _context.Mascotas.Remove(mascota);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
