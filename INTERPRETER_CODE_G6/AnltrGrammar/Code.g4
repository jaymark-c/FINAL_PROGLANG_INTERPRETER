grammar Code;

/*Parser rules*/
program: 'BEGIN CODE' NEWLINE statements* 'END CODE';
statements: statement+ ;
statement: (vardec | assignment | functionCall) NEWLINE;
vardec: DATATYPE declaratorlist;
assignment: assignmentList '=' value;
assignmentList: VARIABLENAME ('=' VARIABLENAME)*;
functionCall: FUNCTIONNAME ': ' ( value (',' value)*)?;
declarator: VARIABLENAME | VARIABLENAME '=' value;
declaratorlist: declarator | declarator ',' declaratorlist;
constant: CHARVAL | INTEGERVAL | FLOATVAL | BOOLVAL | STRINGVAL;
value:
     ('+'|'-')? constant	# constantExpression
	| '(' value ')'         #parenthesizedExpression
	| '&' value             #firstnewlineExpression
	| value '&'             #lastnewlineExpression
	| 'NOT' value           #notBoolExpression
	| VARIABLENAME			# variablenameExpression
	| functionCall			# functionCallExpression
	| value compareOp value	# comparisonExpression
	| value logicalOp value	# logicalOpExpression
	| value multOp value	# multiplicativeExpression
	| value addOp value		# additiveExpression
	| NEWLINEOP             # newlineopExpression
	| value concOp value	# concatenateExpression
	;
multOp: '*' | '/' | '%';
addOp: '+' | '-';
compareOp: '>' | '<' | '>=' | '<=' | '==' | '<>';
logicalOp: 'AND' | 'OR';
concOp: '&';
assgnOp: '=';

/*Lexer rules*/
NEWLINEOP: '$';
DATATYPE: 'BOOL' | 'CHAR' | 'INT' | 'FLOAT';
BOOLVAL: 'TRUE' | 'FALSE';
CHARVAL: '\'' ([a-z] | [A-Z] | [0-9]) '\'';
INTEGERVAL: [1-9][0-9]*;
FLOATVAL: ('-')? [0-9]+ '.' ('-')? [0-9]+;
STRINGVAL: ('"' ~'"'* '"') | ('[' ~']'* ']'+);
WS: [ \t\r]+ -> skip;
NEWLINE: [\r\n];
FUNCTIONNAME: 'DISPLAY' | 'SCAN';
VARIABLENAME: [_a-z][a-zA-Z0-9_]* | [a-z][a-zA-Z0-9_]*;
COMMENT: '#' ~[\r\n]* [\n]-> skip;
