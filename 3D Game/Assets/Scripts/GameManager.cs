using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("地板陣列")]
    // 陣列 : 儲存多筆相同類型的資料
    public Transform[] terrains;
    [Header("地板移動速度"), Range(1f, 50f)]
    public float speedTerrain = 20f;

    /// <summary>
    /// 移動地板
    /// </summary>
    private void MoveTerrain()
    {
     
        for (int i = 0; i < terrains.Length; i++)
        {
            // 如果 地板.Z 小於 100
            if (terrains[i].position.z <= -100)
            {
                // 另一塊地板前方 100 位置
                terrains[i].position = new Vector3(0, 0, terrains[1 - i].position.z + 95f);
            }
            // 移動
            terrains[i].Translate(0, 0, -speedTerrain * Time.deltaTime);
        }
    }

    /// <summary>
    /// 固定禎數更新事件 : 1 秒 50 禎
    /// </summary>
    private void FixedUpdate()
    {
        MoveTerrain();
    }

}
