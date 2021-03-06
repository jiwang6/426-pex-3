using CS426.node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS426.analysis
{
    class SemanticAnalyzer : DepthFirstAdapter
    {
        // List
        List<VariableDefinition> argumentsList = new List<VariableDefinition>(); // for function definitions
        List<Definition> parametersList = new List<Definition>(); // for function call statements
        
        // This symbol table keeps track of global "stuff"
        Dictionary<string, Definition> globalSymbolTable = new Dictionary<string, Definition>();

        // This symbol table keeps track of local "stuff"
        Dictionary<string, Definition> localSymbolTable = new Dictionary<string, Definition>();

        // This is our decorated parse tree, implemented as a dictionary
        Dictionary<Node, Definition> decoratedParseTree = new Dictionary<Node, Definition>();

        public void PrintWarning(Token t, string message)
        {
            Console.WriteLine(t.Line + "," + t.Pos + ":" + message);
        }

        // PEX 3 code goes here!
        public override void InAProgram(AProgram node)
        {
            // Create Definition for Integers
            Definition intDefinition = new NumberDefinition();
            intDefinition.name = "int";

            // Create Definition for Float
            Definition floatDefinition = new NumberDefinition();
            floatDefinition.name = "float";

            // Create Definition for Strings
            Definition strDefinition = new StringDefinition();
            strDefinition.name = "string";

            globalSymbolTable.Add("int", intDefinition);
            globalSymbolTable.Add("float", floatDefinition);
            globalSymbolTable.Add("string", strDefinition);
        }

        // --------------------------------------------------------------
        // OPERANDS
        // --------------------------------------------------------------
        public override void OutAIntOperand(AIntOperand node)
        {
            // Creates the Definition Object we will add to our parse tree
            Definition intDefinition = new NumberDefinition();
            intDefinition.name = "int";

            // Adds this node to the decorated parse tree
            decoratedParseTree.Add(node, intDefinition);
        }

        public override void OutAFloatOperand(AFloatOperand node)
        {
            // Creates the Definition Object we will add to our parse tree
            Definition floatDefinition = new NumberDefinition();
            floatDefinition.name = "float";

            // Adds this node to the decorated parse tree
            decoratedParseTree.Add(node, floatDefinition);
        }
        

        public override void OutAStringOperand(AStringOperand node)
        {
            // Creates the Definition Object we will add to our parse tree
            Definition stringDefinition = new StringDefinition();
            stringDefinition.name = "string";

            // Adds this node to the decorated parse tree
            decoratedParseTree.Add(node, stringDefinition);
        }

        public override void OutAVariableOperand(AVariableOperand node)
        {
            // Gets the Name of the ID
            String varName = node.GetId().Text;

            // This will contain the definition of the variable from the
            // symbol table, assuming it exists
            Definition varDefinition;
            
            // Checks the symbol table to see if the variable has been declared
            if (!localSymbolTable.TryGetValue(varName, out varDefinition) && !globalSymbolTable.TryGetValue(varName, out varDefinition))
            {
                // Prints out a warning that the variable does not exist
                PrintWarning(node.GetId(), "Variable " + varName + " does not exist");
            }
            // Checks to see if the value obtained from the localSymbolTable is a VariableDefinition
            else if (!(varDefinition is VariableDefinition))
            {
                PrintWarning(node.GetId(), "Identifier" + varName + " is not a variable");
            }
            else
            {
                // This casts the variable definition so that we can access its contents
                VariableDefinition v = (VariableDefinition)varDefinition;

                // Decorates the parse tree with the type of the variable
                decoratedParseTree.Add(node, v.variableType);
            }
        }
        // --------------------------------------------------------------
        // EXPRESSION 1
        // --------------------------------------------------------------

        public override void OutAPassExpression1(APassExpression1 node)
        {
            Definition operandDefinition;

            if (!decoratedParseTree.TryGetValue(node.GetOperand(), out operandDefinition))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, operandDefinition);
            }
        }

        public override void OutAParenthsisExpression1(AParenthsisExpression1 node)
        {
            Definition expressionDefinition;

            if (!decoratedParseTree.TryGetValue(node.GetExpression(), out expressionDefinition))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, expressionDefinition);
            }
        }

        // --------------------------------------------------------------
        // EXPRESSION 2
        // --------------------------------------------------------------
        public override void OutAPassExpression2(APassExpression2 node)
        {
            Definition expression1Def;
            
            if (!decoratedParseTree.TryGetValue(node.GetExpression1(), out expression1Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, expression1Def);
            }
        }

        public override void OutANegativeExpression2(ANegativeExpression2 node)
        {
            Definition expression1Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression1(), out expression1Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!(expression1Def is NumberDefinition))
            {
                PrintWarning(node.GetSub(), "Only a number can be negated");
            }
            else
            {
                decoratedParseTree.Add(node, expression1Def);
            }
        }

        // --------------------------------------------------------------
        // EXPRESSION 3
        // --------------------------------------------------------------
        public override void OutAPassExpression3(APassExpression3 node)
        {
            Definition expression2Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression2(), out expression2Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, expression2Def);
            }
        }
        
        public override void OutAMultiplyExpression3(AMultiplyExpression3 node)
        {
            Definition expression3Def;
            Definition expression2Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression3(), out expression3Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetExpression2(), out expression2Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (expression3Def.GetType() != expression2Def.GetType())
            {
                PrintWarning(node.GetMult(), "Cannot multiply " + expression3Def.name 
                    + " by " + expression2Def.name);
            }
            else if (!(expression3Def is NumberDefinition))
            {
                PrintWarning(node.GetMult(), "Cannot multiply something of type " 
                    + expression3Def.name);
            }
            else
            {
                // Decorate ourselves (either expression2def or expression3def would work)
                decoratedParseTree.Add(node, expression3Def);
            }
        }

        public override void OutADivisionExpression3(ADivisionExpression3 node)
        {
            Definition expression3Def;
            Definition expression2Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression3(), out expression3Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetExpression2(), out expression2Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (expression3Def.GetType() != expression2Def.GetType())
            {
                PrintWarning(node.GetDiv(), "Cannot divide " + expression3Def.name
                    + " by " + expression2Def.name);
            }
            else if (!(expression3Def is NumberDefinition))
            {
                PrintWarning(node.GetDiv(), "Cannot divide something of type "
                    + expression3Def.name);
            }
            else
            {
                // Decorate ourselves (either expression2def or expression3def would work)
                decoratedParseTree.Add(node, expression3Def);
            }
        }

        // --------------------------------------------------------------
        // EXPRESSION 4
        // --------------------------------------------------------------
        public override void OutAPassExpression4(APassExpression4 node)
        {
            Definition expression3Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression3(), out expression3Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, expression3Def);
            }
        }

        public override void OutAAddExpression4(AAddExpression4 node)
        {
            Definition expression4Type;
            Definition expression3Type;

            if (!decoratedParseTree.TryGetValue(node.GetExpression4(), out expression4Type))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetExpression3(), out expression3Type))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (expression4Type.name != expression3Type.name)
            {
                PrintWarning(node.GetPlus(), "Could not add " + expression4Type.name 
                    + " and " + expression3Type.name);
            }
            else if (!(expression4Type is NumberDefinition))
            {
                PrintWarning(node.GetPlus(), "Could not add something of type" 
                    + expression4Type.name);
            }
            else
            {
                decoratedParseTree.Add(node, expression4Type);
            }
        }

        public override void OutASubtractExpression4(ASubtractExpression4 node)
        {
            Definition expression4Type;
            Definition expression3Type;

            if (!decoratedParseTree.TryGetValue(node.GetExpression4(), out expression4Type))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetExpression3(), out expression3Type))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (expression4Type.name != expression3Type.name)
            {
                PrintWarning(node.GetSub(), "Could not subtract " + expression4Type.name
                    + " and " + expression3Type.name);
            }
            else if (!(expression4Type is NumberDefinition))
            {
                PrintWarning(node.GetSub(), "Could not subtract something of type"
                    + expression4Type.name);
            }
            else
            {
                decoratedParseTree.Add(node, expression4Type);
            }
        }

        // --------------------------------------------------------------
        // EXPRESSION 5
        // --------------------------------------------------------------

        public override void OutAPassExpression5(APassExpression5 node)
        {
            Definition expression4Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression4(), out expression4Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, expression4Def);
            }
        }

        public override void OutAGreaterThanExpression5(AGreaterThanExpression5 node)
        {
            Definition firstExpression4Def;
            Definition secondExpression4Def;

            if (!decoratedParseTree.TryGetValue(node.GetFirst(), out firstExpression4Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetSecond(), out secondExpression4Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (firstExpression4Def.name != secondExpression4Def.name)
            {
                PrintWarning(node.GetGreaterThan(), "Could not compare " + firstExpression4Def.name
                    + " and " + secondExpression4Def.name);
            }
            else if (!(firstExpression4Def is NumberDefinition))
            {
                PrintWarning(node.GetGreaterThan(), "Could not compare something of type"
                    + firstExpression4Def.name);
            }
            else
            {
                VariableDefinition v = new VariableDefinition();
                v.name = "bool";
                decoratedParseTree.Add(node, v);
            }
        }

        public override void OutALessThanExpression5(ALessThanExpression5 node)
        {
            Definition firstExpression4Def;
            Definition secondExpression4Def;

            if (!decoratedParseTree.TryGetValue(node.GetFirst(), out firstExpression4Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetSecond(), out secondExpression4Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (firstExpression4Def.name != secondExpression4Def.name)
            {
                PrintWarning(node.GetLessThan(), "Could not compare " + firstExpression4Def.name
                    + " and " + secondExpression4Def.name);
            }
            else if (!(firstExpression4Def is NumberDefinition))
            {
                PrintWarning(node.GetLessThan(), "Could not compare something of type"
                    + firstExpression4Def.name);
            }
            else
            {
                VariableDefinition v = new VariableDefinition();
                v.name = "bool";
                decoratedParseTree.Add(node, v);
            }
        }

        public override void OutAGreaterThanOrEqualExpression5(AGreaterThanOrEqualExpression5 node)
        {
            Definition firstExpression4Def;
            Definition secondExpression4Def;

            if (!decoratedParseTree.TryGetValue(node.GetFirst(), out firstExpression4Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetSecond(), out secondExpression4Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (firstExpression4Def.name != secondExpression4Def.name)
            {
                PrintWarning(node.GetGreaterThanOrEqual(), "Could not compare " + firstExpression4Def.name
                    + " and " + secondExpression4Def.name);
            }
            else if (!(firstExpression4Def is NumberDefinition))
            {
                PrintWarning(node.GetGreaterThanOrEqual(), "Could not compare something of type"
                    + firstExpression4Def.name);
            }
            else
            {
                VariableDefinition v = new VariableDefinition();
                v.name = "bool";
                decoratedParseTree.Add(node, v);
            }
        }

        public override void OutALessThanOrEqualExpression5(ALessThanOrEqualExpression5 node)
        {
            Definition firstExpression4Def;
            Definition secondExpression4Def;

            if (!decoratedParseTree.TryGetValue(node.GetFirst(), out firstExpression4Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetSecond(), out secondExpression4Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (firstExpression4Def.name != secondExpression4Def.name)
            {
                PrintWarning(node.GetLessThanOrEqual(), "Could not compare " + firstExpression4Def.name
                    + " and " + secondExpression4Def.name);
            }
            else if (!(firstExpression4Def is NumberDefinition))
            {
                PrintWarning(node.GetLessThanOrEqual(), "Could not compare something of type"
                    + firstExpression4Def.name);
            }
            else
            {
                VariableDefinition v = new VariableDefinition();
                v.name = "bool";
                decoratedParseTree.Add(node, v);
            }
        }

        // --------------------------------------------------------------
        // EXPRESSION 6
        // --------------------------------------------------------------

        public override void OutAPassExpression6(APassExpression6 node)
        {
            Definition expression5Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression5(), out expression5Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, expression5Def);
            }
        }

        public override void OutAEqualsExpression6(AEqualsExpression6 node)
        {
            Definition expression6Def;
            Definition expression5Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression6(), out expression6Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetExpression5(), out expression5Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (expression6Def.name != expression5Def.name)
            {
                PrintWarning(node.GetEquivalent(), "Could not compare " + expression6Def.name
                    + " and " + expression5Def.name);
            }
            else if (!(expression6Def is NumberDefinition))
            {
                PrintWarning(node.GetEquivalent(), "Could not compare something of type"
                    + expression6Def.name);
            }
            else
            {
                VariableDefinition v = new VariableDefinition();
                v.name = "bool";
                decoratedParseTree.Add(node, v);
            }
        }

        public override void OutANotEqualExpression6(ANotEqualExpression6 node)
        {
            Definition expression6Def;
            Definition expression5Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression6(), out expression6Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetExpression5(), out expression5Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (expression6Def.name != expression5Def.name)
            {
                PrintWarning(node.GetNotEquivalent(), "Could not compare " + expression6Def.name
                    + " and " + expression5Def.name);
            }
            else if (!(expression6Def is NumberDefinition))
            {
                PrintWarning(node.GetNotEquivalent(), "Could not compare something of type"
                    + expression6Def.name);
            }
            else
            {
                VariableDefinition v = new VariableDefinition();
                v.name = "bool";
                decoratedParseTree.Add(node, v);
            }
        }

        // --------------------------------------------------------------
        // EXPRESSION 7
        // --------------------------------------------------------------

        public override void OutAPassExpression7(APassExpression7 node)
        {
            Definition expression6Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression6(), out expression6Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, expression6Def);
            }
        }

        public override void OutAAndComparisonExpression7(AAndComparisonExpression7 node)
        {
            Definition expression7Def;
            Definition expression6Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression7(), out expression7Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetExpression6(), out expression6Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (expression7Def.GetType() != expression6Def.GetType())
            {
                PrintWarning(node.GetAnd(), "Cannot complete AND operation of different types");
            }
            else if (expression7Def.name != "bool")
            {
                PrintWarning(node.GetAnd(), "Type must be boolean for AND operation");
            }
            else
            {
                VariableDefinition v = new VariableDefinition();
                v.name = "bool";
                decoratedParseTree.Add(node, v);
            }
        }

        // --------------------------------------------------------------
        // EXPRESSION8
        // --------------------------------------------------------------

        public override void OutAPassExpression8(APassExpression8 node)
        {
            Definition expression7Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression7(), out expression7Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, expression7Def);
            }
        }

        public override void OutAOrComparisonExpression8(AOrComparisonExpression8 node)
        {
            Definition expression8Def;
            Definition expression7Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression7(), out expression7Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (!decoratedParseTree.TryGetValue(node.GetExpression8(), out expression8Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (expression7Def.GetType() != expression8Def.GetType())
            {
                PrintWarning(node.GetOr(), "Cannot complete OR operation of different types");
            }
            else if (expression8Def.name != "bool")
            {
                PrintWarning(node.GetOr(), "Type must be boolean for OR operation");
            }
            else
            {
                VariableDefinition v = new VariableDefinition();
                v.name = "bool";
                decoratedParseTree.Add(node, v);
            }
        }

        // --------------------------------------------------------------
        // EXPRESSION
        // --------------------------------------------------------------

        public override void OutAPassExpression(APassExpression node)
        {
            Definition expression8Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression8(), out expression8Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, expression8Def);
            }
        }

        public override void OutANegateExpression(ANegateExpression node)
        {
            Definition expression8Def;

            if (!decoratedParseTree.TryGetValue(node.GetExpression8(), out expression8Def))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (expression8Def.name != "bool")
            {
                PrintWarning(node.GetNot(), "Type must be boolean for NOT operation");
            }
            else
            {
                VariableDefinition v = new VariableDefinition();
                v.name = "bool";
                decoratedParseTree.Add(node, v);
            }
        }

        // --------------------------------------------------------------
        // DECLARE STATEMENT
        // --------------------------------------------------------------
        public override void OutADeclareStatement(ADeclareStatement node)
        {
            Definition typeDef;
            Definition idDef;

            if (!globalSymbolTable.TryGetValue(node.GetType().Text, out typeDef))
            {
                // If the type doesn't exist, throw an error
                PrintWarning(node.GetType(), "Type " + node.GetType().Text + " does not exist");
            }
            else if (localSymbolTable.TryGetValue(node.GetVarname().Text, out idDef))
            {
                // If the id exists, then we can't declare something with the same name
                PrintWarning(node.GetVarname(), "ID " + node.GetVarname().Text 
                    + " has already been declared");
            }
            else
            {
                // Add the id to the symbol table
                VariableDefinition newVariableDefinition = new VariableDefinition();
                newVariableDefinition.name = node.GetVarname().Text;
                newVariableDefinition.variableType = (TypeDefinition)typeDef;

                localSymbolTable.Add(node.GetVarname().Text, newVariableDefinition);
            }
        }

        // --------------------------------------------------------------
        // ASSIGNMENT
        // --------------------------------------------------------------
        public override void OutAAssignStatement(AAssignStatement node)
        {
            Definition idDef;
            Definition expressionDef;

            if (globalSymbolTable.TryGetValue(node.GetId().Text, out idDef))
            {
                PrintWarning(node.GetId(), "ID " + node.GetId().Text + " is a constant and cannot be reassigned");
            }
            else if (!localSymbolTable.TryGetValue(node.GetId().Text, out idDef))
            {
                PrintWarning(node.GetId(), "ID " + node.GetId().Text + " does not exist");
            }
            else if (!(idDef is VariableDefinition))
            {
                PrintWarning(node.GetId(), "ID " + node.GetId().Text + " is not a variable");
            }
            else if (!decoratedParseTree.TryGetValue(node.GetExpression(), out expressionDef))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (((VariableDefinition)idDef).variableType.name != expressionDef.name)
            {
                PrintWarning(node.GetId(), "Cannot assign value of type " + expressionDef.name 
                    + " to variable of type " + ((VariableDefinition)idDef).variableType.name);
            }
            else
            {
                // NOTHING IS REQUIRED ONCE ALL THE TESTS HAVE PASSED
            }
        }

        // --------------------------------------------------------------
        // WHILE
        // --------------------------------------------------------------
        public override void OutAWhileStatement(AWhileStatement node)
        {
            Definition expressionDef;

            if (!decoratedParseTree.TryGetValue(node.GetExpression(), out expressionDef))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (expressionDef.name != "bool")
            {
                PrintWarning(node.GetKeywordWhile(), "Condition for while statement must be boolean");
            }
            else
            {
                decoratedParseTree.Add(node, expressionDef);
            }
        }

        // --------------------------------------------------------------
        // IF / IF-ELSE
        // --------------------------------------------------------------
        public override void OutAIfStatement(AIfStatement node)
        {
            Definition expressionDef;

            if (!decoratedParseTree.TryGetValue(node.GetExpression(), out expressionDef))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else if (expressionDef.name != "bool")
            {
                PrintWarning(node.GetKeywordIf(), "Condition for if statement must be boolean");
            }
            else
            {
                decoratedParseTree.Add(node, expressionDef);
            }
        }

        // --------------------------------------------------------------
        // FUNCTION DEFINITION
        // --------------------------------------------------------------
        public override void InAFunction(AFunction node)
        {
            Definition idDef;

            if (globalSymbolTable.TryGetValue(node.GetId().Text, out idDef))
            {
                PrintWarning(node.GetId(), "Identifier " + node.GetId().Text + " is already being used");
            }
            else
            {
                // Wipes out the local symbol table
                localSymbolTable = new Dictionary<string, Definition>();
                argumentsList = new List<VariableDefinition>();
            }
        }
        
        public override void OutAFunction(AFunction node)
        {
            // Registers the New Function Definition in the Global Table
            FunctionDefinition newFunctionDefinition = new FunctionDefinition();
            newFunctionDefinition.name = node.GetId().Text;

            // TODO:  You will have to figure out how to populate this with parameters
            // when you work on PEX 3
            newFunctionDefinition.parameters = new List<VariableDefinition>(argumentsList);

            // Adds the Function!
            globalSymbolTable.Add(node.GetId().Text, newFunctionDefinition);


            // Wipes out the local symbol table so that the next function doesn't have to deal with it
            localSymbolTable = new Dictionary<string, Definition>();
            argumentsList = new List<VariableDefinition>();
        }

        // --------------------------------------------------------------
        // ARGUMENTS
        // --------------------------------------------------------------
        public override void OutASingleArguments(ASingleArguments node)
        {
            Definition typeDef;
            Definition idDef;

            if (!globalSymbolTable.TryGetValue(node.GetType().Text, out typeDef))
            {
                // If the type doesn't exist, throw an error
                PrintWarning(node.GetType(), "Type " + node.GetType().Text + " does not exist");
            }
            else if (localSymbolTable.TryGetValue(node.GetVarname().Text, out idDef))
            {
                // If the id exists, then we can't declare something with the same name
                PrintWarning(node.GetVarname(), "ID " + node.GetVarname().Text
                    + " has already been declared");
            }
            else
            {
                // Add the id to the symbol table
                VariableDefinition newVariableDefinition = new VariableDefinition();
                newVariableDefinition.name = node.GetVarname().Text;
                newVariableDefinition.variableType = (TypeDefinition)typeDef;

                localSymbolTable.Add(node.GetVarname().Text, newVariableDefinition);
                argumentsList.Add(newVariableDefinition);
            }
        }

        public override void OutAMultipleArguments(AMultipleArguments node)
        {
            Definition typeDef;
            Definition idDef;
 
            if (!globalSymbolTable.TryGetValue(node.GetType().Text, out typeDef))
            {
                // If the type doesn't exist, throw an error
                PrintWarning(node.GetType(), "Type " + node.GetType().Text + " does not exist");
            }
            else if (localSymbolTable.TryGetValue(node.GetVarname().Text, out idDef))
            {
                // If the id exists, then we can't declare something with the same name
                PrintWarning(node.GetVarname(), "ID " + node.GetVarname().Text
                    + " has already been declared");
            }
            else
            {
                // Add the id to the symbol table
                VariableDefinition newVariableDefinition = new VariableDefinition();
                newVariableDefinition.name = node.GetVarname().Text;
                newVariableDefinition.variableType = (TypeDefinition)typeDef;

                localSymbolTable.Add(node.GetVarname().Text, newVariableDefinition);
                argumentsList.Add(newVariableDefinition);
            }
        }

        // --------------------------------------------------------------
        // FUNCTION CALL
        // --------------------------------------------------------------
        public override void OutAFunctionCallStatement(AFunctionCallStatement node)
        {
            Definition idDef;

            if (!globalSymbolTable.TryGetValue(node.GetId().Text, out idDef))
            {
                PrintWarning(node.GetId(), "ID " + node.GetId().Text + " not found");
            }
            else if (!(idDef is FunctionDefinition))
            {
                PrintWarning(node.GetId(), "ID " + node.GetId().Text + " is not a function");
            }
            else if (((FunctionDefinition)idDef).parameters.Count() != parametersList.Count())
            {
                PrintWarning(node.GetId(), "ID " + node.GetId().Text + " does not contain the correct number of parameters");
            }
            else
            {
                for (int i=0; i < ((FunctionDefinition)idDef).parameters.Count(); i++)
                {
                    if (((FunctionDefinition)idDef).parameters[i].variableType.name != parametersList[i].name)
                    {
                        PrintWarning(node.GetId(), "ID " + node.GetId().Text + " has improper parameter types");
                    }
                }
            }



            // ensure parametersList is empty
            parametersList = new List<Definition>();

            // TODO:  Verify parameters are in the correct order, and are of the correct type
            // HINT:  You can use a class variable to "build" a list of the parameters as
            //        you discover them!
        }

        // --------------------------------------------------------------
        // PARAMETERS
        // --------------------------------------------------------------
        public override void OutAOneParameters(AOneParameters node)
        {
            Definition expressionDef;

            if (!decoratedParseTree.TryGetValue(node.GetExpression(), out expressionDef))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, expressionDef);
                parametersList.Add(expressionDef);
            }
        }

        public override void OutAMultipleParameters(AMultipleParameters node)
        {
            Definition expressionDef;

            if (!decoratedParseTree.TryGetValue(node.GetExpression(), out expressionDef))
            {
                // We are checking to see if the node below us was decorated.
                // We don't have to print an error, because if something bad happened
                // the error would have been printed at the lower node.
            }
            else
            {
                decoratedParseTree.Add(node, expressionDef);
                parametersList.Add(expressionDef);
            }
        }

        // --------------------------------------------------------------
        // CONSTANTS
        // --------------------------------------------------------------
        public override void OutAConstants(AConstants node)
        { 
            Definition typeDef;
            Definition idDef;
            Definition expressionDef;

            if (!globalSymbolTable.TryGetValue(node.GetType().Text, out typeDef))
            {
                // If the type doesn't exist, throw an error
                PrintWarning(node.GetType(), "Type " + node.GetType().Text + " does not exist");
            }
            else if (globalSymbolTable.TryGetValue(node.GetVarname().Text, out idDef))
            {
                // If the id exists, then we can't declare something with the same name
                PrintWarning(node.GetVarname(), "ID " + node.GetVarname().Text
                    + " has already been declared");
            }
            else if (!decoratedParseTree.TryGetValue(node.GetExpression(), out expressionDef))
            {
                // catch error earlier on
            }
            else
            {
                // Add the id to the symbol table
                VariableDefinition newVariableDefinition = new VariableDefinition();
                newVariableDefinition.name = node.GetVarname().Text;
                newVariableDefinition.variableType = (TypeDefinition)typeDef;

                if (newVariableDefinition.variableType.toString() != expressionDef.name)
                {
                    PrintWarning(node.GetKeywordConstant(), "Cannot assign value of type " + expressionDef.name
                        + " to variable of type " + newVariableDefinition.variableType.toString());
                }

                globalSymbolTable.Add(node.GetVarname().Text, newVariableDefinition);
              
            }
        }
    }
}


