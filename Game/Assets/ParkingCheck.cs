using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ParkingCheck : MonoBehaviour
{
    HashSet<Collider2D> colls = new HashSet<Collider2D>();
    [SerializeField]
    string[] parkingTags = new string[] { "Top Left Parking", "Top Right Parking", "Bottom Left Parking", "Bottom Right Parking" };



    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        if (colls.Count == 4) {
            success();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (parkingTags.Contains(collision.tag)){ 
            colls.Add(collision);
            Debug.Log(collision);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        colls.Remove(collision);
        Debug.Log(collision);
    }

    private void success() {
        Debug.Log("SUCESS!!!!!!");
    }



}
