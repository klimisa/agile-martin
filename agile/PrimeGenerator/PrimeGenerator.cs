using System;

namespace agile.PrimeGenerator
{
    /// <summary>
    /// author: Robert C. Martin
    /// </summary>
    public class PrimeGenerator
    {
        private static bool[] _isCrossed;
        private static int[] _primes;

        ///<summary>
        /// Generates an array of prime numbers.
        ///</summary>
        ///
        /// <param name="maxValue">The generation limit.</param>
        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue >= 2) // the only valid case
            {
                Initialize(maxValue);
                Sieve();
                Primes();
                return _primes; // return the primes
            }
            else // maxValue < 2
                return new int[0]; // return null array if bad input.
        }

        private static void Primes()
        {
            // how many primes are there?
            int i;
            int count = 0;
            for (i = 0; i < _isCrossed.Length; i++)
            {
                if (_isCrossed[i])
                    count++; // bump count.
            }

            int j;
            _primes = new int[count];
            // move the primes into the result
            for (i = 0, j = 0; i < _isCrossed.Length; i++)
            {
                if (_isCrossed[i]) // if prime
                    _primes[j++] = i;
            }
        }

        private static void Sieve()
        {
            // sieve
            int i, j;
            for (i = 2; i < Math.Sqrt(_isCrossed.Length) + 1; i++)
            {
                if (_isCrossed[i]) // if i is uncrossed, cross its multiples.
                {
                    for (j = 2 * i; j < _isCrossed.Length; j += i)
                        _isCrossed[j] = false; // multiple is not prime
                }
            }
        }

        private static void Initialize(int maxValue)
        {
            _isCrossed = new bool[maxValue + 1];
            int i;
            // initialize array to true.
            for (i = 0; i < _isCrossed.Length; i++)
                _isCrossed[i] = true;

            // get rid of known non-primes
            _isCrossed[0] = _isCrossed[1] = false;
        }
    }
}

