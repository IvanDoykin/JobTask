using FishNet.Object;
using UnityEngine;

public class NetworkPlayerMovement : NetworkBehaviour, IPlayerMovementServer
{
    private const float _playerSpeed = 5f;

    [ServerRpc]
    public void RequestInput(NetworkObject player, PlayerClientInfo playerInfo)
    {
        player.transform.position += _playerSpeed * Time.deltaTime * new Vector3(playerInfo.InputHorizontal, 0f, playerInfo.InputVertical);
    }
}
