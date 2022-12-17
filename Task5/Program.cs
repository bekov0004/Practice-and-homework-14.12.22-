int n;
n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if (a[i]>0 && a[i+1]>0 || a[i]<0 && a[i+1]<0)
    {
        System.Console.Write($"{a[i]} {a[i+1]}");
        break;
    }
}