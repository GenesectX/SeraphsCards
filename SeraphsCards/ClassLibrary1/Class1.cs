using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using SeraphsCards.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;

namespace SeraphsCards
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class SeraphsCards : BaseUnityPlugin
    {
        private const string ModId = "com.seraph.rounds.SeraphsCards";
        private const string ModName = "SeraphsCards";
        public const string Version = "1.1.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "SC";
        public static SeraphsCards instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
            CustomCard.BuildCard<fart>();
            CustomCard.BuildCard<piss>();
            CustomCard.BuildCard<DoubleJump>();
            CustomCard.BuildCard<RBB>();
            CustomCard.BuildCard<UltraMayhem>();
            CustomCard.BuildCard<Melee>();
            CustomCard.BuildCard<DragonBorn>();
            CustomCard.BuildCard<TrueGC>();
            CustomCard.BuildCard<Shield>();
            CustomCard.BuildCard<Catlives>();
        }
    }
}
