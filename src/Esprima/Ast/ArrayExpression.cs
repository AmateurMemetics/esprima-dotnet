using System.Collections.Generic;

namespace Esprima.Ast
{
    public class ArrayExpression : Node, Expression
    {
        public readonly List<ArrayExpressionElement> Elements;

        public ArrayExpression(List<ArrayExpressionElement> elements) :
            base(Nodes.ArrayExpression)
        {
            Elements = elements;
        }

        public override IEnumerable<INode> ChildNodes =>
            ChildNodeYielder.Yield(Elements);
    }
}