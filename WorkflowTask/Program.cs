// See https://aka.ms/new-console-template for more information


var activities = new List<IActivity>() { new UploadVideo(), new Encode(), new Notify(), new ChangeStatus() };

var workflow = new Workflow(activities);

//workflow.Add(new UploadVideo());

var workflowEngine = new WorkflowEngine(workflow);


workflowEngine.Run();



