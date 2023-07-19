using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ThongTinSanPham : ManHinh
{
    public SanPhamUI SanPhamUi;
    public Button button;
    private int ID;
    
    protected override void Start()
    {
        base.Start();
        button.onClick.AddListener(ShowInfoShop);
    }

   
    public void SetInfo(SanPham product)
    {
    }

    public void ShowInfo(int id)
    {
        var sanPham = GameDataManager.Instance.SanPhamSo.GetSanPhamWithID(id);

        ID = id;
        SanPhamUi.SetInfo(sanPham);
    }
    
    
    protected override void Back()
    {
        base.Back();
    }

    private void Save()
    {
        GameDataManager.Instance.TickSave(ID);
    }

    public void ShowInfoShop()
    {
        PurchasingManager.Instance.Show(ID);
    }

}