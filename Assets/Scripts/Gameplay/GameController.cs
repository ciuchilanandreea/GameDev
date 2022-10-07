using UnityEngine;

public class GameController : MonoBehaviour
{
    private Player _player;
    void Start()
    {
        _player = FindObjectOfType<Player>();
    }


}
