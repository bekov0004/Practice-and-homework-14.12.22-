    int n,cnt=0;
    n = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[n]; 
    for (int i = 0; i < n; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine());
    } 
    for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (a[i] == a[j])
            cnt++;
    }
}
    System.Console.WriteLine("--------------------");
           System.Console.WriteLine(cnt);