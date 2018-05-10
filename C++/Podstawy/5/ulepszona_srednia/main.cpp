#include <iostream>
#include <windows.h>
#include <time.h>
#include <cstdlib>





using namespace std;

int x;

float srednia, suma;

int main()
{
    cout<<"podaj liczbe ocen:";
    cin>>x;

    while (x<=0)
    {
        cout<<"ilosc ocen nie moze byc mniejsza od zera!!!";
        Sleep(5000);
        system("cls");
        cout<<"podaj liczbe ocen:";
        cin>>x;
    }

    float oceny[x];


    for (int i=0; i<x; i++)
    {
        cout<<endl<<"Podaj "<<i+1<<" ocene:";
        cin>>oceny[i];
        suma += oceny[i];
    }

    srednia = (suma/x);

    cout<<endl<<"srednia="<<srednia;


    return 0;
}
