using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using NancyDemo.Data;

namespace NancyDemo
{
	public class ApiModule : NancyModule
	{
		private readonly IDataStore _Data;

		public ApiModule(IDataStore data)
			: base("/api")
		{
			_Data = data;

			Get["/messages/list"] = p => Response.AsJson(_Data.GetMessages());

			Post["/messages/save"] = p => { _Data.AddMessage(Request.Form["Message"]); return "OK!"; };
		}
	}
}