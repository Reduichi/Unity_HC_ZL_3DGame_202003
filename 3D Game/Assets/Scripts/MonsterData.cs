﻿using UnityEngine;

[CreateAssetMenu(fileName = "怪物資料", menuName = "RED/怪物資料")]
public class MonsterData : ScriptableObject
{
    [Header("血量"), Range(1, 10000)]
    public float hp;
    [Header("攻擊"), Range(1, 1000)]
    public float attack;
    [Header("移動速度"), Range(1, 100)]
    public float speed;
    [Header("補血藥水掉落機率"), Range(0, 1)]
    public float propHp;
    [Header("加速藥水掉落機率"), Range(0, 1)]
    public float propCd;
    [Header("攻擊冷卻"), Range(0, 5)]
    public float cd;
    [Header("子彈速度"), Range(1, 50)]
    public float bulletSpeed;
}
