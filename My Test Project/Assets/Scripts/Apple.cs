using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public GameObject collected;


    private SpriteRenderer sr;
    private CircleCollider2D cc;


    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        cc = GetComponent<CircleCollider2D>();
    }


    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            cc.enabled = false;
            collected.SetActive(true);

            Destroy(gameObject, 0.3f);
        }
    }
}
