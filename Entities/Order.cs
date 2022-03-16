﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order : BaseEntity
    {
        public string CustomerID { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public string CustomerPhone { get; set; } = null!;
        public string CustomerAddress { get; set; } = null!;
        public string OverCode { get; set; } = null!;
        public int PaymentMethod { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal DeliveryCharges { get; set; }
        public decimal FinalAmount { get; set; }
        public DateTime PlacedOn { get; set; }
        public bool IsGuestOrder { get; set; }

        public int? PromoID { get; set; }
        public virtual Promo? Promo { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; } = null!;
        public virtual List<OrderHistory>? OrderHistories { get; set; } 

    }









}
