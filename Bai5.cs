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
Console.Write("Nhap ten can xoa: ");
string[] b = new string[n];
string x = Console.ReadLine();
int k = 0;
for (int i = 0; i < n; i++)
{
    if (a[i] != x)
    {
        b[k] = a[i];
        k++;
    }

}
Console.WriteLine("Danh sach sau khi xoa :");
for (int i = 0; i < k; i++)
{
    Console.Write(b[i] + (" "));
}