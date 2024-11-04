using UnityEngine;

public class Unit : MonoBehaviour
{
    protected enum UnitState { Idle, RightWalk, LeftWalk, Attack };
    protected UnitState unitState;

    [SerializeField]
    protected float speed;

    [SerializeField]
    protected float maxStamina = 100.0f;
    protected float stamina = 0.0f;
    private GameObject staminaSprite;
    private float staminaSpriteMaxWidth;

    private void Awake()
    {
        //SetStaminaSprite();
    }

    private void FixedUpdate()
    {
        switch(unitState)
        {
            case UnitState.RightWalk:
                transform.position += Vector3.right * speed * 0.01f;
                break;
            case UnitState.LeftWalk:
                transform.position += Vector3.left * speed * 0.01f;
                break;
        }

        // Recovery stmina
        //RecoveryStamina();

        //UpdateStaminaSprite();
    }

    public void SetIdle()
    {
        unitState = UnitState.Idle;
        this.GetComponent<Animator>().SetTrigger("IdleTrigger");
    }

    public void SetRightWalk()
    {
        GetComponent<SpriteRenderer>().flipX = false;
        unitState = UnitState.RightWalk;
        this.GetComponent<Animator>().SetTrigger("WalkTrigger");
    }
    public void SetLeftWalk()
    {
        GetComponent<SpriteRenderer>().flipX = true;
        unitState = UnitState.LeftWalk;
        this.GetComponent<Animator>().SetTrigger("WalkTrigger");
    }

    public void SetAttack()
    {
        unitState = UnitState.Attack;
        this.GetComponent<Animator>().SetTrigger("AttackTrigger");

        // use stamina
        //this.stamina -= 10.0f;
    }

    //public void SetStaminaSprite()
    //{
    //    this.staminaSprite = this.transform.Find("Stamina").gameObject;
    //}

    //public void RecoveryStamina()
    //{
    //    if(this.stamina >= maxStamina)
    //    {
    //        this.stamina = maxStamina;

    //        return;
    //    }

    //    this.stamina += GameManager.instace.RecoveryStamina();

    //    Debug.Log("Stamina: " + this.stamina);
    //}

    //public void UpdateStaminaSprite()
    //{
    //    this.staminaSpriteMaxWidth = this.staminaSprite.transform.localScale.x;

    //    this.staminaSprite.transform.localScale = new Vector3(this.staminaSpriteMaxWidth * this.stamina, this.staminaSprite.transform.localScale.y, this.staminaSprite.transform.localScale.z);
    //}
}
