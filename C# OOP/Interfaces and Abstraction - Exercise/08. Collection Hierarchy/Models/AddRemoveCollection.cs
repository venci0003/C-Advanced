namespace Collection_Hierarchy.Models
{
    using Contracts;
    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {
        private int index = 0;
        private string[] array = new string[MAX_LENGHT];
        private int countItems = 0;

        public override int Add(string item)
        {
            if (countItems > 0)
            {
                Shift(array, countItems);
            }
            array[index] = item;
            countItems++;
            return index;
        }

        public virtual string Remove()
        {
            string itemToRemove = array[countItems - 1];
            array[countItems - 1] = null;
            countItems--;
            return itemToRemove;
        }

        protected virtual void Shift(string[] array, int countItems)
        {
            for (int i = countItems; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
        }
    }
}
