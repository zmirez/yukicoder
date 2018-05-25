using System;
class Program{
    static void Main(string[]args){
        double x=int.Parse(Console.ReadLine());
        double y=int.Parse(Console.ReadLine());
        double l=int.Parse(Console.ReadLine());
        if(y>=0&&x==0){
            Console.WriteLine(Math.Ceiling(y/l));
        }else if(y>=0&&Math.Abs(x)>0){
            Console.WriteLine(Math.Ceiling(y/l)+1+Math.Ceiling(Math.Abs(x)/l));
        }else if(y<0){
            Console.WriteLine(Math.Ceiling(Math.Abs(y)/l)+2+Math.Ceiling(Math.Abs(x)/l));
        }
    }
    
}