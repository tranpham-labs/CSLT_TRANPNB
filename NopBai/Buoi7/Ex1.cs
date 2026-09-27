using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_PNBTRAN.Buoi6
{
    internal class Ex1
    {
        static void Main()
        {
            Random rand = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 20);
            }

            Console.Write("Mảng ban đầu: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // 1. Tính giá trị trung bình
        static double CalculateAverage(int[] a)
        {
            if (a.Length == 0) return 0;

            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum / a.Length;
        }

        // 2. Kiểm tra mảng có chứa giá trị target không
        static bool ContainsValue(int[] a, int target)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == target)
                {
                    return true;
                }
            }
            return false;
        }

        // 3. Tìm chỉ số (index) đầu tiên của phần tử target
        static int FindIndex(int[] a, int target)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        // 4. Xóa một giá trị cụ thể khỏi mảng
        static int[] RemoveElement(int[] a, int target)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != target)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != target)
                {
                    result[index] = a[i];
                    index++;
                }
            }
            return result;
        }

        // 5. Tìm giá trị lớn nhất và nhỏ nhất
        static void FindMaxMin(int[] a)
        {
            if (a.Length == 0) return;

            int max = a[0];
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }

            Console.WriteLine("Max: " + max + ", Min: " + min);
        }

        // 6. Đảo ngược mảng
        static int[] ReverseArray(int[] a)
        {
            int[] result = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[a.Length - 1 - i];
            }
            return result;
        }

        // 7. Tìm các giá trị trùng lặp
        static int[] FindDuplicates(int[] a)
        {
            int[] temp = new int[a.Length];
            int tempCount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        bool alreadyAdded = false;
                        for (int k = 0; k < tempCount; k++)
                        {
                            if (temp[k] == a[i])
                            {
                                alreadyAdded = true;
                                break;
                            }
                        }

                        if (!alreadyAdded)
                        {
                            temp[tempCount] = a[i];
                            tempCount++;
                        }
                        break;
                    }
                }
            }

            int[] result = new int[tempCount];
            for (int i = 0; i < tempCount; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }

        // 8. Xóa các giá trị trùng lặp (chỉ giữ lại 1 lần xuất hiện)
        static int[] RemoveDuplicates(int[] a)
        {
            int[] temp = new int[a.Length];
            int tempCount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < tempCount; j++)
                {
                    if (a[i] == temp[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    temp[tempCount] = a[i];
                    tempCount++;
                }
            }
            int[] result = new int[tempCount];
            for (int i = 0; i < tempCount; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }
    }
}
