﻿using System.Collections.Generic;

namespace PoeTradeSearch
{
    internal static class ResStr
    {
        internal static string PoeClass = "POEWindowClass";
        internal static string PoeCaption = "Path of Exile";

        internal static string[] TradeUrl = { "https://poe.game.daum.net/trade/search/", "https://www.pathofexile.com/trade/search/" };
        internal static string[] TradeApi = { "https://poe.game.daum.net/api/trade/search/", "https://www.pathofexile.com/api/trade/search/" };
        internal static string[] FetchApi = { "https://poe.game.daum.net/api/trade/fetch/", "https://www.pathofexile.com/api/trade/fetch/" };
        internal static string[] ExchangeApi = { "https://poe.game.daum.net/api/trade/exchange/", "https://www.pathofexile.com/api/trade/exchange/" };

        internal static byte ServerLang = 0;
        internal static string ServerType = "";

        internal const string All = "모두";
        internal const string Max = "최대";

        internal const string Rarity = "아이템 희귀도";
        internal const string Unique = "고유";
        internal const string Rare = "희귀";
        internal const string Magic = "마법";
        internal const string Normal = "일반";

        internal const string Prophecy = "예언";
        internal const string Currency = "화폐";
        internal const string DivinationCard = "점술 카드";
        internal const string Gem = "젬";

        internal const string Higher = "상급";
        internal const string formed = "형성된";

        internal const string Lv = "레벨";
        internal const string ItemLv = "아이템 레벨";
        internal const string CharmLv = "부적 등급";
        internal const string MaTier = "지도 등급";
        internal const string Quality = "퀄리티";
        internal const string Socket = "홈";

        internal const string Corrupt = "타락";
        internal const string Vaal = "바알";
        internal const string Unidentify = "미확인";
        internal const string Blight = "역병 걸린 지도";
        internal const string Blighted = "역병 걸린";

        internal const string Shaper = "쉐이퍼 아이템";
        internal const string Elder = "엘더 아이템";
        internal const string Crusader = "십자군 아이템";
        internal const string Redeemer = "대속자 아이템";
        internal const string Hunter = "사냥꾼 아이템";
        internal const string Warlord = "전쟁군주 아이템";

        internal const string Synthesis = "결합된 아이템";
        internal const string Synthesised = "결합된";
        internal const string Captured = "포획한 야수";

        internal const string ChkProphecy = "우클릭으로 이 예언을 캐릭터에 추가하십시오.";
        internal const string ChkMapFragment = "템플러의 실험실이나 전용 지도 장치에서";
        internal const string ChkMetEntrails = "테인의 연구실에서 이 아이템을 다른 샘플과";        
        internal const string ChkFlask = "현재 용량";
        internal const string ChkBeast1 = "종";
        internal const string ChkBeast2 = "속";

        internal const string SClickSplitItem = "Shift + 클릭으로 아이템 나누기";    

        internal const string Pseudo = "유사";
        internal const string Explicit = "일반";
        internal const string Fractured = "분열";
        internal const string Crafted = "제작";
        internal const string Implicit = "고정";
        internal const string Enchant = "인챈";
        internal const string Veiled = "장막";
        internal const string Monster = "야수";
        internal const string Delve = "탐광";
        internal const string Local = "특정";

        internal const string PhysicalDamage = "물리 피해";
        internal const string ElementalDamage = "원소 피해";
        internal const string ChaosDamage = "카오스 피해";
        internal const string AttacksPerSecond = "초당 공격 횟수";
        internal const string AttackSpeedIncr = "공격 속도 #% 증가";
        internal const string PhysicalDamageIncr = "물리 피해 #% 증가";
        internal const string TotalResistance = "총 저항 +#%";

        internal static Dictionary<string, string> lFilterTypeName = new Dictionary<string, string>()
        {
            { "pseudo", Pseudo}, { "explicit", Explicit}, { "fractured", Fractured}, { "crafted", Crafted}, { "implicit", Implicit},
            { "enchant", Enchant}, { "veiled", Veiled}, { "monster", Monster}, { "delve", Delve}
        };

        internal static Dictionary<string, bool> lDefaultPosition = new Dictionary<string, bool>()
        {
            { "stat_3441651621", true}, { "stat_3853018505", true}, { "stat_969865219", true},  { "stat_4176970656", true},
            { "stat_3277537093", true}, { "stat_3691641145", true}, { "stat_3557561376", true}, { "stat_705686721", true},
            { "stat_2156764291", true}, { "stat_3743301799", true}, { "stat_1187803783", true}, { "stat_3612407781", true},
            { "stat_496011033", true},  { "stat_1625103793", true}, { "stat_308618188", true},  { "stat_2590715472", true},
            { "stat_1964333391", true}, { "stat_614758785", true},  { "stat_2440172920", true}, { "stat_321765853", true},
            { "stat_465051235", true},  { "stat_261654754", true},  { "stat_3522931817", true}, { "stat_1443108510", true}, { "stat_2477636501", true}
        };
        
        internal static Dictionary<string, byte> lParticular = new Dictionary<string, byte>()
        {
            { "stat_210067635", 1}, { "stat_691932474", 1}, { "stat_3885634897", 1}, { "stat_2223678961", 1},
            { "stat_1940865751", 1}, { "stat_3336890334", 1}, { "stat_709508406", 1}, { "stat_1037193709", 1},
            { "stat_4052037485", 2}, { "stat_4015621042", 2}, { "stat_124859000", 2}, { "stat_53045048", 2}, 
            { "stat_1062208444", 2}, { "stat_3484657501", 2}, { "stat_3321629045", 2}, { "stat_1999113824", 2}, { "stat_2451402625", 2}
        };
        
        internal static Dictionary<string, bool> lResistance = new Dictionary<string, bool>()
        {
            { "stat_4220027924", true }, { "stat_3372524247", true }, { "stat_1671376347", true }, { "stat_2923486259", true },
            { "stat_2915988346", true }, { "stat_4277795662", true }, { "stat_3441501978", true }
        };

        internal static Dictionary<string, string> lPseudo = new Dictionary<string, string>()
        {
            { "stat_4220027924", "pseudo_total_cold_resistance" }, { "stat_3372524247", "pseudo_total_fire_resistance" }, { "stat_1671376347", "pseudo_total_lightning_resistance" }, { "stat_2923486259", "pseudo_total_chaos_resistance" },
            { "stat_3299347043", "pseudo_total_life" }, { "stat_1050105434", "pseudo_total_mana" }, { "stat_3489782002", "pseudo_total_energy_shield" }, { "stat_2482852589", "pseudo_increased_energy_shield" },
            { "stat_4080418644", "pseudo_total_strength" }, { "stat_3261801346", "pseudo_total_dexterity" }, { "stat_328541901", "pseudo_total_intelligence" },
            { "stat_681332047", "pseudo_total_attack_speed" }, { "stat_2891184298", "pseudo_total_cast_speed" }, { "stat_2250533757", "pseudo_increased_movement_speed" },
            { "stat_587431675", "pseudo_global_critical_strike_chance" }, { "stat_3556824919", "pseudo_global_critical_strike_multiplier" }, { "stat_737908626", "pseudo_critical_strike_chance_for_spells" },
            { "stat_1509134228", "pseudo_increased_physical_damage" }, { "stat_2974417149", "pseudo_increased_spell_damage" }, { "stat_3141070085", "pseudo_increased_elemental_damage" },
            { "stat_2231156303", "pseudo_increased_lightning_damage" }, { "stat_3291658075", "pseudo_increased_cold_damage" }, { "stat_3962278098", "pseudo_increased_fire_damage" },
            { "stat_4208907162", "pseudo_increased_lightning_damage_with_attack_skills" }, { "stat_860668586", "pseudo_increased_cold_damage_with_attack_skills" }, { "stat_2468413380", "pseudo_increased_fire_damage_with_attack_skills" }, { "stat_387439868", "pseudo_increased_elemental_damage_with_attack_skills" },
            { "stat_960081730", "pseudo_adds_physical_damage" }, { "stat_1334060246", "pseudo_adds_lightning_damage" }, { "stat_2387423236", "pseudo_adds_cold_damage" }, { "stat_321077055", "pseudo_adds_fire_damage" }, { "stat_3531280422", "pseudo_adds_chaos_damage" },
            { "stat_3032590688", "pseudo_adds_physical_damage_to_attacks" }, { "stat_1754445556", "pseudo_adds_lightning_damage_to_attacks" }, { "stat_4067062424", "pseudo_adds_cold_damage_to_attacks" }, { "stat_1573130764", "pseudo_adds_fire_damage_to_attacks" }, { "stat_674553446", "pseudo_adds_chaos_damage_to_attacks" },
            { "stat_2435536961", "pseudo_adds_physical_damage_to_spells" }, { "stat_2831165374", "pseudo_adds_lightning_damage_to_spells" }, { "stat_2469416729", "pseudo_adds_cold_damage_to_spells" }, { "stat_1133016593", "pseudo_adds_fire_damage_to_spells" }, { "stat_2300399854", "pseudo_adds_chaos_damage_to_spells" },
            { "stat_3325883026", "pseudo_total_life_regen" }, { "stat_836936635", "pseudo_percent_life_regen" }, { "stat_789117908", "pseudo_increased_mana_regen" }
        };

        internal static Dictionary<string, string> lInherit = new Dictionary<string, string>()
        {
            { "Weapons","weapon" }, { "Quivers","armour.quiver" }, { "Armours","armour" },
            { "Amulets","accessory.amulet" }, { "Rings","accessory.ring" }, { "Belts","accessory.belt" }, /* accessory */
            { "Jewels","jewel" }, { "Flasks","flask" }, { "DivinationCards","card" }, { "Prophecies","prophecy" }, { "Gems","gem" },
            { "Currency","currency" },  { "Maps","map" }, { "MapFragments","map" }
        };

        internal static Dictionary<string, string> lRarity = new Dictionary<string, string>()
        {
            { Unique, "unique"}, { Rare, "rare"}, { Magic, "magic"}, { Normal, "normal"}
        };

        internal static Dictionary<string, string> lExchangeCurrency = new Dictionary<string, string>()
        {
            { "고대의 오브", "ancient-orb"}, { "기술자의 오브", "engineers-orb"}, { "기회의 오브", "chance"}, { "바알 오브", "vaal"}, { "변화의 오브", "alt"},
            { "선구자의 오브", "harbingers-orb"}, { "소멸의 오브", "orb-of-annulment"}, { "속박의 오브", "orb-of-binding"}, { "신성한 오브", "divine"}, { "색채의 오브", "chrom"},
            { "연결의 오브", "fuse"}, { "연금술의 오브", "alch"}, { "영원의 오브", "ete"}, { "엑잘티드 오브", "exa"}, { "정제의 오브", "scour"},
            { "쥬얼러 오브", "jew"}, { "지평의 오브", "orb-of-horizons"}, { "진화의 오브", "tra"},  { "제왕의 오브", "regal"},  { "축복의 오브", "blessed"},
            { "카오스 오브", "chaos"}, { "칼란드라의 거울", "mir"}, { "확장의 오브", "aug"}, { "후회의 오브", "regret"}, { "세공사의 프리즘", "gcp"}, 
            { "유리직공의 방울", "ba"}, { "실버 코인", "silver"}, { "카드 묶음", "stacked-deck"}, { "감정 주문서", "wis"}, { "포탈 주문서", "port"}, { "지도제작자의 끌", "chisel"},
            { "단순한 육분의", "apprentice-sextant"}, { "최종형 육분의", "journeyman-sextant"}, { "각성한 육분의", "master-sextant"},
            { "공허의 화석", "hollow-fossil"}, { "그을린 화석", "scorched-fossil"}, { "금속성 화석", "metallic-fossil"}, { "도금된 화석", "gilded-fossil"}, { "뒤덮인 화석", "encrusted-fossil"},
            { "부식된 화석", "corroded-fossil"}, { "분광 화석", "prismatic-fossil"}, { "분열된 화석", "fractured-fossil"},{ "뾰족한 화석", "jagged-fossil"}, { "빛나는 화석", "lucent-fossil"},
            { "상형 문자 화석", "glyphic-fossil"}, { "속박의 화석", "bound-fossil"}, { "얽혀든 화석", "tangled-fossil"},   { "연마한 화석", "faceted-fossil"}, { "온전한 화석", "pristine-fossil"},
            { "완벽한 화석", "perfect-fossil"},  { "인챈트된 화석", "enchanted-fossil"}, { "에테르 화석", "aetheric-fossil"}, { "전율의 화석", "shuddering-fossil"}, { "조밀한 화석", "dense-fossil"},
            { "차디찬 화석", "frigid-fossil"}, { "축성된 화석", "sanctified-fossil"}, { "톱니 화석", "serrated-fossil"}, { "특이한 화석", "aberrant-fossil"},{ "피얼룩 화석", "bloodstained-fossil"},    
            { "울네톨의 파편", "splinter-uul"}, { "에쉬의 파편", "splinter-esh"}, { "조프의 파편", "splinter-xoph"}, { "차율라의 파편", "splinter-chayula"}, { "툴의 파편", "splinter-tul"},
            { "울네톨의 축복", "blessing-uul-netol"}, { "에쉬의 축복", "blessing-esh"}, { "조프의 축복", "blessing-xoph"}, { "차율라의 축복", "blessing-chayula"}, { "툴의 축복", "blessing-tul"},
            { "무궁한 바알 파편", "timeless-vaal-splinter"}, { "무궁한 영원한 제국 파편", "timeless-eternal-empire-splinter"}, { "무궁한 카루이 파편", "timeless-karui-splinter"}, { "무궁한 템플러 파편", "timeless-templar-splinter"}, { "무궁한 마라케스 파편", "timeless-maraketh-splinter"},
            { "무궁한 바알 상징", "timeless-vaal-emblem"}, { "무궁한 영원한 제국 상징", "timeless-eternal-emblem"}, { "무궁한 카루이 상징", "timeless-karui-emblem"}, { "무궁한 템플러 상징", "timeless-templar-emblem"}, { "무궁한 마라케스 상징", "timeless-maraketh-emblem"},
            { "대장장이의 숫돌", "whe"}, { "방어구 장인의 고철", "scr"}, { "소멸의 파편", "annulment-shard"}, { "거울 파편", "mirror-shard"}, { "엑잘티드 파편", "exalted-shard"},
            { "속박의 파편", "binding-shard"},{ "지평의 파편", "horizon-shard"}, { "선구자의 파편", "harbingers-shard"}, { "기술자의 파편", "engineers-shard"}, { "고대의 파편", "ancient-shard"},
            { "카오스 파편", "chaos-shard"},{ "제왕의 파편", "regal-shard"}, { "페란두스 코인", "p"}
        };
    }
}