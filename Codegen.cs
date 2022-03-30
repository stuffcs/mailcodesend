using System;
 
namespace Huetauouiyo {
    class Program {
        static void Main() {
            Random r = new Random();
            int n = r.Next(100000, 999999);
            Console.WriteLine(n);
            char[] chArray = n.ToString().ToCharArray();
            int[] nArray = new int[chArray.Length];
            int oddCount = 0; //нечетные
            int evenCount = 0; //четные
            int summ = 0;
            for (int i = 0; i < nArray.Length; i++) {
                nArray[i] = int.Parse(chArray[i].ToString());
                if (nArray[i] % 2 == 1) {
                    oddCount++;
                } else {
                    evenCount++;
                }
                if (nArray[i] > 5) {
                    summ += nArray[i];
                }
            }
            Console.WriteLine("count of even = {0}", evenCount);
            Console.WriteLine("summ of greate then 5 = {0}", summ);
            Console.ReadLine();
        }
    }
}
