namespace PolyAI2VRChat.Database
{
    public interface IDatabase
    {
        string DatabaseName { get; }
        string DatabasePath { get; }
    }
}