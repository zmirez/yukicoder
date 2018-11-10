using System;
class Program{
    static void Main(string[]args){
        int N=int.Parse(Console.ReadLine());
        if(N%2==1){
            Console.Write("7");
            for(int i=0;i<N/2-1;i++){
                Console.Write("1");
            }
            Console.WriteLine();
        }else if(N%2==0){
            for(int i=0;i<N/2;i++){
                Console.Write("1");
            }
            Console.WriteLine();
        }
    }
} 