using FishNet.Object;

public interface IPlayerMovementServer
{
    public void RequestInput(NetworkObject player, PlayerClientInfo playerInfo);
}
