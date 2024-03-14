public class Solution {
    public int MySqrt(int x) {
        if (x == 1 || x == 2) return 1;
        long l = x;
        for (long i = 0; i < l; i++)
        {
            if (i * i > l) return (int)i - 1;
        }
        return 0;
    }
}