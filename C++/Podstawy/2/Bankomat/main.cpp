#include <iostream>

using namespace std;

string PIN;
int kasa;

int main()
{
    cout << "Witaj w naszym banku!" << endl<<endl;
    cout << "Podaj numer PIN:";

    cin >> PIN;

    if(PIN=="1729")
    {
        cout<<"Poprawny PIN" << endl<<endl;
        cout<<"Ile chcesz wyplacic:";
        cin>>kasa;
        if(kasa<50)
        {
            cout<<"zbyt maly nominal";
        }
        else
        {
            cout<<"wyplacam pieniazki";
        }
    }
    else
    {
        cout<<"Niepoprawny PIN";
    }


    return 0;
}
