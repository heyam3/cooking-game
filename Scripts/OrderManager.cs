using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class OrderManager : MonoBehaviour
{
    public GameObject orderTicketPrefab;
    public Transform orderPanel;
    public Sprite burgerTicketSprite;
    public Sprite burgerDrinkTicketSprite;
    public Sprite drinkTicketSprite;

    private List<GameObject> activeOrders = new List<GameObject>();

    private void Start()
    {
        GenerateOrder();
    }

    private void GenerateOrder()
    {
        GameObject orderTicket = Instantiate(orderTicketPrefab, orderPanel);
        int randomOrder = Random.Range(0, 3);

        switch (randomOrder)
        {
            case 0:
                orderTicket.GetComponent<Image>().sprite = burgerTicketSprite;
                break;
            case 1:
                orderTicket.GetComponent<Image>().sprite = burgerDrinkTicketSprite;
                break;
            case 2:
                orderTicket.GetComponent<Image>().sprite = drinkTicketSprite;
                break;
        }

        activeOrders.Add(orderTicket);
    }

    private void CompleteOrder(GameObject orderTicket)
    {
        activeOrders.Remove(orderTicket);
        Destroy(orderTicket);
        // Add money
    }

    private void FailOrder(GameObject orderTicket)
    {
        activeOrders.Remove(orderTicket);
        Destroy(orderTicket);
        // Subtract money
    }
}