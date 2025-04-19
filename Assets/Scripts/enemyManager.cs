using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    public enemyDataBase dataBase;
    private List<runTimeEnemyData> activeEnemies = new List<runTimeEnemyData>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    public void spawnEnemy(int id, float difficultyMult){
        enemyDatas baseData = dataBase.enemyDatas.Find(e=> e.ID == id);
        if (baseData != null)
        {
            runTimeEnemyData runTimeData = new runTimeEnemyData(baseData);
            runTimeData.Health = Mathf.RoundToInt(runTimeData.Health * difficultyMult);
            runTimeData.AttackDamage = Mathf.RoundToInt(runTimeData.AttackDamage * difficultyMult);

            activeEnemies.Add(runTimeData);

            GameObject enemy = Instantiate(runTimeData.Prefab);
            enemy.GetComponent<Enemy>().Initialize(runTimeData);
        }
        
    }
}
