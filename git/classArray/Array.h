#pragma once
#define Data int

class WrongSize {
	double wrongl;
public:
	WrongSize(double wl) :wrongl(wl) {};
	double errorlen()const {
		return wrongl;
	}
};

class Array {
public:
	Array();
	Array(size_t len);
	Array(const Array& source);
	~Array();
	void addData(Data newdata, Array a);
	Data getData(size_t i)const;
	bool setData(size_t i, Data value);
	bool isEmpty()const;
	bool del(size_t i, Array a);
	size_t getSize();
	void print();
	void fillArr();
	Data operator[] (size_t ind);;
private:
	Data *arr;
	size_t size;
};


