namespace Assignment6_2_2
{
    internal class Program
    {
        //Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4 };
            Print(ProductOfAllButIndex(intArr));
            int[] intArr2 = { -1,1,0,-3,3 };
            Print(ProductOfAllButIndex(intArr2));
        }

        /// <summary>
        /// The main trick for this problem is to multiply the ends of the array by 1.
        /// We want to create an array to hold our individual products (prodHolder)
        /// We want to set a variable to 1 and use it to hold our products (prod)
        /// Initially loop through the original array.
        /// Each iteration we will set the current index of "prodHolder" to "prod" (our current calculated product)
        /// Then set "prod" to our current "prod" value times current index element of the current array(prod * arr[i])
        /// EXPLAINATION: Each time we multiply prod with array values and add to prodHolder we are multiplying all numbers execpt for 1 value needed for program solution
        /// Set "prod" to 1 again
        /// Loop the length of the array again, this time in reverse
        /// set current index(prodHolder[i]) equal to "prod" * prodHolder[i](current index element)
        /// Then set "prod" to our current "prod" value times current index element of the current array(prod * arr[i])
        /// </summary>

        static int[] ProductOfAllButIndex(int[] arr)
        {
            int[] prodHolder = new int[arr.Length];

            // Place prod in prodHolder[i], then set prod to ( arr[i](original array) * prod)
            int prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                prodHolder[i] = prod;
                prod *= arr[i];
            }

            // Replace prodHolder[i] with (prod * prodHolder[i]), then set prod to ( arr[i](original array) * prod)
            prod = 1;
            for(int i = arr.Length-1; i >= 0; i--)
            {
                prodHolder[i] = prod * prodHolder[i];
                prod *= arr[i];
            }
            return prodHolder;
        }


        static void Print(int[] arr)
        {
            Console.Write("|");
            foreach(int i in arr)
            {
                Console.Write($" {i} |");
            }
            Console.WriteLine();
        }
    }
}
