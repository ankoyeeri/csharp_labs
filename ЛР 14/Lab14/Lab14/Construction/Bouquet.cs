using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab14.Construction
{
    [Serializable]
    public class Bouquet : Plant, IPaper
    {
        public string Color { get; set; }   //  Цвет бумаги букета
        public float Price { get; set; }

        [NonSerialized]
        private int nonSerial;

        public Bouquet()
        {
            //this.Color = null;
            //this.Price = 0f;
            //this.nonSerial = 0;
            //this.Name = null;
            //this.Size = 0;
        }

        public Bouquet(string color, float price)
        {
            this.Color = color;
            this.Price = price;
        }

        void IPaper.Note()
        {
            Console.WriteLine("Это букет. Метод унаследован от интерфейса");
        }

        public override void Note()
        {
            Console.WriteLine("Это букет. Метод унаследован от абстрактного класса");
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Color, Price);
        }

        public override string ToString()
        {
            return $"{{{nameof(Color)}={Color}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}
