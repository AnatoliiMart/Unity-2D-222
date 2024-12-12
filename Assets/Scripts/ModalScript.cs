using UnityEngine;
using UnityEngine.SceneManagement;

public class ModalScript : MonoBehaviour
{
    private GameObject content;
    public static bool onPause = false;
    void Start()
    {
        content = transform.Find("Content").gameObject;
        Time.timeScale = content.activeInHierarchy ? 0.0f : 1.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (!onPause)
            {
                this.content.transform.Find("ContentStart").gameObject.SetActive(false);
                this.content.transform.Find("ContentGameOver").gameObject.SetActive(false);
                this.content.transform.Find("ContentPause").gameObject.SetActive(true);
                onPause = true;
            }
            Time.timeScale = content.activeInHierarchy ? 1.0f : 0.0f;
            this.content.SetActive(!this.content.activeInHierarchy);
        }
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void OnPlayButtonClick()
    {
        Time.timeScale = 1.0f;
        this.content.SetActive(false);
    }

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}