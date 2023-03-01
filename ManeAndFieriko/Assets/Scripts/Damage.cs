using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int PhysicalDamage, FireDamage, IceDamge, ShockDamage,HolyDamage,PoisonDamage,DeathyDamage;

    public void Hit(GameObject HitTarget)
    {
        int OverallDamage = PhysicalDamage + FireDamage+ IceDamge+ ShockDamage+ HolyDamage+ PoisonDamage+ DeathyDamage;
        int targerHp = HitTarget.GetComponent<BasicStats>().hp;
        targerHp = targerHp - OverallDamage;
    }
}
