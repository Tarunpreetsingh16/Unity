using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCheckMaster : MonoBehaviour
{
    public static ScoreCheckMaster scoreMaster;
    public int score = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        if(scoreMaster == null)
        {
            DontDestroyOnLoad(gameObject);
            scoreMaster = this;
        }
        else if(scoreMaster != this)
        {
            Destroy(gameObject);
        }
    }
}
