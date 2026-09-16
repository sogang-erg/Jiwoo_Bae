using UnityEngine;

public class Arcadia : MonoBehaviour
{
    public Mesh playerMesh;
    public Material playerMaterial;
    public AudioClip bgmClip;

    public GameObject player;

    void Start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        if (bgmClip != null)
        {
            audioSource.clip = bgmClip;
            audioSource.loop = true;
            audioSource.Play();
        }

        player = CreateChallenger();
        player.transform.position = new Vector3(6, 1, 3);
    }

    GameObject CreateChallenger()
    {
        GameObject go = new GameObject("Challenger");
        go.tag = "Player";

        MeshFilter meshFilter = go.AddComponent<MeshFilter>();
        meshFilter.mesh = playerMesh;

        MeshRenderer meshRenderer = go.AddComponent<MeshRenderer>();
        meshRenderer.material = playerMaterial;

        go.AddComponent<CapsuleCollider>();

        Challenger challenger = go.AddComponent<Challenger>();
        challenger.hp = 100;

        return go;
    }
}