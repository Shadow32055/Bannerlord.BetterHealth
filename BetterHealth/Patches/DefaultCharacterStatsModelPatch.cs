using BetterCore.Utils;
using HarmonyLib;
using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BetterHealth.Patches
{
    [HarmonyPatch]
    internal class DefaultCharacterStatsModelPatch {

        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultCharacterStatsModel), nameof(DefaultCharacterStatsModel.MaxHitpoints))]
        public static void MaxHitpointsPrefix(ref ExplainedNumber __result, ref DefaultCharacterStatsModel __instance, CharacterObject character, bool includeDescriptions = false) {
            try {
                int tier = __instance.GetTier(character);
                int baseHealth = 100;

                switch (tier) {
                    case 0:

                        if (character.IsPlayerCharacter) {
                            baseHealth = BetterHealth.Settings.PlayerBaseHealth; 
                        } else {
                            baseHealth = BetterHealth.Settings.HeroBaseHealth;
                        }
                        break;
                    case 1:
                        baseHealth = BetterHealth.Settings.TroopBaseHealthT1;
                        break;
                    case 2:
                        baseHealth = BetterHealth.Settings.TroopBaseHealthT2;
                        break;
                    case 3:
                        baseHealth = BetterHealth.Settings.TroopBaseHealthT3;
                        break;
                    case 4:
                        baseHealth = BetterHealth.Settings.TroopBaseHealthT4;
                        break;
                    case 5:
                        baseHealth = BetterHealth.Settings.TroopBaseHealthT5;
                        break;
                    case 6:
                        baseHealth = BetterHealth.Settings.TroopBaseHealthT6;
                        break;
                    case 7:
                        baseHealth = BetterHealth.Settings.TroopBaseHealthT7;
                        break;
                }

                ExplainedNumber result = new ExplainedNumber(baseHealth, includeDescriptions, null);

                // TW Skill Bonues
                if (character.IsHero && character.HeroObject.PartyBelongedTo != null && character.HeroObject.PartyBelongedTo.LeaderHero != character.HeroObject && character.HeroObject.PartyBelongedTo.HasPerk(DefaultPerks.Medicine.FortitudeTonic, false)) {
                    result.Add(DefaultPerks.Medicine.FortitudeTonic.PrimaryBonus, DefaultPerks.Medicine.FortitudeTonic.Name, null);
                }
                if (character.GetPerkValue(DefaultPerks.Athletics.MightyBlow)) {
                    int num = character.GetSkillValue(DefaultSkills.Athletics) - Campaign.Current.Models.CharacterDevelopmentModel.MaxSkillRequiredForEpicPerkBonus;
                    result.Add((float)num, DefaultPerks.Athletics.MightyBlow.Name, null);
                }

                int totalVigorSkills = 0;
                int totalControlSkills = 0;
                int totalEnduranceSkills = 0;

                float vigorBonusHealth = 0;
                float controlBonusHealth = 0;
                float enduranceBonusHealth = 0;



                if (character.IsPlayerCharacter) {

                    if (BetterHealth.Settings.PlayerVigorSkills) {
                        vigorBonusHealth = BetterHealth.Settings.PlayerVigorHealthValue;
                        totalVigorSkills = GetVigorSkillTotal(character, BetterHealth.Settings.PlayerVigorOneHandedSkill, BetterHealth.Settings.PlayerVigorTwoHandedSkill, BetterHealth.Settings.PlayerVigorPolearmSkill);
                    }

                    if (BetterHealth.Settings.PlayerControlSkills) {
                        controlBonusHealth = BetterHealth.Settings.PlayerControlHealthValue;
                        totalControlSkills = GetVigorSkillTotal(character, BetterHealth.Settings.PlayerControlBowSkill, BetterHealth.Settings.PlayerControlCrossbowSkill, BetterHealth.Settings.PlayerControlThrowingSkill);
                    }

                    if (BetterHealth.Settings.PlayerEnduranceSkills) {
                        enduranceBonusHealth = BetterHealth.Settings.PlayerEnduranceHealthValue;
                        totalEnduranceSkills = GetVigorSkillTotal(character, BetterHealth.Settings.PlayerEnduranceRidingSkill, BetterHealth.Settings.PlayerEnduranceAthleticsSkill, BetterHealth.Settings.PlayerEnduranceSmithingSkill);
                    }



                    float playerBonus = character.Level * BetterHealth.Settings.PlayerFlatAmount;
                    if (playerBonus > 0) {
                        result.Add(playerBonus, new TextObject(Strings.FlatText, null));
                    }

                    //playerBonus = (float)(character.Level * BetterHealth.Settings.PlayerPercent);
                    playerBonus = (BetterHealth.Settings.PlayerBaseHealth * (float)Math.Pow((1+ BetterHealth.Settings.PlayerPercent), character.Level)) - BetterHealth.Settings.PlayerBaseHealth;
                    if (playerBonus > 0) {
                        result.Add(playerBonus, new TextObject(Strings.PercentText, null));
                    }

                } else if (character.IsHero) {

                    if (BetterHealth.Settings.HeroVigorSkills) {
                        vigorBonusHealth = BetterHealth.Settings.HeroVigorHealthValue;
                        totalVigorSkills = GetVigorSkillTotal(character, BetterHealth.Settings.HeroVigorOneHandedSkill, BetterHealth.Settings.HeroVigorTwoHandedSkill, BetterHealth.Settings.HeroVigorPolearmSkill);
                    }

                    if (BetterHealth.Settings.HeroControlSkills) {
                        controlBonusHealth = BetterHealth.Settings.HeroControlHealthValue;
                        totalControlSkills = GetVigorSkillTotal(character, BetterHealth.Settings.HeroControlBowSkill, BetterHealth.Settings.HeroControlCrossbowSkill, BetterHealth.Settings.HeroControlThrowingSkill);
                    }

                    if (BetterHealth.Settings.HeroEnduranceSkills) {
                        enduranceBonusHealth = BetterHealth.Settings.HeroEnduranceHealthValue;
                        totalEnduranceSkills = GetVigorSkillTotal(character, BetterHealth.Settings.HeroEnduranceRidingSkill, BetterHealth.Settings.HeroEnduranceAthleticsSkill, BetterHealth.Settings.HeroEnduranceSmithingSkill);
                    }


                    float heroBonus = character.Level * BetterHealth.Settings.HeroFlatAmount;
                    if (heroBonus > 0) {
                        result.Add(heroBonus, new TextObject(Strings.FlatText, null));
                    }

                    heroBonus = (BetterHealth.Settings.HeroBaseHealth * (float)Math.Pow((1 + BetterHealth.Settings.HeroPercent), character.Level)) - BetterHealth.Settings.HeroBaseHealth;
                    if (heroBonus > 0) {
                        result.Add(heroBonus, new TextObject(Strings.PercentText, null));
                    }

                } else {
                    if (BetterHealth.Settings.TroopVigorSkills) {
                        vigorBonusHealth = BetterHealth.Settings.TroopVigorHealthValue;
                        totalVigorSkills = GetVigorSkillTotal(character, BetterHealth.Settings.TroopVigorOneHandedSkill, BetterHealth.Settings.TroopVigorTwoHandedSkill, BetterHealth.Settings.TroopVigorPolearmSkill);
                    }

                    if (BetterHealth.Settings.TroopControlSkills) {
                        controlBonusHealth = BetterHealth.Settings.TroopControlHealthValue;
                        totalControlSkills = GetVigorSkillTotal(character, BetterHealth.Settings.TroopControlBowSkill, BetterHealth.Settings.TroopControlCrossbowSkill, BetterHealth.Settings.TroopControlThrowingSkill);
                    }

                    if (BetterHealth.Settings.TroopEnduranceSkills) {
                        enduranceBonusHealth = BetterHealth.Settings.TroopEnduranceHealthValue;
                        totalEnduranceSkills = GetVigorSkillTotal(character, BetterHealth.Settings.TroopEnduranceRidingSkill, BetterHealth.Settings.TroopEnduranceAthleticsSkill, BetterHealth.Settings.TroopEnduranceSmithingSkill);
                    }
                }


                float vigorBonus = totalVigorSkills * vigorBonusHealth;
                float controlBonus = totalControlSkills * controlBonusHealth;
                float enduranceBonus = totalEnduranceSkills * enduranceBonusHealth;

                if (vigorBonus > 0) {
                    result.Add((float)Math.Round(vigorBonus), new TextObject(Strings.VigorSkillText));
                }

                if (controlBonus > 0) {
                    result.Add((float)Math.Round(totalControlSkills * controlBonusHealth), new TextObject(Strings.ControlSkillText));
                }

                if (enduranceBonus > 0) {
                    result.Add((float)Math.Round(totalEnduranceSkills * enduranceBonusHealth), new TextObject(Strings.EnduranceSkillText));
                }

                __result = result;
            } catch (Exception e) {
                NotifyHelper.WriteError(BetterHealth.ModName, "DefaultCharacterStatsModel.MaxHitpoints threw exception: " + e);
            }
        }

        private static int GetVigorSkillTotal(CharacterObject ch, bool one, bool two, bool three) {
            int count = 0;

            if (one) {
                count += ch.GetSkillValue(DefaultSkills.OneHanded);
            }

            if (two) {
                count += ch.GetSkillValue(DefaultSkills.TwoHanded);
            }

            if (three) {
                count += ch.GetSkillValue(DefaultSkills.Polearm);
            }

            return count;
        }

        private static int GetControlSkillTotal(CharacterObject ch, bool one, bool two, bool three) {
            int count = 0;

            if (one) {
                count += ch.GetSkillValue(DefaultSkills.Bow);
            }

            if (two) {
                count += ch.GetSkillValue(DefaultSkills.Crossbow);
            }

            if (three) {
                count += ch.GetSkillValue(DefaultSkills.Throwing);
            }

            return count;
        }

        private static int GetEnduranceSkillTotal(CharacterObject ch, bool one, bool two, bool three) {
            int count = 0;

            if (one) {
                count += ch.GetSkillValue(DefaultSkills.Riding);
            }

            if (two) {
                count += ch.GetSkillValue(DefaultSkills.Athletics);
            }

            if (three) {
                count += ch.GetSkillValue(DefaultSkills.Crafting);
            }

            return count;
        }
    }
}