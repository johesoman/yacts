﻿%output=Generated/Parser.cs
%namespace Parser

%union {
	public string value;

	public Program Program;
	public FunctionDefinition Decl;
	public List<FunctionDefinition> DeclList;
	public Expression Expr;
	public List<Expression> ExprList;
	public Statement Stmt;
	public List<Statement> StmtList;
	public List<VariableDeclaration> FormalList;
	public Type Type;
}

%token <value> ID
%token <value> BOOL
%token <value> INT
%token <value> ERR

%token IF "if", ELSE "else", WHILE "while", RETURN "return"
%token INTTYPE "int", BOOLTYPE "bool", VOIDTYPE "void"
%token LPAR "(", RPAR ")", LCUR "{", RCUR "}", SEMI ";", COMMA ","

%right ASN "="
%left OR "||"
%left AND "&&"
%left EQ "==", NEQ "!="
%left LT "<", GT ">", LEQ "<=", GEQ ">="
%left ADD "+", SUB "-"
%left MUL "*", DIV "/"
%left UMINUS, NOT "!"

%type <Program> Program
%type <DeclList> DeclList
%type <Decl> Decl
%type <Expr> Expr
%type <Expr> Expr1

%type <ExprList> ExprList
%type <ExprList> ExprRest

%type <Stmt> Stmt
%type <StmtList> StmtList

%type <FormalList> FormalList
%type <FormalList> FormalRest

%type <Type> Type

%start Program



%%


Program : DeclList EOF
{
	program = new Program($1);
}
        ;

DeclList : DeclList Decl 
{
	$1.Add($2);
	$$ = $1;
}
         |
{
	$$ = new List<FunctionDefinition>();
}
         ;

Decl : "void" ID "(" FormalList ")" "{" StmtList "}" 
{
	$$ = new FunctionDefinition(Type.VOID, $2, $4, $7);
	$$.SetLocation(@$);
}    
     | Type ID "(" FormalList ")" "{" StmtList "}"
{
	$$ = new FunctionDefinition($1, $2, $4, $7);
	$$.SetLocation(@$);
} 
     ;

FormalList : Type ID FormalRest 
{
	$3.Add(new VariableDeclaration($1,$2));
	$3.Reverse();
	$$ = $3;
}
           |
{
	$$ = new List<VariableDeclaration>();
}
           ;

FormalRest : "," Type ID FormalRest
{
	$4.Add(new VariableDeclaration($2,$3));
	$$ = $4;
}
           | 
{
	$$ = new List<VariableDeclaration>();
}
           ;

StmtList : StmtList Stmt
{
	$1.Add($2);
	$$ = $1;
}
         | 
{
	$$ = new List<Statement>();
}
         ;

Stmt : "{" StmtList "}"
{
	$$ = new BlockStatement($2);
	$$.SetLocation(@$);
}
     | "if" "(" Expr ")" Stmt 
{
	$$ = new IfStatement($3, $5, null);
	$$.SetLocation(@$);
}
     | "if" "(" Expr ")" Stmt "else" Stmt
{
	$$ = new IfStatement($3, $5, $7);
	$$.SetLocation(@$);
}
     | "while" "(" Expr ")" Stmt
{
	$$ = new WhileStatement($3, $5);
	$$.SetLocation(@$);
}
     | "return" Expr ";"
{
	$$ = new ReturnStatement($2);
	$$.SetLocation(@$);
}
     | "return" ";"
{
	$$ = new ReturnStatement(null);
	$$.SetLocation(@$);
}
     | Expr ";"
{
	$$ = new ExpressionStatement($1);
	$$.SetLocation(@$);
}
     | Type ID ";"
{
	$$ = new VariableDeclarationStatement($1, $2);
	$$.SetLocation(@$);
}
     ;

Expr : ID "=" Expr
{
	$$ = new AssignmentExpression($1, $3);
	$$.SetLocation(@$);
}

     | Expr "||" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.OR, $1, $3);
	$$.SetLocation(@$);
}
     | Expr "&&" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.AND, $1, $3);
	$$.SetLocation(@$);
}   

     | Expr "==" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.EQ, $1, $3);
	$$.SetLocation(@$);
}
     | Expr "!=" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.NEQ, $1, $3);
	$$.SetLocation(@$);
}
     | Expr ">=" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.GEQ, $1, $3);
	$$.SetLocation(@$);
}
     | Expr "<=" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.LEQ, $1, $3);
	$$.SetLocation(@$);
}
     | Expr ">" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.GT, $1, $3);
	$$.SetLocation(@$);
}
     | Expr "<" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.LT, $1, $3);
	$$.SetLocation(@$);
}

     | Expr "+" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.ADD, $1, $3);
	$$.SetLocation(@$);
}
     | Expr "-" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.SUB, $1, $3);
	$$.SetLocation(@$);
}
     | Expr "*" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.MUL, $1, $3);
	$$.SetLocation(@$);
}
     | Expr "/" Expr
{
	$$ = new BinaryOperatorExpression(BinaryOperatorExpression.OperatorType.DIV, $1, $3);
	$$.SetLocation(@$);
}
	 | Expr1
{ 
	$$ = $1;
}
	 ;

Expr1 : "-" Expr1 %prec UMINUS
{
	$$ = new UnaryOperatorExpression(UnaryOperatorExpression.OperatorType.NEG, $2);
	$$.SetLocation(@$);
}
     | "!" Expr1 %prec NOT
{
	$$ = new UnaryOperatorExpression(UnaryOperatorExpression.OperatorType.NOT, $2);
	$$.SetLocation(@$);
}
     | INT
{
	$$ = new IntegerLiteralExpression($1);
	$$.SetLocation(@$);
}
     | BOOL
{
	$$ = new BooleanLiteralExpression($1);
	$$.SetLocation(@$);
}
     | ID
{
	$$ = new VariableExpression($1);
	$$.SetLocation(@$);
}
     | ID "(" ExprList ")"
{
	$$ = new FunctionCallExpression($1,$3);
	$$.SetLocation(@$);
}
     | "(" Expr ")"
{
	$$ = $2;
	$$.SetLocation(@$);
}
     ;


ExprList : Expr ExprRest
{
	$2.Add($1);
	$2.Reverse();
	$$ = $2;
}
         | 
{
	$$ = new List<Expression>();
}
         ;

ExprRest : "," Expr ExprRest
{
	$3.Add($2);
	$$ = $3;
}
         | 
{
	$$ = new List<Expression>();
}
         ;

Type : "int"
{
	$$ = Type.INT;
}
     | "bool"
{
	$$ = Type.BOOL;
}
     ;

%%

public Program program;
public Parser( Scanner s ) : base( s ) { }
