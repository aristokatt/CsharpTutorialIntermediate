// See https://aka.ms/new-console-template for more information
internal class Post
{
	private int VoteCount { get; set; }
	private string Title { get; set; }
	private readonly DateTime timeOfCreation;

	public Post(string title)
	{
		VoteCount = 0;
		timeOfCreation = DateTime.Now;
		Title = title;
	}

	//private void setTitle(string title)
	//{
	//	Title = title;
	//}

	public void UpVote()
	{
		VoteCount++;
	}

	public void DownVote()
	{
		VoteCount--;
	}

	public int getVoteCount()
	{
		return VoteCount;
	}
}