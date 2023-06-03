using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using PlayFab;
using PlayFab.ClientModels;
using AdvancedPlayFab;

public class PlayfabPurchase : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("SCRIPTS")]
    public AdvancedPlayfab AdvancedPlayfab;

    [Header("COSMETICS")]
    [Tooltip("What will be enabled when you buy the cosmetic.")]
    public List<GameObject> enable;
    [Tooltip("What will be disabled when you buy the cosmetic. (Leave blank if you have only one button.")]
    public List<GameObject> disable;

    [Header("BUY")]
    [Tooltip("The name of the cosmetic.")]
    public string CosmeticName;
    [Tooltip("The price of the cosmetic.")]
    public int coinsPrice;
    [Tooltip("Where the cosmetics price will be displayed.")]
    public TextMeshPro PriceText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HandTag")
        {
            if (AdvancedPlayfab.CurrencyAmount >= coinsPrice)
            {
                if (PlayerPrefs.GetInt(CosmeticName) != 1)
                {
                    PlayerPrefs.SetInt(CosmeticName, 1);
                    BuyItem();
                }
                if (PlayerPrefs.GetInt(CosmeticName) == 1)
                {
                    for (int i = 0; i < enable.Count; i++)
                    {
                        enable[i].SetActive(true);
                    }
                    for (int i = 0; i < disable.Count; i++)
                    {
                        disable[i].SetActive(true);
                    }

                    gameObject.SetActive(false);
                }
            }
        }

    }

    public void BuyItem()
    {
        var request = new SubtractUserVirtualCurrencyRequest
        {
            VirtualCurrency = AdvancedPlayfab.CurrencyCode,
            Amount = coinsPrice
        };
        PlayFabClientAPI.SubtractUserVirtualCurrency(request, OnSubtractCoins, OnError);
    }

    void OnSubtractCoins(ModifyUserVirtualCurrencyResult result)
    {
        Debug.Log(CosmeticName + "Has been bought.");
        AdvancedPlayfab.GetInventory();
    }

    void OnError(PlayFabError error)
    {
        Debug.Log("Error: " + error.ErrorMessage);
    }

    private void Start()
    {
        PriceText.text = coinsPrice.ToString();

        if (PlayerPrefs.GetInt(CosmeticName) == 1)
        {
            for (int i = 0; i < enable.Count; i++)
            {
                enable[i].SetActive(true);
            }
            for (int i = 0; i < disable.Count; i++)
            {
                disable[i].SetActive(true);
            }

            gameObject.SetActive(false);
        }
    }
}