// See https://aka.ms/new-console-template for more information
using System.Collections;


var activities = new List<IActivity>() { new UploadVideo(), new Encode(), new Notify(), new ChangeStatus() };

var workflow = new Workflow(activities);

//workflow.Add(new UploadVideo());

var workflowEngine = new WorkflowEngine(workflow);


workflowEngine.Run();

public interface IActivity
{
    void Execute();
}

public class UploadVideo : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Uploading video...");
    }
}

public class Notify : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Notifying...");
    }
}

public class Encode : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Encoding...");
    }
}

public class ChangeStatus : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Changing status...");
    }
}


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

public class WorkflowEngine
{
    private readonly Workflow _workflow;
    public WorkflowEngine(Workflow workflow)
    {
        _workflow = workflow;
    }
    public void Run()
    {
        foreach (var activity in _workflow.GetActivities())
        {
            activity.Execute();
        }
    }
}