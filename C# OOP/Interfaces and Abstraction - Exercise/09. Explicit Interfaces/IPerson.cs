namespace Explicit_Interfaces
{
    public interface IPerson
    {
        string Name { get; }
        int Age { get; }

        string GetName();
    } 
}
