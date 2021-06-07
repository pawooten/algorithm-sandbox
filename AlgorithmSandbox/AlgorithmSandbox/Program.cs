using System;

namespace AlgorithmSandbox
{
    class Program
    {
        static void Main( string[] args )
        {
            findMissingInteger1To100Test();
        }

        private static void findMissingInteger1To100Test()
        {
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            int[] array3 = new int[100];
            int[] array4 = new int[100];
            for ( int i = 0; i < 100; i++ )
            {
                array1[i] = i + 1;
                array2[i] = i + 1;
                array3[i] = i + 1;
                array4[i] = i + 1;
            }
            array1[4] = 0;
            array2[98] = 0;
            array3[44] = 0;
            var random = new Random( (int)DateTime.Now.Ticks );
            var index = random.Next( 0, 100 );
            array4[index] = 0;

            Console.WriteLine( $"array1: {findMissingInteger1to100(array1)} is missing" );
            Console.WriteLine( $"array2: {findMissingInteger1to100( array2 )} is missing" );
            Console.WriteLine( $"array3: {findMissingInteger1to100( array3 )} is missing" );
            Console.WriteLine( $"array4: {findMissingInteger1to100( array4 )} is missing" );
        }
        /// <summary>
        /// Return index of missing integer
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int findMissingInteger1to100(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != i + 1)
                {
                    return i;
                }
            }
            return 100;
        }
    }
}
