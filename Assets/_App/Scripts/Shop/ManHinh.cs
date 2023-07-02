using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManHinh : MonoBehaviour
{
    public string title;
    public TextMeshProUGUI tieuDe;
    public Button buttonBack;

    void Start()
    {
        tieuDe.SetText(title);
        buttonBack.onClick.AddListener(() => SetActive(false));
    }

    public void SetActive(bool b)
    {
        gameObject.SetActive(b);
    }
}