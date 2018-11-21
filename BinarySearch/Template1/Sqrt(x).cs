public class Solution {
    public int MySqrt(int x) {
        if (x<0)
        {
            return -1; 
        }
        var result = Math.Floor(Math.Sqrt(x));
        return (int)result;
    }
}
