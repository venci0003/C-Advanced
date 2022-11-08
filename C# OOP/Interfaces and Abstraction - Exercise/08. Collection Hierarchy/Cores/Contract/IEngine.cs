using Collection_Hierarchy.IO.Contracts;

namespace Collection_Hierarchy.Cores.Contract
{
    public interface IEngine
    {
        void Run(IReader reader, IWriter writer);
    }
}
