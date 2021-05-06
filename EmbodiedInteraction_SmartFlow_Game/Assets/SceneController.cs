using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SceneController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {


        // Do raycast here
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 20))
        {
            if(hit.collider.CompareTag("dispensedObject"))
            {
                // DO STUFF WHEN SLICING OBJECT
                        // * INITIATE A SEQUENCE OF NESTED CALLS!

            }
        }






    }




}
