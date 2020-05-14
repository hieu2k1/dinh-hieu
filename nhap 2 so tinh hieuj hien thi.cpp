#include<stdio.h>
#include<iostream>
using namespace std;

int main()
{
	int a,b,hieu=0;
	cout<<"nhap hai so a va b vao tu ban phim";
	cin>>a>>b;
	hieu=a-b;
	cout<<"hieu cua hai so a-b= "<<hieu<<endl;
	if(hieu==a||hieu==b)
	{
		cout<<"hieu bang gia tri ma so da nhap vao"<<endl;
	}
	else
	{
		cout<<"hieu khong bang bat ki gia tri nao da nhap "<<endl;
	}

}
