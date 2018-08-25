using System;

class Program{
    static void Main(string[]args){
        string[]t=Console.ReadLine().Split(' ');
        int[]A=new int[t.Length];
        for(int i=0;i<t.Length;i++){
            A[i]=int.Parse(t[i]);
        }
        int count=0;
        for(int i=0;i<A.Length-1;i++){
            for(int j=i+1;j<A.Length;j++){
                if(A[i]==A[j]){
                    count++;
                }
            }
        }
        if(count==4){
            Console.WriteLine("FULL HOUSE");
        }else if(count==3){
            Console.WriteLine("THREE CARD");
        }else if(count==2){
            Console.WriteLine("TWO PAIR");
        }
        else if(count==1){
            Console.WriteLine("ONE PAIR");
        }else{
            Console.WriteLine("NO HAND");
        }
    }
}