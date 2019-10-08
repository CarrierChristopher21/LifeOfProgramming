﻿using SportsStore.WebUI.Infrastructure.Abstract;
using System.Web.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsStore.WebUI.Infrastructure.Concrete
{
	public class FormsAuthProvider : IAuthProvider
	{
		public bool Authenticate(string username, string password)
		{
			bool result = FormsAuthentication.Authenticate(username, password);
			if(result)
			{
				FormsAuthentication.SetAuthCookie(username, false);
			}
			return result;
		}
	}
}