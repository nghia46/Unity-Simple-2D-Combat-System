using UnityEngine;


public class CharacterController : MonoBehaviour
{
    public Animator playerAnimator;
    public bool isAttacking = false;
    public static CharacterController instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    private void Attack()
    {
        if(Input.GetMouseButtonDown(0) && !isAttacking)
        {
            isAttacking =true;
        }
    }
}

