using FishNet.Object;
using UnityEngine;

public class LocalPlayerMovement : MonoBehaviour, IPlayerMovementServer
{
    private const float _playerSpeed = 5f;

    public void RequestInput(NetworkObject player, PlayerClientInfo playerInfo)
    {
        player.transform.position += _playerSpeed * Time.deltaTime * new Vector3(playerInfo.InputHorizontal, 0f, playerInfo.InputVertical);
    }
}
