namespace P03.Detail_Printer.Models
{
    using P03.Detail_Printer.Models.Contracts;
    using System.Collections.Generic;
    using System.Text;

    public class Manager : Employee, IManager
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; private set; }

        public override string PrintEmployee()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.PrintEmployee());
            foreach (string document in Documents)
            {
                result.AppendLine(document);
            }
            return result.ToString().Trim();
        }
    }
}
