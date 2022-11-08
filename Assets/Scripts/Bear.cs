using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : LivingEntity, IDamageable
{
    public void Damage(int amount)
    {
        health -= amount;

        // �������� ���� �ǰ� �ִϸ��̼� ó��

        Debug.Log(" ������ ���� !!");

    }

    void OnCollisionEnter(Collision collision)
    {
        collision.collider.GetComponent<IDamageable>().Damage(damage);
    }
}
