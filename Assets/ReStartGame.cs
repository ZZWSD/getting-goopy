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
        Time.timeScale = 1f;  // �Ѱ��Ȱ��]�p�G���Ȱ��^
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
