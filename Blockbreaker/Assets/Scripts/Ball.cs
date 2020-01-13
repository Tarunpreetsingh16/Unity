using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Paddle paddle;
    [SerializeField] float xForce = 2f;
    [SerializeField] float yForce = 15f;
    [SerializeField] AudioClip[] clips;
    AudioSource audioSource;
    Vector2 vector2Ball;
    float difference;

    bool statusCheck = false;
    void Start()
    {
        difference = transform.position.y - paddle.transform.position.y; ;
        FreezeBall();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && statusCheck == false)
        {
            ShootTheBall();
        }
        if (statusCheck == false)
        {
            FreezeBall();
        }
    }

    private void FreezeBall()
    {
        vector2Ball = new Vector2(paddle.transform.position.x, paddle.transform.position.y + difference);
        transform.position = vector2Ball;
    }
    private void ShootTheBall()
    {
        statusCheck = true;
        GetComponent<Rigidbody2D>().velocity = new Vector2(xForce, yForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (statusCheck == true)
        {
            AudioClip clip = clips[UnityEngine.Random.Range(0, clips.Length)];
            audioSource.PlayOneShot(clip);
        }
    }
}
