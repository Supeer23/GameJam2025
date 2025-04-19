using System;
using System.Collections.Generic;
using UnityEngine;


public enum enemyType{
    flying,
    normal,
    boss
};

[CreateAssetMenu]
public class enemyDataBase : ScriptableObject{
    public List<enemyDatas> enemyDatas;
}

[Serializable]
public class enemyDatas{
    [field:SerializeField] public string Name {get; private set;}
    [field:SerializeField] public int ID {get; private set;}
    [field:SerializeField] public GameObject Prefab {get; private set;}
    [field:SerializeField] public enemyType Type {get; private set;}
    [field:SerializeField] public int attackDamage {get; private set;}
    [field:SerializeField] public int Health {get; private set;}
}