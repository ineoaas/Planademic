using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Planademic.Web.Pages.Teacher
{
    // TODO: Inject ICourseService and IAssignmentService in Iteration 2.
    // TODO: Add [Authorize(Roles = "Teacher")] attribute in Iteration 3.
    public class DashboardModel : PageModel
    {
        public void OnGet() { }
    }
}