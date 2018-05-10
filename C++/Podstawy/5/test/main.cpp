#include <iostream>

using namespace std;

float dane[5]; float iloczyn=1;

int main()
{
    for (int i=0; i<5; i++)
    {

        cin>>dane[i];
        cout<<endl;

        iloczyn *= dane[i];

    }

     cout << iloczyn << endl;

    return 0;
}
