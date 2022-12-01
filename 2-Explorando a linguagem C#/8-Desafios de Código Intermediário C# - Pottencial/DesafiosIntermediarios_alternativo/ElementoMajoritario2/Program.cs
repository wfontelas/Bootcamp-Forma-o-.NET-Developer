// C# program to find Majority
// element in an array
using System;
 
public class GFG {
 
    // Function to find Majority element
    // in an array
    static void findMajority(int[] arr, int n)
    {
        int maxCount = 0;
        int index = -1; // sentinels
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++) 
            {
                if (arr[i] == arr[j])
                    count++;
            }
 
            // update maxCount if count of
            // current element is greater
            if (count > maxCount) 
            {
                maxCount = count;
                index = i;
            }
        }
 
        // if maxCount is greater than n/2
        // return the corresponding element
        if (maxCount > n / 2)
            Console.WriteLine(arr[index]);
 
        else
            Console.WriteLine(arr[index]);
    }
 
    // Driver code
    static public void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] num = new int[n];

       for (int i = 0; i < n; i++)
       {
            num[i] = int.Parse(Console.ReadLine());
       } 
       
        int tamanho = num.Length;
 
        // Function calling
        findMajority(num, tamanho);
    }
    // This code is contributed by Tushil..
}




// using System;
// using System.Collections.Generic;

// public class Program
// {
// public static void Main()
// {
// 	int[] unsortedArray = new int[10] {3, 3, 6, 3, 1, 3, 8, 3, 7, 3};

//     // int n = int.Parse(Console.ReadLine());

//     // int[] unsortedArray = new int[n];

//     // for (int i = 0; i < n; i++)
//     // {
//     //     unsortedArray[i] = int.Parse(Console.ReadLine());
//     // }


			
// 	Console.WriteLine("Input UnSorted Array: ");	
// 	Console.WriteLine("------------------------------------------------ ");	
// 	for( int i = 0; i < unsortedArray.Length; i++)
// 	{
// 		Console.WriteLine(unsortedArray[i]);
// 	}
	
// 	// Majority Array Element
// 	var majorityElement = MajorityElement(unsortedArray);
	
// 	Console.WriteLine("\nMajority Array Element: " + majorityElement);	
					
// }	
	
//  public static int MajorityElement(int[] array)
//  {
// 	 Dictionary<int, int> dictionary = new Dictionary<int, int>();
// 	 int majority = array.Length / 2;
	
// 	 foreach (int i in array)
// 	 {
// 		 if (dictionary.ContainsKey(i))
// 		 {
// 			 dictionary[i]++;				
// 			 if (dictionary[i] > majority)
// 				 return i;
// 		 }
// 		 else
// 			dictionary.Add(i, 1);		 
			
// 	 }
// 	 throw new Exception("No Majority Element Found in the Array");
//  }	
// }





// using System;

// namespace ElementoMajoritario
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n = int.Parse(Console.ReadLine());

//             int[] num = new int[n];

//             for (int i = 0; i < n; i++)
//             {
//                 num[i] = int.Parse(Console.ReadLine());
//             }

//             Console.WriteLine(MajorityElement(num));
            
//         }

//         public static int MajorityElement(int[] nums)
//         {
//             int major = nums[0];
//             int count = 1;
//             for (int i = 0; i < nums.Length;i++ )
//             {
//                 if (count < major)
//                 {
//                     major = nums[i];
//                         count ++  ;
//                 }
//                 else
//                 {
//                     if (major == nums[i])
//                     {
//                         count++;
//                     }
//                     else
//                     {
//                         count--;
//                     }
//                 }
//             }
//             return count;
//         }
//     }
// }
