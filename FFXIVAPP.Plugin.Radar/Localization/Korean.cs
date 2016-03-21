// FFXIVAPP.Plugin.Radar ~ Korean.cs
// 
// Copyright © 2007 - 2016 Ryan Wilson - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using System.Windows;

namespace FFXIVAPP.Plugin.Radar.Localization
{
    public abstract class Korean
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        private static readonly List<string> RankB = new List<string>
        {
            "잿빛낯 알빈",
            "바바스텔",
            "피빛 메리",
            "검은 투구게",
            "불멸의 중사 페란드",
            "개틀링",
            "대왕거머리",
            "제왕잠자리",
            "미라드로시",
            "나울",
            "아브젱",
            "페크다",
            "하수도 시럽",
            "스콕스프루",
            "따끔한 소피",
            "부오코",
            "흰재간둥이",
            // Heavensward Rank B - Not Yet
            "Alteci",
            "Gigantopithecus",
            "Gnath Cometdrone",
            "Kreutzet",
            "Lycidas",
            "Omni",
            "Pterygotus",
            "Sanu Vali of Dancing Wings",
            "Scitalis",
            "Squonk",
            "The Scarecrow",
            "Thextera"
        };

        private static readonly List<string> RankA = new List<string>
        {
            "마도 지옥손아귀",
            "웅크테히",
            "못생긴 보가쟈",
            "콘누",
            "마베리",
            "난",
            "포르네우스",
            "녹아내리는 젤리",
            "기르타브",
            "게데",
            "머라쿠",
            "사보텐더 무희",
            "마헤스",
            "마지막 투혼",
            "자니고",
            "알렉트리온",
            "쿠레아",
            // Heavensward Rank A - Not Yet
            "Mirka",
            "Lyuba",
            "Bune",
            "Agathos",
            "Pylraster",
            "Lord of the Wyverns",
            "Slipkinx Steeljoints",
            "Stolas",
            "Campacti",
            "Stench Blossom",
            "Enkelados",
            "Sisiutl"
        };

        private static readonly List<string> RankS = new List<string>
        {
            "갈록",
            "개굴개로스",
            "크로크 미테느",
            "체르노보그",
            "난디",
            "보나콘",
            "레드로네트",
            "울가루",
            "천갈래덩굴 세다",
            "정신지배자",
            "사파트",
            "브론테스",
            "발라우르",
            "미뇨카온",
            "느뉴느위",
            "조나 시커",
            "아그리파",
            // Heavensward Rank S - Not Yet
            "Kaiser Behemoth",
            "Gandarewa",
            "Senmurv",
            "The Pale Rider",
            "Leucrotta",
            "Bird of Paradise"
        };

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("radar_", "*PH*");
            Dictionary.Add("radar_RadarWidgetHeader", "Radar Widget");
            Dictionary.Add("radar_OpenNowButtonText", "Open Now");
            Dictionary.Add("radar_ResetPositionButtonText", "Reset Settings");
            Dictionary.Add("radar_EnableClickThroughHeader", "Enable Click-Through On Radar");
            Dictionary.Add("radar_WidgetOpacityHeader", "Widget Opacity");
            Dictionary.Add("radar_ShowTitlesOnRadarHeader", "Show Titles On Radar");
            Dictionary.Add("radar_UIScaleHeader", "UI Scale");
            Dictionary.Add("radar_RadarSettingsTabHeader", "Radar Settings");
            Dictionary.Add("radar_PCShowHeader", "PC Show");
            Dictionary.Add("radar_PCShowNameHeader", "PC Show Name");
            Dictionary.Add("radar_PCShowHPPercentHeader", "PC Show HP Percent");
            Dictionary.Add("radar_PCShowJobHeader", "PC Show Job");
            Dictionary.Add("radar_PCShowDistanceHeader", "PC Show Distance");
            Dictionary.Add("radar_NPCShowHeader", "NPC Show");
            Dictionary.Add("radar_NPCShowNameHeader", "NPC Show Name");
            Dictionary.Add("radar_NPCShowHPPercentHeader", "NPC Show HP Percent");
            Dictionary.Add("radar_NPCShowDistanceHeader", "NPC Show Distance");
            Dictionary.Add("radar_MonsterShowHeader", "Monster Show");
            Dictionary.Add("radar_MonsterShowNameHeader", "Monster Show Name");
            Dictionary.Add("radar_MonsterShowHPPercentHeader", "Monster Show HP Percent");
            Dictionary.Add("radar_MonsterShowDistanceHeader", "Monster Show Distance");
            Dictionary.Add("radar_GatheringShowHeader", "Gathering Show");
            Dictionary.Add("radar_GatheringShowNameHeader", "Gathering Show Name");
            Dictionary.Add("radar_GatheringShowHPPercentHeader", "Gathering Show HP Percent");
            Dictionary.Add("radar_GatheringShowDistanceHeader", "Gathering Show Distance");
            Dictionary.Add("radar_OtherShowHeader", "Other Show");
            Dictionary.Add("radar_OtherShowNameHeader", "Other Show Name");
            Dictionary.Add("radar_OtherShowHPPercentHeader", "Other Show HP Percent");
            Dictionary.Add("radar_OtherShowDistanceHeader", "Other Show Distance");
            Dictionary.Add("radar_GitHubButtonText", "Open Project Source (GitHub)");
            Dictionary.Add("radar_PCFontSizeHeader", "PC Font Size");
            Dictionary.Add("radar_PCFontColorHeader", "PC Font Color");
            Dictionary.Add("radar_NPCFontSizeHeader", "NPC Font Size");
            Dictionary.Add("radar_NPCFontColorHeader", "NPC Font Color");
            Dictionary.Add("radar_MonsterFontSizeHeader", "Monster Font Size");
            Dictionary.Add("radar_MonsterFontColorHeader", "Monster Font Color");
            Dictionary.Add("radar_GatheringFontSizeHeader", "Gathering Font Size");
            Dictionary.Add("radar_GatheringFontColorHeader", "Gathering Font Color");
            Dictionary.Add("radar_OtherFontSizeHeader", "Other Font Size");
            Dictionary.Add("radar_OtherFontColorHeader", "Other Font Color");

            Dictionary.Add("radar_MonsterShowRankColorHeader", "Show Ranked Monsters In Color");
            Dictionary.Add("radar_MonsterShowBRankHeader", "Monster Show (B Rank)");
            Dictionary.Add("radar_MonsterShowARankHeader", "Monster Show (A Rank)");
            Dictionary.Add("radar_MonsterShowSRankHeader", "Monster Show (S Rank)");
            Dictionary.Add("radar_MonsterFontColorBRankHeader", "Monster Font Color (B Rank)");
            Dictionary.Add("radar_MonsterFontColorARankHeader", "Monster Font Color (A Rank)");
            Dictionary.Add("radar_MonsterFontColorSRankHeader", "Monster Font Color (S Rank)");
            Dictionary.Add("radar_FilterOptionsHeader", "Filter Options");
            Dictionary.Add("radar_KeyLabel", "Key:");
            Dictionary.Add("radar_LevelLabel", "Level:");
            Dictionary.Add("radar_TypeLabel", "Type:");
            Dictionary.Add("radar_DeleteFilterButton", " - ");
            Dictionary.Add("radar_AddorUpdateFilterButton", "Add Or Update Filter");
            Dictionary.Add("radar_SettingsRadarHeader", "Settings:Radar");
            Dictionary.Add("radar_CompasModeLabel", "Compass Mode");
            Dictionary.Add("radar_FilterRadarItemsLabel", "Filter Radar Items");
            Dictionary.Add("radar_RadarUIScaleLabel", "UI Scale");
            Dictionary.Add("radar_SettingsRadarPCHeader", "Settings:Radar:PC");
            Dictionary.Add("radar_SettingsRadarNPCHeader", "Settings:Radar:NPC");
            Dictionary.Add("radar_SettingsRadarMonsterHeader", "Settings:Radar:Monster");
            Dictionary.Add("radar_SettingsRadarGatheringHeader", "Settings:Radar:Gathering");
            Dictionary.Add("radar_SettingsRadarOtherHeader", "Settings:Radar:Other");
            Dictionary.Add("radar_RadarTitleBar", "[RADAR]");

            return Dictionary;
        }

        public static List<string> GetRankedMonster(string name)
        {
            List<string> monsters;
            switch (name)
            {
                case "B":
                    monsters = RankB;
                    break;
                case "A":
                    monsters = RankA;
                    break;
                case "S":
                    monsters = RankS;
                    break;
                default:
                    monsters = new List<string>();
                    monsters.AddRange(RankB);
                    monsters.AddRange(RankA);
                    monsters.AddRange(RankS);
                    break;
            }

            return monsters;
        }
    }
}
