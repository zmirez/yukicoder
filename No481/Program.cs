using System;
class Program{
    static void Main(string [] args){
        string []B=Console.ReadLine().Split(' ');
        int[]b=new int[B.Length];
        for(int i=1;i<=b.Length;i++){
            b[i-1]=int.Parse(B[i-1]);
            if(b[i-1]!=i){
                Console.WriteLine(i);
                break;
            }else if(i==b.Length){
                Console.WriteLine(i+1);
                break;
            }
        }
    }
}