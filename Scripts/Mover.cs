using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private float _speed;

    private void Awake()
    {
        _transform = transform;
    }

    public void Move(Vector3 direction)
    {
        Vector3 offset = direction.normalized * (_speed * Time.deltaTime);
        _transform.Translate(offset);
    }
}
