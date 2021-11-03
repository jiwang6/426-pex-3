/* This file was generated by SableCC (http://www.sablecc.org/). */

using System;
using System.Collections;
using System.Text;

using  CS426.analysis;

namespace CS426.node {


public sealed class TKeywordIf : Token
{
    public TKeywordIf(string text)
    {
        Text = text;
    }

    public TKeywordIf(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TKeywordIf(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTKeywordIf(this);
    }
}

public sealed class TKeywordElse : Token
{
    public TKeywordElse(string text)
    {
        Text = text;
    }

    public TKeywordElse(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TKeywordElse(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTKeywordElse(this);
    }
}

public sealed class TKeywordWhile : Token
{
    public TKeywordWhile(string text)
    {
        Text = text;
    }

    public TKeywordWhile(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TKeywordWhile(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTKeywordWhile(this);
    }
}

public sealed class TKeywordConstant : Token
{
    public TKeywordConstant(string text)
    {
        Text = text;
    }

    public TKeywordConstant(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TKeywordConstant(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTKeywordConstant(this);
    }
}

public sealed class TKeywordFunction : Token
{
    public TKeywordFunction(string text)
    {
        Text = text;
    }

    public TKeywordFunction(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TKeywordFunction(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTKeywordFunction(this);
    }
}

public sealed class TKeywordMain : Token
{
    public TKeywordMain(string text)
    {
        Text = text;
    }

    public TKeywordMain(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TKeywordMain(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTKeywordMain(this);
    }
}

public sealed class TAssign : Token
{
    public TAssign(string text)
    {
        Text = text;
    }

    public TAssign(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TAssign(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTAssign(this);
    }
}

public sealed class TPlus : Token
{
    public TPlus(string text)
    {
        Text = text;
    }

    public TPlus(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TPlus(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTPlus(this);
    }
}

public sealed class TSub : Token
{
    public TSub(string text)
    {
        Text = text;
    }

    public TSub(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TSub(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTSub(this);
    }
}

public sealed class TMult : Token
{
    public TMult(string text)
    {
        Text = text;
    }

    public TMult(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TMult(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTMult(this);
    }
}

public sealed class TDiv : Token
{
    public TDiv(string text)
    {
        Text = text;
    }

    public TDiv(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TDiv(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTDiv(this);
    }
}

public sealed class TEquivalent : Token
{
    public TEquivalent(string text)
    {
        Text = text;
    }

    public TEquivalent(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TEquivalent(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTEquivalent(this);
    }
}

public sealed class TNotEquivalent : Token
{
    public TNotEquivalent(string text)
    {
        Text = text;
    }

    public TNotEquivalent(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TNotEquivalent(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTNotEquivalent(this);
    }
}

public sealed class TGreaterThan : Token
{
    public TGreaterThan(string text)
    {
        Text = text;
    }

    public TGreaterThan(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TGreaterThan(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTGreaterThan(this);
    }
}

public sealed class TGreaterThanOrEqual : Token
{
    public TGreaterThanOrEqual(string text)
    {
        Text = text;
    }

    public TGreaterThanOrEqual(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TGreaterThanOrEqual(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTGreaterThanOrEqual(this);
    }
}

public sealed class TLessThan : Token
{
    public TLessThan(string text)
    {
        Text = text;
    }

    public TLessThan(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TLessThan(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTLessThan(this);
    }
}

public sealed class TLessThanOrEqual : Token
{
    public TLessThanOrEqual(string text)
    {
        Text = text;
    }

    public TLessThanOrEqual(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TLessThanOrEqual(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTLessThanOrEqual(this);
    }
}

public sealed class TOr : Token
{
    public TOr(string text)
    {
        Text = text;
    }

    public TOr(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TOr(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTOr(this);
    }
}

public sealed class TAnd : Token
{
    public TAnd(string text)
    {
        Text = text;
    }

    public TAnd(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TAnd(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTAnd(this);
    }
}

public sealed class TNot : Token
{
    public TNot(string text)
    {
        Text = text;
    }

    public TNot(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TNot(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTNot(this);
    }
}

public sealed class TEol : Token
{
    public TEol(string text)
    {
        Text = text;
    }

    public TEol(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TEol(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTEol(this);
    }
}

public sealed class TEscapeQuote : Token
{
    public TEscapeQuote(string text)
    {
        Text = text;
    }

    public TEscapeQuote(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TEscapeQuote(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTEscapeQuote(this);
    }
}

public sealed class TString : Token
{
    public TString(string text)
    {
        Text = text;
    }

    public TString(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TString(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTString(this);
    }
}

public sealed class TLeftParenthesis : Token
{
    public TLeftParenthesis(string text)
    {
        Text = text;
    }

    public TLeftParenthesis(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TLeftParenthesis(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTLeftParenthesis(this);
    }
}

public sealed class TRightParenthesis : Token
{
    public TRightParenthesis(string text)
    {
        Text = text;
    }

    public TRightParenthesis(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TRightParenthesis(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTRightParenthesis(this);
    }
}

public sealed class TOpenBrace : Token
{
    public TOpenBrace(string text)
    {
        Text = text;
    }

    public TOpenBrace(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TOpenBrace(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTOpenBrace(this);
    }
}

public sealed class TClosedBrace : Token
{
    public TClosedBrace(string text)
    {
        Text = text;
    }

    public TClosedBrace(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TClosedBrace(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTClosedBrace(this);
    }
}

public sealed class TComma : Token
{
    public TComma(string text)
    {
        Text = text;
    }

    public TComma(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TComma(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTComma(this);
    }
}

public sealed class TComment : Token
{
    public TComment(string text)
    {
        Text = text;
    }

    public TComment(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TComment(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTComment(this);
    }
}

public sealed class TInteger : Token
{
    public TInteger(string text)
    {
        Text = text;
    }

    public TInteger(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TInteger(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTInteger(this);
    }
}

public sealed class TFloat : Token
{
    public TFloat(string text)
    {
        Text = text;
    }

    public TFloat(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TFloat(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTFloat(this);
    }
}

public sealed class TId : Token
{
    public TId(string text)
    {
        Text = text;
    }

    public TId(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TId(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTId(this);
    }
}

public sealed class TBlank : Token
{
    public TBlank(string text)
    {
        Text = text;
    }

    public TBlank(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TBlank(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTBlank(this);
    }
}


public abstract class Token : Node
{
    private string text;
    private int line;
    private int pos;

    public virtual string Text
    {
      get { return text; }
      set { text = value; }
    }

    public int Line
    {
      get { return line; }
      set { line = value; }
    }

    public int Pos
    {
      get { return pos; }
      set { pos = value; }
    }

    public override string ToString()
    {
        return text + " ";
    }

    internal override void RemoveChild(Node child)
    {
    }

    internal override void ReplaceChild(Node oldChild, Node newChild)
    {
    }
}

public sealed class EOF : Token
{
    public EOF()
    {
        Text = "";
    }

    public EOF(int line, int pos)
    {
        Text = "";
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
        return new EOF(Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseEOF(this);
    }
}
}