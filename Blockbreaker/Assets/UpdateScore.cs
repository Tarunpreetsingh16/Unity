using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
        GetComponent<Text>().text = "Score : " + ScoreCheckMaster.scoreMaster.score.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
