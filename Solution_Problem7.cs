using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulier
{
	class Program
	{
		  static void Main(string[] args)
		  {
			   PrimeNumber PNumber = new PrimeNumber();
			   int i = 2;
			   int counter = 1;
			   while(i>0)
			  {
				    if (i == 2 || i == 3 || i == 5)
				    {
					  counter++;					
				    }
				    else
				    {
					    if (PNumber.IsPrime(i))
					    {	
						      if (counter == 10001)
						      {
							      Console.WriteLine("The 10001st number is " + i);
							      break;
						      }
						      counter++;
					    }
				    }
				
				  i++;
			  }
		  Console.ReadLine();
		  }
	}
	
/**********************************************************************************************************************************/

	// Function used to determine whether the number is Prime 
	class PrimeNumber
	{
		  public bool IsPrime(int num)
		  {
			  for (int i = 2; i < num; i++)
				  if (num % i == 0)
				  {
					  return false;
				  }
				  else
				  {
					continue;
				  }
			return true;
		  }
	}
  
} 
	
