using System;
using System.IO;
using System.Runtime.Serialization;
using com.calitha.commons;

namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
            Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }

    [Serializable()]
    public class RuleException : System.Exception
    {

        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }

    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF = 0, // (EOF)
        SYMBOL_ERROR = 1, // (Error)
        SYMBOL_WHITESPACE = 2, // Whitespace
        SYMBOL_EXCLAMEQ = 3, // '!='
        SYMBOL_LPAREN = 4, // '('
        SYMBOL_RPAREN = 5, // ')'
        SYMBOL_COMMA = 6, // ','
        SYMBOL_COLON = 7, // ':'
        SYMBOL_SEMI = 8, // ';'
        SYMBOL_QUESTION = 9, // '?'
        SYMBOL_LBRACKET = 10, // '['
        SYMBOL_RBRACKET = 11, // ']'
        SYMBOL_LBRACE = 12, // '{'
        SYMBOL_RBRACE = 13, // '}'
        SYMBOL_LT = 14, // '<'
        SYMBOL_LTEQ = 15, // '<='
        SYMBOL_EQ = 16, // '='
        SYMBOL_EQEQ = 17, // '=='
        SYMBOL_GT = 18, // '>'
        SYMBOL_MINUSGT = 19, // '->'
        SYMBOL_GTEQ = 20, // '>='
        SYMBOL_AUTO = 21, // auto
        SYMBOL_BOOLEAN = 22, // Boolean
        SYMBOL_BUILD = 23, // build
        SYMBOL_CHOOSE = 24, // choose
        SYMBOL_DEF = 25, // def
        SYMBOL_DO = 26, // do
        SYMBOL_FACT = 27, // fact
        SYMBOL_FLOAT = 28, // Float
        SYMBOL_FOR = 29, // for
        SYMBOL_IDENTIFIER = 30, // Identifier
        SYMBOL_IN = 31, // in
        SYMBOL_INTEGER = 32, // Integer
        SYMBOL_LETTER = 33, // letter
        SYMBOL_LIST = 34, // list
        SYMBOL_LOGICALOPERATOR = 35, // LogicalOperator
        SYMBOL_MATHOPERATOR_HIGH_P = 36, // 'MathOperator_High_P'
        SYMBOL_MATHOPERATOR_LOW_P = 37, // 'MathOperator_Low_P'
        SYMBOL_NEW = 38, // new
        SYMBOL_NUM = 39, // num
        SYMBOL_OBJECT = 40, // object
        SYMBOL_PROC = 41, // proc
        SYMBOL_RETURN = 42, // return
        SYMBOL_SI = 43, // si
        SYMBOL_STRING = 44, // String
        SYMBOL_STRUCT = 45, // struct
        SYMBOL_TEXT = 46, // text
        SYMBOL_VOID = 47, // void
        SYMBOL_WHEN = 48, // when
        SYMBOL_WHILE = 49, // while
        SYMBOL_ARGS = 50, // <args>
        SYMBOL_ARGSMINUS = 51, // <args->
        SYMBOL_ARRAY = 52, // <array>
        SYMBOL_ARRAYMINUSARGS = 53, // <array-args>
        SYMBOL_ASSIGNMENT = 54, // <assignment>
        SYMBOL_BLOCK = 55, // <block>
        SYMBOL_BOOLEANOPERATOR = 56, // <BooleanOperator>
        SYMBOL_CHECKMINUSIFMINUSNOT = 57, // <check-if-not>
        SYMBOL_CHECKMINUSSTATE = 58, // <check-state>
        SYMBOL_CLASS = 59, // <class>
        SYMBOL_CONDITION = 60, // <condition>
        SYMBOL_DECLARATION = 61, // <declaration>
        SYMBOL_DECLARATION_LIST = 62, // <declaration_list>
        SYMBOL_DEFAULT_CASE = 63, // <default_case>
        SYMBOL_EXPR = 64, // <expr>
        SYMBOL_EXPRMINUS = 65, // <expr->
        SYMBOL_FACTOR = 66, // <factor>
        SYMBOL_GENERIC = 67, // <generic>
        SYMBOL_IFMINUSELSE = 68, // <if-else>
        SYMBOL_INHERITS = 69, // <inherits>
        SYMBOL_LIST2 = 70, // <list>
        SYMBOL_LISTMINUSARGS = 71, // <list-args>
        SYMBOL_LOGICAL_EXPR = 72, // <logical_expr>
        SYMBOL_LOOP = 73, // <loop>
        SYMBOL_METHOD_BLOCK = 74, // <method_block>
        SYMBOL_METHOD_CALL = 75, // <method_call>
        SYMBOL_METHOD_DECL = 76, // <method_decl>
        SYMBOL_OBJMINUSBODY = 77, // <obj-body>
        SYMBOL_OBJECT_DECLARATION = 78, // <object_declaration>
        SYMBOL_OPTION_CASE = 79, // <option_case>
        SYMBOL_OPTION_LIST = 80, // <option_list>
        SYMBOL_PARAM = 81, // <param>
        SYMBOL_PARAMS = 82, // <params>
        SYMBOL_PARAMSMINUS = 83, // <params->
        SYMBOL_PRIMITIVE_TYPE = 84, // <primitive_type>
        SYMBOL_PROGRAM = 85, // <program>
        SYMBOL_STMT = 86, // <stmt>
        SYMBOL_STMT_LIST = 87, // <stmt_list>
        SYMBOL_STRUCT2 = 88, // <struct>
        SYMBOL_STRUCTMINUSBLOCK = 89, // <struct-block>
        SYMBOL_SWITCH_STMT = 90, // <switch_stmt>
        SYMBOL_TERM = 91, // <term>
        SYMBOL_TERMMINUS = 92, // <term->
        SYMBOL_TERNARY_EXPR = 93, // <ternary_expr>
        SYMBOL_TYPE = 94  // <type>
    };

    enum RuleConstants : int
    {
        RULE_PROGRAM = 0, // <program> ::= <stmt_list>
        RULE_PROGRAM2 = 1, // <program> ::= 
        RULE_STMT_LIST = 2, // <stmt_list> ::= <stmt_list> <stmt>
        RULE_STMT_LIST2 = 3, // <stmt_list> ::= <stmt>
        RULE_STMT = 4, // <stmt> ::= <class>
        RULE_STMT2 = 5, // <stmt> ::= <struct>
        RULE_STMT3 = 6, // <stmt> ::= <if-else>
        RULE_STMT4 = 7, // <stmt> ::= <switch_stmt>
        RULE_STMT5 = 8, // <stmt> ::= <loop>
        RULE_STMT6 = 9, // <stmt> ::= <method_decl>
        RULE_STMT_SEMI = 10, // <stmt> ::= <method_call> ';'
        RULE_STMT_SEMI2 = 11, // <stmt> ::= <declaration> ';'
        RULE_STMT_SEMI3 = 12, // <stmt> ::= <object_declaration> ';'
        RULE_STMT_SEMI4 = 13, // <stmt> ::= <assignment> ';'
        RULE_BLOCK_LBRACE_RBRACE = 14, // <block> ::= '{' <stmt_list> '}'
        RULE_BLOCK = 15, // <block> ::= <stmt>
        RULE_BLOCK_SEMI = 16, // <block> ::= ';'
        RULE_DECLARATION_IDENTIFIER = 17, // <declaration> ::= <type> Identifier
        RULE_DECLARATION = 18, // <declaration> ::= <type> <assignment>
        RULE_ASSIGNMENT_IDENTIFIER_EQ = 19, // <assignment> ::= Identifier '=' <expr>
        RULE_DECLARATION_LIST_SEMI = 20, // <declaration_list> ::= <declaration_list> <declaration> ';'
        RULE_DECLARATION_LIST_SEMI2 = 21, // <declaration_list> ::= <declaration> ';'
        RULE_OBJBODY_EQ_NEW_LPAREN_RPAREN = 22, // <obj-body> ::= '=' new '(' <args> ')'
        RULE_OBJBODY = 23, // <obj-body> ::= 
        RULE_OBJECT_DECLARATION_OBJECT_IDENTIFIER_IDENTIFIER = 24, // <object_declaration> ::= object Identifier Identifier <obj-body>
        RULE_GENERIC_LT_IDENTIFIER_GT = 25, // <generic> ::= '<' Identifier '>'
        RULE_GENERIC = 26, // <generic> ::= 
        RULE_INHERITS_COLON_IDENTIFIER = 27, // <inherits> ::= ':' Identifier
        RULE_INHERITS = 28, // <inherits> ::= 
        RULE_CLASS_BUILD_IDENTIFIER = 29, // <class> ::= build Identifier <generic> <inherits> <block>
        RULE_STRUCT_STRUCT_IDENTIFIER = 30, // <struct> ::= struct Identifier <struct-block>
        RULE_STRUCTBLOCK_LBRACE_RBRACE = 31, // <struct-block> ::= '{' <declaration_list> '}'
        RULE_STRUCTBLOCK_LBRACE_RBRACE2 = 32, // <struct-block> ::= '{' '}'
        RULE_STRUCTBLOCK_SEMI = 33, // <struct-block> ::= <declaration> ';'
        RULE_STRUCTBLOCK_SEMI2 = 34, // <struct-block> ::= ';'
        RULE_IFELSE = 35, // <if-else> ::= <check-state> <check-if-not>
        RULE_CHECKSTATE_SI_LPAREN_RPAREN = 36, // <check-state> ::= si '(' <condition> ')' <block>
        RULE_CHECKIFNOT_MINUSGT = 37, // <check-if-not> ::= '->' <block>
        RULE_BOOLEANOPERATOR_EQEQ = 38, // <BooleanOperator> ::= '=='
        RULE_BOOLEANOPERATOR_EXCLAMEQ = 39, // <BooleanOperator> ::= '!='
        RULE_BOOLEANOPERATOR_LT = 40, // <BooleanOperator> ::= '<'
        RULE_BOOLEANOPERATOR_GT = 41, // <BooleanOperator> ::= '>'
        RULE_BOOLEANOPERATOR_LTEQ = 42, // <BooleanOperator> ::= '<='
        RULE_BOOLEANOPERATOR_GTEQ = 43, // <BooleanOperator> ::= '>='
        RULE_CONDITION = 44, // <condition> ::= <expr> <BooleanOperator> <expr>
        RULE_CONDITION_LOGICALOPERATOR = 45, // <condition> ::= <expr> LogicalOperator <expr>
        RULE_CONDITION_BOOLEAN = 46, // <condition> ::= Boolean
        RULE_SWITCH_STMT_CHOOSE_LPAREN_RPAREN_LBRACE_RBRACE = 47, // <switch_stmt> ::= choose '(' <expr> ')' '{' <option_list> <default_case> '}'
        RULE_OPTION_LIST = 48, // <option_list> ::= <option_list> <option_case>
        RULE_OPTION_LIST2 = 49, // <option_list> ::= <option_case>
        RULE_OPTION_CASE_WHEN_COLON = 50, // <option_case> ::= when <expr> ':' <block>
        RULE_DEFAULT_CASE_DEF_COLON = 51, // <default_case> ::= def ':' <block>
        RULE_DEFAULT_CASE = 52, // <default_case> ::= 
        RULE_LOOP_DO_LBRACE_RBRACE_WHILE_LPAREN_RPAREN = 53, // <loop> ::= do '{' <stmt_list> '}' while '(' <condition> ')'
        RULE_LOOP_WHILE_LPAREN_RPAREN = 54, // <loop> ::= while '(' <condition> ')' <block>
        RULE_LOOP_FOR_IDENTIFIER_IN = 55, // <loop> ::= for Identifier in <expr> <block>
        RULE_METHOD_DECL_PROC_IDENTIFIER_COLON_VOID_LPAREN_RPAREN = 56, // <method_decl> ::= proc Identifier ':' void '(' <params> ')' <block>
        RULE_METHOD_DECL_PROC_IDENTIFIER_COLON_LPAREN_RPAREN_LBRACE_RETURN_SEMI_RBRACE = 57, // <method_decl> ::= proc Identifier ':' <type> '(' <params> ')' '{' <method_block> return <expr> ';' '}'
        RULE_METHOD_BLOCK = 58, // <method_block> ::= 
        RULE_METHOD_BLOCK2 = 59, // <method_block> ::= <stmt_list>
        RULE_PARAMS = 60, // <params> ::= <param> <params->
        RULE_PARAMS_COMMA = 61, // <params-> ::= ',' <param> <params->
        RULE_PARAMS2 = 62, // <params-> ::= 
        RULE_PARAM_IDENTIFIER = 63, // <param> ::= <type> Identifier
        RULE_METHOD_CALL_IDENTIFIER_LPAREN_RPAREN = 64, // <method_call> ::= Identifier '(' <args> ')'
        RULE_ARGS = 65, // <args> ::= <expr> <args->
        RULE_ARGS_COMMA = 66, // <args-> ::= ',' <expr> <args->
        RULE_ARGS2 = 67, // <args-> ::= 
        RULE_EXPR = 68, // <expr> ::= <ternary_expr>
        RULE_TERNARY_EXPR_QUESTION_COLON = 69, // <ternary_expr> ::= <logical_expr> '?' <expr> ':' <expr>
        RULE_TERNARY_EXPR = 70, // <ternary_expr> ::= <logical_expr>
        RULE_LOGICAL_EXPR = 71, // <logical_expr> ::= <term> <expr->
        RULE_EXPR_MATHOPERATOR_LOW_P = 72, // <expr-> ::= 'MathOperator_Low_P' <term> <expr->
        RULE_EXPR2 = 73, // <expr-> ::= 
        RULE_TERM = 74, // <term> ::= <factor> <term->
        RULE_TERM_MATHOPERATOR_HIGH_P = 75, // <term-> ::= 'MathOperator_High_P' <factor> <term->
        RULE_TERM2 = 76, // <term-> ::= 
        RULE_FACTOR = 77, // <factor> ::= <method_call>
        RULE_FACTOR_INTEGER = 78, // <factor> ::= Integer
        RULE_FACTOR_FLOAT = 79, // <factor> ::= Float
        RULE_FACTOR_STRING = 80, // <factor> ::= String
        RULE_FACTOR_BOOLEAN = 81, // <factor> ::= Boolean
        RULE_FACTOR_IDENTIFIER = 82, // <factor> ::= Identifier
        RULE_FACTOR_LPAREN_RPAREN = 83, // <factor> ::= '(' <expr> ')'
        RULE_TYPE = 84, // <type> ::= <primitive_type>
        RULE_TYPE2 = 85, // <type> ::= <array>
        RULE_TYPE3 = 86, // <type> ::= <list>
        RULE_TYPE_IDENTIFIER = 87, // <type> ::= Identifier
        RULE_PRIMITIVE_TYPE_FACT = 88, // <primitive_type> ::= fact
        RULE_PRIMITIVE_TYPE_TEXT = 89, // <primitive_type> ::= text
        RULE_PRIMITIVE_TYPE_LETTER = 90, // <primitive_type> ::= letter
        RULE_PRIMITIVE_TYPE_AUTO = 91, // <primitive_type> ::= auto
        RULE_PRIMITIVE_TYPE_NUM = 92, // <primitive_type> ::= num
        RULE_ARRAY_LBRACKET_RBRACKET = 93, // <array> ::= <type> '[' <array-args> ']'
        RULE_ARRAYARGS_COMMA_INTEGER = 94, // <array-args> ::= <array-args> ',' Integer
        RULE_ARRAYARGS_INTEGER = 95, // <array-args> ::= Integer
        RULE_ARRAYARGS = 96, // <array-args> ::= 
        RULE_LIST_LIST_LT_GT = 97, // <list> ::= list '<' <list-args> '>'
        RULE_LISTARGS_COMMA = 98, // <list-args> ::= <list-args> ',' <type>
        RULE_LISTARGS = 99, // <list-args> ::= <type>
        RULE_LISTARGS2 = 100  // <list-args> ::= 
    };

    public delegate void ErrorEventHandler(int line, string unExpected, string expected);
    public delegate void ReadTokenEventHandler(int id, string token);
    public class MyParser
    {
        private LALRParser parser;
        public event ErrorEventHandler OnError;
        public event ReadTokenEventHandler OnReadToken;

        public MyParser(string filename)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open, 
                                               FileAccess.Read, 
                                               FileShare.Read);
            Init(stream);
            stream.Close();
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnReduce += ReduceEvent;
            parser.OnTokenRead += TokenReadEvent;
            parser.OnAccept += AcceptEvent;
            parser.OnTokenError += TokenErrorEvent;
            parser.OnParseError += ParseErrorEvent;
        }

        

        public void Parse(string source)
        {
            parser.Parse(source);

        }


        private Object CreateObject(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF:
                    //(EOF)
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_ERROR:
                    //(Error)
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE:
                    //Whitespace
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_EXCLAMEQ:
                    //'!='
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LPAREN:
                    //'('
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_RPAREN:
                    //')'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_COMMA:
                    //','
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_COLON:
                    //':'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_SEMI:
                    //';'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_QUESTION:
                    //'?'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LBRACKET:
                    //'['
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_RBRACKET:
                    //']'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LBRACE:
                    //'{'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_RBRACE:
                    //'}'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LT:
                    //'<'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LTEQ:
                    //'<='
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_EQ:
                    //'='
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_EQEQ:
                    //'=='
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_GT:
                    //'>'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_MINUSGT:
                    //'->'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_GTEQ:
                    //'>='
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_AUTO:
                    //auto
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_BOOLEAN:
                    //Boolean
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_BUILD:
                    //build
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_CHOOSE:
                    //choose
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_DEF:
                    //def
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_DO:
                    //do
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_FACT:
                    //fact
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_FLOAT:
                    //Float
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_FOR:
                    //for
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_IDENTIFIER:
                    //Identifier
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_IN:
                    //in
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_INTEGER:
                    //Integer
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LETTER:
                    //letter
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LIST:
                    //list
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LOGICALOPERATOR:
                    //LogicalOperator
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_MATHOPERATOR_HIGH_P:
                    //'MathOperator_High_P'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_MATHOPERATOR_LOW_P:
                    //'MathOperator_Low_P'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_NEW:
                    //new
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_NUM:
                    //num
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_OBJECT:
                    //object
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_PROC:
                    //proc
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_RETURN:
                    //return
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_SI:
                    //si
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_STRING:
                    //String
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_STRUCT:
                    //struct
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_TEXT:
                    //text
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_VOID:
                    //void
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_WHEN:
                    //when
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_WHILE:
                    //while
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_ARGS:
                    //<args>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_ARGSMINUS:
                    //<args->
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_ARRAY:
                    //<array>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_ARRAYMINUSARGS:
                    //<array-args>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_ASSIGNMENT:
                    //<assignment>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_BLOCK:
                    //<block>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_BOOLEANOPERATOR:
                    //<BooleanOperator>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_CHECKMINUSIFMINUSNOT:
                    //<check-if-not>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_CHECKMINUSSTATE:
                    //<check-state>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_CLASS:
                    //<class>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_CONDITION:
                    //<condition>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_DECLARATION:
                    //<declaration>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_DECLARATION_LIST:
                    //<declaration_list>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_DEFAULT_CASE:
                    //<default_case>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_EXPR:
                    //<expr>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_EXPRMINUS:
                    //<expr->
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_FACTOR:
                    //<factor>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_GENERIC:
                    //<generic>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_IFMINUSELSE:
                    //<if-else>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_INHERITS:
                    //<inherits>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LIST2:
                    //<list>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LISTMINUSARGS:
                    //<list-args>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LOGICAL_EXPR:
                    //<logical_expr>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LOOP:
                    //<loop>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_METHOD_BLOCK:
                    //<method_block>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_METHOD_CALL:
                    //<method_call>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_METHOD_DECL:
                    //<method_decl>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_OBJMINUSBODY:
                    //<obj-body>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_OBJECT_DECLARATION:
                    //<object_declaration>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_OPTION_CASE:
                    //<option_case>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_OPTION_LIST:
                    //<option_list>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_PARAM:
                    //<param>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_PARAMS:
                    //<params>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_PARAMSMINUS:
                    //<params->
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_PRIMITIVE_TYPE:
                    //<primitive_type>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_PROGRAM:
                    //<program>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_STMT:
                    //<stmt>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_STMT_LIST:
                    //<stmt_list>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_STRUCT2:
                    //<struct>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_STRUCTMINUSBLOCK:
                    //<struct-block>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_SWITCH_STMT:
                    //<switch_stmt>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_TERM:
                    //<term>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_TERMMINUS:
                    //<term->
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_TERNARY_EXPR:
                    //<ternary_expr>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_TYPE:
                    //<type>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

            }
            throw new SymbolException("Unknown symbol");
        }
        private void ReduceEvent(LALRParser parser, ReduceEventArgs args)
        {
            try
            {
                args.Token.UserObject = CreateObject(args.Token);
            }
            catch (Exception e)
            {
                args.Continue = false;
                //todo: Report message to UI?
            }
        }
        public static Object CreateObject(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_PROGRAM:
                    //<program> ::= <stmt_list>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_PROGRAM2:
                    //<program> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT_LIST:
                    //<stmt_list> ::= <stmt_list> <stmt>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT_LIST2:
                    //<stmt_list> ::= <stmt>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT:
                    //<stmt> ::= <class>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT2:
                    //<stmt> ::= <struct>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT3:
                    //<stmt> ::= <if-else>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT4:
                    //<stmt> ::= <switch_stmt>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT5:
                    //<stmt> ::= <loop>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT6:
                    //<stmt> ::= <method_decl>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT_SEMI:
                    //<stmt> ::= <method_call> ';'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT_SEMI2:
                    //<stmt> ::= <declaration> ';'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT_SEMI3:
                    //<stmt> ::= <object_declaration> ';'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STMT_SEMI4:
                    //<stmt> ::= <assignment> ';'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_BLOCK_LBRACE_RBRACE:
                    //<block> ::= '{' <stmt_list> '}'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_BLOCK:
                    //<block> ::= <stmt>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_BLOCK_SEMI:
                    //<block> ::= ';'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_DECLARATION_IDENTIFIER:
                    //<declaration> ::= <type> Identifier
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_DECLARATION:
                    //<declaration> ::= <type> <assignment>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_ASSIGNMENT_IDENTIFIER_EQ:
                    //<assignment> ::= Identifier '=' <expr>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_DECLARATION_LIST_SEMI:
                    //<declaration_list> ::= <declaration_list> <declaration> ';'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_DECLARATION_LIST_SEMI2:
                    //<declaration_list> ::= <declaration> ';'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_OBJBODY_EQ_NEW_LPAREN_RPAREN:
                    //<obj-body> ::= '=' new '(' <args> ')'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_OBJBODY:
                    //<obj-body> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_OBJECT_DECLARATION_OBJECT_IDENTIFIER_IDENTIFIER:
                    //<object_declaration> ::= object Identifier Identifier <obj-body>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_GENERIC_LT_IDENTIFIER_GT:
                    //<generic> ::= '<' Identifier '>'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_GENERIC:
                    //<generic> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_INHERITS_COLON_IDENTIFIER:
                    //<inherits> ::= ':' Identifier
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_INHERITS:
                    //<inherits> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_CLASS_BUILD_IDENTIFIER:
                    //<class> ::= build Identifier <generic> <inherits> <block>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STRUCT_STRUCT_IDENTIFIER:
                    //<struct> ::= struct Identifier <struct-block>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STRUCTBLOCK_LBRACE_RBRACE:
                    //<struct-block> ::= '{' <declaration_list> '}'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STRUCTBLOCK_LBRACE_RBRACE2:
                    //<struct-block> ::= '{' '}'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STRUCTBLOCK_SEMI:
                    //<struct-block> ::= <declaration> ';'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_STRUCTBLOCK_SEMI2:
                    //<struct-block> ::= ';'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_IFELSE:
                    //<if-else> ::= <check-state> <check-if-not>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_CHECKSTATE_SI_LPAREN_RPAREN:
                    //<check-state> ::= si '(' <condition> ')' <block>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_CHECKIFNOT_MINUSGT:
                    //<check-if-not> ::= '->' <block>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_BOOLEANOPERATOR_EQEQ:
                    //<BooleanOperator> ::= '=='
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_BOOLEANOPERATOR_EXCLAMEQ:
                    //<BooleanOperator> ::= '!='
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_BOOLEANOPERATOR_LT:
                    //<BooleanOperator> ::= '<'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_BOOLEANOPERATOR_GT:
                    //<BooleanOperator> ::= '>'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_BOOLEANOPERATOR_LTEQ:
                    //<BooleanOperator> ::= '<='
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_BOOLEANOPERATOR_GTEQ:
                    //<BooleanOperator> ::= '>='
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_CONDITION:
                    //<condition> ::= <expr> <BooleanOperator> <expr>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_CONDITION_LOGICALOPERATOR:
                    //<condition> ::= <expr> LogicalOperator <expr>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_CONDITION_BOOLEAN:
                    //<condition> ::= Boolean
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_SWITCH_STMT_CHOOSE_LPAREN_RPAREN_LBRACE_RBRACE:
                    //<switch_stmt> ::= choose '(' <expr> ')' '{' <option_list> <default_case> '}'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_OPTION_LIST:
                    //<option_list> ::= <option_list> <option_case>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_OPTION_LIST2:
                    //<option_list> ::= <option_case>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_OPTION_CASE_WHEN_COLON:
                    //<option_case> ::= when <expr> ':' <block>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_DEFAULT_CASE_DEF_COLON:
                    //<default_case> ::= def ':' <block>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_DEFAULT_CASE:
                    //<default_case> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_LOOP_DO_LBRACE_RBRACE_WHILE_LPAREN_RPAREN:
                    //<loop> ::= do '{' <stmt_list> '}' while '(' <condition> ')'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_LOOP_WHILE_LPAREN_RPAREN:
                    //<loop> ::= while '(' <condition> ')' <block>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_LOOP_FOR_IDENTIFIER_IN:
                    //<loop> ::= for Identifier in <expr> <block>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_METHOD_DECL_PROC_IDENTIFIER_COLON_VOID_LPAREN_RPAREN:
                    //<method_decl> ::= proc Identifier ':' void '(' <params> ')' <block>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_METHOD_DECL_PROC_IDENTIFIER_COLON_LPAREN_RPAREN_LBRACE_RETURN_SEMI_RBRACE:
                    //<method_decl> ::= proc Identifier ':' <type> '(' <params> ')' '{' <method_block> return <expr> ';' '}'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_METHOD_BLOCK:
                    //<method_block> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_METHOD_BLOCK2:
                    //<method_block> ::= <stmt_list>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_PARAMS:
                    //<params> ::= <param> <params->
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_PARAMS_COMMA:
                    //<params-> ::= ',' <param> <params->
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_PARAMS2:
                    //<params-> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_PARAM_IDENTIFIER:
                    //<param> ::= <type> Identifier
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_METHOD_CALL_IDENTIFIER_LPAREN_RPAREN:
                    //<method_call> ::= Identifier '(' <args> ')'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_ARGS:
                    //<args> ::= <expr> <args->
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_ARGS_COMMA:
                    //<args-> ::= ',' <expr> <args->
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_ARGS2:
                    //<args-> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_EXPR:
                    //<expr> ::= <ternary_expr>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_TERNARY_EXPR_QUESTION_COLON:
                    //<ternary_expr> ::= <logical_expr> '?' <expr> ':' <expr>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_TERNARY_EXPR:
                    //<ternary_expr> ::= <logical_expr>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_LOGICAL_EXPR:
                    //<logical_expr> ::= <term> <expr->
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_EXPR_MATHOPERATOR_LOW_P:
                    //<expr-> ::= 'MathOperator_Low_P' <term> <expr->
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_EXPR2:
                    //<expr-> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_TERM:
                    //<term> ::= <factor> <term->
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_TERM_MATHOPERATOR_HIGH_P:
                    //<term-> ::= 'MathOperator_High_P' <factor> <term->
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_TERM2:
                    //<term-> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_FACTOR:
                    //<factor> ::= <method_call>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_FACTOR_INTEGER:
                    //<factor> ::= Integer
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_FACTOR_FLOAT:
                    //<factor> ::= Float
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_FACTOR_STRING:
                    //<factor> ::= String
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_FACTOR_BOOLEAN:
                    //<factor> ::= Boolean
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_FACTOR_IDENTIFIER:
                    //<factor> ::= Identifier
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_FACTOR_LPAREN_RPAREN:
                    //<factor> ::= '(' <expr> ')'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_TYPE:
                    //<type> ::= <primitive_type>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_TYPE2:
                    //<type> ::= <array>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_TYPE3:
                    //<type> ::= <list>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_TYPE_IDENTIFIER:
                    //<type> ::= Identifier
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_PRIMITIVE_TYPE_FACT:
                    //<primitive_type> ::= fact
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_PRIMITIVE_TYPE_TEXT:
                    //<primitive_type> ::= text
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_PRIMITIVE_TYPE_LETTER:
                    //<primitive_type> ::= letter
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_PRIMITIVE_TYPE_AUTO:
                    //<primitive_type> ::= auto
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_PRIMITIVE_TYPE_NUM:
                    //<primitive_type> ::= num
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_ARRAY_LBRACKET_RBRACKET:
                    //<array> ::= <type> '[' <array-args> ']'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_ARRAYARGS_COMMA_INTEGER:
                    //<array-args> ::= <array-args> ',' Integer
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_ARRAYARGS_INTEGER:
                    //<array-args> ::= Integer
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_ARRAYARGS:
                    //<array-args> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_LIST_LIST_LT_GT:
                    //<list> ::= list '<' <list-args> '>'
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_LISTARGS_COMMA:
                    //<list-args> ::= <list-args> ',' <type>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_LISTARGS:
                    //<list-args> ::= <type>
                    //todo: Create a new object using the stored user objects.
                    return null;

                case (int)RuleConstants.RULE_LISTARGS2:
                    //<list-args> ::= 
                    //todo: Create a new object using the stored user objects.
                    return null;

            }
            throw new RuleException("Unknown rule");
        }
        private void AcceptEvent(LALRParser parser, AcceptEventArgs args)
        {
            //todo: Use your fully reduced args.Token.UserObject
        }
        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '"+args.Token.ToString()+"'";
            //todo: Report message to UI?
        }
        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            OnError.Invoke(args.UnexpectedToken.Location.LineNr, args.UnexpectedToken.Text, args.ExpectedTokens.ToString());
        }
        private void TokenReadEvent(LALRParser parser, TokenReadEventArgs args)
        {
            try
            {
                OnReadToken(args.Token.Symbol.Id, args.Token.Symbol.Name);

                args.Token.UserObject = CreateObject(args.Token);
            }
            catch (Exception e)
            {
                args.Continue = false;
                //todo: Report message to UI?
            }
        }
    }
}
