using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public SanPhamUI[] sanPham;
    public SanPhamUI[] baiViet;

    public Button priBtn; 

    void Start()
    {
        priBtn.onClick.AddListener(ShowPri);
        
        for (int i = 0; i < sanPham.Length; i++)
        {
            var products = GameDataManager.Instance.SanPhamSo.SanPham[i];
            sanPham[i].SetInfo(products);
        }
        
        for (int i = 0; i < baiViet.Length; i++)
        {
            var products = GameDataManager.Instance.BaiVietSO.SanPham[i];
            baiViet[i].SetInfo(products);
        }
    }

    private void ShowPri()
    {
        
    }
}