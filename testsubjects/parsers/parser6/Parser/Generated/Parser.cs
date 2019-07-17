// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  LEC-CZC4271HB7
// DateTime: 2018-12-12 12:45:59
// UserName: nbn16002
// Input file <Parser.y - 2018-12-12 12:45:34>

// options: lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace Parser
{
public enum Tokens {error=2,EOF=3,ID=4,NUM=5,ERR=6,
    VOID=7,LPAR=8,RPAR=9,LCUR=10,RCUR=11,COM=12,
    INT=13,BOOL=14,IF=15,ELSE=16,WHILE=17,SEMI=18,
    TRUE=19,FALSE=20,RETURN=21,ASN=22,OR=23,AND=24,
    EQ=25,NEQ=26,LT=27,GT=28,LTE=29,GTE=30,
    ADD=31,NEG=32,MUL=33,DIV=34,NOT=35,THEN=36,
    NOBOP=37,BOP=38};

public struct ValueType
#line 6 "Parser.y"
       {
  public string value;
  public Expression Expr;
  public Statement Stmt;
  public List<Expression> Exprs;
  public List<Statement> Stmts;
  public List<Variable> formalList;
  public Variable variable;
  public Declaration declaration;
  public List<Declaration> Decls;
  public ParsedProgram Program;
  public BlockStatement BlockStmt;
}
#line default
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[52];
  private static State[] states = new State[105];
  private static string[] nonTerms = new string[] {
      "Expr", "EExpr", "FirstID", "ExprList", "NotFirstExpr", "Stmts", "Stmt", 
      "Type", "FormalList", "NotFirstID", "Decl", "Decls", "Program", "BlockStmt", 
      "$accept", };

  static Parser() {
    states[0] = new State(new int[]{13,88,14,89,7,97,3,-3},new int[]{-13,1,-11,3,-8,7});
    states[1] = new State(new int[]{3,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{13,88,14,89,7,97,3,-5},new int[]{-12,4,-11,5,-8,7});
    states[4] = new State(-2);
    states[5] = new State(new int[]{13,88,14,89,7,97,3,-5},new int[]{-12,6,-11,5,-8,7});
    states[6] = new State(-4);
    states[7] = new State(new int[]{4,8});
    states[8] = new State(new int[]{8,9});
    states[9] = new State(new int[]{13,88,14,89,9,-11},new int[]{-9,10,-3,90,-8,95});
    states[10] = new State(new int[]{9,11});
    states[11] = new State(new int[]{10,12});
    states[12] = new State(new int[]{10,18,15,21,17,74,21,79,5,52,19,53,20,54,4,55,8,58,32,62,35,64,13,88,14,89,11,-9},new int[]{-6,13,-7,15,-14,17,-1,83,-2,61,-8,85});
    states[13] = new State(new int[]{11,14});
    states[14] = new State(-6);
    states[15] = new State(new int[]{10,18,15,21,17,74,21,79,5,52,19,53,20,54,4,55,8,58,32,62,35,64,13,88,14,89,11,-9},new int[]{-6,16,-7,15,-14,17,-1,83,-2,61,-8,85});
    states[16] = new State(-8);
    states[17] = new State(-17);
    states[18] = new State(new int[]{10,18,15,21,17,74,21,79,5,52,19,53,20,54,4,55,8,58,32,62,35,64,13,88,14,89,11,-9},new int[]{-6,19,-7,15,-14,17,-1,83,-2,61,-8,85});
    states[19] = new State(new int[]{11,20});
    states[20] = new State(-25);
    states[21] = new State(new int[]{8,22});
    states[22] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,23,-2,61});
    states[23] = new State(new int[]{9,24,31,28,23,30,24,32,25,34,26,36,27,38,28,40,29,42,30,44,32,46,33,48,34,50});
    states[24] = new State(new int[]{10,18},new int[]{-14,25});
    states[25] = new State(new int[]{16,26,10,-18,15,-18,17,-18,21,-18,5,-18,19,-18,20,-18,4,-18,8,-18,32,-18,35,-18,13,-18,14,-18,11,-18});
    states[26] = new State(new int[]{10,18},new int[]{-14,27});
    states[27] = new State(-19);
    states[28] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,29,-2,61});
    states[29] = new State(new int[]{31,-34,23,-34,24,-34,25,-34,26,-34,27,-34,28,-34,29,-34,30,-34,32,-34,33,48,34,50,18,-34,9,-34,12,-34});
    states[30] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,31,-2,61});
    states[31] = new State(new int[]{31,28,23,-35,24,32,25,34,26,36,27,38,28,40,29,42,30,44,32,46,33,48,34,50,18,-35,9,-35,12,-35});
    states[32] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,33,-2,61});
    states[33] = new State(new int[]{31,28,23,-36,24,-36,25,34,26,36,27,38,28,40,29,42,30,44,32,46,33,48,34,50,18,-36,9,-36,12,-36});
    states[34] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,35,-2,61});
    states[35] = new State(new int[]{31,28,23,-37,24,-37,25,-37,26,-37,27,38,28,40,29,42,30,44,32,46,33,48,34,50,18,-37,9,-37,12,-37});
    states[36] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,37,-2,61});
    states[37] = new State(new int[]{31,28,23,-38,24,-38,25,-38,26,-38,27,38,28,40,29,42,30,44,32,46,33,48,34,50,18,-38,9,-38,12,-38});
    states[38] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,39,-2,61});
    states[39] = new State(new int[]{31,28,23,-39,24,-39,25,-39,26,-39,27,-39,28,-39,29,-39,30,-39,32,46,33,48,34,50,18,-39,9,-39,12,-39});
    states[40] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,41,-2,61});
    states[41] = new State(new int[]{31,28,23,-40,24,-40,25,-40,26,-40,27,-40,28,-40,29,-40,30,-40,32,46,33,48,34,50,18,-40,9,-40,12,-40});
    states[42] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,43,-2,61});
    states[43] = new State(new int[]{31,28,23,-41,24,-41,25,-41,26,-41,27,-41,28,-41,29,-41,30,-41,32,46,33,48,34,50,18,-41,9,-41,12,-41});
    states[44] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,45,-2,61});
    states[45] = new State(new int[]{31,28,23,-42,24,-42,25,-42,26,-42,27,-42,28,-42,29,-42,30,-42,32,46,33,48,34,50,18,-42,9,-42,12,-42});
    states[46] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,47,-2,61});
    states[47] = new State(new int[]{31,-43,23,-43,24,-43,25,-43,26,-43,27,-43,28,-43,29,-43,30,-43,32,-43,33,48,34,50,18,-43,9,-43,12,-43});
    states[48] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,49,-2,61});
    states[49] = new State(-44);
    states[50] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,51,-2,61});
    states[51] = new State(-45);
    states[52] = new State(-26);
    states[53] = new State(-27);
    states[54] = new State(-28);
    states[55] = new State(new int[]{22,56,8,66,18,-30,31,-30,23,-30,24,-30,25,-30,26,-30,27,-30,28,-30,29,-30,30,-30,32,-30,33,-30,34,-30,9,-30,12,-30});
    states[56] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,57,-2,61});
    states[57] = new State(new int[]{31,28,23,30,24,32,25,34,26,36,27,38,28,40,29,42,30,44,32,46,33,48,34,50,18,-29,9,-29,12,-29});
    states[58] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,59,-2,61});
    states[59] = new State(new int[]{9,60,31,28,23,30,24,32,25,34,26,36,27,38,28,40,29,42,30,44,32,46,33,48,34,50});
    states[60] = new State(-32);
    states[61] = new State(-33);
    states[62] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,63,-2,61});
    states[63] = new State(-46);
    states[64] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,65,-2,61});
    states[65] = new State(-47);
    states[66] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64,9,-49},new int[]{-4,67,-1,69,-2,61});
    states[67] = new State(new int[]{9,68});
    states[68] = new State(-31);
    states[69] = new State(new int[]{31,28,23,30,24,32,25,34,26,36,27,38,28,40,29,42,30,44,32,46,33,48,34,50,12,71,9,-51},new int[]{-5,70});
    states[70] = new State(-48);
    states[71] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,72,-2,61});
    states[72] = new State(new int[]{31,28,23,30,24,32,25,34,26,36,27,38,28,40,29,42,30,44,32,46,33,48,34,50,12,71,9,-51},new int[]{-5,73});
    states[73] = new State(-50);
    states[74] = new State(new int[]{8,75});
    states[75] = new State(new int[]{5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,76,-2,61});
    states[76] = new State(new int[]{9,77,31,28,23,30,24,32,25,34,26,36,27,38,28,40,29,42,30,44,32,46,33,48,34,50});
    states[77] = new State(new int[]{10,18},new int[]{-14,78});
    states[78] = new State(-20);
    states[79] = new State(new int[]{18,82,5,52,19,53,20,54,4,55,8,58,32,62,35,64},new int[]{-1,80,-2,61});
    states[80] = new State(new int[]{18,81,31,28,23,30,24,32,25,34,26,36,27,38,28,40,29,42,30,44,32,46,33,48,34,50});
    states[81] = new State(-21);
    states[82] = new State(-22);
    states[83] = new State(new int[]{18,84,31,28,23,30,24,32,25,34,26,36,27,38,28,40,29,42,30,44,32,46,33,48,34,50});
    states[84] = new State(-23);
    states[85] = new State(new int[]{4,86});
    states[86] = new State(new int[]{18,87});
    states[87] = new State(-24);
    states[88] = new State(-15);
    states[89] = new State(-16);
    states[90] = new State(new int[]{12,92,9,-14},new int[]{-10,91});
    states[91] = new State(-10);
    states[92] = new State(new int[]{13,88,14,89},new int[]{-3,93,-8,95});
    states[93] = new State(new int[]{12,92,9,-14},new int[]{-10,94});
    states[94] = new State(-13);
    states[95] = new State(new int[]{4,96});
    states[96] = new State(-12);
    states[97] = new State(new int[]{4,98});
    states[98] = new State(new int[]{8,99});
    states[99] = new State(new int[]{13,88,14,89,9,-11},new int[]{-9,100,-3,90,-8,95});
    states[100] = new State(new int[]{9,101});
    states[101] = new State(new int[]{10,102});
    states[102] = new State(new int[]{10,18,15,21,17,74,21,79,5,52,19,53,20,54,4,55,8,58,32,62,35,64,13,88,14,89,11,-9},new int[]{-6,103,-7,15,-14,17,-1,83,-2,61,-8,85});
    states[103] = new State(new int[]{11,104});
    states[104] = new State(-7);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-15, new int[]{-13,3});
    rules[2] = new Rule(-13, new int[]{-11,-12});
    rules[3] = new Rule(-13, new int[]{});
    rules[4] = new Rule(-12, new int[]{-11,-12});
    rules[5] = new Rule(-12, new int[]{});
    rules[6] = new Rule(-11, new int[]{-8,4,8,-9,9,10,-6,11});
    rules[7] = new Rule(-11, new int[]{7,4,8,-9,9,10,-6,11});
    rules[8] = new Rule(-6, new int[]{-7,-6});
    rules[9] = new Rule(-6, new int[]{});
    rules[10] = new Rule(-9, new int[]{-3,-10});
    rules[11] = new Rule(-9, new int[]{});
    rules[12] = new Rule(-3, new int[]{-8,4});
    rules[13] = new Rule(-10, new int[]{12,-3,-10});
    rules[14] = new Rule(-10, new int[]{});
    rules[15] = new Rule(-8, new int[]{13});
    rules[16] = new Rule(-8, new int[]{14});
    rules[17] = new Rule(-7, new int[]{-14});
    rules[18] = new Rule(-7, new int[]{15,8,-1,9,-14});
    rules[19] = new Rule(-7, new int[]{15,8,-1,9,-14,16,-14});
    rules[20] = new Rule(-7, new int[]{17,8,-1,9,-14});
    rules[21] = new Rule(-7, new int[]{21,-1,18});
    rules[22] = new Rule(-7, new int[]{21,18});
    rules[23] = new Rule(-7, new int[]{-1,18});
    rules[24] = new Rule(-7, new int[]{-8,4,18});
    rules[25] = new Rule(-14, new int[]{10,-6,11});
    rules[26] = new Rule(-1, new int[]{5});
    rules[27] = new Rule(-1, new int[]{19});
    rules[28] = new Rule(-1, new int[]{20});
    rules[29] = new Rule(-1, new int[]{4,22,-1});
    rules[30] = new Rule(-1, new int[]{4});
    rules[31] = new Rule(-1, new int[]{4,8,-4,9});
    rules[32] = new Rule(-1, new int[]{8,-1,9});
    rules[33] = new Rule(-1, new int[]{-2});
    rules[34] = new Rule(-2, new int[]{-1,31,-1});
    rules[35] = new Rule(-2, new int[]{-1,23,-1});
    rules[36] = new Rule(-2, new int[]{-1,24,-1});
    rules[37] = new Rule(-2, new int[]{-1,25,-1});
    rules[38] = new Rule(-2, new int[]{-1,26,-1});
    rules[39] = new Rule(-2, new int[]{-1,27,-1});
    rules[40] = new Rule(-2, new int[]{-1,28,-1});
    rules[41] = new Rule(-2, new int[]{-1,29,-1});
    rules[42] = new Rule(-2, new int[]{-1,30,-1});
    rules[43] = new Rule(-2, new int[]{-1,32,-1});
    rules[44] = new Rule(-2, new int[]{-1,33,-1});
    rules[45] = new Rule(-2, new int[]{-1,34,-1});
    rules[46] = new Rule(-2, new int[]{32,-1});
    rules[47] = new Rule(-2, new int[]{35,-1});
    rules[48] = new Rule(-4, new int[]{-1,-5});
    rules[49] = new Rule(-4, new int[]{});
    rules[50] = new Rule(-5, new int[]{12,-1,-5});
    rules[51] = new Rule(-5, new int[]{});

    aliases = new Dictionary<int, string>();
    aliases.Add(4, "id");
    aliases.Add(5, "num");
    aliases.Add(7, "void");
    aliases.Add(8, "(");
    aliases.Add(9, ")");
    aliases.Add(10, "{");
    aliases.Add(11, "}");
    aliases.Add(12, ",");
    aliases.Add(13, "int");
    aliases.Add(14, "bool");
    aliases.Add(15, "if");
    aliases.Add(16, "else");
    aliases.Add(17, "while");
    aliases.Add(18, ";");
    aliases.Add(19, "true");
    aliases.Add(20, "false");
    aliases.Add(21, "return");
    aliases.Add(22, "=");
    aliases.Add(23, "||");
    aliases.Add(24, "&&");
    aliases.Add(25, "==");
    aliases.Add(26, "!=");
    aliases.Add(27, "<");
    aliases.Add(28, ">");
    aliases.Add(29, "<=");
    aliases.Add(30, ">=");
    aliases.Add(31, "+");
    aliases.Add(32, "-");
    aliases.Add(33, "*");
    aliases.Add(34, "/");
    aliases.Add(35, "!");
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 2: // Program -> Decl, Decls
#line 95 "Parser.y"
                             { ValueStack[ValueStack.Depth-1].Decls.Insert(0, ValueStack[ValueStack.Depth-2].declaration); Program = new ParsedProgram(ValueStack[ValueStack.Depth-1].Decls); }
#line default
        break;
      case 3: // Program -> /* empty */
#line 96 "Parser.y"
              { Program = new ParsedProgram(new List<Declaration>()); }
#line default
        break;
      case 4: // Decls -> Decl, Decls
#line 99 "Parser.y"
                           { ValueStack[ValueStack.Depth-1].Decls.Insert(0, ValueStack[ValueStack.Depth-2].declaration); CurrentSemanticValue.Decls = ValueStack[ValueStack.Depth-1].Decls; }
#line default
        break;
      case 5: // Decls -> /* empty */
#line 100 "Parser.y"
                { CurrentSemanticValue.Decls = new List<Declaration>(); }
#line default
        break;
      case 6: // Decl -> Type, "id", "(", FormalList, ")", "{", Stmts, "}"
#line 103 "Parser.y"
                                                 { CurrentSemanticValue.declaration = new Declaration(ValueStack[ValueStack.Depth-8].value, ValueStack[ValueStack.Depth-7].value, ValueStack[ValueStack.Depth-5].formalList, ( new BlockStatement(ValueStack[ValueStack.Depth-2].Stmts) )); }
#line default
        break;
      case 7: // Decl -> "void", "id", "(", FormalList, ")", "{", Stmts, "}"
#line 104 "Parser.y"
                                                 { CurrentSemanticValue.declaration = new Declaration("void", ValueStack[ValueStack.Depth-7].value, ValueStack[ValueStack.Depth-5].formalList, ( new BlockStatement(ValueStack[ValueStack.Depth-2].Stmts) )); }
#line default
        break;
      case 8: // Stmts -> Stmt, Stmts
#line 109 "Parser.y"
                         { CurrentSemanticValue.Stmts = ValueStack[ValueStack.Depth-1].Stmts; CurrentSemanticValue.Stmts.Insert(0, ValueStack[ValueStack.Depth-2].Stmt); }
#line default
        break;
      case 9: // Stmts -> /* empty */
#line 110 "Parser.y"
              { CurrentSemanticValue.Stmts = new List<Statement>();}
#line default
        break;
      case 10: // FormalList -> FirstID, NotFirstID
#line 113 "Parser.y"
                                   { CurrentSemanticValue.formalList = ValueStack[ValueStack.Depth-1].formalList; CurrentSemanticValue.formalList.Insert(0, ValueStack[ValueStack.Depth-2].variable);  }
#line default
        break;
      case 11: // FormalList -> /* empty */
#line 114 "Parser.y"
                    { CurrentSemanticValue.formalList = new List<Variable>(); }
#line default
        break;
      case 12: // FirstID -> Type, "id"
#line 117 "Parser.y"
                        { CurrentSemanticValue.variable = new Variable(ValueStack[ValueStack.Depth-2].value, ValueStack[ValueStack.Depth-1].value); }
#line default
        break;
      case 13: // NotFirstID -> ",", FirstID, NotFirstID
#line 120 "Parser.y"
                                      { CurrentSemanticValue.formalList = ValueStack[ValueStack.Depth-1].formalList; CurrentSemanticValue.formalList.Insert(0, ValueStack[ValueStack.Depth-2].variable); }
#line default
        break;
      case 14: // NotFirstID -> /* empty */
#line 121 "Parser.y"
              { CurrentSemanticValue.formalList = new List<Variable>(); }
#line default
        break;
      case 15: // Type -> "int"
#line 126 "Parser.y"
                   { CurrentSemanticValue.value = "int"; }
#line default
        break;
      case 16: // Type -> "bool"
#line 127 "Parser.y"
                    { CurrentSemanticValue.value = "bool"; }
#line default
        break;
      case 17: // Stmt -> BlockStmt
#line 132 "Parser.y"
                          { CurrentSemanticValue.Stmt = ValueStack[ValueStack.Depth-1].BlockStmt;  CurrentSemanticValue.Stmt.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 18: // Stmt -> "if", "(", Expr, ")", BlockStmt
#line 133 "Parser.y"
                                            { CurrentSemanticValue.Stmt = new IfStatement(ValueStack[ValueStack.Depth-3].Expr, ValueStack[ValueStack.Depth-1].BlockStmt); CurrentSemanticValue.Stmt.SetLocation(LocationStack[LocationStack.Depth-5]);  }
#line default
        break;
      case 19: // Stmt -> "if", "(", Expr, ")", BlockStmt, "else", BlockStmt
#line 134 "Parser.y"
                                                   { CurrentSemanticValue.Stmt = new IfElseStatement(ValueStack[ValueStack.Depth-5].Expr, ValueStack[ValueStack.Depth-3].BlockStmt, ValueStack[ValueStack.Depth-1].BlockStmt); CurrentSemanticValue.Stmt.SetLocation(LocationStack[LocationStack.Depth-7]);  }
#line default
        break;
      case 20: // Stmt -> "while", "(", Expr, ")", BlockStmt
#line 135 "Parser.y"
                                        { CurrentSemanticValue.Stmt = new WhileStatement(ValueStack[ValueStack.Depth-3].Expr, ValueStack[ValueStack.Depth-1].BlockStmt); CurrentSemanticValue.Stmt.SetLocation(LocationStack[LocationStack.Depth-5]);  }
#line default
        break;
      case 21: // Stmt -> "return", Expr, ";"
#line 136 "Parser.y"
                               { CurrentSemanticValue.Stmt = new ReturnStatement(ValueStack[ValueStack.Depth-2].Expr); CurrentSemanticValue.Stmt.SetLocation(LocationStack[LocationStack.Depth-3]);  }
#line default
        break;
      case 22: // Stmt -> "return", ";"
#line 137 "Parser.y"
                            { CurrentSemanticValue.Stmt = new ReturnStatement(); CurrentSemanticValue.Stmt.SetLocation(LocationStack[LocationStack.Depth-2]);  }
#line default
        break;
      case 23: // Stmt -> Expr, ";"
#line 138 "Parser.y"
                          { CurrentSemanticValue.Stmt = new ExpressionStatement(ValueStack[ValueStack.Depth-2].Expr); CurrentSemanticValue.Stmt.SetLocation(LocationStack[LocationStack.Depth-2]);  }
#line default
        break;
      case 24: // Stmt -> Type, "id", ";"
#line 139 "Parser.y"
                            { CurrentSemanticValue.Stmt = new VariableStatement(ValueStack[ValueStack.Depth-3].value, ValueStack[ValueStack.Depth-2].value); CurrentSemanticValue.Stmt.SetLocation(LocationStack[LocationStack.Depth-3]);  }
#line default
        break;
      case 25: // BlockStmt -> "{", Stmts, "}"
#line 142 "Parser.y"
                                { CurrentSemanticValue.BlockStmt = new BlockStatement(ValueStack[ValueStack.Depth-2].Stmts); CurrentSemanticValue.BlockStmt.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 26: // Expr -> "num"
#line 147 "Parser.y"
                   { CurrentSemanticValue.Expr = new NumExpression(ValueStack[ValueStack.Depth-1].value); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 27: // Expr -> "true"
#line 148 "Parser.y"
                     { CurrentSemanticValue.Expr = new BooleanExpression(true); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 28: // Expr -> "false"
#line 149 "Parser.y"
                      { CurrentSemanticValue.Expr = new BooleanExpression(false); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 29: // Expr -> "id", "=", Expr
#line 150 "Parser.y"
                          { CurrentSemanticValue.Expr = new AssignmentExpression(ValueStack[ValueStack.Depth-3].value, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 30: // Expr -> "id"
#line 151 "Parser.y"
                    { CurrentSemanticValue.Expr = new IdentifierExpression(ValueStack[ValueStack.Depth-1].value); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 31: // Expr -> "id", "(", ExprList, ")"
#line 152 "Parser.y"
                                { CurrentSemanticValue.Expr = new FunctionCallExpression(ValueStack[ValueStack.Depth-4].value, ValueStack[ValueStack.Depth-2].Exprs); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-4]); }
#line default
        break;
      case 32: // Expr -> "(", Expr, ")"
#line 153 "Parser.y"
                           { CurrentSemanticValue.Expr = ValueStack[ValueStack.Depth-2].Expr; CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 34: // EExpr -> Expr, "+", Expr
#line 158 "Parser.y"
                           {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.ADD, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 35: // EExpr -> Expr, "||", Expr
#line 159 "Parser.y"
                         {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.OR, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 36: // EExpr -> Expr, "&&", Expr
#line 160 "Parser.y"
                         {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.AND, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 37: // EExpr -> Expr, "==", Expr
#line 161 "Parser.y"
                         {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.EQ, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 38: // EExpr -> Expr, "!=", Expr
#line 162 "Parser.y"
                         {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.NEQ, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 39: // EExpr -> Expr, "<", Expr
#line 163 "Parser.y"
                        {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.LT, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 40: // EExpr -> Expr, ">", Expr
#line 164 "Parser.y"
                        {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.GT, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 41: // EExpr -> Expr, "<=", Expr
#line 165 "Parser.y"
                         {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.LTE, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 42: // EExpr -> Expr, ">=", Expr
#line 166 "Parser.y"
                         {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.GTE, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 43: // EExpr -> Expr, "-", Expr
#line 167 "Parser.y"
                        {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.NEG, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 44: // EExpr -> Expr, "*", Expr
#line 168 "Parser.y"
                        {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.MUL, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 45: // EExpr -> Expr, "/", Expr
#line 169 "Parser.y"
                        {CurrentSemanticValue.Expr = new BinaryOperatorExpression(ValueStack[ValueStack.Depth-3].Expr, Operator.DIV, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-3]);}
#line default
        break;
      case 46: // EExpr -> "-", Expr
#line 170 "Parser.y"
                            {CurrentSemanticValue.Expr = new UnaryOperatorExpression(Operator.NEG, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-2]);}
#line default
        break;
      case 47: // EExpr -> "!", Expr
#line 171 "Parser.y"
                    {CurrentSemanticValue.Expr = new UnaryOperatorExpression(Operator.NOT, ValueStack[ValueStack.Depth-1].Expr); CurrentSemanticValue.Expr.SetLocation(LocationStack[LocationStack.Depth-2]);}
#line default
        break;
      case 48: // ExprList -> Expr, NotFirstExpr
#line 176 "Parser.y"
                                { CurrentSemanticValue.Exprs = ValueStack[ValueStack.Depth-1].Exprs; CurrentSemanticValue.Exprs.Insert(0, ValueStack[ValueStack.Depth-2].Expr); }
#line default
        break;
      case 49: // ExprList -> /* empty */
#line 177 "Parser.y"
                   { CurrentSemanticValue.Exprs = new List<Expression>(); }
#line default
        break;
      case 50: // NotFirstExpr -> ",", Expr, NotFirstExpr
#line 180 "Parser.y"
                                      { CurrentSemanticValue.Exprs = ValueStack[ValueStack.Depth-1].Exprs; CurrentSemanticValue.Exprs.Insert(0, ValueStack[ValueStack.Depth-2].Expr); }
#line default
        break;
      case 51: // NotFirstExpr -> /* empty */
#line 181 "Parser.y"
                      { CurrentSemanticValue.Exprs = new List<Expression>(); }
#line default
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 186 "Parser.y"

public Parser( Scanner s ) : base( s ) { }
public ParsedProgram Program;
#line default
}
}