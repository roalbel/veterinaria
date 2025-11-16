using Microsoft.AspNetCore.Mvc;
using veterinaria.infretruture.DBContex;
using veterinaria.infretruture.Model;
using Veterinaria.Aplication.DTOS;


namespace CRUD_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CitaController : ControllerBase
    {
        private readonly VeterinariaContex _context;

        public CitaController(VeterinariaContex context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllCitas()
        {
            var citas = _context.Citas.ToList();

            var dtoList = citas.Select(c => new CitaDto
            {
               
                FechaCita = c.FechaCita,
                Motivo = c.Motivo,
                Estado = c.Estado,
                MascotaId = c.MascotaId
            }).ToList();

            return Ok(dtoList);
        }

        [HttpGet("{id}")]
        public IActionResult GetCitaById(int id)
        {
            var cita = _context.Citas.FirstOrDefault(c => c.MascotaId  == id);
            if (cita == null)
                return NotFound();

            return Ok(cita);
        }

        [HttpPost]
        public IActionResult CreateCita([FromBody] CitaDto dto)
        {
            var cita = new CitaModel
            {
                FechaCita = dto.FechaCita,
                Motivo = dto.Motivo,
                Estado = dto.Estado,
                MascotaId = dto.MascotaId
            };

            _context.Add(cita);
            _context.SaveChanges();

            return Ok(dto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCita(int id, [FromBody] CitaDto dto)
        {
            var cita = _context.Citas.FirstOrDefault(c => c.MascotaId  == id);
            if (cita == null)
                return NotFound();

            cita.FechaCita = dto.FechaCita;
            cita.Motivo = dto.Motivo;
            cita.Estado = dto.Estado;
            cita.MascotaId = dto.MascotaId;

            _context.Update(cita);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCita(int id)
        {
            var cita = _context.Citas.FirstOrDefault(c => c.MascotaId  == id);
            if (cita == null)
                return NotFound();

            _context.Citas.Remove(cita);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
