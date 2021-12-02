using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCommand : Command
{
    public RightCommand(Transform transform) : base(transform) { }
    
    public override void Do() {
        _transform.Translate(1, 0, 0);
    }

    public override void Undo() {
        _transform.Translate(-1, 0, 0);
    }
}
