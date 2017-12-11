namespace Sharp.Reporting
{
	public interface IMessage
	{
		void Message(string text, int image = -1, bool popup = false);
	}
}
