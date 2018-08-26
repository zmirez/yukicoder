using System;
class Program{
    static void Main(string[]args){
        int N=int.Parse(Console.ReadLine());
        int ken=0;
        int pa=0;
        int count_k=0;
        for(int i=0;i<N;i++){
            if(i==0){
                ken++;
                count_k++;
            }else if(count_k==2){
                pa++;
                count_k=0;
            }else if(pa==1){
                ken++;
                count_k++;
                pa=0;
            }else if((ken+pa)==N){
                break;
            }
            else{
                ken++;
                pa++;
                count_k++;
            } 
        }
        Console.WriteLine(ken+pa);
    }
}