using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private PlayerClient _player;
    private Animator _animator;

    private const string _inputVertical = "InputVertical";
    private const string _inputHorizontal = "InputHorizontal";

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _player.InfoUpdated += SetInput;
    }

    private void OnDestroy()
    {
        _player.InfoUpdated -= SetInput;
    }

    private void SetInput(PlayerClientInfo playerClientInfo)
    {
        _animator.SetFloat(_inputVertical, playerClientInfo.InputVertical);
        if (playerClientInfo.InputVertical >= 0)
        {
            _animator.SetFloat(_inputHorizontal, playerClientInfo.InputHorizontal);
        }
        else
        {
            _animator.SetFloat(_inputHorizontal, -playerClientInfo.InputHorizontal);
        }
    }
}
