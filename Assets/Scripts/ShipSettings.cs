using UnityEngine;

[CreateAssetMenu(menuName = "Ship/Settings", fileName = "ShipData")]
public class ShipSettings : ScriptableObject
{
    [SerializeField] private float _turnSpeed = 150f;
    [SerializeField] private float _moveSpeed = 15f;
    [SerializeField] private bool _useAi = false;

    public float TurnSpeed { get { return _turnSpeed; } }
    public float MoveSpeed { get { return _moveSpeed; } }
    public bool UseAi { get { return _useAi; } }
}
