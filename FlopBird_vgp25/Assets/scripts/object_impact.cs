using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_impact : MonoBehaviour
{
    public GameObject stickPrefab; //these two should respond to the tags given to each prefab in the unity Hierachy!
    public GameObject foodPrefab;
    public GameObject waterPrefab;
   
    public float stickInterval = 1f;
    public float foodInterval = 5f;
    public float waterInterval = 2f;

    public float spawnY = 6f;
    public float minX = -3f;
    public float maxX = 3f;

    void stickSpawn()
    {
        Vector3 pos = new Vector3(Random.Range(minX, maxX), spawnY, 0f);
        Instantiate(stickPrefab, pos, Quaternion.identity);
    }
    void foodSpawn()
    {
        Vector3 pos = new Vector3(Random.Range(minX, maxX), spawnY, 0f);
        Instantiate(foodPrefab, pos, Quaternion.identity);
    }

    void waterSpawn()
    {
        Vector2 pos = new Vector3(Random.Range(minX, maxX), spawnY, 0f);
        Instantiate(waterPrefab, pos, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(stickSpawn), 1f, stickInterval);
        InvokeRepeating(nameof(foodSpawn), 2f, foodInterval);
        InvokeRepeating(nameof(waterSpawn), 2f, waterInterval);

    }











    // Update is called once per frame
    void Update()
    {
        
    }
}
