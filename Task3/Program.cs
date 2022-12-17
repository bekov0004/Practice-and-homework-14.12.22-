int n,cnt=0;
n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if (a[i]>0)
    {
        cnt++;
    }
}
System.Console.Write(cnt+" ");