using System;
class Program{
    static void Main(string[]args){
        long N=int.Parse(Console.ReadLine());
        string[]t=Console.ReadLine().Split(' ');
        long[]a=new long[t.Length];
        long count=0;
        long div=0;
        for(int i=0;i<t.Length;i++){
            a[i]=int.Parse(t[i]);
        }
        if(a[2]%a[0]==0 && a[1]%a[0]==0 ){
            count=N/a[0];
        }else if(a[2]%a[1]==0 || a[2]%a[0]==0){
            div=N/(lcm(a[0],a[1]));
            count=N/a[1]+N/a[0]-div;
        }else if(a[1]%a[0]==0){
            div=N/(lcm(a[0],a[2]));
            count=N/a[2]+N/a[0]-div;
        }else{
            div =N/lcm(a[0],a[1])+N/lcm(a[0],a[2])+N/lcm(a[1],a[2]);
            //Console.WriteLine((a[0]*a[1]*a[2]));
            count=N/a[0]+N/a[1]+N/a[2]-div+N/(lcm(a[0],lcm(a[1],a[2])));
            //count=N/a[0]+N/a[1]+N/a[2]-div+N/(a[0]*a[1]*a[2]);
            
        }
        
        Console.WriteLine(count);
    }
    //Å‘åŒö”{”‚ð‹‚ß‚é
    static long lcm(long n,long m){
        //n<m
        return m*n/gcd(n,m);


    }
    //Å‘åŒö–ñ”
    static long gcd(long n,long m){
        //n<m
        long r=0;
        while(true){
            r=m%n;
            if(r==0){
                //Console.WriteLine(n);
                return n;
            }
            m=n;
            n=r;
        }
    }
}