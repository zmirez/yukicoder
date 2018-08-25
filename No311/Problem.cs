using System;

class Program{
    static void Main(string[]args){
        long N=long.Parse(Console.ReadLine());
        Console.WriteLine(FizzBuzzString(N));

    }
    public static long FizzBuzzString(long N){
        long count=0;
        long div_t=N/3;
        long div_f=N/5;
        count=(div_f+div_t)*2;
        return count;
    }
}