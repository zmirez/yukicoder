using System;
class Program{
    static void Main(string[]args){
        string N=Console.ReadLine();
        string A=Console.ReadLine();
        string[]t=A.Split(' ');
        long[]a=new long[t.Length];
        for(int i=0;i<a.Length;i++){
            a[i]=long.Parse(t[i]);
        }
        int n=int.Parse(N);
        
        //ソート
        for(int i=0;i<n-1;i++){
            for(int j=i+1;j<n;j++){
                if(a[i]>a[j]){
                    long k=a[i];
                    a[i]=a[j];
                    a[j]=k;
                }
            }
        }
        // for(int i=0;i<n;i++){
        //     Console.Write(a[i]);
        // }
        if(n%2==1){
            Console.WriteLine(a[n/2]);
        }else if(n%2==0){
            long sum=a[n/2]+a[n/2-1];
            Console.WriteLine(sum/2.0);
        }
        
    }
}