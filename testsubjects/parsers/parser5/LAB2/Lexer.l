﻿%option out:Generated/Lexer.cs
%namespace Parser
%using QUT.Gppg;

alpha   [a-zA-Z]
digit   [0-9]
alphanum    {alpha}|{digit}
bool	true|false
type	int|bool

%%

" "|\r|\n|\t       { }
\/\/.*$           { }

"if"            { return (int) Tokens.IF;}
"else"          { return (int) Tokens.ELSE;}
"while"         { return (int) Tokens.WHILE;}
"return"        { return (int) Tokens.RETURN;}
"int"           { return (int) Tokens.INT;}
"bool"          { return (int) Tokens.BOOL;}
"void"          { return (int) Tokens.VOID;}

"="             { return (int) Tokens.ASN; }
"&&"            { return (int) Tokens.AND; }
"||"            { return (int) Tokens.OR; }
"=="            { return (int) Tokens.EQ; }
"!="            { return (int) Tokens.NEQ; }
"<"             { return (int) Tokens.LT; }
">"             { return (int) Tokens.GT; }
"<="            { return (int) Tokens.LEQ; }
">="            { return (int) Tokens.GEQ; }
"+"             { return (int) Tokens.ADD; }
"-"             { return (int) Tokens.SUB; }
"*"             { return (int) Tokens.MUL; }
"/"             { return (int) Tokens.DIV; }
"!"             { return (int) Tokens.NOT; }

"("             { return (int) Tokens.LPAR; }
")"             { return (int) Tokens.RPAR; }
"{"             { return (int) Tokens.LPRA; }
"}"             { return (int) Tokens.RPRA; }
";"             { return (int) Tokens.SEMI; }
","             { return (int) Tokens.COMMA; }

{bool}					{	yylval.value = yytext;
							return (int) Tokens.BOOLEAN;							
						}

{alpha}{alphanum}*      { yylval.value = yytext;
                          return (int) Tokens.ID; 
                        }
                        
{digit}+                { yylval.value = yytext;
                          return (int) Tokens.NUM; 
                        }
                        
.                       { yylval.value = yytext;
                          return (int) Tokens.ERR;
                        }
                        
    {
      yylloc = new LexLocation(tokLin, tokCol, tokELin, tokECol);
    }

%% 

override public void yyerror(string msg, object[] arg) {
  Console.WriteLine("{0} on line {1} column {2}", msg, yylloc.StartLine, yylloc.StartColumn);
}