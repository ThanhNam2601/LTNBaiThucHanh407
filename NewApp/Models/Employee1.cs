namespace NewApp.Models
{
    public class Employee1 
    {
        public String Employee1ID { get; set; }
        public String Employee1Name { get; set; }
        public int Age { get; set; }
        public decimal wage { get; set; }
        
        public void Enterdata()
        {
            System.Console.WriteLine("Nhap ID nhan vien:    ");
            Employee1ID = Console.ReadLine();
            
            System.Console.WriteLine("Nhap ten nhan vien:   ");
            Employee1Name = Console.ReadLine();
            
            System.Console.WriteLine("Nhap tuoi:    ");
            Age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhap so tien luong:   ");
            wage = Convert.ToDecimal(Console.ReadLine());
            
        }
        
        public void Display()
        {
            System.Console.WriteLine("Nhan vien {0} - co ma nhan vien la {1} - {2} tuoi - so tien luong la {3}", Employee1Name, Employee1ID, Age, wage);
        }
    }
}