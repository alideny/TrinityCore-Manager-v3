﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrinityCore_Manager.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TrinityCore_Manager.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets whether the world accepts new client connections. Even if the server is online..
        /// </summary>
        internal static string AllowConnDesc {
            get {
                return ResourceManager.GetString("AllowConnDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type of ammunition the item uses.
        /// </summary>
        internal static string AmmoTypeDesc {
            get {
                return ResourceManager.GetString("AmmoTypeDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The zone ID that this item can be used in..
        /// </summary>
        internal static string AreaDesc {
            get {
                return ResourceManager.GetString("AreaDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the item is a bag, this field is a bitmask controlling what types of items can be put in this bag. You can combine different types by adding up the bit numbers..
        /// </summary>
        internal static string BagFamilyDesc {
            get {
                return ResourceManager.GetString("BagFamilyDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The size of the item stack when sold by vendors. Also if a vendor has limited copies of this item available, everytime the vendor list is refreshed (See npc_vendor.incrtime), the number of copies increases by this number..
        /// </summary>
        internal static string BuyCountDesc {
            get {
                return ResourceManager.GetString("BuyCountDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the item is a bag, this field controls the number of slots the bag has..
        /// </summary>
        internal static string ContainerSlotsDesc {
            get {
                return ResourceManager.GetString("ContainerSlotsDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The time in milliseconds between successive hits..
        /// </summary>
        internal static string DelayDesc {
            get {
                return ResourceManager.GetString("DelayDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The description that appears in orange letters at the bottom of the item tooltip..
        /// </summary>
        internal static string DescriptionDesc {
            get {
                return ResourceManager.GetString("DescriptionDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The disenchant loot template ID. See disenchant_loot_template.entry.
        /// </summary>
        internal static string DisenchantIdDesc {
            get {
                return ResourceManager.GetString("DisenchantIdDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to he duration of the item in seconds. If positive, it is the duration measured in ingame time. If negative, it is the duration measured in real time..
        /// </summary>
        internal static string DurationDesc {
            get {
                return ResourceManager.GetString("DurationDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bitmask field that contains flags that the item has on it. As all other such fields, just add the flags together to combine them. Possible flags are listed below.
        /// </summary>
        internal static string FlagsDesc {
            get {
                return ResourceManager.GetString("FlagsDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If this item is a food type item, this field defines what type of food it is for hunters who want to feed their pets. It controls in what diet this food item falls in.
        ///NOTE: Raw meat and fish is not the same as regular meat and fish. It seems that the last two types of diets include grey &quot;poor&quot; types of food that players have no use for but some pets seem to be able to eat. Also, those food types appeared in TBC so most likely only TBC pets will have those types of diets..
        /// </summary>
        internal static string FoodTypeDesc {
            get {
                return ResourceManager.GetString("FoodTypeDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ID of the item set that this item belongs to. To save you some time, you CAN NOT make up new item sets. Item sets are defined in ItemSet.dbc.
        /// </summary>
        internal static string ItemSetDesc {
            get {
                return ResourceManager.GetString("ItemSetDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The language that the item text is written in. Languages.dbc.
        /// </summary>
        internal static string LanguageIdDesc {
            get {
                return ResourceManager.GetString("LanguageIdDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The lock entry ID that this item (which serves as a key) is tied to. This field is used in key-door mechanics. See Lock.dbc.
        /// </summary>
        internal static string LockIdDesc {
            get {
                return ResourceManager.GetString("LockIdDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The map ID that this item can be used in..
        /// </summary>
        internal static string MapDesc {
            get {
                return ResourceManager.GetString("MapDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The material that the item is made of. The value here affects the sound that the item makes when moved. Use -1 for consumable items like food, reagents, etc..
        /// </summary>
        internal static string MatDesc {
            get {
                return ResourceManager.GetString("MatDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum number of copies of this item a player can have. Use 0 for infinite.
        /// </summary>
        internal static string MaxCountDesc {
            get {
                return ResourceManager.GetString("MaxCountDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the item is a container that can contain money, then this field defines the maximum coinage held in this container, in copper..
        /// </summary>
        internal static string MaxMoneyLootDesc {
            get {
                return ResourceManager.GetString("MaxMoneyLootDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the item is a container that can contain money, then this field defines the minimum coinage held in this container, in copper..
        /// </summary>
        internal static string MinMoneyLootDesc {
            get {
                return ResourceManager.GetString("MinMoneyLootDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The background texture that appears in the page text window. PageTextMaterial.dbc.
        /// </summary>
        internal static string PageMatDesc {
            get {
                return ResourceManager.GetString("PageMatDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ID referring to the text that the item will show (if it is a book or a letter, etc). The item will have a magnifying glass cursor in the game and will show the text when right-clicked. See page_text.entry.
        /// </summary>
        internal static string PageTextDesc {
            get {
                return ResourceManager.GetString("PageTextDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No description for this field, visit trinitycore website for more info..
        /// </summary>
        internal static string RandomArmorDmgModDesc {
            get {
                return ResourceManager.GetString("RandomArmorDmgModDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number in this field points to item_enchantment_template.entry and ties in an item&apos;s chance at having a random property attached to it when it shows up for the first time. This field and the RandomSuffix field CANNOT both have non-zero values. Either one is filled, or the other. Also, the primary source for the number in this field are WDBs..
        /// </summary>
        internal static string RandomPropDesc {
            get {
                return ResourceManager.GetString("RandomPropDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number in this field points to item_enchantment_template.entry and ties in an item&apos;s chance at having a random suffix attached to it when it shows up for the first time. This field and the RandomProperty field CANNOT both have non-zero values. Either one is filled, or the other. Also, the primary source for the number in this field are WDBs..
        /// </summary>
        internal static string RandomSuffixDesc {
            get {
                return ResourceManager.GetString("RandomSuffixDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Range-Modefier for bows/guns/crossbows:
        ///Default range is somewhere between 0.3 and 0.4 yards,
        ///all blizzard ranged weapons have RangedModRange100.
        /// </summary>
        internal static string RangedModDamageDesc {
            get {
                return ResourceManager.GetString("RangedModDamageDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The required proficiency in disenchanting that the player needs to have to be able to disenchant this item..
        /// </summary>
        internal static string ReqDisenchSkillDesc {
            get {
                return ResourceManager.GetString("ReqDisenchSkillDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The honor rank the player needs to have to use this item..
        /// </summary>
        internal static string ReqHonorRankDesc {
            get {
                return ResourceManager.GetString("ReqHonorRankDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required level the player has to be to use this item..
        /// </summary>
        internal static string ReqLevelDesc {
            get {
                return ResourceManager.GetString("ReqLevelDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The faction template ID (from Faction.dbc) of the faction that the player has to have a certain ranking with. If this value is 0, the faction of the seller of the item is used..
        /// </summary>
        internal static string ReqRepFactionDesc {
            get {
                return ResourceManager.GetString("ReqRepFactionDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The skill required to use this item. See SkillLine.dbc.
        /// </summary>
        internal static string ReqSkillDesc {
            get {
                return ResourceManager.GetString("ReqSkillDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The required skill rank the player needs to have to use this item..
        /// </summary>
        internal static string ReqSkillRankDesc {
            get {
                return ResourceManager.GetString("ReqSkillRankDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The required spell that the player needs to have to use this item.
        /// </summary>
        internal static string ReqSpellDesc {
            get {
                return ResourceManager.GetString("ReqSpellDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Similar to Static Stats these are the Stats that grow along with the users level (mainly heirloom leveling gear)
        ///use like static stats.
        /// </summary>
        internal static string ScalingStatDistDesc {
            get {
                return ResourceManager.GetString("ScalingStatDistDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Final (level 80) value of the scaling-stat.
        /// </summary>
        internal static string ScalingStatValueDesc {
            get {
                return ResourceManager.GetString("ScalingStatValueDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to he name of the script that the item should use. There is no &apos;internalitemhandler&apos; or &apos;internalitemhanler&apos; script so trinity will ignore any such values in this field..
        /// </summary>
        internal static string ScriptNameDesc {
            get {
                return ResourceManager.GetString("ScriptNameDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The price that the vendor will pay you for the item when you sell it and if it is possible to be sold, in copper. Put in 0 if the item cannot be sold to a vendor..
        /// </summary>
        internal static string SellGoldDesc {
            get {
                return ResourceManager.GetString("SellGoldDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Controls how the item is put away on the character (pressing the &apos;Z&apos; hotkey)..
        /// </summary>
        internal static string SheathDesc {
            get {
                return ResourceManager.GetString("SheathDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The color of the socket that can be placed in this item..
        /// </summary>
        internal static string SocketColorDesc {
            get {
                return ResourceManager.GetString("SocketColorDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cooldown time in milliseconds that is applied to all other spells in the category that the triggered spell is also in. Use -1 to use the default spell cooldown..
        /// </summary>
        internal static string SpellCatCdDesc {
            get {
                return ResourceManager.GetString("SpellCatCdDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The category that the spell is in..
        /// </summary>
        internal static string SpellCatDesc {
            get {
                return ResourceManager.GetString("SpellCatDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cooldown in milliseconds for the specific spell controlling how often the spell can be used. Use -1 to use the default spell cooldown. Note: this is not the &quot;internal cooldown&quot; of procs commonly found on items such as trinkets with &quot;Chance on hit&quot; effects..
        /// </summary>
        internal static string SpellCdDesc {
            get {
                return ResourceManager.GetString("SpellCdDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of times that the item can cast the spell. If 0, then infinite charges are possible. If negative, then after the number of charges is depleted, the item is deleted as well. If positive, then the item is not deleted after all the charges are spent..
        /// </summary>
        internal static string SpellChargesDesc {
            get {
                return ResourceManager.GetString("SpellChargesDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The spell ID of the spell that the item can cast or trigger..
        /// </summary>
        internal static string SpellIdDesc {
            get {
                return ResourceManager.GetString("SpellIdDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The proc per minute rate controlling how often the spell is triggered (if #spelltrigger == 2)..
        /// </summary>
        internal static string SpellPpmRateDesc {
            get {
                return ResourceManager.GetString("SpellPpmRateDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type of trigger for the spell..
        /// </summary>
        internal static string SpellTriggerDesc {
            get {
                return ResourceManager.GetString("SpellTriggerDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of copies of this item that can be stacked in the same slot..
        /// </summary>
        internal static string StackableDesc {
            get {
                return ResourceManager.GetString("StackableDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ID of the quest that this item will start if right-clicked. See quest_template.id.
        /// </summary>
        internal static string StartQuestDesc {
            get {
                return ResourceManager.GetString("StartQuestDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When an item has entries in stat_type, this must be updated to display those entries
        ///(Unknown how this works).
        /// </summary>
        internal static string StatsCountDesc {
            get {
                return ResourceManager.GetString("StatsCountDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Corresponds to the ID in TotemCategory.dbc..
        /// </summary>
        internal static string TotemCatDesc {
            get {
                return ResourceManager.GetString("TotemCatDesc", resourceCulture);
            }
        }
    }
}