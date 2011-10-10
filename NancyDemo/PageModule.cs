using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyDemo
{
	public class PageModule : NancyModule
	{
		public PageModule()
		{
			Get["/"] = p => View["Default"];
		}
	}
}