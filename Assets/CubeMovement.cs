using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

    private Stack<Command> Commands = new Stack<Command>();
    public GameObject CubePrefab;
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Z)) {
            Command command = new ForwardCommand(transform);
            command.Do();
            Commands.Push(command);
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            Command command = new BackwardCommand(transform);
            command.Do();
            Commands.Push(command);
        }
        if (Input.GetKeyDown(KeyCode.Q)) {
            Command command = new LeftCommand(transform);
            command.Do();
            Commands.Push(command);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            Command command = new RightCommand(transform);
            command.Do();
            Commands.Push(command);
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            Command command = new ColorSwapCommand(transform);
            command.Do();
            Commands.Push(command);
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            Command command = new DuplicateCommand(transform, CubePrefab);
            command.Do();
            Commands.Push(command);
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
        if (Input.GetButtonDown("Jump") && Commands.Count > 0) {
            Command command = Commands.Pop();
            command.Undo();
        }
    }
    
}