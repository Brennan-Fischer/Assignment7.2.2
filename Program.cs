namespace Assignment7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "intelligent";
            Char[] c = s.ToCharArray();

            int l = 0;
            int r = s.Length - 1;

            while(l<=r)
            {
                if (s[l] != 'a' && s[l] != 'e' && s[l] != 'i' && s[l] != 'o' && s[l] != 'u')
                {
                    l++;
                }
                else if (s[r] != 'a' && s[r] != 'e' && s[r] != 'i' && s[r] != 'o' && s[r] != 'u')
                {
                    r--;
                }
                else if ((s[l] == 'a' || s[l] != 'e' || s[l] != 'i' || s[l] != 'o' || s[l] != 'u') && (s[r] == 'a' || s[r] != 'e' || s[r] != 'i' || s[r] != 'o' || s[r] != 'u')) 
                {
                    char temp = c[l];
                    c[l] = c[r];
                    c[r] = temp;
                    l++;
                    r--;
                }

            }
            Console.WriteLine("test");
            foreach (char k in c) { Console.Write(k+" "); }
        }
    }
}
