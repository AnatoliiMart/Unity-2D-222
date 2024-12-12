using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject pipePrefab;

    [SerializeField]
    private GameObject mosquitoPrefab;
    
    [SerializeField]
    private GameObject treePrefab;

    [SerializeField]
    private GameObject cloudPrefab;

    private float mosquitoSpawnPeriod = 7.5f;
    private float mosquitoTimeout;
    private float pipeSpawnPeriod = 2.5f;
    private float pipeTimeout, treeTimeout, cloudTimeout;

    private float cloudSpawnPeriod = 1.5f;
    private float treeSpawnPeriod = 3.5f;

    void Start()
    {
        pipeTimeout = cloudTimeout = 0f;
        treeTimeout = 0;
        mosquitoTimeout = 4.0f;
    }


    void Update()
    {
        pipeTimeout -= Time.deltaTime;
        if (pipeTimeout <= 0)
        {
            SpawnPipe();
            pipeTimeout = pipeSpawnPeriod;
        }

        mosquitoTimeout -= Time.deltaTime;
        if (mosquitoTimeout <= 0)
        {
            mosquitoTimeout = mosquitoSpawnPeriod;
            SpawnMosquito();
        }
        cloudTimeout -= Time.deltaTime;
        if (cloudTimeout <= 0)
        {
            cloudTimeout = cloudSpawnPeriod;
            SpawnClouds();
        }
        treeTimeout -= Time.deltaTime;
        if (treeTimeout <= 0)
        {
            treeTimeout = treeSpawnPeriod;
            SpawnTrees();
        }
      
    }


    private void SpawnTrees()
    {
        GameObject tree = Instantiate(treePrefab);
        tree.transform.position = this.transform.position + Random.Range(-3f, -1.5f) * Vector3.up;

    }

    private void SpawnPipe()
    {
        GameObject pipe = GameObject.Instantiate(pipePrefab);
        pipe.transform.position = this.transform.position + Random.Range(-2f, 2f) * Vector3.up;

    }
    public void SpawnMosquito()
    {
        GameObject mosquito = Instantiate(mosquitoPrefab);
        mosquito.transform.position = this.transform.position + Random.Range(-1.7f, 1.7f) * Vector3.up;
    }

    private void SpawnClouds()
    {
        GameObject cloud = Instantiate(cloudPrefab);
        cloud.transform.position = this.transform.position + Random.Range(3.1f, 4.1f) * Vector3.up;

    }
}
