using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int Health;
    private int attackDamage;

    public void Initialize(runTimeEnemyData data){
        Health = data.Health;
        attackDamage = data.AttackDamage;
    }
}
