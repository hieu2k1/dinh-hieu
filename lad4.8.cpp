#include <iostream>
using namespace std;
 
int main()
{
	int a;
	cout<<"nhap vao tu ban phim 1 so nguyen"<<endl;
	cin>>a;
	float n;
	cout<<"nhap vao tu ban phim 1 so thuc kieu float"<<endl;
	cin>>n;
	double i;
	cout<<"nhap vao tu ban phim 1 so thuc kieu double"<<endl;
	cin>>i;
	char j;
	cout<<"nhap vao tu ban phim 1 so thuc kieu char"<<endl;
	cin>>j;
	
   cout<<"\*=====kich thuc cua kieu du lieu======*/";
   cout << "Kich co cua int : " << sizeof( int) <<" Byte "<< endl;
   cout<<"so nguyen: "<<a;
   cout << "Kich co cua float : " << sizeof(float) <<" Byte "<< endl;
   cout<<"so thuc kieu float"<<n;
   cout << "Kich co cua double : " << sizeof(double) <<" Byte "<< endl;
   cout<<"so thuc kieu double"<<i;
   cout << "Kich co cua char : " << sizeof(char) <<" Byte "<< endl;
   cout<<"ki tu:"<<j;
   cout << "Kich co cua long int : " << sizeof(long int) <<" Byte "<< endl;
   cout << "Kich co cua long double : " << sizeof(long double) <<" Byte "<< endl;
   cout<<"\*=====================================*/"<<endl;
   cout<<"nhap mot phim bat ki thoat ra khoi chuong trinh";
   return 0;
}
