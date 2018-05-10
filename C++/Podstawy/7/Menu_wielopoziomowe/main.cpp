#include <iostream>
#include <windows.h>
#include <conio.h>
#include <cstdlib>
#include <time.h>
#include <stdio.h>

using namespace std;

int wybor;

int main()
{
    while (true)

    {


    cout<< "Witaj w menu"<<endl;
    cout<<endl;

    cout<<"1. Nowa gra"<<endl;
    cout<<"2. Opcje"<<endl;
    cout<<"3. Wiadomoœci"<<endl;
    cout<<"4. Tutorial"<<endl;
    cout<<"5. Wyjscie"<<endl;

    wybor = getch();

    switch (wybor)
    {
    case '1':
        {
            system("cls");
        cout<<"1. Latwy"<<endl;
        cout<<"2. Sredni"<<endl;
        cout<<"3. Trudny"<<endl;
        cout<<"4. Powrot do menu glownego"<<endl;

            wybor = getch();
            switch(wybor)
            {


            case '1':
                {
                    system("cls");
                    cout<<"Gra rozpoczeta";
                    getchar(); getchar();
                    system("cls");


                }
            break;

            case '2':
                {
                    system("cls");
                    cout<<"Gra rozpoczeta";
                    getchar(); getchar();
                    system("cls");
                }
            break;

            case '3':
                {
                    system("cls");
                    cout<<"Gra rozpoczeta";
                    getchar(); getchar();
                    system("cls");
                }
            break;

            case '4':
                {
                    system("cls");

                }
            break;
            }

        }
    break;

    case '2':
        {
            cout<<"pozniej";
        }
    break;

    case '3':
        {
            cout<<"pozniej";
        }
    break;

    case '4':
        {
            cout<<"pozniej";
        }
    break;

    case '5':
        {
                exit(0);
        }
    break;

    default:
    {
        system("cls");
        cout<<"nie ma takiej opcji"<<endl;
        Sleep(3000);
        system("cls");

    }
    break;







    }






    }


    return 0;
}
