using Photon.Pun;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D.Sprites;
using UnityEngine;

public class ButtonController : MonoBehaviourPunCallbacks
{

    private PhotonView _myPhotonView;
    private SpriteRenderer _spriteRenderer;
    private BoxCollider2D _boxcollider2D;
    public bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _myPhotonView = GetComponent<PhotonView>();
        _boxcollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_myPhotonView.IsMine && !isPressed)
        {
            _myPhotonView.RPC("ChangeColorRed", RpcTarget.All);
            isPressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_myPhotonView.IsMine && isPressed)
        {
            _myPhotonView.RPC("ChangeColorYellow", RpcTarget.All);
            isPressed = false;
        }
    }

    [PunRPC]
    void ChangeColorRed() 
    {
        _spriteRenderer.color = Color.red;
        Debug.Log("pressed");
        NetworkManager.ButtonPressed();
    }

    [PunRPC]
    void ChangeColorYellow()
    {
        _spriteRenderer.color = Color.yellow;
        Debug.Log("released");
        NetworkManager.ButtonReleased();
    }


    public static void Blocker(GameObject objecttoblock)
    {
        //objecttoblock.GetComponent<SpriteRenderer>() = Color.black;
        //_boxcollider2D.enabled = false;
    }




}
