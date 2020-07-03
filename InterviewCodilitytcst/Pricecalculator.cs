using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCodilitytcst
{
    public class Pricecalculator
    {
        public  static int TotalPrice(Dictionary<string, Dictionary<int, int>> orders, bool ispromoapplied, string PromoType)
        {
            try
            {
                if (ispromoapplied)
                {
                    PromoFactory obj = new PromotionFactoryObj();
                    IPromotional active_promo = obj.PromoIntance(PromoType);
                    return active_promo.TotalPricewithPromotional(orders);
                }
                else
                {
                    return orders.Sum(x => x.Value.Sum(s => s.Value * s.Key));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + " in method TotalPrice" ); throw ; }

        
}
    }
}
