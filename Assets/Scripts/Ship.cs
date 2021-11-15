using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private ShipSettings _shipSettings;

    private IShipInput _shipInput;
    private ShipMotor _shipMotor;

    private void Awake()
    {
        _shipInput = _shipSettings.UseAi ? new AiInput() as IShipInput : new ControllerInput();
        _shipMotor = new ShipMotor(_shipInput, transform, _shipSettings);
    }

    void Update()
    {
        _shipInput.ReadInput();
        _shipMotor.Move();
    }
}
