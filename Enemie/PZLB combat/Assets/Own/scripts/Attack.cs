using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator animator;
    public string Base_attack = "Base_attack";
    public string NPCname = "Enemy (slime)";
    public int PlayerPower = 5;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayerAttack()
    {
        animator.SetTrigger(Base_attack);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        PlayerAttack();
    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == NPCname)
        {
            Col.GetComponent<IEnemy>().TakeDmg(PlayerPower);
        }
    }
}
