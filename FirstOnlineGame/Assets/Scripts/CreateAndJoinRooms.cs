using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createRooms;
    public InputField joinRooms;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createRooms.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRooms.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
    
}
