using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TotalScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text= "Total Score : " + ScoreCheckMaster.scoreMaster.score.ToString();
        ScoreCheckMaster.scoreMaster.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
