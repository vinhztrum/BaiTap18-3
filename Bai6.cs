Console.WriteLine("PhamTranThanhVinh");
Console.WriteLine("2415053122248");
Console.WriteLine("nhap so phan tu");
int n = int.Parse(Console.ReadLine());
string[] a = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap ten hoc sinh" + (i + 1));
    a[i] = Console.ReadLine();
}
Console.WriteLine("Danh sach :");
for (int i = 0; i < n; i++)
{
    Console.Write(a[i] + (" "));
}
Console.WriteLine();
Console.Write("Nhap ten can kiem tra: ");
string x = Console.ReadLine();
int s = 0;
for (int i = 0; i < n; i++)
{
    if (a[i] == x)
    {
        s = s + 1;
        break;
    }

}
if (s == 0)
    Console.WriteLine("Khong co ten");
else
    Console.WriteLine("Co ton tai");
