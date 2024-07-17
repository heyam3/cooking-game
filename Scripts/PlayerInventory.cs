using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private Sprite carriedItem;

    public void AddCookedPatty(Sprite cookedPattySprite)
    {
        carriedItem = cookedPattySprite;
        UpdateCarriedItemDisplay();
    }

    private void UpdateCarriedItemDisplay()
    {
        // Assuming you have an Image component to display the carried item
        // You can modify this to fit your actual implementation
        GameObject carriedItemDisplay = GameObject.Find("CarriedItemDisplay");
        if (carriedItemDisplay != null)
        {
            carriedItemDisplay.GetComponent<UnityEngine.UI.Image>().sprite = carriedItem;
            carriedItemDisplay.GetComponent<UnityEngine.UI.Image>().enabled = true;
        }
    }

    public void DropItem()
    {
        carriedItem = null;
        UpdateCarriedItemDisplay();
    }
}