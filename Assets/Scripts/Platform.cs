using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

   


    public int speed = 7;
    // Start is called before the first frame update
    void Start()
    {
    
    
    }

    // Update is called once per frame
    void Update()
    {

            
        transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);

        if(transform.position.x < -24.38f)
        {
            Destroy(gameObject);
        }

    
    }

}
