using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartCurrentScene()
    {
        Time.timeScale = 1f;  // 解除暫停（如果有暫停）
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
