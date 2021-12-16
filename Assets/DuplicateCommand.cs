using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateCommand : Command
{
    protected static List<Transform> _cubeList;
    private GameObject _cubePrefab;

    public DuplicateCommand(Transform transform, GameObject cubePrefab) : base(transform)
    {
        _cubePrefab = cubePrefab;
        if (_cubeList == null)
        {
            _cubeList = new List<Transform>();
        }
    }

    public override void Do()
    {
        Vector3 newPos;
        if (_cubeList.Count == 0)
        {
            newPos = new Vector3(_transform.position.x, _transform.position.y +1, _transform.position.z);
        }
        else
        {
            Transform t = _cubeList[_cubeList.Count - 1].transform;
            newPos = new Vector3(t.position.x, t.position.y +1, t.position.z);
        }
        GameObject p = MonoBehaviour.Instantiate(_cubePrefab, newPos, Quaternion.identity,_transform);

        p.GetComponent<Renderer>().material.color = _transform.gameObject.GetComponent<Renderer>().material.color;

        _cubeList.Add(p.transform);
    }

    public override void Undo()
    {
        MonoBehaviour.Destroy(_cubeList[_cubeList.Count-1].gameObject);
        _cubeList.RemoveAt(_cubeList.Count-1);
    }
}
