using System;
class Program{
    static void Main(string []args){
        int n=int.Parse(Console.ReadLine());
        for(int i=0;;i++){
            if(Math.Pow(2,i)>=n){
                Console.WriteLine(i);
                break;
            }
        }
    }
}