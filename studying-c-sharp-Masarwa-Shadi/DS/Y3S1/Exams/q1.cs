namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Exams
{
    public class q1
    {

        public static bool IsOk(Stack<char> stack)
        {
            char prev = 'O';
            while (!stack.IsEmpty())
            {
                char curr = stack.Pop();
                if ((prev == 'O' || prev == 'A') && (curr != 'T' && curr != 'F'))
                    return false;
                if ((prev == 'T' || prev == 'F') && (curr != 'A' && curr != 'O'))
                    return false;
                if ((curr == 'O' || curr == 'A') && stack.IsEmpty()) return false;
                prev = curr;
            }
            return true;

        }

    }
}
