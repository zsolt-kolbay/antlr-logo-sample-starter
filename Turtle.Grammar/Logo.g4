grammar Logo;

// Parser rules
// Every identifier must start with a small letter.
// Recursive rules are allowed.
program: SOME_TOKEN;

// Lexer rules
// Every identifier must start with a capital letter.
// Rules cannot directly reference each other.
SOME_TOKEN: 'LOGO';