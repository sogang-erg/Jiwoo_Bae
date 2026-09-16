using UnityEngine;

public class MainScript : MonoBehaviour
{
    public Mesh playerMesh;
    public Material playerMaterial;

    public GameObject player;

    void Start()
    {
        player = CreatPlayer();

        player.transform.position = new Vector3(10,10,10);
        player.GetComponent<Player>().hp = 0;
        //GameObject.Destroy(player.gameObject,5);
        //player.gameObject.SetActive(false);
        player.GetComponent<Player>().enabled = false;

    }

    GameObject CreatPlayer()
    {
        GameObject go = new GameObject();
        go.name = "Player";
        go.tag = "Player";

        go.AddComponent<MeshFilter>();
        go.AddComponent<MeshRenderer>();
        go.AddComponent<CapsuleCollider>();
        go.AddComponent<Player>();

        MeshFilter meshFilter = go.GetComponent<MeshFilter>();
        meshFilter.mesh = playerMesh;

        MeshRenderer meshRenderer = go.GetComponent<MeshRenderer>();
        meshRenderer.material = playerMaterial;

        Player player = go.GetComponent<Player>();
        player.hp = 200;

        return go;
    }
    
    void Update()
    {
        
    }
}
