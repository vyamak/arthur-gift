internal class DadContext : IDisposable
{
    public DadContext()
    {
    }

    public object Database { get; internal set; }
    public object Children { get; internal set; }
}
