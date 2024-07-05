//using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2005_Employee_Skills_Portal.Models;
using Syncfusion.EJ2.Base;
using Syncfusion.EJ2.DropDowns;
using System.Collections;

namespace P2005_Employee_Skills_Portal.Controllers
{
    public class StaffController : Controller
    {
        private ApplicationDbContext _context;
        public StaffController(ApplicationDbContext context)
        {
            _context = context;
        }
        #region Staff

        //StaffController
        public ActionResult Staff()
        {
            return View();
        }

        public ActionResult GetStaffList([FromBody] DataManagerRequest dm)
        {
            var _data = _context.StaffPages.OrderByDescending(o => o.Id).ToList();
            IEnumerable data = _data;
            int count = _data.Count();
            DataOperations operation = new DataOperations();

            //Performing filtering operation
            if (dm.Where != null)
            {
                data = operation.PerformFiltering(data, dm.Where, "and");
                var filtered = (IEnumerable<object>)data;
                count = filtered.Count();
            }
            //Performing search operation
            if (dm.Search != null)
            {
                data = operation.PerformSearching(data, dm.Search);
                var searched = (IEnumerable<object>)data;
                count = searched.Count();
            }
            //Performing sorting operation
            if (dm.Sorted != null)
                data = operation.PerformSorting(data, dm.Sorted);

            //Performing paging operations
            if (dm.Skip != 0)
                data = operation.PerformSkip(data, dm.Skip);
            if (dm.Take != 0)
                data = operation.PerformTake(data, dm.Take);

            return Json(new { result = data, count = count }, new System.Text.Json.JsonSerializerOptions());
        }

        //call a Partial view 
        public ActionResult AddPartial([FromBody] CRUDModel<StaffPages> value)
        {
            List<string> education = new List<string>() { "associate degree", "bachelor's degree", "master's or graduate degrees", "doctorate or professional degrees" };
            ViewBag.education = education; //HighestLevelOfEducation(dropdown)

            List<string> Station = new List<string>() { "Nairobi", "Entebbe", "Somalia", "Port Sudan", "Geneva" };
            ViewBag.DutyStation = Station;//DutyStation (dropdown)

            List<string> Expertise = new List<string>() { "Senior", "Junior" };
            ViewBag.Expertise = Expertise; //Software Expertise (dropdown)

            List<string> Level = new List<string>() { "< than 3 years", "> than 3 years", " above 5 years" };
            ViewBag.Level = Level;//Software Expertise Level (dropdown)

            List<string> Responsibility = new List<string>() { "Over all Responsibility", "Manager", " Junior" };
            ViewBag.Responsibility = Responsibility; //Level of Responsibility (dropdown)

            List<string> Language = new List<string>() { "English", "French", " Luganda", " Kishwahili" };
            ViewBag.Language = Language; //Level of Responsibility (dropdown)

            return PartialView("_DialogAddPartial", value.Value);
        }
        #endregion
    }
}
