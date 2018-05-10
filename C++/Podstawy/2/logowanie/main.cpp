#include <iostream>

using namespace std;

string login, haslo;

int main()
{
    cout << "Podaj login:" << endl;
    cin >> login;
    cout << "Podaj haslo:" << endl;
    cin >> haslo;

    if((login=="admin")&&(haslo=="szarlotka"))
    {
        cout<<"Udalo sie zalogowac";
    }

    else if ((login!="admin")&&(haslo=="szarlotka"))
    {
        cout<<"podano zly login";
    }
    else if ((login=="admin")&&(haslo!="szarlotka"))
    {
        cout<<"podano zle haslo";
    }
    else
    {
        cout<<"nie mozna sie zalogowac";
    }



    return 0;
}
