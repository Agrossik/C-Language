#include<iostream>
using namespace std;
int main()
{
	int x, y;
	int sucet;
	int odcitanie;
	int delenie;
	int nasobenie;
	cout << "Zadaj prve cislo:";
	cin >> x;
	cout << "Zadaj druhe cislo:";
	cin >> y;
	sucet = x + y;
	odcitanie = x - y;
	nasobenie = x * y;
	delenie = x / y;
	cout << "Sucet je :" << sucet << endl;
	cout << "Rozdiel je :" << odcitanie << endl;
	cout << "Sucin je :" << nasobenie << endl;
	cout << "Podiel je:" << delenie << endl;
	
	
}