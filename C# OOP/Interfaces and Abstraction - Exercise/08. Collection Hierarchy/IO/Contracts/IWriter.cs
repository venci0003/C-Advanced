namespace Collection_Hierarchy.IO.Contracts
{
    public interface IWriter
    {
        void WriteLine(object obj);

        void Write(object obj);
    }
}
