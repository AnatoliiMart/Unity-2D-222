using UnityEngine;

public class ModalScript : MonoBehaviour
{
    private GameObject content;
    void Start()
    {
        content = this.transform.Find("Content").gameObject;
        if (content.activeInHierarchy)
            Time.timeScale = 0;  // Pause the game when the modal is open.

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = content.activeInHierarchy ? 1.0f : 0.0f;  // Toggle pause when escape key is pressed.
            content.SetActive(!content.activeInHierarchy);

        }
    }
    public void OnExitButtonClick()
    {
        Application.Quit();  // Quit the game when the exit button is clicked.
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
    public void OnResumeButtonClick()
    {
        Time.timeScale = 1.0f;
        content.SetActive(false);
    }
}
