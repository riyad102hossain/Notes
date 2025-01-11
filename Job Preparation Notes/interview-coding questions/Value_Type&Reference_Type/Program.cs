//Value Type
int a = 20;
int b = a;  //copies the value of a to b
b = 10;
Console.WriteLine(a);

//Reference type
int[] array1 = { 2, 5, 8 };
int[] array2 = array1; //copies the reference 
array2[0] = 20;
Console.WriteLine(array1[0]);