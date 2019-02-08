using System;

class Program
{
    static void Main()
    {
        //8.Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World".
        //    Декларирайте променлива от тип object и и присвоете стойността на конкатенацията на двете променливи от тип string
        //(не изпускайте интервала по средата).
        //    Декларирайте трета променлива от тип 
        //    string и я инициализирайте със стойността на променливата от тип object(трябва да използвате type casting).
        string a = "Hello";
        string b = "World";
        object c = (a + " " + b);
        string resultObject = (string)c;
        Console.WriteLine(resultObject);
             
    }
}
