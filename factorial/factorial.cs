using System;
class Program{
    static void Main(string[]args){
        string N=Console.ReadLine();
        double A=double.Parse(N);
        Console.WriteLine(fac(A));


    }

    public static double fac(double x){
        if(x==1){
            return 1;
        }else{
        double k=x*fac(x-1);
        return k;
        }
    }
}