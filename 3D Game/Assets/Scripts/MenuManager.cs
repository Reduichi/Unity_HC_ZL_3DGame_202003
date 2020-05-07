using UnityEngine;
using UnityEngine.UI;                   // 引用介面 API
using UnityEngine.SceneManagement;      // 引用 場景 API
using System.Collections;               // 引用 系統.集合 API (協程)

public class MenuManager : MonoBehaviour
{
    [Header("載入畫面")]
    /// <summary>
    /// 載入畫面
    /// </summary>
    public GameObject panelLoading;

    [Header("載入畫面文字")]
    /// <summary>
    /// 載入畫面文字
    /// </summary>
    public Text textLoading;

    [Header("載入畫面吧條")]
    /// <summary>
    /// 載入畫面吧條
    /// </summary>
    public Image imgLoading;

    public void StartLoading()
    {
        panelLoading.SetActive(true);
        StartCoroutine(Loading());
    }

    private IEnumerator Loading()
    {
        // SceneManager.LoadScene("關卡1");         // 載入場景
        AsyncOperation ao = SceneManager.LoadSceneAsync("關卡1");
        ao.allowSceneActivation = false;            // 關閉自動載入場景

        // 迴圈 while(布林植) { 當布林值為 true 時執行敘述 }
        while (ao.progress < 1)
        {
            print("關卡進度 : " + ao.progress);

            textLoading.text = (ao.progress / 0.9f * 100).ToString("F2") + "%";       // 更新載入文字

            imgLoading.fillAmount = ao.progress / 0.9f;                               // 更新載入吧條
            yield return null;                                                        // 等待

            // 判斷式 if(布林植) { 當布林值為 true 時執行敘述 }
            if (ao.progress == 0.9f)                                                  // 如果 進度 = 0.9
            {
                ao.allowSceneActivation = true;                                       // 允許自動載入場景
            }
        }
    }

    private void Start()
    {
        // 螢幕.設定解析度(寬，高，是否全螢幕) - EXE 與網頁 (Build Settings)
        Screen.SetResolution(450, 800, false);
    }
}
