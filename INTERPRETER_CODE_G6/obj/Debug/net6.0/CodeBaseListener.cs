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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICodeListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class CodeBaseListener : ICodeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantExpression([NotNull] CodeParser.ConstantExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantExpression([NotNull] CodeParser.ConstantExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesizedExpression([NotNull] CodeParser.ParenthesizedExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesizedExpression([NotNull] CodeParser.ParenthesizedExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>notBoolExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotBoolExpression([NotNull] CodeParser.NotBoolExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>notBoolExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotBoolExpression([NotNull] CodeParser.NotBoolExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierExpression([NotNull] CodeParser.IdentifierExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierExpression([NotNull] CodeParser.IdentifierExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>newLineExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNewLineExpression([NotNull] CodeParser.NewLineExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>newLineExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNewLineExpression([NotNull] CodeParser.NewLineExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>colonFuncExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColonFuncExpression([NotNull] CodeParser.ColonFuncExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>colonFuncExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColonFuncExpression([NotNull] CodeParser.ColonFuncExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>binaryExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBinaryExpression([NotNull] CodeParser.BinaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>binaryExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBinaryExpression([NotNull] CodeParser.BinaryExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>logicalExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalExpression([NotNull] CodeParser.LogicalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>logicalExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalExpression([NotNull] CodeParser.LogicalExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooleanExpression([NotNull] CodeParser.BooleanExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooleanExpression([NotNull] CodeParser.BooleanExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>concatenateExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConcatenateExpression([NotNull] CodeParser.ConcatenateExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>concatenateExpression</c>
	/// labeled alternative in <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConcatenateExpression([NotNull] CodeParser.ConcatenateExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] CodeParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] CodeParser.ProgramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.lines"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLines([NotNull] CodeParser.LinesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.lines"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLines([NotNull] CodeParser.LinesContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.ifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfBlock([NotNull] CodeParser.IfBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.ifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfBlock([NotNull] CodeParser.IfBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.elseIfBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseIfBlock([NotNull] CodeParser.ElseIfBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.elseIfBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseIfBlock([NotNull] CodeParser.ElseIfBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.blockLine"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockLine([NotNull] CodeParser.BlockLineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.blockLine"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockLine([NotNull] CodeParser.BlockLineContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] CodeParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] CodeParser.BlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.whileBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileBlock([NotNull] CodeParser.WhileBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.whileBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileBlock([NotNull] CodeParser.WhileBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.inWhileBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInWhileBlock([NotNull] CodeParser.InWhileBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.inWhileBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInWhileBlock([NotNull] CodeParser.InWhileBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] CodeParser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] CodeParser.DeclarationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarations([NotNull] CodeParser.DeclarationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarations([NotNull] CodeParser.DeclarationsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.terminalDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTerminalDeclaration([NotNull] CodeParser.TerminalDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.terminalDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTerminalDeclaration([NotNull] CodeParser.TerminalDeclarationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] CodeParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] CodeParser.AssignmentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.assignments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignments([NotNull] CodeParser.AssignmentsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.assignments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignments([NotNull] CodeParser.AssignmentsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.colonFunc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColonFunc([NotNull] CodeParser.ColonFuncContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.colonFunc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColonFunc([NotNull] CodeParser.ColonFuncContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant([NotNull] CodeParser.ConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant([NotNull] CodeParser.ConstantContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] CodeParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] CodeParser.ExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.binaryOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBinaryOperation([NotNull] CodeParser.BinaryOperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.binaryOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBinaryOperation([NotNull] CodeParser.BinaryOperationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.logicalOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalOperation([NotNull] CodeParser.LogicalOperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.logicalOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalOperation([NotNull] CodeParser.LogicalOperationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.booleanOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooleanOperation([NotNull] CodeParser.BooleanOperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.booleanOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooleanOperation([NotNull] CodeParser.BooleanOperationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.concatenateOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConcatenateOperation([NotNull] CodeParser.ConcatenateOperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.concatenateOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConcatenateOperation([NotNull] CodeParser.ConcatenateOperationContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace INTERPRETER_CODE_G6.Grammar