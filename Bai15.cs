Console.WriteLine("PhamTranThanhVinh");
Console.WriteLine("2415053122248");
Dictionary<string, string> dict = new Dictionary<string, string>();
Console.Write("Nhap so tu: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("Nhap tu Anh: ");
    string eng = Console.ReadLine();

    Console.Write("Nhap nghia: ");
    string vie = Console.ReadLine();

    dict[eng] = vie;
}
Console.WriteLine();
Console.Write("Nhap tu can tra: ");
string key = Console.ReadLine();

if (dict.ContainsKey(key))
{
    Console.WriteLine("Nghia: " + dict[key]);
}
else
{
    Console.WriteLine("Khong tim thay!");
}