using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meat : MonoBehaviour
{
    public GameObject meatclone;
    public Sprite[] pic;
    public SpriteRenderer meatbone;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.CompareTag("yeemon"))
            {
                meatbone.sprite = pic[1];
                gameObject.tag = "bone";
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        meatbone.sprite = pic[0];
    }

    // Update is called once per frame
    void Update()
    {
        
        Destroy(gameObject, 5f);
        

    }
}
