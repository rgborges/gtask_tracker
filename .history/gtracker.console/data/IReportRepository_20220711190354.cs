namespace gtracker.console.data 
{
    public interface  IReportRepository <T>
    {
        void Save();
        T Read()
    }
}