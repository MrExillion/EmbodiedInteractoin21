using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispensedObjProperties : MonoBehaviour
{
    private SceneController sceneController;
    public int debrisCount;
    public GameObject debris;
    public Vector3[] debrisDirectionForce;
    public int dispenseWave;
    public string dispenseType;
    private void Awake()
    {
        sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
    }



    // Update is called once per frame
    void Update()
    {
        if(sceneController == null)
        {
            sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
        }

        if (gameObject.transform.position.y < GameObject.Find("Dispenser1").transform.position.y)
        {

            sceneController.DeQueue();
            Destroy(gameObject);
        }

    }

  

}
