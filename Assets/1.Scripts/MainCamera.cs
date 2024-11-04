using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MainCamera : MonoBehaviour
{
    private GameObject standardUnit;
    private float bias;

    [SerializeField]
    private const float CAMERA_SPEED = 0.1f;

    private void Start()
    {
        bias = 5f;
    }

    public void SetStandardUnit(GameObject stdUnit)
    {
        standardUnit = stdUnit;
    }
    private void FixedUpdate()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(standardUnit.transform.position.x + bias, -0.25f, -10), CAMERA_SPEED);
    }
    public void SetRightPosition()
    {
        bias = 5f;
    }

    public void SetLeftPosition()
    {
        bias = -11f;
    }
}
