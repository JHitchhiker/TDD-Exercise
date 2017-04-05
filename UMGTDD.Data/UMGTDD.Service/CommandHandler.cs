namespace UMGTDD.Service
{
    public abstract class CommandHandler
    {
        public CommandHandler Successor { get; set; }
        public abstract void HandleCommand(string command);
        
    }
}