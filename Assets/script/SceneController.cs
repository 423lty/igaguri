using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GameHome()
    {
        SceneManager.LoadScene("Start");
    }
    /// <summary>
    /// ゲーム画面に遷移
    /// </summary>
    public void GameStart()
    {
        SceneManager.LoadScene("Game");
    }
    /// <summary>
    /// ゲーム終了画面遷移
    /// </summary>
    public void GameEnd()
    {
        SceneManager.LoadScene("End");
    }
    /// <summary>
    /// 再スタート
    /// </summary>
    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
