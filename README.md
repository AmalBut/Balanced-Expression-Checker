# Balanced Expression Checker

This is a simple C# program to check whether a given expression has balanced parentheses, brackets, and braces. It uses a stack-based approach to evaluate if the expression is balanced.

## Features

- Checks for balanced parentheses `()`, curly braces `{}`, and square brackets `[]`.
- Handles invalid input gracefully using exception handling.
- Demonstrates stack operations (push, pop, and top).

## How It Works

1. The program reads an expression from the user.
2. It evaluates the expression using a stack:
   - Opening brackets (`{`, `[`, `(`) are pushed onto the stack.
   - Closing brackets (`}`, `]`, `)`) are matched with the top of the stack. If matched, the opening bracket is popped.
   - If there is no matching bracket or the stack is empty when a closing bracket is encountered, the expression is considered unbalanced.
3. After processing the entire expression:
   - If the stack is empty, the expression is balanced.
   - If the stack is not empty, the expression is unbalanced.
