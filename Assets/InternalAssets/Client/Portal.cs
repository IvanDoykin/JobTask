using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] private int _multiplayerSceneIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerClient>() != null)
        {
            SceneManager.LoadScene(_multiplayerSceneIndex);
        }
    }
}
