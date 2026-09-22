using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
   
    private InputAction _testAction;
    void Start()
    {
        
        _testAction = InputSystem.actions.FindAction("Player/Test");

        _testAction.Enable();

    }

      void Update()
    {
        Vector2 move = _testAction.ReadValue<Vector2>();
        Debug.Log("Move: " + move  );
    }
}

