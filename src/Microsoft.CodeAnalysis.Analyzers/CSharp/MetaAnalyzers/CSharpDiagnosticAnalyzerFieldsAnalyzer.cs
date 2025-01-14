﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the MIT license.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Analyzers.MetaAnalyzers;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Analyzers.MetaAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class CSharpDiagnosticAnalyzerFieldsAnalyzer : DiagnosticAnalyzerFieldsAnalyzer<ClassDeclarationSyntax, StructDeclarationSyntax, FieldDeclarationSyntax, TypeSyntax, VariableDeclarationSyntax>
    {
    }
}
