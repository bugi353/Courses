#include <iostream>
#include <cstdlib>
#include <cmath>
#include <cstdio>

using namespace std;

//Napisaæ program znajduj¹cy liczbê najbli¿sz¹ œredniej
//z 5-ciu podanych liczb



int ile;
float suma, srednia;
float m, n;

int main()
{

    cout<<"podaj ilosc liczb:";
    cin>>ile;
    cout<<endl;

    float liczba[ile];

    for (int i = 0;  i<ile; i++)
    {
        cout<<"podaj "<<i+1<<" liczbe:";
        cin>>liczba[i];
    }

    for (int i=0; i<ile; i++)

    {
        suma += liczba[i];

    }

        srednia = (suma/ile);
        m = liczba[0];


    for (int i=1; i<ile; i++)
    {
       if ((fabs(liczba[i]-srednia))<fabs((m-srednia)))
       {
           m = liczba[i];
       }
       else if ((fabs(liczba[i]-srednia))==fabs((m-srednia)))
       {
           n = liczba[i];
       }

    }


    if ((fabs(n-srednia))==fabs((m-srednia)))
    {
        cout<<srednia<<endl;
        cout<<"liczby zlizone to: "<<m<<" i "<<n;
    }
    else
    {
        cout<<srednia<<endl;
        cout<<"liczba zblizona "<<m<<endl;
    }

    return 0;
}
