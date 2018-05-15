using System;

//‚É[‚Ì‚Æ‚à‚ ‚«‚ª‘‚¢‚Ä‚­‚ê‚Ü‚µ‚½
class Program{
    static void Main(string []args){
        string S=Console.ReadLine();
        // string str = "abcde";
        // Console.WriteLine(str[3]);
        int sum = 0;
        for(int i = 0; i < S.Length;i++){
            try {
                sum += int.Parse(Char.ToString(S[i]));
            } catch {
            }
        }
        Console.WriteLine(sum);
    }
}