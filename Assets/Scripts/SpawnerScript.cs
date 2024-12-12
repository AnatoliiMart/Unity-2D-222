using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject pipePrefab;
    private float pipeSpawnPeriod = 2.5f; // 4 seconds
    private float pipeTimeout;

    void Start()
    {
        pipeTimeout = 0.0f;
    }


    void Update()
    {
        pipeTimeout -= Time.deltaTime;
        if (pipeTimeout <= 0)
        {
            SpawnPipe();
            pipeTimeout = pipeSpawnPeriod;
        }
    }

    private void SpawnPipe()
    {
        GameObject pipe = GameObject.Instantiate(pipePrefab);
        pipe.transform.position = this.transform.position + Random.Range(-2f, 2f) * Vector3.up;

    }
}
