using UnityEngine;

using UnityEngine;

public class Challenger : MonoBehaviour
{
    public string playerName = "Challenger";
    public int hp = 100;
    public float moveSpeed = 5.0f; 

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        Vector3 moveDir = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDir += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDir += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDir += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDir += Vector3.right;
        }

        if (moveDir != Vector3.zero)
        {
            Vector3 finalDir = moveDir.normalized;
            transform.position += finalDir * moveSpeed * Time.deltaTime;

            transform.LookAt(transform.position + finalDir);

            if (anim != null)
            {
                anim.Play("run");
            }
        }
        else
        {
            if (anim != null)
            {
                anim.Play("idle");
            }
        }

        if (hp <= 0)
        {
            Debug.Log("도전자가 쓰러졌습니다. 만회할 수 있을까요?");
            Destroy(gameObject);
        }
    }
}