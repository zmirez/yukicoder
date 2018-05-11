using System;
class Program{
    static void Main(string []args){
        string[]t=(Console.ReadLine()).Split(' ');
        long L=long.Parse(t[0]);
        int K=int.Parse(t[1]);
        Console.WriteLine(Pockey(L,K));

    }
    static int Pockey (long L,int K){
        int count=0;
        while(L>0){
            L=L-2*K;
            if(L<=0)break;
            count++;
        }
        return count*K;
    }
}