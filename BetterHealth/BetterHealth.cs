using BetterCore.Utils;
using BetterHealth.Behaviors;
using BetterHealth.Settings;
using HarmonyLib;
using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BetterHealth {
    public class BetterHealth : MBSubModuleBase {

        public static MCMSettings Settings { get; private set; }
        public static HealthOverflow HealthOverflow { get; private set; }
        public static string ModName { get; private set; } = "BetterHealth";

        private bool isInitialized = false;
        private bool isLoaded = false;

        //FIRST
        protected override void OnSubModuleLoad() {
            try {
                base.OnSubModuleLoad();

               if (isInitialized)
                    return;

                Harmony h = new("Bannerlord.Shadow." + ModName);

                h.PatchAll();

                isInitialized = true;
            } catch (Exception e) {
                NotifyHelper.ReportError(ModName, "OnSubModuleLoad threw exception " + e);
            }
        }

        //SECOND
        protected override void OnBeforeInitialModuleScreenSetAsRoot() {
            try {
                base.OnBeforeInitialModuleScreenSetAsRoot();

                if (isLoaded)
                    return;

                ModName = base.GetType().Assembly.GetName().Name;

                Settings = MCMSettings.Instance ?? throw new NullReferenceException("Settings are null");

                NotifyHelper.ChatMessage(ModName + " Loaded.", MsgType.Good);
                Integrations.BetterHealthLoaded = true;

                isLoaded = true;
            } catch (Exception e) {
                NotifyHelper.ReportError(ModName, "OnBeforeInitialModuleScreenSetAsRoot threw exception " + e);
            }
        }

        //THIRD
        protected override void OnGameStart(Game game, IGameStarter gameStarter) {
            try {
                base.OnGameStart(game, gameStarter);

                if (Settings.ApplyHealthOverflowFix) {
                    if (game.GameType is Campaign) {
                        CampaignGameStarter campaignGameStarter = (CampaignGameStarter)gameStarter;

                        if (campaignGameStarter != null) {
                            HealthOverflow = new HealthOverflow();
                            campaignGameStarter.AddBehavior(new HealthOverflow());
                        }
                    }
                }
            } catch (Exception e) {
                NotifyHelper.ReportError(ModName, "OnGameStart threw exception " + e);
            }
        }
    }
}
