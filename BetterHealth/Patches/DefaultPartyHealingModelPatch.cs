using BetterHealth.Localization;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Localization;

namespace BetterHealth.Patches {
    internal class DefaultPartyHealingModelPatch {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultPartyHealingModel), "GetDailyHealingForRegulars")]
        public static void GetDailyHealingForRegulars(ref ExplainedNumber __result, MobileParty party, bool includeDescriptions = false) {

            __result.AddFactor(BetterHealth.Settings.CampaignHealthRegenMultiplier, new TextObject(RefValues.RegenText, null));

        }
    }
}
