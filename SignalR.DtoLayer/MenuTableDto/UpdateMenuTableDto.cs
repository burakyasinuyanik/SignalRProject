﻿using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.MenuTableDto
{
	public class UpdateMenuTableDto
	{
		public int TableId { get; set; }
		public string Name { get; set; }
		public bool Status { get; set; }
		public List<Basket> Baskets { get; set; }
	}
}