using Microsoft.AspNetCore.Mvc;
using P2005_Employee_Skills_Portal.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace P2005_Employee_Skills_Portal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffAPIController : ControllerBase
    {
        private ApplicationDbContext _context;
        public StaffAPIController(ApplicationDbContext context)
        {
            _context = context; //injection
        }
        // GET: api/<StaffAPIController>
        [Route("/GetStaffAsync")]
        public async Task<List<StaffPages>> GetStaffAsync()
        {
            return await GetStaffPagesAsync();
        }

        [HttpPost]
        [Route("/SaveStaffAsync")]
        public async Task<StaffPages> _SaveStaffAsync(StaffPages record)
        {
            return await SaveStaffAsync(record);
        }

        [HttpPut]
        [Route("/UpdateStaffAsync")]
        public async Task<StaffPages> _UpdateStaffAsync(StaffPages record)
        {
            return await UpdateStaffAsync(record);
        }


        private static List<StaffPages> staff = new List<StaffPages>();

        public async Task<List<StaffPages>> GetStaffPagesAsync()
        {
            await Task.Delay(5000);//delay
            return staff;
        }

        public async Task<StaffPages> SaveStaffAsync(StaffPages record)
        {
            await Task.Delay(5000);
            staff.Add(record);
            return record;
        }

        public async Task<StaffPages> UpdateStaffAsync(StaffPages record)
        {
            await Task.Delay(5000);
            var exsits = staff.FirstOrDefault(x => x.Id == record.Id);
            if (exsits != null) { staff.Remove(exsits); }
            staff.Add(record);
            return record;
        }
    }
}
