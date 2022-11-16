using System.Text;
using System;
using System.Reflection;
using System.Linq;

namespace _01._Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] parameters)
        {
            StringBuilder result = new StringBuilder();

            Type classType = Type.GetType(className);

            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            result.AppendLine($"Class under investigation: {classType.FullName}");

            foreach (FieldInfo field in fields.Where(x => parameters.Contains(x.Name)))
            {
                result.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return result.ToString().Trim();
        }
    }
}
