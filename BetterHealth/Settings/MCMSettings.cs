using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace BetterHealth.Settings
{

    public class MCMSettings : AttributeGlobalSettings<MCMSettings> {

        [SettingPropertyGroup(Strings.MiscText, GroupOrder = 4)]
        [SettingPropertyInteger(Strings.RegenText, 0, 10000, "0", Order = 0, RequireRestart = false, HintText = Strings.RegenHint)]
        public int CampaignHealthRegen { get; set; } = 10;

        [SettingPropertyGroup(Strings.MiscText, GroupOrder = 4)]
        [SettingPropertyBool(Strings.HealthOverflowText, Order = 1, RequireRestart = false, HintText = Strings.HealthOverflowHint)]
        public bool ApplyHealthOverflowFix { get; set; } = false;



        [SettingPropertyGroup(Strings.PlayerText)]
        [SettingPropertyInteger(Strings.BaseHealthText, 1, 2000, "0", Order = 0, RequireRestart = false, HintText = Strings.BaseHealthHint)]
        public int PlayerBaseHealth { get; set; } = 100;

        [SettingPropertyGroup(Strings.PlayerText)]
        [SettingPropertyFloatingInteger(Strings.PercentText, 0f, 0.05f, "0.0 %", Order = 0, RequireRestart = false, HintText = Strings.PercentHint)]
        public float PlayerPercent { get; set; } = 0;

        [SettingPropertyGroup(Strings.PlayerText)]
        [SettingPropertyInteger(Strings.FlatText, 0, 1000, "0 HP", Order = 0, RequireRestart = false, HintText = Strings.FlatHint)]
        public int PlayerFlatAmount { get; set; } = 0;



        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.GenericSkillText, IsToggle = true, Order = 1, RequireRestart = false, HintText = Strings.AttributeHint)]
        public bool PlayerVigorSkills { get; set; } = false;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.VigorSkillText)]
        [SettingPropertyFloatingInteger(Strings.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = Strings.HealthPerSPHint)]
        public float PlayerVigorHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.OneHandedText, Order = 1, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool PlayerVigorOneHandedSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.TwoHandedText, Order = 2, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool PlayerVigorTwoHandedSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.PoleArmText, Order = 3, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool PlayerVigorPolearmSkill { get; set; } = true;



        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.GenericSkillText, IsToggle = true, Order = 2, RequireRestart = false, HintText = Strings.AttributeHint)]
        public bool PlayerControlSkills { get; set; } = false;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.ControlSkillText)]
        [SettingPropertyFloatingInteger(Strings.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = Strings.HealthPerSPHint)]
        public float PlayerControlHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.BowText, Order = 1, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool PlayerControlBowSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.CrossbowText, Order = 2, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool PlayerControlCrossbowSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.ThrowingText, Order = 3, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool PlayerControlThrowingSkill { get; set; } = true;



        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.GenericSkillText, IsToggle = true, Order = 3, RequireRestart = false, HintText = Strings.AttributeHint)]
        public bool PlayerEnduranceSkills { get; set; } = false;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyFloatingInteger(Strings.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = Strings.HealthPerSPHint)]
        public float PlayerEnduranceHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.RidingText, Order = 1, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool PlayerEnduranceRidingSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.AthleticsText, Order = 2, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool PlayerEnduranceAthleticsSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.PlayerText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.SmithingText, Order = 3, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool PlayerEnduranceSmithingSkill { get; set; } = true;

        /// <summary>
        /// HEROES
        /// </summary>

        [SettingPropertyGroup(Strings.HeroesText)]
        [SettingPropertyInteger(Strings.BaseHealthText, 1, 2000, "0", Order = 0, RequireRestart = false, HintText = Strings.BaseHealthHint)]
        public int HeroBaseHealth { get; set; } = 100;

        [SettingPropertyGroup(Strings.HeroesText)]
        [SettingPropertyFloatingInteger(Strings.PercentText, 0f, 0.05f, "0.0 %", Order = 0, RequireRestart = false, HintText = Strings.PercentHint)]
        public float HeroPercent { get; set; } = 0;

        [SettingPropertyGroup(Strings.HeroesText)]
        [SettingPropertyInteger(Strings.FlatText, 0, 1000, "0 HP", Order = 0, RequireRestart = false, HintText = Strings.FlatHint)]
        public int HeroFlatAmount { get; set; } = 0;



        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.GenericSkillText, IsToggle = true, Order = 1, RequireRestart = false, HintText = Strings.AttributeHint)]
        public bool HeroVigorSkills { get; set; } = false;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.VigorSkillText)]
        [SettingPropertyFloatingInteger(Strings.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = Strings.HealthPerSPHint)]
        public float HeroVigorHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.OneHandedText, Order = 1, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool HeroVigorOneHandedSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.TwoHandedText, Order = 2, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool HeroVigorTwoHandedSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.PoleArmText, Order = 3, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool HeroVigorPolearmSkill { get; set; } = true;



        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.GenericSkillText, IsToggle = true, Order = 2, RequireRestart = false, HintText = Strings.AttributeHint)]
        public bool HeroControlSkills { get; set; } = false;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.ControlSkillText)]
        [SettingPropertyFloatingInteger(Strings.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = Strings.HealthPerSPHint)]
        public float HeroControlHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.BowText, Order = 1, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool HeroControlBowSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.CrossbowText, Order = 2, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool HeroControlCrossbowSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.ThrowingText, Order = 3, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool HeroControlThrowingSkill { get; set; } = true;



        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.GenericSkillText, IsToggle = true, Order = 3, RequireRestart = false, HintText = Strings.AttributeHint)]
        public bool HeroEnduranceSkills { get; set; } = false;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyFloatingInteger(Strings.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = Strings.HealthPerSPHint)]
        public float HeroEnduranceHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.RidingText, Order = 1, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool HeroEnduranceRidingSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.AthleticsText, Order = 2, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool HeroEnduranceAthleticsSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.HeroesText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.SmithingText, Order = 3, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool HeroEnduranceSmithingSkill { get; set; } = true;

        /// <summary>
        /// TROOPS
        /// </summary>

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.BaseHealthText)]
        [SettingPropertyInteger(Strings.Tier1Text, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = Strings.TierBaseHealthHint)]
        public int TroopBaseHealthT1 { get; set; } = 100;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.BaseHealthText)]
        [SettingPropertyInteger(Strings.Tier2Text, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = Strings.TierBaseHealthHint)]
        public int TroopBaseHealthT2 { get; set; } = 100;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.BaseHealthText)]
        [SettingPropertyInteger(Strings.Tier3Text, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = Strings.TierBaseHealthHint)]
        public int TroopBaseHealthT3 { get; set; } = 100;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.BaseHealthText)]
        [SettingPropertyInteger(Strings.Tier4Text, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = Strings.TierBaseHealthHint)]
        public int TroopBaseHealthT4 { get; set; } = 100;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.BaseHealthText)]
        [SettingPropertyInteger(Strings.Tier5Text, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = Strings.TierBaseHealthHint)]
        public int TroopBaseHealthT5 { get; set; } = 100;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.BaseHealthText)]
        [SettingPropertyInteger(Strings.Tier6Text, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = Strings.TierBaseHealthHint)]
        public int TroopBaseHealthT6 { get; set; } = 100;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.BaseHealthText)]
        [SettingPropertyInteger(Strings.Tier7Text, 1, 2000, "0 HP", Order = 0, RequireRestart = false, HintText = Strings.TierBaseHealthHint)]
        public int TroopBaseHealthT7 { get; set; } = 100;



        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.GenericSkillText, IsToggle = true, Order = 1, RequireRestart = false, HintText = Strings.AttributeHint)]
        public bool TroopVigorSkills { get; set; } = false;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.VigorSkillText)]
        [SettingPropertyFloatingInteger(Strings.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = Strings.HealthPerSPHint)]
        public float TroopVigorHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.OneHandedText, Order = 1, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool TroopVigorOneHandedSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.TwoHandedText, Order = 2, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool TroopVigorTwoHandedSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.VigorSkillText)]
        [SettingPropertyBool(Strings.PoleArmText, Order = 3, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool TroopVigorPolearmSkill { get; set; } = true;



        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.GenericSkillText, IsToggle = true, Order = 2, RequireRestart = false, HintText = Strings.AttributeHint)]
        public bool TroopControlSkills { get; set; } = false;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.ControlSkillText)]
        [SettingPropertyFloatingInteger(Strings.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = Strings.HealthPerSPHint)]
        public float TroopControlHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.BowText, Order = 1, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool TroopControlBowSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.CrossbowText, Order = 2, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool TroopControlCrossbowSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.ControlSkillText)]
        [SettingPropertyBool(Strings.ThrowingText, Order = 3, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool TroopControlThrowingSkill { get; set; } = true;


        
        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.GenericSkillText, IsToggle = true, Order = 3, RequireRestart = false, HintText = Strings.AttributeHint)]
        public bool TroopEnduranceSkills { get; set; } = false;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyFloatingInteger(Strings.PointPerSkillText, 0f, 50f, "0.0 HP", Order = 0, RequireRestart = false, HintText = Strings.HealthPerSPHint)]
        public float TroopEnduranceHealthValue { get; set; } = .2f;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.RidingText, Order = 1, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool TroopEnduranceRidingSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.AthleticsText, Order = 2, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool TroopEnduranceAthleticsSkill { get; set; } = true;

        [SettingPropertyGroup(Strings.TroopsText + "/" + Strings.EnduranceSkillText)]
        [SettingPropertyBool(Strings.SmithingText, Order = 3, RequireRestart = false, HintText = Strings.SkillImpactHint)]
        public bool TroopEnduranceSmithingSkill { get; set; } = true;
        


        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FormatType { get; } = "xml";
        public bool LoadMCMConfigFile { get; set; } = true;
    }
}
