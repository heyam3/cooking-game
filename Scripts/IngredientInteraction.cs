using UnityEngine;

public class IngredientInteraction : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Picked up " + gameObject.name);
        }
    }
}