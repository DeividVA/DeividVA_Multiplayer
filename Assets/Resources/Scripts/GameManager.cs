using Photon.Pun;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _buttonL;
    [SerializeField] private GameObject _buttonR;
    //private bool b1p = false;
    public ButtonController _button;
    private int _pressedcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        _button = FindObjectOfType<ButtonController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (ButtonController.isPressed) {
            Debug.Log("pressed");
            //b1p = true;
            //Debug.Log(b1p);
            //_pressedcount++;
            //Debug.Log(_pressedcount);
        } else
        {
            //b1p = false;
            Debug.Log(b1p);
        }
    }




}