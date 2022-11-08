namespace Collection_Hierarchy.Cores
{
    using IO.Contracts;
    using Cores.Contract;
    using Collection_Hierarchy.Models;
    using System.Text;

    public class Engine : IEngine
    {
        public void Run(IReader reader, IWriter writer)
        {
            string[] array = reader.ReadLine().Split();

            AddCollection addCollection = new AddCollection();

            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();

            MyList myList = new MyList();

            StringBuilder addCollectionStringBuilder = new StringBuilder();

            StringBuilder addRemoveCollectionStringBuilder = new StringBuilder();

            StringBuilder myListStringBuilder = new StringBuilder();

            StringBuilder addRemoveCollectionRemoveStringBuilder = new StringBuilder();

            StringBuilder myListRemoveStringBuilder = new StringBuilder();

            int operationsCount = int.Parse(reader.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                addCollectionStringBuilder.Append($"{addCollection.Add(array[i])} ");
                addRemoveCollectionStringBuilder.Append($"{addRemoveCollection.Add(array[i])} ");
                myListStringBuilder.Append($"{myList.Add(array[i])} ");
            }

            for (int i = 0; i < operationsCount; i++)
            {
                addRemoveCollectionRemoveStringBuilder.Append($"{addRemoveCollection.Remove()} ");
                myListRemoveStringBuilder.Append($"{myList.Remove()} ");
            }


            writer.WriteLine(addCollectionStringBuilder.ToString());
            writer.WriteLine(addRemoveCollectionStringBuilder.ToString());
            writer.WriteLine(myListStringBuilder.ToString());
            writer.WriteLine(addRemoveCollectionRemoveStringBuilder.ToString());
            writer.WriteLine(myListRemoveStringBuilder.ToString());
        }
    }
}
