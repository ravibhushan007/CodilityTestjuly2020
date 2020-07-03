using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewCodilitytcst
{
    class PromotionFactoryObj : PromoFactory
    {
        public override IPromotional PromoIntance(string Promotype)
        {

            switch (Promotype)
            {
                case "InstantPromo":
                    return new InstantPromo();
                case "CashBackPromo":
                    return new CashBackPromo();
                default:
                    throw new ApplicationException(string.Format("Promotype '{0}' cannot be created", Promotype));
            }

        }
    }
}
