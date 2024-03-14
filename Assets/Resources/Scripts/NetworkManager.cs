using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class NetworkManager : MonoBehaviourPunCallbacks
{

    private int _playerID;
    private GameObject _myAvatar;
    private GameObject _buttonL;
    private GameObject _buttonR;

    public static int buttonsPressed = 0;

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
        PhotonNetwork.JoinOrCreateRoom("room1", new RoomOptions() {MaxPlayers = 2, }, TypedLobby.Default);
    }

    // second PUN callback (event triggered when joined or created room)
    // first client joining creates room and is master client

    public override void OnJoinedRoom()
    {
        Debug.Log($"Joined {PhotonNetwork.CurrentRoom.Name}, we are {PhotonNetwork.CurrentRoom.Players.Count} players inside");
        _playerID = PhotonNetwork.CurrentRoom.Players.Count;

        // avatar creation
        // prefabs are in Resources folder
        _myAvatar = PhotonNetwork.Instantiate($"Prefabs/avatar{_playerID}", new Vector3(_playerID == 1 ? -1 : 1, 0, 0), Quaternion.identity);
        //_myAvatar.GetComponentInChildren<SpriteRenderer>().color = _playerID == 1 ? Color.green : Color.blue;
        if (_playerID == 1)
        {
            _buttonL = PhotonNetwork.Instantiate("Prefabs/button", new Vector3(-10, 2, 0), Quaternion.identity);
            _buttonR = PhotonNetwork.Instantiate("Prefabs/button", new Vector3(10, 2, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
