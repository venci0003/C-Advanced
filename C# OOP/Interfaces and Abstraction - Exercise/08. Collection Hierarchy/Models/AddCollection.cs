namespace Collection_Hierarchy.Models
{
    using Contracts;
    public class AddCollection : IAddCollection
    {
        protected const int MAX_LENGHT = 100;
        private int index = -1;
        private string[] array = new string[MAX_LENGHT];

        public virtual int Add(string item)
        {
            array[++index] = item;
            return index;
        }
    }
}
