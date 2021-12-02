using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateCommand : Command
{
    protected List<Transform> _cubeList;
    private GameObject _cubePrefab;

    public DuplicateCommand(Transform transform, GameObject cubePrefab) : base(transform)
    {
        _cubePrefab = cubePrefab;
    }

    public override void Do()
    {
        //MonoBehaviour.Instantiate();
    }

    public override void Undo()
    {
        
    }
}
