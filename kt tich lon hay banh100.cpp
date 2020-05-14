#include <stdio.h>
#include<iostream>

using namespace std;
int main()
{
	int a,b,tich=1;
	cout<<"nhap hai so a va b vao tu ban phim";
	cin>>a>>b;
	tich=a*b;
	cout<<"tich cua hai so a*b= "<<tich<<endl;
	if(tich==1000)
	{
		cout<<"tich hai so bang 1000"<<endl;
	}
	else if(tich>1000)
	{
		cout<<"tich hai so lon hon 1000  "<<endl;
	}
	else
	{
	cout<<"tich hai so nho hon 1000"<<endl;
	}

}
