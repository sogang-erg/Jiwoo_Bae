using UnityEngine;

public class Monster : MonoBehaviour
{
    public Player target;

    void Start()
    {

    }

    void Update()
    {
        if (target != null)
            return;

            //target = GameObject.Find("Player").GetComponent<Player>();
            //target = GameObject.FindWithTag("Player").GetComponent<Player>();
            target = GameObject.FindFirstObjectByType<Player>();
    }
}
