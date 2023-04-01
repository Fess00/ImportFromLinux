using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Categories
{
    private int[][] numbers;
    private int numbersAmount;
    private int[] pointers;
    
    public Categories(int n) {
        numbers = new int[n][];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new int[n];
            for (int j = 0; j < numbers[i].Length; j++)
            {
                numbers[i][j] = 0;
            }
        }
        pointers = new int[n*n];
        numbersAmount = n;
    }

    public void Categorize() {
        bool flag = false;
        for (int i = 1; i <= numbersAmount; i++)
        {
            if (i == 1)
            {
                numbers[0][0] = i;
                pointers[0] = 0;
                continue;
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                for (int k = 0; k < numbers[j].Length; k++)
                {
                    if (numbers[j][k] % i != 0 && numbers[j][k] != 0)
                    {
                        continue;
                    }
                    else if(numbers[j][k] == 0 && k != 0 && j != 0)
                    {
                        numbers[j][k] = i;
                        flag = true;
                        break;
                    }
                    else if(numbers[j][k] == 0 && k == 0 && j != 0)
                    {
                        numbers[j][k] = i;
                        pointers[j] = k;
                        flag = true;
                        break;
                    }
                    else if (numbers[j][k] != 0 && (numbers[j][k - 1] % i == 0 || i % numbers[j][k - 1] == 0) && j != 0)
                    {
                        flag = true;
                        break;
                    }
                }
                
                if (flag == true)
                {
                    flag = false;
                    break;
                }
            }
        }
    }

    public void ShowCats() {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                if (numbers[i][j] == 0)
                {
                    break;
                }

                Console.Write($"{numbers[i][j]} ");
            }
        
            if (numbers[i][0] == 0)
            {
                break;
            }
            Console.WriteLine();
        }
    }
}