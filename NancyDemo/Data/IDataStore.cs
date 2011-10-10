using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NancyDemo.Data
{
	public interface IDataStore
	{
		IList<Message> GetMessages();

		void AddMessage(string message);
	}

	public class Message
	{
		public string Content { get; set; }
	}
}