#include <iostream>
#include <ctime>
#include "Array.h"
#define Data int
using namespace std;


int main() {
	cout << "Enter size of array: ";
	size_t n;
	cin >> n;
	Array arr(n);
	arr.fillArr();
	cout << "Array ";
	arr.print();
	if (arr.isEmpty())
		cout << "Array is empty\n";
	else
		cout << "Array is full\n";
	cout << "Size of array " << arr.getSize();
	cout << "\nValue of 8 element " << arr.getData(7) << endl;
	if (arr.setData(1, 13)) {
		cout << "Changed array: ";
		arr.print();
	}
	arr.addData(13, arr);
	cout << "New array: ";
	arr.print();
	arr.del(1, arr);
	cout << "\nArray after delete: ";
	arr.print();
	Array newarr(arr);
	cout << "Copy of array: ";
	newarr.print();
	cout << endl;
	system("pause");
	return 1;
}