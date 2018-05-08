using System;
class Program{
    static void Main(string[]args){
        string[]t=(Console.ReadLine()).Split(' ');
        int K=int.Parse(t[0]);
        int N=int.Parse(t[1]);
        int F=int.Parse(t[2]);
        string[]a=(Console.ReadLine()).Split(' ');
        int[]A=new int[a.Length];
        int sum=K*N;
        for(int i=0;i<a.Length;i++){
            A[i]=int.Parse(a[i]);
            sum-=A[i];
            
        }
        if(sum<0){
            Console.WriteLine(-1);
        }else Console.WriteLine(sum);
       
        
    }
}