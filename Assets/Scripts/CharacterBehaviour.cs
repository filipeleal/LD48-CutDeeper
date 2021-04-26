using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    public TimingBarBehaviour AttackBar;

    public SpriteRenderer Renderer;

    public Sprite[] CharacterSprites;


    public int Health;

    public int Power;
    public int Skill;
    public int Speed;

    public CharacterEnum Character;

    float lastAttackValue;

    public bool Attacked;

    public bool IsAI;

    // Start is called before the first frame update
    void Awake()
    {
        Power = 0;
        Skill = 0;
        Speed = 0;
        
        Health = 5;

        Renderer.sprite = CharacterSprites[(int)Character];
        Attacked = false;

        if (IsAI)
        {
            StartCoroutine("AIAttack");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetLastAttackValue()
    {
        return lastAttackValue;
    }

    void OnAttack()
    {
        if (IsAI )
            return;

        Attack();

       // Debug.Log($"{lastAttackValue}");
    }

    void Attack()
    {
        lastAttackValue = AttackBar.Attack();
        Attacked = true;
    }

    IEnumerator AIAttack()
    {
        float wait = Random.Range(2f, 3f);
        yield return new WaitForSeconds(wait);

        Attack();
    }

    public void TakeDamage()
    {
        Health -= 1;
    }

    public void Reload()
    {
        AttackBar.ShowTimeBars();
        Attacked = false;

        if (IsAI)
        {
            StartCoroutine("AIAttack");
        }
    }

    public WeaponEnum GetWeapon()
    {
        switch (Character)
        {
            case CharacterEnum.Samurai:
                return WeaponEnum.Katana;
            case CharacterEnum.Amazon:
                return WeaponEnum.Arrow;
            default:
                return WeaponEnum.Katana;
        }
    }
}
