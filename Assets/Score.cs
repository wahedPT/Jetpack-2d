using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int Scorevalue = 0;
   
    int highScore;
    Text Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        Scoretext = GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("highScore");
    }

    // Update is called once per frame
    void Update()
    {
        Scoretext.text = "Score:  " + Scorevalue;
    }
}

