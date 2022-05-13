using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{

    public GameObject playerPrefab;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    private float maxY = 11.26f;

    private void Start()
    {
        Vector3 rP = new Vector3(Random.Range(minX, maxX), maxY, Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(playerPrefab.name, rP, Quaternion.identity); // Quaternion.identity means no roation of the object
    }
}
