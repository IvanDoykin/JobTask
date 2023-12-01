using FishNet.Managing;
using FishNet.Object;
using System.Collections;
using UnityEngine;

public class LocalStarter : MonoBehaviour
{
    [SerializeField] private NetworkManager _network;

    private void Start()
    {
        StartLocalPlayer();
    }

    private void StartLocalPlayer()
    {
        _network.ServerManager.StartConnection();
        _network.ClientManager.StartConnection();
    }
}
