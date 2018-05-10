#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

long long int x;

int main()

{

    x = pow(2,32)-1;
    cout << setprecision(20);
    cout<<x<<endl;

    cout<<sizeof(x)<<endl;

    return 0;
}
