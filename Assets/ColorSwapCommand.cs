using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwapCommand : Command
{
    protected Renderer _renderer;

    public ColorSwapCommand(Transform transform) : base(transform) { }
    
    private Color _colorSaved;
    
    public override void Do()
    {
        _renderer = _transform.gameObject.GetComponent<Renderer>();

        _colorSaved = _renderer.material.color;
        _renderer.material.color = Random.ColorHSV();
    }

    public override void Undo()
    {
        _renderer.material.color = _colorSaved;
    }
}
