#include <iostream>

using namespace std;

//struct‚Ípublic class‚Íprivate
struct s{
    double A,B;
};

int main(){
    int n,A,B;
    cin >> n;
    struct s frac[n];
    double f[n];
    for(int i=0;i<n;i++){
        cin >> frac[i].A >> frac[i].B;
        
    }
    for(int j=0;j<n;j++){
        for(int i=0;i<n-1;i++){
            if(frac[i].A/frac[i].B<frac[i+1].A/frac[i+1].B){
                int a=frac[i].A;
                int b=frac[i].B;
                frac[i].A=frac[i+1].A;
                frac[i].B=frac[i+1].B;
                frac[i+1].A=a;
                frac[i+1].B=b;
            }
        }

    }
    
    for(int i=0;i<n;i++){
        cout << frac[i].A <<" "<< frac[i].B <<endl;
    }
    return 0;
}