// See https://aka.ms/new-console-template for more information



using System.Collections;

public class Workflow //: IEnumerable<IActivity>
{
	//public List<IActivity> Activities { get; set; }
	private readonly List<IActivity> _workflow;
		public Workflow(List<IActivity> activities)
		{
			_workflow = activities;
		}
	public IEnumerable<IActivity> GetActivities()
	{
		return _workflow;
	}

	//public IEnumerator<IActivity> GetEnumerator()
	//{
	//	foreach (IActivity activity in _workflow)
	//		yield return activity;
	//}

	
	//IEnumerator IEnumerable.GetEnumerator()
	//{
	//	throw new NotImplementedException();
	//}

	public void Add(IActivity activity)
	{
		_workflow.Add(activity);
	}

	public void Remove(IActivity activity)
	{
		_workflow.Remove(activity);
	}
}
