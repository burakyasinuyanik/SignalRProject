﻿using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUi.Dtos.MenuTableDtos
{
	public class ResultMenuTableDto
	{
		public int TableId { get; set; }
		public string Name { get; set; }
		public bool Status { get; set; }
		
	}
}
