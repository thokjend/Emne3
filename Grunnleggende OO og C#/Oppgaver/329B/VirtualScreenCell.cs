namespace _329B
{
    internal class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }


        public char GetCharacter()
        {
            if (Up && Down && Left && Right) { return '\u253c'; }
            if (Up && Down && Left) { return '\u251c'; }
            if (Up && Down && Right) { return '\u2524'; }
            if (Left && Right && Up) { return '\u2534'; }
            if (Left && Right && Down) { return '\u252c'; }
            if (Right && Down) { return '\u250c'; }
            if (Left && Down) { return '\u2510'; }
            if (Right && Up) { return '\u2518'; }
            if (Left && Up) { return '\u2514'; }
            if (Up || Down) { return '\u2502'; }
            if (Left || Right) { return '\u2500'; }
            return ' ';
        }

        public void AddHorizontal()
        {
            Left = true;
            Right = true;
        }

        public void AddVertical()
        {
            Up = true;
            Down = true;
        }

        public void AddLowerLeftCorner()
        {
            Up = true;
            Left = true;
        }

        public void AddUpperLeftCorner()
        {
            Right = true;
            Down = true;
        }

        public void AddUpperRightCorner()
        {
            Left = true;
            Down = true;
        }

        public void AddLowerRightCorner()
        {
            Up = true;
            Right = true;
        }

    }
}
