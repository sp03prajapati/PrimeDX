using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementAPI.Models;

namespace SchoolManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolDepartmentController : ControllerBase
    {

        private readonly CarryZoneContext zoneContext;

        public SchoolDepartmentController(CarryZoneContext zoneContext)
        {
            this.zoneContext = zoneContext;
        }
     
        [HttpGet]
        public async Task<ActionResult<SchoolInfo>> GetStudentDetails()
        {
            var data = await zoneContext.SchoolInfos.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SchoolInfo>> GetStudentById(int id)
        {
            var student = await zoneContext.SchoolInfos.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }

        [HttpPost]
        public async Task<ActionResult<SchoolInfo>> AddStudent(SchoolInfo info)
        {
            await zoneContext.SchoolInfos.AddAsync(info);
            await zoneContext.SaveChangesAsync();
            return Ok(info);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SchoolInfo>> UpdateStudent(int id,SchoolInfo info)
        {
            if (id != info.Id)
            {
                return BadRequest();
            }
            zoneContext.Entry(info).State = EntityState.Modified;   
            await zoneContext.SaveChangesAsync();
            return Ok(info);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SchoolInfo>> DeleteStudent(int id)
        {
            var std = await zoneContext.SchoolInfos.FindAsync(id);
            if (std == null)
            { 
               return NotFound();
            }
            zoneContext.SchoolInfos.Remove(std);
            await zoneContext.SaveChangesAsync();
            return Ok(std);
        }
    }
}
