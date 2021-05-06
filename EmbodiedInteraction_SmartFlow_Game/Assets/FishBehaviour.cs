using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehaviour : DispensableObjBehavior
{
    private SceneController sceneController;
    private GameObject[] dispensedObjects;
    private void OnEnable()
    {
        sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
    }

    void FixedUpdate()
    {
        if (gameObject.GetComponent<Rigidbody>().velocity.y < 0)
        {
            dispensedObjects = GameObject.FindGameObjectsWithTag("dispensedObject");
            foreach( GameObject go in dispensedObjects)            
            {
                Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), go.GetComponent<Collider>());
            }
            
                
        }        
    }




}
