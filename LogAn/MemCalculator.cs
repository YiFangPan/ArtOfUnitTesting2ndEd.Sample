namespace LogAn
{
    public class MemCalculator
    {
        private int total = 0;

        public void add(int number)
        {
            total += number;
        }

        public int sum()
        {
            int temp = total;
            total = 0;
            return temp;
        }
    }
}