using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    public RectTransform transitionPanel;
    public float slideDuration = 1f;

    private void Start()
    {
        // Ensure the transition panel is off-screen at the start
        transitionPanel.anchoredPosition = new Vector2(-transitionPanel.rect.width, 0);
    }

    public void StartGame()
    {
        StartCoroutine(SlideOut("MainGame"));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private IEnumerator SlideIn()
    {
        float elapsedTime = 0f;

        while (elapsedTime < slideDuration)
        {
            float x = Mathf.Lerp(-transitionPanel.rect.width, 0, elapsedTime / slideDuration);
            transitionPanel.anchoredPosition = new Vector2(x, 0);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transitionPanel.anchoredPosition = Vector2.zero;
    }

    private IEnumerator SlideOut(string sceneName)
    {
        float elapsedTime = 0f;

        while (elapsedTime < slideDuration)
        {
            float x = Mathf.Lerp(0, transitionPanel.rect.width, elapsedTime / slideDuration);
            transitionPanel.anchoredPosition = new Vector2(x, 0);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        SceneManager.LoadScene(sceneName);
    }
}