using Microsoft.AspNetCore.Mvc.Rendering;

namespace Proje.Models
{
    public class DemirbasMarkaModel
    {
        public IEnumerable<SelectListItem> MarkaList { get; set; }
        public IEnumerable<SelectListItem> ModelList { get; set; }
    }
}
