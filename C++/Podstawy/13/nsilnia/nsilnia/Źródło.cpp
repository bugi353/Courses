#include <iostream>
#include <time.h>
#include <cstdlib>

using namespace std;

clock_t start, stop;
double czas;
int w;
int x=1;

long int silnia(int n)
{
	if (n == 0) return 1;
	else return silnia(n-1) + 1;


}

long int silniait(int n)
{
	if (n == 0)
	{
		return 1;
	}
	else
	{
		

		for (int i = 1; i <= n; i++)
		{
			x += 1;

		}
		return x;
	}

}


int main()
{
	cin >> w;

	start = clock();

	cout << silnia(w)<<endl;

	stop = clock();

	czas = (double)(stop - start) / CLOCKS_PER_SEC;
	cout << "czas rekurencji: " << czas << endl;


	start = clock();

	cout << silniait(w) << endl;


	stop = clock();

	czas = (double)(stop - start) / CLOCKS_PER_SEC;
	cout << "czas rekurencji: " << czas << endl;

	system("pause");
}