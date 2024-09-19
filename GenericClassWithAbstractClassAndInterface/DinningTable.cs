using System;

namespace Products{
    public class DinningTable : CProduct{
        #region Data Members
        private int capacity;
        private float length;
        private float width;
        private String description;
        private float price;
        private int rating;
        #endregion

        #region Constructor
        public DinningTable(){
            this.capacity = 6;
            this.length = 6.3f;
            this.width = 7.4f;
            this.description = "Dinning Table";
            this.price = 4200.2f;
            this.rating = 4;
            this.brand = "SM";
            this.type = "furniture";
            this.id = 11051;    
        }
        #endregion

        #region Properties
        public int Capacity{
            get {return capacity;}
            set {capacity = value;}
        }
        public float Length{
            get {return length;}
            set {length = value;}
        }
        public float Width{
            get {return width;}
            set {width = value;}
        }
        public String Description{
            get {return description;}
            set {description = value;}
        }
        public float Price{
            get {return price;}
            set {price = value;}
        }
        public int Rating{
            get {return rating;}
            set {rating = value;}
        }
        public String Brand{
            get {return brand;}
            set {brand = value;}
        }
        public String Type{
            get {return type;}
            set {type = value;}
        }
        public int Id{
            get {return id;}
            set {id = value;}
        }
        #endregion

        #region Override Methods
        public override void DisplayDinningTable(){
            Console.WriteLine("Brand Name - " + brand);
            Console.WriteLine("Product Type - " + type);
            Console.WriteLine("Product Id - " + id);
            Console.WriteLine("Seating Capacity - " + capacity);
            Console.WriteLine("Length - " + length);
            Console.WriteLine("Width - " + width);
            Console.WriteLine("Description - " + description);
            Console.WriteLine("Price - " + price);
            Console.WriteLine("Rating - " + rating);
        }
        #endregion

    }
}