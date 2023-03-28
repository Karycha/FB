using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    private float timer = 0;
    public float height = 5;
    public GameObject prefabRedPipe;
    public GameObject prefabGreenPipe;

    // Update is called once per frame
    void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnRandomPipe();
        }

        timer += Time.deltaTime;
    }

    private void SpawnGreenPipe()
    {
        GameObject newPipe = Instantiate(prefabGreenPipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 10f);
    }
    private void SpawnRedPipe()
    {
        GameObject newPipe = Instantiate(prefabRedPipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 10f);
    }
    private void SpawnRandomPipe()
    {
        if (Random.Range(0, 2) == 0)
        {
            SpawnGreenPipe();
        }
        else
        {
            SpawnRedPipe();
        }
    }
}
