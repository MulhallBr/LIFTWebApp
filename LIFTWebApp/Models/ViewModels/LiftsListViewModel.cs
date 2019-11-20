using System.Collections.Generic;
using System.Linq;
using LIFTWebApp.Models;

namespace LIFTWebApp.Models.ViewModels {

    public class LiftsListViewModel {
        public IEnumerable<Lift> Lifts { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
