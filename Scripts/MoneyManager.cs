using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public Text moneyText;
    private int money = 0;

    private void Start()
    {
        UpdateMoneyText();
    }

    public void AddMoney(int amount)
    {
        money += amount;
        UpdateMoneyText();
    }

    public void SubtractMoney(int amount)
    {
        money -= amount;
        UpdateMoneyText();
    }

    private void UpdateMoneyText()
    {
        moneyText.text = "$" + money.ToString();
    }
}