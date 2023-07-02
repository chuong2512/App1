using System.Collections;
using System.Collections.Generic;
using TimDoVat;
using UnityEngine;

public class PurchasingManager : Singleton<PurchasingManager>
{
    public void OnPressDown(int i)
    {
        IAPManager.OnPurchaseSuccess = () =>
        {
            GameDataManager.Instance.TaoDonHang(ButtonBuy.buyID);
            gameObject.SetActive(false);
        };

        switch (i)
        {
            case 1:
                IAPManager.Instance.BuyProductID(Key.PACK1);
                break;
            case 2:
                IAPManager.Instance.BuyProductID(Key.PACK2);
                break;
            case 3:
                IAPManager.Instance.BuyProductID(Key.PACK3);
                break;
            case 4:
                IAPManager.Instance.BuyProductID(Key.PACK4);
                break;
            case 5:
                IAPManager.Instance.BuyProductID(Key.PACK5);
                break;
            case 6:
                IAPManager.Instance.BuyProductID(Key.PACK6);
                break;
        }
    }

    public void Show(int id)
    {
        ButtonBuy.buyID = id;
        gameObject.SetActive(true);
    }


    public void Sub(int i)
    {
    }
}