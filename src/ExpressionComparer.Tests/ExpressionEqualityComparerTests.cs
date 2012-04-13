using System;
using System.Linq.Expressions;
using NUnit.Framework;

namespace ExpressionComparer.Tests
{
    [TestFixture]
    public class ExpressionEqualityComparerTests
    {
        [Test]
        public void can_compare_simple_func()
        {
            Expression<Func<int, int>> func1 = i => i + 1;
            Expression<Func<int, int>> func2 = i => i + 1;

            Func<Expression, Expression, bool> eq =
                ExpressionEqualityComparer.Instance.Equals;

            Assert.That(eq(func1, func2));
        }
    }
}