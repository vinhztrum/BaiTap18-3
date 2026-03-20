class hocsinh
{
    public int id;
    public string ten;
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
            Console.WriteLine("Nhap ma so");
            a[i].id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten");
            a[i].ten = Console.ReadLine();

        }
        Console.WriteLine("Danh sach sinh vien:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Ma so sinh vien : " + a[i].id);
            Console.WriteLine("Ten sinh vien : " + a[i].ten);
        }
    }
};