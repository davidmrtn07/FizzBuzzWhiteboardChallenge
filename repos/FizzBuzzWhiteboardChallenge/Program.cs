
using System;
using System.Security.Cryptography.X509Certificates;


string FizzBuzz(int number)
{
    var answer = "";
    if (number % 3 == 0)
    {
        answer = "fizz";
    }
    if(number % 5 == 0)
    {
        answer += "buzz";
    }
    return answer;
}