using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Unit[] Units;
    [SerializeField]
    private MainCamera camera;

    public static GameManager instace;

    private void Awake()
    {
        GameManager.instace = this;
        SetCamera();
    }

    private void SetCamera()
    {
        camera.SetStandardUnit(Units[0].gameObject);
    }

    public void SetIdle()
    {
        foreach(Unit unit in Units)
            unit.SetIdle();
    }

    public void SetRightWalk()
    {
        foreach(Unit unit in Units)
            unit.SetRightWalk();

        camera.SetRightPosition();
    }
    public void SetLeftWalk()
    {
        foreach(Unit unit in Units)
            unit.SetLeftWalk();

        camera.SetLeftPosition();
    }

    public void SetAttack()
    {
        foreach(Unit unit in Units)
            unit.SetAttack();
    }

    //public float RecoveryStamina()
    //{
    //    return 0.5f;
    //}
}
