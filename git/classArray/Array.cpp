#include "Array.h"
#include <iostream>
#include <ctime>
using namespace std;

Array::Array() {
	arr = nullptr;
	size = 0;
}
Array::Array(size_t len) {
	if (len > 0) {
		arr = new Data[len];
		size = len;
	}
	else throw WrongSize(len);
}
Array::Array(const Array& source) {
	size = source.size;
	arr = new Data[size];
	for (size_t i = 0; i < size; i++) {
		arr[i] = source.arr[i];
	}
}
Array::~Array() {
	if (arr != NULL)
		delete[] arr;
}
void Array::addData(Data newdata, Array a) {
	Data* tmp = new Data[a.getSize()];
	for (size_t i = 0; i < a.getSize(); i++)
		tmp[i] = a.getData(i);
	arr = new Data[size + 1];
	for (size_t i = 0; i < a.getSize(); i++)
		arr[i] = tmp[i];
	arr[size] = newdata;
	size++;
}
Data Array::getData(size_t i)const {
	if (i < size)
		return arr[i];
	return -1;

}
bool Array::setData(size_t i, Data value) {
	if (i >= size) return false;
	arr[i] = value;
	return true;
}
bool Array::isEmpty()const {
	return size == 0;
}
bool Array::del(size_t i, Array a) {
	if (i >= size) return false;
	Data *tmp = new Data[size - 1];
	for (size_t j = 0; j < i; j++)
		tmp[j] = a.getData(j);
	for (size_t j = i; j < a.getSize() - 1; j++)
		tmp[j] = a.getData(j + 1);
	arr = new Data[--size];
	for (size_t j = 0; j < size; j++) {
		arr[j] = tmp[j];
	}
	return true;
}
size_t Array::getSize() {
	return size;
}
void Array::print() {
	if (size != 0)
		for (size_t i = 0; i < size; i++)
			cout << arr[i] << " ";
	cout << endl;
}
void Array::fillArr() {
	srand(time(NULL));
	if (size != 0)
		for (size_t i = 0; i < size; i++)
			arr[i] = rand() % 100 + 1;
}
Data Array::operator[] (size_t ind) {
	return *(arr + ind);
}
