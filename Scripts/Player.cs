using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Player : MonoBehaviour
{
    [SerializeField] private KeyCode _leftMovingKey;
    [SerializeField] private KeyCode _rightMovingKey;

    private Mover _mover;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        Vector2 direction = Vector2.zero;
        Vector2 possibleXDirection = Vector2.right;

        if (Input.GetKey(_leftMovingKey))
            direction -= possibleXDirection;
        else if (Input.GetKey(_rightMovingKey))
            direction += possibleXDirection;

        _mover.Move(direction);
    }
}
