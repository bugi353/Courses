#include <iostream>
#include <cstdlib>
#include <time.h>

using namespace std;

int liczba, strzal, ile_prob=0;

int main()
{
    cout << "Witaj! Pomyslalem sobie liczbe z zakresu 1...100" << endl;
    srand(time(NULL));
    liczba=rand()%100+1;


    while(strzal!=liczba)
    {
        ile_prob++;
        cout<<"Zgadnija jaka ( to Twoja"<<ile_prob<<"proba)";
        cin>>strzal;

        if(strzal==liczba)
        {
            cout<<"Udalo sie! Wygrywasz w"<<ile_prob<<"proba"<<endl;
        }
        else if(strzal<liczba)
        {
            cout<<"To za malo"<<endl;
        }
        else if(strzal>liczba)
        {
            cout<<"To za duzo"<<endl;
        }
    }

    system("pause");

    return 0;
}
