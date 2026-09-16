using UnityEngine;

public class Mainscript : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/Player");
        GameObject go = GameObject.Instantiate(prefab);
        go.name = prefab.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
