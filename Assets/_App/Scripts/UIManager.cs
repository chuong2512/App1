using System.Collections;
using System.Collections.Generic;
using TimDoVat;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public ThongTinBaiViet ThongTinBaiViet;
    public ThongTinSanPham ThongTinSanPham;
    public AllBaiViet AllBaiViet;
    public AllSanPham AllSanPham;


    void OnValidate()
    {
        ThongTinBaiViet = GetComponentInChildren<ThongTinBaiViet>();
        ThongTinSanPham = GetComponentInChildren<ThongTinSanPham>();
        AllBaiViet = GetComponentInChildren<AllBaiViet>();
        AllSanPham = GetComponentInChildren<AllSanPham>();
    }

    public void ShowSanPham(int id)
    {
        ThongTinSanPham.SetActive(true);
        ThongTinSanPham.ShowInfo(id);
    }

    public void ShowTTSanPham()
    {
        ThongTinSanPham.SetActive(true);
    }

    public void ShowAllSanPham()
    {
        AllBaiViet.SetActive(true);
    }

    public void ShowTTBaiViet()
    {
        ThongTinBaiViet.SetActive(true);
    }

    public void ShowAllBaiViet()
    {
        AllBaiViet.SetActive(true);
    }
}