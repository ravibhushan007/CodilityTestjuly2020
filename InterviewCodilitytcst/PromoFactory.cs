using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewCodilitytcst
{
    abstract class PromoFactory
    {
        public abstract IPromotional PromoIntance(string Promotype);
    }
}
