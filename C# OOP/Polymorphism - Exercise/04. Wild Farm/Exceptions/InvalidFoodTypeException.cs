namespace WildFarm.Exceptions
{
    using System;

    public class InvalidFoodTypeException : Exception
    {
        private const string DefaultMessage = "Invalid food type!";

        public InvalidFoodTypeException()
            : base(DefaultMessage)
        {

        }

        public InvalidFoodTypeException(string message)
            : base(message)
        {

        }
    }
}
