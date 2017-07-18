/* C# Port of MT19937: Integer version (2002/1/26) algorithm used in the PS4?    */
/* More information, including original source can be found at the following     */
/* Link: http://www.math.sci.hiroshima-u.ac.jp/~m-mat/MT/MT2002/emt19937ar.html  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF12RNGHelper
{
    public class RNG2002 : IRNG
    {
        /// <summary>
        /// This is the seed the PS4/FF12:ZA uses
        /// </summary>
        private const UInt32 DEFAULT_SEED = 4537U; // 5489U is default seed. PS2 and PS4/FF12:ZA uses 4537.


        /* Period parameters */
        private const Int32 N = 624;
        private const Int32 M = 397;
        private const UInt32 MATRIX_A = 0x9908b0dfU;   /* constant vector a */
        private const UInt32 UPPER_MASK = 0x80000000U; /* most significant w-r bits */
        private const UInt32 LOWER_MASK = 0x7fffffffU; /* least significant r bits */

        private UInt32[] mt = new UInt32[N]; /* the array for the state vector  */
        private Int32 mti = N + 1; /* mti==N+1 means mt[N] is not initialized */

        public RNG2002(UInt32 seed = DEFAULT_SEED)
        {
            sgenrand(seed);
        }

        public void sgenrand()
        {
            sgenrand(DEFAULT_SEED);
        }

        /* initializes mt[N] with a seed */
        public void sgenrand(UInt32 s) //init_genrand
        {
            mt[0] = s & 0xffffffff;
            for (mti = 1; mti < N; mti++)
            {
                mt[mti] =
                (1812433253U * (mt[mti - 1] ^ (mt[mti - 1] >> 30)) + (UInt32)mti);
                /* See Knuth TAOCP Vol2. 3rd Ed. P.106 for multiplier. */
                /* In the previous versions, MSBs of the seed affect   */
                /* only MSBs of the array mt[].                        */
                /* 2002/01/09 modified by Makoto Matsumoto             */
                mt[mti] &= 0xffffffff;
                /* for >32 bit machines */
            }
        }

        private UInt32[] mag01 = { 0x0U, MATRIX_A }; //Moved out of below method.
        /* mag01[x] = x * MATRIX_A  for x=0,1 */

        /* generates a random number on [0,0xffffffff]-interval */
        public UInt32 genrand() //genrand_int32
        {
            UInt32 y;
            //See above for what was moved out from here

            if (mti >= N)
            { /* generate N words at one time */
                int kk;

                if (mti == N + 1)   /* if init_genrand() has not been called, */
                    sgenrand(DEFAULT_SEED); /* a default initial seed is used */

                for (kk = 0; kk < N - M; kk++)
                {
                    y = (mt[kk] & UPPER_MASK) | (mt[kk + 1] & LOWER_MASK);
                    mt[kk] = mt[kk + M] ^ (y >> 1) ^ mag01[y & 0x1UL];
                }
                for (; kk < N - 1; kk++)
                {
                    y = (mt[kk] & UPPER_MASK) | (mt[kk + 1] & LOWER_MASK);
                    mt[kk] = mt[kk + (M - N)] ^ (y >> 1) ^ mag01[y & 0x1U];
                }
                y = (mt[N - 1] & UPPER_MASK) | (mt[0] & LOWER_MASK);
                mt[N - 1] = mt[M - 1] ^ (y >> 1) ^ mag01[y & 0x1U];

                mti = 0;
            }

            y = mt[mti++];

            /* Tempering */
            y ^= (y >> 11);
            y ^= (y << 7) & 0x9d2c5680U;
            y ^= (y << 15) & 0xefc60000U;
            y ^= (y >> 18);

            return y;
        }


        /// <summary>
        /// Saves the state of the RNG
        /// </summary>
        /// <param name="rng"></param>
        /// <returns>RNGState structure</returns>
        public RNGState saveState()
        {
            return new RNGState
            {
                mti = this.mti,
                mt = this.mt.Clone() as uint[]
            };
        }

        /// <summary>
        /// Loads the state of the RNG
        /// </summary>
        /// <param name="inmti">Input mti</param>
        /// <param name="inmt">Input mt</param>
        public void loadState(int mti, UInt32[] mt)
        {
            this.mti = mti;
            mt.CopyTo(this.mt, 0);
        }

        /// <summary>
        /// Loads the state of the RNG
        /// </summary>
        /// <param name="inputState">Tuple<Input mti, Input mt, Input mag01></param>
        public void loadState(RNGState inputState)
        {
            mti = inputState.mti;
            inputState.mt.CopyTo(mt, 0);
        }
    }
}
