using System;

namespace Code_Snippet13
{
    class Code_Snippet13
    {
        static void Main(string[] args)
        {
            static void Depreciation(out int val)
            {
                val = 20000;
                int dep = val * 5 / 100;
                int amt = val - dep;
                Console.WriteLine("DepreciationAmount:" + dep);
                Console.WriteLine("Reduced value after depreciation: " + amt);
            }
            static void Main(string[] args)
            {
                int value;
                Depreciation(out value);
            }
        }
    }
}
