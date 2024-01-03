using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apitask.Server.db;

namespace apitask.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
   

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/student/marks/less-than-50
        [HttpGet("marks/less-than-50")]
        public async Task<ActionResult<IEnumerable<int>>> GetStudentIdsWithLessThan50Marks()
        {
            var studentIds = await _context.Student
                .Where(s => s.Course.Any(c => c.Marks < 50))
                .Select(s => s.StudentId)
                .ToListAsync();

            return Ok(studentIds);
        }

        // GET: api/student/marks/50-to-85
        [HttpGet("marks/50-to-85")]
        public async Task<ActionResult<IEnumerable<int>>> GetStudentIdsWith50To85Marks()
        {
            var studentIds = await _context.Student
                .Where(s => s.Course.Any(c => c.Marks >= 50 && c.Marks < 85))
                .Select(s => s.StudentId)
                .ToListAsync();

            return Ok(studentIds);
        }

        // GET: api/student/marks/more-than-85
        [HttpGet("marks/more-than-85")]
        public async Task<ActionResult<IEnumerable<int>>> GetStudentIdsWithMoreThan85Marks()
        {
            var studentIds = await _context.Student
                .Where(s => s.Course.Any(c => c.Marks >= 85))
                .Select(s => s.StudentId)
                .ToListAsync();

            return Ok(studentIds);
        }
    }

}
