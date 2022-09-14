using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Students.Model;
namespace HelloWorld.Pages
{
    public class HelloWebModel : PageModel
    {
        public string Message { get; set; } = "In page model: ";
        public Student Sicco = new Student(1, "Sicco", 1);
        public void OnGet()
        {
        }
    }
}
