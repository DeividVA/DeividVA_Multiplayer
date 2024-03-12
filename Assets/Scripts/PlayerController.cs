using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    private PhotonView _myPhotonView;

    // Start is called before the first frame update
    void Start()
    {
        _myPhotonView = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_myPhotonView.IsMine) return;
        if (Input.GetKeyDown(KeyCode.A)) transform.position += new Vector3(-1, 0, 0);
        if (Input.GetKeyDown(KeyCode.D)) transform.position += new Vector3(1, 0, 0);
        if (Input.GetKeyDown(KeyCode.S)) transform.position += new Vector3(0, -1, 0);
        if (Input.GetKeyDown(KeyCode.W)) transform.position += new Vector3(0, 1, 0);
    }
}
