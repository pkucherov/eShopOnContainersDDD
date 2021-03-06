﻿using Infrastructure.ServiceStack;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Ordering.Order.Services
{
    [Api("Ordering")]
    [Route("/orders/sales_by_state", "GET")]
    public class OrderingSalesByState : Paged<Models.SalesByState>
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
