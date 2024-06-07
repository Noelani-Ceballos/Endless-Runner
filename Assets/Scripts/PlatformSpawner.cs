  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
     public GameObject platformPrefab;


     float minY = -5.92f;
     float maxY = -0.4f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlatform", 2, 6);
       
    }

    // Update is called once per frame
    void Update()
    {
         
   
       
    }
      void SpawnPlatform()
        {
             Instantiate(platformPrefab, new Vector2(13f,Random.Range(minY, maxY)), Quaternion.identity);
        }
   
    }


 