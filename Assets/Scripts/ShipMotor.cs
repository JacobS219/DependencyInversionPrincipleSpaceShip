using UnityEngine;

public class ShipMotor
{
    private readonly IShipInput _shipInput;
    private readonly Transform _transformToMove;
    private readonly ShipSettings _shipSettings;

    public ShipMotor(IShipInput shipInput, Transform transformToMove, ShipSettings shipSettings)
    {
        _shipInput = shipInput;
        _transformToMove = transformToMove;
        _shipSettings = shipSettings;
    }

    public void Move()
    {
        _transformToMove.position += Time.deltaTime * -_transformToMove.forward * _shipInput.Thrust * _shipSettings.MoveSpeed; // -_transformToMove.forward inverted vertical axis
        _transformToMove.Rotate(Vector3.up * _shipInput.Rotation * Time.deltaTime * _shipSettings.TurnSpeed);
    }
}
