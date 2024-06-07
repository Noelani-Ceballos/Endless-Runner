using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    [SerializeField] Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the camera's position to the player's position on the y axis//
        transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
    }
}
