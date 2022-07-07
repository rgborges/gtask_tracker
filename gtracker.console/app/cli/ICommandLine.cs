public interface ICommandLine 
{
    void Run(string[] args);
    void RunInteractive();
}