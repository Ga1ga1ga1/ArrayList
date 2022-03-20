namespace ClassLibraryForArryaList
{
    public class ArrayList
    {
        public int Length { get; private set; }
        private int[] _array;

        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }
        public void WriteArrayList()
        {
            for(int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]}");
            }
            Console.WriteLine();
        }
        public void AddElement(int value)
        {
            if(Length >= _array.Length)
            {
                if (Length >= _array.Length)
                {
                    UpSize();
                }
                    
                _array[Length] = value;
                Length++;
            }
        }
        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
    }
}