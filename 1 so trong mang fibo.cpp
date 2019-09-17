#include <stdio.h>

int fibonacci(int n)
{
    if (n == 1 || n == 2)
        return 1;
    return fibonacci(n - 1) + fibonacci(n - 2);
}
int main()
{
    int n;
    printf("nhap n: ");
    scanf("%d", &n);
    printf("so fibonacci thu %d la: %d", n, fibonacci(n));
    return 0;
}
