﻿using System.Collections.Generic;
using TreeProcessing.NET.Tests;
using Xunit;

namespace TreeProcessing.NET.Core.Tests
{
    public class HashTests
    {
        [Fact]
        public void Hash_EqualNodes()
        {
            Node tree1 = SampleTree.Init();
            Node tree2 = SampleTree.Init();

            Assert.Equal(tree1.GetHashCode(), tree2.GetHashCode());
        }

        [Fact]
        public void Hash_MerkelizedAst()
        {
            Node tree = SampleTree.Init();
            List<Statement> statements = ((BlockStatement)tree).Statements;
            var expressionStatement = (ExpressionStatement)statements[0];
            var forStatement = (ForStatement)statements[2];

            int treeHashBefore = tree.GetHashCode();
            int expressionStatementHashBefore = expressionStatement.GetHashCode();
            int forStatementHashBefore = forStatement.GetHashCode();

            ((BinaryOperatorExpression)expressionStatement.Expression).Operator = "!=";

            int treeHashAfter = tree.GetHashCode();
            int expressionStatementHashAfter = expressionStatement.GetHashCode();
            int forStatementHashAfter = forStatement.GetHashCode();

            Assert.NotEqual(treeHashBefore, treeHashAfter);
            Assert.NotEqual(expressionStatementHashBefore, expressionStatementHashAfter);
            Assert.Equal(forStatementHashBefore, forStatementHashAfter);
        }
    }
}
