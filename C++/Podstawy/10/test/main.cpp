#include <iostream>
#include <time.h>
#include <cstdlib>
#include <cstdio>
#include <cmath>

using namespace std;

int ile;
float m, suma, srednia;


int main()
{


    cout<<"podaj ilosc liczb:";
    cin>>ile;
    cout<<endl;

    float tablica[ile];
    float *wskaznik;
    wskaznik = tablica;


    for (int i = 0;  i<ile; i++)
    {
        cout<<"podaj "<<i+1<<" liczbe:";
        cin>>tablica[i];
    }

    cout<<*wskaznik<<endl;
    cout<<(int)wskaznik<<endl;

    wskaznik+8;
    cout<<(int)wskaznik<<endl;
    cout<<*wskaznik<<endl;



   // suma = 3.1;
   // srednia = 5.5;
  //  cout<<fabs(suma-srednia);






   // cout << "Ile liczb w tablicy: " << endl;
   // cin>>ile;



  //  int *tablica;
  //  tablica = new int[ile];
   // int *wskaznik = tablica;




  //  for (int i=0; i<ile; i++)
 //   {

      //  system("pause");

     //   *wskaznik = i;
    //    *wskaznik+=50;
     //   cout<< tablica[i]<<endl;
   //     cout<< wskaznik<<endl;
   //     cout<< *wskaznik<<endl;
   //     cout<<endl;

   //     wskaznik++;


   // }




    return 0;
}
