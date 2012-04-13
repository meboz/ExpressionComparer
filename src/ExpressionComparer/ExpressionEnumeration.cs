using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressionComparer
{
    public class ExpressionEnumeration : ExpressionVisitor, IEnumerable<Expression>
    {
        private readonly List<Expression> _expressions = new List<Expression>();

        public ExpressionEnumeration(Expression expression)
        {
            Visit(expression);
        }

        #region IEnumerable<Expression> Members

        public IEnumerator<Expression> GetEnumerator()
        {
            return _expressions.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        protected override void Visit(Expression expression)
        {
            if (expression == null) return;

            _expressions.Add(expression);
            base.Visit(expression);
        }
    }
}