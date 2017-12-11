namespace Sharp.Reporting
{
	public struct MessageItem
	{
		public readonly string Text;
		public readonly MessagePriority Priority;


		public MessageItem(string text)
		{
			Text = text;
			Priority = MessagePriority.None;
		}

		public MessageItem(string text, MessagePriority priority)
		{
			Text = text;
			Priority = priority;
		}
	}


	public enum MessagePriority
	{
		None,
		Hot
	}
}
