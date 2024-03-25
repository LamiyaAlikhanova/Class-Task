using System.ComponentModel.Design;

namespace Task105A.L1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            bool IsStock=true;

            NoteBook notebook1 = new NoteBook("Asus",0, 2500,16);
            NoteBook notebook2 = new NoteBook("Hp", 20, 2100, 8);

            notebook1.Sale();
            notebook2.ShowFullData();
                
        }
    }

    public class Product 
    {
        public string Name;
        public string Description;
        public int Count;
        public bool IsStock;
        public double Price;

        public  Product(string name, int count, double price)
        {
            this.Name = name;
            this.Count = count;
            this.Price = price;
        }


        
    }

    public class NoteBook : Product
    {
        public byte ram;
        public int storage;

        public NoteBook(string name, int count, double price, byte ram ): base(name, count, price) 
        { 
            this.ram = ram;
            
        }

        public void Sale()
           
        {
            if (Count > 0)
            {
                Count--;
                Console.WriteLine($"name:{Name},count:{Count},price:{Price},byte:{ram}");
            }
            else
            {
                Console.WriteLine("Stokda Mehsul Yoxdur");
            }
        }
        public void ShowFullData()
        {
            if (Count > 0)
            {
                Count--;
                Console.WriteLine($"name:{Name}, description:{Description}, count:{Count}, IsStock:{IsStock}, price:{Price},byte:{ram}");
            }
            else 
            {
                Console.WriteLine("Stokda Mehsul Yoxdur");
            }
        }
        
        

        
    }
}
