﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.DiscountDto
{
    public class ResultDiscountDto
    {
        public int DiccountId { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
		public bool status { get; set; }

	}
}
