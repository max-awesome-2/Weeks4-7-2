using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public float waitDuration = 3;
    private float destroyDuration;
    private float destroyProgress;
    private float progress;

    public float spawnedObjectSpeed = 2;

    private GameObject instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        if (progress > waitDuration)
        {
            progress = 0;
            instance = Instantiate(prefab, transform.position, Quaternion.identity);
            instance.GetComponent<Pacer>().speed = spawnedObjectSpeed;
            Destroy(instance, destroyDuration);
        }
        

    }
}
