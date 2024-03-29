﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.Domain.Concrete
{
	public class EFProductRepository
	{
		private EFDbContext context = new EFDbContext();
		public IEnumerable<Product> Products
		{
			get
			{
				return context.Products;
			}
		}
	}
}
