// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  LAPTOP-B7BUAEVP
// DateTime: 2019-01-02 20:25:56
// UserName: Ray
// Input file <Parser.y - 2019-01-02 20:25:47>

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
    SEMI=7,ASN=8,LPAR=9,RPAR=10,COMMA=11,LBRA=12,
    RBRA=13,INT=14,BOOL=15,IF=16,ELSE=17,WHILE=18,
    RETURN=19,TRUE=20,FALSE=21,VOID=22,NOT=23,SUB=24,
    ADD=25,DIV=26,MUL=27,OR=28,AND=29,EQ=30,
    NOT_EQ=31,LESS=32,GREATER=33,LESS_OR_EQ=34,GREATER_OR_EQ=35};

public struct ValueType
#line 4 "Parser.y"
       {
  public string value;

  public List<Declaration> P;
  public Declaration DECL;
  public List<Statement> S;
  public Statement STMT;
  public List<Parameter> FL;
  public Type_ T;

  public BopExpression.Operator B;

  public Expression E;
  public List<Expression> EL;
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
  private static State[] states = new State[106];
  private static string[] nonTerms = new string[] {
      "P", "Decl", "S", "Stmt", "FormalList", "Fl", "Type", "Expr", "F", "Eone", 
      "Etwo", "Ethree", "Efour", "Efive", "Esix", "ExprList", "Start", "$accept", 
      };

  static Parser() {
    states[0] = new State(-4,new int[]{-17,1,-1,3});
    states[1] = new State(new int[]{3,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{14,89,15,90,22,98,3,-2},new int[]{-2,4,-7,5});
    states[4] = new State(-3);
    states[5] = new State(new int[]{4,6});
    states[6] = new State(new int[]{9,7});
    states[7] = new State(new int[]{14,89,15,90,10,-10},new int[]{-5,8,-7,91});
    states[8] = new State(new int[]{10,9});
    states[9] = new State(new int[]{12,10});
    states[10] = new State(-8,new int[]{-3,11});
    states[11] = new State(new int[]{13,12,12,14,16,17,18,24,19,29,4,33,5,49,20,50,21,51,23,68,24,70,9,72,14,89,15,90},new int[]{-4,13,-8,84,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79,-7,86});
    states[12] = new State(-5);
    states[13] = new State(-7);
    states[14] = new State(-8,new int[]{-3,15});
    states[15] = new State(new int[]{13,16,12,14,16,17,18,24,19,29,4,33,5,49,20,50,21,51,23,68,24,70,9,72,14,89,15,90},new int[]{-4,13,-8,84,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79,-7,86});
    states[16] = new State(-15);
    states[17] = new State(new int[]{9,18});
    states[18] = new State(new int[]{4,33,5,49,20,50,21,51,23,68,24,70,9,72},new int[]{-8,19,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79});
    states[19] = new State(new int[]{10,20});
    states[20] = new State(new int[]{12,14,16,17,18,24,19,29,4,33,5,49,20,50,21,51,23,68,24,70,9,72,14,89,15,90},new int[]{-4,21,-8,84,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79,-7,86});
    states[21] = new State(new int[]{17,22,13,-16,12,-16,16,-16,18,-16,19,-16,4,-16,5,-16,20,-16,21,-16,23,-16,24,-16,9,-16,14,-16,15,-16});
    states[22] = new State(new int[]{12,14,16,17,18,24,19,29,4,33,5,49,20,50,21,51,23,68,24,70,9,72,14,89,15,90},new int[]{-4,23,-8,84,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79,-7,86});
    states[23] = new State(-17);
    states[24] = new State(new int[]{9,25});
    states[25] = new State(new int[]{4,33,5,49,20,50,21,51,23,68,24,70,9,72},new int[]{-8,26,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79});
    states[26] = new State(new int[]{10,27});
    states[27] = new State(new int[]{12,14,16,17,18,24,19,29,4,33,5,49,20,50,21,51,23,68,24,70,9,72,14,89,15,90},new int[]{-4,28,-8,84,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79,-7,86});
    states[28] = new State(-18);
    states[29] = new State(new int[]{7,32,4,33,5,49,20,50,21,51,23,68,24,70,9,72},new int[]{-8,30,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79});
    states[30] = new State(new int[]{7,31});
    states[31] = new State(-19);
    states[32] = new State(-20);
    states[33] = new State(new int[]{8,34,9,53,26,-46,27,-46,25,-46,24,-46,32,-46,33,-46,34,-46,35,-46,30,-46,31,-46,29,-46,28,-46,7,-46,10,-46,11,-46});
    states[34] = new State(new int[]{4,33,5,49,20,50,21,51,23,68,24,70,9,72},new int[]{-8,35,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79});
    states[35] = new State(-23);
    states[36] = new State(new int[]{28,37,7,-24,10,-24,11,-24});
    states[37] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-11,38,-12,59,-13,75,-14,82,-15,78,-9,79});
    states[38] = new State(new int[]{29,39,28,-25,7,-25,10,-25,11,-25});
    states[39] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-12,40,-13,75,-14,82,-15,78,-9,79});
    states[40] = new State(new int[]{30,41,31,60,29,-27,28,-27,7,-27,10,-27,11,-27});
    states[41] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-13,42,-14,82,-15,78,-9,79});
    states[42] = new State(new int[]{32,43,33,62,34,76,35,80,30,-29,31,-29,29,-29,28,-29,7,-29,10,-29,11,-29});
    states[43] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-14,44,-15,78,-9,79});
    states[44] = new State(new int[]{25,45,24,64,32,-32,33,-32,34,-32,35,-32,30,-32,31,-32,29,-32,28,-32,7,-32,10,-32,11,-32});
    states[45] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-15,46,-9,79});
    states[46] = new State(new int[]{26,47,27,66,25,-37,24,-37,32,-37,33,-37,34,-37,35,-37,30,-37,31,-37,29,-37,28,-37,7,-37,10,-37,11,-37});
    states[47] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-9,48});
    states[48] = new State(-40);
    states[49] = new State(-43);
    states[50] = new State(-44);
    states[51] = new State(-45);
    states[52] = new State(new int[]{9,53,26,-46,27,-46,25,-46,24,-46,32,-46,33,-46,34,-46,35,-46,30,-46,31,-46,29,-46,28,-46,7,-46,10,-46,11,-46});
    states[53] = new State(new int[]{4,33,5,49,20,50,21,51,23,68,24,70,9,72,10,-53,11,-53},new int[]{-16,54,-8,83,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79});
    states[54] = new State(new int[]{10,55,11,56});
    states[55] = new State(-49);
    states[56] = new State(new int[]{4,33,5,49,20,50,21,51,23,68,24,70,9,72},new int[]{-8,57,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79});
    states[57] = new State(-52);
    states[58] = new State(new int[]{29,39,28,-26,7,-26,10,-26,11,-26});
    states[59] = new State(new int[]{30,41,31,60,29,-28,28,-28,7,-28,10,-28,11,-28});
    states[60] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-13,61,-14,82,-15,78,-9,79});
    states[61] = new State(new int[]{32,43,33,62,34,76,35,80,30,-30,31,-30,29,-30,28,-30,7,-30,10,-30,11,-30});
    states[62] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-14,63,-15,78,-9,79});
    states[63] = new State(new int[]{25,45,24,64,32,-33,33,-33,34,-33,35,-33,30,-33,31,-33,29,-33,28,-33,7,-33,10,-33,11,-33});
    states[64] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-15,65,-9,79});
    states[65] = new State(new int[]{26,47,27,66,25,-38,24,-38,32,-38,33,-38,34,-38,35,-38,30,-38,31,-38,29,-38,28,-38,7,-38,10,-38,11,-38});
    states[66] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-9,67});
    states[67] = new State(-41);
    states[68] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-9,69});
    states[69] = new State(-47);
    states[70] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-9,71});
    states[71] = new State(-48);
    states[72] = new State(new int[]{4,33,5,49,20,50,21,51,23,68,24,70,9,72},new int[]{-8,73,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79});
    states[73] = new State(new int[]{10,74});
    states[74] = new State(-50);
    states[75] = new State(new int[]{32,43,33,62,34,76,35,80,30,-31,31,-31,29,-31,28,-31,7,-31,10,-31,11,-31});
    states[76] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-14,77,-15,78,-9,79});
    states[77] = new State(new int[]{25,45,24,64,32,-34,33,-34,34,-34,35,-34,30,-34,31,-34,29,-34,28,-34,7,-34,10,-34,11,-34});
    states[78] = new State(new int[]{26,47,27,66,25,-39,24,-39,32,-39,33,-39,34,-39,35,-39,30,-39,31,-39,29,-39,28,-39,7,-39,10,-39,11,-39});
    states[79] = new State(-42);
    states[80] = new State(new int[]{5,49,20,50,21,51,4,52,23,68,24,70,9,72},new int[]{-14,81,-15,78,-9,79});
    states[81] = new State(new int[]{25,45,24,64,32,-35,33,-35,34,-35,35,-35,30,-35,31,-35,29,-35,28,-35,7,-35,10,-35,11,-35});
    states[82] = new State(new int[]{25,45,24,64,32,-36,33,-36,34,-36,35,-36,30,-36,31,-36,29,-36,28,-36,7,-36,10,-36,11,-36});
    states[83] = new State(-51);
    states[84] = new State(new int[]{7,85});
    states[85] = new State(-21);
    states[86] = new State(new int[]{4,87});
    states[87] = new State(new int[]{7,88});
    states[88] = new State(-22);
    states[89] = new State(-13);
    states[90] = new State(-14);
    states[91] = new State(new int[]{4,92});
    states[92] = new State(new int[]{11,94,10,-12},new int[]{-6,93});
    states[93] = new State(-9);
    states[94] = new State(new int[]{14,89,15,90},new int[]{-7,95});
    states[95] = new State(new int[]{4,96});
    states[96] = new State(new int[]{11,94,10,-12},new int[]{-6,97});
    states[97] = new State(-11);
    states[98] = new State(new int[]{4,99});
    states[99] = new State(new int[]{9,100});
    states[100] = new State(new int[]{14,89,15,90,10,-10},new int[]{-5,101,-7,91});
    states[101] = new State(new int[]{10,102});
    states[102] = new State(new int[]{12,103});
    states[103] = new State(-8,new int[]{-3,104});
    states[104] = new State(new int[]{13,105,12,14,16,17,18,24,19,29,4,33,5,49,20,50,21,51,23,68,24,70,9,72,14,89,15,90},new int[]{-4,13,-8,84,-10,36,-11,58,-12,59,-13,75,-14,82,-15,78,-9,79,-7,86});
    states[105] = new State(-6);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-18, new int[]{-17,3});
    rules[2] = new Rule(-17, new int[]{-1});
    rules[3] = new Rule(-1, new int[]{-1,-2});
    rules[4] = new Rule(-1, new int[]{});
    rules[5] = new Rule(-2, new int[]{-7,4,9,-5,10,12,-3,13});
    rules[6] = new Rule(-2, new int[]{22,4,9,-5,10,12,-3,13});
    rules[7] = new Rule(-3, new int[]{-3,-4});
    rules[8] = new Rule(-3, new int[]{});
    rules[9] = new Rule(-5, new int[]{-7,4,-6});
    rules[10] = new Rule(-5, new int[]{});
    rules[11] = new Rule(-6, new int[]{11,-7,4,-6});
    rules[12] = new Rule(-6, new int[]{});
    rules[13] = new Rule(-7, new int[]{14});
    rules[14] = new Rule(-7, new int[]{15});
    rules[15] = new Rule(-4, new int[]{12,-3,13});
    rules[16] = new Rule(-4, new int[]{16,9,-8,10,-4});
    rules[17] = new Rule(-4, new int[]{16,9,-8,10,-4,17,-4});
    rules[18] = new Rule(-4, new int[]{18,9,-8,10,-4});
    rules[19] = new Rule(-4, new int[]{19,-8,7});
    rules[20] = new Rule(-4, new int[]{19,7});
    rules[21] = new Rule(-4, new int[]{-8,7});
    rules[22] = new Rule(-4, new int[]{-7,4,7});
    rules[23] = new Rule(-8, new int[]{4,8,-8});
    rules[24] = new Rule(-8, new int[]{-10});
    rules[25] = new Rule(-10, new int[]{-10,28,-11});
    rules[26] = new Rule(-10, new int[]{-11});
    rules[27] = new Rule(-11, new int[]{-11,29,-12});
    rules[28] = new Rule(-11, new int[]{-12});
    rules[29] = new Rule(-12, new int[]{-12,30,-13});
    rules[30] = new Rule(-12, new int[]{-12,31,-13});
    rules[31] = new Rule(-12, new int[]{-13});
    rules[32] = new Rule(-13, new int[]{-13,32,-14});
    rules[33] = new Rule(-13, new int[]{-13,33,-14});
    rules[34] = new Rule(-13, new int[]{-13,34,-14});
    rules[35] = new Rule(-13, new int[]{-13,35,-14});
    rules[36] = new Rule(-13, new int[]{-14});
    rules[37] = new Rule(-14, new int[]{-14,25,-15});
    rules[38] = new Rule(-14, new int[]{-14,24,-15});
    rules[39] = new Rule(-14, new int[]{-15});
    rules[40] = new Rule(-15, new int[]{-15,26,-9});
    rules[41] = new Rule(-15, new int[]{-15,27,-9});
    rules[42] = new Rule(-15, new int[]{-9});
    rules[43] = new Rule(-9, new int[]{5});
    rules[44] = new Rule(-9, new int[]{20});
    rules[45] = new Rule(-9, new int[]{21});
    rules[46] = new Rule(-9, new int[]{4});
    rules[47] = new Rule(-9, new int[]{23,-9});
    rules[48] = new Rule(-9, new int[]{24,-9});
    rules[49] = new Rule(-9, new int[]{4,9,-16,10});
    rules[50] = new Rule(-9, new int[]{9,-8,10});
    rules[51] = new Rule(-16, new int[]{-8});
    rules[52] = new Rule(-16, new int[]{-16,11,-8});
    rules[53] = new Rule(-16, new int[]{});

    aliases = new Dictionary<int, string>();
    aliases.Add(7, ";");
    aliases.Add(8, "=");
    aliases.Add(9, "(");
    aliases.Add(10, ")");
    aliases.Add(11, ",");
    aliases.Add(12, "{");
    aliases.Add(13, "}");
    aliases.Add(14, "int");
    aliases.Add(15, "bool");
    aliases.Add(16, "if");
    aliases.Add(17, "else");
    aliases.Add(18, "while");
    aliases.Add(19, "return");
    aliases.Add(20, "true");
    aliases.Add(21, "false");
    aliases.Add(22, "void");
    aliases.Add(23, "!");
    aliases.Add(24, "-");
    aliases.Add(25, "+");
    aliases.Add(26, "/");
    aliases.Add(27, "*");
    aliases.Add(28, "||");
    aliases.Add(29, "&&");
    aliases.Add(30, "==");
    aliases.Add(31, "!=");
    aliases.Add(32, "<");
    aliases.Add(33, ">");
    aliases.Add(34, "<=");
    aliases.Add(35, ">=");
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
      case 2: // Start -> P
#line 65 "Parser.y"
          { program = new Program(ValueStack[ValueStack.Depth-1].P); }
#line default
        break;
      case 3: // P -> P, Decl
#line 68 "Parser.y"
            { CurrentSemanticValue.P = ValueStack[ValueStack.Depth-2].P; CurrentSemanticValue.P.Add(ValueStack[ValueStack.Depth-1].DECL); }
#line default
        break;
      case 4: // P -> /* empty */
#line 69 "Parser.y"
            { CurrentSemanticValue.P = new List<Declaration>(); }
#line default
        break;
      case 5: // Decl -> Type, ID, "(", FormalList, ")", "{", S, "}"
#line 72 "Parser.y"
                                                  { CurrentSemanticValue.DECL = new Declaration(ValueStack[ValueStack.Depth-8].T, ValueStack[ValueStack.Depth-7].value, ValueStack[ValueStack.Depth-5].FL, ValueStack[ValueStack.Depth-2].S); CurrentSemanticValue.DECL.SetLocation(LocationStack[LocationStack.Depth-8]); }
#line default
        break;
      case 6: // Decl -> "void", ID, "(", FormalList, ")", "{", S, "}"
#line 73 "Parser.y"
                                                  { CurrentSemanticValue.DECL = new Declaration(Type_.NULL, ValueStack[ValueStack.Depth-7].value, ValueStack[ValueStack.Depth-5].FL, ValueStack[ValueStack.Depth-2].S); CurrentSemanticValue.DECL.SetLocation(LocationStack[LocationStack.Depth-8]); }
#line default
        break;
      case 7: // S -> S, Stmt
#line 76 "Parser.y"
              { CurrentSemanticValue.S = ValueStack[ValueStack.Depth-2].S; CurrentSemanticValue.S.Add(ValueStack[ValueStack.Depth-1].STMT); }
#line default
        break;
      case 8: // S -> /* empty */
#line 77 "Parser.y"
              { CurrentSemanticValue.S = new List<Statement>(); }
#line default
        break;
      case 9: // FormalList -> Type, ID, Fl
#line 80 "Parser.y"
                          { CurrentSemanticValue.FL = ValueStack[ValueStack.Depth-1].FL; CurrentSemanticValue.FL.Insert(0, new Parameter(ValueStack[ValueStack.Depth-3].T, ValueStack[ValueStack.Depth-2].value)); }
#line default
        break;
      case 10: // FormalList -> /* empty */
#line 81 "Parser.y"
                        { CurrentSemanticValue.FL = new List<Parameter>(); }
#line default
        break;
      case 11: // Fl -> ",", Type, ID, Fl
#line 84 "Parser.y"
                    { CurrentSemanticValue.FL = ValueStack[ValueStack.Depth-1].FL; CurrentSemanticValue.FL.Insert(0, new Parameter(ValueStack[ValueStack.Depth-3].T, ValueStack[ValueStack.Depth-2].value));}
#line default
        break;
      case 12: // Fl -> /* empty */
#line 85 "Parser.y"
                    { CurrentSemanticValue.FL = new List<Parameter>(); }
#line default
        break;
      case 13: // Type -> "int"
#line 88 "Parser.y"
              { CurrentSemanticValue.T =  Type_.INT;  }
#line default
        break;
      case 14: // Type -> "bool"
#line 89 "Parser.y"
              { CurrentSemanticValue.T =  Type_.BOOL; }
#line default
        break;
      case 15: // Stmt -> "{", S, "}"
#line 92 "Parser.y"
                                                { CurrentSemanticValue.STMT = new BlockStatement(ValueStack[ValueStack.Depth-2].S); CurrentSemanticValue.STMT.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 16: // Stmt -> "if", "(", Expr, ")", Stmt
#line 93 "Parser.y"
                                                { CurrentSemanticValue.STMT = new IfStatement(ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].STMT, null); CurrentSemanticValue.STMT.SetLocation(LocationStack[LocationStack.Depth-5]); }
#line default
        break;
      case 17: // Stmt -> "if", "(", Expr, ")", Stmt, "else", Stmt
#line 94 "Parser.y"
                                                { CurrentSemanticValue.STMT = new IfStatement(ValueStack[ValueStack.Depth-5].E, ValueStack[ValueStack.Depth-3].STMT, ValueStack[ValueStack.Depth-1].STMT); CurrentSemanticValue.STMT.SetLocation(LocationStack[LocationStack.Depth-7]); }
#line default
        break;
      case 18: // Stmt -> "while", "(", Expr, ")", Stmt
#line 95 "Parser.y"
                                                { CurrentSemanticValue.STMT = new WhileStatement(ValueStack[ValueStack.Depth-3].E, ValueStack[ValueStack.Depth-1].STMT); CurrentSemanticValue.STMT.SetLocation(LocationStack[LocationStack.Depth-5]); }
#line default
        break;
      case 19: // Stmt -> "return", Expr, ";"
#line 96 "Parser.y"
                                                { CurrentSemanticValue.STMT = new ReturnStatement(ValueStack[ValueStack.Depth-2].E); CurrentSemanticValue.STMT.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 20: // Stmt -> "return", ";"
#line 97 "Parser.y"
                                                { CurrentSemanticValue.STMT = new ReturnStatement(null); CurrentSemanticValue.STMT.SetLocation(LocationStack[LocationStack.Depth-2]); }
#line default
        break;
      case 21: // Stmt -> Expr, ";"
#line 98 "Parser.y"
                                                { CurrentSemanticValue.STMT = new ExpressionStatement(ValueStack[ValueStack.Depth-2].E); CurrentSemanticValue.STMT.SetLocation(LocationStack[LocationStack.Depth-2]); }
#line default
        break;
      case 22: // Stmt -> Type, ID, ";"
#line 99 "Parser.y"
                                                { CurrentSemanticValue.STMT = new DeclareStatement(ValueStack[ValueStack.Depth-3].T, ValueStack[ValueStack.Depth-2].value); CurrentSemanticValue.STMT.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 23: // Expr -> ID, "=", Expr
#line 102 "Parser.y"
                      { CurrentSemanticValue.E = new AssignmentExpression(ValueStack[ValueStack.Depth-3].value, ValueStack[ValueStack.Depth-1].E); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 25: // Eone -> Eone, "||", Etwo
#line 106 "Parser.y"
                      { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.OR, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 27: // Etwo -> Etwo, "&&", Ethree
#line 111 "Parser.y"
                        { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.AND, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 29: // Ethree -> Ethree, "==", Efour
#line 116 "Parser.y"
                           { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.EQ, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 30: // Ethree -> Ethree, "!=", Efour
#line 117 "Parser.y"
                        { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.NOT_EQ, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 32: // Efour -> Efour, "<", Efive
#line 121 "Parser.y"
                         { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.LESS, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 33: // Efour -> Efour, ">", Efive
#line 122 "Parser.y"
                       { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.GREATER, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 34: // Efour -> Efour, "<=", Efive
#line 123 "Parser.y"
                       { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.LESS_OR_EQ, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 35: // Efour -> Efour, ">=", Efive
#line 124 "Parser.y"
                       { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.GREATER_OR_EQ, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 37: // Efive -> Efive, "+", Esix
#line 128 "Parser.y"
                       { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.ADD, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 38: // Efive -> Efive, "-", Esix
#line 129 "Parser.y"
                       { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.SUB, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 40: // Esix -> Esix, "/", F
#line 133 "Parser.y"
                   { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.DIV, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 41: // Esix -> Esix, "*", F
#line 134 "Parser.y"
                 { CurrentSemanticValue.E = new BopExpression(ValueStack[ValueStack.Depth-3].E, BopExpression.Operator.MUL, ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 43: // F -> NUM
#line 138 "Parser.y"
               { CurrentSemanticValue.E = new NumberExpression(ValueStack[ValueStack.Depth-1].value); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 44: // F -> "true"
#line 139 "Parser.y"
               { CurrentSemanticValue.E = new BoolExpression(true); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 45: // F -> "false"
#line 140 "Parser.y"
                { CurrentSemanticValue.E = new BoolExpression(false); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 46: // F -> ID
#line 141 "Parser.y"
              { CurrentSemanticValue.E = new IdentifierExpression(ValueStack[ValueStack.Depth-1].value); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-1]); }
#line default
        break;
      case 47: // F -> "!", F
#line 142 "Parser.y"
                      { CurrentSemanticValue.E = new UopExpression(ValueStack[ValueStack.Depth-1].E, UopExpression.Operator.NOT); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-2]); }
#line default
        break;
      case 48: // F -> "-", F
#line 143 "Parser.y"
              { CurrentSemanticValue.E = new UopExpression(ValueStack[ValueStack.Depth-1].E, UopExpression.Operator.NEG); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-2]); }
#line default
        break;
      case 49: // F -> ID, "(", ExprList, ")"
#line 144 "Parser.y"
                         { CurrentSemanticValue.E = new LetExpression(ValueStack[ValueStack.Depth-4].value, ValueStack[ValueStack.Depth-2].EL); CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-4]); }
#line default
        break;
      case 50: // F -> "(", Expr, ")"
#line 145 "Parser.y"
                   { CurrentSemanticValue.E = ValueStack[ValueStack.Depth-2].E; CurrentSemanticValue.E.SetLocation(LocationStack[LocationStack.Depth-3]); }
#line default
        break;
      case 51: // ExprList -> Expr
#line 148 "Parser.y"
                                { CurrentSemanticValue.EL = new List<Expression>(); CurrentSemanticValue.EL.Add(ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 52: // ExprList -> ExprList, ",", Expr
#line 149 "Parser.y"
                              { CurrentSemanticValue.EL = ValueStack[ValueStack.Depth-3].EL; CurrentSemanticValue.EL.Add(ValueStack[ValueStack.Depth-1].E); }
#line default
        break;
      case 53: // ExprList -> /* empty */
#line 150 "Parser.y"
                                { CurrentSemanticValue.EL = new List<Expression>(); }
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

#line 154 "Parser.y"

public Parser( Scanner s ) : base( s ) { }
public Program program; 
#line default
}
}
