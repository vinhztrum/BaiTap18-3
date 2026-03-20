using System.ComponentModel.DataAnnotations;
using System.Data;

class hocsinh
{
   
    public string ten;
    public double diem;
}
class programe
{
    static void Main()
    {
        Console.WriteLine("PhamTranThanhVinh");
        Console.WriteLine("2415053122248");
        Console.WriteLine("Nhap so sinh vien");
        int n = int.Parse(Console.ReadLine());
        hocsinh[] a = new hocsinh[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = new hocsinh();
           
            Console.WriteLine("Nhap ten");
            a[i].ten = Console.ReadLine();
            Console.WriteLine("Nhap diem so");
            a[i].diem = double.Parse(Console.ReadLine());

        }
        Console.WriteLine("Danh sach sinh vien:");
        for (int i = 0; i < n; i++)
        {
            
            Console.WriteLine("Ten sinh vien : " + a[i].ten);
            Console.WriteLine("diem so sinh vien : " + a[i].diem);
        }
        double max = a[0].diem;
        for (int i = 0; i < n; i++)
        {
            if (a[i].diem >= max)
                max = a[i].diem;
        }
        Console.WriteLine("Sinh vien co diem cao nhat la");
        for (int i = 1; i < n; i++)
        {
            if (a[i].diem == max)
            {
                Console.WriteLine("Ten sinh vien : " + a[i].ten);
                Console.WriteLine("diem so sinh vien : " + a[i].diem);
                
            }
        }
    }
}