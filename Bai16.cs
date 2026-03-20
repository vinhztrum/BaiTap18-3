

class Program
{
    static void Main()
    {
        Console.WriteLine("Pham Tran Thanh Vinh");
        Console.WriteLine("2415053122248");
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Dictionary<char, int> dict = new Dictionary<char, int>();

        // Duyệt chuỗi bằng for
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }

        List<char> keys = new List<char>(dict.Keys);

        for (int i = 0; i < keys.Count; i++)
        {
            char k = keys[i];
            Console.Write(k + " : " + dict[k] + " ");
        }
    }
}