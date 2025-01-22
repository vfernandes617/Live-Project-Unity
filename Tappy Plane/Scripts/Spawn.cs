using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    //variable for spawn rate
    public float spawnRate = 1f;
    //defining range for obstacle
    public float minHeight = -1f;
    public float maxHeight = 1f;

    //Keeping the repeating object when spawn is enabled
    private void OnEnable()
    {
        InvokeRepeating(nameof (Spawns), spawnRate, spawnRate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawns));
    }
    private void Spawns() 
    {
        GameObject Obstacle = Instantiate(prefab, transform.position,Quaternion.identity);
        Obstacle.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }

    

    
}
