/* This file was generated by SableCC (http://www.sablecc.org/). */

package org.sablecc.sablecc.node;

import org.sablecc.sablecc.analysis.*;

public final class TTokens extends Token
{
    public TTokens()
    {
        super.setText("Tokens");
    }

    public TTokens(int line, int pos)
    {
        super.setText("Tokens");
        setLine(line);
        setPos(pos);
    }

    public Object clone()
    {
      return new TTokens(getLine(), getPos());
    }

    public void apply(Switch sw)
    {
        ((Analysis) sw).caseTTokens(this);
    }

    public void setText(String text)
    {
        throw new RuntimeException("Cannot change TTokens text.");
    }
}
