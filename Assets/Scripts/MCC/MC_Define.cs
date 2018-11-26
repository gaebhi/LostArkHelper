using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_Define : MonoBehaviour
{
    public class MapName
    {
        //아르테미스
        public const string ar_leon = "ar_leon";
        public const string ar_log = "ar_log";
        public const string ar_ange = "ar_ange";
        public const string ar_guk = "ar_guk";

        //유디아
        public const string udia_sa = "udia_sa";
        public const string udia_oz = "udia_oz";

        //루테란서부
        public const string lw_guk = "lw_guk";
        public const string lw_lake = "lw_lake";
        public const string lw_mad = "lw_mad";
        public const string lw_bil = "lw_bil";
        public const string lw_zago = "lw_zago";

        //루테란동부
        public const string le_gal = "le_gal";
        public const string le_dio = "le_dio";
        public const string le_lia = "le_lia";
        public const string le_lu = "le_lu";
        public const string le_bae = "le_bae";
        public const string le_bo = "le_bo";
        public const string le_cro = "le_cro";
        public const string le_hae = "le_hae";
        public const string le_hk = "le_hk";

        //애니츠
        public const string an_mirror = "an_mirror";
        public const string an_del = "an_del";
        public const string an_dung = "an_dung";
        public const string an_sori = "an_sori";
        public const string an_hang = "an_hang";
        public const string an_hwang = "an_hwang";

        //아르데타인
        public const string ard_gal = "ard_gal";
        public const string ard_ne = "ard_ne";
        public const string ard_lise = "ard_lse";
        public const string ard_me = "ard_me";
        public const string ard_wind = "ard_wind";
        public const string ard_sh = "ard_sh";
        public const string ard_to = "ard_to";
        public const string ard_red = "ard_red";

        //베른북부
        public const string bn_la = "bn_la";
        public const string bn_val = "bn_val";
        public const string bn_be = "bn_be";
        public const string bn_bc = "bn_bc";
        public const string bn_cro = "bn_cro";
        public const string bn_par = "bn_par";
        public const string bn_pes = "bn_pes";

        //슈샤이어
        public const string sh_li = "sh_li";
        public const string sh_mu = "sh_mu";
        public const string sh_su = "sh_su";
        public const string sh_freeze = "sh_freeze";
        public const string sh_ice = "sh_ice";
        public const string sh_kal = "sh_kal";
    }

    public class CotinentList
    {
        public static List<string> are = new List<string>();
        public static List<string> udia = new List<string>();
        public static List<string> luteranWest = new List<string>();
        public static List<string> luteranEast = new List<string>();
        public static List<string> anits = new List<string>();
        public static List<string> arde = new List<string>();
        public static List<string> sh = new List<string>();
        public static List<string> bernNorth = new List<string>();
        public static List<string> greatVoyage = new List<string>();
    }

    private void Awake()
    {
        //아르테미스
        CotinentList.are.Add("레온하트");
        CotinentList.are.Add("로그힐");
        CotinentList.are.Add("안게모스산기슭");
        CotinentList.are.Add("국경지대");

        //유디아
        CotinentList.udia.Add("살란드구릉지");
        CotinentList.udia.Add("오즈혼구릉지");

        //루테란서부
        CotinentList.luteranWest.Add("격전의평야");        
        CotinentList.luteranWest.Add("레이크바");
        CotinentList.luteranWest.Add("메드리닉수도원");
        CotinentList.luteranWest.Add("빌브린숲");
        CotinentList.luteranWest.Add("자고라스산");

        //루테란동부
        CotinentList.luteranEast.Add("갈기파도항구");
        CotinentList.luteranEast.Add("디오리카평원");
        CotinentList.luteranEast.Add("라이아단구");
        CotinentList.luteranEast.Add("루테란성");
        CotinentList.luteranEast.Add("배꽃나무자생지");
        CotinentList.luteranEast.Add("보레야영지");
        CotinentList.luteranEast.Add("크로커니스해변");
        CotinentList.luteranEast.Add("헤무리언덕");
        CotinentList.luteranEast.Add("흑장미교회당");

        //애니츠
        CotinentList.anits.Add("거울계곡");
        CotinentList.anits.Add("델파이현");
        CotinentList.anits.Add("등나무언덕");
        CotinentList.anits.Add("소리의숲");
        CotinentList.anits.Add("항구도시창천");
        CotinentList.anits.Add("황혼의연무");

        //아르데타인
        CotinentList.arde.Add("갈라진땅");
        CotinentList.arde.Add("네벨호른");
        CotinentList.arde.Add("리제폭포");
        CotinentList.arde.Add("메마른통로");
        CotinentList.arde.Add("바람결구릉지");
        CotinentList.arde.Add("슈테른");
        CotinentList.arde.Add("토트리치");
        CotinentList.arde.Add("붉은모래사막");

        //베른북부
        CotinentList.bernNorth.Add("라니아마을");
        CotinentList.bernNorth.Add("발란카르산맥");
        CotinentList.bernNorth.Add("베르닐삼림");
        CotinentList.bernNorth.Add("베른성");
        CotinentList.bernNorth.Add("크로나항구");
        CotinentList.bernNorth.Add("파르나숲");
        CotinentList.bernNorth.Add("페스나르고원");

        //슈샤이어
        CotinentList.sh.Add("리겐스마을");
        CotinentList.sh.Add("머무른시간의호수");
        CotinentList.sh.Add("서리감옥고원");
        CotinentList.sh.Add("얼어붙은바다");
        CotinentList.sh.Add("얼음나비절벽");
        CotinentList.sh.Add("칼날바람언덕");
    }

}
