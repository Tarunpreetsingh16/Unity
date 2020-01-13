using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float screenWidthUnity = 16f;
    //[SerializeField] float zAxis = 0f;
    [SerializeField] float minWidth = 1f;
    [SerializeField] float maxWidth = 15f;
    [SerializeField] Ball ball;
    [SerializeField] float xForce = 0f;
    [SerializeField] float yForce = 8f;
    void Start()
    {
        //GodMode();
    }

    // Update is called once per frame
    void Update()
    {
        float xPosition = Input.mousePosition.x / Screen.width * screenWidthUnity;
        Vector2 transformPaddle = new Vector2(xPosition,transform.position.y);
        transformPaddle.x = Mathf.Clamp(transformPaddle.x,minWidth,maxWidth) ;
        transform.position = transformPaddle;
        //GodMode();

    }

    private void GodMode()
    {
        Vector2 position = new Vector2(ball.transform.position.x,transform.position.y);
        position.x = Mathf.Clamp(position.x, minWidth, maxWidth);
        transform.position = position;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (yForce > ball.GetComponent<Rigidbody2D>().velocity.y)
        {
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(ball.GetComponent<Rigidbody2D>().velocity.x + Random.Range(-2,2), yForce);
        }
        else
        {
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(ball.GetComponent<Rigidbody2D>().velocity.x + Random.Range(-2, 2), ball.GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
