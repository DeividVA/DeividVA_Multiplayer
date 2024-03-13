using Photon.Pun;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D.Sprites;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    public static bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        GetComponent<BoxCollider2D>().enabled = false;
        isPressed = true;   
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
        GetComponent<BoxCollider2D>().enabled = true;
        isPressed = false;
    }

}
