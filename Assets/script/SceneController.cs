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
    /// �Q�[����ʂɑJ��
    /// </summary>
    public void GameStart()
    {
        SceneManager.LoadScene("Game");
    }
    /// <summary>
    /// �Q�[���I����ʑJ��
    /// </summary>
    public void GameEnd()
    {
        SceneManager.LoadScene("End");
    }
    /// <summary>
    /// �ăX�^�[�g
    /// </summary>
    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
