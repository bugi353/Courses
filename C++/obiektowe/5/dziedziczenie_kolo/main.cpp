#include <iostream>
#include <math.h>

using namespace std;

class Punkt
{
    float x,y;
    string nazwa;

public:
    void wyswietl()
    {
        cout<<nazwa<<"("<<x<<","<<y<<")"<<endl;
    }
    Punkt(string n="S", float a=0, float b=0)
    {
            nazwa = n;
            x = a;
            y = b;
    }
};

class Kolo:public Punkt
{
    protected:
        float r;
        string nazwa;

public:
    void wyswietl()
    {

        cout<<"Kolo o nazwie: "<<nazwa<<endl;
        cout<<"Srodek kola: ";
        Punkt::wyswietl();
        cout<<"Promien: "<<r<<endl;
        cout<<"Pole kola: "<<M_PI*r*r<<endl;
    }
    Kolo(string nk="Kolko", string np="S", float a=0, float b=0, float pr=1)
    :Punkt(np,a,b)
    {
        nazwa = nk;
        r = pr;
    }

};

class Kula:public Kolo
{
    string nazwa;

public:
    void wyswietl()
    {
        cout<<"Kula o nazwie: "<<nazwa<<endl;
        Kolo::wyswietl();
        cout<<"Objetosc kuli: "<<(4*M_PI*r*r*r)/3<<endl;

    }
    Kula(string nku="Kula", string nk="Kolko", string np="S", float a=0, float b=0, float r=1)
    :Kolo(nk, np, a, b, r)
    {
        nazwa=nku;
    }




};

int main()
{
    Kula k1;
    k1.wyswietl();







    return 0;
}
