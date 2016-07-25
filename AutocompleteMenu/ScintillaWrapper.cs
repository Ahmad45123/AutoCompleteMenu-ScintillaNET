﻿using System;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using AutocompleteMenuNS;
using ScintillaNET;

public class ScintillaWrapper : ITextBoxWrapper
{
    public Scintilla target;

    public ScintillaWrapper(Scintilla trgt)
    {
        target = trgt;

        //Now add handler for the UpdateUI event.
        target.UpdateUI += (sender, args) =>
        {
            if (args?.Change == UpdateChange.HScroll || args?.Change == UpdateChange.VScroll)
            {
                Scroll?.Invoke(sender, new ScrollEventArgs(ScrollEventType.LargeIncrement, 0));
            }
        };
    }


    public bool Readonly
    {
        get{ return target.ReadOnly; }
    }

    public string SelectedText
    {
        get { return target.SelectedText; }
        set
        {
            //Store the start of the selection.
            int start = target.SelectionStart;

            //Delete the current text between selections.
            target.DeleteRange(target.SelectionStart, (target.SelectionEnd - target.SelectionStart));

            //Add the text in the same postion.
            target.InsertText(start, value);

            //Clear selection and make sure the caret is at the end.
            target.SelectionStart = (start + value.Length);
            target.SelectionEnd = (start + value.Length);
        }
    }

    public int SelectionLength
    {
        get { return (target.SelectionEnd - target.SelectionStart); }
        set { target.SelectionEnd = (target.SelectionStart + value); }
    }

    public int SelectionStart
    {
        get { return target.SelectionStart; }
        set { target.SelectionStart = value; }
    }

    public Control TargetControl
    {
        get { return target; }
    }

    public string Text
    {
        get { return target.Text; }
    }

    public Point GetPositionFromCharIndex(int pos)
    {
        return new Point(target.PointXFromPosition(pos), target.PointYFromPosition(pos));
    }

    //Events
    public virtual event KeyEventHandler KeyDown
    {
        add { target.KeyDown += value; }
        remove { target.KeyDown -= value; }
    }
    public virtual event EventHandler LostFocus
    {
        add { target.LostFocus += value; }
        remove { target.LostFocus -= value; }
    }
    public virtual event MouseEventHandler MouseDown
    {
        add { target.MouseDown += value; }
        remove { target.MouseDown -= value; }
    }

    public event ScrollEventHandler Scroll;
}