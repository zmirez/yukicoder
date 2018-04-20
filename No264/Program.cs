using System;
class Program4{
    static void Main(string[]args){
        string N=Console.ReadLine();
        string []t=N.Split(' ');
        int n=int.Parse(t[0]);
        int k=int.Parse(t[1]);
        if((n-k+3)%3==1){
            Console.WriteLine("Lost");
        }else if((n-k+3)%3==2){
            Console.WriteLine("Won");
        }else{
            Console.WriteLine("Drew");
        }

    }
}