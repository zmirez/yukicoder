using System;
class Program{
    static void Main(string [] args){
        int L=int.Parse(Console.ReadLine());
        int N=int.Parse(Console.ReadLine());
        string[]W=(Console.ReadLine()).Split(' ');
        int []w=new int[W.Length];
        int count=0;
        for(int i=0;i<N;i++){
            w[i]=int.Parse(W[i]);
        }
        for(int i=0;i<N-1;i++){
            for(int j=i+1;j<N;j++){
            if(w[i]>w[j]){
                int t=w[i];
                w[i]=w[j];
                w[j]=t;
            }
            }
        }
        for(int i=0;i<N;i++){
            L=L-w[i];
            if(L<0){
                Console.WriteLine(count);
                break;
            }else if(i==N-1)Console.WriteLine(count+1);
            count++;
        }
    }
}