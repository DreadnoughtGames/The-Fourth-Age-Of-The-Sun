using UnityEngine;

public class InputManager : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            GameManager.instace.SetAttack();
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            GameManager.instace.SetRightWalk();
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            GameManager.instace.SetLeftWalk();
        }
        else if(Input.anyKey == false)
        {
            GameManager.instace.SetIdle();
        }
    }
}
