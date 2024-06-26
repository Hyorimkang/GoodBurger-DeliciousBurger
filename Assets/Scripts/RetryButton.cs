using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryButtonScript : MonoBehaviour
{
    public Button retryButton;

   void Start()
    {
        if (retryButton != null)
        {
            retryButton.onClick.AddListener(OnSkipButtonClick);
        }
        else
        {
            Debug.LogError("Retry Button is not assigned in the Inspector!");
        }
    }

    void OnSkipButtonClick()
    {
        Debug.Log("Retry button clicked!");
        SceneManager.LoadScene("MainScene");
    }
}
