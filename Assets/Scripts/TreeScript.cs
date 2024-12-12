using UnityEngine;

public class TreeScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float speed = 1.5f; // 1 cell/sec

    void Start()
    {


    }

    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime * Vector2.left);
    }
}
