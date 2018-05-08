using System;
class Program{
    static void Main(string[] args){
        string[]t=(Console.ReadLine()).Split(' ');
        int D=int.Parse(t[0]);
        int P=int.Parse(t[1]);
        Console.WriteLine(D+(int)(D*P/100));
    }
}

