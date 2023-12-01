using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private KeyCode _keyForward;
    [SerializeField] private KeyCode _keyBackward;
    [SerializeField] private KeyCode _keyLeft;
    [SerializeField] private KeyCode _keyRight;

    private float _inputVertical = 0f;
    private float _inputHorizontal = 0f;

    public float InputVertical => _inputVertical;
    public float InputHorizontal => _inputHorizontal;

    private void Update()
    {
        if (Input.GetKey(_keyForward))
        {
            _inputVertical = 1f;
        }
        else if (Input.GetKey(_keyBackward))
        {
            _inputVertical = -1f;
        }
        else
        {
            _inputVertical = 0f;
        }

        if (Input.GetKey(_keyLeft))
        {
            _inputHorizontal = -1f;
        }
        else if (Input.GetKey(_keyRight))
        {
            _inputHorizontal = 1f;
        }
        else
        {
            _inputHorizontal = 0f;
        }
    }
}
