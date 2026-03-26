using Unity.Mathematics;
using UnityEngine;

public class SpawnerScript: MonoBehaviour
{
   public GameObject enemy;
   
   public float timeBetweenSpawns = 5;
   public float time;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= timeBetweenSpawns)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            time = 0;
        }
    }
}
