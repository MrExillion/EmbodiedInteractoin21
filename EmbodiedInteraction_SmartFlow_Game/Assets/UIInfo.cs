
using UnityEngine;
using UnityEngine.UI;

public class UIInfo : MonoBehaviour
{

    private Text difficultyInfo;
    private DifficultyController difficultyController;
    
    // Start is called before the first frame update

    void Start()
    {
        difficultyInfo = GameObject.Find("Difficulty").GetComponent<Text>();
        difficultyController = GameObject.Find("DispenserContainer").GetComponent<DifficultyController>();
    }

    // Update is called once per frame
    void Update()
    {
        difficultyInfo.text = "Difficulty Level: "+difficultyController.GetDifficultyLevel();
    }
}
