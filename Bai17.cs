Console.WriteLine("PhamTranThanhVinh");
Console.WriteLine("2415053122248");
Console.WriteLine("Nhap so phan tu");
int n=int.Parse(Console.ReadLine());
int[] a=new int[n];
for(int i=0; i<n; i++)
{
    Console.WriteLine("Nhap phan tu thu "+(i+1));
    a[i]=int.Parse(Console.ReadLine());
}
int so = a[0];

int demnhieu = 0;
for(int i = 0; i < n; i++) { 
    int dem = 0;
for (int j=0;j<n;j++)
    {
        
        if (a[i]==a[j])
            dem=dem+1;
        if (dem > demnhieu)
        {
            demnhieu = dem;
            so = a[i];
        }
    }
}
Console.WriteLine("So xuat hien nhieu nhat la " + so);

Console.WriteLine("Voi so lan xuat hien la " + demnhieu);

