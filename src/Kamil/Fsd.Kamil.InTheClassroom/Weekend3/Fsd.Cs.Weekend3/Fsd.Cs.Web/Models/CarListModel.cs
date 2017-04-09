using System.Collections.Generic;

namespace Fsd.Cs.Web.Models
{
    public class CarListModel
    {
        public IEnumerable<CarModel> Cars { get; set; }

        public string Title { get; set; }
    }
}