#include <iostream>
#include <time.h>
#include <windows.h>
#include <fstream>
#include <cstdlib>


using namespace std;

string slowo;
int nr_linii=0;
int saldo=3000,wyplata;

int main()
{


    cout<<saldo<<endl;

    cin>>wyplata;

    saldo = saldo - wyplata;

    cout<<saldo<<endl;





    return 0;
}
