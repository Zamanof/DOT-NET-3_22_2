#region Arithmetic operators
// + - * / % ++ -- += -= *= /= %=

//int numb1 = 15, numb2 = 23;

//Console.WriteLine(numb1 + numb2);
//Console.WriteLine(numb1 - numb2);
//Console.WriteLine(numb1 * numb2);
//Console.WriteLine(numb1 / numb2);
//Console.WriteLine(numb1 % numb2);
//Console.WriteLine(1.2m % 1);
//int number = 25;
//Console.WriteLine(number++);
//Console.WriteLine(++number);
//Console.WriteLine(number--);
//Console.WriteLine(--number);

#endregion

#region Comparison operators
// > < >= <= == !=
//int numb1 = 15, numb2 = 23;

//Console.WriteLine(numb1 > numb2);
//Console.WriteLine(numb1 < numb2);
//Console.WriteLine(numb1 >= numb2);
//Console.WriteLine(numb1 <= numb2);
//Console.WriteLine(numb1 == numb2);
//Console.WriteLine(numb1 != numb2);
#endregion

#region Logical operators
// && || !
//Console.WriteLine(true && true);
//Console.WriteLine(true && false);
//Console.WriteLine(false && true);
//Console.WriteLine(false && false);

//Console.WriteLine(true  || true);
//Console.WriteLine(true  || false);
//Console.WriteLine(false || true);
//Console.WriteLine(false || false);

//Console.WriteLine(!true);
//Console.WriteLine(!false);

#endregion

#region Bitwise operators
// & | ^ ~ <<  >>   <<=  >>= &= |= ^=

//Console.WriteLine(1 & 5);
//   0 0 0 0 0 1 0 1
// & 
//   0 0 0 0 0 0 0 1
// ------------------
//   0 0 0 0 0 0 0 1

//Console.WriteLine(1 | 5);

//   0 0 0 0 0 1 0 1
// | 
//   0 0 0 0 0 0 0 1
// ------------------
//   0 0 0 0 0 1 0 1

//Console.WriteLine(~1u);

//Console.WriteLine(5 << 3);   // 5 * 2^3
//Console.WriteLine(5 >> 3);   // 5 / 2^3

//sbyte sb1 = 5;
//sbyte sb2 = 3;
//Console.WriteLine(sb1 ^ sb2);
//sb1 ^= sb2;
//Console.WriteLine(sb1);
//sb1 ^= sb2;
//Console.WriteLine(sb1);
//   0 0 0 0 0 1 0 1
// ^ 
//   0 0 0 0 0 0 1 1
// ------------------
//   0 0 0 0 0 1 1 0
// ^ 
//   0 0 0 0 0 0 1 1
// ------------------
//   0 0 0 0 0 1 0 1



#endregion

#region if else else if

//int value = 25;

//if (value == 25)
//{
//    Console.WriteLine("Salam");
//}
//else if(value > 0){
//    Console.WriteLine("Saqol");
//}
//else if (value != 0)
//{
//    Console.WriteLine("Hi");
//}
//else
//{
//    Console.WriteLine("Goodbye");
//}

#endregion

#region while, do while
//int i = 0;
//while (i < 10)
//{
//    Console.WriteLine(i);
//    if (i == 2) continue;
//    i++;
//}

//int i = 0;
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i == 10);
#endregion

#region for
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(i);
//}
#endregion

#region foreach
//string name = "Atilla";

//foreach (var item in name)
//{
//    Console.WriteLine(item);
//}

//int[] arr = new int[5] { 1, 6, 3, 5, 8 };

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}
#endregion 


