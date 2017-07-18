﻿/* C# Port of MT19937: Integer version (1998/4/6) algorithm used in the PS2.            */
/* More information, including original source can be found at the following            */
/* Link: http://www.math.sci.hiroshima-u.ac.jp/~m-mat/MT/VERSIONS/C-LANG/ver980409.html */

/* A C-program for MT19937: Integer version (1998/4/6)            */
/*  genrand() generates one pseudorandom unsigned integer (32bit) */
/* which is uniformly distributed among 0 to 2^32-1  for each     */
/* call. sgenrand(seed) set initial values to the working area    */
/* of 624 words. Before genrand(), sgenrand(seed) must be         */
/* called once. (seed is any 32-bit integer except for 0).        */
/*   Coded by Takuji Nishimura, considering the suggestions by    */
/* Topher Cooper and Marc Rieffel in July-Aug. 1997.              */

/* This library is free software; you can redistribute it and/or   */
/* modify it under the terms of the GNU Library General Public     */
/* License as published by the Free Software Foundation; either    */
/* version 2 of the License, or (at your option) any later         */
/* version.                                                        */
/* This library is distributed in the hope that it will be useful, */
/* but WITHOUT ANY WARRANTY; without even the implied warranty of  */
/* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.            */
/* See the GNU Library General Public License for more details.    */
/* You should have received a copy of the GNU Library General      */
/* Public License along with this library; if not, write to the    */
/* Free Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA   */ 
/* 02111-1307  USA                                                 */

/* Copyright (C) 1997 Makoto Matsumoto and Takuji Nishimura.       */
/* When you use this, send an email to: matumoto@math.keio.ac.jp   */
/* with an appropriate reference to your work.                     */

/* REFERENCE                                                       */
/* M. Matsumoto and T. Nishimura,                                  */
/* "Mersenne Twister: A 623-Dimensionally Equidistributed Uniform  */
/* Pseudo-Random Number Generator",                                */
/* ACM Transactions on Modeling and Computer Simulation,           */
/* Vol. 8, No. 1, January 1998, pp 3--30.                          */

using System;

namespace FF12RNGHelper
{
    public class RNG1998 : IRNG
    {
        /// <summary>
        /// This is the seed the PS2 uses.
        /// </summary>
        private const UInt32 DEFAULT_SEED = 4537U; //For original implementation, default seed is 4357

        /// <summary>
        /// Period Parameters.
        /// </summary>
        private const int M = 397;
        private const int N = 624;
        private const UInt32 MATRIX_A = 0x9908b0dfU;   // constant Vector a
        private const UInt32 UPPER_MASK = 0x80000000U; // Most significant w-r bits
        private const UInt32 LOWER_MASK = 0x7fffffffU; // Least significant r bits

        /// <summary>
        /// Tempering parameters.
        /// </summary>
        private const UInt32 TEMPERING_MASK_B = 0x9d2c5680U;
        private const UInt32 TEMPERING_MASK_C = 0xefc60000U;

        /// <summary>
        /// The array for the state vector.
        /// </summary>
        private UInt32[] mt = new UInt32[N];
        /// <summary>
        /// mt's index used in for loops. A value of N+1 means mt[N] is not initialized.
        /// </summary>
        private int mti = N+1;

        private UInt32[] mag01 = { 0x0, MATRIX_A };

        public RNG1998(UInt32 seed = DEFAULT_SEED)
        {
            sgenrand(seed);
        }

        public void sgenrand()
        {
            sgenrand(DEFAULT_SEED);
        }

        /// <summary>
        /// Seeds the random number generator and restarts the sequence.
        /// </summary>
        /// <param name="seed">The Seed used for determining the sequence.</param>
        public void sgenrand(UInt32 seed)
        {
            /* setting initial seeds to mt[N] using         */
            /* the generator Line 25 of Table 1 in          */
            /* [KNUTH 1981, The Art of Computer Programming */
            /*    Vol. 2 (2nd Ed.), pp102]                  */
            mt[0] = seed & 0xffffffff;
            for (mti=1; mti<N; mti++)
            {
                mt[mti] = (69069 * mt[mti - 1]) & 0xffffffff;
            }
        }

        /// <summary>
        /// Generates the next random number in the sequence.
        /// </summary>
        /// <returns>The next random number in the sequence.</returns>
        public UInt32 genrand()
        {
            int kk;
            UInt32 y = 0;
            if(mti >= N)
            {
                if (mti == N + 1) sgenrand(DEFAULT_SEED);

                for(kk=0; kk < N-M; kk++)
                {
                    y = (mt[kk] & UPPER_MASK) | (mt[kk + 1] & LOWER_MASK);
                    mt[kk] = mt[kk + M] ^ (y >> 1) ^ mag01[y & 0x1];
                }
                for (; kk < N - 1; kk++)
                {
                    y = (mt[kk] & UPPER_MASK) | (mt[kk + 1] & LOWER_MASK);
                    mt[kk] = mt[kk + (M - N)] ^ (y >> 1) ^ mag01[y & 0x1];
                }

                y = (mt[N - 1] & UPPER_MASK) | (mt[0] & LOWER_MASK);
                mt[N - 1] = mt[M - 1] ^ (y >> 1) ^ mag01[y & 0x1];

                mti = 0;
            }

            y = mt[mti++];
            y ^= y >> 11;
            y ^= y << 7  & TEMPERING_MASK_B;
            y ^= y << 15 & TEMPERING_MASK_C;
            y ^= y >> 18;

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
