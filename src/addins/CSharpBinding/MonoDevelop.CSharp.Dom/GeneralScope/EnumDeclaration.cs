// 
// EnumDeclaration.cs
//  
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2009 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Linq;
using MonoDevelop.Projects.Dom;
using System.Collections.Generic;

namespace MonoDevelop.CSharp.Dom
{
	public class EnumDeclaration : TypeDeclaration
	{
		const int EnumMemberDeclarationRole = 100;
		
		public IEnumerable<EnumMemberDeclaration> Members { 
			get {
				return base.GetChildrenByRole (EnumMemberDeclarationRole).Cast <EnumMemberDeclaration>();
			}
		}
		
		public override ClassType ClassType {
			get {
				return ClassType.Enum;
			}
		}
		
		public override S AcceptVisitor<T, S> (ICSharpDomVisitor<T, S> visitor, T data)
		{
			return visitor.VisitEnumDeclaration (this, data);
		}
	}
	
	public class EnumMemberDeclaration : AbstractCSharpNode
	{
		public IEnumerable<AttributeSection> Attributes { 
			get {
				return base.GetChildrenByRole (Roles.Attribute).Cast <AttributeSection>();
			}
		}
		
		public string Name {
			get {
				return NameIdentifier.Name;
			}
		}
		
		public Identifier NameIdentifier {
			get {
				return (Identifier)GetChildByRole (Roles.Identifier);
			}
		}
		
		public INode Initializer {
			get {
				return GetChildByRole (Roles.Initializer);
			}
		}
		
		public override S AcceptVisitor<T, S> (ICSharpDomVisitor<T, S> visitor, T data)
		{
			return visitor.VisitEnumMemberDeclaration (this, data);
		}
	}
}
