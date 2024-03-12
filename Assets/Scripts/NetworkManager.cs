using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class NetworkManager : MonoBehaviourPunCallbacks
{

    private int _playerID;
    private int _myAvatar;

    // Start is called before the first frame update
    void Start()
    {
        // Conexión Photon
        PhotonNetwork.ConnectUsingSettings();

    }


    // first PUN callback (evennt when connected to master)

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected");
        PhotonNetwork.JoinOrCreateRoom("room1", new Photon.Realtime.RoomOptions() {MaxPlayers = 2 }, Photon.Realtime.TypedLobby.Default);
    }

    // second PUN callback (event triggered when joined or created room)
    // first cñoemt joining creates room and is master client

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined");
        // avatar creation
        // prefabs are in Resources folder
        //PhotonNetwork.Instantiate
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
