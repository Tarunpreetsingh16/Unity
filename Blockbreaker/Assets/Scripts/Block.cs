using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioClip clip;
    [SerializeField] GameObject vfx;
    [SerializeField] int maxHits;
    [SerializeField] Sprite[] sprites;

    [SerializeField] int totalHits = 0;
    Level level;
    public void Start()
    {
        level = FindObjectOfType<Level>();
        if (tag == "Breakable")
        {
            level.CountBreakableBricks();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        totalHits++;
        if (tag == "Breakable" && maxHits == totalHits)
        {
            DestroyBrick();
        }
        else if(tag == "Breakable")
        {
            GetComponent<SpriteRenderer>().sprite = sprites[totalHits-1];
        }
    }
    private void DestroyBrick()
    {
        PlayAnimation();
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, 100);
        Destroy(gameObject);
        level.BreakBricks();
    }
    private void PlayAnimation()
    {
        GameObject sparkle = Object.Instantiate(vfx,transform.position,transform.rotation);
        Destroy(sparkle,0.2f);
    }
}
