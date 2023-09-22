namespace baitap1KT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so luong n: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"so thu {i + 1} :");
                mang[i] = int.Parse(Console.ReadLine());
            }
            int max_value = mang[0];
            int max_index = 0;
            for (int i = 1; i < n; i++)
            {
                if (mang[i] > max_value)
                {
                    max_value = mang[i];
                    max_index = i;
                }
            }
            Console.WriteLine($"phan tu lon nhat trong mang la :{max_value}");
            Console.WriteLine($" vi tri trong mang la : {max_index + 1}.");
            Console.ReadLine(); 
        }
    }
}