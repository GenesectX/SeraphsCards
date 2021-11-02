using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace SeraphsCards.Cards
{
    class DragonBorn : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.knockback = 100f;
            gun.destroyBulletAfter = 0.1f;
            gun.numberOfProjectiles = 10;
            gun.damage = 0.2f;
            gun.ammo = 10;
            gun.spread = 0.2f;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            UnityEngine.Debug.Log($"[{SeraphsCards.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            gun.projectileColor = Color.cyan;
            //Edits values on player when card is selected
            UnityEngine.Debug.Log($"[{SeraphsCards.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
            UnityEngine.Debug.Log($"[{SeraphsCards.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }
        protected override string GetTitle()
        {
            return "Unrelenting Force";
        }
        protected override string GetDescription()
        {
            return "Your voice is raw power, pushing aside anything - or anyone - who stands in your path";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Knockback",
                    amount = "4000%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },         
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Bullets",
                    amount = "+10",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },       
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Range",
                    amount = "Reduced",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },      
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Damage",
                    amount = "-80%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.ColdBlue;
        }
        public override string GetModName()
        {
            return SeraphsCards.ModInitials;
        }
    }
}



