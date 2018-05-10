#include <iostream>
#include <windows.h>
#include<time.h>
#include<conio.h>

using namespace std;

int t, x;

int main()
{


    time_t t;
    t = time(NULL);

    x = (10*2000000000000);
    cout << t << endl;
    cout << x << endl;
    return 0;
}
