# FF12RNGHelper
Final Fantasy XII RNG Helper. Works for PS2 and PS4 versions of the game.

I first coded this a number of years ago, and I must admit that it is a bit of a mess. There are a number of half baked ideas (like that progress bar), and I did nothing to make it so that the UI thread doesn't stall when doing large numbers of calculations.
I refactored things a little when I added in support for The Zodiac Age.

Basic usage:
1. Enter in your stats (level, magick power, spell power, whether you have serenity licence, and Console/Platform).
2. Heal yourself
3. Report how much you were healed to the program using the RNG search section
4. Repeat steps 2 and 3 untill you are confident you are at the Correct RNG position.
5. Use the proceeding RNG values to manipulate chest drops/rare steals/etc. The % column is most likely what you want to use for this as many manipulable events use the rng value mod 100 to determine success or failure.

If you need any more information on how you can use this program to your advantage, I'm sure a little searching of the web will help.

There is also a section where you can provide the RNG position, and the number of positions you want to display, and it will give you a "cure list", which you can then copy into a spreadsheet if you want.

About the RNG Algorithm Used:

While the PS2 version used the old 1998 version of the Mersenne Twister algorithm, the PS4 remake uses the "new" (or at least newer) 2002 version of the MT algorithm. You can find links to the original source for these algorithms in the RNG1998.cs and RNG2002.cs files respectively.
Both the PS2 and PS4 initialize their respective algorithms with the same seed of 4537 (I'm so glad I didnt have to brute force the seed for FF12:TZA). The PS4/FF12:TZA seems to reinitialize the PRNG whenever you restart the app, so you dont need to restart the PS4 hardware to reset the PRNG.
