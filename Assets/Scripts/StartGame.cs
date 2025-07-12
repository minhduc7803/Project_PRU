using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
        public void OnStartButtonClicked()
        {
            SceneManager.LoadScene("Level 1"); // Đổi "MainScene" thành tên scene chính của bạn
        }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
