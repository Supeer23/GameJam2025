using UnityEngine;

public class runTimeEnemyData : MonoBehaviour
{
    public string Name;
    public int ID;
    public enemyType Type;
    public GameObject Prefab;
    public int AttackDamage;
    public int Health;
    public float attackRange;
    public float speed;
    
    public runTimeEnemyData(enemyDatas baseData){
        name = baseData.Name;
        ID = baseData.ID;
        Type = baseData.Type;
        Prefab = baseData.Prefab;
        AttackDamage = baseData.attackDamage;
        Health = baseData.Health;
        attackRange = baseData.attackRange;
        speed = baseData.moveSpeed;
    }
}
