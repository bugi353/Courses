#include <iostream>

using namespace std;

int a, b, c;
int m;
int ile;

int main()
{
    cout << "Podaj ilosc liczb" << endl;
    cin>>ile;
    cout<<endl;


    // cin>>a>>b>>c; //oddzielone spacja musza byc lub enterem


    int liczba[ile];
    int *wskaznik;
    wskaznik = liczba;

    for (int i =0; i<ile; i++)
    {
        cout<<"podaj "<<i+1<<" liczbe:";
        cin>>*wskaznik;
        cout<<endl;
        cout<<(int) wskaznik<<endl;
        wskaznik++;
    }

    m=liczba[0];

    for (int i=1; i<ile; i++)
    {

    if (liczba[i]>m) m=liczba[i];

    }

        //m = a;
        //if (b>m) m=b;
        //if (c>m) m=c;

    cout<<"najwieksza liczba to: "<<m<<endl;

    return 0;
}
