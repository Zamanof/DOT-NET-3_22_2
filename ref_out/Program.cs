// ref out
int[] arr = new int[2] { 2, 2 };
int n1 = default, n2 = default;
//Console.WriteLine($"arr = [{arr[0]}, {arr[1]}], n1 = {n1} n2 = {n2} n3 = {n3} ");
Foo(arr, n1, ref n2, out int n3);
Console.WriteLine($"arr = [{arr[0]}, {arr[1]}], n1 = {n1} n2 = {n2} n3 = {n3} ");

int b = default;
Int32.TryParse("17", out int a);
Int32.TryParse("15", out b);
Console.WriteLine($"{a} {b}");



void Foo(int[] arr, int n1, ref int n2, out int n3 )
{
    arr[0] = 5;
    arr[1] = 6;
    n1 = 6;
    Console.WriteLine(n2);
    n3 = 6;
}
