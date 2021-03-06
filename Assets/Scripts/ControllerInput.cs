using UnityEngine;

public class ControllerInput : IShipInput
{
    public float Rotation { get; set; }
    public float Thrust { get; set; }

    public void ReadInput()
    {
        Rotation = Input.GetAxis("Horizontal");
        Thrust = Input.GetAxis("Vertical");
    }
}
