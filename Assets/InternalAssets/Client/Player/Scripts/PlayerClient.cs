using FishNet.Object;
using System;
using UnityEngine;

public class PlayerClient : NetworkObject
{
    public event Action<PlayerClientInfo> InfoUpdated;

    [SerializeField] private GameObject _cameraPrefab;
    [SerializeField] private Transform _cameraPlace;
    [SerializeField] private PlayerInput _input;
    private IPlayerMovementServer _movement;
    private PlayerClientInfo _localInfo;

    protected override void Start()
    {
        base.Start();
        _localInfo = new PlayerClientInfo();
        _movement = GetComponent<IPlayerMovementServer>();

        if (IsOwner || IsHost)
        {
            var camera = Instantiate(_cameraPrefab);
            camera.transform.parent = _cameraPlace;
            camera.transform.localPosition = Vector3.zero;
            camera.transform.localRotation = Quaternion.identity;
        }
    }

    private void Update()
    {
        if (IsOwner || IsHost)
        {
            _localInfo.InputVertical = _input.InputVertical;
            _localInfo.InputHorizontal = _input.InputHorizontal;
            InfoUpdated?.Invoke(_localInfo);

            _movement.RequestInput(this, _localInfo);
        }
    }
}
