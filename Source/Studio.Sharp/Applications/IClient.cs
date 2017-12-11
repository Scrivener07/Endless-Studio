using Sharp.Reporting;
using System.ComponentModel;


namespace Sharp.Applications
{
	/// <summary>
	/// Implements MDI features on a windows form.
	/// </summary>
	public interface IClient
	{
		void Log(string message, BindingList<string> history);
		void Log(MessageItem message, BindingList<string> history);
	}
}
