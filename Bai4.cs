Console.WriteLine("PhamTranThanhVinh");
Console.WriteLine("2415053122248");
Console.WriteLine("nhap so phan tu");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap so phan tu" + (i + 1));
    a[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Danh sach:");
for (int i = 0; i < n; i++)
{
    Console.Write(a[i] + (" "));
}
int dem = 0;
for (int i = 0; i < n; i++)
    if (a[i]% 2  ==0)
    {
        dem++; 
    }
Console.WriteLine("so phan tu chan la "+dem);