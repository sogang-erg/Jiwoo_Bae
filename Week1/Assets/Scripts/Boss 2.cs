using UnityEngine;

public class Boss : MonoBehaviour
{
    public Challenger target;

    public Light safeLight1;
    public Light safeLight2;
    public Light safeLight3;
    public Light safeLight4;
    public Light safeLight5;

    public float safeRadius = 5.0f;

    float timer = 0f;
    bool hasChecked = false;

    void Start()
    {

    }

    void Update()
    {
        if (target == null)
        {
            target = GameObject.FindFirstObjectByType<Challenger>();
            return;
        }

        if (hasChecked) return;

        timer += Time.deltaTime;

        if (timer >= 10.0f)
        {
            hasChecked = true;
            CheckPlayerInLight();
        }
    }

    void CheckPlayerInLight()
    {
        if (target == null) return;

        bool isSafe = false;

        if (safeLight1 != null && Vector3.Distance(safeLight1.transform.position, target.transform.position) <= safeRadius)
        {
            isSafe = true;
        }

        if (safeLight2 != null && Vector3.Distance(safeLight2.transform.position, target.transform.position) <= safeRadius)
        {
            isSafe = true;
        }

        if (safeLight3 != null && Vector3.Distance(safeLight3.transform.position, target.transform.position) <= safeRadius)
        {
            isSafe = true;
        }

        if (safeLight4 != null && Vector3.Distance(safeLight4.transform.position, target.transform.position) <= safeRadius)
        {
            isSafe = true;
        }

        if (safeLight5 != null && Vector3.Distance(safeLight5.transform.position, target.transform.position) <= safeRadius)
        {
            isSafe = true;
        }

        if (isSafe)
        {
            Debug.Log("조명 속에서 네 모습을 뽐내 봐!");
        }
        else
        {
            Debug.Log("도전자가 쓰러졌습니다! 만회할 수 있을까요?");
            target.hp -= target.hp;
        }
    }
}