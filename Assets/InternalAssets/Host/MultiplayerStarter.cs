using FishNet.Managing;
using UnityEngine;

public class MultiplayerStarter : MonoBehaviour
{
    [SerializeField] private NetworkManager _network;

    private void Start()
    {
        StartMultiplayerPlayer();
    }

    private void StartMultiplayerPlayer()
    {
#if !UNITY_EDITOR
#if UNITY_SERVER
        _network.ServerManager.StartConnection();
#else
        _network.ClientManager.StartConnection();
#endif
#else
        if (ParrelSync.ClonesManager.IsClone())
        {
            _network.ClientManager.StartConnection();
        }
        else
        {
            _network.ServerManager.StartConnection();
        }
#endif
    }
}
