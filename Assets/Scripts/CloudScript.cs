using UnityEngine;

public class CloudScript : MonoBehaviour
{
    private float speed = 1.5f; // 1 cell/sec

    void Start()
    {


    }

    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime * Vector2.left);
    }
}
