using UnityEngine;

public class Player : MonoBehaviour
{   
    public string playerName = "Player";
    public int hp = 100;

    void Start()
    {
        //gameObject.GetComponent<Transform>().position = new Vector3(10,10,10);
        //GetComponent<Transform>().position = new Vector3(10,10,10);
        transform.position = new Vector3(10,10,10);
    }

    void Update()
    {

    }

}