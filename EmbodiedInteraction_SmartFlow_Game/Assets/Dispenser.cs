using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    public GameObject[] DispenseableObjects;
    public static CentreDispenser centreDispenser;
    public int dispensecounter = 0;
    public int dispenseID = 0; // not in use but referenced



    public void Dispense(GameObject[] go,int seed, float dispenserforce, int id)
    {
        GameObject clone = Instantiate(go[seed], gameObject.transform.position, gameObject.transform.rotation);
        clone.GetComponent<Rigidbody>().AddForce(clone.transform.up * dispenserforce);
        //clone.GetComponent<Rigidbody>().AddTorque(Vector3.left * 5f);
        
        try
        {
            clone.GetComponent<DispensedObjProperties>().dispenseWave = dispensecounter;
            clone.GetComponent<DispensedObjProperties>().dispenseType = clone.GetComponent<MeshRenderer>().material.color.ToString();
            GameObject.Find("DispenserContainer").GetComponent<Dispenser>().dispensecounter = dispensecounter;
        }
       
        catch
        {

        }
        Destroy(clone, 15);

    }

    private int GetDispenseWave()
    {
        return -1;
    }

}


