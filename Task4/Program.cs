int n;
n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n-1; i++)
{
    if (a[i+1]>a[i])
    {
        System.Console.Write(a[i+1]+" ");
    }
}