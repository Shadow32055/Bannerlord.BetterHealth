using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;
using BetterHealth.Localization;

namespace BetterHealth.Settings {

    public class MCMSettings : AttributeGlobalSettings<MCMSettings> {

        [SettingPropertyGroup(RefValues.MiscText, GroupOrder = 4)]
        [SettingPropertyFloatingInteger(RefValues.RegenText, 0f, 10f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.RegenHint)]
        public float CampaignHealthRegenMultiplier { get; set; } = 1;

        [SettingPropertyGroup(RefValues.MiscText, GroupOrder = 4)]
        [SettingPropertyBool(RefValues.HealthOverflowText, Order = 1, RequireRestart = false, HintText = RefValues.HealthOverflowHint)]
        public bool ApplyHealthOverflowFix { get; set; } = false;



        [SettingPropertyGroup(RefValues.PlayerText)]
        [SettingPropertyInteger(RefValues.BaseHealthText, 1, 2000, "0", Order = 0, RequireRestart = false, HintText = RefValues.BaseHealthHint)]
        public int PlayerBaseHealth { get; set; } = 100;

        [SettingPropertyGroup(RefValues.PlayerText)]
        [SettingPropertyFloatingInteger(RefValues.PercentText, 0.01f, 1f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.PercentHint)]
        public float PlayerPercent { get; set; } = 0;

        [SettingPropertyGroup(RefValues.PlayerText)]
        [SettingPropertyInteger(RefValues.FlatText, 1, 1000, "0 HP", Order = 0, RequireRestart = false, HintText = RefValues.FlatHint)]
        public int PlayerFlatAmount { get; set; } = 0;



        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.GenericSkillText, IsToggle = true, Order = 1, RequireRestart = false, HintText = RefValues.AttributeHint)]
        public bool PlayerVigorSkills { get; set; } = false;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyFloatingInteger(RefValues.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = RefValues.HealthPerSPHint)]
        public float PlayerVigorHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.OneHandedText, Order = 1, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool PlayerVigorOneHandedSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.TwoHandedText, Order = 2, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool PlayerVigorTwoHandedSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.PoleArmText, Order = 3, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool PlayerVigorPolearmSkill { get; set; } = true;



        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.GenericSkillText, IsToggle = true, Order = 2, RequireRestart = false, HintText = RefValues.AttributeHint)]
        public bool PlayerControlSkills { get; set; } = false;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyFloatingInteger(RefValues.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = RefValues.HealthPerSPHint)]
        public float PlayerControlHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.BowText, Order = 1, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool PlayerControlBowSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.CrossbowText, Order = 2, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool PlayerControlCrossbowSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.ThrowingText, Order = 3, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool PlayerControlThrowingSkill { get; set; } = true;



        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.GenericSkillText, IsToggle = true, Order = 3, RequireRestart = false, HintText = RefValues.AttributeHint)]
        public bool PlayerEnduranceSkills { get; set; } = false;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyFloatingInteger(RefValues.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = RefValues.HealthPerSPHint)]
        public float PlayerEnduranceHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.RidingText, Order = 1, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool PlayerEnduranceRidingSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.AthleticsText, Order = 2, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool PlayerEnduranceAthleticsSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.PlayerText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.SmithingText, Order = 3, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool PlayerEnduranceSmithingSkill { get; set; } = true;

        /// <summary>
        /// HEROES
        /// </summary>

        [SettingPropertyGroup(RefValues.HeroesText)]
        [SettingPropertyInteger(RefValues.BaseHealthText, 1, 2000, "0", Order = 0, RequireRestart = false, HintText = RefValues.BaseHealthHint)]
        public int HeroBaseHealth { get; set; } = 100;

        [SettingPropertyGroup(RefValues.HeroesText)]
        [SettingPropertyFloatingInteger(RefValues.PercentText, 0.01f, 1f, "0.0 %", Order = 0, RequireRestart = false, HintText = RefValues.PercentHint)]
        public float HeroPercent { get; set; } = 0;

        [SettingPropertyGroup(RefValues.HeroesText)]
        [SettingPropertyInteger(RefValues.FlatText, 1, 1000, "0 HP", Order = 0, RequireRestart = false, HintText = RefValues.FlatHint)]
        public int HeroFlatAmount { get; set; } = 0;



        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.GenericSkillText, IsToggle = true, Order = 1, RequireRestart = false, HintText = RefValues.AttributeHint)]
        public bool HeroVigorSkills { get; set; } = false;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyFloatingInteger(RefValues.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = RefValues.HealthPerSPHint)]
        public float HeroVigorHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.OneHandedText, Order = 1, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool HeroVigorOneHandedSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.TwoHandedText, Order = 2, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool HeroVigorTwoHandedSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.PoleArmText, Order = 3, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool HeroVigorPolearmSkill { get; set; } = true;



        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.GenericSkillText, IsToggle = true, Order = 2, RequireRestart = false, HintText = RefValues.AttributeHint)]
        public bool HeroControlSkills { get; set; } = false;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyFloatingInteger(RefValues.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = RefValues.HealthPerSPHint)]
        public float HeroControlHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.BowText, Order = 1, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool HeroControlBowSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.CrossbowText, Order = 2, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool HeroControlCrossbowSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.ThrowingText, Order = 3, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool HeroControlThrowingSkill { get; set; } = true;



        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.GenericSkillText, IsToggle = true, Order = 3, RequireRestart = false, HintText = RefValues.AttributeHint)]
        public bool HeroEnduranceSkills { get; set; } = false;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyFloatingInteger(RefValues.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = RefValues.HealthPerSPHint)]
        public float HeroEnduranceHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.RidingText, Order = 1, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool HeroEnduranceRidingSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.AthleticsText, Order = 2, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool HeroEnduranceAthleticsSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.HeroesText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.SmithingText, Order = 3, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool HeroEnduranceSmithingSkill { get; set; } = true;

        /// <summary>
        /// TROOPS
        /// </summary>

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.BaseHealthText)]
        [SettingPropertyInteger(RefValues.TierText + " 1 " + RefValues.BaseHealthText, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = RefValues.TierBaseHealthHint)]
        public int TroopBaseHealthT1 { get; set; } = 100;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.BaseHealthText)]
        [SettingPropertyInteger(RefValues.TierText + " 2 " + RefValues.BaseHealthText, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = RefValues.TierBaseHealthHint)]
        public int TroopBaseHealthT2 { get; set; } = 100;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.BaseHealthText)]
        [SettingPropertyInteger(RefValues.TierText + " 3 " + RefValues.BaseHealthText, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = RefValues.TierBaseHealthHint)]
        public int TroopBaseHealthT3 { get; set; } = 100;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.BaseHealthText)]
        [SettingPropertyInteger(RefValues.TierText + " 4 " + RefValues.BaseHealthText, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = RefValues.TierBaseHealthHint)]
        public int TroopBaseHealthT4 { get; set; } = 100;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.BaseHealthText)]
        [SettingPropertyInteger(RefValues.TierText + " 5 " + RefValues.BaseHealthText, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = RefValues.TierBaseHealthHint)]
        public int TroopBaseHealthT5 { get; set; } = 100;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.BaseHealthText)]
        [SettingPropertyInteger(RefValues.TierText + " 6 " + RefValues.BaseHealthText, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = RefValues.TierBaseHealthHint)]
        public int TroopBaseHealthT6 { get; set; } = 100;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.BaseHealthText)]
        [SettingPropertyInteger(RefValues.TierText + " 7 " + RefValues.BaseHealthText, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = RefValues.TierBaseHealthHint)]
        public int TroopBaseHealthT7 { get; set; } = 100;



        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.GenericSkillText, IsToggle = true, Order = 1, RequireRestart = false, HintText = RefValues.AttributeHint)]
        public bool TroopVigorSkills { get; set; } = false;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyFloatingInteger(RefValues.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = RefValues.HealthPerSPHint)]
        public float TroopVigorHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.OneHandedText, Order = 1, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool TroopVigorOneHandedSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.TwoHandedText, Order = 2, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool TroopVigorTwoHandedSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.VigorSkillText)]
        [SettingPropertyBool(RefValues.PoleArmText, Order = 3, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool TroopVigorPolearmSkill { get; set; } = true;



        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.GenericSkillText, IsToggle = true, Order = 2, RequireRestart = false, HintText = RefValues.AttributeHint)]
        public bool TroopControlSkills { get; set; } = false;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyFloatingInteger(RefValues.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = RefValues.HealthPerSPHint)]
        public float TroopControlHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.BowText, Order = 1, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool TroopControlBowSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.CrossbowText, Order = 2, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool TroopControlCrossbowSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.ControlSkillText)]
        [SettingPropertyBool(RefValues.ThrowingText, Order = 3, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool TroopControlThrowingSkill { get; set; } = true;


        
        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.GenericSkillText, IsToggle = true, Order = 3, RequireRestart = false, HintText = RefValues.AttributeHint)]
        public bool TroopEnduranceSkills { get; set; } = false;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyFloatingInteger(RefValues.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = RefValues.HealthPerSPHint)]
        public float TroopEnduranceHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.RidingText, Order = 1, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool TroopEnduranceRidingSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.AthleticsText, Order = 2, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool TroopEnduranceAthleticsSkill { get; set; } = true;

        [SettingPropertyGroup(RefValues.TroopsText + "/" + RefValues.EnduranceSkillText)]
        [SettingPropertyBool(RefValues.SmithingText, Order = 3, RequireRestart = false, HintText = RefValues.SkillImpactHint)]
        public bool TroopEnduranceSmithingSkill { get; set; } = true;
        


        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FormatType { get; } = "xml";
        public bool LoadMCMConfigFile { get; set; } = true;
    }
}
