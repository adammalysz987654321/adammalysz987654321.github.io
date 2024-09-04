using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i=2;
        System.Console.WriteLine(2);
        List<int> primes=new List<int>();
        primes.Add(i);
        while(true){
            n++;
            bool Add=true;
            for (int i = 0; i < primes.Count; i++)
            {
                if(n%primes[i]==0){
                    Add=false;

                }
            }
            if(Add){
                primes.Add(n);
                System.Console.WriteLine(n);
            }
        }
    }
}
