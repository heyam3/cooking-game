using UnityEngine;

public class CashierInteraction : MonoBehaviour
{
    public GameObject speechBubble;

    private void StartConversation()
    {
        // Flip the speech bubble back and forth to simulate conversation
        StartCoroutine(ConversationCoroutine());
    }

    private IEnumerator ConversationCoroutine()
    {
        while (true)
        {
            speechBubble.transform.localScale = new Vector3(1, 1, 1);
            yield return new WaitForSeconds(1f);
            speechBubble.transform.localScale = new Vector3(-1, 1, 1);
            yield return new WaitForSeconds(1f);
        }
    }
}