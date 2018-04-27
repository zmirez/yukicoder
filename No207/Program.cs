using System;

class Program4{
    static void Main(string[]args){
        string N=Console.ReadLine();
        string []t=N.Split(' ');
        long A=long.Parse(t[0]);
        long B=long.Parse(t[1]);
        for(long i=A;i<=B;i++){
            if(i%3==0){
                Console.WriteLine(i);
                continue;
            }
            for(long j=i;j>0;j=j/10){
                if(j%10==3){
                    Console.WriteLine(i);
                    break;
                }
            }
        } 


        
     }
}