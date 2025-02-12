using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Add this namespace
using Mutagen.Bethesda.Plugins;
using System.ComponentModel;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Synthesis.Bethesda.Commands;

namespace madDynamicStatScaler
{

    public record Settings
    {

        [SettingName("General: Armor Added Per Level Lower than Player")]
        public float mad_Rescale_armorNum { get; set; } = 1;
		[SettingName("General: Armor Decreased Per Level Higher than Player")]
        public float mad_Rescale_armorNum_N { get; set; } = -1;
		[SettingName("General: Magic Resist Added Per Level Lower than Player")]
        public float mad_Rescale_MagicResistNum { get; set; } = 1;
		[SettingName("General: Magic Resist Decreased Per Level Higher than Player")]
        public float mad_Rescale_MagicResistNum_N { get; set; } = -1;
		
        [SettingName("General: Health Added Per Level Lower than Player")]
        public float mad_Rescale_healthNum { get; set; } = 1;

        [SettingName("General: Magicka Added Per Level Lower than Player")]
        public float mad_Rescale_magickaNum { get; set; } = 1;



        [SettingName("General: Stamina Added Per Level Lower than Player")]
        public float mad_Rescale_staminaNum { get; set; } = 1;



        [SettingName("General: Two-Handed % Damage Increase Per Level Lower than Player")]
        public float mad_Rescale_twoNum { get; set; } = 1;



        [SettingName("General: One-Handed % Damage Increase Per Level Lower than Player")]
        public float mad_Rescale_OneNum { get; set; } = 1;



        [SettingName("General: Archery % Damage Increase Per Level Lower than Player")]
        public float mad_Rescale_marksmanNum { get; set; } = 1;



        [SettingName("General: Destruction % Damage Increase Per Level Lower than Player")]
        public float mad_Rescale_DestNum { get; set; } = 1;



        [SettingName("General: Health Decreased Per Level Higher than Player")]
        public float mad_Rescale_health_NegativeNum { get; set; } = -1;



        [SettingName("General: Magicka Decreased Per Level Higher than Player")]
        public float mad_Rescale_magicka_NegativeNum { get; set; } = -1;



        [SettingName("General: Stamina Decreased Per Level Higher than Player")]
        public float mad_Rescale_stamina_NegativeNum { get; set; } = -1;



        [SettingName("General: Two-Handed % Damage Decrease Per Level Higher than Player")]
        public float mad_Rescale_two_NegativeNum { get; set; } = -1;



        [SettingName("General: One-Handed % Damage Decrease Per Level Higher than Player")]
        public float mad_Rescale_one_NegativeNum { get; set; } = -1;



        [SettingName("General: Archery % Damage Decrease Per Level Higher than Player")]
        public float mad_Rescale_marksman_NegativeNum { get; set; } = -1;



        [SettingName("General: Destruction % Damage Decrease Per Level Higher than Player")]
        public float mad_Rescale_Dest_NegativeNum { get; set; } = -1;


        [SettingName("Boss & Dragon: Max Level Diff")]
        public int mad_Rescale_bossdragNum { get; set; } = 40;


		[SettingName("Boss: Armor Added Per Level Lower than Player")]
        public float mad_Rescale_armorNum_boss { get; set; } = 1;

		[SettingName("Boss: Armor Decreased Per Level Higher than Player")]
        public float mad_Rescale_armorNum_bossN { get; set; } = -1;

		[SettingName("Boss: Magic Resist Added Per Level Lower than Player")]
        public float mad_Rescale_MagicResistNum_boss { get; set; } = 1;

		[SettingName("Boss: Magic Resist Decreased Per Level Higher than Player")]
        public float mad_Rescale_MagicResistNum_bossN { get; set; } = -1;
		
		
        [SettingName("Boss: Health Added Per Level Lower than Player")]
        public float mad_Rescale_health_BossNum { get; set; } = 1;




        [SettingName("Boss: Magicka Added Per Level Lower than Player")]
        public float mad_Rescale_magicka_BossNum { get; set; } = 1;




        [SettingName("Boss: Stamina Added Per Level Lower than Player")]
        public float mad_Rescale_stamina_BossNum { get; set; } = 1;



        [SettingName("Boss: Two-Handed % Damage Increase Per Level Lower than Player")]
        public float mad_Rescale_two_BossNum { get; set; } = 1;



        [SettingName("Boss: One-Handed % Damage Increase Per Level Lower than Player")]
        public float mad_Rescale_One_BossNum { get; set; } = 1;



        [SettingName("Boss: Archery % Damage Increase Per Level Lower than Player")]
        public float mad_Rescale_marksman_BossNum { get; set; } = 1;




        [SettingName("Boss: Destruction % Damage Increase Per Level Lower than Player")]
        public float mad_Rescale_Dest_BossNum { get; set; } = 1;


        [SettingName("Boss: Health Decreased Per Level Higher than Player")]
        public float mad_Rescale_health_Negative_BossNum { get; set; } = -1;

        [SettingName("Boss: Magicka Decreased Per Level Higher than Player")]
        public float mad_Rescale_magicka_Negative_BossNum { get; set; } = -1;

        [SettingName("Boss: Stamina Decreased Per Level Higher than Player")]
        public float mad_Rescale_stamina_Negative_BossNum { get; set; } = -1;

        [SettingName("Boss: Two-Handed % Damage Decrease Per Level Higher than Player")]
        public float mad_Rescale_two_Negative_BossNum { get; set; } = -1;

        [SettingName("Boss: One-Handed % Damage Decrease Per Level Higher than Player")]
        public float mad_Rescale_one_Negative_BossNum { get; set; } = -1;

        [SettingName("Boss: Archery % Damage Decrease Per Level Higher than Player")]
        public float mad_Rescale_marksman_Negative_BossNum { get; set; } = -1;

        [SettingName("Boss: Destruction % Damage Decrease Per Level Higher than Player")]
        public float mad_Rescale_Dest_Negative_BossNum { get; set; } = -1;

        [SettingName("Dragon: Health Added Per Level Lower than Player")]
        public float mad_Rescale_health_dragonNum { get; set; } = 1;

        [SettingName("Dragon: Health Decreased Per Level Higher than Player")]
        public float mad_Rescale_health_Negative_DragonNum { get; set; } = -1;

        [SettingName("Dragon: Unarmed Damage Added Per Level Lower than Player")]
        public float mad_Rescale_UA_dragonNum { get; set; } = 1;

        [SettingName("Dragon: Unarmed Damage Decreased Per Level Higher than Player")]
        public float mad_Rescale_UA_Negative_DragonNum { get; set; } = -1;
	
		[SettingName("Dragon: Armor Added Per Level Lower than Player")]
        public float mad_Rescale_armorNum_Dragon { get; set; } = 1;
		[SettingName("Dragon: Armor Decreased Per Level Higher than Player")]
        public float mad_Rescale_armorNum_DragonN { get; set; } = -1;
		[SettingName("Dragon: Magic Resist Added Per Level Lower than Player")]
        public float mad_Rescale_MagicResistNum_Dragon { get; set; } = 1;
		[SettingName("Dragon: Magic Resist Decreased Per Level Higher than Player")]
        public float mad_Rescale_MagicResistNum_DragonN { get; set; } = -1;

        [SettingName("Creature: Unarmed Damage Added Per Level Lower than Player")]
        public float mad_Rescale_UA_CreatureNum { get; set; } = 1;

        [SettingName("Creature: Unarmed Damage Decreased Per Level Higher than Player")]
        public float mad_Rescale_UA_Negative_CreatureNum { get; set; } = -1;




		
		









    }







}

