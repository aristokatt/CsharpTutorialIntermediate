// See https://aka.ms/new-console-template for more information

namespace CsharpTutorialIntermediate
{
	public class Workflow : List<IActivity>
	{
		public List<IActivity> _activities { get; set; }
		public Workflow(List<IActivity> activities)
		{
			_activities = activities;
		}
	}
}