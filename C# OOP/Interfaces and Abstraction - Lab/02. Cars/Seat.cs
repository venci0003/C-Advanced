using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        private string color;
        private string model;

        public Seat(string color, string model)
        {
            this.Color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} Seat {Model}";
        }
    }
}
