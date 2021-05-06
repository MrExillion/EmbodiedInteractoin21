using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SceneController : MonoBehaviour
{
    private GameObject hitGameObjectDebris;
    // Start is called before the first frame update

    private int lastQueuedWave = 0;
    public Queue<KeyValuePair<int, int>> queue = new Queue<KeyValuePair<int, int>>();
    public int killedWaveIndex;
    public string lastHitDispenseType;
    public Material blueMat;
    public Material greenMat;
    public Material redMat;
    void Start()
    {



    }
    //Queue<System.Collections.Generic.Dictionary<int,int>> queue2;
    

    // Update is called once per frame
    void Update()
    {
        if(lastQueuedWave != GameObject.Find("DispenserContainer").GetComponent<Dispenser>().dispensecounter || queue.Count == 0)
        {
            Debug.Log("QUEUING");
            lastQueuedWave = GameObject.Find("DispenserContainer").GetComponent<Dispenser>().dispensecounter;
            queue.Enqueue(new KeyValuePair<int,int>(lastQueuedWave,5));
            //queue2.Enqueue(new System.Collections.Generic.Dictionary(lastQueuedWave,4));


        }
        // Do raycast here
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawRay(ray.origin, ray.direction);
            if(hit.collider.CompareTag("dispensedObject") && Input.GetMouseButton(0))
            {
                // DO STUFF WHEN SLICING OBJECT
                // * INITIATE A SEQUENCE OF NESTED CALLS!
                        hit.collider.isTrigger = true;
                    for(int i = hit.collider.gameObject.GetComponent<DispensedObjProperties>().debrisCount; i >= 0; i--)
                    {
                        hitGameObjectDebris = Instantiate(hit.collider.gameObject.GetComponent<DispensedObjProperties>().debris, hit.transform.position, Quaternion.identity);
                        hitGameObjectDebris.GetComponent<Rigidbody>().AddForce(hit.collider.gameObject.GetComponent<DispensedObjProperties>().debrisDirectionForce[i]);
                        Destroy(hitGameObjectDebris, 5f);
                    }
                ScorePoints(hit.collider.gameObject);
                killedWaveIndex = hit.collider.gameObject.GetComponent<DispensedObjProperties>().dispenseWave;
                
                Destroy(hit.collider.gameObject);

            }
        }






    }

    public void ScorePoints(GameObject go)
    {
        KeyValuePair<int, int>[] tempArr;
        tempArr = queue.ToArray();
        //Red = 1P
        //green = 3P
        //blue = 2P
        //For killing 2 of the same colour in a row a bonus modifier is awarded, but not continued on 3 or 4.
        if (lastHitDispenseType == go.GetComponent<MeshRenderer>().material.color.ToString()) // THIS MUST be before the other if checsk as last hit gets updated.
        {
            //ADD COMBO MULTIPLIER here
        }
        //else if (MULTIPLIER_ACTIVE && COUNT == 1)
        //{

        //    //REMOVE COMBO MULIPLIER.
        //    COUNT = 0;
        //}
        //else if (MULTIPLIER_ACTIVE)
        //{
        //    COUNT = 1;
        //}

        if (go.GetComponent<MeshRenderer>().material.color.ToString() == blueMat.color.ToString()) 
        {

            //Debug.Log(go.GetComponent<MeshRenderer>().material.color.ToString());
            lastHitDispenseType = go.GetComponent<MeshRenderer>().material.color.ToString();
        }
        if (go.GetComponent<MeshRenderer>().material.color.ToString() == greenMat.color.ToString()) 
        {

            lastHitDispenseType = go.GetComponent<MeshRenderer>().material.color.ToString();
        }
        if (go.GetComponent<MeshRenderer>().material.color.ToString() == redMat.color.ToString()) 
        {

            lastHitDispenseType = go.GetComponent<MeshRenderer>().material.color.ToString();
        }

            //For killing all in a dispense a bonus is awarded of 1P

            if (tempArr[0].Value > 1)
        {


            
            
            tempArr[0] = new KeyValuePair<int, int>(tempArr[0].Key, tempArr[0].Value - 1);
            queue.Clear();
            for(int i = 0; i < tempArr.Length; i++)
            {
                queue.Enqueue(tempArr[i]);
            }

            Debug.Log("Objects Left: "+ tempArr[0].Value);
            //queue.Peek() = new KeyValuePair<int, int>(queue.Peek().Key, queue.Peek().Value - 1);
        }
        else
        {
            Debug.Log("Objects Cleared");
            
            queue.Clear();
            for (int i = 1; i < tempArr.Length; i++)
            {
                queue.Enqueue(tempArr[i]);
            }
        }
        //For killing all in a dispense a bonus modifier is awarded + 1X

        

        //For missing an object all modifiers are lost.
         // SEE DEQUEUE


    }

    public void DeQueue()
    {
        KeyValuePair<int, int>[] tempArr;
        
        tempArr = queue.ToArray();
        queue.Clear();
        for (int i = 1; i < tempArr.Length; i++)
        {
            queue.Enqueue(tempArr[i]);
        }
        // REMOVE ALL MODIFIERS HERE



    }


}
