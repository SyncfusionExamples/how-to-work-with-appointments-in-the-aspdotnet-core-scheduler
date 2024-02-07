using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Dynamic;
namespace DataGrid.Pages
{
    public class AppointmentData
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public bool? IsAllDay { get; set; }
        public string? RecurrenceRule { get; set; }
        public bool? IsReadonly { get; set; }

        public bool? IsBlock { get; set; }
    }

    public class IndexModel : PageModel
    { 
        public void OnGet()
        {
           
        }
    }
}