namespace _03.AceOfDiamonds
{
    using System;

    public static class AceOfDiamonds
    {
        private const char BorderChar = '*';
        private const char RombChar = '@';
        private const char OutterChar = '-';

        public static void Main()
        {
            var size = uint.Parse(Console.ReadLine());
            var rombSize = size - 2;
            var halfRombSize = rombSize / 2;

            DrawFirstLastLine(size);

            var outter = (rombSize - 1) / 2;
            var inner = 1;
            for (var row = 0; row < rombSize; row++)
            {

                if (row < halfRombSize)
                {
                    DrawHalfRomb(outter, inner);
                    outter--;
                    inner += 2;
                }
                else if (row == rombSize / 2)
                {
                    DrawMiddleLine(rombSize);
                    outter++;
                    inner -= 2;
                }
                else
                {
                    DrawHalfRomb(outter, inner);
                    outter++;
                    inner -= 2;
                }
            }

            DrawFirstLastLine(size);
        }

        private static void DrawHalfRomb(uint outter, int inner)
        {
            Console.Write(BorderChar);
            DrawLineOutterPart(outter);
            DrawLineInnerPart(inner);
            DrawLineOutterPart(outter);
            Console.WriteLine(BorderChar);
        }

        private static void DrawLineInnerPart(int inner)
        {
            for (var j = 0; j < inner; j++)
            {
                Console.Write(RombChar);
            }
        }

        private static void DrawLineOutterPart(uint outter)
        {
            for (var j = 0; j < outter; j++)
            {
                Console.Write(OutterChar);
            }
        }

        private static void DrawFirstLastLine(uint size)
        {
            for (var i = 0; i < size; i++)
            {
                Console.Write(BorderChar);
            }

            Console.WriteLine();
        }

        private static void DrawMiddleLine(uint rombSize)
        {
            Console.Write(BorderChar);
            for (var i = 0; i < rombSize; i++)
            {
                Console.Write(RombChar);
            }

            Console.WriteLine(BorderChar);
        }
    }
}