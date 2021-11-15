using UnityEngine;

public class AiInput : IShipInput
{
    public float Rotation { get; set; }
    public float Thrust { get; set; }

    public void ReadInput()
    {
        Rotation = Random.Range(-10f, 10f);
        Thrust = Random.Range(0f, 1f);
    }
}
