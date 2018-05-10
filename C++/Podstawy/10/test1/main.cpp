#include <iostream>

using namespace std;

int ile;


int main()
{
    cout << "wprowadz ile:" << endl;
    cin>>ile;

    int *tablica;
    tablica = new int[ile];

    for (int i=0; i<ile; i++)
    {
        tablica[i] = i;
        cout<<tablica[i]<<endl;
    }



    return 0;
}
