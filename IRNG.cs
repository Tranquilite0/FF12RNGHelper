using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF12RNGHelper
{
    public interface IRNG
    {
        void sgenrand();
        void sgenrand(UInt32 s);
        UInt32 genrand();

        RNGState saveState();
        void loadState(int inmti, UInt32[] inmt);
        void loadState(RNGState state);
    }

    /// <summary>
    /// Represents the state of the Mersenne Twister RNG
    /// </summary>
    public struct RNGState
    {
        /// <summary>
        /// Index into the mt state array.
        /// </summary>
        public int mti;

        /// <summary>
        /// The mt state array.
        /// </summary>
        public UInt32[] mt;

    }
}
