using System.Threading.Tasks;

namespace Solution.Web.Pages.Public.Unit
{
    public class IndexModel : SolutionPageModel
    {
        public async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
