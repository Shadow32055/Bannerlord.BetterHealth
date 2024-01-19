using BetterCore.Utils;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Localization;

namespace BetterHealth.Patches {
    [HarmonyPatch]
    internal class DefaultPartyHealingModelPatch {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultPartyHealingModel), nameof(DefaultPartyHealingModel.GetDailyHealingForRegulars))]
        public static void GetDailyHealingForRegulars(ref ExplainedNumber __result, MobileParty party, bool includeDescriptions = false) {

            __result.Add(BetterHealth.Settings.CampaignHealthRegen, new TextObject(Strings.RegenText, null));

        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultPartyHealingModel), nameof(DefaultPartyHealingModel.GetDailyHealingHpForHeroes))]
        public static void GetDailyHealingHpForHeroes(ref ExplainedNumber __result, MobileParty party, bool includeDescriptions = false) {

            __result.Add(BetterHealth.Settings.CampaignHealthRegen, new TextObject(Strings.RegenText, null));

        }


    }
}
