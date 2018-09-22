using System;
class Program{
    static void Main(string[]args){
        int N=int.Parse(Console.ReadLine());
        string[]t=Console.ReadLine().Split(' ');
        int []a=new int[t.Length];
        long sum=0;
        int tsuru=0;
        int turtle=0;
        for(int i=0;i<t.Length;i++){
            a[i]=int.Parse(t[i]);
            sum+=a[i];
        }
        sum=sum/(a.Length-1);
        for(int i=0;i<t.Length;i++){
            if(sum-a[i]==2){
                tsuru++;
            }else if(sum-a[i]==4){
                turtle++;
            }
        }
        Console.WriteLine(tsuru+" "+turtle);
        
    }
}