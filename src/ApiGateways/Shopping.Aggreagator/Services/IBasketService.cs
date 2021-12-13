using Shopping.Aggreagator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Aggreagator.Services
{
   public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}
