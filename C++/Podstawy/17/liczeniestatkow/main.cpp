#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;

float metal, deuter, krysztal, km=20000, kk = 7000, kd = 2000;
float statki;
float a, b, c;
float m;

int main()
{
    cout << "Podaj ilosc metalu" << endl;
    cin>>metal;
    cout << "Podaj ilosc krysztalu" << endl;
    cin>>krysztal;
    cout << "Podaj ilosc deuteru" << endl;
    cin>>deuter;

    a = trunc(metal/km);
    b = trunc(krysztal/kk);
    c = trunc (deuter/kd);

    if (a==0) {cout<<"masz za malo metalu";}
    else if (b==0) {cout<<"masz za malo krysztalu";}
    else if (c==0) {cout<<"masz za malo deuteru";}
    else if (krysztal<0||deuter<0||metal<0) {cout<<"bledne dane";}
    else if (a>=b && a>=c)
    {
        cout<<"liczba statkow"<<a<<endl;
    }
    else if (b>=a && b>=c)
    {
        cout<<"liczba statkow"<<b<<endl;
    }
    else if (c>=a && c>=b)
    {
        cout<<"liczba statkow"<<c<<endl;
    }


    return 0;
}  //niedokonczone i bledne
