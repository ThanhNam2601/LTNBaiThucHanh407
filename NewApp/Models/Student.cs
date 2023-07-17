namespace NewApp.Models
{
    public class Student 
    {
        public String StudentID { get; set; }
        public String StudentName { get; set; }
        // public int Age { get; set; }
        // public string Address { get; set; }
        
        public void Enterdata()
        {
            System.Console.WriteLine("Nhap ma sinh vien:    ");
            StudentID = Console.ReadLine();
            
            System.Console.WriteLine("Nhap ten sinh vien:   ");
            StudentName = Console.ReadLine();
            // System.Console.WriteLine("Nhap tuoi:    ");
            // Age = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine("Nhap dia chi:   ");
            // Address = Console.ReadLine();
            
            
        }
        
        public void Display()
        {
            // System.Console.WriteLine("Sinh vien :{0} - co ma sinh vien la : {1} - {2} tuoi - dia chi la : {3}", StudentName, StudentID, Age, Address);
            System.Console.WriteLine("Sinh vien :{0} - co ma sinh vien la : {1}", StudentName, StudentID);
        }
        
        /* public Student()
        {
            StudentName = "Nguyen Van A";
            Address = "Ha Noi";
            Age = 20;
        } */
        
    }
}