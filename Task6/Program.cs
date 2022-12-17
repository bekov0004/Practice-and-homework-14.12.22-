int n;
n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i]=Convert.ToInt32(Console.ReadLine());
}
Array.Sort(a);
for (int i = 0; i < n; i++)
{
    if(a[i]>0){
    System.Console.WriteLine(a[i]);
    break;
    }
}