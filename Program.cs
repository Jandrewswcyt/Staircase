using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text; 
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        PrintStairCase(n); 
    }
    
        static void PrintStairCase(int size)
        {
            int totalN = size; 
            while(size > 0)
            {
                DrawStairCase(--size, totalN);
            }
        }

        static void DrawStairCase(int numPrecedingSpaces, int n,  char pic = '#')
        {
            int totalPics = n - numPrecedingSpaces; 
            StringBuilder sBuilder = new StringBuilder(); 

            for(int i = 0; i < numPrecedingSpaces; i++)
            {
                sBuilder.Append(' '); 
            }
            
            for(int i = 0; i < totalPics; i++)
            {
                sBuilder.Append(pic);
            }
            
            Console.WriteLine(sBuilder.ToString()); 
        }
}
