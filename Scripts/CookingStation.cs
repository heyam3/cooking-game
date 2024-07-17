using UnityEngine;
using System.Collections; // Add this line to include the IEnumerator interface

public class CookingStation : MonoBehaviour
{
    public Sprite cookedPattySprite;
    private bool isCooking = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isCooking)
        {
            StartCoroutine(CookPatty(collision.gameObject));
        }
    }

    private IEnumerator CookPatty(GameObject player)
    {
        isCooking = true;
        yield return new WaitForSeconds(5f); // Cooking time
        player.GetComponent<PlayerInventory>().AddCookedPatty(cookedPattySprite);
        isCooking = false;
    }
}