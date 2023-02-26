using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    // private float despawn = 5f;
 
     public static int presentCount = 0;
    private int score;
   
    // Start is called before the first frame update
    void Start()
    {
        //present counter is set to 0
         presentCount = 0;
         //start the despawn timer
        //  Destroy(t$$anonymous$$s.gameObject, despawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        Destroy(gameObject);
            Destroy(other.gameObject);

        if (other.gameObject.name == "Food_Pizza_01")
        {
            Debug.Log("Enter");
        }

        if(other.transform.name == "Food_Pizza_01")
         {
             presentCount++;
             Debug.Log("Present Count: "+ presentCount);
            //  Destroy(t$$anonymous$$s.gameObject);
         }

    }


   
    
}
