﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitekAPI.Models
{
    public class Market
    {
        public int MarketID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public int? ProductGuideID { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public ProductGuide Administrator { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
