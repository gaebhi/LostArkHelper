using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_UIRoot : MonoBehaviour
{
    public static int width;
    public static int height;

    public UISprite spriteMap;

    public UIPopupList continentList;
    public UILabel labelContinet;

    public UIPopupList areaList;
    public UILabel labelArea;

    // Use this for initialization
    void Awake ()
    {
        float screenRatio = (float)Screen.currentResolution.width / (float)Screen.currentResolution.height;
		
		height = Screen.currentResolution.height;
        height = Mathf.FloorToInt( height / 1.2f);
        width = Mathf.FloorToInt(height * screenRatio);

        float spriteRatio = (float)width / (float)height;

        int spriteHeight = Mathf.FloorToInt( height / 1.2f);
        int spriteWidth = Mathf.FloorToInt(spriteHeight * spriteRatio);

        spriteMap.width = spriteWidth;
        spriteMap.height = spriteHeight;
    }
    public void SetContinentSelection()
    {
        if (continentList != null)
        {
            labelContinet.text = continentList.value;
            areaList.Clear();
            switch (continentList.value)
            {
                case "아르테미스":
                    foreach (var item in MC_Define.CotinentList.are)
					{
                        areaList.AddItem(item);
					}
                    break;
                case "유디아":
                    foreach (var item in MC_Define.CotinentList.udia)
					{
						areaList.AddItem(item);
					}
                    break;
                case "루테란서부":
                    foreach (var item in MC_Define.CotinentList.luteranWest)
					{
                        areaList.AddItem(item);
                    }
					break;
                case "루테란동부":
                    foreach (var item in MC_Define.CotinentList.luteranEast)
					{
                        areaList.AddItem(item);
                    }
					break;
                case "애니츠":
                    foreach (var item in MC_Define.CotinentList.anits)
					{                        
						areaList.AddItem(item);
                    }
					break;
                case "아르데타인":
                    foreach (var item in MC_Define.CotinentList.arde)
                    {
						areaList.AddItem(item);
                    }
					break;
                case "슈샤이어":
                    foreach (var item in MC_Define.CotinentList.sh)
					{
                        areaList.AddItem(item);
                    }
					break;
                case "베른북부":
                    foreach (var item in MC_Define.CotinentList.bernNorth)
					{
                        areaList.AddItem(item);
                    }
					break;
                case "대항해":
                    foreach (var item in MC_Define.CotinentList.greatVoyage)
					{
                        areaList.AddItem(item);
                    }
					break;
                default:
                    foreach (var item in MC_Define.CotinentList.are)
					{
                        areaList.AddItem(item);
                    }
					break;
            }
        }
    }

    public void SetAreaSelection()
    {
        if (areaList != null)
        {
            labelArea.text = areaList.value;
            switch (areaList.value)
            {
                //아르테미스
                case "레온하트":
                    spriteMap.spriteName = MC_Define.MapName.ar_leon;
                    break;
                case "로그힐":
                    spriteMap.spriteName = MC_Define.MapName.ar_log;
                    break;
                case "안게모스산기슭":
                    spriteMap.spriteName = MC_Define.MapName.ar_ange;
                    break;
                case "국경지대":
                    spriteMap.spriteName = MC_Define.MapName.ar_guk;
                    break;

               //유디아
                case "살란드구릉지":
                    spriteMap.spriteName = MC_Define.MapName.udia_sa;
                    break;
                case "오즈혼구릉지":
                    spriteMap.spriteName = MC_Define.MapName.udia_oz;
                    break;

                //루테란서부
                case "격전의평야":
                    spriteMap.spriteName = MC_Define.MapName.lw_guk;
                    break;
                case "레이크바":
                    spriteMap.spriteName = MC_Define.MapName.lw_lake;
                    break;
                case "메드리닉수도원":
                    spriteMap.spriteName = MC_Define.MapName.lw_mad;
                    break;
                case "빌브린숲":
                    spriteMap.spriteName = MC_Define.MapName.lw_bil;
                    break;
                case "자고라스산":
                    spriteMap.spriteName = MC_Define.MapName.lw_zago;
                    break;

                //루테란동부
                case "갈기파도항구":
                    spriteMap.spriteName = MC_Define.MapName.le_gal;
                    break;
                case "디오리카평원":
                    spriteMap.spriteName = MC_Define.MapName.le_dio;
                    break;
                case "라이아단구":
                    spriteMap.spriteName = MC_Define.MapName.le_lia;
                    break;
                case "루테란성":
                    spriteMap.spriteName = MC_Define.MapName.le_lu;
                    break;
                case "배꽃나무자생지":
                    spriteMap.spriteName = MC_Define.MapName.le_bae;
                    break;
                case "보레야영지":
                    spriteMap.spriteName = MC_Define.MapName.le_bo;
                    break;
                case "크로커니스해변":
                    spriteMap.spriteName = MC_Define.MapName.le_cro;
                    break;
                case "헤무리언덕":
                    spriteMap.spriteName = MC_Define.MapName.le_hae;
                    break;
                case "흑장미교회당":
                    spriteMap.spriteName = MC_Define.MapName.le_hk;
                    break;

                //애니츠
                case "거울계곡":
                    spriteMap.spriteName = MC_Define.MapName.an_mirror;
                    break;
                case "델파이현":
                    spriteMap.spriteName = MC_Define.MapName.an_del;
                    break;
                case "등나무언덕":
                    spriteMap.spriteName = MC_Define.MapName.an_dung;
                    break;
                case "소리의숲":
                    spriteMap.spriteName = MC_Define.MapName.an_sori;
                    break;
                case "항구도시창천":
                    spriteMap.spriteName = MC_Define.MapName.an_hang;
                    break;
                case "황혼의연무":
                    spriteMap.spriteName = MC_Define.MapName.an_hwang;
                    break;
  
                //아르데타인
                case "갈라진땅":
                    spriteMap.spriteName = MC_Define.MapName.ard_gal;
                    break;
                case "네벨호른":
                    spriteMap.spriteName = MC_Define.MapName.ard_ne;
                    break;
                case "리제폭포":
                    spriteMap.spriteName = MC_Define.MapName.ard_lise;
                    break;
                case "메마른통로":
                    spriteMap.spriteName = MC_Define.MapName.ard_me;
                    break;
                case "바람결구릉지":
                    spriteMap.spriteName = MC_Define.MapName.ard_wind;
                    break;
                case "슈테른":
                    spriteMap.spriteName = MC_Define.MapName.ard_sh;
                    break;
                case "토트리치":
                    spriteMap.spriteName = MC_Define.MapName.ard_to;
                    break;
                case "붉은모래사막":
                    spriteMap.spriteName = MC_Define.MapName.ard_red;
                    break;

                //베른북부
                case "라니아마을":
                    spriteMap.spriteName = MC_Define.MapName.bn_la;
                    break;
                case "발란카르산맥":
                    spriteMap.spriteName = MC_Define.MapName.bn_val;
                    break;
                case "베르닐삼림":
                    spriteMap.spriteName = MC_Define.MapName.bn_be;
                    break;
                case "베른성":
                    spriteMap.spriteName = MC_Define.MapName.bn_bc;
                    break;
                case "크로나항구":
                    spriteMap.spriteName = MC_Define.MapName.bn_cro;
                    break;
                case "파르나숲":
                    spriteMap.spriteName = MC_Define.MapName.bn_par;
                    break;
                case "페스나르고원":
                    spriteMap.spriteName = MC_Define.MapName.bn_pes;
                    break;

                //슈샤이어
                case "리겐스마을":
                    spriteMap.spriteName = MC_Define.MapName.sh_li;
                    break;
                case "머무른시간의호수":
                    spriteMap.spriteName = MC_Define.MapName.sh_mu;
                    break;
                case "서리감옥고원":
                    spriteMap.spriteName = MC_Define.MapName.sh_su;
                    break;
                case "얼어붙은바다":
                    spriteMap.spriteName = MC_Define.MapName.sh_freeze;
                    break;
                case "얼음나비절벽":
                    spriteMap.spriteName = MC_Define.MapName.sh_ice;
                    break;
                case "칼날바람언덕":
                    spriteMap.spriteName = MC_Define.MapName.sh_kal;
                    break;

                default:
                    spriteMap.spriteName = MC_Define.MapName.ar_leon;
                    break;
            }
        }
    }
}
