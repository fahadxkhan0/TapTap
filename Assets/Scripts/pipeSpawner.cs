using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
public float maxYpose;
public float spawnTime;
public GameObject pipe;


    // Start is called before the first frame update
    void Start()
    {
       //startSpawning();
    }

    public void stopSpawning(){
        CancelInvoke("spawnPipe");
    }
    public void startSpawning(){
         InvokeRepeating("spawnPipe",0.1f,spawnTime) ;
    }
    public void spawnPipe(){
    Instantiate(pipe,new Vector3 (transform.position.x, Random.Range(-maxYpose, maxYpose),0),Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
