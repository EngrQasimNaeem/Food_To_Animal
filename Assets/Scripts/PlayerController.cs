using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xrange = 13.0f;
    public GameObject projectilePrefab;

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { //Keep the player Inbounds that player don't go further this setting position....
        if (transform.position.x < -xrange )
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }

        else if (transform.position.x > xrange )
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        

    }
    



   
    
}
