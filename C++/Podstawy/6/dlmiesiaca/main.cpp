#include <iostream>
#include <conio.h>
#include <cstdlib>

using namespace std;
int nr_msc;

int main()
{
    cout << "Podaj nr miesiaca:";
    if(!(cin>>nr_msc));
    {
        cerr<<"To nie jest liczba!";
        exit(0);
    }

    switch(nr_msc)
    {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            cout<<"Ten miesiac ma 31dni!";
        break;

        case 4:
        case 6:
        case 9:
        case 11:
            cout<<"Ten miesiac ma 30dni!";
        break;

        case 2:
            {
              int rok;
              cout<<"Podaj rok: ";
              cin>>rok;

              if (((rok%4 == 0) && (rok%100 != 0)) || (rok%400==0))
            {
                cout<<"Ten miesiac ma 29dni!";
            }
                else
                {
                    cout<<"Ten miesiac ma 28dni!";
                }


            }
            break;

            default: cout<<"Niepoprawny numer miesiaca";
    }





    return 0;
}
