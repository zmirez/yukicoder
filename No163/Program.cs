using System;

class Program{
    static void Main(string[]args){
        string N=Console.ReadLine();
        
        char []a=N.ToCharArray();
        for(int i=0;i<a.Length;i++){
            if(char.IsUpper(a[i])){
                a[i]=char.ToLower(a[i]);
            }else{
                a[i]=char.ToUpper(a[i]);
            }
            Console.Write(a[i]);
        }
    }
}