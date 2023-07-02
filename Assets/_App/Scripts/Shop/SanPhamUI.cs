using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SanPhamUI : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI name, thongTin, gia;
    public Button button;
    private int ID;

    void OnValidate()
    {
        button = GetComponent<Button>();
    }

    void Start()
    {
        button.onClick.AddListener(ShowInfo);
    }

    private void ShowInfo()
    {
        UIManager.Instance.ShowSanPham(ID);
    }

    public void SetInfo(SanPham product)
    {
        ID = product.ID;
        image.sprite = product.anh;
        name?.SetText(product.name);
        gia?.SetText(product.gia);
        thongTin?.SetText(product.thongTin);
    }
}
