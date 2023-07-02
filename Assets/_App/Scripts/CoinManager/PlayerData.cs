using System;
using System.Collections.Generic;
using UnityEngine;

public class Constant
{
    public static string DataKey_PlayerData = "player_data";
}

public class PlayerData : BaseData
{
    public List<ThongTinDangNhap> accounts;
    public List<DonHang> donHangs;

    public long time;
    public int donHangID;
    public string timeRegister;

    public void SetTimeRegister(long timeSet)
    {
        timeRegister = DateTime.Now.ToBinary().ToString();
        time = timeSet;
        Save();
    }

    public void ResetTime()
    {
        time = 0;
        Save();
    }

    public override void Init()
    {
        prefString = Constant.DataKey_PlayerData;

        if (PlayerPrefs.GetString(prefString).Equals(""))
        {
            ResetData();
        }

        base.Init();
    }

    public override void ResetData()
    {
        timeRegister = DateTime.Now.ToBinary().ToString();
        time = 7 * 24 * 60 * 60;

        donHangID = 0;
        accounts = new List<ThongTinDangNhap>();
        donHangs = new List<DonHang>();
        Save();
    }

    public void TaoDon(SanPham sanPham)
    {
        donHangs.Add(new DonHang()
        {
            donHangID = donHangID,
            ID = sanPham.ID,
            anh = sanPham.anh,
            gia = sanPham.gia,
            name = sanPham.name,
            thongTin = sanPham.thongTin
        });
        
        donHangID++;
        Save();
    }

    public void ThemTaiKhoan(ThongTinDangNhap thongTinDangNhap)
    {
        accounts.Add(thongTinDangNhap);
        Save();
    }

    public bool CheckTrungTaiKhoan(ThongTinDangNhap thongTinDangNhap)
    {
        var result = accounts.Find(info => info.tenDangNhap == thongTinDangNhap.tenDangNhap);

        return result != null;
    }
}