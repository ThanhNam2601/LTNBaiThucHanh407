namespace NewApp.Models
{
    public class Person : Student 
    {
        public string Personcode { get; set; }
        
        public void Enterdata()

        {
            //ke thua Student
            base.Enterdata();
            //phat trien them nhap thong tin
            System.Console.Write("Person code = ");
            Personcode = Console.ReadLine();
            
        }

        public void Display()
        {
            base.Display();
            System.Console.Write("- Ma person: {0}", Personcode);
        }

        public void makeArr()
        {
            System.Console.Write("Nhap vao so luong cac lop trong truong :    ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] stdArr = new int [n];
            for (int i = 0; i < stdArr.Length; i++)
            {
                System.Console.Write("Nhap so sinh vien lop {0} =   ",i+1);
                int m = Convert.ToInt32(Console.ReadLine());
                stdArr[i] = m;
            }
            for (int i = 0; i < stdArr.Length; i++)
            {
                System.Console.Write(stdArr[i] + "\t");
            }
        }
    }
}