#include <iostream>

using namespace std;

int uczniowie, cukierki, x, y;

int main()
{
    cout << "Ilu uczniow jest w twojej klasie:";
    cin >> uczniowie;

    cout << "Ile cukierkow kupila mama:";
    cin >> cukierki;

    x = cukierki/(uczniowie-1);

    cout<<"cukierkow dla kazdego ucznia:"<<x;

    y = cukierki-x*(uczniowie-1);

    cout<<endl<<"Dla Jasia na wieczor pozostalo:"<<y<<"cukierkow";


    return 0;
}