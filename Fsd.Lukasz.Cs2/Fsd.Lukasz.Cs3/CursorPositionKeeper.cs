using System;

namespace Fsd.Lukasz.Cs3
{
    public class CursorPositionKeeper : IDisposable
    {
        private int Top { get; } = Console.CursorTop;
        private int Left { get; } = Console.CursorLeft;

        public void Dispose()
        {
            Console.SetCursorPosition(Left, Top);
        }
    }
}