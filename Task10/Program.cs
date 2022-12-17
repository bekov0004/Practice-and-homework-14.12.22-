int n;
n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
int t;
for (int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
t = a[n-1];
for (int i = n-2; i >= 0; i--)
{
      a[i+1]=a[i];
}
a[0]=t;
for (int i = 0; i < n; i++)
{
      System.Console.Write(a[i]+" ");
}