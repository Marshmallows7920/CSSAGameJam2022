using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfOnTargets : MonoBehaviour
{
    // Start is called before the first frame update
    BoxCollider2D bc;
    SpriteRenderer sr;
    bool isOn = false;

    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sr.color = Color.green;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sr.color = Color.red;
    }
}
