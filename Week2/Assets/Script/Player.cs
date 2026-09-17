using UnityEngine;

public class Player : Character
{
    public float speed = 5f;
   
    void Start()
    {
  
    }

    void Update()
    {
        Vector3 dir = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            dir += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            dir += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            dir += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dir += Vector3.right;
        }

        transform.position += dir.normalized * speed * Time.deltaTime;
    }
}

