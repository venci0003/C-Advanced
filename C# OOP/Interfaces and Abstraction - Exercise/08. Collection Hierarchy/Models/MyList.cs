namespace Collection_Hierarchy.Models
{
    using Contracts;

    public class MyList : AddRemoveCollection, IMyList
    {
        private int index = 0;
        private string[] array = new string[MAX_LENGHT];
        private int countItems = 0;
        public int Used => countItems;

        public override int Add(string item)
        {
            if (countItems > 0)
            {
                base.Shift(array, countItems);
            }
            array[index] = item;
            countItems++;
            return index;
        }
        public override string Remove()
        {
            string elementToRemove = array[index];
            array[index] = default;
            Shift(array, countItems);
            countItems--;
            return elementToRemove;
        }

        protected override void Shift(string[] array, int countItems)
        {
            for (int i = 0; i < countItems; i++)
            {
                array[i] = array[i + 1];
            }
        }
    }
}
