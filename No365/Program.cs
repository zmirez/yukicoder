using System;
 class Program{
     static void Main(string[]args){
         int N=int.Parse(Console.ReadLine());
         string[]t=Console.ReadLine().Split(' ');
         int[]a=new int[N];
         int count=0;
         int y=0;
         int max=0;
         for(int i=0;i<N;i++){
             a[i]=int.Parse(t[i]);
         }
         for(int i=0;i<N;i++){
             if(y<a[i]){
                 y=a[i];
             }else{
                 max=Math.Max(max,a[i]);
             }
         }
         for(int i=0;i<N;i++){
             if(a[i]<=max)count++;
         }
         Console.WriteLine(count);

         
     }
 }