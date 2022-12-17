int[] a =  new int[8];
int[] b =  new int[8];
for (int i = 0; i < 8; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
    b[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 7; i++)
{
    if(a[i]-a[i+1]==0 || b[i]-b[i+1]==0 || Math.Abs(a[i]-a[i+1])==Math.Abs(b[i]-b[i+1]))
    {
        System.Console.WriteLine("YES");
        break;
    }
    else{
    System.Console.WriteLine("NO");
    break;
    }
}