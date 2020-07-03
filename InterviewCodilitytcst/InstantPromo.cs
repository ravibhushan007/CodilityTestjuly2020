using System.Collections.Generic;
using System.Linq;

namespace InterviewCodilitytcst
{
    class InstantPromo : IPromotional
    {
        int IPromotional.TotalPricewithPromotional(Dictionary<string, Dictionary<int, int>> orders)
        {
            var t = orders.Sum(x => x.Value.Sum(s => s.Value * s.Key));

            var first = orders.Where(x => x.Key == "A").SingleOrDefault().Value?.Values.FirstOrDefault() ?? 0;
            var second = orders.Where(x => x.Key == "B").SingleOrDefault().Value?.Values.FirstOrDefault() ?? 0;
            var third = orders.Where(x => x.Key == "C").SingleOrDefault().Value?.Values.FirstOrDefault() ?? 0;
            var four = orders.Where(x => x.Key == "D").FirstOrDefault().Value?.Values?.FirstOrDefault() ?? 0;
            int CD = 0;
            if (third > 0 && four > 0)
            {
                CD = third - four > 0 ? four : third;
            }
            return t - first / 3 * 20 - second / 2 * 15 - CD * 5;

        }
    }
}
