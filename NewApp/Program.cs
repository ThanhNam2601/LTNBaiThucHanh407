// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
Console.WriteLine ("Summer Time Sadness");
Console.WriteLine("Nhap ten cua ban: ");
string ten = Console.ReadLine();
Console.WriteLine("Nhap tuoi cua ban: ");
string tuoi = Console.ReadLine();
Console.WriteLine("Hoc Sinh : " + ten + " Tuoi la:"  + tuoi );*/

/* internal class Program 
{
    private static void Main (string[] args)
    {
        //khai bao bien kieu string va gan gia tri = Nguyen Van A
        const string hoTen = "Nguyen Van A";
        //khai bao bien kieu int va gan gia tri = 8
        const int namLamViec =8;
        Console.WriteLine("Nhan vien {0} - {1} nam kinh nghiem", hoTen,namLamViec);
    }
} */

/* internal class Program {
    private static void Main (string[] args)
    {
        Console.WriteLine("Nhap ten cua ban:    ");
        string ten = Console.ReadLine();
        System.Console.WriteLine("nhap tuoi cua ban:    ");
        string tuoi = Console.ReadLine();
        System.Console.WriteLine("sinh vien {0} - {1} tuoi", ten,tuoi);
    }
} */

//Hang so

/* internal class program 
{
    private static void Main (string [] args)
    {
        //khai bao bien kieu string va gan gia tri = Nguyen Van A
        const string hoTen = "Nguyen Van A";
        //khai bao bien kieu int va gan gia tri = 8
        const int namLamViec =8;
        System.Console.WriteLine("Nhan vien {0} - {1} nam kinh nghiem", hoTen,namLamViec);
    }
} */

//4. CHUYEN DOI KIEU DU LIEU
//4.1 Parse

/* internal class NACC 
{
    private static void Main (string [] args)
    {
        string str = "123";
        int a =int.Parse(str);
        System.Console.WriteLine("a =   " + a);
    }
} */

//4.2 TryParse
/* internal class Program 
{
    private static void Main (string[] args)
    {
        string str ="123";
        int ketQua;
        //bien kiem tra chuyen doi co thanh cong hay khong
        bool kiemtra = false;
        //chuyen doi kieu du lieu
        kiemtra = int.TryParse(str,out(ketQua));
        System.Console.WriteLine("ket qua = " + ketQua);
    }
} */
//4.3 Convert

/* internal class Program 
{
    private static void Main (string[] args)
    {
        string str ="123";
        int a = Convert.ToInt32(str);
        System.Console.WriteLine("a =   " +a);
    }
} */
//5. CAC TOAN TU
//5.1 Toan tu so hoc : phep cong
/* public class program 
{
    private static void Main (string[] args)
    {
        int a,b; //khai bao 2 bien so theo kieu int
        //thong bao cho nguoi dung nhap vao a
        System.Console.Write("a = ");
        //doc du lieu nhap tu ban phim chuyen sang kieu int va gan cho a
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("b = ");
        //doc du lieu nhap tu ban phim chuyen sang kieu int va gan cho b
        b = Convert.ToInt32(Console.ReadLine());
        //in tong a + b ra ngoai man hinh
        System.Console.WriteLine("{0} % {1} = {2}",a,b,a%b);
        
    }
} */
//BTVN : xây dựng ctrinh cho phép nhập vào tt sinh viên, điểm các môn học và tính điểm trung bình của sinh viên.

public class program 
{
    public static void Main (string[] args )
    {
        System.Console.WriteLine("Nhap ten sinh vien:   ");
        string ten = Console.ReadLine();
        System.Console.WriteLine("Nhap ma sinh vien:   ");
        string msv = Console.ReadLine();
        System.Console.WriteLine("Nhap lop sinh vien:   ");
        string lop = Console.ReadLine();
        /* System.Console.WriteLine("Sinh vien {1} - co ma sinh vien la : {2} - hoc lop : {3}", ten,msv,lop); */
                    
        
            int a,b,c,d,e;
            System.Console.Write("diem mon a =  ");
            a = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("diem mon b =  ");
            b = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("diem mon c =  ");
            c = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("diem mon d =  ");
            d = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("diem mon e =  ");
            e = Convert.ToInt32(Console.ReadLine());
            int dtb = (a + b + c + d + e ) /5;
            System.Console.WriteLine("diem trung binh la = ",dtb);
    }
}

