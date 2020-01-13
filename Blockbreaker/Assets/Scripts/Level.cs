using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public static int score;
    // Start is called before the first frame update
    [SerializeField] int bricks = 0;
    [SerializeField] Text scoreText;

    LoadScene loadScene;
    public void Start()
    {
        loadScene = FindObjectOfType<LoadScene>();
    }
    public void CountBreakableBricks()
    {
        bricks++;
    }
    public void BreakBricks()
    {
        ScoreCheckMaster.scoreMaster.score++;
        scoreText.text = "Score : " + ScoreCheckMaster.scoreMaster.score.ToString();
        bricks--;
        if(bricks == 0)
        {
            loadScene.LoadNextLevel();
        }
    }
}
