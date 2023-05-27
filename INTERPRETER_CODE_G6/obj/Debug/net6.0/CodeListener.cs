﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\JMARK\Git Repositories\Programming Language Interpreter\INTERPRETER_CODE_G6\INTERPRETER_CODE_G6\Grammar\Code.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace INTERPRETER_CODE_G6.Grammar {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CodeParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ICodeListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] CodeParser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] CodeParser.ConstantExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpression([NotNull] CodeParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpression([NotNull] CodeParser.ParenthesizedExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>notBoolExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotBoolExpression([NotNull] CodeParser.NotBoolExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notBoolExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotBoolExpression([NotNull] CodeParser.NotBoolExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] CodeParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] CodeParser.IdentifierExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>newLineExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewLineExpression([NotNull] CodeParser.NewLineExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>newLineExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewLineExpression([NotNull] CodeParser.NewLineExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>colonFuncExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColonFuncExpression([NotNull] CodeParser.ColonFuncExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>colonFuncExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColonFuncExpression([NotNull] CodeParser.ColonFuncExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>binaryExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinaryExpression([NotNull] CodeParser.BinaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>binaryExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinaryExpression([NotNull] CodeParser.BinaryExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>logicalExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalExpression([NotNull] CodeParser.LogicalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>logicalExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalExpression([NotNull] CodeParser.LogicalExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanExpression([NotNull] CodeParser.BooleanExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanExpression([NotNull] CodeParser.BooleanExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>concatenateExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConcatenateExpression([NotNull] CodeParser.ConcatenateExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>concatenateExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConcatenateExpression([NotNull] CodeParser.ConcatenateExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] CodeParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] CodeParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.lines"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLines([NotNull] CodeParser.LinesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.lines"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLines([NotNull] CodeParser.LinesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] CodeParser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] CodeParser.IfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfBlock([NotNull] CodeParser.ElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfBlock([NotNull] CodeParser.ElseIfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.blockLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockLine([NotNull] CodeParser.BlockLineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.blockLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockLine([NotNull] CodeParser.BlockLineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] CodeParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] CodeParser.BlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileBlock([NotNull] CodeParser.WhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileBlock([NotNull] CodeParser.WhileBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.inWhileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInWhileBlock([NotNull] CodeParser.InWhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.inWhileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInWhileBlock([NotNull] CodeParser.InWhileBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] CodeParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] CodeParser.DeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarations([NotNull] CodeParser.DeclarationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarations([NotNull] CodeParser.DeclarationsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.terminalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerminalDeclaration([NotNull] CodeParser.TerminalDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.terminalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerminalDeclaration([NotNull] CodeParser.TerminalDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] CodeParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] CodeParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.assignments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignments([NotNull] CodeParser.AssignmentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.assignments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignments([NotNull] CodeParser.AssignmentsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.colonFunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColonFunc([NotNull] CodeParser.ColonFuncContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.colonFunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColonFunc([NotNull] CodeParser.ColonFuncContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] CodeParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] CodeParser.ConstantContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] CodeParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] CodeParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.binaryOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinaryOperation([NotNull] CodeParser.BinaryOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.binaryOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinaryOperation([NotNull] CodeParser.BinaryOperationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.logicalOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalOperation([NotNull] CodeParser.LogicalOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.logicalOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalOperation([NotNull] CodeParser.LogicalOperationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.booleanOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanOperation([NotNull] CodeParser.BooleanOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.booleanOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanOperation([NotNull] CodeParser.BooleanOperationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.concatenateOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConcatenateOperation([NotNull] CodeParser.ConcatenateOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.concatenateOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConcatenateOperation([NotNull] CodeParser.ConcatenateOperationContext context);
}
} // namespace INTERPRETER_CODE_G6.Grammar
