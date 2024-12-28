grammar Expression;

prog: (statement)* EOF;

statement: arrayDeclaration;

arrayDeclaration: 'array' ID '=' '[' (INT (',' INT)*)? ']';

ID: [a-zA-Z_][a-zA-Z_0-9]*;
INT: [0-9]+;

WS: [ \t\r\n]+ -> skip;
