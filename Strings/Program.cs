﻿//Intro();
string sentence = "My name is Engin Demiroğ";
var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "My name is Derin Demiroğ";
bool result3 = sentence.EndsWith("ğ");
bool result4 = sentence.StartsWith("My name");

var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0,"Hello, ");
var result9 = sentence.Substring(3,4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ", "-");
var result13 = sentence.Remove(2,5);
Console.WriteLine(result13);
void Intro()
{
    string city = "Ankara";
//Console.WriteLine(city[3]);
    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";
    string result = city + city2;
    Console.WriteLine("{0}{1}",city,city2);
}