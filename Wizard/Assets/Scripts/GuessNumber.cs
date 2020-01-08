using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GuessNumber : MonoBehaviour
{
    // Start is called before the first frame update
    int max = 1001;
    int min = 1;

    [SerializeField] Text score;
    public void Lower()
    {
        max = int.Parse(score.text);
        score.text = ((min + max) / 2).ToString();
    }
    public void Higher()
    {
        min = int.Parse(score.text);
        score.text = ((min + max) / 2).ToString();
    }
}
