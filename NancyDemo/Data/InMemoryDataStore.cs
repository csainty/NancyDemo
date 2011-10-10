using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyDemo.Data
{
	public class InMemoryDataStore : IDataStore
	{
		List<Message> _Messages = new List<Message>(new[] { new Message() { Content = "Hello World" } });

		public IList<Message> GetMessages()
		{
			return _Messages.ToList();
		}

		public void AddMessage(string message)
		{
			_Messages.Add(new Message { Content = message });
		}
	}
}