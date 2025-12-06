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
        GameObject stickClone = Instantiate(stickPrefab, pos, Quaternion.identity);
        Destroy(stickClone, 5f);
    }
    void foodSpawn()
    {
        Vector3 pos = new Vector3(Random.Range(minX, maxX), spawnY, 0f);
        GameObject foodclone = Instantiate(foodPrefab, pos, Quaternion.identity);
        Destroy(foodclone, 5f);
    }

    void waterSpawn()
    {
        Vector2 pos = new Vector3(Random.Range(minX, maxX), spawnY, 0f);
        GameObject waterClone = Instantiate(waterPrefab, pos, Quaternion.identity);
        Destroy(waterClone, 5f);
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
