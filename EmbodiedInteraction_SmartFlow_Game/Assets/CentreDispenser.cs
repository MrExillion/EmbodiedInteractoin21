using UnityEngine;

public class CentreDispenser : Dispenser
{


    private DifficultyController difficultyController;
    private int diffLevel;
    private float lastDispense;
    
    [SerializeField] private float[] frequencyList;
    // Start is called before the first frame update



   

    private void Awake()
    {
       

    }

    void Start()
    {
       difficultyController = GameObject.Find("DispenserContainer").GetComponent<DifficultyController>();
    }

    // Update is called once per frame
    void Update()
    {
        diffLevel = difficultyController.GetDifficultyLevel();

        switch (diffLevel)
        {
            case 0:
                {   if(Time.deltaTime + (frequencyList[0] + lastDispense) <= Time.time)
                    {
                        Dispense(DispenseableObjects, 0, 750, dispenseID);
                        dispensecounter += 1;
                        lastDispense = Time.time;
                    }

                    break;
                }
            case 1:
                {
                    if (Time.deltaTime + (frequencyList[1] + lastDispense) <= Time.time)
                    {
                        Dispense(DispenseableObjects, 0, 750, dispenseID);
                        dispensecounter += 1;
                        lastDispense = Time.time;
                    }
                    break;
                }
            case 2:
                {
                    if (Time.deltaTime + (frequencyList[2] + lastDispense) <= Time.time)
                    {
                        Dispense(DispenseableObjects, 0, 750, dispenseID);
                        dispensecounter += 1;
                        lastDispense = Time.time;
                    }
                    break;
                }
            case 3:
                {
                    if (Time.deltaTime + (frequencyList[3] + lastDispense) <= Time.time)
                    {
                        Dispense(DispenseableObjects, 0, 750, dispenseID);
                        dispensecounter += 1;
                        lastDispense = Time.time;
                    }
                    break;
                }
            case 4:
                {
                    if (Time.deltaTime + (frequencyList[4] + lastDispense) <= Time.time)
                    {
                        Dispense(DispenseableObjects, 0, 750, dispenseID);
                        dispensecounter += 1;
                        lastDispense = Time.time;
                    }
                    break;
                }
            case 5:
                {
                    if (Time.deltaTime + (frequencyList[5] + lastDispense) <= Time.time)
                    {
                        Dispense(DispenseableObjects, 0, 750, dispenseID);
                        dispensecounter += 1;
                        lastDispense = Time.time;
                    }
                    break;
                }
            case 6:
                {
                    if (Time.deltaTime + (frequencyList[6] + lastDispense) <= Time.time)
                    {
                        Dispense(DispenseableObjects, 0, 750, dispenseID);
                        dispensecounter += 1;
                        lastDispense = Time.time;
                    }
                    break;
                }
            case 7:
                {
                    if ((Time.deltaTime + frequencyList[7]) + lastDispense <= Time.time)
                    {
                        Dispense(DispenseableObjects, 0, 750, dispenseID);
                        dispensecounter += 1;
                        lastDispense = Time.time;
                    }
                    break;
                }
            case 8:
                {
                    if ((Time.deltaTime + frequencyList[8]) + lastDispense <= Time.time)
                    {
                        Dispense(DispenseableObjects, 0, 750, dispenseID);
                        dispensecounter += 1;
                        lastDispense = Time.time;
                    }
                    break;
                }
            case 9:
                {
                    if (Time.deltaTime + (frequencyList[9] + lastDispense) <= Time.time)
                    {
                        Dispense(DispenseableObjects, 0, 750, dispenseID);
                        dispensecounter += 1;
                        lastDispense = Time.time;
                    }
                    break;
                }
            case 10:
                {
                    if (Time.deltaTime + (frequencyList[10] + lastDispense) <= Time.time)
                    {
                        Dispense(DispenseableObjects, 0, 750, dispenseID);
                        dispensecounter += 1;
                        lastDispense = Time.time;
                    }
                    break;
                }
            default:
                {
                    if(diffLevel <= 0)
                    {
                        goto case 0;
                    }
                    else
                    {
                        Debug.Log("Default 10");
                        goto case 10;
                    }


                }



        }
        



    }




}


