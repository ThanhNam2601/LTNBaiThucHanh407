namespace NewApp.Models
{
    public class Fruit 
    {
        public String FruitID { get; set; }
        public String FruitName { get; set; }
        public int Price { get; set; }
        public void Enterdata()
        {
            System.Console.WriteLine("Nhap ma hoa qua:    ");
            FruitID = Console.ReadLine();
            
            System.Console.WriteLine("Nhap ten hoa qua:   ");
            FruitName = Console.ReadLine();
            System.Console.WriteLine("Nhap gia:    ");
            Price = Convert.ToInt32(Console.ReadLine());         
        }
        
        public void Display()
        {
            System.Console.WriteLine("Loai hoa qua :{0} - co ma hoa qua la : {1} - co gia la : {3}", FruitName,FruitID,Price);
        }
    }
}