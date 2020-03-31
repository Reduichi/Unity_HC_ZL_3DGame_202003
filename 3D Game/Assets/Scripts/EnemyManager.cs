using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Enemy enemy1, enemy2;

    private void Start()
    {
        // 取得 欄位
        print(enemy1.hp);
        // 設定 欄位
        enemy2.hp = 200;

        // 設定 屬性
        enemy1.attack = 999;
        // 取得 屬性
        print("怪物1號的攻擊力:" + enemy1.attack);
    }
}
