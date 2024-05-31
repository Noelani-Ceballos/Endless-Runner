using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
     public GameObject platformPrefab;

     public PlayerController playerScript; 

     float minY = 0.58f;
     float maxY = 4.52f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlatform", 2, 2);
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
         
   
       
    }
      void SpawnPlatform()
        {
             Instantiate(platformPrefab, new Vector2(7.57f,Random.Range(minY, maxY)), Quaternion.identity);
        }
   
    }


