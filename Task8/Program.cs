int n,cnt=1;
n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i]=Convert.ToInt32(Console.ReadLine());
}
Array.Sort(a);
for (int i = 0; i < n-1; i++)
{
    if(a[i] != a[i+1]){ 
    cnt++; 
    }

} 
System.Console.WriteLine("----------------------------");
    System.Console.WriteLine(cnt);