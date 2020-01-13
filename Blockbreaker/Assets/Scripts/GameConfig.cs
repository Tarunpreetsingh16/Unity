using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfig : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1.3f;

    private void Update()
    {
        Time.timeScale = gameSpeed;
    }
}
