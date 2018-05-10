#include <iostream>
#include <windows.h>

using namespace std;
int x, y;

int main()
{
    for (int i=1; i<=10; i++)
    {
    Sleep(1000);
    system("cls");
    x=(i/2);
    y= i-(2*x);

    if (y==1)
    {
        cout<<"Kocham"<<endl;
    }
    else
    {
        cout<<"Madzie"<<endl;
    }

    }
    system("cls");
    cout << "KOCHAM MADZIE TAK BARDZO" << endl;
    return 0;
}
