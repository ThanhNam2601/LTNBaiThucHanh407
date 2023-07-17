using System.Collections;
using System;
using NewApp.Models;

/* Employee1 NV = new Employee1();
NV.Enterdata();
NV.Display();

Student HS = new Student();
HS.Enterdata();
HS.Display();

Fruit HQ = new Fruit();
HQ.Enterdata();
HQ.Display(); */


/* public class Program
{
    private static void Main (string[] args)
    {
        Student st1 = new Student();
        Student st2 = new Student();
        st1.StudentName ="Nguyen Van A";
        st2.Address = "Ha Noi";
        st1.Display();
        st2.Display();
    }
} */

/* GPT PT = new GPT();
PT.Phuongtrinhbacnhat();
PT.GiaiPTB2(); */

 public class Program 
{
    private static void Main (string[] args)
    {
        ArrayList arrStudent = new ArrayList();
        System.Console.Write("nhap n=   ");
        int n = Convert.ToInt32(Console.ReadLine());
        //NHAP THONG TIN VA ADD VAO ARRAY LIST
        for( int i = 0; i < n; i ++)
        {
            Student std = new Student ();
            std.Enterdata();
            arrStudent.Add(std);
        }
        //HIEN THI THONG TIN TRONG ARRAY LIST
        foreach(Student std in arrStudent)
        {
            std.Display();
        }
        
        //SUA THONG TIN
        System.Console.WriteLine("Nhap thong tin sinh vien muon sua: ");
        string str = Console.ReadLine();
        foreach (Student std in arrStudent)
        {
            if (std.StudentID.Equals(std))
            {
                int intIndex = -1;
                while(intIndex < 0 || intIndex >= n)
                {
                    System.Console.WriteLine("Nhap chi so cua phan tu muon sua: ");
                    intIndex = Convert.ToInt32(Console.ReadLine());
                    //khai bao 1 phan tu Student moi
                    Student stdUpdate = new Student();
                    stdUpdate.Enterdata();
                    //gan phan tu moi vao phan tu co index = intIndex
                    arrStudent[intIndex] = stdUpdate;
                }
                foreach ( Student stdUpdate in arrStudent )
                {
                    stdUpdate.Display();
                }
            }
            
        }

    }
}
