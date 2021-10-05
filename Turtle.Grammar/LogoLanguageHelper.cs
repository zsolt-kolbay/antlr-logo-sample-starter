using Antlr4.Runtime;

namespace Turtle.Grammar
{
    public static class LogoLanguageHelper
    {
        public static void ParseAndExecuteLogoScript(string sourceCode, ITurtle turtle)
        {
            // create a stream from the source code
            // pass that stream to the Lexer


            // create a stream of tokens from the Lexer


            // pass that stream to the Parser


            // get the root node of the parsed syntax tree


            // pass that root node to a Visitor object
        }
    }
}
