using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_Define : MonoBehaviour
{
    public class MapName
    {
        //아르테미스
        public readonly string ar_leon = "ar_leon";
        public readonly string ar_log = "ar_log";
        public readonly string ar_ange = "ar_ange";
        public readonly string ar_guk = "ar_guk";

        //유디아
        public readonly string udia_sa = "udia_sa";
        public readonly string udia_oz = "udia_oz";

        //루테란서부
        public readonly string lw_guk = "lw_guk";
        public readonly string lw_lake = "lw_lake";
        public readonly string lw_mad = "lw_mad";
        public readonly string lw_bil = "lw_bil";
        public readonly string lw_zago = "lw_zago";

        //루테란동부
        public readonly string le_gal = "le_gal";
        public readonly string le_dio = "le_dio";
        public readonly string le_lia = "le_lia";
        public readonly string le_lu = "le_lu";
        public readonly string le_bae = "le_bae";
        public readonly string le_bo = "le_bo";
        public readonly string le_cro = "le_cro";
        public readonly string le_hae = "le_hae";
        public readonly string le_hk = "le_hk";

        //애니츠
        public readonly string an_mirror = "an_mirror";
        public readonly string an_del = "an_del";
        public readonly string an_dung = "an_dung";
        public readonly string an_sori = "an_sori";
        public readonly string an_hang = "an_hang";
        public readonly string an_hwang = "an_hwang";

        //아르데타인
        public readonly string ard_gal = "ard_gal";
        public readonly string ard_ne = "ard_ne";
        public readonly string ard_lise = "ard_lse";
        public readonly string ard_me = "ard_me";
        public readonly string ard_wind = "ard_wind";
        public readonly string ard_sh = "ard_sh";
        public readonly string ard_to = "ard_to";
        public readonly string ard_red = "ard_red";

        //베른북부
        public readonly string bn_la = "bn_la";
        public readonly string bn_val = "bn_val";
        public readonly string bn_be = "bn_be";
        public readonly string bn_bc = "bn_bc";
        public readonly string bn_cro = "bn_cro";
        public readonly string bn_par = "bn_par";
        public readonly string bn_pes = "bn_pes";

        //슈샤이어
        public readonly string sh_li = "sh_li";
        public readonly string sh_mu = "sh_mu";
        public readonly string sh_su = "sh_su";
        public readonly string sh_freeze = "sh_freeze";
        public readonly string sh_ice = "sh_ice";
        public readonly string sh_kal = "sh_kal";
    }

    public List<string> are = new List<string>();
    public List<string> udia = new List<string>();
    public List<string> luteranWest = new List<string>();
    public List<string> luteranEast = new List<string>();
    public List<string> anits = new List<string>();
    public List<string> arde = new List<string>();
    public List<string> sh = new List<string>();
    public List<string> bernNorth = new List<string>();
    public List<string> greatVoyage = new List<string>();

    private void Awake()
    {
        //아르테미스
		are.Add("레온하트");
		are.Add("로그힐");
		are.Add("안게모스산기슭");
		are.Add("국경지대");

        //유디아
        udia.Add("살란드구릉지");
        udia.Add("오즈혼구릉지");

        //루테란서부
        luteranWest.Add("격전의평야");        
        luteranWest.Add("레이크바");
        luteranWest.Add("메드리닉수도원");
        luteranWest.Add("빌브린숲");
        luteranWest.Add("자고라스산");

        //루테란동부
        luteranEast.Add("갈기파도항구");
        luteranEast.Add("디오리카평원");
        luteranEast.Add("라이아단구");
        luteranEast.Add("루테란성");
        luteranEast.Add("배꽃나무자생지");
        luteranEast.Add("보레야영지");
        luteranEast.Add("크로커니스해변");
        luteranEast.Add("헤무리언덕");
        luteranEast.Add("흑장미교회당");

        //애니츠
        anits.Add("거울계곡");
        anits.Add("델파이현");
        anits.Add("등나무언덕");
        anits.Add("소리의숲");
        anits.Add("항구도시창천");
        anits.Add("황혼의연무");

        //아르데타인
        arde.Add("갈라진땅");
        arde.Add("네벨호른");
        arde.Add("리제폭포");
        arde.Add("메마른통로");
        arde.Add("바람결구릉지");
        arde.Add("슈테른");
        arde.Add("토트리치");
        arde.Add("붉은모래사막");

        //베른북부
        bernNorth.Add("라니아마을");
        bernNorth.Add("발란카르산맥");
        bernNorth.Add("베르닐삼림");
        bernNorth.Add("베른성");
        bernNorth.Add("크로나항구");
        bernNorth.Add("파르나숲");
        bernNorth.Add("페스나르고원");

        //슈샤이어
        sh.Add("리겐스마을");
        sh.Add("머무른시간의호수");
        sh.Add("서리감옥고원");
        sh.Add("얼어붙은바다");
        sh.Add("얼음나비절벽");
        sh.Add("칼날바람언덕");
    }

}
