using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackwardCommand : Command
{
    public BackwardCommand(Transform transform) : base(transform) { }

    public override void Do()
    {
        _transform.Translate(0, 0, -1);
    }

    public override void Undo()
    {
        _transform.Translate(0, 0, 1);
    }
}
