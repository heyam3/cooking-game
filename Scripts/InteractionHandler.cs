using UnityEngine;
using UnityEngine.UI;

public class InteractionHandler : MonoBehaviour
{
    public Image carriedItemImage; // Assign the Image component of the CarriedItem GameObject

    public Sprite drinkSprite; // Assign in the Inspector
    public Sprite bunSprite; // Assign in the Inspector
    public Sprite pattySprite; // Assign in the Inspector
    public Sprite burgerSprite; // Assign in the Inspector

    private string carriedItem;

    public void OnGetDrinkButtonClicked()
    {
        carriedItem = "Drink";
        UpdateCarriedItemDisplay(drinkSprite);
    }

    public void OnGetBunButtonClicked()
    {
        carriedItem = "Bun";
        UpdateCarriedItemDisplay(bunSprite);
    }

    public void OnGetPattyButtonClicked()
    {
        carriedItem = "Patty";
        UpdateCarriedItemDisplay(pattySprite);
    }

    public void OnDropOffButtonClicked()
    {
        if (carriedItem == "Drink")
        {
            // Handle drink drop off logic
        }
        else if (carriedItem == "Burger")
        {
            // Handle burger drop off logic
        }
        // Clear carried item
        carriedItem = null;
        carriedItemImage.sprite = null;
        carriedItemImage.enabled = false;
    }

    private void UpdateCarriedItemDisplay(Sprite sprite)
    {
        carriedItemImage.sprite = sprite;
        carriedItemImage.enabled = true;
    }

    public void AssembleBurger()
    {
        if (carriedItem == "Bun" || carriedItem == "Patty")
        {
            // Assume we have both bun and patty collected
            carriedItem = "Burger";
            UpdateCarriedItemDisplay(burgerSprite);
        }
    }
}