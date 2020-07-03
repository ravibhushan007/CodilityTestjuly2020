using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewCodilitytcst
{
    interface IPromotional
    {
        int TotalPricewithPromotional(Dictionary<string, Dictionary<int, int>> orders);
    }
}
