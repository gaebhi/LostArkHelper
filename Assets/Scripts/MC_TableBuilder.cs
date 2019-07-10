using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_TableBuilder : MonoBehaviour
{
    //CotinentList
    [HideInInspector]
    public List<string> are = new List<string>();
    [HideInInspector]
    public List<string> udia = new List<string>();
    [HideInInspector]
    public List<string> luteranWest = new List<string>();
    [HideInInspector]
    public List<string> luteranEast = new List<string>();
    [HideInInspector]
    public List<string> anits = new List<string>();
    [HideInInspector]
    public List<string> arde = new List<string>();
    [HideInInspector]
    public List<string> sh = new List<string>();
    [HideInInspector]
    public List<string> bernNorth = new List<string>();
    [HideInInspector]
    public List<string> greatVoyage = new List<string>();

    //map name
    public static string Ar_leon
    {
        get
        {
            return ar_leon;
        }
    }

    public static string Ar_log
    {
        get
        {
            return ar_log;
        }
    }

    public static string Ar_ange
    {
        get
        {
            return ar_ange;
        }
    }

    public static string Ar_guk
    {
        get
        {
            return ar_guk;
        }
    }

    public static string Udia_sa
    {
        get
        {
            return udia_sa;
        }
    }

    public static string Udia_oz
    {
        get
        {
            return udia_oz;
        }
    }

    public static string Lw_guk
    {
        get
        {
            return lw_guk;
        }
    }

    public static string Lw_lake
    {
        get
        {
            return lw_lake;
        }
    }

    public static string Lw_mad
    {
        get
        {
            return lw_mad;
        }
    }

    public static string Lw_bil
    {
        get
        {
            return lw_bil;
        }
    }

    public static string Lw_zago
    {
        get
        {
            return lw_zago;
        }
    }

    public static string Le_gal
    {
        get
        {
            return le_gal;
        }
    }

    public static string Le_dio
    {
        get
        {
            return le_dio;
        }
    }

    public static string Le_lia
    {
        get
        {
            return le_lia;
        }
    }

    public static string Le_lu
    {
        get
        {
            return le_lu;
        }
    }

    public static string Le_bae
    {
        get
        {
            return le_bae;
        }
    }

    public static string Le_bo
    {
        get
        {
            return le_bo;
        }
    }

    public static string Le_cro
    {
        get
        {
            return le_cro;
        }
    }

    public static string Le_hae
    {
        get
        {
            return le_hae;
        }
    }

    public static string Le_hk
    {
        get
        {
            return le_hk;
        }
    }

    public static string An_mirror
    {
        get
        {
            return an_mirror;
        }
    }

    public static string An_del
    {
        get
        {
            return an_del;
        }
    }

    public static string An_dung
    {
        get
        {
            return an_dung;
        }
    }

    public static string An_sori
    {
        get
        {
            return an_sori;
        }
    }

    public static string An_hang
    {
        get
        {
            return an_hang;
        }
    }

    public static string An_hwang
    {
        get
        {
            return an_hwang;
        }
    }

    public static string Ard_gal
    {
        get
        {
            return ard_gal;
        }
    }

    public static string Ard_ne
    {
        get
        {
            return ard_ne;
        }
    }

    public static string Ard_lise
    {
        get
        {
            return ard_lise;
        }
    }

    public static string Ard_me
    {
        get
        {
            return ard_me;
        }
    }

    public static string Ard_wind
    {
        get
        {
            return ard_wind;
        }
    }

    public static string Ard_sh
    {
        get
        {
            return ard_sh;
        }
    }

    public static string Ard_to
    {
        get
        {
            return ard_to;
        }
    }

    public static string Ard_red
    {
        get
        {
            return ard_red;
        }
    }

    public static string Bn_la
    {
        get
        {
            return bn_la;
        }
    }

    public static string Bn_val
    {
        get
        {
            return bn_val;
        }
    }

    public static string Bn_be
    {
        get
        {
            return bn_be;
        }
    }

    public static string Bn_bc
    {
        get
        {
            return bn_bc;
        }
    }

    public static string Bn_cro
    {
        get
        {
            return bn_cro;
        }
    }

    public static string Bn_par
    {
        get
        {
            return bn_par;
        }
    }

    public static string Bn_pes
    {
        get
        {
            return bn_pes;
        }
    }

    public static string Sh_li
    {
        get
        {
            return sh_li;
        }
    }

    public static string Sh_mu
    {
        get
        {
            return sh_mu;
        }
    }

    public static string Sh_su
    {
        get
        {
            return sh_su;
        }
    }

    public static string Sh_freeze
    {
        get
        {
            return sh_freeze;
        }
    }

    public static string Sh_ice
    {
        get
        {
            return sh_ice;
        }
    }

    public static string Sh_kal
    {
        get
        {
            return sh_kal;
        }
    }

    public static MC_TableBuilder Instance
    {
        get
        {
            return instance;
        }
    }

    private static MC_TableBuilder instance;

    //map name

    //아르테미스
    private const string ar_leon = "ar_leon";
    private const string ar_log = "ar_log";
    private const string ar_ange = "ar_ange";
    private const string ar_guk = "ar_guk";

    //유디아
    private const string udia_sa = "udia_sa";
    private const string udia_oz = "udia_oz";

    //루테란서부
    private const string lw_guk = "lw_guk";
    private const string lw_lake = "lw_lake";
    private const string lw_mad = "lw_mad";
    private const string lw_bil = "lw_bil";
    private const string lw_zago = "lw_zago";

    //루테란동부
    private const string le_gal = "le_gal";
    private const string le_dio = "le_dio";
    private const string le_lia = "le_lia";
    private const string le_lu = "le_lu";
    private const string le_bae = "le_bae";
    private const string le_bo = "le_bo";
    private const string le_cro = "le_cro";
    private const string le_hae = "le_hae";
    private const string le_hk = "le_hk";

    //애니츠
    private const string an_mirror = "an_mirror";
    private const string an_del = "an_del";
    private const string an_dung = "an_dung";
    private const string an_sori = "an_sori";
    private const string an_hang = "an_hang";
    private const string an_hwang = "an_hwang";

    //아르데타인
    private const string ard_gal = "ard_gal";
    private const string ard_ne = "ard_ne";
    private const string ard_lise = "ard_lse";
    private const string ard_me = "ard_me";
    private const string ard_wind = "ard_wind";
    private const string ard_sh = "ard_sh";
    private const string ard_to = "ard_to";
    private const string ard_red = "ard_red";

    //베른북부
    private const string bn_la = "bn_la";
    private const string bn_val = "bn_val";
    private const string bn_be = "bn_be";
    private const string bn_bc = "bn_bc";
    private const string bn_cro = "bn_cro";
    private const string bn_par = "bn_par";
    private const string bn_pes = "bn_pes";

    //슈샤이어
    private const string sh_li = "sh_li";
    private const string sh_mu = "sh_mu";
    private const string sh_su = "sh_su";
    private const string sh_freeze = "sh_freeze";
    private const string sh_ice = "sh_ice";
    private const string sh_kal = "sh_kal";

    private void Awake()
    {
        instance = this;

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
