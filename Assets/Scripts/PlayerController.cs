using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public bool isAlive;
    [SerializeField] float jumpForce;
    bool canJump;


    private Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>(); 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canJump = false;
            Debug.Log("Space bar was pressed");
        }
        
    }   
        
    void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.tag == "Platform")
        {
            Debug.Log("Here");
            canJump = true;
        }
    }
}
