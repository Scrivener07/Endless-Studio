namespace Sharp.Applications.Dialogs
{
	public interface ISplash
	{
		string Title { get; set; }
		string PrimaryMessage { get; set; }
		string SecondaryMessage { get; set; }
		bool DoFadeOpen { set; }
		bool DoFadeClose { set; }
		void SetFade(bool enable);
	}
}
