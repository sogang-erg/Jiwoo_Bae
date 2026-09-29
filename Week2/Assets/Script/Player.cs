using UnityEngine;
using UnityEngine.InputSystem; 

// Case Study 1 : Player vs Wall
//A: Collider(IsTrigger ?) + RigidBody(IsKinematic ?)
//B: Collider(IsTrigger X)

public class Player : Character
{
    private InputAction _testAction;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 dir = Vector3.zero;

        // input.Getkey -> Input.GetKey, foward -> forward 수정
        if (Input.GetKey(KeyCode.W))
            dir += Vector3.forward;
        if (Input.GetKey(KeyCode.S))
            dir += Vector3.back;
        if (Input.GetKey(KeyCode.A))
            dir += Vector3.left;
        if (Input.GetKey(KeyCode.D))
            dir += Vector3.right;

        // 대각선 이동 시 속도가 빨라지지 않도록 dir.normalized 권장
        transform.position += dir.normalized * Time.deltaTime * 5;
    }
}


