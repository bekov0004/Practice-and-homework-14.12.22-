  int n,c;
    n = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[n]; 
    for (int i = 0; i < n; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine());
    } 
    for (int i = 0; i<n-1; i+=2)
    {
          c = a[i];
          a[i] = a[i + 1];
          a[i + 1] = c; 
    } 
    for (int i = 0; i < n; i++)
    {
          System.Console.Write(a[i]+" ");
    }