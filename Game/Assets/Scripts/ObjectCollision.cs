using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    private BoxCollider2D bc;
    [SerializeField] GameObject crashedPopout;

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //insert what we want to do if they hit a wrong thing
        Debug.Log("IT FUCKING WORKED!!!!");
        crashedPopout.SetActive(true);
    }
}
