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
int k = 0;
int[] b = new int[n];

for (int i = 0; i < n; i++)
{
    int s = 0;

    for (int j = 0; j < i; j++)
    {
        if (a[i] == a[j])
        {
            s++;
            break;
        }
    }

    if (s == 0)
    {
        b[k] = a[i];
        k++;
    }
}
;
Console.WriteLine();
Console.WriteLine("day sau Khi loai bo phan tu trung ");
for (int i = 0; i < k; i++)
{
    Console.Write(b[i] + (" "));
}