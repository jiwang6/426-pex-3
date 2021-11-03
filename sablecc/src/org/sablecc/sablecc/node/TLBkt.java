/* This file was generated by SableCC (http://www.sablecc.org/). */

package org.sablecc.sablecc.node;

import org.sablecc.sablecc.analysis.*;

public final class TLBkt extends Token
{
    public TLBkt()
    {
        super.setText("[");
    }

    public TLBkt(int line, int pos)
    {
        super.setText("[");
        setLine(line);
        setPos(pos);
    }

    public Object clone()
    {
      return new TLBkt(getLine(), getPos());
    }

    public void apply(Switch sw)
    {
        ((Analysis) sw).caseTLBkt(this);
    }

    public void setText(String text)
    {
        throw new RuntimeException("Cannot change TLBkt text.");
    }
}
