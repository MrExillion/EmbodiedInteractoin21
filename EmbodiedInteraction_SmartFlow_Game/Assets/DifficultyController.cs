using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour
{

    public int DifficultyLevel = 10;
    private int difficultyLevel;


    public void Awake()
    {
        // SET difficulty to inspector value or 10.
        SetDifficultyLevel(DifficultyLevel);
    }


    public int GetDifficultyLevel()
    {
        DifficultyLevel = difficultyLevel;
        return DifficultyLevel;

    }
    private void SetDifficultyLevel(int newLevel)
    {
        difficultyLevel = newLevel;
        
    }


    public void Update()
    {

        // MANUAL DIFFICULTY ADJUSTMENT
        if (Input.GetKeyUp(KeyCode.PageUp))
        {
            SetDifficultyLevel(GetDifficultyLevel() + 1);

        }
        else if (Input.GetKeyUp(KeyCode.PageDown))
        {
            SetDifficultyLevel(GetDifficultyLevel() - 1);

        }
        // AI DIFFICULTY ADJUSTMENT


        /*
         
        SOME FUNCTION CALL TO AN AI
        
        */

    }










}
