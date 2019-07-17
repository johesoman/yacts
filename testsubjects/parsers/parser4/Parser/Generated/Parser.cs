// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  DESKTOP-1V1VFND
// DateTime: 02-Jan-19 11:45:17
// UserName: Laura
// Input file <Parser.y - 02-Jan-19 11:44:50>

// options: lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace Parser
{
public enum Tokens {error=2,EOF=3,IF=4,ELSE=5,WHILE=6,
    RETURN=7,VOID=8,INT=9,BOOLEAN=10,LCBR=11,RCBR=12,
    SEMI=13,LPAR=14,RPAR=15,COMMA=16,ASGN=17,OR=18,
    AND=19,EQL=20,NEQL=21,GRT=22,LESS=23,GEQL=24,
    LEQL=25,ADD=26,SUB=27,MUL=28,DIV=29,NOT=30,
    BOOL=31,ID=32,NUM=33,ERR=34};

public struct ValueType
#line 4 "Parser.y"
       {
  public string value;
  
  public Declaration D;
  public List<Declaration> Ld;
  public Formal F;
  public List<Formal> Lf;
  public List<Statement> Ls;
  public Statement S;
  public Expression E;
  public List<Expression> Le;
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
  private static Rule[] rules = new Rule[54];
  private static State[] states = new State[112];
  private static string[] nonTerms = new string[] {
      "D", "M", "F", "J", "S", "B", "E", "Z", "G", "C", "H", "I", "O", "R", "K", 
      "L", "P", "$accept", };

  static Parser() {
    states[0] = new State(-4,new int[]{-17,1,-2,3});
    states[1] = new State(new int[]{3,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{3,4,9,6,10,96,8,104},new int[]{-1,5});
    states[4] = new State(-2);
    states[5] = new State(-3);
    states[6] = new State(new int[]{32,7});
    states[7] = new State(new int[]{14,8});
    states[8] = new State(new int[]{9,89,10,91,15,-12,16,-12},new int[]{-4,9,-3,95});
    states[9] = new State(new int[]{15,10,16,93});
    states[10] = new State(new int[]{11,11});
    states[11] = new State(-9,new int[]{-6,12});
    states[12] = new State(new int[]{12,13,11,15,4,18,6,25,7,30,32,34,30,50,27,52,33,55,31,56,14,73,9,89,10,91},new int[]{-5,14,-7,85,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54,-3,87});
    states[13] = new State(-5);
    states[14] = new State(-8);
    states[15] = new State(-9,new int[]{-6,16});
    states[16] = new State(new int[]{12,17,11,15,4,18,6,25,7,30,32,34,30,50,27,52,33,55,31,56,14,73,9,89,10,91},new int[]{-5,14,-7,85,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54,-3,87});
    states[17] = new State(-15);
    states[18] = new State(new int[]{14,19});
    states[19] = new State(new int[]{32,34,30,50,27,52,33,55,31,56,14,73},new int[]{-7,20,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54});
    states[20] = new State(new int[]{15,21});
    states[21] = new State(new int[]{11,15,4,18,6,25,7,30,32,34,30,50,27,52,33,55,31,56,14,73,9,89,10,91},new int[]{-5,22,-7,85,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54,-3,87});
    states[22] = new State(new int[]{5,23,12,-17,11,-17,4,-17,6,-17,7,-17,32,-17,30,-17,27,-17,33,-17,31,-17,14,-17,9,-17,10,-17});
    states[23] = new State(new int[]{11,15,4,18,6,25,7,30,32,34,30,50,27,52,33,55,31,56,14,73,9,89,10,91},new int[]{-5,24,-7,85,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54,-3,87});
    states[24] = new State(-16);
    states[25] = new State(new int[]{14,26});
    states[26] = new State(new int[]{32,34,30,50,27,52,33,55,31,56,14,73},new int[]{-7,27,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54});
    states[27] = new State(new int[]{15,28});
    states[28] = new State(new int[]{11,15,4,18,6,25,7,30,32,34,30,50,27,52,33,55,31,56,14,73,9,89,10,91},new int[]{-5,29,-7,85,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54,-3,87});
    states[29] = new State(-18);
    states[30] = new State(new int[]{13,33,32,34,30,50,27,52,33,55,31,56,14,73},new int[]{-7,31,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54});
    states[31] = new State(new int[]{13,32});
    states[32] = new State(-19);
    states[33] = new State(-20);
    states[34] = new State(new int[]{17,35,14,58,28,-49,29,-49,26,-49,27,-49,23,-49,22,-49,25,-49,24,-49,20,-49,21,-49,19,-49,18,-49,13,-49,15,-49,16,-49});
    states[35] = new State(new int[]{32,34,30,50,27,52,33,55,31,56,14,73},new int[]{-7,36,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54});
    states[36] = new State(-23);
    states[37] = new State(new int[]{18,38,13,-24,15,-24,16,-24});
    states[38] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-9,39,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54});
    states[39] = new State(new int[]{19,40,18,-25,13,-25,15,-25,16,-25});
    states[40] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-10,41,-11,76,-12,83,-13,79,-14,80,-15,54});
    states[41] = new State(new int[]{20,42,21,65,19,-27,18,-27,13,-27,15,-27,16,-27});
    states[42] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-11,43,-12,83,-13,79,-14,80,-15,54});
    states[43] = new State(new int[]{23,44,22,67,25,77,24,81,20,-29,21,-29,19,-29,18,-29,13,-29,15,-29,16,-29});
    states[44] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-12,45,-13,79,-14,80,-15,54});
    states[45] = new State(new int[]{26,46,27,69,23,-32,22,-32,25,-32,24,-32,20,-32,21,-32,19,-32,18,-32,13,-32,15,-32,16,-32});
    states[46] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-13,47,-14,80,-15,54});
    states[47] = new State(new int[]{28,48,29,71,26,-37,27,-37,23,-37,22,-37,25,-37,24,-37,20,-37,21,-37,19,-37,18,-37,13,-37,15,-37,16,-37});
    states[48] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-14,49,-15,54});
    states[49] = new State(-40);
    states[50] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-14,51,-15,54});
    states[51] = new State(-43);
    states[52] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-14,53,-15,54});
    states[53] = new State(-44);
    states[54] = new State(-45);
    states[55] = new State(-46);
    states[56] = new State(-47);
    states[57] = new State(new int[]{14,58,28,-49,29,-49,26,-49,27,-49,23,-49,22,-49,25,-49,24,-49,20,-49,21,-49,19,-49,18,-49,13,-49,15,-49,16,-49});
    states[58] = new State(new int[]{32,34,30,50,27,52,33,55,31,56,14,73,15,-53,16,-53},new int[]{-16,59,-7,84,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54});
    states[59] = new State(new int[]{15,60,16,61});
    states[60] = new State(-48);
    states[61] = new State(new int[]{32,34,30,50,27,52,33,55,31,56,14,73},new int[]{-7,62,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54});
    states[62] = new State(-52);
    states[63] = new State(new int[]{19,40,18,-26,13,-26,15,-26,16,-26});
    states[64] = new State(new int[]{20,42,21,65,19,-28,18,-28,13,-28,15,-28,16,-28});
    states[65] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-11,66,-12,83,-13,79,-14,80,-15,54});
    states[66] = new State(new int[]{23,44,22,67,25,77,24,81,20,-30,21,-30,19,-30,18,-30,13,-30,15,-30,16,-30});
    states[67] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-12,68,-13,79,-14,80,-15,54});
    states[68] = new State(new int[]{26,46,27,69,23,-33,22,-33,25,-33,24,-33,20,-33,21,-33,19,-33,18,-33,13,-33,15,-33,16,-33});
    states[69] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-13,70,-14,80,-15,54});
    states[70] = new State(new int[]{28,48,29,71,26,-38,27,-38,23,-38,22,-38,25,-38,24,-38,20,-38,21,-38,19,-38,18,-38,13,-38,15,-38,16,-38});
    states[71] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-14,72,-15,54});
    states[72] = new State(-41);
    states[73] = new State(new int[]{32,34,30,50,27,52,33,55,31,56,14,73},new int[]{-7,74,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54});
    states[74] = new State(new int[]{15,75});
    states[75] = new State(-50);
    states[76] = new State(new int[]{23,44,22,67,25,77,24,81,20,-31,21,-31,19,-31,18,-31,13,-31,15,-31,16,-31});
    states[77] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-12,78,-13,79,-14,80,-15,54});
    states[78] = new State(new int[]{26,46,27,69,23,-34,22,-34,25,-34,24,-34,20,-34,21,-34,19,-34,18,-34,13,-34,15,-34,16,-34});
    states[79] = new State(new int[]{28,48,29,71,26,-39,27,-39,23,-39,22,-39,25,-39,24,-39,20,-39,21,-39,19,-39,18,-39,13,-39,15,-39,16,-39});
    states[80] = new State(-42);
    states[81] = new State(new int[]{30,50,27,52,33,55,31,56,32,57,14,73},new int[]{-12,82,-13,79,-14,80,-15,54});
    states[82] = new State(new int[]{26,46,27,69,23,-35,22,-35,25,-35,24,-35,20,-35,21,-35,19,-35,18,-35,13,-35,15,-35,16,-35});
    states[83] = new State(new int[]{26,46,27,69,23,-36,22,-36,25,-36,24,-36,20,-36,21,-36,19,-36,18,-36,13,-36,15,-36,16,-36});
    states[84] = new State(-51);
    states[85] = new State(new int[]{13,86});
    states[86] = new State(-21);
    states[87] = new State(new int[]{13,88});
    states[88] = new State(-22);
    states[89] = new State(new int[]{32,90});
    states[90] = new State(-13);
    states[91] = new State(new int[]{32,92});
    states[92] = new State(-14);
    states[93] = new State(new int[]{9,89,10,91},new int[]{-3,94});
    states[94] = new State(-11);
    states[95] = new State(-10);
    states[96] = new State(new int[]{32,97});
    states[97] = new State(new int[]{14,98});
    states[98] = new State(new int[]{9,89,10,91,15,-12,16,-12},new int[]{-4,99,-3,95});
    states[99] = new State(new int[]{15,100,16,93});
    states[100] = new State(new int[]{11,101});
    states[101] = new State(-9,new int[]{-6,102});
    states[102] = new State(new int[]{12,103,11,15,4,18,6,25,7,30,32,34,30,50,27,52,33,55,31,56,14,73,9,89,10,91},new int[]{-5,14,-7,85,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54,-3,87});
    states[103] = new State(-6);
    states[104] = new State(new int[]{32,105});
    states[105] = new State(new int[]{14,106});
    states[106] = new State(new int[]{9,89,10,91,15,-12,16,-12},new int[]{-4,107,-3,95});
    states[107] = new State(new int[]{15,108,16,93});
    states[108] = new State(new int[]{11,109});
    states[109] = new State(-9,new int[]{-6,110});
    states[110] = new State(new int[]{12,111,11,15,4,18,6,25,7,30,32,34,30,50,27,52,33,55,31,56,14,73,9,89,10,91},new int[]{-5,14,-7,85,-8,37,-9,63,-10,64,-11,76,-12,83,-13,79,-14,80,-15,54,-3,87});
    states[111] = new State(-7);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-18, new int[]{-17,3});
    rules[2] = new Rule(-17, new int[]{-2,3});
    rules[3] = new Rule(-2, new int[]{-2,-1});
    rules[4] = new Rule(-2, new int[]{});
    rules[5] = new Rule(-1, new int[]{9,32,14,-4,15,11,-6,12});
    rules[6] = new Rule(-1, new int[]{10,32,14,-4,15,11,-6,12});
    rules[7] = new Rule(-1, new int[]{8,32,14,-4,15,11,-6,12});
    rules[8] = new Rule(-6, new int[]{-6,-5});
    rules[9] = new Rule(-6, new int[]{});
    rules[10] = new Rule(-4, new int[]{-3});
    rules[11] = new Rule(-4, new int[]{-4,16,-3});
    rules[12] = new Rule(-4, new int[]{});
    rules[13] = new Rule(-3, new int[]{9,32});
    rules[14] = new Rule(-3, new int[]{10,32});
    rules[15] = new Rule(-5, new int[]{11,-6,12});
    rules[16] = new Rule(-5, new int[]{4,14,-7,15,-5,5,-5});
    rules[17] = new Rule(-5, new int[]{4,14,-7,15,-5});
    rules[18] = new Rule(-5, new int[]{6,14,-7,15,-5});
    rules[19] = new Rule(-5, new int[]{7,-7,13});
    rules[20] = new Rule(-5, new int[]{7,13});
    rules[21] = new Rule(-5, new int[]{-7,13});
    rules[22] = new Rule(-5, new int[]{-3,13});
    rules[23] = new Rule(-7, new int[]{32,17,-7});
    rules[24] = new Rule(-7, new int[]{-8});
    rules[25] = new Rule(-8, new int[]{-8,18,-9});
    rules[26] = new Rule(-8, new int[]{-9});
    rules[27] = new Rule(-9, new int[]{-9,19,-10});
    rules[28] = new Rule(-9, new int[]{-10});
    rules[29] = new Rule(-10, new int[]{-10,20,-11});
    rules[30] = new Rule(-10, new int[]{-10,21,-11});
    rules[31] = new Rule(-10, new int[]{-11});
    rules[32] = new Rule(-11, new int[]{-11,23,-12});
    rules[33] = new Rule(-11, new int[]{-11,22,-12});
    rules[34] = new Rule(-11, new int[]{-11,25,-12});
    rules[35] = new Rule(-11, new int[]{-11,24,-12});
    rules[36] = new Rule(-11, new int[]{-12});
    rules[37] = new Rule(-12, new int[]{-12,26,-13});
    rules[38] = new Rule(-12, new int[]{-12,27,-13});
    rules[39] = new Rule(-12, new int[]{-13});
    rules[40] = new Rule(-13, new int[]{-13,28,-14});
    rules[41] = new Rule(-13, new int[]{-13,29,-14});
    rules[42] = new Rule(-13, new int[]{-14});
    rules[43] = new Rule(-14, new int[]{30,-14});
    rules[44] = new Rule(-14, new int[]{27,-14});
    rules[45] = new Rule(-14, new int[]{-15});
    rules[46] = new Rule(-15, new int[]{33});
    rules[47] = new Rule(-15, new int[]{31});
    rules[48] = new Rule(-15, new int[]{32,14,-16,15});
    rules[49] = new Rule(-15, new int[]{32});
    rules[50] = new Rule(-15, new int[]{14,-7,15});
    rules[51] = new Rule(-16, new int[]{-7});
    rules[52] = new Rule(-16, new int[]{-16,16,-7});
    rules[53] = new Rule(-16, new int[]{});

    aliases = new Dictionary<int, string>();
    aliases.Add(4, "if");
    aliases.Add(5, "else");
    aliases.Add(6, "while");
    aliases.Add(7, "return");
    aliases.Add(8, "void");
    aliases.Add(9, "int");
    aliases.Add(10, "bool");
    aliases.Add(11, "{");
    aliases.Add(12, "}");
    aliases.Add(13, ";");
    aliases.Add(14, "(");
    aliases.Add(15, ")");
    aliases.Add(16, ",");
    aliases.Add(17, "=");
    aliases.Add(18, "||");
    aliases.Add(19, "&&");
    aliases.Add(20, "==");
    aliases.Add(21, "!=");
    aliases.Add(22, ">");
    aliases.Add(23, "<");
    aliases.Add(24, ">=");
    aliases.Add(25, "<=");
    aliases.Add(26, "+");
    aliases.Add(27, "-");
    aliases.Add(28, "*");
    aliases.Add(29, "/");
    aliases.Add(30, "!");
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
      case 2: // P -> M, EOF
#line 64 "Parser.y"
                {  Program = new Program(ValueStack[ValueStack.Depth-2].Ld); }
#line default
        break;
      case 3: // M -> M, D
#line 67 "Parser.y"
               { CurrentSemanticValue.Ld = ValueStack[ValueStack.Depth-2].Ld; CurrentSemanticValue.Ld.Add(ValueStack[ValueStack.Depth-1].D); }
#line default
        break;
      case 4: // M -> /* empty */
#line 68 "Parser.y"
            { CurrentSemanticValue.Ld = new List<Declaration>(); }
#line default
        break;
      case 5: // D -> "int", ID, "(", J, ")", "{", B, "}"
#line 71 "Parser.y"
                                 { CurrentSemanticValue.D = new FormalDeclaration(FormalDeclaration.IdType.Int, ValueStack[ValueStack.Depth-7].value, ValueStack[ValueStack.Depth-5].Lf, ValueStack[ValueStack.Depth-2].Ls); CurrentSemanticValue.D.SetLocation(LocationStack[LocationStack.Depth-8]); }
#line default
        break;
      case 6: // D -> "bool", ID, "(", J, ")", "{", B, "}"
#line 72 "Parser.y"
                                  { CurrentSemanticValue.D = new FormalDeclaration(FormalDeclaration.IdType.Bool, ValueStack[ValueStack.Depth-7].value, ValueStack[ValueStack.Depth-5].Lf, ValueStack[ValueStack.Depth-2].Ls); CurrentSemanticValue.D.SetLocation(LocationStack[LocationStack.Depth-8]); }
#line default
        break;
      case 7: // D -> "void", ID, "(", J, ")", "{", B, "}"
#line 73 "Parser.y"
                                  { CurrentSemanticValue.D = new FormalDeclaration(FormalDeclaration.IdType.Void, ValueStack[ValueStack.Depth-7].value, ValueStack[ValueStack.Depth-5].Lf, ValueStack[ValueStack.Depth-2].Ls); CurrentSemanticValue.D.SetLocation(LocationStack[LocationStack.Depth-8]); }
#line default
        break;
      case 8: // B -> B, S
#line 76 "Parser.y"
               { CurrentSemanticValue.Ls = ValueStack[ValueStack.Depth-2].Ls; CurrentSemanticValue.Ls.Add(ValueStack[ValueStack.Depth-1].S); }
#line default
        break;
      case 9: // B -> /* empty */
#line 77 "Parser.y"
            { CurrentSemanticValue.Ls = new List<Statement>(); }
#line default
        break;
      case 10: // J -> F
#line 80 "Parser.y"
             { CurrentSemanticValue.Lf = new List<Formal>(); CurrentSemanticValue.Lf.Add(ValueStack[ValueStack.Depth-1].F); }
#line default
        break;
      case 11: // J -> J, ",", F
#line 81 "Parser.y"
                  { CurrentSemanticValue.Lf = ValueStack[ValueStack.Depth-3].Lf; CurrentSemanticValue.Lf.Add(ValueStack[ValueStack.Depth-1].F); }
#line default
        break;
      case 12: // J -> /* empty */
#line 82 "Parser.y"
             { CurrentSemanticValue.Lf = new List<Formal>(); }
#line default
        break;
      case 13: // F -> "int", ID
#line 85 "Parser.y"
                  { CurrentSemanticValue.F = new Formal(Formal.IdType.Int, ValueStack[ValueStack.Depth-1].value); CurrentSemanticValue.F.SetLocation(LocationStack[LocationStack.Depth-2]); }
#line default
        break;
      case 14: // F -> "bool", ID
#line 86 "Parser.y"
                   { CurrentSemanticValue.F = new Formal(Formal.IdType.Bool, ValueStack[ValueStack.Depth-1].value); CurrentSemanticValue.F.SetLocation(LocationStack[LocationStack.Depth-2]); }
#line default
        break;
      case 15: // S -> "{", B, "}"
#line 89 "Parser.y"
                   { CurrentSemanticValue.S = new BlockStatement(ValueStack[ValueStack.Depth-2].Ls); CurrentSemanticValue.S.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 16: // S -> "if", "(", E, ")", S, "else", S
#line 90 "Parser.y"
                            { CurrentSemanticValue.S = new IfStatement(ValueStack[ValueStack.Depth-5].E, ValueStack[ValueStack.Depth-3].S, ValueStack[ValueStack.Depth-1].S); CurrentSemanticValue.S.SetLocation(LocationStack[LocationStack.Depth-7]); }
#line default
        break;
      case 17: // S -> "if", "(", E, ")", S
#line 91 "Parser.y"
                       { CurrentSemanticValue.S = new IfStatement(ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].S); CurrentSemanticValue.S.SetLocation(LocationStack[LocationStack.Depth-5]); }
#line default
        break;
      case 18: // S -> "while", "(", E, ")", S
#line 92 "Parser.y"
                         { CurrentSemanticValue.S = new WhileStatement(ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].S); CurrentSemanticValue.S.SetLocation(LocationStack[LocationStack.Depth-5]); }
#line default
        break;
      case 19: // S -> "return", E, ";"
#line 93 "Parser.y"
                     { CurrentSemanticValue.S = new ReturnStatement(ValueStack[ValueStack.Depth-2].E); CurrentSemanticValue.S.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 20: // S -> "return", ";"
#line 94 "Parser.y"
                    { CurrentSemanticValue.S = new ReturnStatement(); CurrentSemanticValue.S.SetLocation(LocationStack[LocationStack.Depth-2]); }
#line default
        break;
      case 21: // S -> E, ";"
#line 95 "Parser.y"
                { CurrentSemanticValue.S = new ExpressionStatement(ValueStack[ValueStack.Depth-2].E); CurrentSemanticValue.S.SetLocation(LocationStack[LocationStack.Depth-2]); }
#line default
        break;
      case 22: // S -> F, ";"
#line 96 "Parser.y"
                { CurrentSemanticValue.S = new FormalStatement(ValueStack[ValueStack.Depth-2].F); CurrentSemanticValue.S.SetLocation(LocationStack[LocationStack.Depth-2]); }
#line default
        break;
      case 23: // E -> ID, "=", E
#line 99 "Parser.y"
                   { CurrentSemanticValue.E = new AssignmentExpression(ValueStack[ValueStack.Depth-3].value, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 24: // E -> Z
#line 100 "Parser.y"
             { CurrentSemanticValue.E = ValueStack[ValueStack.Depth-1].E; }
#line default
        break;
      case 25: // Z -> Z, "||", G
#line 103 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.Or, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 26: // Z -> G
#line 104 "Parser.y"
             { CurrentSemanticValue.E = ValueStack[ValueStack.Depth-1].E; }
#line default
        break;
      case 27: // G -> G, "&&", C
#line 107 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.And, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 28: // G -> C
#line 108 "Parser.y"
             { CurrentSemanticValue.E = ValueStack[ValueStack.Depth-1].E; }
#line default
        break;
      case 29: // C -> C, "==", H
#line 111 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.Eql, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 30: // C -> C, "!=", H
#line 112 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.NEql, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 31: // C -> H
#line 113 "Parser.y"
             { CurrentSemanticValue.E = ValueStack[ValueStack.Depth-1].E; }
#line default
        break;
      case 32: // H -> H, "<", I
#line 116 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.Less, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 33: // H -> H, ">", I
#line 117 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.Grt, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 34: // H -> H, "<=", I
#line 118 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.LEql, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 35: // H -> H, ">=", I
#line 119 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.GEql, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 36: // H -> I
#line 120 "Parser.y"
             { CurrentSemanticValue.E = ValueStack[ValueStack.Depth-1].E; }
#line default
        break;
      case 37: // I -> I, "+", O
#line 123 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.Add, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 38: // I -> I, "-", O
#line 124 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.Sub, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 39: // I -> O
#line 125 "Parser.y"
             { CurrentSemanticValue.E = ValueStack[ValueStack.Depth-1].E; }
#line default
        break;
      case 40: // O -> O, "*", R
#line 128 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.Mul, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 41: // O -> O, "/", R
#line 129 "Parser.y"
                  { CurrentSemanticValue.E = new BinaryOperatorExpression(BinaryOperatorExpression.Type.Div, ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 42: // O -> R
#line 130 "Parser.y"
             { CurrentSemanticValue.E = ValueStack[ValueStack.Depth-1].E; }
#line default
        break;
      case 43: // R -> "!", R
#line 133 "Parser.y"
                { CurrentSemanticValue.E = new UnaryOperatorExpression(UnaryOperatorExpression.Type.Not, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-2]); }
#line default
        break;
      case 44: // R -> "-", R
#line 134 "Parser.y"
                { CurrentSemanticValue.E = new UnaryOperatorExpression(UnaryOperatorExpression.Type.Neg, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-2]); }
#line default
        break;
      case 45: // R -> K
#line 135 "Parser.y"
             { CurrentSemanticValue.E = ValueStack[ValueStack.Depth-1].E; }
#line default
        break;
      case 46: // K -> NUM
#line 138 "Parser.y"
               { CurrentSemanticValue.E = new NumberExpression(ValueStack[ValueStack.Depth-1].value); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 47: // K -> BOOL
#line 139 "Parser.y"
               { CurrentSemanticValue.E = new BooleanExpression(ValueStack[ValueStack.Depth-1].value); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 48: // K -> ID, "(", L, ")"
#line 140 "Parser.y"
                     { CurrentSemanticValue.E = new FunctionCallExpression(ValueStack[ValueStack.Depth-4].value, ValueStack[ValueStack.Depth-2].Le); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-4]); }
#line default
        break;
      case 49: // K -> ID
#line 141 "Parser.y"
              { CurrentSemanticValue.E = new IdentifierExpression(ValueStack[ValueStack.Depth-1].value); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 50: // K -> "(", E, ")"
#line 142 "Parser.y"
                   { CurrentSemanticValue.E = ValueStack[ValueStack.Depth-2].E; }
#line default
        break;
      case 51: // L -> E
#line 145 "Parser.y"
             { CurrentSemanticValue.Le = new List<Expression>(); CurrentSemanticValue.Le.Add(ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 52: // L -> L, ",", E
#line 146 "Parser.y"
                  { CurrentSemanticValue.Le = ValueStack[ValueStack.Depth-3].Le; CurrentSemanticValue.Le.Add(ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 53: // L -> /* empty */
#line 147 "Parser.y"
            { CurrentSemanticValue.Le = new List<Expression>(); }
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

#line 151 "Parser.y"

public Parser(Scanner s) : base(s) { }
public Program Program; 
#line default
}
}