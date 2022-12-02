// See https://aka.ms/new-console-template for more information


public abstract partial class DbConnection
{
    public string ConnectionString { get; set; }
    public TimeSpan TimeOut { get; set; }

    public DbConnection(string connectionString)
    {
        if (connectionString == null)
            throw new ArgumentNullException();
        ConnectionString = connectionString;
        Console.WriteLine("Constructor has been called");
    }

    public abstract void Open();
    public abstract void Close();
}
