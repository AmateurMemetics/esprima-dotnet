﻿using System.Collections.Generic;

namespace Esprima.Ast
{
    public class ExportNamedDeclaration : Node, ExportDeclaration
    {
        public readonly StatementListItem Declaration;
        public readonly List<ExportSpecifier> Specifiers;
        public readonly Literal Source;

        public ExportNamedDeclaration(StatementListItem declaration, List<ExportSpecifier> specifiers, Literal source) :
            base(Nodes.ExportNamedDeclaration)
        {
            Declaration = declaration;
            Specifiers = specifiers;
            Source = source;
        }

        public override IEnumerable<INode> ChildNodes =>
            ChildNodeYielder.Yield((INode) Declaration, Specifiers, Source);
    }
}