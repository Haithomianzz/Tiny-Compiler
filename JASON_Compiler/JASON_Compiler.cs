using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JASON_Compiler
{
    public static class JASON_Compiler
    {
        public static Scanner Jason_Scanner = new Scanner();
       
        public static List<string> Lexemes = new List<string>();
        public static List<Token> TokenStream = new List<Token>();

        public static void Start_Compiling(string SourceCode) //character by character
        {
            //Scanner
            Jason_Scanner.StartScanning(SourceCode);
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               //ReplaceLexemesWithBrainrot();
            //Parser
            //Sematic Analysis
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     private static void ReplaceLexemesWithBrainrot(){Dictionary<string, string> brainrotKeywords = new Dictionary<string, string>{{ "int", "chad" },{ "float", "gigachad" },{ "string", "rant" },{ "read", "skibidi" },{ "write", "cooked" },{ "repeat", "yap" },{ "until", "cap" },{ "if", "edgy" },{ "elseif", "flex" },{ "else", "amogus" },{ "then", "schizo" },{ "return", "bussin" },{ "main", "goon" },{ "end", "deadass" },{ "endl", "ohio" },};foreach (var token in TokenStream){if (brainrotKeywords.ContainsKey(token.lex)){token.lex = brainrotKeywords[token.lex];}}}
    }
}
