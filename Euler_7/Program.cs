using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           List<int> primeNumbers = getPrimesToN(10001);
           
           Console.WriteLine(primeNumbers[10001-1]);
        }
        
        // computes n amount of primes 
        public static List<int> getPrimesToN(int n){
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            //TODO: increase i by 2, since we can ignore even numbers.
        	for(int i = 2; primeNumbers.Count < n; i++){
        		//check if i is divisble by a prime number
        		for(int j = 0; j < primeNumbers.Count; j++){
        			if(i % primeNumbers[j] == 0){
        				break; // not prime
        			}
        			if(j == primeNumbers.Count -1) {
        				// end reached and no divisor found, so must be a prime
        				primeNumbers.Add(i)
        			}
        		}
        	}
        	
        	return primeNumbers;
        }
    }
}
