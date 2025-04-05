using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnPrefab;
    [SerializeField] private Transform[] spawnTransforms;
    [SerializeField] private float spawnTimer = 0;
    [SerializeField] private float spawnCoolDown = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnRandomVehicle();
       
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer > spawnCoolDown)
        {
            spawnTimer = 0;
            SpawnRandomVehicle();
        }
    }

    private void SpawnRandomVehicle()
    {
        int spawnTransformIndex = Random.Range(0, spawnTransforms.Length);
        Transform currentSpawnTransform = spawnTransforms[spawnTransformIndex];
        Instantiate(spawnPrefab, currentSpawnTransform.position, currentSpawnTransform.rotation);
    }
}
