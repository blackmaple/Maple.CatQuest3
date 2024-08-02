
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3
{


    /// <summary>
    /// class ["ProjectStar".""."GameEntity"]
    /// [Entitas.Entity]=>[System.Object]
    /// [IAoeCastingHitEntity]=>[IAoeColliderTypeEntity]=>[IAoeCollisionEntity]=>[IAoeInfoEntity]=>[IAoeTickEntity]=>[IAoeTickingHitEntity]=>[IAttackEventInfoEntity]=>[ICombatAgentEntity]=>[ICombatAgentListEntity]=>[ICombatLogEntity]=>[ICombatProxyAgentEntity]=>[ICulledVisualsEntity]=>[IDestroyedEntity]=>[IDirectionEntity]=>[IEnemyAllegianceEntity]=>[IEnemyOwnedProxyEntity]=>[IFadeDurationEntity]=>[IGameEntityIdEntity]=>[IHitTargetEntity]=>[IIdEntity]=>[IInactiveEntity]=>[IInputStateCommandEntity]=>[IIntCounterEntity]=>[IInteractCommandEntity]=>[IInteractCommandUpdateEntity]=>[IManaEntity]=>[IOnReviveCallbackEntity]=>[IPlayerAllegianceEntity]=>[IPlayerOwnedProxyEntity]=>[IPositionAttachEntity]=>[IPositionEntity]=>[IProjectileInfoEntity]=>[IProjectileReferenceEntity]=>[IProxyTargetAlliesEntity]=>[IProxyTargetEnemiesEntity]=>[IProxyTargetSelfEntity]=>[IShipCannonAttackConfigEntity]=>[IShipSpecialAttackConfigEntity]=>[ISourceEntity]=>[ISourceTransformEntity]=>[ISpawnerOverrideDurationEntity]=>[ISpawnTableItemEntity]=>[ITargetEntity]=>[ITargetListEntity]=>[ITargetPositionEntity]=>[ITargetTransformEntity]=>[ITimedBuffEntity]=>[ITimerCallbackEntity]=>[ITimerEntity]=>[ITransformEntity]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000639U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [71, 97, 109, 101, 69, 110, 116, 105, 116, 121])]

    //  class static AddPlayerEventComponent addPlayerEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"addPlayerEventComponent", "ADD_PLAYER_EVENT_COMPONENT", true)]

    //  class static AnimationDoneComponent animationDoneComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"animationDoneComponent", "ANIMATION_DONE_COMPONENT", true)]

    //  class static AoeCastingHitComponent aoeCastingHitComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"aoeCastingHitComponent", "AOE_CASTING_HIT_COMPONENT", true)]

    //  class static AoeCollisionComponent aoeCollisionComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"aoeCollisionComponent", "AOE_COLLISION_COMPONENT", true)]

    //  class static AoeTickComponent aoeTickComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"aoeTickComponent", "AOE_TICK_COMPONENT", true)]

    //  class static AoeTickingHitComponent aoeTickingHitComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"aoeTickingHitComponent", "AOE_TICKING_HIT_COMPONENT", true)]

    //  class static AttachedProjectileComponent attachedProjectileComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"attachedProjectileComponent", "ATTACHED_PROJECTILE_COMPONENT", true)]

    //  class static AttackDoHitComponent attackDoHitComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"attackDoHitComponent", "ATTACK_DO_HIT_COMPONENT", true)]

    //  class static AttackingComponent attackingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"attackingComponent", "ATTACKING_COMPONENT", true)]

    //  class static BossTrait bossTraitComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"bossTraitComponent", "BOSS_TRAIT_COMPONENT", true)]

    //  class static ChargeAttackingComponent chargeAttackingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"chargeAttackingComponent", "CHARGE_ATTACKING_COMPONENT", true)]

    //  class static ChargingAttack chargingAttackComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"chargingAttackComponent", "CHARGING_ATTACK_COMPONENT", true)]

    //  class static CollectibleMagnetEventComponent collectibleMagnetEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"collectibleMagnetEventComponent", "COLLECTIBLE_MAGNET_EVENT_COMPONENT", true)]

    //  class static CombatCheckedComponent combatCheckedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"combatCheckedComponent", "COMBAT_CHECKED_COMPONENT", true)]

    //  class static Culled culledComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"culledComponent", "CULLED_COMPONENT", true)]

    //  class static CulledVisuals culledVisualsComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"culledVisualsComponent", "CULLED_VISUALS_COMPONENT", true)]

    //  class static CutSceneFastForwardBlockedComponent cutSceneFastForwardBlockedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"cutSceneFastForwardBlockedComponent", "CUT_SCENE_FAST_FORWARD_BLOCKED_COMPONENT", true)]

    //  class static CutSceneFastForwardComponent cutSceneFastForwardComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"cutSceneFastForwardComponent", "CUT_SCENE_FAST_FORWARD_COMPONENT", true)]

    //  class static DashAttackUnlockedComponent dashAttackUnlockedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"dashAttackUnlockedComponent", "DASH_ATTACK_UNLOCKED_COMPONENT", true)]

    //  class static DeathEventProcessedComponent deathEventProcessedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"deathEventProcessedComponent", "DEATH_EVENT_PROCESSED_COMPONENT", true)]

    //  class static DestroyedComponent destroyedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"destroyedComponent", "DESTROYED_COMPONENT", true)]

    //  class static DestructibleComponent destructibleComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"destructibleComponent", "DESTRUCTIBLE_COMPONENT", true)]

    //  class static DisableHitFlash disableHitFlashComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"disableHitFlashComponent", "DISABLE_HIT_FLASH_COMPONENT", true)]

    //  class static EnemyAllegianceComponent enemyAllegianceComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"enemyAllegianceComponent", "ENEMY_ALLEGIANCE_COMPONENT", true)]

    //  class static EnemyComponent enemyComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"enemyComponent", "ENEMY_COMPONENT", true)]

    //  class static EnemyOwnedProxyComponent enemyOwnedProxyComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"enemyOwnedProxyComponent", "ENEMY_OWNED_PROXY_COMPONENT", true)]

    //  class static EquipmentUpgradeShopInteractableComponent equipmentUpgradeShopInteractableComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"equipmentUpgradeShopInteractableComponent", "EQUIPMENT_UPGRADE_SHOP_INTERACTABLE_COMPONENT", true)]

    //  class static FacePlayerWhenFlee facePlayerWhenFleeComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"facePlayerWhenFleeComponent", "FACE_PLAYER_WHEN_FLEE_COMPONENT", true)]

    //  class static FinalPoint finalPointComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"finalPointComponent", "FINAL_POINT_COMPONENT", true)]

    //  class static Fleeing fleeingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"fleeingComponent", "FLEEING_COMPONENT", true)]

    //  class static FloatBlockedComponent floatBlockedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"floatBlockedComponent", "FLOAT_BLOCKED_COMPONENT", true)]

    //  class static FlyingTrait flyingTraitComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"flyingTraitComponent", "FLYING_TRAIT_COMPONENT", true)]

    //  class static FollowingComponent followingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"followingComponent", "FOLLOWING_COMPONENT", true)]

    //  class static FreezeFacing freezeFacingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"freezeFacingComponent", "FREEZE_FACING_COMPONENT", true)]

    //  class static FSMInteractableComponent fSMInteractableComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"fSMInteractableComponent", "F_SM_INTERACTABLE_COMPONENT", true)]

    //  class static GlobalInteractBlockedComponent globalInteractBlockedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"globalInteractBlockedComponent", "GLOBAL_INTERACT_BLOCKED_COMPONENT", true)]

    //  class static HitTargetComponent hitTargetComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"hitTargetComponent", "HIT_TARGET_COMPONENT", true)]

    //  class static HomingAroundSourceComponent homingAroundSourceComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"homingAroundSourceComponent", "HOMING_AROUND_SOURCE_COMPONENT", true)]

    //  class static InactiveComponent inactiveComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"inactiveComponent", "INACTIVE_COMPONENT", true)]

    //  class static InActiveTrapComponent inActiveTrapComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"inActiveTrapComponent", "IN_ACTIVE_TRAP_COMPONENT", true)]

    //  class static InCombatModeComponent inCombatModeComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"inCombatModeComponent", "IN_COMBAT_MODE_COMPONENT", true)]

    //  class static InCutsceneComponent inCutsceneComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"inCutsceneComponent", "IN_CUTSCENE_COMPONENT", true)]

    //  class static InfinityComponent infinityComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"infinityComponent", "INFINITY_COMPONENT", true)]

    //  class static InShipComponent inShipComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"inShipComponent", "IN_SHIP_COMPONENT", true)]

    //  class static InteractBlockedComponent interactBlockedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"interactBlockedComponent", "INTERACT_BLOCKED_COMPONENT", true)]

    //  class static InvincibleComponent invincibleComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"invincibleComponent", "INVINCIBLE_COMPONENT", true)]

    //  class static inWaterComponent inWaterComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"inWaterComponent", "IN_WATER_COMPONENT", true)]

    //  class static JustSpawnedComponent justSpawnedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"justSpawnedComponent", "JUST_SPAWNED_COMPONENT", true)]

    //  class static KilledComponent killedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"killedComponent", "KILLED_COMPONENT", true)]

    //  class static LastBossComponent lastBossComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"lastBossComponent", "LAST_BOSS_COMPONENT", true)]

    //  class static LootDropEventComponent lootDropEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"lootDropEventComponent", "LOOT_DROP_EVENT_COMPONENT", true)]

    //  class static MonsterCapturedComponent monsterCapturedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"monsterCapturedComponent", "MONSTER_CAPTURED_COMPONENT", true)]

    //  class static MonsterComponent monsterComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"monsterComponent", "MONSTER_COMPONENT", true)]

    //  class static MovingComponent movingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"movingComponent", "MOVING_COMPONENT", true)]

    //  class static NotEnoughGunAmmoEventComponent notEnoughGunAmmoEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"notEnoughGunAmmoEventComponent", "NOT_ENOUGH_GUN_AMMO_EVENT_COMPONENT", true)]

    //  class static NPCComponent nPCComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"nPCComponent", "N_PC_COMPONENT", true)]

    //  class static PlayerAllegianceComponent playerAllegianceComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"playerAllegianceComponent", "PLAYER_ALLEGIANCE_COMPONENT", true)]

    //  class static PlayerCannotBeAggroedComponent playerCannotBeAggroedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"playerCannotBeAggroedComponent", "PLAYER_CANNOT_BE_AGGROED_COMPONENT", true)]

    //  class static PlayerCharacterComponent playerCharacterComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"playerCharacterComponent", "PLAYER_CHARACTER_COMPONENT", true)]

    //  class static PlayerControlledComponent playerControlledComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"playerControlledComponent", "PLAYER_CONTROLLED_COMPONENT", true)]

    //  class static PlayerFlinchingComponent playerFlinchingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"playerFlinchingComponent", "PLAYER_FLINCHING_COMPONENT", true)]

    //  class static PlayerOwnedProxyComponent playerOwnedProxyComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"playerOwnedProxyComponent", "PLAYER_OWNED_PROXY_COMPONENT", true)]

    //  class static PlayerShipComponent playerShipComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"playerShipComponent", "PLAYER_SHIP_COMPONENT", true)]

    //  class static PlayerShipHealthUpdatedEventComponent playerShipHealthUpdatedEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"playerShipHealthUpdatedEventComponent", "PLAYER_SHIP_HEALTH_UPDATED_EVENT_COMPONENT", true)]

    //  class static PlayerSleepingComponent playerSleepingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"playerSleepingComponent", "PLAYER_SLEEPING_COMPONENT", true)]

    //  class static PreviouslyRollingComponent previouslyRollingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"previouslyRollingComponent", "PREVIOUSLY_ROLLING_COMPONENT", true)]

    //  class static PreviouslyRunningComponent previouslyRunningComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"previouslyRunningComponent", "PREVIOUSLY_RUNNING_COMPONENT", true)]

    //  class static ProcessingDestinationRelayComponent processingDestinationRelayComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"processingDestinationRelayComponent", "PROCESSING_DESTINATION_RELAY_COMPONENT", true)]

    //  class static ProjectileCollidableComponent projectileCollidableComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"projectileCollidableComponent", "PROJECTILE_COLLIDABLE_COMPONENT", true)]

    //  class static ProjectileComponent projectileComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"projectileComponent", "PROJECTILE_COMPONENT", true)]

    //  class static PromptAddPlayerEventComponent promptAddPlayerEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"promptAddPlayerEventComponent", "PROMPT_ADD_PLAYER_EVENT_COMPONENT", true)]

    //  class static ProxyDontDestroyOnCutsceneComponent proxyDontDestroyOnCutsceneComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"proxyDontDestroyOnCutsceneComponent", "PROXY_DONT_DESTROY_ON_CUTSCENE_COMPONENT", true)]

    //  class static ProxyTargetAlliesComponent proxyTargetAlliesComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"proxyTargetAlliesComponent", "PROXY_TARGET_ALLIES_COMPONENT", true)]

    //  class static ProxyTargetEnemiesComponent proxyTargetEnemiesComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"proxyTargetEnemiesComponent", "PROXY_TARGET_ENEMIES_COMPONENT", true)]

    //  class static ProxyTargetSelfComponent proxyTargetSelfComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"proxyTargetSelfComponent", "PROXY_TARGET_SELF_COMPONENT", true)]

    //  class static QuestFsmUpdateEveryFrameComponent questFsmUpdateEveryFrameComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"questFsmUpdateEveryFrameComponent", "QUEST_FSM_UPDATE_EVERY_FRAME_COMPONENT", true)]

    //  class static QuestFsmUpdateNextFrameComponent questFsmUpdateNextFrameComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"questFsmUpdateNextFrameComponent", "QUEST_FSM_UPDATE_NEXT_FRAME_COMPONENT", true)]

    //  class static QuestFsmUpdateThisFrameComponent questFsmUpdateThisFrameComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"questFsmUpdateThisFrameComponent", "QUEST_FSM_UPDATE_THIS_FRAME_COMPONENT", true)]

    //  class static RemovePlayerEventComponent removePlayerEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"removePlayerEventComponent", "REMOVE_PLAYER_EVENT_COMPONENT", true)]

    //  class static RespawnPlayersEventComponent respawnPlayersEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"respawnPlayersEventComponent", "RESPAWN_PLAYERS_EVENT_COMPONENT", true)]

    //  class static RevivableComponent revivableComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"revivableComponent", "REVIVABLE_COMPONENT", true)]

    //  class static RollBlockedComponent rollBlockedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"rollBlockedComponent", "ROLL_BLOCKED_COMPONENT", true)]

    //  class static RollingComponent rollingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"rollingComponent", "ROLLING_COMPONENT", true)]

    //  class static SaveParrotDestructibleColliderComponent saveParrotDestructibleColliderComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"saveParrotDestructibleColliderComponent", "SAVE_PARROT_DESTRUCTIBLE_COLLIDER_COMPONENT", true)]

    //  class static SaveStoneInRangeComponent saveStoneInRangeComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"saveStoneInRangeComponent", "SAVE_STONE_IN_RANGE_COMPONENT", true)]

    //  class static SaveStoneUpdateEventComponent saveStoneUpdateEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"saveStoneUpdateEventComponent", "SAVE_STONE_UPDATE_EVENT_COMPONENT", true)]

    //  class static SelfHealingComponent selfHealingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"selfHealingComponent", "SELF_HEALING_COMPONENT", true)]

    //  class static ShieldBlockingComponent shieldBlockingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"shieldBlockingComponent", "SHIELD_BLOCKING_COMPONENT", true)]

    //  class static ShieldReflectiveComponent shieldReflectiveComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"shieldReflectiveComponent", "SHIELD_REFLECTIVE_COMPONENT", true)]

    //  class static ShipComponent shipComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"shipComponent", "SHIP_COMPONENT", true)]

    //  class static ShipEnterBlockedComponent shipEnterBlockedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"shipEnterBlockedComponent", "SHIP_ENTER_BLOCKED_COMPONENT", true)]

    //  class static ShipEnterEventComponent shipEnterEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"shipEnterEventComponent", "SHIP_ENTER_EVENT_COMPONENT", true)]

    //  class static ShipExitEventComponent shipExitEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"shipExitEventComponent", "SHIP_EXIT_EVENT_COMPONENT", true)]

    //  class static ShipInteriorEnterEventComponent shipInteriorEnterEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"shipInteriorEnterEventComponent", "SHIP_INTERIOR_ENTER_EVENT_COMPONENT", true)]

    //  class static ShipSpecialAmmoCapacityUpdatedEventComponent shipSpecialAmmoCapacityUpdatedEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"shipSpecialAmmoCapacityUpdatedEventComponent", "SHIP_SPECIAL_AMMO_CAPACITY_UPDATED_EVENT_COMPONENT", true)]

    //  class static SideScrollingModeComponent sideScrollingModeComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"sideScrollingModeComponent", "SIDE_SCROLLING_MODE_COMPONENT", true)]

    //  class static SpecialAudioPlayComponent specialAudioPlayComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"specialAudioPlayComponent", "SPECIAL_AUDIO_PLAY_COMPONENT", true)]

    //  class static SpellCastBlockedComponent spellCastBlockedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"spellCastBlockedComponent", "SPELL_CAST_BLOCKED_COMPONENT", true)]

    //  class static Spirit spiritComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"spiritComponent", "SPIRIT_COMPONENT", true)]

    //  class static SprintingComponent sprintingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"sprintingComponent", "SPRINTING_COMPONENT", true)]

    //  class static StopAddPlayerEventComponent stopAddPlayerEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"stopAddPlayerEventComponent", "STOP_ADD_PLAYER_EVENT_COMPONENT", true)]

    //  class static StrafeMovementComponent strafeMovementComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"strafeMovementComponent", "STRAFE_MOVEMENT_COMPONENT", true)]

    //  class static SwapWeaponBlockedComponent swapWeaponBlockedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"swapWeaponBlockedComponent", "SWAP_WEAPON_BLOCKED_COMPONENT", true)]

    //  class static TargetGroupComponent targetGroupComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"targetGroupComponent", "TARGET_GROUP_COMPONENT", true)]

    //  class static TrapComponent trapComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"trapComponent", "TRAP_COMPONENT", true)]

    //  class static TriggerableInteractableComponent triggerableInteractableComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"triggerableInteractableComponent", "TRIGGERABLE_INTERACTABLE_COMPONENT", true)]

    //  class static UndamageableUnitComponent undamageableUnitComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"undamageableUnitComponent", "UNDAMAGEABLE_UNIT_COMPONENT", true)]

    //  class static WaterTrait waterTraitComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"waterTraitComponent", "WATER_TRAIT_COMPONENT", true)]

    //  class static Waypoint waypointComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"waypointComponent", "WAYPOINT_COMPONENT", true)]

    //  class static XAxisOnly xAxisOnlyComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"xAxisOnlyComponent", "X_AXIS_ONLY_COMPONENT", true)]

    // class 0x8 Entitas.EntityComponentChanged OnComponentAdded
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentAdded", "ON_COMPONENT_ADDED")]

    // class 0xC Entitas.EntityComponentChanged OnComponentRemoved
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentRemoved", "ON_COMPONENT_REMOVED")]

    // class 0x10 Entitas.EntityComponentReplaced OnComponentReplaced
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentReplaced", "ON_COMPONENT_REPLACED")]

    // class 0x14 Entitas.EntityEvent OnEntityReleased
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityReleased", "ON_ENTITY_RELEASED")]

    // class 0x18 Entitas.EntityEvent OnDestroyEntity
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnDestroyEntity", "ON_DESTROY_ENTITY")]

    // class 0x1C System.Collections.Generic.List<Entitas.IComponent> _componentBuffer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentBuffer", "_COMPONENT_BUFFER")]

    // class 0x20 System.Collections.Generic.List<System.Int32> _indexBuffer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_indexBuffer", "_INDEX_BUFFER")]

    // class 0x24 Entitas.IComponent[] _components
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_components", "_COMPONENTS")]

    // class 0x28 System.Collections.Generic.Stack<Entitas.IComponent>[] _componentPools
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentPools", "_COMPONENT_POOLS")]

    // class 0x2C Entitas.ContextInfo _contextInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_contextInfo", "_CONTEXT_INFO")]

    // interface 0x30 Entitas.IAERC _aerc
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_aerc", "_AERC")]

    // class 0x34 Entitas.IComponent[] _componentsCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentsCache", "_COMPONENTS_CACHE")]

    // class 0x38 System.Int32[] _componentIndicesCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentIndicesCache", "_COMPONENT_INDICES_CACHE")]

    // class 0x3C System.String _toStringCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_toStringCache", "_TO_STRING_CACHE")]

    // class 0x40 System.Text.StringBuilder _toStringBuilder
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_toStringBuilder", "_TO_STRING_BUILDER")]

    // struct 0x44 System.Int32 _creationIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_creationIndex", "_CREATION_INDEX")]

    // struct 0x48 System.Boolean _isEnabled
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"_isEnabled", "_IS_ENABLED")]

    // struct 0x4C System.Int32 _totalComponents
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_totalComponents", "_TOTAL_COMPONENTS")]
    public partial class GameEntity
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GameEntity";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 69, 110, 116, 105, 116, 121];

        //public const uint Const_TypeToken = 0x02000639U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameEntity(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameEntity(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameEntity obj) => obj._ptr;
            public static implicit operator bool(Ptr_GameEntity obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."GameEntity"]
    /// </summary>
    public partial class GameEntity
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void add_OnComponentAdded(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentAdded")]
        ///  extern void ADD_ON_COMPONENT_ADDED (nint value);


        /// <summary>
        ///   System.Void add_OnComponentRemoved(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentRemoved")]
        ///  extern void ADD_ON_COMPONENT_REMOVED (nint value);


        /// <summary>
        ///   System.Void add_OnComponentReplaced(Entitas.EntityComponentReplaced value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentReplaced</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentReplaced")]
        ///  extern void ADD_ON_COMPONENT_REPLACED (nint value);


        /// <summary>
        ///   System.Void add_OnDestroyEntity(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnDestroyEntity")]
        ///  extern void ADD_ON_DESTROY_ENTITY (nint value);


        /// <summary>
        ///   System.Void add_OnEntityReleased(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityReleased")]
        ///  extern void ADD_ON_ENTITY_RELEASED (nint value);


        /// <summary>
        ///   System.Void AddActiveScreenEffectPlayer(ScreenEffectPlayer newValue)
        /// </summary>
        /// <param name="newValue">class ScreenEffectPlayer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddActiveScreenEffectPlayer")]
        ///  extern void ADD_ACTIVE_SCREEN_EFFECT_PLAYER (nint newValue);


        /// <summary>
        ///   System.Void AddActiveWeaponChangedEvent(GameEntity newOwner, Equipment newWeapon)
        /// </summary>
        /// <param name="newOwner">class GameEntity</param>
        /// <param name="newWeapon">class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddActiveWeaponChangedEvent")]
        ///  extern void ADD_ACTIVE_WEAPON_CHANGED_EVENT (nint newOwner, nint newWeapon);


        /// <summary>
        ///   System.Void AddAdvancedStatModifiers(AdvancedStats newValue)
        /// </summary>
        /// <param name="newValue">class AdvancedStats</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAdvancedStatModifiers")]
        ///  extern void ADD_ADVANCED_STAT_MODIFIERS (nint newValue);


        /// <summary>
        ///   System.Void AddAgentDestination(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAgentDestination")]
        ///  extern void ADD_AGENT_DESTINATION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void AddAgentPreviousDestination(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAgentPreviousDestination")]
        ///  extern void ADD_AGENT_PREVIOUS_DESTINATION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void AddAnchorPosOffset(UnityEngine.Vector2 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnchorPosOffset")]
        ///  extern void ADD_ANCHOR_POS_OFFSET (UnityEngine.Vector2 newValue);


        /// <summary>
        ///   System.Void AddAngleOffset(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAngleOffset")]
        ///  extern void ADD_ANGLE_OFFSET (System.Single newValue);


        /// <summary>
        ///   System.Void AddAnimation(UnityEngine.Animation newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Animation</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnimation")]
        ///  extern void ADD_ANIMATION (nint newValue);


        /// <summary>
        ///   System.Void AddAnimationFlags(AnimationFlags newValue)
        /// </summary>
        /// <param name="newValue">enum AnimationFlags</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnimationFlags")]
        ///  extern void ADD_ANIMATION_FLAGS (AnimationFlags newValue);


        /// <summary>
        ///   System.Void AddAnimationProgress(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnimationProgress")]
        ///  extern void ADD_ANIMATION_PROGRESS (System.Single newValue);


        /// <summary>
        ///   System.Void AddAnimator(UnityEngine.Animator newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Animator</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnimator")]
        ///  extern void ADD_ANIMATOR (nint newValue);


        /// <summary>
        ///   System.Void AddAoeColliderType(AoeColliderType newValue)
        /// </summary>
        /// <param name="newValue">enum AoeColliderType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAoeColliderType")]
        ///  extern void ADD_AOE_COLLIDER_TYPE (AoeColliderType newValue);


        /// <summary>
        ///   System.Void AddAoeInfo(AoeInfo newValue)
        /// </summary>
        /// <param name="newValue">class AoeInfo</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAoeInfo")]
        ///  extern void ADD_AOE_INFO (nint newValue);


        /// <summary>
        ///   System.Void AddArtPrefabReference(ArtPrefabReference newValue)
        /// </summary>
        /// <param name="newValue">class ArtPrefabReference</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddArtPrefabReference")]
        ///  extern void ADD_ART_PREFAB_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void AddAttachableFloat(UnityEngine.GameObject newAttachableFloat)
        /// </summary>
        /// <param name="newAttachableFloat">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAttachableFloat")]
        ///  extern void ADD_ATTACHABLE_FLOAT (nint newAttachableFloat);


        /// <summary>
        ///   System.Void AddAttachedVfxTracker(System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAttachedVfxTracker")]
        ///  extern void ADD_ATTACHED_VFX_TRACKER (nint newValue);


        /// <summary>
        ///   System.Void AddAttackAnimation(System.Single newPreAttackDuration, System.Single newDuringAttack, System.Single newPostAttackDuration)
        /// </summary>
        /// <param name="newPreAttackDuration">struct System.Single</param>
        /// <param name="newDuringAttack">struct System.Single</param>
        /// <param name="newPostAttackDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAttackAnimation")]
        ///  extern void ADD_ATTACK_ANIMATION (System.Single newPreAttackDuration, System.Single newDuringAttack, System.Single newPostAttackDuration);


        /// <summary>
        ///   System.Void AddAttackCommand(UnityEngine.Vector3 newDirection, System.Single newLifetime, System.Boolean newProcessed)
        /// </summary>
        /// <param name="newDirection">struct UnityEngine.Vector3</param>
        /// <param name="newLifetime">struct System.Single</param>
        /// <param name="newProcessed">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAttackCommand")]
        ///  extern void ADD_ATTACK_COMMAND (UnityEngine.Vector3 newDirection, System.Single newLifetime, System.Boolean newProcessed);


        /// <summary>
        ///   System.Void AddAttackEventInfo(AttackEventInfo newValue)
        /// </summary>
        /// <param name="newValue">class AttackEventInfo</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAttackEventInfo")]
        ///  extern void ADD_ATTACK_EVENT_INFO (nint newValue);


        /// <summary>
        ///   System.Void AddAttackReference(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAttackReference")]
        ///  extern void ADD_ATTACK_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void AddAttackTellView(AttackTellView newValue)
        /// </summary>
        /// <param name="newValue">class AttackTellView</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAttackTellView")]
        ///  extern void ADD_ATTACK_TELL_VIEW (nint newValue);


        /// <summary>
        ///   System.Void AddAttackTint(UnityEngine.Color newColor)
        /// </summary>
        /// <param name="newColor">struct UnityEngine.Color</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAttackTint")]
        ///  extern void ADD_ATTACK_TINT (UnityEngine.Color newColor);


        /// <summary>
        ///   System.Void AddAwardedQuestItems(QuestItemContainer newValue)
        /// </summary>
        /// <param name="newValue">class QuestItemContainer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAwardedQuestItems")]
        ///  extern void ADD_AWARDED_QUEST_ITEMS (nint newValue);


        /// <summary>
        ///   System.Void AddBaseEnemyBehaviour(BaseEnemyBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class BaseEnemyBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBaseEnemyBehaviour")]
        ///  extern void ADD_BASE_ENEMY_BEHAVIOUR (nint newValue);


        /// <summary>
        ///   System.Void AddBehaviourTree(BehaviorDesigner.Runtime.BehaviorTree newValue)
        /// </summary>
        /// <param name="newValue">class BehaviorDesigner.Runtime.BehaviorTree</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBehaviourTree")]
        ///  extern void ADD_BEHAVIOUR_TREE (nint newValue);


        /// <summary>
        ///   System.Void AddBlockEffectCooldown(System.Single newDurationRemaining)
        /// </summary>
        /// <param name="newDurationRemaining">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBlockEffectCooldown")]
        ///  extern void ADD_BLOCK_EFFECT_COOLDOWN (System.Single newDurationRemaining);


        /// <summary>
        ///   System.Void AddBlockFreezeDuration(System.Single newDuration)
        /// </summary>
        /// <param name="newDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBlockFreezeDuration")]
        ///  extern void ADD_BLOCK_FREEZE_DURATION (System.Single newDuration);


        /// <summary>
        ///   System.Void AddBurnCounter(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBurnCounter")]
        ///  extern void ADD_BURN_COUNTER (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddCannonCooldown(System.Single newRegular, System.Single newSpecial, System.Single newRegularCache, System.Single newSpecialCache)
        /// </summary>
        /// <param name="newRegular">struct System.Single</param>
        /// <param name="newSpecial">struct System.Single</param>
        /// <param name="newRegularCache">struct System.Single</param>
        /// <param name="newSpecialCache">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCannonCooldown")]
        ///  extern void ADD_CANNON_COOLDOWN (System.Single newRegular, System.Single newSpecial, System.Single newRegularCache, System.Single newSpecialCache);


        /// <summary>
        ///   System.Void AddCapsule(UnityEngine.Vector3 newLocalPoint0, UnityEngine.Vector3 newLocalPoint1)
        /// </summary>
        /// <param name="newLocalPoint0">struct UnityEngine.Vector3</param>
        /// <param name="newLocalPoint1">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCapsule")]
        ///  extern void ADD_CAPSULE (UnityEngine.Vector3 newLocalPoint0, UnityEngine.Vector3 newLocalPoint1);


        /// <summary>
        ///   System.Void AddCharacterController(UnityEngine.CharacterController newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.CharacterController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCharacterController")]
        ///  extern void ADD_CHARACTER_CONTROLLER (nint newValue);


        /// <summary>
        ///   System.Void AddCharacterGender(CharacterGender newValue)
        /// </summary>
        /// <param name="newValue">enum CharacterGender</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCharacterGender")]
        ///  extern void ADD_CHARACTER_GENDER (CharacterGender newValue);


        /// <summary>
        ///   System.Void AddChargeConfig(ChargeConfig newValue)
        /// </summary>
        /// <param name="newValue">class ChargeConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddChargeConfig")]
        ///  extern void ADD_CHARGE_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void AddChest(ChestBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class ChestBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddChest")]
        ///  extern void ADD_CHEST (nint newValue);


        /// <summary>
        ///   System.Void AddChestInteractor(GameEntity newEntity)
        /// </summary>
        /// <param name="newEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddChestInteractor")]
        ///  extern void ADD_CHEST_INTERACTOR (nint newEntity);


        /// <summary>
        ///   System.Void AddCollatedAoeAttacks(System.Collections.Generic.Dictionary<DealCollatedAoeDamageEffect,System.Int32> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.Dictionary<DealCollatedAoeDamageEffect,System.Int32></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCollatedAoeAttacks")]
        ///  extern void ADD_COLLATED_AOE_ATTACKS (nint newValue);


        /// <summary>
        ///   System.Void AddCollectibleCollectedEvent(UnityEngine.Transform newTarget, System.Int32 newValue, DamageTextAnimation newTextAnimationData)
        /// </summary>
        /// <param name="newTarget">class UnityEngine.Transform</param>
        /// <param name="newValue">struct System.Int32</param>
        /// <param name="newTextAnimationData">class DamageTextAnimation</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCollectibleCollectedEvent")]
        ///  extern void ADD_COLLECTIBLE_COLLECTED_EVENT (nint newTarget, System.Int32 newValue, nint newTextAnimationData);


        /// <summary>
        ///   System.Void AddCollectibleReference(CollectibleBase newValue)
        /// </summary>
        /// <param name="newValue">abstract class CollectibleBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCollectibleReference")]
        ///  extern void ADD_COLLECTIBLE_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void AddCollider(UnityEngine.Collider newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Collider</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCollider")]
        ///  extern void ADD_COLLIDER (nint newValue);


        /// <summary>
        ///   System.Void AddCombatAgent(CombatAgent newValue)
        /// </summary>
        /// <param name="newValue">class CombatAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCombatAgent")]
        ///  extern void ADD_COMBAT_AGENT (nint newValue);


        /// <summary>
        ///   System.Void AddCombatAgentHealthUpdatedEvent(CombatAgent newCombatAgent)
        /// </summary>
        /// <param name="newCombatAgent">class CombatAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCombatAgentHealthUpdatedEvent")]
        ///  extern void ADD_COMBAT_AGENT_HEALTH_UPDATED_EVENT (nint newCombatAgent);


        /// <summary>
        ///   System.Void AddCombatAgentList(System.Collections.Generic.List<CombatAgent> newList)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<CombatAgent></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCombatAgentList")]
        ///  extern void ADD_COMBAT_AGENT_LIST (nint newList);


        /// <summary>
        ///   System.Void AddCombatAggroDuration(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCombatAggroDuration")]
        ///  extern void ADD_COMBAT_AGGRO_DURATION (System.Single newValue);


        /// <summary>
        ///   System.Void AddCombatLog(CombatLog newValue)
        /// </summary>
        /// <param name="newValue">class CombatLog</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCombatLog")]
        ///  extern void ADD_COMBAT_LOG (nint newValue);


        /// <summary>
        ///   System.Void AddCombatProxyAgent(GameEntity newSourceEntity, CombatProxyAgent newValue)
        /// </summary>
        /// <param name="newSourceEntity">class GameEntity</param>
        /// <param name="newValue">class CombatProxyAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCombatProxyAgent")]
        ///  extern void ADD_COMBAT_PROXY_AGENT (nint newSourceEntity, nint newValue);


        /// <summary>
        ///   System.Void AddComponent(System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddComponent")]
        ///  extern void ADD_COMPONENT (System.Int32 index, nint component);


        /// <summary>
        ///   System.Void AddCurrentChargerAttackEntities(System.Collections.Generic.Dictionary<GameEntity,System.Single> newDictionary)
        /// </summary>
        /// <param name="newDictionary">class System.Collections.Generic.Dictionary<GameEntity,System.Single></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCurrentChargerAttackEntities")]
        ///  extern void ADD_CURRENT_CHARGER_ATTACK_ENTITIES (nint newDictionary);


        /// <summary>
        ///   System.Void AddCurrentProjectileHitEntities(System.Collections.Generic.List<GameEntity> newList, System.Collections.Generic.List<System.Single> newTickTime)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newTickTime">class System.Collections.Generic.List<System.Single></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCurrentProjectileHitEntities")]
        ///  extern void ADD_CURRENT_PROJECTILE_HIT_ENTITIES (nint newList, nint newTickTime);


        /// <summary>
        ///   System.Void AddCurrentSensorRadius(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCurrentSensorRadius")]
        ///  extern void ADD_CURRENT_SENSOR_RADIUS (System.Single newValue);


        /// <summary>
        ///   System.Void AddCutsceneOwner(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCutsceneOwner")]
        ///  extern void ADD_CUTSCENE_OWNER (nint newValue);


        /// <summary>
        ///   System.Void AddDashAttackCounter(System.Int32 newDoAttackHitCounter)
        /// </summary>
        /// <param name="newDoAttackHitCounter">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDashAttackCounter")]
        ///  extern void ADD_DASH_ATTACK_COUNTER (System.Int32 newDoAttackHitCounter);


        /// <summary>
        ///   System.Void AddDestinationRelay(Sigtrap.Relays.Relay newReachedDestinationEvents)
        /// </summary>
        /// <param name="newReachedDestinationEvents">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDestinationRelay")]
        ///  extern void ADD_DESTINATION_RELAY (nint newReachedDestinationEvents);


        /// <summary>
        ///   System.Void AddDestructibleFX(DestructibleEffectConfig newConfig)
        /// </summary>
        /// <param name="newConfig">class DestructibleEffectConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDestructibleFX")]
        ///  extern void ADD_DESTRUCTIBLE_FX (nint newConfig);


        /// <summary>
        ///   System.Void AddDialogueSpeaker(IDialogueSpeaker newOwner, UIPanelBase newSpeechPanel)
        /// </summary>
        /// <param name="newOwner">interface IDialogueSpeaker</param>
        /// <param name="newSpeechPanel">abstract class UIPanelBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDialogueSpeaker")]
        ///  extern void ADD_DIALOGUE_SPEAKER (nint newOwner, nint newSpeechPanel);


        /// <summary>
        ///   System.Void AddDirection(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDirection")]
        ///  extern void ADD_DIRECTION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void AddDockRepair(DockRepair newValue)
        /// </summary>
        /// <param name="newValue">class DockRepair</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDockRepair")]
        ///  extern void ADD_DOCK_REPAIR (nint newValue);


        /// <summary>
        ///   System.Void AddDockRepairBeacon(GameEntity newOwner, ReviveBeaconBehaviour newValue)
        /// </summary>
        /// <param name="newOwner">class GameEntity</param>
        /// <param name="newValue">class ReviveBeaconBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDockRepairBeacon")]
        ///  extern void ADD_DOCK_REPAIR_BEACON (nint newOwner, nint newValue);


        /// <summary>
        ///   System.Void AddDockRepairOccupantsUpdatedEvent(GameEntity newDockRepair)
        /// </summary>
        /// <param name="newDockRepair">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDockRepairOccupantsUpdatedEvent")]
        ///  extern void ADD_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT (nint newDockRepair);


        /// <summary>
        ///   System.Void AddEnemyShipBehaviour(EnemyShipBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class EnemyShipBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEnemyShipBehaviour")]
        ///  extern void ADD_ENEMY_SHIP_BEHAVIOUR (nint newValue);


        /// <summary>
        ///   System.Void AddEquipItemCommand(System.Int32 newPlayerID, Equipment newTargetEquipment)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newTargetEquipment">class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEquipItemCommand")]
        ///  extern void ADD_EQUIP_ITEM_COMMAND (System.Int32 newPlayerID, nint newTargetEquipment);


        /// <summary>
        ///   System.Void AddEquipment(Equipment newValue)
        /// </summary>
        /// <param name="newValue">class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEquipment")]
        ///  extern void ADD_EQUIPMENT (nint newValue);


        /// <summary>
        ///   System.Void AddEquipmentChangedEvent(GameEntity newOwner, Equipment newEquippedEquipment, Equipment newUnequippedEquipment)
        /// </summary>
        /// <param name="newOwner">class GameEntity</param>
        /// <param name="newEquippedEquipment">class Equipment</param>
        /// <param name="newUnequippedEquipment">class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEquipmentChangedEvent")]
        ///  extern void ADD_EQUIPMENT_CHANGED_EVENT (nint newOwner, nint newEquippedEquipment, nint newUnequippedEquipment);


        /// <summary>
        ///   System.Void AddEquipmentEffects(EquipmentEffects newValue)
        /// </summary>
        /// <param name="newValue">class EquipmentEffects</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEquipmentEffects")]
        ///  extern void ADD_EQUIPMENT_EFFECTS (nint newValue);


        /// <summary>
        ///   System.Void AddEquipmentItemData(ProjectStar.Data.EquipmentItemData newValue)
        /// </summary>
        /// <param name="newValue">class ProjectStar.Data.EquipmentItemData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEquipmentItemData")]
        ///  extern void ADD_EQUIPMENT_ITEM_DATA (nint newValue);


        /// <summary>
        ///   System.Void AddEquippedItems(EquippedItems newValue)
        /// </summary>
        /// <param name="newValue">class EquippedItems</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEquippedItems")]
        ///  extern void ADD_EQUIPPED_ITEMS (nint newValue);


        /// <summary>
        ///   System.Void AddEquippedPlayerShipSpells(EquippedSpells newValue)
        /// </summary>
        /// <param name="newValue">class EquippedSpells</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEquippedPlayerShipSpells")]
        ///  extern void ADD_EQUIPPED_PLAYER_SHIP_SPELLS (nint newValue);


        /// <summary>
        ///   System.Void AddEquippedShipBlueprints(ShipBlueprintCollection newValue)
        /// </summary>
        /// <param name="newValue">class ShipBlueprintCollection</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEquippedShipBlueprints")]
        ///  extern void ADD_EQUIPPED_SHIP_BLUEPRINTS (nint newValue);


        /// <summary>
        ///   System.Void AddEquippedSpells(GameEntity newOwner, EquippedSpells newValue)
        /// </summary>
        /// <param name="newOwner">class GameEntity</param>
        /// <param name="newValue">class EquippedSpells</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEquippedSpells")]
        ///  extern void ADD_EQUIPPED_SPELLS (nint newOwner, nint newValue);


        /// <summary>
        ///   System.Void AddFacing(UnityEngine.Vector3 newValue, System.Boolean newWasFacingRight, System.Boolean newWasFacingBack)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <param name="newWasFacingRight">struct System.Boolean</param>
        /// <param name="newWasFacingBack">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFacing")]
        ///  extern void ADD_FACING (UnityEngine.Vector3 newValue, System.Boolean newWasFacingRight, System.Boolean newWasFacingBack);


        /// <summary>
        ///   System.Void AddFadeDuration(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFadeDuration")]
        ///  extern void ADD_FADE_DURATION (System.Single newValue);


        /// <summary>
        ///   System.Void AddFiringPoint(FiringPoint newValue)
        /// </summary>
        /// <param name="newValue">class FiringPoint</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFiringPoint")]
        ///  extern void ADD_FIRING_POINT (nint newValue);


        /// <summary>
        ///   System.Void AddFloatTransitionEvent(FloatTransitionType newTransitionType)
        /// </summary>
        /// <param name="newTransitionType">enum FloatTransitionType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFloatTransitionEvent")]
        ///  extern void ADD_FLOAT_TRANSITION_EVENT (FloatTransitionType newTransitionType);


        /// <summary>
        ///   System.Void AddFoam(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFoam")]
        ///  extern void ADD_FOAM (nint newValue);


        /// <summary>
        ///   System.Void AddGameDifficulty(SaveGameDifficulty newValue)
        /// </summary>
        /// <param name="newValue">enum SaveGameDifficulty</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameDifficulty")]
        ///  extern void ADD_GAME_DIFFICULTY (SaveGameDifficulty newValue);


        /// <summary>
        ///   System.Void AddGameDifficultyDamageModifier(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameDifficultyDamageModifier")]
        ///  extern void ADD_GAME_DIFFICULTY_DAMAGE_MODIFIER (System.Single newValue);


        /// <summary>
        ///   System.Void AddGameDifficultyHeathModifier(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameDifficultyHeathModifier")]
        ///  extern void ADD_GAME_DIFFICULTY_HEATH_MODIFIER (System.Single newValue);


        /// <summary>
        ///   System.Void AddGameEntityId(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameEntityId")]
        ///  extern void ADD_GAME_ENTITY_ID (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddGameOverEvent(System.Single newElapsed)
        /// </summary>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameOverEvent")]
        ///  extern void ADD_GAME_OVER_EVENT (System.Single newElapsed);


        /// <summary>
        ///   System.Void AddGameOverNoSaveOverride(PortalID newTargetPortal, GameOverOverrideFlags newGameOverOverrideFlags)
        /// </summary>
        /// <param name="newTargetPortal">class PortalID</param>
        /// <param name="newGameOverOverrideFlags">enum GameOverOverrideFlags</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameOverNoSaveOverride")]
        ///  extern void ADD_GAME_OVER_NO_SAVE_OVERRIDE (nint newTargetPortal, GameOverOverrideFlags newGameOverOverrideFlags);


        /// <summary>
        ///   System.Void AddGraphicObjContainer(UnityEngine.GameObject newGraphic)
        /// </summary>
        /// <param name="newGraphic">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGraphicObjContainer")]
        ///  extern void ADD_GRAPHIC_OBJ_CONTAINER (nint newGraphic);


        /// <summary>
        ///   System.Void AddGunAmmo(ValueGauge newValue, System.Int32 newSpecialAmmoCount)
        /// </summary>
        /// <param name="newValue">class ValueGauge</param>
        /// <param name="newSpecialAmmoCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGunAmmo")]
        ///  extern void ADD_GUN_AMMO (nint newValue, System.Int32 newSpecialAmmoCount);


        /// <summary>
        ///   System.Void AddGunReload(System.Single newBulletReloadDuration, System.Single newClipReloadDuration, System.Single newStartDelayDuration)
        /// </summary>
        /// <param name="newBulletReloadDuration">struct System.Single</param>
        /// <param name="newClipReloadDuration">struct System.Single</param>
        /// <param name="newStartDelayDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGunReload")]
        ///  extern void ADD_GUN_RELOAD (System.Single newBulletReloadDuration, System.Single newClipReloadDuration, System.Single newStartDelayDuration);


        /// <summary>
        ///   System.Void AddGunReloadProgress(System.Single newProgress)
        /// </summary>
        /// <param name="newProgress">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGunReloadProgress")]
        ///  extern void ADD_GUN_RELOAD_PROGRESS (System.Single newProgress);


        /// <summary>
        ///   System.Void AddGunReloadTimer(System.Single newTimeElapsed, System.Single newStartDelay, System.Single newTimeDestination, GunReloadStatus newReloadStatus, System.Action newCallback, System.Single newPauseDuration, System.Int32 newCurrReloadingGunMaxAmmo)
        /// </summary>
        /// <param name="newTimeElapsed">struct System.Single</param>
        /// <param name="newStartDelay">struct System.Single</param>
        /// <param name="newTimeDestination">struct System.Single</param>
        /// <param name="newReloadStatus">enum GunReloadStatus</param>
        /// <param name="newCallback">class System.Action</param>
        /// <param name="newPauseDuration">struct System.Single</param>
        /// <param name="newCurrReloadingGunMaxAmmo">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGunReloadTimer")]
        ///  extern void ADD_GUN_RELOAD_TIMER (System.Single newTimeElapsed, System.Single newStartDelay, System.Single newTimeDestination, GunReloadStatus newReloadStatus, nint newCallback, System.Single newPauseDuration, System.Int32 newCurrReloadingGunMaxAmmo);


        /// <summary>
        ///   System.Void AddHealCompletedEvent(GameEntity newHealer)
        /// </summary>
        /// <param name="newHealer">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHealCompletedEvent")]
        ///  extern void ADD_HEAL_COMPLETED_EVENT (nint newHealer);


        /// <summary>
        ///   System.Void AddHealer(System.Single newHealFactor, System.Int32 newHealFixedValue, System.Single newHealInterval, System.Boolean newIsHealing)
        /// </summary>
        /// <param name="newHealFactor">struct System.Single</param>
        /// <param name="newHealFixedValue">struct System.Int32</param>
        /// <param name="newHealInterval">struct System.Single</param>
        /// <param name="newIsHealing">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHealer")]
        ///  extern void ADD_HEALER (System.Single newHealFactor, System.Int32 newHealFixedValue, System.Single newHealInterval, System.Boolean newIsHealing);


        /// <summary>
        ///   System.Void AddHealStartedEvent(GameEntity newHealer)
        /// </summary>
        /// <param name="newHealer">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHealStartedEvent")]
        ///  extern void ADD_HEAL_STARTED_EVENT (nint newHealer);


        /// <summary>
        ///   System.Void AddHealth(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHealth")]
        ///  extern void ADD_HEALTH (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddHealthRegenTickCounter(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHealthRegenTickCounter")]
        ///  extern void ADD_HEALTH_REGEN_TICK_COUNTER (System.Single newValue);


        /// <summary>
        ///   System.Void AddHealthStat(Gentlebros.IntStat newStat)
        /// </summary>
        /// <param name="newStat">class Gentlebros.IntStat</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHealthStat")]
        ///  extern void ADD_HEALTH_STAT (nint newStat);


        /// <summary>
        ///   System.Void AddHitStop(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHitStop")]
        ///  extern void ADD_HIT_STOP (System.Single newValue);


        /// <summary>
        ///   System.Void AddHitStopEvent(UnityEngine.GameObject newTarget)
        /// </summary>
        /// <param name="newTarget">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHitStopEvent")]
        ///  extern void ADD_HIT_STOP_EVENT (nint newTarget);


        /// <summary>
        ///   System.Void AddId(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddId")]
        ///  extern void ADD_ID (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddIFrame(System.Single newDurationRemaining)
        /// </summary>
        /// <param name="newDurationRemaining">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddIFrame")]
        ///  extern void ADD_I_FRAME (System.Single newDurationRemaining);


        /// <summary>
        ///   System.Void AddInfinityTowerTimer(System.Single newSecondsRemaining, System.Single newSecondsTotal, System.Boolean newPaused)
        /// </summary>
        /// <param name="newSecondsRemaining">struct System.Single</param>
        /// <param name="newSecondsTotal">struct System.Single</param>
        /// <param name="newPaused">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInfinityTowerTimer")]
        ///  extern void ADD_INFINITY_TOWER_TIMER (System.Single newSecondsRemaining, System.Single newSecondsTotal, System.Boolean newPaused);


        /// <summary>
        ///   System.Void AddInHealRegion(GameEntity newHealer)
        /// </summary>
        /// <param name="newHealer">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInHealRegion")]
        ///  extern void ADD_IN_HEAL_REGION (nint newHealer);


        /// <summary>
        ///   System.Void AddInitialDirection(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInitialDirection")]
        ///  extern void ADD_INITIAL_DIRECTION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void AddInitialPosition(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInitialPosition")]
        ///  extern void ADD_INITIAL_POSITION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void AddInPotentialHealRegion(GameEntity newHealer)
        /// </summary>
        /// <param name="newHealer">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInPotentialHealRegion")]
        ///  extern void ADD_IN_POTENTIAL_HEAL_REGION (nint newHealer);


        /// <summary>
        ///   System.Void AddInputStateCommand(InputStateCommand newValue, System.Nullable<InputState> newState)
        /// </summary>
        /// <param name="newValue">enum InputStateCommand</param>
        /// <param name="newState">struct System.Nullable<InputState></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInputStateCommand")]
        ///  extern void ADD_INPUT_STATE_COMMAND (InputStateCommand newValue, System.Nullable<InputState> newState);


        /// <summary>
        ///   System.Void AddInstancePortal(InstancePortalBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class InstancePortalBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInstancePortal")]
        ///  extern void ADD_INSTANCE_PORTAL (nint newValue);


        /// <summary>
        ///   System.Void AddIntCounter(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddIntCounter")]
        ///  extern void ADD_INT_COUNTER (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddInteractable(System.Boolean newEnabledState, InteractableBehaviour newValue)
        /// </summary>
        /// <param name="newEnabledState">struct System.Boolean</param>
        /// <param name="newValue">abstract class InteractableBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInteractable")]
        ///  extern void ADD_INTERACTABLE (System.Boolean newEnabledState, nint newValue);


        /// <summary>
        ///   System.Void AddInteractableFailInteractableEvent(GameEntity newInteractableEntity, BaseInteractionCondition newFailedCondition)
        /// </summary>
        /// <param name="newInteractableEntity">class GameEntity</param>
        /// <param name="newFailedCondition">abstract class BaseInteractionCondition</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInteractableFailInteractableEvent")]
        ///  extern void ADD_INTERACTABLE_FAIL_INTERACTABLE_EVENT (nint newInteractableEntity, nint newFailedCondition);


        /// <summary>
        ///   System.Void AddInteractableFailValidateEvent(GameEntity newInteractableEntity, BaseInteractionCondition newFailedCondition)
        /// </summary>
        /// <param name="newInteractableEntity">class GameEntity</param>
        /// <param name="newFailedCondition">abstract class BaseInteractionCondition</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInteractableFailValidateEvent")]
        ///  extern void ADD_INTERACTABLE_FAIL_VALIDATE_EVENT (nint newInteractableEntity, nint newFailedCondition);


        /// <summary>
        ///   System.Void AddInteractableStatus(System.Boolean newTriggered, System.Collections.Generic.HashSet<GameEntity> newTriggeredTargetEntities, InteractableAcceptDenyState newState, System.Boolean newSuccessfulInteraction)
        /// </summary>
        /// <param name="newTriggered">struct System.Boolean</param>
        /// <param name="newTriggeredTargetEntities">class System.Collections.Generic.HashSet<GameEntity></param>
        /// <param name="newState">enum InteractableAcceptDenyState</param>
        /// <param name="newSuccessfulInteraction">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInteractableStatus")]
        ///  extern void ADD_INTERACTABLE_STATUS (System.Boolean newTriggered, nint newTriggeredTargetEntities, InteractableAcceptDenyState newState, System.Boolean newSuccessfulInteraction);


        /// <summary>
        ///   System.Void AddInteractableStatusUpdatedEvent(GameEntity newInteractableOwnerEntity, InteractableAcceptDenyState newPrevState, InteractableAcceptDenyState newCurrState)
        /// </summary>
        /// <param name="newInteractableOwnerEntity">class GameEntity</param>
        /// <param name="newPrevState">enum InteractableAcceptDenyState</param>
        /// <param name="newCurrState">enum InteractableAcceptDenyState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInteractableStatusUpdatedEvent")]
        ///  extern void ADD_INTERACTABLE_STATUS_UPDATED_EVENT (nint newInteractableOwnerEntity, InteractableAcceptDenyState newPrevState, InteractableAcceptDenyState newCurrState);


        /// <summary>
        ///   System.Void AddInteractableTriggeredTargetEntitiesUpdatedEvent(GameEntity newInteractableEntity, GameEntity newInteractorEntity)
        /// </summary>
        /// <param name="newInteractableEntity">class GameEntity</param>
        /// <param name="newInteractorEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInteractableTriggeredTargetEntitiesUpdatedEvent")]
        ///  extern void ADD_INTERACTABLE_TRIGGERED_TARGET_ENTITIES_UPDATED_EVENT (nint newInteractableEntity, nint newInteractorEntity);


        /// <summary>
        ///   System.Void AddInteractCommand(System.Single newLifetime, System.Boolean newProcessed, PressMode newPressMode, System.Int32 newInputActionID)
        /// </summary>
        /// <param name="newLifetime">struct System.Single</param>
        /// <param name="newProcessed">struct System.Boolean</param>
        /// <param name="newPressMode">enum PressMode</param>
        /// <param name="newInputActionID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInteractCommand")]
        ///  extern void ADD_INTERACT_COMMAND (System.Single newLifetime, System.Boolean newProcessed, PressMode newPressMode, System.Int32 newInputActionID);


        /// <summary>
        ///   System.Void AddInteractCommandUpdate(System.Int32 newPlayerID, System.Single newCompletionParam, System.Single newTimeHeld, System.Boolean newIsValid)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newCompletionParam">struct System.Single</param>
        /// <param name="newTimeHeld">struct System.Single</param>
        /// <param name="newIsValid">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInteractCommandUpdate")]
        ///  extern void ADD_INTERACT_COMMAND_UPDATE (System.Int32 newPlayerID, System.Single newCompletionParam, System.Single newTimeHeld, System.Boolean newIsValid);


        /// <summary>
        ///   System.Void AddInteractLookAt(UnityEngine.Transform newLookAtTarget, UnityEngine.Transform newSecondaryLookAtTarget, System.Single newViewAngle, System.Collections.Generic.List<UnityEngine.Transform> newPotentialTargets)
        /// </summary>
        /// <param name="newLookAtTarget">class UnityEngine.Transform</param>
        /// <param name="newSecondaryLookAtTarget">class UnityEngine.Transform</param>
        /// <param name="newViewAngle">struct System.Single</param>
        /// <param name="newPotentialTargets">class System.Collections.Generic.List<UnityEngine.Transform></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInteractLookAt")]
        ///  extern void ADD_INTERACT_LOOK_AT (nint newLookAtTarget, nint newSecondaryLookAtTarget, System.Single newViewAngle, nint newPotentialTargets);


        /// <summary>
        ///   System.Void AddInventoryCommand(InventoryCommand newValue)
        /// </summary>
        /// <param name="newValue">enum InventoryCommand</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInventoryCommand")]
        ///  extern void ADD_INVENTORY_COMMAND (InventoryCommand newValue);


        /// <summary>
        ///   System.Void AddInventoryLevel(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInventoryLevel")]
        ///  extern void ADD_INVENTORY_LEVEL (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddInventorySpellInfo(SpellConfigBase newSpellConfig)
        /// </summary>
        /// <param name="newSpellConfig">abstract class SpellConfigBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInventorySpellInfo")]
        ///  extern void ADD_INVENTORY_SPELL_INFO (nint newSpellConfig);


        /// <summary>
        ///   System.Void AddInvisibleWall(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInvisibleWall")]
        ///  extern void ADD_INVISIBLE_WALL (nint newValue);


        /// <summary>
        ///   System.Void AddinWall(UnityEngine.Transform[] newTransform)
        /// </summary>
        /// <param name="newTransform">class UnityEngine.Transform[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddinWall")]
        ///  extern void ADDIN_WALL (nint newTransform);


        /// <summary>
        ///   System.Void AddKnockbackMultiplier(System.Single newMultiplier)
        /// </summary>
        /// <param name="newMultiplier">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddKnockbackMultiplier")]
        ///  extern void ADD_KNOCKBACK_MULTIPLIER (System.Single newMultiplier);


        /// <summary>
        ///   System.Void AddLastSeenDuration(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLastSeenDuration")]
        ///  extern void ADD_LAST_SEEN_DURATION (System.Single newValue);


        /// <summary>
        ///   System.Void AddLatestInfinityTowerClearedWave(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLatestInfinityTowerClearedWave")]
        ///  extern void ADD_LATEST_INFINITY_TOWER_CLEARED_WAVE (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddLifetime(System.Single newValue, System.Single newElapsed)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLifetime")]
        ///  extern void ADD_LIFETIME (System.Single newValue, System.Single newElapsed);


        /// <summary>
        ///   System.Void AddLifetimeTarget(UnityEngine.GameObject newValue, System.Single newFlickerElapsed, System.Single newFlickerInterval)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <param name="newFlickerElapsed">struct System.Single</param>
        /// <param name="newFlickerInterval">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLifetimeTarget")]
        ///  extern void ADD_LIFETIME_TARGET (nint newValue, System.Single newFlickerElapsed, System.Single newFlickerInterval);


        /// <summary>
        ///   System.Void AddLocationData(UnityEngine.Vector3 newLocation, LocationData newLocationData)
        /// </summary>
        /// <param name="newLocation">struct UnityEngine.Vector3</param>
        /// <param name="newLocationData">class LocationData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLocationData")]
        ///  extern void ADD_LOCATION_DATA (UnityEngine.Vector3 newLocation, nint newLocationData);


        /// <summary>
        ///   System.Void AddLootDropLevel(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLootDropLevel")]
        ///  extern void ADD_LOOT_DROP_LEVEL (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddLootMagnet(UnityEngine.Collider newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Collider</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLootMagnet")]
        ///  extern void ADD_LOOT_MAGNET (nint newValue);


        /// <summary>
        ///   System.Void AddLootMultiplier(System.Int32 newQuantityMultiplier, System.Single newValueMultiplier)
        /// </summary>
        /// <param name="newQuantityMultiplier">struct System.Int32</param>
        /// <param name="newValueMultiplier">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLootMultiplier")]
        ///  extern void ADD_LOOT_MULTIPLIER (System.Int32 newQuantityMultiplier, System.Single newValueMultiplier);


        /// <summary>
        ///   System.Void AddLootTable(LootTable newValue)
        /// </summary>
        /// <param name="newValue">class LootTable</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLootTable")]
        ///  extern void ADD_LOOT_TABLE (nint newValue);


        /// <summary>
        ///   System.Void AddLootTimer(System.Int32 newCurrIndex, System.Single newElapsed, System.Single newGoal)
        /// </summary>
        /// <param name="newCurrIndex">struct System.Int32</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <param name="newGoal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLootTimer")]
        ///  extern void ADD_LOOT_TIMER (System.Int32 newCurrIndex, System.Single newElapsed, System.Single newGoal);


        /// <summary>
        ///   System.Void AddMagicStat(Gentlebros.IntStat newStat)
        /// </summary>
        /// <param name="newStat">class Gentlebros.IntStat</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMagicStat")]
        ///  extern void ADD_MAGIC_STAT (nint newStat);


        /// <summary>
        ///   System.Void AddMainSprite(UnityEngine.GameObject newMain, UnityEngine.GameObject newMain_Back)
        /// </summary>
        /// <param name="newMain">class UnityEngine.GameObject</param>
        /// <param name="newMain_Back">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMainSprite")]
        ///  extern void ADD_MAIN_SPRITE (nint newMain, nint newMain_Back);


        /// <summary>
        ///   System.Void AddMana(ValueGauge newValue)
        /// </summary>
        /// <param name="newValue">class ValueGauge</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMana")]
        ///  extern void ADD_MANA (nint newValue);


        /// <summary>
        ///   System.Void AddManaBar(ManaBarBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class ManaBarBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddManaBar")]
        ///  extern void ADD_MANA_BAR (nint newValue);


        /// <summary>
        ///   System.Void AddMapIconDisplayLink(MapIconType newDisplayType, GameEntity newOwner)
        /// </summary>
        /// <param name="newDisplayType">enum MapIconType</param>
        /// <param name="newOwner">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapIconDisplayLink")]
        ///  extern void ADD_MAP_ICON_DISPLAY_LINK (MapIconType newDisplayType, nint newOwner);


        /// <summary>
        ///   System.Void AddMapMarkerWorld(MapMarkerWorldBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class MapMarkerWorldBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapMarkerWorld")]
        ///  extern void ADD_MAP_MARKER_WORLD (nint newValue);


        /// <summary>
        ///   System.Void AddMapMarkerWorldIndex(System.Int32 newIndex)
        /// </summary>
        /// <param name="newIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapMarkerWorldIndex")]
        ///  extern void ADD_MAP_MARKER_WORLD_INDEX (System.Int32 newIndex);


        /// <summary>
        ///   System.Void AddMaxMoveSpeed(System.Single newCurrent, System.Single newActual, System.Single newOriginal)
        /// </summary>
        /// <param name="newCurrent">struct System.Single</param>
        /// <param name="newActual">struct System.Single</param>
        /// <param name="newOriginal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMaxMoveSpeed")]
        ///  extern void ADD_MAX_MOVE_SPEED (System.Single newCurrent, System.Single newActual, System.Single newOriginal);


        /// <summary>
        ///   System.Void AddMeleeAttackCommand(UnitMainAttackConfig newConfig)
        /// </summary>
        /// <param name="newConfig">class UnitMainAttackConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMeleeAttackCommand")]
        ///  extern void ADD_MELEE_ATTACK_COMMAND (nint newConfig);


        /// <summary>
        ///   System.Void AddMonsterBehaviour(MonsterBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class MonsterBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMonsterBehaviour")]
        ///  extern void ADD_MONSTER_BEHAVIOUR (nint newValue);


        /// <summary>
        ///   System.Void AddMonsterDetector(MonsterDetectorBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class MonsterDetectorBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMonsterDetector")]
        ///  extern void ADD_MONSTER_DETECTOR (nint newValue);


        /// <summary>
        ///   System.Void AddMonsterDetectorInfo(UnitConfig newTargetUnit, System.Int32 newRequiredCount, System.Single newDetectionRadius, System.Single newDetectionDuration)
        /// </summary>
        /// <param name="newTargetUnit">class UnitConfig</param>
        /// <param name="newRequiredCount">struct System.Int32</param>
        /// <param name="newDetectionRadius">struct System.Single</param>
        /// <param name="newDetectionDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMonsterDetectorInfo")]
        ///  extern void ADD_MONSTER_DETECTOR_INFO (nint newTargetUnit, System.Int32 newRequiredCount, System.Single newDetectionRadius, System.Single newDetectionDuration);


        /// <summary>
        ///   System.Void AddMonsterDetectorRequestor(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMonsterDetectorRequestor")]
        ///  extern void ADD_MONSTER_DETECTOR_REQUESTOR (nint newValue);


        /// <summary>
        ///   System.Void AddMonsterDetectorResultInfo(System.Collections.Generic.HashSet<GameEntity> newPrevDetectedMonsters, System.Collections.Generic.HashSet<GameEntity> newDetectedMonsters)
        /// </summary>
        /// <param name="newPrevDetectedMonsters">class System.Collections.Generic.HashSet<GameEntity></param>
        /// <param name="newDetectedMonsters">class System.Collections.Generic.HashSet<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMonsterDetectorResultInfo")]
        ///  extern void ADD_MONSTER_DETECTOR_RESULT_INFO (nint newPrevDetectedMonsters, nint newDetectedMonsters);


        /// <summary>
        ///   System.Void AddMonsterTrait(MonsterTraitsTypes newTraits)
        /// </summary>
        /// <param name="newTraits">enum MonsterTraitsTypes</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMonsterTrait")]
        ///  extern void ADD_MONSTER_TRAIT (MonsterTraitsTypes newTraits);


        /// <summary>
        ///   System.Void AddMoveSpeed(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMoveSpeed")]
        ///  extern void ADD_MOVE_SPEED (System.Single newValue);


        /// <summary>
        ///   System.Void AddNavAgentTarget(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddNavAgentTarget")]
        ///  extern void ADD_NAV_AGENT_TARGET (nint newValue);


        /// <summary>
        ///   System.Void AddNavMeshAgent(UnityEngine.AI.NavMeshAgent newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.AI.NavMeshAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddNavMeshAgent")]
        ///  extern void ADD_NAV_MESH_AGENT (nint newValue);


        /// <summary>
        ///   System.Void AddNavPath(UnityEngine.AI.NavMeshPath newPath, System.Int32 newCurrPoint)
        /// </summary>
        /// <param name="newPath">class UnityEngine.AI.NavMeshPath</param>
        /// <param name="newCurrPoint">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddNavPath")]
        ///  extern void ADD_NAV_PATH (nint newPath, System.Int32 newCurrPoint);


        /// <summary>
        ///   System.Void AddObjectiveInteractor(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddObjectiveInteractor")]
        ///  extern void ADD_OBJECTIVE_INTERACTOR (nint newValue);


        /// <summary>
        ///   System.Void AddOnDeathAnimCompleteEvent(Sigtrap.Relays.Relay newValue)
        /// </summary>
        /// <param name="newValue">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOnDeathAnimCompleteEvent")]
        ///  extern void ADD_ON_DEATH_ANIM_COMPLETE_EVENT (nint newValue);


        /// <summary>
        ///   System.Void AddOnDeathEvent(Sigtrap.Relays.Relay newValue)
        /// </summary>
        /// <param name="newValue">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOnDeathEvent")]
        ///  extern void ADD_ON_DEATH_EVENT (nint newValue);


        /// <summary>
        ///   System.Void AddOnHitIFrameData(System.Single newIFrameDuration)
        /// </summary>
        /// <param name="newIFrameDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOnHitIFrameData")]
        ///  extern void ADD_ON_HIT_I_FRAME_DATA (System.Single newIFrameDuration);


        /// <summary>
        ///   System.Void AddOnReviveCallback(Sigtrap.Relays.Relay newValue)
        /// </summary>
        /// <param name="newValue">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOnReviveCallback")]
        ///  extern void ADD_ON_REVIVE_CALLBACK (nint newValue);


        /// <summary>
        ///   System.Void AddOriginalLocalScale(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOriginalLocalScale")]
        ///  extern void ADD_ORIGINAL_LOCAL_SCALE (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void AddOverlapList(System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOverlapList")]
        ///  extern void ADD_OVERLAP_LIST (nint newList);


        /// <summary>
        ///   System.Void AddOverrideCharacterGender(System.Int32 newPlayerId, CharacterGender newValue)
        /// </summary>
        /// <param name="newPlayerId">struct System.Int32</param>
        /// <param name="newValue">enum CharacterGender</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOverrideCharacterGender")]
        ///  extern void ADD_OVERRIDE_CHARACTER_GENDER (System.Int32 newPlayerId, CharacterGender newValue);


        /// <summary>
        ///   System.Void AddOwner(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOwner")]
        ///  extern void ADD_OWNER (nint newValue);


        /// <summary>
        ///   System.Void AddParticleEffect(UnityEngine.ParticleSystem newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.ParticleSystem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddParticleEffect")]
        ///  extern void ADD_PARTICLE_EFFECT (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerAddedEvent(GameEntity newPlayerAddedEntity)
        /// </summary>
        /// <param name="newPlayerAddedEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerAddedEvent")]
        ///  extern void ADD_PLAYER_ADDED_EVENT (nint newPlayerAddedEntity);


        /// <summary>
        ///   System.Void AddPlayerId(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerId")]
        ///  extern void ADD_PLAYER_ID (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddPlayerIdReference(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerIdReference")]
        ///  extern void ADD_PLAYER_ID_REFERENCE (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddPlayerKilledSource(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerKilledSource")]
        ///  extern void ADD_PLAYER_KILLED_SOURCE (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerReference(System.Collections.Generic.List<GameEntity> newPlayers)
        /// </summary>
        /// <param name="newPlayers">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerReference")]
        ///  extern void ADD_PLAYER_REFERENCE (nint newPlayers);


        /// <summary>
        ///   System.Void AddPlayerRemovedEvent(GameEntity newPlayerRemovedEntity)
        /// </summary>
        /// <param name="newPlayerRemovedEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerRemovedEvent")]
        ///  extern void ADD_PLAYER_REMOVED_EVENT (nint newPlayerRemovedEntity);


        /// <summary>
        ///   System.Void AddPlayerSleepingSaveStone(GameEntity newPlayer)
        /// </summary>
        /// <param name="newPlayer">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerSleepingSaveStone")]
        ///  extern void ADD_PLAYER_SLEEPING_SAVE_STONE (nint newPlayer);


        /// <summary>
        ///   System.Void AddPlayerStat(System.Int32 newLevel, System.Int32 newTrinketSlots)
        /// </summary>
        /// <param name="newLevel">struct System.Int32</param>
        /// <param name="newTrinketSlots">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerStat")]
        ///  extern void ADD_PLAYER_STAT (System.Int32 newLevel, System.Int32 newTrinketSlots);


        /// <summary>
        ///   System.Void AddPlayerVicinity(System.Int32 newPlayerID, GameEntity newValue)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerVicinity")]
        ///  extern void ADD_PLAYER_VICINITY (System.Int32 newPlayerID, nint newValue);


        /// <summary>
        ///   System.Void AddPoolStatusTable(System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPoolStatusTable")]
        ///  extern void ADD_POOL_STATUS_TABLE (nint newValue);


        /// <summary>
        ///   System.Void AddPosition(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPosition")]
        ///  extern void ADD_POSITION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void AddPositionAttach(UnityEngine.Transform newTarget, UnityEngine.Vector3 newOffset)
        /// </summary>
        /// <param name="newTarget">class UnityEngine.Transform</param>
        /// <param name="newOffset">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPositionAttach")]
        ///  extern void ADD_POSITION_ATTACH (nint newTarget, UnityEngine.Vector3 newOffset);


        /// <summary>
        ///   System.Void AddPositionHistory(System.Collections.Generic.List<UnityEngine.Vector3> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPositionHistory")]
        ///  extern void ADD_POSITION_HISTORY (nint newValue);


        /// <summary>
        ///   System.Void AddPositionTween(UnityEngine.Vector3 newFrom, UnityEngine.Vector3 newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed, System.Single newDelay, System.Boolean newIsPaused, System.Action newCompleteCallback)
        /// </summary>
        /// <param name="newFrom">struct UnityEngine.Vector3</param>
        /// <param name="newTo">struct UnityEngine.Vector3</param>
        /// <param name="newDuration">struct System.Single</param>
        /// <param name="newEase">enum EasingFunction.Ease</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <param name="newDelay">struct System.Single</param>
        /// <param name="newIsPaused">struct System.Boolean</param>
        /// <param name="newCompleteCallback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPositionTween")]
        ///  extern void ADD_POSITION_TWEEN (UnityEngine.Vector3 newFrom, UnityEngine.Vector3 newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed, System.Single newDelay, System.Boolean newIsPaused, nint newCompleteCallback);


        /// <summary>
        ///   System.Void AddProjectileBehaviour(ProjectileBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class ProjectileBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddProjectileBehaviour")]
        ///  extern void ADD_PROJECTILE_BEHAVIOUR (nint newValue);


        /// <summary>
        ///   System.Void AddProjectileColliderInfo(UnityEngine.SphereCollider newColl, UnityEngine.SphereCollider newObstacleColl)
        /// </summary>
        /// <param name="newColl">class UnityEngine.SphereCollider</param>
        /// <param name="newObstacleColl">class UnityEngine.SphereCollider</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddProjectileColliderInfo")]
        ///  extern void ADD_PROJECTILE_COLLIDER_INFO (nint newColl, nint newObstacleColl);


        /// <summary>
        ///   System.Void AddProjectileInfo(ProjectileInfo newValue)
        /// </summary>
        /// <param name="newValue">class ProjectileInfo</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddProjectileInfo")]
        ///  extern void ADD_PROJECTILE_INFO (nint newValue);


        /// <summary>
        ///   System.Void AddProjectileMovement(System.Single newSpeed, UnityEngine.Vector3 newDirection, ProjectileMovementType newMovementType, UnityEngine.AnimationCurve newSpeedGraph)
        /// </summary>
        /// <param name="newSpeed">struct System.Single</param>
        /// <param name="newDirection">struct UnityEngine.Vector3</param>
        /// <param name="newMovementType">enum ProjectileMovementType</param>
        /// <param name="newSpeedGraph">class UnityEngine.AnimationCurve</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddProjectileMovement")]
        ///  extern void ADD_PROJECTILE_MOVEMENT (System.Single newSpeed, UnityEngine.Vector3 newDirection, ProjectileMovementType newMovementType, nint newSpeedGraph);


        /// <summary>
        ///   System.Void AddProjectileReference(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddProjectileReference")]
        ///  extern void ADD_PROJECTILE_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void AddProjectileVfxReference(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddProjectileVfxReference")]
        ///  extern void ADD_PROJECTILE_VFX_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void AddPromptRemovePlayerEvent(System.Int32 newInitiatorPlayerID)
        /// </summary>
        /// <param name="newInitiatorPlayerID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPromptRemovePlayerEvent")]
        ///  extern void ADD_PROMPT_REMOVE_PLAYER_EVENT (System.Int32 newInitiatorPlayerID);


        /// <summary>
        ///   System.Void AddPuzzleAnswer(PuzzleAnswerData newPuzzleAnswerData, System.Collections.Generic.List<PuzzlePieceID> newLiveAnswers, GameEntity newInitialActivatedPuzzlePiece)
        /// </summary>
        /// <param name="newPuzzleAnswerData">class PuzzleAnswerData</param>
        /// <param name="newLiveAnswers">class System.Collections.Generic.List<PuzzlePieceID></param>
        /// <param name="newInitialActivatedPuzzlePiece">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPuzzleAnswer")]
        ///  extern void ADD_PUZZLE_ANSWER (nint newPuzzleAnswerData, nint newLiveAnswers, nint newInitialActivatedPuzzlePiece);


        /// <summary>
        ///   System.Void AddPuzzleAnswerCompletedEvent(GameEntity newPuzzleAnswerEntity)
        /// </summary>
        /// <param name="newPuzzleAnswerEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPuzzleAnswerCompletedEvent")]
        ///  extern void ADD_PUZZLE_ANSWER_COMPLETED_EVENT (nint newPuzzleAnswerEntity);


        /// <summary>
        ///   System.Void AddPuzzleAnswerState(PuzzleAnswerState newValue)
        /// </summary>
        /// <param name="newValue">enum PuzzleAnswerState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPuzzleAnswerState")]
        ///  extern void ADD_PUZZLE_ANSWER_STATE (PuzzleAnswerState newValue);


        /// <summary>
        ///   System.Void AddPuzzleLootLocation(PuzzleLootLocation newValue, PuzzleAnswerData newAnswerData)
        /// </summary>
        /// <param name="newValue">class PuzzleLootLocation</param>
        /// <param name="newAnswerData">class PuzzleAnswerData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPuzzleLootLocation")]
        ///  extern void ADD_PUZZLE_LOOT_LOCATION (nint newValue, nint newAnswerData);


        /// <summary>
        ///   System.Void AddPuzzlePieceID(PuzzlePieceID newValue)
        /// </summary>
        /// <param name="newValue">class PuzzlePieceID</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPuzzlePieceID")]
        ///  extern void ADD_PUZZLE_PIECE_ID (nint newValue);


        /// <summary>
        ///   System.Void AddPuzzlePieceInteractedCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPuzzlePieceInteractedCount")]
        ///  extern void ADD_PUZZLE_PIECE_INTERACTED_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddPuzzlePieceInteractedEvent(GameEntity newPuzzlePieceEntity)
        /// </summary>
        /// <param name="newPuzzlePieceEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPuzzlePieceInteractedEvent")]
        ///  extern void ADD_PUZZLE_PIECE_INTERACTED_EVENT (nint newPuzzlePieceEntity);


        /// <summary>
        ///   System.Void AddQuestFsm(PlayMakerFSM newValue)
        /// </summary>
        /// <param name="newValue">class PlayMakerFSM</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddQuestFsm")]
        ///  extern void ADD_QUEST_FSM (nint newValue);


        /// <summary>
        ///   System.Void AddRecovery(Gentlebros.FloatStat newStat, System.Single newElapsed, Gentlebros.FloatStat newAggroDelay, Gentlebros.FloatStat newRecoveryAmt)
        /// </summary>
        /// <param name="newStat">class Gentlebros.FloatStat</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <param name="newAggroDelay">class Gentlebros.FloatStat</param>
        /// <param name="newRecoveryAmt">class Gentlebros.FloatStat</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRecovery")]
        ///  extern void ADD_RECOVERY (nint newStat, System.Single newElapsed, nint newAggroDelay, nint newRecoveryAmt);


        /// <summary>
        ///   System.Void AddRendererTinter(RendererTinterBase newValue)
        /// </summary>
        /// <param name="newValue">abstract class RendererTinterBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRendererTinter")]
        ///  extern void ADD_RENDERER_TINTER (nint newValue);


        /// <summary>
        ///   System.Void AddRenderTransform(UnityEngine.Transform newValue, UnityEngine.Vector3 newOriginalScale)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <param name="newOriginalScale">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRenderTransform")]
        ///  extern void ADD_RENDER_TRANSFORM (nint newValue, UnityEngine.Vector3 newOriginalScale);


        /// <summary>
        ///   System.Void AddRestTriggeredEvent(GameEntity newTriggerSource, GameEntity newRestPortal)
        /// </summary>
        /// <param name="newTriggerSource">class GameEntity</param>
        /// <param name="newRestPortal">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRestTriggeredEvent")]
        ///  extern void ADD_REST_TRIGGERED_EVENT (nint newTriggerSource, nint newRestPortal);


        /// <summary>
        ///   System.Void AddReviveBeacon(GameEntity newRevivableEntity, System.Single newCurrentReviveProgress, System.Single newMaxReviveProgress, System.Single newIntervalTimer, System.Boolean newDecaying, System.Boolean newReviving)
        /// </summary>
        /// <param name="newRevivableEntity">class GameEntity</param>
        /// <param name="newCurrentReviveProgress">struct System.Single</param>
        /// <param name="newMaxReviveProgress">struct System.Single</param>
        /// <param name="newIntervalTimer">struct System.Single</param>
        /// <param name="newDecaying">struct System.Boolean</param>
        /// <param name="newReviving">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddReviveBeacon")]
        ///  extern void ADD_REVIVE_BEACON (nint newRevivableEntity, System.Single newCurrentReviveProgress, System.Single newMaxReviveProgress, System.Single newIntervalTimer, System.Boolean newDecaying, System.Boolean newReviving);


        /// <summary>
        ///   System.Void AddReviveBeaconReference(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddReviveBeaconReference")]
        ///  extern void ADD_REVIVE_BEACON_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void AddReviveEvent(GameEntity newEntity)
        /// </summary>
        /// <param name="newEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddReviveEvent")]
        ///  extern void ADD_REVIVE_EVENT (nint newEntity);


        /// <summary>
        ///   System.Void AddRigidbody(UnityEngine.Rigidbody newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Rigidbody</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRigidbody")]
        ///  extern void ADD_RIGIDBODY (nint newValue);


        /// <summary>
        ///   System.Void AddRollCommand(UnityEngine.Vector3 newDirection, System.Single newElapsed, System.Single newLifetime, System.Boolean newProcessed)
        /// </summary>
        /// <param name="newDirection">struct UnityEngine.Vector3</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <param name="newLifetime">struct System.Single</param>
        /// <param name="newProcessed">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRollCommand")]
        ///  extern void ADD_ROLL_COMMAND (UnityEngine.Vector3 newDirection, System.Single newElapsed, System.Single newLifetime, System.Boolean newProcessed);


        /// <summary>
        ///   System.Void AddRollCooldown(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRollCooldown")]
        ///  extern void ADD_ROLL_COOLDOWN (System.Single newValue);


        /// <summary>
        ///   System.Void AddRollCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRollCount")]
        ///  extern void ADD_ROLL_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddRotationTween(UnityEngine.Vector3 newFrom, UnityEngine.Vector3 newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed, System.Single newDelay, System.Boolean newIsPaused, System.Action newCompleteCallback)
        /// </summary>
        /// <param name="newFrom">struct UnityEngine.Vector3</param>
        /// <param name="newTo">struct UnityEngine.Vector3</param>
        /// <param name="newDuration">struct System.Single</param>
        /// <param name="newEase">enum EasingFunction.Ease</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <param name="newDelay">struct System.Single</param>
        /// <param name="newIsPaused">struct System.Boolean</param>
        /// <param name="newCompleteCallback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRotationTween")]
        ///  extern void ADD_ROTATION_TWEEN (UnityEngine.Vector3 newFrom, UnityEngine.Vector3 newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed, System.Single newDelay, System.Boolean newIsPaused, nint newCompleteCallback);


        /// <summary>
        ///   System.Void AddSaveStone(SaveStoneBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class SaveStoneBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSaveStone")]
        ///  extern void ADD_SAVE_STONE (nint newValue);


        /// <summary>
        ///   System.Void AddScreenEffect(ScreenEffectBase newEffect, System.Action newCompleteCallback)
        /// </summary>
        /// <param name="newEffect">abstract class ScreenEffectBase</param>
        /// <param name="newCompleteCallback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddScreenEffect")]
        ///  extern void ADD_SCREEN_EFFECT (nint newEffect, nint newCompleteCallback);


        /// <summary>
        ///   System.Void AddScreenEffectPlayer(ScreenEffectPlayer newPlayer, System.Action newCompleteCallback, System.Collections.Generic.List<System.Tuple<System.Action,System.Single>> newParamCompletionCallbacks, ScreenEffectBase newPreStartEffect)
        /// </summary>
        /// <param name="newPlayer">class ScreenEffectPlayer</param>
        /// <param name="newCompleteCallback">class System.Action</param>
        /// <param name="newParamCompletionCallbacks">class System.Collections.Generic.List<System.Tuple<System.Action,System.Single>></param>
        /// <param name="newPreStartEffect">abstract class ScreenEffectBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddScreenEffectPlayer")]
        ///  extern void ADD_SCREEN_EFFECT_PLAYER (nint newPlayer, nint newCompleteCallback, nint newParamCompletionCallbacks, nint newPreStartEffect);


        /// <summary>
        ///   System.Void AddSecondPlayer(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSecondPlayer")]
        ///  extern void ADD_SECOND_PLAYER (nint newValue);


        /// <summary>
        ///   System.Void AddSelectedTavernTalesData(TavernTalesData newValue)
        /// </summary>
        /// <param name="newValue">class TavernTalesData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSelectedTavernTalesData")]
        ///  extern void ADD_SELECTED_TAVERN_TALES_DATA (nint newValue);


        /// <summary>
        ///   System.Void AddShadow(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShadow")]
        ///  extern void ADD_SHADOW (nint newValue);


        /// <summary>
        ///   System.Void AddShipBlueprintEffects(ShipBlueprintEffects newValue)
        /// </summary>
        /// <param name="newValue">class ShipBlueprintEffects</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipBlueprintEffects")]
        ///  extern void ADD_SHIP_BLUEPRINT_EFFECTS (nint newValue);


        /// <summary>
        ///   System.Void AddShipBlueprintItemData(ShipBlueprintItemData newValue)
        /// </summary>
        /// <param name="newValue">class ShipBlueprintItemData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipBlueprintItemData")]
        ///  extern void ADD_SHIP_BLUEPRINT_ITEM_DATA (nint newValue);


        /// <summary>
        ///   System.Void AddShipBlueprintsRefreshedEvent(ShipBlueprintsRefreshedEvent newValue)
        /// </summary>
        /// <param name="newValue">class ShipBlueprintsRefreshedEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipBlueprintsRefreshedEvent")]
        ///  extern void ADD_SHIP_BLUEPRINTS_REFRESHED_EVENT (nint newValue);


        /// <summary>
        ///   System.Void AddShipBoost(UnityEngine.Vector3 newInitialDirection, System.Single newBoostAmountMultiplier, System.Single newBoostTime, System.Single newBoostDecayTime, System.Single newLifetime)
        /// </summary>
        /// <param name="newInitialDirection">struct UnityEngine.Vector3</param>
        /// <param name="newBoostAmountMultiplier">struct System.Single</param>
        /// <param name="newBoostTime">struct System.Single</param>
        /// <param name="newBoostDecayTime">struct System.Single</param>
        /// <param name="newLifetime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipBoost")]
        ///  extern void ADD_SHIP_BOOST (UnityEngine.Vector3 newInitialDirection, System.Single newBoostAmountMultiplier, System.Single newBoostTime, System.Single newBoostDecayTime, System.Single newLifetime);


        /// <summary>
        ///   System.Void AddShipCannon(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipCannon")]
        ///  extern void ADD_SHIP_CANNON (nint newValue);


        /// <summary>
        ///   System.Void AddShipCannonAttackConfig(ShipCannonAttackConfig newValue)
        /// </summary>
        /// <param name="newValue">class ShipCannonAttackConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipCannonAttackConfig")]
        ///  extern void ADD_SHIP_CANNON_ATTACK_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void AddShipCannonRotationDelta(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipCannonRotationDelta")]
        ///  extern void ADD_SHIP_CANNON_ROTATION_DELTA (System.Single newValue);


        /// <summary>
        ///   System.Void AddShipConfig(ShipConfig newValue)
        /// </summary>
        /// <param name="newValue">class ShipConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipConfig")]
        ///  extern void ADD_SHIP_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void AddShipDock(ShipDockBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class ShipDockBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipDock")]
        ///  extern void ADD_SHIP_DOCK (nint newValue);


        /// <summary>
        ///   System.Void AddShipEnterCamFocusRuntimeScreenEffect(GenericCamFocus newScreenEffect)
        /// </summary>
        /// <param name="newScreenEffect">class GenericCamFocus</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipEnterCamFocusRuntimeScreenEffect")]
        ///  extern void ADD_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT (nint newScreenEffect);


        /// <summary>
        ///   System.Void AddShipExitSensorRange(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipExitSensorRange")]
        ///  extern void ADD_SHIP_EXIT_SENSOR_RANGE (System.Single newValue);


        /// <summary>
        ///   System.Void AddShipFeedbackState(ShipFeedbackState newValue)
        /// </summary>
        /// <param name="newValue">enum ShipFeedbackState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipFeedbackState")]
        ///  extern void ADD_SHIP_FEEDBACK_STATE (ShipFeedbackState newValue);


        /// <summary>
        ///   System.Void AddShipMovementPoint(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipMovementPoint")]
        ///  extern void ADD_SHIP_MOVEMENT_POINT (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void AddShipPassengerUpdatedEvent(GameEntity newShip)
        /// </summary>
        /// <param name="newShip">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipPassengerUpdatedEvent")]
        ///  extern void ADD_SHIP_PASSENGER_UPDATED_EVENT (nint newShip);


        /// <summary>
        ///   System.Void AddShipPathAgent(UnityEngine.AI.NavMeshAgent newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.AI.NavMeshAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipPathAgent")]
        ///  extern void ADD_SHIP_PATH_AGENT (nint newValue);


        /// <summary>
        ///   System.Void AddShipReference(GameEntity newEntity)
        /// </summary>
        /// <param name="newEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipReference")]
        ///  extern void ADD_SHIP_REFERENCE (nint newEntity);


        /// <summary>
        ///   System.Void AddShipSailInfo(UnityEngine.Cloth newCloth, UnityEngine.Vector3 newDefaultClothValues, System.Single newMaxMoveSpeedReciprocal)
        /// </summary>
        /// <param name="newCloth">class UnityEngine.Cloth</param>
        /// <param name="newDefaultClothValues">struct UnityEngine.Vector3</param>
        /// <param name="newMaxMoveSpeedReciprocal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipSailInfo")]
        ///  extern void ADD_SHIP_SAIL_INFO (nint newCloth, UnityEngine.Vector3 newDefaultClothValues, System.Single newMaxMoveSpeedReciprocal);


        /// <summary>
        ///   System.Void AddShipSpecialAttackConfig(ShipCannonAttackConfig newValue)
        /// </summary>
        /// <param name="newValue">class ShipCannonAttackConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddShipSpecialAttackConfig")]
        ///  extern void ADD_SHIP_SPECIAL_ATTACK_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void AddSoundStatesReference(SoundStates newValue)
        /// </summary>
        /// <param name="newValue">class SoundStates</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSoundStatesReference")]
        ///  extern void ADD_SOUND_STATES_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void AddSource(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSource")]
        ///  extern void ADD_SOURCE (nint newValue);


        /// <summary>
        ///   System.Void AddSourceTransform(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSourceTransform")]
        ///  extern void ADD_SOURCE_TRANSFORM (nint newValue);


        /// <summary>
        ///   System.Void AddSpawnerOverrideDuration(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpawnerOverrideDuration")]
        ///  extern void ADD_SPAWNER_OVERRIDE_DURATION (System.Single newValue);


        /// <summary>
        ///   System.Void AddSpawnTableItem(SpawnTableItem newValue)
        /// </summary>
        /// <param name="newValue">class SpawnTableItem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpawnTableItem")]
        ///  extern void ADD_SPAWN_TABLE_ITEM (nint newValue);


        /// <summary>
        ///   System.Void AddSpawnTextEvent(UnityEngine.Vector3 newPosition, System.String newText, CombatTextAnimation newTextAnimation)
        /// </summary>
        /// <param name="newPosition">struct UnityEngine.Vector3</param>
        /// <param name="newText">class System.String</param>
        /// <param name="newTextAnimation">abstract class CombatTextAnimation</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpawnTextEvent")]
        ///  extern void ADD_SPAWN_TEXT_EVENT (UnityEngine.Vector3 newPosition, nint newText, nint newTextAnimation);


        /// <summary>
        ///   System.Void AddSpeedTween(System.Single newFrom, System.Single newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed)
        /// </summary>
        /// <param name="newFrom">struct System.Single</param>
        /// <param name="newTo">struct System.Single</param>
        /// <param name="newDuration">struct System.Single</param>
        /// <param name="newEase">enum EasingFunction.Ease</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpeedTween")]
        ///  extern void ADD_SPEED_TWEEN (System.Single newFrom, System.Single newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed);


        /// <summary>
        ///   System.Void AddSpellCommand(System.Int32 newSpellSlot, System.Int32 newSpellInputActionID, UnityEngine.Vector3 newDirection, System.Single newLifetime, System.Boolean newProcessed)
        /// </summary>
        /// <param name="newSpellSlot">struct System.Int32</param>
        /// <param name="newSpellInputActionID">struct System.Int32</param>
        /// <param name="newDirection">struct UnityEngine.Vector3</param>
        /// <param name="newLifetime">struct System.Single</param>
        /// <param name="newProcessed">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpellCommand")]
        ///  extern void ADD_SPELL_COMMAND (System.Int32 newSpellSlot, System.Int32 newSpellInputActionID, UnityEngine.Vector3 newDirection, System.Single newLifetime, System.Boolean newProcessed);


        /// <summary>
        ///   System.Void AddSpellConfig(SpellConfig newValue)
        /// </summary>
        /// <param name="newValue">class SpellConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpellConfig")]
        ///  extern void ADD_SPELL_CONFIG (nint newValue);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameEntity))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameEntity))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void AddAnyActiveWeaponChangedEventListener(System.Collections.Generic.List<IAnyActiveWeaponChangedEventListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyActiveWeaponChangedEventListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyActiveWeaponChangedEventListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddAnyActiveWeaponChangedEventListener(IAnyActiveWeaponChangedEventListener value)
        /// </summary>
        /// <param name="value">interface IAnyActiveWeaponChangedEventListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyActiveWeaponChangedEventListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddAnyShipEnterBlockedListener(System.Collections.Generic.List<IAnyShipEnterBlockedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyShipEnterBlockedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyShipEnterBlockedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_SHIP_ENTER_BLOCKED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddAnyShipEnterBlockedListener(IAnyShipEnterBlockedListener value)
        /// </summary>
        /// <param name="value">interface IAnyShipEnterBlockedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyShipEnterBlockedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_SHIP_ENTER_BLOCKED_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddAnyShipEnterBlockedRemovedListener(System.Collections.Generic.List<IAnyShipEnterBlockedRemovedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyShipEnterBlockedRemovedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyShipEnterBlockedRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddAnyShipEnterBlockedRemovedListener(IAnyShipEnterBlockedRemovedListener value)
        /// </summary>
        /// <param name="value">interface IAnyShipEnterBlockedRemovedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyShipEnterBlockedRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddGameDestroyedListener(System.Collections.Generic.List<IGameDestroyedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IGameDestroyedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameDestroyedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_GAME_DESTROYED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddGameDestroyedListener(IGameDestroyedListener value)
        /// </summary>
        /// <param name="value">interface IGameDestroyedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameDestroyedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_GAME_DESTROYED_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddGunReloadProgressListener(System.Collections.Generic.List<IGunReloadProgressListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IGunReloadProgressListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGunReloadProgressListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_GUN_RELOAD_PROGRESS_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddGunReloadProgressListener(IGunReloadProgressListener value)
        /// </summary>
        /// <param name="value">interface IGunReloadProgressListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGunReloadProgressListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_GUN_RELOAD_PROGRESS_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddKilledListener(System.Collections.Generic.List<IKilledListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IKilledListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddKilledListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_KILLED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddKilledListener(IKilledListener value)
        /// </summary>
        /// <param name="value">interface IKilledListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddKilledListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_KILLED_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddNotEnoughGunAmmoEventListener(System.Collections.Generic.List<INotEnoughGunAmmoEventListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<INotEnoughGunAmmoEventListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddNotEnoughGunAmmoEventListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddNotEnoughGunAmmoEventListener(INotEnoughGunAmmoEventListener value)
        /// </summary>
        /// <param name="value">interface INotEnoughGunAmmoEventListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddNotEnoughGunAmmoEventListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddPlayerIdListener(System.Collections.Generic.List<IPlayerIdListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPlayerIdListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerIdListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_PLAYER_ID_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerIdListener(IPlayerIdListener value)
        /// </summary>
        /// <param name="value">interface IPlayerIdListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerIdListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_PLAYER_ID_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddPlayerIdRemovedListener(System.Collections.Generic.List<IPlayerIdRemovedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPlayerIdRemovedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerIdRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_PLAYER_ID_REMOVED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerIdRemovedListener(IPlayerIdRemovedListener value)
        /// </summary>
        /// <param name="value">interface IPlayerIdRemovedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerIdRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_PLAYER_ID_REMOVED_LISTENER_01 (nint value);


        /// public static partial class Search_GameEntity
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyActiveWeaponChangedEventListener(System.Collections.Generic.List<IAnyActiveWeaponChangedEventListener> newValue)
        /// </summary>
        /// public static bool ADD_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyActiveWeaponChangedEventListener", "System.Collections.Generic.List<IAnyActiveWeaponChangedEventListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyActiveWeaponChangedEventListener(IAnyActiveWeaponChangedEventListener value)
        /// </summary>
        /// public static bool ADD_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyActiveWeaponChangedEventListener", "IAnyActiveWeaponChangedEventListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyShipEnterBlockedListener(System.Collections.Generic.List<IAnyShipEnterBlockedListener> newValue)
        /// </summary>
        /// public static bool ADD_ANY_SHIP_ENTER_BLOCKED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyShipEnterBlockedListener", "System.Collections.Generic.List<IAnyShipEnterBlockedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyShipEnterBlockedListener(IAnyShipEnterBlockedListener value)
        /// </summary>
        /// public static bool ADD_ANY_SHIP_ENTER_BLOCKED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyShipEnterBlockedListener", "IAnyShipEnterBlockedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyShipEnterBlockedRemovedListener(System.Collections.Generic.List<IAnyShipEnterBlockedRemovedListener> newValue)
        /// </summary>
        /// public static bool ADD_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyShipEnterBlockedRemovedListener", "System.Collections.Generic.List<IAnyShipEnterBlockedRemovedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyShipEnterBlockedRemovedListener(IAnyShipEnterBlockedRemovedListener value)
        /// </summary>
        /// public static bool ADD_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyShipEnterBlockedRemovedListener", "IAnyShipEnterBlockedRemovedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddGameDestroyedListener(System.Collections.Generic.List<IGameDestroyedListener> newValue)
        /// </summary>
        /// public static bool ADD_GAME_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddGameDestroyedListener", "System.Collections.Generic.List<IGameDestroyedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddGameDestroyedListener(IGameDestroyedListener value)
        /// </summary>
        /// public static bool ADD_GAME_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddGameDestroyedListener", "IGameDestroyedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddGunReloadProgressListener(System.Collections.Generic.List<IGunReloadProgressListener> newValue)
        /// </summary>
        /// public static bool ADD_GUN_RELOAD_PROGRESS_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddGunReloadProgressListener", "System.Collections.Generic.List<IGunReloadProgressListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddGunReloadProgressListener(IGunReloadProgressListener value)
        /// </summary>
        /// public static bool ADD_GUN_RELOAD_PROGRESS_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddGunReloadProgressListener", "IGunReloadProgressListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddKilledListener(System.Collections.Generic.List<IKilledListener> newValue)
        /// </summary>
        /// public static bool ADD_KILLED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddKilledListener", "System.Collections.Generic.List<IKilledListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddKilledListener(IKilledListener value)
        /// </summary>
        /// public static bool ADD_KILLED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddKilledListener", "IKilledListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddNotEnoughGunAmmoEventListener(System.Collections.Generic.List<INotEnoughGunAmmoEventListener> newValue)
        /// </summary>
        /// public static bool ADD_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddNotEnoughGunAmmoEventListener", "System.Collections.Generic.List<INotEnoughGunAmmoEventListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddNotEnoughGunAmmoEventListener(INotEnoughGunAmmoEventListener value)
        /// </summary>
        /// public static bool ADD_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddNotEnoughGunAmmoEventListener", "INotEnoughGunAmmoEventListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPlayerIdListener(System.Collections.Generic.List<IPlayerIdListener> newValue)
        /// </summary>
        /// public static bool ADD_PLAYER_ID_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPlayerIdListener", "System.Collections.Generic.List<IPlayerIdListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPlayerIdListener(IPlayerIdListener value)
        /// </summary>
        /// public static bool ADD_PLAYER_ID_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPlayerIdListener", "IPlayerIdListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPlayerIdRemovedListener(System.Collections.Generic.List<IPlayerIdRemovedListener> newValue)
        /// </summary>
        /// public static bool ADD_PLAYER_ID_REMOVED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPlayerIdRemovedListener", "System.Collections.Generic.List<IPlayerIdRemovedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPlayerIdRemovedListener(IPlayerIdRemovedListener value)
        /// </summary>
        /// public static bool ADD_PLAYER_ID_REMOVED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPlayerIdRemovedListener", "IPlayerIdRemovedListener");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["ProjectStar".""."GameEntity"]
    /// </summary>
    public partial class GameEntity
    {



        /// <summary>
        ///   System.Void AddSpellLevelConfig(SpellLevelConfig newValue)
        /// </summary>
        /// <param name="newValue">class SpellLevelConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpellLevelConfig")]
        ///  extern void ADD_SPELL_LEVEL_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void AddSpellReference(GameEntity newOwner, SpellLevelConfig newSpell)
        /// </summary>
        /// <param name="newOwner">class GameEntity</param>
        /// <param name="newSpell">class SpellLevelConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpellReference")]
        ///  extern void ADD_SPELL_REFERENCE (nint newOwner, nint newSpell);


        /// <summary>
        ///   System.Void AddSpellTracker(System.Collections.Generic.Dictionary<SpellLevelConfig,System.Collections.Generic.List<GameEntity>> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.Dictionary<SpellLevelConfig,System.Collections.Generic.List<GameEntity>></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpellTracker")]
        ///  extern void ADD_SPELL_TRACKER (nint newValue);


        /// <summary>
        ///   System.Void AddStarGuide(StarGuideBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class StarGuideBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddStarGuide")]
        ///  extern void ADD_STAR_GUIDE (nint newValue);


        /// <summary>
        ///   System.Void AddStarGuideManager(StarGuideManagerBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class StarGuideManagerBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddStarGuideManager")]
        ///  extern void ADD_STAR_GUIDE_MANAGER (nint newValue);


        /// <summary>
        ///   System.Void AddStrafeLane(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddStrafeLane")]
        ///  extern void ADD_STRAFE_LANE (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddStrengthStat(Gentlebros.IntStat newStat)
        /// </summary>
        /// <param name="newStat">class Gentlebros.IntStat</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddStrengthStat")]
        ///  extern void ADD_STRENGTH_STAT (nint newStat);


        /// <summary>
        ///   System.Void AddSwapWeaponCommand(System.Single newLifetime, System.Int32 newProcessingStage, Rewired.InputActionEventData newInputActionEventData)
        /// </summary>
        /// <param name="newLifetime">struct System.Single</param>
        /// <param name="newProcessingStage">struct System.Int32</param>
        /// <param name="newInputActionEventData">struct Rewired.InputActionEventData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSwapWeaponCommand")]
        ///  extern void ADD_SWAP_WEAPON_COMMAND (System.Single newLifetime, System.Int32 newProcessingStage, Rewired.InputActionEventData newInputActionEventData);


        /// <summary>
        ///   System.Void AddTakeDamageEvent(GameEntity newTarget)
        /// </summary>
        /// <param name="newTarget">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTakeDamageEvent")]
        ///  extern void ADD_TAKE_DAMAGE_EVENT (nint newTarget);


        /// <summary>
        ///   System.Void AddTarget(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTarget")]
        ///  extern void ADD_TARGET (nint newValue);


        /// <summary>
        ///   System.Void AddTargetList(System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTargetList")]
        ///  extern void ADD_TARGET_LIST (nint newList);


        /// <summary>
        ///   System.Void AddTargetPosition(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTargetPosition")]
        ///  extern void ADD_TARGET_POSITION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void AddTargetTransform(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTargetTransform")]
        ///  extern void ADD_TARGET_TRANSFORM (nint newValue);


        /// <summary>
        ///   System.Void AddTeleportCallback(Sigtrap.Relays.Relay newValue)
        /// </summary>
        /// <param name="newValue">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTeleportCallback")]
        ///  extern void ADD_TELEPORT_CALLBACK (nint newValue);


        /// <summary>
        ///   System.Void AddTerrainExploredCellsTable(System.Collections.Generic.HashSet<UnityEngine.Vector3Int> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.HashSet<UnityEngine.Vector3Int></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTerrainExploredCellsTable")]
        ///  extern void ADD_TERRAIN_EXPLORED_CELLS_TABLE (nint newValue);


        /// <summary>
        ///   System.Void AddTilt(System.Single newValue, System.Single newGoal)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <param name="newGoal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTilt")]
        ///  extern void ADD_TILT (System.Single newValue, System.Single newGoal);


        /// <summary>
        ///   System.Void AddTiltSpeed(System.Single newValue, System.Single newGoal)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <param name="newGoal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTiltSpeed")]
        ///  extern void ADD_TILT_SPEED (System.Single newValue, System.Single newGoal);


        /// <summary>
        ///   System.Void AddTimedBuff(System.Collections.Generic.List<CombatTimedBuff> newList, Sigtrap.Relays.Relay<BuffEventType> newBuffRelay)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<CombatTimedBuff></param>
        /// <param name="newBuffRelay">class Sigtrap.Relays.Relay<BuffEventType></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTimedBuff")]
        ///  extern void ADD_TIMED_BUFF (nint newList, nint newBuffRelay);


        /// <summary>
        ///   System.Void AddTimer(System.Single newElapsed)
        /// </summary>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTimer")]
        ///  extern void ADD_TIMER (System.Single newElapsed);


        /// <summary>
        ///   System.Void AddTimerCallback(System.Collections.Generic.List<TimerCallbackInfo> newInfoTable)
        /// </summary>
        /// <param name="newInfoTable">class System.Collections.Generic.List<TimerCallbackInfo></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTimerCallback")]
        ///  extern void ADD_TIMER_CALLBACK (nint newInfoTable);


        /// <summary>
        ///   System.Void AddTint(TintType newTintType, UnityEngine.Color newColor, System.Single newDuration)
        /// </summary>
        /// <param name="newTintType">enum TintType</param>
        /// <param name="newColor">struct UnityEngine.Color</param>
        /// <param name="newDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTint")]
        ///  extern void ADD_TINT (TintType newTintType, UnityEngine.Color newColor, System.Single newDuration);


        /// <summary>
        ///   System.Void AddTrailRenderer(UnityEngine.TrailRenderer newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.TrailRenderer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTrailRenderer")]
        ///  extern void ADD_TRAIL_RENDERER (nint newValue);


        /// <summary>
        ///   System.Void AddTransform(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTransform")]
        ///  extern void ADD_TRANSFORM (nint newValue);


        /// <summary>
        ///   System.Void AddTransitioning(UnityEngine.Vector3 newTargetPosition, TransitionType newTransitionType)
        /// </summary>
        /// <param name="newTargetPosition">struct UnityEngine.Vector3</param>
        /// <param name="newTransitionType">enum TransitionType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTransitioning")]
        ///  extern void ADD_TRANSITIONING (UnityEngine.Vector3 newTargetPosition, TransitionType newTransitionType);


        /// <summary>
        ///   System.Void AddTriggerableInteractableType(WorldUIButton.ButtonIcon newValue)
        /// </summary>
        /// <param name="newValue">enum WorldUIButton.ButtonIcon</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTriggerableInteractableType")]
        ///  extern void ADD_TRIGGERABLE_INTERACTABLE_TYPE (WorldUIButton.ButtonIcon newValue);


        /// <summary>
        ///   System.Void AddTriggerHashSet(System.Collections.Generic.HashSet<GameEntity> newHashSet)
        /// </summary>
        /// <param name="newHashSet">class System.Collections.Generic.HashSet<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTriggerHashSet")]
        ///  extern void ADD_TRIGGER_HASH_SET (nint newHashSet);


        /// <summary>
        ///   System.Void AddTurnSpeed(System.Single newValue, System.Single newGoal)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <param name="newGoal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTurnSpeed")]
        ///  extern void ADD_TURN_SPEED (System.Single newValue, System.Single newGoal);


        /// <summary>
        ///   System.Void AddUnequipItemCommand(System.Int32 newPlayerID, Equipment newTargetEquipment)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newTargetEquipment">class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUnequipItemCommand")]
        ///  extern void ADD_UNEQUIP_ITEM_COMMAND (System.Int32 newPlayerID, nint newTargetEquipment);


        /// <summary>
        ///   System.Void AddUnitConfig(UnitConfig newValue)
        /// </summary>
        /// <param name="newValue">class UnitConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUnitConfig")]
        ///  extern void ADD_UNIT_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void AddUnitLevel(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUnitLevel")]
        ///  extern void ADD_UNIT_LEVEL (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddUnlockedEquipmentList(System.Collections.Generic.List<Equipment> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<Equipment></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUnlockedEquipmentList")]
        ///  extern void ADD_UNLOCKED_EQUIPMENT_LIST (nint newValue);


        /// <summary>
        ///   System.Void AddUnlockedShipBlueprints(ShipBlueprintCollection newValue)
        /// </summary>
        /// <param name="newValue">class ShipBlueprintCollection</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUnlockedShipBlueprints")]
        ///  extern void ADD_UNLOCKED_SHIP_BLUEPRINTS (nint newValue);


        /// <summary>
        ///   System.Void AddUnlockedShipSpellTable(ShipSpellCollection newValue)
        /// </summary>
        /// <param name="newValue">class ShipSpellCollection</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUnlockedShipSpellTable")]
        ///  extern void ADD_UNLOCKED_SHIP_SPELL_TABLE (nint newValue);


        /// <summary>
        ///   System.Void AddUnlockedSpellTable(SpellCollection newValue)
        /// </summary>
        /// <param name="newValue">class SpellCollection</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUnlockedSpellTable")]
        ///  extern void ADD_UNLOCKED_SPELL_TABLE (nint newValue);


        /// <summary>
        ///   System.Void AddUpdatedGunAmmo(System.Int32 newPrevValue, System.Int32 newNewValue, System.Int32 newMaxValue)
        /// </summary>
        /// <param name="newPrevValue">struct System.Int32</param>
        /// <param name="newNewValue">struct System.Int32</param>
        /// <param name="newMaxValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUpdatedGunAmmo")]
        ///  extern void ADD_UPDATED_GUN_AMMO (System.Int32 newPrevValue, System.Int32 newNewValue, System.Int32 newMaxValue);


        /// <summary>
        ///   System.Void AddVelocityBuffer(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddVelocityBuffer")]
        ///  extern void ADD_VELOCITY_BUFFER (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void AddVFXFollowParent(ProjectStar.VFXBehaviour newBehaviour, UnityEngine.GameObject newRefObj, VFXSpawnPosition newSpawnPosition, GameEntity newSource, System.Boolean newOffsetByLocalForward, System.Single newLocalDirectionOffsetDistance)
        /// </summary>
        /// <param name="newBehaviour">class ProjectStar.VFXBehaviour</param>
        /// <param name="newRefObj">class UnityEngine.GameObject</param>
        /// <param name="newSpawnPosition">enum VFXSpawnPosition</param>
        /// <param name="newSource">class GameEntity</param>
        /// <param name="newOffsetByLocalForward">struct System.Boolean</param>
        /// <param name="newLocalDirectionOffsetDistance">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddVFXFollowParent")]
        ///  extern void ADD_VFX_FOLLOW_PARENT (nint newBehaviour, nint newRefObj, VFXSpawnPosition newSpawnPosition, nint newSource, System.Boolean newOffsetByLocalForward, System.Single newLocalDirectionOffsetDistance);


        /// <summary>
        ///   System.Void AddVFXSpawnpoint(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddVFXSpawnpoint")]
        ///  extern void ADD_VFX_SPAWNPOINT (nint newValue);


        /// <summary>
        ///   System.Void AddWallColliders(System.Collections.Generic.List<UnityEngine.Collider> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<UnityEngine.Collider></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWallColliders")]
        ///  extern void ADD_WALL_COLLIDERS (nint newValue);


        /// <summary>
        ///   System.Void AddWaterRipplesParticles(UnityEngine.ParticleSystem newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.ParticleSystem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWaterRipplesParticles")]
        ///  extern void ADD_WATER_RIPPLES_PARTICLES (nint newValue);


        /// <summary>
        ///   System.Void AddWorldUIButtonAnchorPosOffset(UnityEngine.Vector2 newShowOffset, UnityEngine.Vector2 newCannotEnterOffset)
        /// </summary>
        /// <param name="newShowOffset">struct UnityEngine.Vector2</param>
        /// <param name="newCannotEnterOffset">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldUIButtonAnchorPosOffset")]
        ///  extern void ADD_WORLD_UI_BUTTON_ANCHOR_POS_OFFSET (UnityEngine.Vector2 newShowOffset, UnityEngine.Vector2 newCannotEnterOffset);


        /// <summary>
        ///   System.Void AddWorldUIButtonAttachFlipSprite(System.Boolean newFlipDisplayedIcon)
        /// </summary>
        /// <param name="newFlipDisplayedIcon">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldUIButtonAttachFlipSprite")]
        ///  extern void ADD_WORLD_UI_BUTTON_ATTACH_FLIP_SPRITE (System.Boolean newFlipDisplayedIcon);


        /// <summary>
        ///   System.Void AddWorldUIButtonAttachParent(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldUIButtonAttachParent")]
        ///  extern void ADD_WORLD_UI_BUTTON_ATTACH_PARENT (nint newValue);


        /// <summary>
        ///   Entitas.ContextInfo createDefaultContextInfo()
        /// </summary>
        /// <returns>class Entitas.ContextInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("createDefaultContextInfo")]
        ///  extern nint CREATE_DEFAULT_CONTEXT_INFO ();


        /// <summary>
        ///   System.Void Destroy()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy")]
        ///  extern void DESTROY ();


        /// <summary>
        ///   ActiveScreenEffectPlayerComponent get_activeScreenEffectPlayer()
        /// </summary>
        /// <returns>class ActiveScreenEffectPlayerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_activeScreenEffectPlayer")]
        ///  extern nint GET_ACTIVE_SCREEN_EFFECT_PLAYER ();


        /// <summary>
        ///   ActiveWeaponChangedEventComponent get_activeWeaponChangedEvent()
        /// </summary>
        /// <returns>class ActiveWeaponChangedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_activeWeaponChangedEvent")]
        ///  extern nint GET_ACTIVE_WEAPON_CHANGED_EVENT ();


        /// <summary>
        ///   AdvancedStatModifiersComponent get_advancedStatModifiers()
        /// </summary>
        /// <returns>class AdvancedStatModifiersComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_advancedStatModifiers")]
        ///  extern nint GET_ADVANCED_STAT_MODIFIERS ();


        /// <summary>
        ///   Entitas.IAERC get_aerc()
        /// </summary>
        /// <returns>interface Entitas.IAERC</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_aerc")]
        ///  extern nint GET_AERC ();


        /// <summary>
        ///   AgentDestinationComponent get_agentDestination()
        /// </summary>
        /// <returns>class AgentDestinationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_agentDestination")]
        ///  extern nint GET_AGENT_DESTINATION ();


        /// <summary>
        ///   AgentPreviousDestinationComponent get_agentPreviousDestination()
        /// </summary>
        /// <returns>class AgentPreviousDestinationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_agentPreviousDestination")]
        ///  extern nint GET_AGENT_PREVIOUS_DESTINATION ();


        /// <summary>
        ///   AnchorPosOffsetComponent get_anchorPosOffset()
        /// </summary>
        /// <returns>class AnchorPosOffsetComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_anchorPosOffset")]
        ///  extern nint GET_ANCHOR_POS_OFFSET ();


        /// <summary>
        ///   AngleOffsetComponent get_angleOffset()
        /// </summary>
        /// <returns>class AngleOffsetComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_angleOffset")]
        ///  extern nint GET_ANGLE_OFFSET ();


        /// <summary>
        ///   AnimationComponent get_animation()
        /// </summary>
        /// <returns>class AnimationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_animation")]
        ///  extern nint GET_ANIMATION ();


        /// <summary>
        ///   AnimationFlagsComponent get_animationFlags()
        /// </summary>
        /// <returns>class AnimationFlagsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_animationFlags")]
        ///  extern nint GET_ANIMATION_FLAGS ();


        /// <summary>
        ///   AnimationProgressComponent get_animationProgress()
        /// </summary>
        /// <returns>class AnimationProgressComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_animationProgress")]
        ///  extern nint GET_ANIMATION_PROGRESS ();


        /// <summary>
        ///   AnimatorComponent get_animator()
        /// </summary>
        /// <returns>class AnimatorComponent</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_animator", CallConvs = [typeof(CallConvCdecl)])]
        extern AnimatorComponent.Ptr_AnimatorComponent GET_ANIMATOR();


        /// <summary>
        ///   AnyActiveWeaponChangedEventListenerComponent get_anyActiveWeaponChangedEventListener()
        /// </summary>
        /// <returns>class AnyActiveWeaponChangedEventListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_anyActiveWeaponChangedEventListener")]
        ///  extern nint GET_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER ();


        /// <summary>
        ///   AnyShipEnterBlockedListenerComponent get_anyShipEnterBlockedListener()
        /// </summary>
        /// <returns>class AnyShipEnterBlockedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_anyShipEnterBlockedListener")]
        ///  extern nint GET_ANY_SHIP_ENTER_BLOCKED_LISTENER ();


        /// <summary>
        ///   AnyShipEnterBlockedRemovedListenerComponent get_anyShipEnterBlockedRemovedListener()
        /// </summary>
        /// <returns>class AnyShipEnterBlockedRemovedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_anyShipEnterBlockedRemovedListener")]
        ///  extern nint GET_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER ();


        /// <summary>
        ///   AoeColliderTypeComponent get_aoeColliderType()
        /// </summary>
        /// <returns>class AoeColliderTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_aoeColliderType")]
        ///  extern nint GET_AOE_COLLIDER_TYPE ();


        /// <summary>
        ///   AoeInfoComponent get_aoeInfo()
        /// </summary>
        /// <returns>class AoeInfoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_aoeInfo")]
        ///  extern nint GET_AOE_INFO ();


        /// <summary>
        ///   ArtPrefabReferenceComponent get_artPrefabReference()
        /// </summary>
        /// <returns>class ArtPrefabReferenceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_artPrefabReference")]
        ///  extern nint GET_ART_PREFAB_REFERENCE ();


        /// <summary>
        ///   AttachableFloatComponent get_attachableFloat()
        /// </summary>
        /// <returns>class AttachableFloatComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attachableFloat")]
        ///  extern nint GET_ATTACHABLE_FLOAT ();


        /// <summary>
        ///   AttachedVfxTrackerComponent get_attachedVfxTracker()
        /// </summary>
        /// <returns>class AttachedVfxTrackerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attachedVfxTracker")]
        ///  extern nint GET_ATTACHED_VFX_TRACKER ();


        /// <summary>
        ///   AttackAnimationComponent get_attackAnimation()
        /// </summary>
        /// <returns>class AttackAnimationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attackAnimation")]
        ///  extern nint GET_ATTACK_ANIMATION ();


        /// <summary>
        ///   AttackCommandComponent get_attackCommand()
        /// </summary>
        /// <returns>class AttackCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attackCommand")]
        ///  extern nint GET_ATTACK_COMMAND ();


        /// <summary>
        ///   AttackEventInfoComponent get_attackEventInfo()
        /// </summary>
        /// <returns>class AttackEventInfoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attackEventInfo")]
        ///  extern nint GET_ATTACK_EVENT_INFO ();


        /// <summary>
        ///   AttackReference get_attackReference()
        /// </summary>
        /// <returns>class AttackReference</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attackReference")]
        ///  extern nint GET_ATTACK_REFERENCE ();


        /// <summary>
        ///   AttackTellViewComponent get_attackTellView()
        /// </summary>
        /// <returns>class AttackTellViewComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attackTellView")]
        ///  extern nint GET_ATTACK_TELL_VIEW ();


        /// <summary>
        ///   AttackTintComponent get_attackTint()
        /// </summary>
        /// <returns>class AttackTintComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attackTint")]
        ///  extern nint GET_ATTACK_TINT ();


        /// <summary>
        ///   AwardedQuestItemsComponent get_awardedQuestItems()
        /// </summary>
        /// <returns>class AwardedQuestItemsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_awardedQuestItems")]
        ///  extern nint GET_AWARDED_QUEST_ITEMS ();


        /// <summary>
        ///   BaseEnemyBehaviourComponent get_baseEnemyBehaviour()
        /// </summary>
        /// <returns>class BaseEnemyBehaviourComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_baseEnemyBehaviour")]
        ///  extern nint GET_BASE_ENEMY_BEHAVIOUR ();


        /// <summary>
        ///   BehaviourTreeComponent get_behaviourTree()
        /// </summary>
        /// <returns>class BehaviourTreeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_behaviourTree")]
        ///  extern nint GET_BEHAVIOUR_TREE ();


        /// <summary>
        ///   BlockEffectCooldownComponent get_blockEffectCooldown()
        /// </summary>
        /// <returns>class BlockEffectCooldownComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_blockEffectCooldown")]
        ///  extern nint GET_BLOCK_EFFECT_COOLDOWN ();


        /// <summary>
        ///   BlockFreezeDurationComponent get_blockFreezeDuration()
        /// </summary>
        /// <returns>class BlockFreezeDurationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_blockFreezeDuration")]
        ///  extern nint GET_BLOCK_FREEZE_DURATION ();


        /// <summary>
        ///   BurnCounterComponent get_burnCounter()
        /// </summary>
        /// <returns>class BurnCounterComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_burnCounter")]
        ///  extern nint GET_BURN_COUNTER ();


        /// <summary>
        ///   CannonCooldownComponent get_cannonCooldown()
        /// </summary>
        /// <returns>class CannonCooldownComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_cannonCooldown")]
        ///  extern nint GET_CANNON_COOLDOWN ();


        /// <summary>
        ///   CapsuleComponent get_capsule()
        /// </summary>
        /// <returns>class CapsuleComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_capsule")]
        ///  extern nint GET_CAPSULE ();


        /// <summary>
        ///   CharacterControllerComponent get_characterController()
        /// </summary>
        /// <returns>class CharacterControllerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_characterController")]
        ///  extern nint GET_CHARACTER_CONTROLLER ();


        /// <summary>
        ///   CharacterGenderComponent get_characterGender()
        /// </summary>
        /// <returns>class CharacterGenderComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_characterGender")]
        ///  extern nint GET_CHARACTER_GENDER ();


        /// <summary>
        ///   ChargeConfigComponent get_chargeConfig()
        /// </summary>
        /// <returns>class ChargeConfigComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_chargeConfig")]
        ///  extern nint GET_CHARGE_CONFIG ();


        /// <summary>
        ///   ChestComponent get_chest()
        /// </summary>
        /// <returns>class ChestComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_chest")]
        ///  extern nint GET_CHEST ();


        /// <summary>
        ///   ChestInteractorComponent get_chestInteractor()
        /// </summary>
        /// <returns>class ChestInteractorComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_chestInteractor")]
        ///  extern nint GET_CHEST_INTERACTOR ();


        /// <summary>
        ///   CollatedAoeAttacksComponent get_collatedAoeAttacks()
        /// </summary>
        /// <returns>class CollatedAoeAttacksComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_collatedAoeAttacks")]
        ///  extern nint GET_COLLATED_AOE_ATTACKS ();


        /// <summary>
        ///   CollectibleCollectedEventComponent get_collectibleCollectedEvent()
        /// </summary>
        /// <returns>class CollectibleCollectedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_collectibleCollectedEvent")]
        ///  extern nint GET_COLLECTIBLE_COLLECTED_EVENT ();


        /// <summary>
        ///   CollectibleReferenceComponent get_collectibleReference()
        /// </summary>
        /// <returns>class CollectibleReferenceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_collectibleReference")]
        ///  extern nint GET_COLLECTIBLE_REFERENCE ();


        /// <summary>
        ///   ColliderComponent get_collider()
        /// </summary>
        /// <returns>class ColliderComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_collider")]
        ///  extern nint GET_COLLIDER ();


        /// <summary>
        ///   CombatAgentComponent get_combatAgent()
        /// </summary>
        /// <returns>class CombatAgentComponent</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_combatAgent", CallConvs = [typeof(CallConvCdecl)])]
        extern CombatAgentComponent.Ptr_CombatAgentComponent GET_COMBAT_AGENT();


        /// <summary>
        ///   CombatAgentHealthUpdatedEvent get_combatAgentHealthUpdatedEvent()
        /// </summary>
        /// <returns>class CombatAgentHealthUpdatedEvent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_combatAgentHealthUpdatedEvent")]
        ///  extern nint GET_COMBAT_AGENT_HEALTH_UPDATED_EVENT ();


        /// <summary>
        ///   CombatAgentListComponent get_combatAgentList()
        /// </summary>
        /// <returns>class CombatAgentListComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_combatAgentList")]
        ///  extern nint GET_COMBAT_AGENT_LIST ();


        /// <summary>
        ///   CombatAggroDuration get_combatAggroDuration()
        /// </summary>
        /// <returns>class CombatAggroDuration</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_combatAggroDuration")]
        ///  extern nint GET_COMBAT_AGGRO_DURATION ();


        /// <summary>
        ///   CombatLogComponent get_combatLog()
        /// </summary>
        /// <returns>class CombatLogComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_combatLog")]
        ///  extern nint GET_COMBAT_LOG ();


        /// <summary>
        ///   CombatProxyAgentComponent get_combatProxyAgent()
        /// </summary>
        /// <returns>class CombatProxyAgentComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_combatProxyAgent")]
        ///  extern nint GET_COMBAT_PROXY_AGENT ();


        /// <summary>
        ///   System.Collections.Generic.Stack<Entitas.IComponent>[] get_componentPools()
        /// </summary>
        /// <returns>class System.Collections.Generic.Stack<Entitas.IComponent>[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_componentPools")]
        ///  extern nint GET_COMPONENT_POOLS ();


        /// <summary>
        ///   Entitas.ContextInfo get_contextInfo()
        /// </summary>
        /// <returns>class Entitas.ContextInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_contextInfo")]
        ///  extern nint GET_CONTEXT_INFO ();


        /// <summary>
        ///   System.Int32 get_creationIndex()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_creationIndex")]
        ///  extern System.Int32 GET_CREATION_INDEX ();


        /// <summary>
        ///   CurrentChargerAttackEntitiesComponent get_currentChargerAttackEntities()
        /// </summary>
        /// <returns>class CurrentChargerAttackEntitiesComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentChargerAttackEntities")]
        ///  extern nint GET_CURRENT_CHARGER_ATTACK_ENTITIES ();


        /// <summary>
        ///   CurrentProjectileHitEntitiesComponent get_currentProjectileHitEntities()
        /// </summary>
        /// <returns>class CurrentProjectileHitEntitiesComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentProjectileHitEntities")]
        ///  extern nint GET_CURRENT_PROJECTILE_HIT_ENTITIES ();


        /// <summary>
        ///   CurrentSensorRadius get_currentSensorRadius()
        /// </summary>
        /// <returns>class CurrentSensorRadius</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentSensorRadius")]
        ///  extern nint GET_CURRENT_SENSOR_RADIUS ();


        /// <summary>
        ///   CutsceneOwnerComponent get_cutsceneOwner()
        /// </summary>
        /// <returns>class CutsceneOwnerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_cutsceneOwner")]
        ///  extern nint GET_CUTSCENE_OWNER ();


        /// <summary>
        ///   DashAttackCounterComponent get_dashAttackCounter()
        /// </summary>
        /// <returns>class DashAttackCounterComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dashAttackCounter")]
        ///  extern nint GET_DASH_ATTACK_COUNTER ();


        /// <summary>
        ///   DestinationRelayComponent get_destinationRelay()
        /// </summary>
        /// <returns>class DestinationRelayComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_destinationRelay")]
        ///  extern nint GET_DESTINATION_RELAY ();


        /// <summary>
        ///   DestructibleFXComponent get_destructibleFX()
        /// </summary>
        /// <returns>class DestructibleFXComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_destructibleFX")]
        ///  extern nint GET_DESTRUCTIBLE_FX ();


        /// <summary>
        ///   DialogueSpeakerComponent get_dialogueSpeaker()
        /// </summary>
        /// <returns>class DialogueSpeakerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dialogueSpeaker")]
        ///  extern nint GET_DIALOGUE_SPEAKER ();


        /// <summary>
        ///   DirectionComponent get_direction()
        /// </summary>
        /// <returns>class DirectionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_direction")]
        ///  extern nint GET_DIRECTION ();


        /// <summary>
        ///   DockRepairComponent get_dockRepair()
        /// </summary>
        /// <returns>class DockRepairComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dockRepair")]
        ///  extern nint GET_DOCK_REPAIR ();


        /// <summary>
        ///   DockRepairBeaconComponent get_dockRepairBeacon()
        /// </summary>
        /// <returns>class DockRepairBeaconComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dockRepairBeacon")]
        ///  extern nint GET_DOCK_REPAIR_BEACON ();


        /// <summary>
        ///   DockRepairOccupantsUpdatedEvent get_dockRepairOccupantsUpdatedEvent()
        /// </summary>
        /// <returns>class DockRepairOccupantsUpdatedEvent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dockRepairOccupantsUpdatedEvent")]
        ///  extern nint GET_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT ();


        /// <summary>
        ///   EnemyShipBehaviourComponent get_enemyShipBehaviour()
        /// </summary>
        /// <returns>class EnemyShipBehaviourComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_enemyShipBehaviour")]
        ///  extern nint GET_ENEMY_SHIP_BEHAVIOUR ();


        /// <summary>
        ///   EquipItemCommand get_equipItemCommand()
        /// </summary>
        /// <returns>class EquipItemCommand</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equipItemCommand")]
        ///  extern nint GET_EQUIP_ITEM_COMMAND ();


        /// <summary>
        ///   EquipmentComponent get_equipment()
        /// </summary>
        /// <returns>class EquipmentComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equipment")]
        ///  extern nint GET_EQUIPMENT ();


        /// <summary>
        ///   EquipmentChangedEventComponent get_equipmentChangedEvent()
        /// </summary>
        /// <returns>class EquipmentChangedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equipmentChangedEvent")]
        ///  extern nint GET_EQUIPMENT_CHANGED_EVENT ();


        /// <summary>
        ///   EquipmentEffectsComponent get_equipmentEffects()
        /// </summary>
        /// <returns>class EquipmentEffectsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equipmentEffects")]
        ///  extern nint GET_EQUIPMENT_EFFECTS ();


        /// <summary>
        ///   EquipmentItemDataComponent get_equipmentItemData()
        /// </summary>
        /// <returns>class EquipmentItemDataComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equipmentItemData")]
        ///  extern nint GET_EQUIPMENT_ITEM_DATA ();


        /// <summary>
        ///   EquippedItemsComponent get_equippedItems()
        /// </summary>
        /// <returns>class EquippedItemsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equippedItems")]
        ///  extern nint GET_EQUIPPED_ITEMS ();


        /// <summary>
        ///   EquippedPlayerShipSpellsComponent get_equippedPlayerShipSpells()
        /// </summary>
        /// <returns>class EquippedPlayerShipSpellsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equippedPlayerShipSpells")]
        ///  extern nint GET_EQUIPPED_PLAYER_SHIP_SPELLS ();


        /// <summary>
        ///   EquippedShipBlueprintsComponent get_equippedShipBlueprints()
        /// </summary>
        /// <returns>class EquippedShipBlueprintsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equippedShipBlueprints")]
        ///  extern nint GET_EQUIPPED_SHIP_BLUEPRINTS ();


        /// <summary>
        ///   EquippedSpellsComponent get_equippedSpells()
        /// </summary>
        /// <returns>class EquippedSpellsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equippedSpells")]
        ///  extern nint GET_EQUIPPED_SPELLS ();


        /// <summary>
        ///   FacingComponent get_facing()
        /// </summary>
        /// <returns>class FacingComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_facing")]
        ///  extern nint GET_FACING ();


        /// <summary>
        ///   FadeDurationComponent get_fadeDuration()
        /// </summary>
        /// <returns>class FadeDurationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fadeDuration")]
        ///  extern nint GET_FADE_DURATION ();


        /// <summary>
        ///   FiringPointComponent get_firingPoint()
        /// </summary>
        /// <returns>class FiringPointComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_firingPoint")]
        ///  extern nint GET_FIRING_POINT ();


        /// <summary>
        ///   FloatTransitionEventComponent get_floatTransitionEvent()
        /// </summary>
        /// <returns>class FloatTransitionEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_floatTransitionEvent")]
        ///  extern nint GET_FLOAT_TRANSITION_EVENT ();


        /// <summary>
        ///   FoamComponent get_foam()
        /// </summary>
        /// <returns>class FoamComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_foam")]
        ///  extern nint GET_FOAM ();


        /// <summary>
        ///   GameDestroyedListenerComponent get_gameDestroyedListener()
        /// </summary>
        /// <returns>class GameDestroyedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameDestroyedListener")]
        ///  extern nint GET_GAME_DESTROYED_LISTENER ();


        /// <summary>
        ///   GameDifficultyComponent get_gameDifficulty()
        /// </summary>
        /// <returns>class GameDifficultyComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameDifficulty")]
        ///  extern nint GET_GAME_DIFFICULTY ();


        /// <summary>
        ///   GameDifficultyDamageModifierComponent get_gameDifficultyDamageModifier()
        /// </summary>
        /// <returns>class GameDifficultyDamageModifierComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameDifficultyDamageModifier")]
        ///  extern nint GET_GAME_DIFFICULTY_DAMAGE_MODIFIER ();


        /// <summary>
        ///   GameDifficultyHeathModifierComponent get_gameDifficultyHeathModifier()
        /// </summary>
        /// <returns>class GameDifficultyHeathModifierComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameDifficultyHeathModifier")]
        ///  extern nint GET_GAME_DIFFICULTY_HEATH_MODIFIER ();


        /// <summary>
        ///   GameEntityIdComponent get_gameEntityId()
        /// </summary>
        /// <returns>class GameEntityIdComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameEntityId")]
        ///  extern nint GET_GAME_ENTITY_ID ();


        /// <summary>
        ///   GameOverEventComponent get_gameOverEvent()
        /// </summary>
        /// <returns>class GameOverEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameOverEvent")]
        ///  extern nint GET_GAME_OVER_EVENT ();


        /// <summary>
        ///   GameOverNoSaveOverrideComponent get_gameOverNoSaveOverride()
        /// </summary>
        /// <returns>class GameOverNoSaveOverrideComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameOverNoSaveOverride")]
        ///  extern nint GET_GAME_OVER_NO_SAVE_OVERRIDE ();


        /// <summary>
        ///   GraphicObjContainerComponent get_graphicObjContainer()
        /// </summary>
        /// <returns>class GraphicObjContainerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_graphicObjContainer")]
        ///  extern nint GET_GRAPHIC_OBJ_CONTAINER ();


        /// <summary>
        ///   GunAmmoComponent get_gunAmmo()
        /// </summary>
        /// <returns>class GunAmmoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gunAmmo")]
        ///  extern nint GET_GUN_AMMO ();


        /// <summary>
        ///   GunReloadComponent get_gunReload()
        /// </summary>
        /// <returns>class GunReloadComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gunReload")]
        ///  extern nint GET_GUN_RELOAD ();


        /// <summary>
        ///   GunReloadProgressComponent get_gunReloadProgress()
        /// </summary>
        /// <returns>class GunReloadProgressComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gunReloadProgress")]
        ///  extern nint GET_GUN_RELOAD_PROGRESS ();


        /// <summary>
        ///   GunReloadProgressListenerComponent get_gunReloadProgressListener()
        /// </summary>
        /// <returns>class GunReloadProgressListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gunReloadProgressListener")]
        ///  extern nint GET_GUN_RELOAD_PROGRESS_LISTENER ();


        /// <summary>
        ///   GunReloadTimerComponent get_gunReloadTimer()
        /// </summary>
        /// <returns>class GunReloadTimerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gunReloadTimer")]
        ///  extern nint GET_GUN_RELOAD_TIMER ();


        /// <summary>
        ///   System.Boolean get_hasActiveScreenEffectPlayer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasActiveScreenEffectPlayer")]
        ///  extern System.Boolean GET_HAS_ACTIVE_SCREEN_EFFECT_PLAYER ();


        /// <summary>
        ///   System.Boolean get_hasActiveWeaponChangedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasActiveWeaponChangedEvent")]
        ///  extern System.Boolean GET_HAS_ACTIVE_WEAPON_CHANGED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasAdvancedStatModifiers()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAdvancedStatModifiers")]
        ///  extern System.Boolean GET_HAS_ADVANCED_STAT_MODIFIERS ();


        /// <summary>
        ///   System.Boolean get_hasAgentDestination()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAgentDestination")]
        ///  extern System.Boolean GET_HAS_AGENT_DESTINATION ();


        /// <summary>
        ///   System.Boolean get_hasAgentPreviousDestination()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAgentPreviousDestination")]
        ///  extern System.Boolean GET_HAS_AGENT_PREVIOUS_DESTINATION ();


        /// <summary>
        ///   System.Boolean get_hasAnchorPosOffset()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnchorPosOffset")]
        ///  extern System.Boolean GET_HAS_ANCHOR_POS_OFFSET ();


        /// <summary>
        ///   System.Boolean get_hasAngleOffset()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAngleOffset")]
        ///  extern System.Boolean GET_HAS_ANGLE_OFFSET ();


        /// <summary>
        ///   System.Boolean get_hasAnimation()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnimation")]
        ///  extern System.Boolean GET_HAS_ANIMATION ();


        /// <summary>
        ///   System.Boolean get_hasAnimationFlags()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnimationFlags")]
        ///  extern System.Boolean GET_HAS_ANIMATION_FLAGS ();


        /// <summary>
        ///   System.Boolean get_hasAnimationProgress()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnimationProgress")]
        ///  extern System.Boolean GET_HAS_ANIMATION_PROGRESS ();


        /// <summary>
        ///   System.Boolean get_hasAnimator()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnimator")]
        ///  extern System.Boolean GET_HAS_ANIMATOR ();


        /// <summary>
        ///   System.Boolean get_hasAnyActiveWeaponChangedEventListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnyActiveWeaponChangedEventListener")]
        ///  extern System.Boolean GET_HAS_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasAnyShipEnterBlockedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnyShipEnterBlockedListener")]
        ///  extern System.Boolean GET_HAS_ANY_SHIP_ENTER_BLOCKED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasAnyShipEnterBlockedRemovedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnyShipEnterBlockedRemovedListener")]
        ///  extern System.Boolean GET_HAS_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasAoeColliderType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAoeColliderType")]
        ///  extern System.Boolean GET_HAS_AOE_COLLIDER_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasAoeInfo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAoeInfo")]
        ///  extern System.Boolean GET_HAS_AOE_INFO ();


        /// <summary>
        ///   System.Boolean get_hasArtPrefabReference()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasArtPrefabReference")]
        ///  extern System.Boolean GET_HAS_ART_PREFAB_REFERENCE ();


        /// <summary>
        ///   System.Boolean get_hasAttachableFloat()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAttachableFloat")]
        ///  extern System.Boolean GET_HAS_ATTACHABLE_FLOAT ();


        /// <summary>
        ///   System.Boolean get_hasAttachedVfxTracker()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAttachedVfxTracker")]
        ///  extern System.Boolean GET_HAS_ATTACHED_VFX_TRACKER ();


        /// <summary>
        ///   System.Boolean get_hasAttackAnimation()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAttackAnimation")]
        ///  extern System.Boolean GET_HAS_ATTACK_ANIMATION ();


        /// <summary>
        ///   System.Boolean get_hasAttackCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAttackCommand")]
        ///  extern System.Boolean GET_HAS_ATTACK_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasAttackEventInfo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAttackEventInfo")]
        ///  extern System.Boolean GET_HAS_ATTACK_EVENT_INFO ();


        /// <summary>
        ///   System.Boolean get_hasAttackReference()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAttackReference")]
        ///  extern System.Boolean GET_HAS_ATTACK_REFERENCE ();


        /// <summary>
        ///   System.Boolean get_hasAttackTellView()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAttackTellView")]
        ///  extern System.Boolean GET_HAS_ATTACK_TELL_VIEW ();


        /// <summary>
        ///   System.Boolean get_hasAttackTint()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAttackTint")]
        ///  extern System.Boolean GET_HAS_ATTACK_TINT ();


        /// <summary>
        ///   System.Boolean get_hasAwardedQuestItems()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAwardedQuestItems")]
        ///  extern System.Boolean GET_HAS_AWARDED_QUEST_ITEMS ();


        /// <summary>
        ///   System.Boolean get_hasBaseEnemyBehaviour()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBaseEnemyBehaviour")]
        ///  extern System.Boolean GET_HAS_BASE_ENEMY_BEHAVIOUR ();


        /// <summary>
        ///   System.Boolean get_hasBehaviourTree()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBehaviourTree")]
        ///  extern System.Boolean GET_HAS_BEHAVIOUR_TREE ();


        /// <summary>
        ///   System.Boolean get_hasBlockEffectCooldown()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBlockEffectCooldown")]
        ///  extern System.Boolean GET_HAS_BLOCK_EFFECT_COOLDOWN ();


        /// <summary>
        ///   System.Boolean get_hasBlockFreezeDuration()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBlockFreezeDuration")]
        ///  extern System.Boolean GET_HAS_BLOCK_FREEZE_DURATION ();


        /// <summary>
        ///   System.Boolean get_hasBurnCounter()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBurnCounter")]
        ///  extern System.Boolean GET_HAS_BURN_COUNTER ();


        /// <summary>
        ///   System.Boolean get_hasCannonCooldown()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCannonCooldown")]
        ///  extern System.Boolean GET_HAS_CANNON_COOLDOWN ();


        /// <summary>
        ///   System.Boolean get_hasCapsule()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCapsule")]
        ///  extern System.Boolean GET_HAS_CAPSULE ();


        /// <summary>
        ///   System.Boolean get_hasCharacterController()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCharacterController")]
        ///  extern System.Boolean GET_HAS_CHARACTER_CONTROLLER ();


        /// <summary>
        ///   System.Boolean get_hasCharacterGender()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCharacterGender")]
        ///  extern System.Boolean GET_HAS_CHARACTER_GENDER ();


        /// <summary>
        ///   System.Boolean get_hasChargeConfig()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasChargeConfig")]
        ///  extern System.Boolean GET_HAS_CHARGE_CONFIG ();


        /// <summary>
        ///   System.Boolean get_hasChest()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasChest")]
        ///  extern System.Boolean GET_HAS_CHEST ();


        /// <summary>
        ///   System.Boolean get_hasChestInteractor()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasChestInteractor")]
        ///  extern System.Boolean GET_HAS_CHEST_INTERACTOR ();


        /// <summary>
        ///   System.Boolean get_hasCollatedAoeAttacks()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCollatedAoeAttacks")]
        ///  extern System.Boolean GET_HAS_COLLATED_AOE_ATTACKS ();


        /// <summary>
        ///   System.Boolean get_hasCollectibleCollectedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCollectibleCollectedEvent")]
        ///  extern System.Boolean GET_HAS_COLLECTIBLE_COLLECTED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasCollectibleReference()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCollectibleReference")]
        ///  extern System.Boolean GET_HAS_COLLECTIBLE_REFERENCE ();


        /// <summary>
        ///   System.Boolean get_hasCollider()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCollider")]
        ///  extern System.Boolean GET_HAS_COLLIDER ();


        /// <summary>
        ///   System.Boolean get_hasCombatAgent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCombatAgent")]
        ///  extern System.Boolean GET_HAS_COMBAT_AGENT ();


        /// <summary>
        ///   System.Boolean get_hasCombatAgentHealthUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCombatAgentHealthUpdatedEvent")]
        ///  extern System.Boolean GET_HAS_COMBAT_AGENT_HEALTH_UPDATED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasCombatAgentList()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCombatAgentList")]
        ///  extern System.Boolean GET_HAS_COMBAT_AGENT_LIST ();


        /// <summary>
        ///   System.Boolean get_hasCombatAggroDuration()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCombatAggroDuration")]
        ///  extern System.Boolean GET_HAS_COMBAT_AGGRO_DURATION ();


        /// <summary>
        ///   System.Boolean get_hasCombatLog()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCombatLog")]
        ///  extern System.Boolean GET_HAS_COMBAT_LOG ();


        /// <summary>
        ///   System.Boolean get_hasCombatProxyAgent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCombatProxyAgent")]
        ///  extern System.Boolean GET_HAS_COMBAT_PROXY_AGENT ();


        /// <summary>
        ///   System.Boolean get_hasCurrentChargerAttackEntities()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCurrentChargerAttackEntities")]
        ///  extern System.Boolean GET_HAS_CURRENT_CHARGER_ATTACK_ENTITIES ();


        /// <summary>
        ///   System.Boolean get_hasCurrentProjectileHitEntities()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCurrentProjectileHitEntities")]
        ///  extern System.Boolean GET_HAS_CURRENT_PROJECTILE_HIT_ENTITIES ();


        /// <summary>
        ///   System.Boolean get_hasCurrentSensorRadius()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCurrentSensorRadius")]
        ///  extern System.Boolean GET_HAS_CURRENT_SENSOR_RADIUS ();


        /// <summary>
        ///   System.Boolean get_hasCutsceneOwner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCutsceneOwner")]
        ///  extern System.Boolean GET_HAS_CUTSCENE_OWNER ();


        /// <summary>
        ///   System.Boolean get_hasDashAttackCounter()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDashAttackCounter")]
        ///  extern System.Boolean GET_HAS_DASH_ATTACK_COUNTER ();


        /// <summary>
        ///   System.Boolean get_hasDestinationRelay()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDestinationRelay")]
        ///  extern System.Boolean GET_HAS_DESTINATION_RELAY ();


        /// <summary>
        ///   System.Boolean get_hasDestructibleFX()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDestructibleFX")]
        ///  extern System.Boolean GET_HAS_DESTRUCTIBLE_FX ();


        /// <summary>
        ///   System.Boolean get_hasDialogueSpeaker()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDialogueSpeaker")]
        ///  extern System.Boolean GET_HAS_DIALOGUE_SPEAKER ();


        /// <summary>
        ///   System.Boolean get_hasDirection()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDirection")]
        ///  extern System.Boolean GET_HAS_DIRECTION ();


        /// <summary>
        ///   System.Boolean get_hasDockRepair()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDockRepair")]
        ///  extern System.Boolean GET_HAS_DOCK_REPAIR ();


        /// <summary>
        ///   System.Boolean get_hasDockRepairBeacon()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDockRepairBeacon")]
        ///  extern System.Boolean GET_HAS_DOCK_REPAIR_BEACON ();


        /// <summary>
        ///   System.Boolean get_hasDockRepairOccupantsUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDockRepairOccupantsUpdatedEvent")]
        ///  extern System.Boolean GET_HAS_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasEnemyShipBehaviour()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEnemyShipBehaviour")]
        ///  extern System.Boolean GET_HAS_ENEMY_SHIP_BEHAVIOUR ();


        /// <summary>
        ///   System.Boolean get_hasEquipItemCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquipItemCommand")]
        ///  extern System.Boolean GET_HAS_EQUIP_ITEM_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasEquipment()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquipment")]
        ///  extern System.Boolean GET_HAS_EQUIPMENT ();


        /// <summary>
        ///   System.Boolean get_hasEquipmentChangedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquipmentChangedEvent")]
        ///  extern System.Boolean GET_HAS_EQUIPMENT_CHANGED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasEquipmentEffects()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquipmentEffects")]
        ///  extern System.Boolean GET_HAS_EQUIPMENT_EFFECTS ();


        /// <summary>
        ///   System.Boolean get_hasEquipmentItemData()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquipmentItemData")]
        ///  extern System.Boolean GET_HAS_EQUIPMENT_ITEM_DATA ();


        /// <summary>
        ///   System.Boolean get_hasEquippedItems()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquippedItems")]
        ///  extern System.Boolean GET_HAS_EQUIPPED_ITEMS ();


        /// <summary>
        ///   System.Boolean get_hasEquippedPlayerShipSpells()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquippedPlayerShipSpells")]
        ///  extern System.Boolean GET_HAS_EQUIPPED_PLAYER_SHIP_SPELLS ();


        /// <summary>
        ///   System.Boolean get_hasEquippedShipBlueprints()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquippedShipBlueprints")]
        ///  extern System.Boolean GET_HAS_EQUIPPED_SHIP_BLUEPRINTS ();


        /// <summary>
        ///   System.Boolean get_hasEquippedSpells()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquippedSpells")]
        ///  extern System.Boolean GET_HAS_EQUIPPED_SPELLS ();


        /// <summary>
        ///   System.Boolean get_hasFacing()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFacing")]
        ///  extern System.Boolean GET_HAS_FACING ();


        /// <summary>
        ///   System.Boolean get_hasFadeDuration()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFadeDuration")]
        ///  extern System.Boolean GET_HAS_FADE_DURATION ();


        /// <summary>
        ///   System.Boolean get_hasFiringPoint()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFiringPoint")]
        ///  extern System.Boolean GET_HAS_FIRING_POINT ();


        /// <summary>
        ///   System.Boolean get_hasFloatTransitionEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFloatTransitionEvent")]
        ///  extern System.Boolean GET_HAS_FLOAT_TRANSITION_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasFoam()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFoam")]
        ///  extern System.Boolean GET_HAS_FOAM ();


        /// <summary>
        ///   System.Boolean get_hasGameDestroyedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameDestroyedListener")]
        ///  extern System.Boolean GET_HAS_GAME_DESTROYED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasGameDifficulty()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameDifficulty")]
        ///  extern System.Boolean GET_HAS_GAME_DIFFICULTY ();


        /// <summary>
        ///   System.Boolean get_hasGameDifficultyDamageModifier()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameDifficultyDamageModifier")]
        ///  extern System.Boolean GET_HAS_GAME_DIFFICULTY_DAMAGE_MODIFIER ();


        /// <summary>
        ///   System.Boolean get_hasGameDifficultyHeathModifier()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameDifficultyHeathModifier")]
        ///  extern System.Boolean GET_HAS_GAME_DIFFICULTY_HEATH_MODIFIER ();


        /// <summary>
        ///   System.Boolean get_hasGameEntityId()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameEntityId")]
        ///  extern System.Boolean GET_HAS_GAME_ENTITY_ID ();


        /// <summary>
        ///   System.Boolean get_hasGameOverEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameOverEvent")]
        ///  extern System.Boolean GET_HAS_GAME_OVER_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasGameOverNoSaveOverride()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameOverNoSaveOverride")]
        ///  extern System.Boolean GET_HAS_GAME_OVER_NO_SAVE_OVERRIDE ();


        /// <summary>
        ///   System.Boolean get_hasGraphicObjContainer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGraphicObjContainer")]
        ///  extern System.Boolean GET_HAS_GRAPHIC_OBJ_CONTAINER ();


        /// <summary>
        ///   System.Boolean get_hasGunAmmo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGunAmmo")]
        ///  extern System.Boolean GET_HAS_GUN_AMMO ();


        /// <summary>
        ///   System.Boolean get_hasGunReload()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGunReload")]
        ///  extern System.Boolean GET_HAS_GUN_RELOAD ();


        /// <summary>
        ///   System.Boolean get_hasGunReloadProgress()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGunReloadProgress")]
        ///  extern System.Boolean GET_HAS_GUN_RELOAD_PROGRESS ();


        /// <summary>
        ///   System.Boolean get_hasGunReloadProgressListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGunReloadProgressListener")]
        ///  extern System.Boolean GET_HAS_GUN_RELOAD_PROGRESS_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasGunReloadTimer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGunReloadTimer")]
        ///  extern System.Boolean GET_HAS_GUN_RELOAD_TIMER ();


        /// <summary>
        ///   System.Boolean get_hasHealCompletedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHealCompletedEvent")]
        ///  extern System.Boolean GET_HAS_HEAL_COMPLETED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasHealer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHealer")]
        ///  extern System.Boolean GET_HAS_HEALER ();


        /// <summary>
        ///   System.Boolean get_hasHealStartedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHealStartedEvent")]
        ///  extern System.Boolean GET_HAS_HEAL_STARTED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasHealth()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHealth")]
        ///  extern System.Boolean GET_HAS_HEALTH ();


        /// <summary>
        ///   System.Boolean get_hasHealthRegenTickCounter()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHealthRegenTickCounter")]
        ///  extern System.Boolean GET_HAS_HEALTH_REGEN_TICK_COUNTER ();


        /// <summary>
        ///   System.Boolean get_hasHealthStat()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHealthStat")]
        ///  extern System.Boolean GET_HAS_HEALTH_STAT ();


        /// <summary>
        ///   System.Boolean get_hasHitStop()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHitStop")]
        ///  extern System.Boolean GET_HAS_HIT_STOP ();


        /// <summary>
        ///   System.Boolean get_hasHitStopEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHitStopEvent")]
        ///  extern System.Boolean GET_HAS_HIT_STOP_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasId()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasId")]
        ///  extern System.Boolean GET_HAS_ID ();


        /// <summary>
        ///   System.Boolean get_hasIFrame()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasIFrame")]
        ///  extern System.Boolean GET_HAS_I_FRAME ();


        /// <summary>
        ///   System.Boolean get_hasInfinityTowerTimer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInfinityTowerTimer")]
        ///  extern System.Boolean GET_HAS_INFINITY_TOWER_TIMER ();


        /// <summary>
        ///   System.Boolean get_hasInHealRegion()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInHealRegion")]
        ///  extern System.Boolean GET_HAS_IN_HEAL_REGION ();


        /// <summary>
        ///   System.Boolean get_hasInitialDirection()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInitialDirection")]
        ///  extern System.Boolean GET_HAS_INITIAL_DIRECTION ();


        /// <summary>
        ///   System.Boolean get_hasInitialPosition()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInitialPosition")]
        ///  extern System.Boolean GET_HAS_INITIAL_POSITION ();


        /// <summary>
        ///   System.Boolean get_hasInPotentialHealRegion()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInPotentialHealRegion")]
        ///  extern System.Boolean GET_HAS_IN_POTENTIAL_HEAL_REGION ();


        /// <summary>
        ///   System.Boolean get_hasInputStateCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInputStateCommand")]
        ///  extern System.Boolean GET_HAS_INPUT_STATE_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasInstancePortal()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInstancePortal")]
        ///  extern System.Boolean GET_HAS_INSTANCE_PORTAL ();


        /// <summary>
        ///   System.Boolean get_hasIntCounter()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasIntCounter")]
        ///  extern System.Boolean GET_HAS_INT_COUNTER ();


        /// <summary>
        ///   System.Boolean get_hasInteractable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInteractable")]
        ///  extern System.Boolean GET_HAS_INTERACTABLE ();


        /// <summary>
        ///   System.Boolean get_hasInteractableFailInteractableEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInteractableFailInteractableEvent")]
        ///  extern System.Boolean GET_HAS_INTERACTABLE_FAIL_INTERACTABLE_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasInteractableFailValidateEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInteractableFailValidateEvent")]
        ///  extern System.Boolean GET_HAS_INTERACTABLE_FAIL_VALIDATE_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasInteractableStatus()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInteractableStatus")]
        ///  extern System.Boolean GET_HAS_INTERACTABLE_STATUS ();


        /// <summary>
        ///   System.Boolean get_hasInteractableStatusUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInteractableStatusUpdatedEvent")]
        ///  extern System.Boolean GET_HAS_INTERACTABLE_STATUS_UPDATED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasInteractableTriggeredTargetEntitiesUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInteractableTriggeredTargetEntitiesUpdatedEvent")]
        ///  extern System.Boolean GET_HAS_INTERACTABLE_TRIGGERED_TARGET_ENTITIES_UPDATED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasInteractCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInteractCommand")]
        ///  extern System.Boolean GET_HAS_INTERACT_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasInteractCommandUpdate()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInteractCommandUpdate")]
        ///  extern System.Boolean GET_HAS_INTERACT_COMMAND_UPDATE ();


        /// <summary>
        ///   System.Boolean get_hasInteractLookAt()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInteractLookAt")]
        ///  extern System.Boolean GET_HAS_INTERACT_LOOK_AT ();



        /// <summary>
        ///   System.Void AddUpdatedGunAmmoListener(System.Collections.Generic.List<IUpdatedGunAmmoListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUpdatedGunAmmoListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUpdatedGunAmmoListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_UPDATED_GUN_AMMO_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddUpdatedGunAmmoListener(IUpdatedGunAmmoListener value)
        /// </summary>
        /// <param name="value">interface IUpdatedGunAmmoListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUpdatedGunAmmoListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_UPDATED_GUN_AMMO_LISTENER_01 (nint value);


        /// <summary>
        ///   Entitas.IComponent CreateComponent(System.Int32 index, System.Type type)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>interface Entitas.IComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_GameEntity))]
        ///  extern nint CREATE_COMPONENT_00 (System.Int32 index, nint type);


        /// <summary>
        ///   T CreateComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_GameEntity))]
        ///  extern nint CREATE_COMPONENT_01 (System.Int32 index);


        /// public static partial class Search_GameEntity
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void AddUpdatedGunAmmoListener(System.Collections.Generic.List<IUpdatedGunAmmoListener> newValue)
        /// </summary>
        /// public static bool ADD_UPDATED_GUN_AMMO_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUpdatedGunAmmoListener", "System.Collections.Generic.List<IUpdatedGunAmmoListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddUpdatedGunAmmoListener(IUpdatedGunAmmoListener value)
        /// </summary>
        /// public static bool ADD_UPDATED_GUN_AMMO_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUpdatedGunAmmoListener", "IUpdatedGunAmmoListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   Entitas.IComponent CreateComponent(System.Int32 index, System.Type type)
        /// </summary>
        /// public static bool CREATE_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateComponent", "System.Int32", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T CreateComponent(System.Int32 index)
        /// </summary>
        /// public static bool CREATE_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateComponent", "System.Int32");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["ProjectStar".""."GameEntity"]
    /// </summary>
    public partial class GameEntity
    {



        /// <summary>
        ///   System.Boolean get_hasInventoryCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInventoryCommand")]
        ///  extern System.Boolean GET_HAS_INVENTORY_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasInventoryLevel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInventoryLevel")]
        ///  extern System.Boolean GET_HAS_INVENTORY_LEVEL ();


        /// <summary>
        ///   System.Boolean get_hasInventorySpellInfo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInventorySpellInfo")]
        ///  extern System.Boolean GET_HAS_INVENTORY_SPELL_INFO ();


        /// <summary>
        ///   System.Boolean get_hasInvisibleWall()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInvisibleWall")]
        ///  extern System.Boolean GET_HAS_INVISIBLE_WALL ();


        /// <summary>
        ///   System.Boolean get_hasinWall()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasinWall")]
        ///  extern System.Boolean GET_HASIN_WALL ();


        /// <summary>
        ///   System.Boolean get_hasKilledListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasKilledListener")]
        ///  extern System.Boolean GET_HAS_KILLED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasKnockbackMultiplier()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasKnockbackMultiplier")]
        ///  extern System.Boolean GET_HAS_KNOCKBACK_MULTIPLIER ();


        /// <summary>
        ///   System.Boolean get_hasLastSeenDuration()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLastSeenDuration")]
        ///  extern System.Boolean GET_HAS_LAST_SEEN_DURATION ();


        /// <summary>
        ///   System.Boolean get_hasLatestInfinityTowerClearedWave()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLatestInfinityTowerClearedWave")]
        ///  extern System.Boolean GET_HAS_LATEST_INFINITY_TOWER_CLEARED_WAVE ();


        /// <summary>
        ///   System.Boolean get_hasLifetime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLifetime")]
        ///  extern System.Boolean GET_HAS_LIFETIME ();


        /// <summary>
        ///   System.Boolean get_hasLifetimeTarget()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLifetimeTarget")]
        ///  extern System.Boolean GET_HAS_LIFETIME_TARGET ();


        /// <summary>
        ///   System.Boolean get_hasLocationData()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLocationData")]
        ///  extern System.Boolean GET_HAS_LOCATION_DATA ();


        /// <summary>
        ///   System.Boolean get_hasLootDropLevel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLootDropLevel")]
        ///  extern System.Boolean GET_HAS_LOOT_DROP_LEVEL ();


        /// <summary>
        ///   System.Boolean get_hasLootMagnet()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLootMagnet")]
        ///  extern System.Boolean GET_HAS_LOOT_MAGNET ();


        /// <summary>
        ///   System.Boolean get_hasLootMultiplier()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLootMultiplier")]
        ///  extern System.Boolean GET_HAS_LOOT_MULTIPLIER ();


        /// <summary>
        ///   System.Boolean get_hasLootTable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLootTable")]
        ///  extern System.Boolean GET_HAS_LOOT_TABLE ();


        /// <summary>
        ///   System.Boolean get_hasLootTimer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLootTimer")]
        ///  extern System.Boolean GET_HAS_LOOT_TIMER ();


        /// <summary>
        ///   System.Boolean get_hasMagicStat()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMagicStat")]
        ///  extern System.Boolean GET_HAS_MAGIC_STAT ();


        /// <summary>
        ///   System.Boolean get_hasMainSprite()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMainSprite")]
        ///  extern System.Boolean GET_HAS_MAIN_SPRITE ();


        /// <summary>
        ///   System.Boolean get_hasMana()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMana")]
        ///  extern System.Boolean GET_HAS_MANA ();


        /// <summary>
        ///   System.Boolean get_hasManaBar()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasManaBar")]
        ///  extern System.Boolean GET_HAS_MANA_BAR ();


        /// <summary>
        ///   System.Boolean get_hasMapIconDisplayLink()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapIconDisplayLink")]
        ///  extern System.Boolean GET_HAS_MAP_ICON_DISPLAY_LINK ();


        /// <summary>
        ///   System.Boolean get_hasMapMarkerWorld()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapMarkerWorld")]
        ///  extern System.Boolean GET_HAS_MAP_MARKER_WORLD ();


        /// <summary>
        ///   System.Boolean get_hasMapMarkerWorldIndex()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapMarkerWorldIndex")]
        ///  extern System.Boolean GET_HAS_MAP_MARKER_WORLD_INDEX ();


        /// <summary>
        ///   System.Boolean get_hasMaxMoveSpeed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMaxMoveSpeed")]
        ///  extern System.Boolean GET_HAS_MAX_MOVE_SPEED ();


        /// <summary>
        ///   System.Boolean get_hasMeleeAttackCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMeleeAttackCommand")]
        ///  extern System.Boolean GET_HAS_MELEE_ATTACK_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasMonsterBehaviour()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMonsterBehaviour")]
        ///  extern System.Boolean GET_HAS_MONSTER_BEHAVIOUR ();


        /// <summary>
        ///   System.Boolean get_hasMonsterDetector()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMonsterDetector")]
        ///  extern System.Boolean GET_HAS_MONSTER_DETECTOR ();


        /// <summary>
        ///   System.Boolean get_hasMonsterDetectorInfo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMonsterDetectorInfo")]
        ///  extern System.Boolean GET_HAS_MONSTER_DETECTOR_INFO ();


        /// <summary>
        ///   System.Boolean get_hasMonsterDetectorRequestor()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMonsterDetectorRequestor")]
        ///  extern System.Boolean GET_HAS_MONSTER_DETECTOR_REQUESTOR ();


        /// <summary>
        ///   System.Boolean get_hasMonsterDetectorResultInfo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMonsterDetectorResultInfo")]
        ///  extern System.Boolean GET_HAS_MONSTER_DETECTOR_RESULT_INFO ();


        /// <summary>
        ///   System.Boolean get_hasMonsterTrait()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMonsterTrait")]
        ///  extern System.Boolean GET_HAS_MONSTER_TRAIT ();


        /// <summary>
        ///   System.Boolean get_hasMoveSpeed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMoveSpeed")]
        ///  extern System.Boolean GET_HAS_MOVE_SPEED ();


        /// <summary>
        ///   System.Boolean get_hasNavAgentTarget()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasNavAgentTarget")]
        ///  extern System.Boolean GET_HAS_NAV_AGENT_TARGET ();


        /// <summary>
        ///   System.Boolean get_hasNavMeshAgent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasNavMeshAgent")]
        ///  extern System.Boolean GET_HAS_NAV_MESH_AGENT ();


        /// <summary>
        ///   System.Boolean get_hasNavPath()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasNavPath")]
        ///  extern System.Boolean GET_HAS_NAV_PATH ();


        /// <summary>
        ///   System.Boolean get_hasNotEnoughGunAmmoEventListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasNotEnoughGunAmmoEventListener")]
        ///  extern System.Boolean GET_HAS_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasObjectiveInteractor()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasObjectiveInteractor")]
        ///  extern System.Boolean GET_HAS_OBJECTIVE_INTERACTOR ();


        /// <summary>
        ///   System.Boolean get_hasOnDeathAnimCompleteEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOnDeathAnimCompleteEvent")]
        ///  extern System.Boolean GET_HAS_ON_DEATH_ANIM_COMPLETE_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasOnDeathEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOnDeathEvent")]
        ///  extern System.Boolean GET_HAS_ON_DEATH_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasOnHitIFrameData()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOnHitIFrameData")]
        ///  extern System.Boolean GET_HAS_ON_HIT_I_FRAME_DATA ();


        /// <summary>
        ///   System.Boolean get_hasOnReviveCallback()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOnReviveCallback")]
        ///  extern System.Boolean GET_HAS_ON_REVIVE_CALLBACK ();


        /// <summary>
        ///   System.Boolean get_hasOriginalLocalScale()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOriginalLocalScale")]
        ///  extern System.Boolean GET_HAS_ORIGINAL_LOCAL_SCALE ();


        /// <summary>
        ///   System.Boolean get_hasOverlapList()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOverlapList")]
        ///  extern System.Boolean GET_HAS_OVERLAP_LIST ();


        /// <summary>
        ///   System.Boolean get_hasOverrideCharacterGender()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOverrideCharacterGender")]
        ///  extern System.Boolean GET_HAS_OVERRIDE_CHARACTER_GENDER ();


        /// <summary>
        ///   System.Boolean get_hasOwner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOwner")]
        ///  extern System.Boolean GET_HAS_OWNER ();


        /// <summary>
        ///   System.Boolean get_hasParticleEffect()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasParticleEffect")]
        ///  extern System.Boolean GET_HAS_PARTICLE_EFFECT ();


        /// <summary>
        ///   System.Boolean get_hasPlayerAddedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerAddedEvent")]
        ///  extern System.Boolean GET_HAS_PLAYER_ADDED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasPlayerId()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerId")]
        ///  extern System.Boolean GET_HAS_PLAYER_ID ();


        /// <summary>
        ///   System.Boolean get_hasPlayerIdListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerIdListener")]
        ///  extern System.Boolean GET_HAS_PLAYER_ID_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasPlayerIdReference()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerIdReference")]
        ///  extern System.Boolean GET_HAS_PLAYER_ID_REFERENCE ();


        /// <summary>
        ///   System.Boolean get_hasPlayerIdRemovedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerIdRemovedListener")]
        ///  extern System.Boolean GET_HAS_PLAYER_ID_REMOVED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasPlayerKilledSource()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerKilledSource")]
        ///  extern System.Boolean GET_HAS_PLAYER_KILLED_SOURCE ();


        /// <summary>
        ///   System.Boolean get_hasPlayerReference()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerReference")]
        ///  extern System.Boolean GET_HAS_PLAYER_REFERENCE ();


        /// <summary>
        ///   System.Boolean get_hasPlayerRemovedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerRemovedEvent")]
        ///  extern System.Boolean GET_HAS_PLAYER_REMOVED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasPlayerSleepingSaveStone()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerSleepingSaveStone")]
        ///  extern System.Boolean GET_HAS_PLAYER_SLEEPING_SAVE_STONE ();


        /// <summary>
        ///   System.Boolean get_hasPlayerStat()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerStat")]
        ///  extern System.Boolean GET_HAS_PLAYER_STAT ();


        /// <summary>
        ///   System.Boolean get_hasPlayerVicinity()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerVicinity")]
        ///  extern System.Boolean GET_HAS_PLAYER_VICINITY ();


        /// <summary>
        ///   System.Boolean get_hasPoolStatusTable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPoolStatusTable")]
        ///  extern System.Boolean GET_HAS_POOL_STATUS_TABLE ();


        /// <summary>
        ///   System.Boolean get_hasPosition()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPosition")]
        ///  extern System.Boolean GET_HAS_POSITION ();


        /// <summary>
        ///   System.Boolean get_hasPositionAttach()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPositionAttach")]
        ///  extern System.Boolean GET_HAS_POSITION_ATTACH ();


        /// <summary>
        ///   System.Boolean get_hasPositionHistory()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPositionHistory")]
        ///  extern System.Boolean GET_HAS_POSITION_HISTORY ();


        /// <summary>
        ///   System.Boolean get_hasPositionTween()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPositionTween")]
        ///  extern System.Boolean GET_HAS_POSITION_TWEEN ();


        /// <summary>
        ///   System.Boolean get_hasProjectileBehaviour()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasProjectileBehaviour")]
        ///  extern System.Boolean GET_HAS_PROJECTILE_BEHAVIOUR ();


        /// <summary>
        ///   System.Boolean get_hasProjectileColliderInfo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasProjectileColliderInfo")]
        ///  extern System.Boolean GET_HAS_PROJECTILE_COLLIDER_INFO ();


        /// <summary>
        ///   System.Boolean get_hasProjectileInfo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasProjectileInfo")]
        ///  extern System.Boolean GET_HAS_PROJECTILE_INFO ();


        /// <summary>
        ///   System.Boolean get_hasProjectileMovement()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasProjectileMovement")]
        ///  extern System.Boolean GET_HAS_PROJECTILE_MOVEMENT ();


        /// <summary>
        ///   System.Boolean get_hasProjectileReference()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasProjectileReference")]
        ///  extern System.Boolean GET_HAS_PROJECTILE_REFERENCE ();


        /// <summary>
        ///   System.Boolean get_hasProjectileVfxReference()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasProjectileVfxReference")]
        ///  extern System.Boolean GET_HAS_PROJECTILE_VFX_REFERENCE ();


        /// <summary>
        ///   System.Boolean get_hasPromptRemovePlayerEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPromptRemovePlayerEvent")]
        ///  extern System.Boolean GET_HAS_PROMPT_REMOVE_PLAYER_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasPuzzleAnswer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPuzzleAnswer")]
        ///  extern System.Boolean GET_HAS_PUZZLE_ANSWER ();


        /// <summary>
        ///   System.Boolean get_hasPuzzleAnswerCompletedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPuzzleAnswerCompletedEvent")]
        ///  extern System.Boolean GET_HAS_PUZZLE_ANSWER_COMPLETED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasPuzzleAnswerState()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPuzzleAnswerState")]
        ///  extern System.Boolean GET_HAS_PUZZLE_ANSWER_STATE ();


        /// <summary>
        ///   System.Boolean get_hasPuzzleLootLocation()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPuzzleLootLocation")]
        ///  extern System.Boolean GET_HAS_PUZZLE_LOOT_LOCATION ();


        /// <summary>
        ///   System.Boolean get_hasPuzzlePieceID()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPuzzlePieceID")]
        ///  extern System.Boolean GET_HAS_PUZZLE_PIECE_ID ();


        /// <summary>
        ///   System.Boolean get_hasPuzzlePieceInteractedCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPuzzlePieceInteractedCount")]
        ///  extern System.Boolean GET_HAS_PUZZLE_PIECE_INTERACTED_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasPuzzlePieceInteractedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPuzzlePieceInteractedEvent")]
        ///  extern System.Boolean GET_HAS_PUZZLE_PIECE_INTERACTED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasQuestFsm()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasQuestFsm")]
        ///  extern System.Boolean GET_HAS_QUEST_FSM ();


        /// <summary>
        ///   System.Boolean get_hasRecovery()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRecovery")]
        ///  extern System.Boolean GET_HAS_RECOVERY ();


        /// <summary>
        ///   System.Boolean get_hasRendererTinter()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRendererTinter")]
        ///  extern System.Boolean GET_HAS_RENDERER_TINTER ();


        /// <summary>
        ///   System.Boolean get_hasRenderTransform()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRenderTransform")]
        ///  extern System.Boolean GET_HAS_RENDER_TRANSFORM ();


        /// <summary>
        ///   System.Boolean get_hasRestTriggeredEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRestTriggeredEvent")]
        ///  extern System.Boolean GET_HAS_REST_TRIGGERED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasReviveBeacon()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasReviveBeacon")]
        ///  extern System.Boolean GET_HAS_REVIVE_BEACON ();


        /// <summary>
        ///   System.Boolean get_hasReviveBeaconReference()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasReviveBeaconReference")]
        ///  extern System.Boolean GET_HAS_REVIVE_BEACON_REFERENCE ();


        /// <summary>
        ///   System.Boolean get_hasReviveEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasReviveEvent")]
        ///  extern System.Boolean GET_HAS_REVIVE_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasRigidbody()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRigidbody")]
        ///  extern System.Boolean GET_HAS_RIGIDBODY ();


        /// <summary>
        ///   System.Boolean get_hasRollCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRollCommand")]
        ///  extern System.Boolean GET_HAS_ROLL_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasRollCooldown()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRollCooldown")]
        ///  extern System.Boolean GET_HAS_ROLL_COOLDOWN ();


        /// <summary>
        ///   System.Boolean get_hasRollCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRollCount")]
        ///  extern System.Boolean GET_HAS_ROLL_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasRotationTween()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRotationTween")]
        ///  extern System.Boolean GET_HAS_ROTATION_TWEEN ();


        /// <summary>
        ///   System.Boolean get_hasSaveStone()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSaveStone")]
        ///  extern System.Boolean GET_HAS_SAVE_STONE ();


        /// <summary>
        ///   System.Boolean get_hasScreenEffect()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasScreenEffect")]
        ///  extern System.Boolean GET_HAS_SCREEN_EFFECT ();


        /// <summary>
        ///   System.Boolean get_hasScreenEffectPlayer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasScreenEffectPlayer")]
        ///  extern System.Boolean GET_HAS_SCREEN_EFFECT_PLAYER ();


        /// <summary>
        ///   System.Boolean get_hasSecondPlayer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSecondPlayer")]
        ///  extern System.Boolean GET_HAS_SECOND_PLAYER ();


        /// <summary>
        ///   System.Boolean get_hasSelectedTavernTalesData()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSelectedTavernTalesData")]
        ///  extern System.Boolean GET_HAS_SELECTED_TAVERN_TALES_DATA ();


        /// <summary>
        ///   System.Boolean get_hasShadow()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShadow")]
        ///  extern System.Boolean GET_HAS_SHADOW ();


        /// <summary>
        ///   System.Boolean get_hasShipBlueprintEffects()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipBlueprintEffects")]
        ///  extern System.Boolean GET_HAS_SHIP_BLUEPRINT_EFFECTS ();


        /// <summary>
        ///   System.Boolean get_hasShipBlueprintItemData()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipBlueprintItemData")]
        ///  extern System.Boolean GET_HAS_SHIP_BLUEPRINT_ITEM_DATA ();


        /// <summary>
        ///   System.Boolean get_hasShipBlueprintsRefreshedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipBlueprintsRefreshedEvent")]
        ///  extern System.Boolean GET_HAS_SHIP_BLUEPRINTS_REFRESHED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasShipBoost()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipBoost")]
        ///  extern System.Boolean GET_HAS_SHIP_BOOST ();


        /// <summary>
        ///   System.Boolean get_hasShipCannon()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipCannon")]
        ///  extern System.Boolean GET_HAS_SHIP_CANNON ();


        /// <summary>
        ///   System.Boolean get_hasShipCannonAttackConfig()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipCannonAttackConfig")]
        ///  extern System.Boolean GET_HAS_SHIP_CANNON_ATTACK_CONFIG ();


        /// <summary>
        ///   System.Boolean get_hasShipCannonRotationDelta()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipCannonRotationDelta")]
        ///  extern System.Boolean GET_HAS_SHIP_CANNON_ROTATION_DELTA ();


        /// <summary>
        ///   System.Boolean get_hasShipConfig()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipConfig")]
        ///  extern System.Boolean GET_HAS_SHIP_CONFIG ();


        /// <summary>
        ///   System.Boolean get_hasShipDock()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipDock")]
        ///  extern System.Boolean GET_HAS_SHIP_DOCK ();


        /// <summary>
        ///   System.Boolean get_hasShipEnterCamFocusRuntimeScreenEffect()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipEnterCamFocusRuntimeScreenEffect")]
        ///  extern System.Boolean GET_HAS_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT ();


        /// <summary>
        ///   System.Boolean get_hasShipExitSensorRange()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipExitSensorRange")]
        ///  extern System.Boolean GET_HAS_SHIP_EXIT_SENSOR_RANGE ();


        /// <summary>
        ///   System.Boolean get_hasShipFeedbackState()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipFeedbackState")]
        ///  extern System.Boolean GET_HAS_SHIP_FEEDBACK_STATE ();


        /// <summary>
        ///   System.Boolean get_hasShipMovementPoint()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipMovementPoint")]
        ///  extern System.Boolean GET_HAS_SHIP_MOVEMENT_POINT ();


        /// <summary>
        ///   System.Boolean get_hasShipPassengerUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipPassengerUpdatedEvent")]
        ///  extern System.Boolean GET_HAS_SHIP_PASSENGER_UPDATED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasShipPathAgent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipPathAgent")]
        ///  extern System.Boolean GET_HAS_SHIP_PATH_AGENT ();


        /// <summary>
        ///   System.Boolean get_hasShipReference()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipReference")]
        ///  extern System.Boolean GET_HAS_SHIP_REFERENCE ();


        /// <summary>
        ///   System.Boolean get_hasShipSailInfo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipSailInfo")]
        ///  extern System.Boolean GET_HAS_SHIP_SAIL_INFO ();


        /// <summary>
        ///   System.Boolean get_hasShipSpecialAttackConfig()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipSpecialAttackConfig")]
        ///  extern System.Boolean GET_HAS_SHIP_SPECIAL_ATTACK_CONFIG ();


        /// <summary>
        ///   System.Boolean get_hasSoundStatesReference()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSoundStatesReference")]
        ///  extern System.Boolean GET_HAS_SOUND_STATES_REFERENCE ();


        /// <summary>
        ///   System.Boolean get_hasSource()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSource")]
        ///  extern System.Boolean GET_HAS_SOURCE ();


        /// <summary>
        ///   System.Boolean get_hasSourceTransform()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSourceTransform")]
        ///  extern System.Boolean GET_HAS_SOURCE_TRANSFORM ();


        /// <summary>
        ///   System.Boolean get_hasSpawnerOverrideDuration()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpawnerOverrideDuration")]
        ///  extern System.Boolean GET_HAS_SPAWNER_OVERRIDE_DURATION ();


        /// <summary>
        ///   System.Boolean get_hasSpawnTableItem()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpawnTableItem")]
        ///  extern System.Boolean GET_HAS_SPAWN_TABLE_ITEM ();


        /// <summary>
        ///   System.Boolean get_hasSpawnTextEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpawnTextEvent")]
        ///  extern System.Boolean GET_HAS_SPAWN_TEXT_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasSpeedTween()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpeedTween")]
        ///  extern System.Boolean GET_HAS_SPEED_TWEEN ();


        /// <summary>
        ///   System.Boolean get_hasSpellCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpellCommand")]
        ///  extern System.Boolean GET_HAS_SPELL_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasSpellConfig()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpellConfig")]
        ///  extern System.Boolean GET_HAS_SPELL_CONFIG ();


        /// <summary>
        ///   System.Boolean get_hasSpellLevelConfig()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpellLevelConfig")]
        ///  extern System.Boolean GET_HAS_SPELL_LEVEL_CONFIG ();


        /// <summary>
        ///   System.Boolean get_hasSpellReference()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpellReference")]
        ///  extern System.Boolean GET_HAS_SPELL_REFERENCE ();


        /// <summary>
        ///   System.Boolean get_hasSpellTracker()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpellTracker")]
        ///  extern System.Boolean GET_HAS_SPELL_TRACKER ();


        /// <summary>
        ///   System.Boolean get_hasStarGuide()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasStarGuide")]
        ///  extern System.Boolean GET_HAS_STAR_GUIDE ();


        /// <summary>
        ///   System.Boolean get_hasStarGuideManager()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasStarGuideManager")]
        ///  extern System.Boolean GET_HAS_STAR_GUIDE_MANAGER ();


        /// <summary>
        ///   System.Boolean get_hasStrafeLane()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasStrafeLane")]
        ///  extern System.Boolean GET_HAS_STRAFE_LANE ();


        /// <summary>
        ///   System.Boolean get_hasStrengthStat()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasStrengthStat")]
        ///  extern System.Boolean GET_HAS_STRENGTH_STAT ();


        /// <summary>
        ///   System.Boolean get_hasSwapWeaponCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSwapWeaponCommand")]
        ///  extern System.Boolean GET_HAS_SWAP_WEAPON_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasTakeDamageEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTakeDamageEvent")]
        ///  extern System.Boolean GET_HAS_TAKE_DAMAGE_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasTarget()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTarget")]
        ///  extern System.Boolean GET_HAS_TARGET ();


        /// <summary>
        ///   System.Boolean get_hasTargetList()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTargetList")]
        ///  extern System.Boolean GET_HAS_TARGET_LIST ();


        /// <summary>
        ///   System.Boolean get_hasTargetPosition()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTargetPosition")]
        ///  extern System.Boolean GET_HAS_TARGET_POSITION ();


        /// <summary>
        ///   System.Boolean get_hasTargetTransform()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTargetTransform")]
        ///  extern System.Boolean GET_HAS_TARGET_TRANSFORM ();


        /// <summary>
        ///   System.Boolean get_hasTeleportCallback()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTeleportCallback")]
        ///  extern System.Boolean GET_HAS_TELEPORT_CALLBACK ();


        /// <summary>
        ///   System.Boolean get_hasTerrainExploredCellsTable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTerrainExploredCellsTable")]
        ///  extern System.Boolean GET_HAS_TERRAIN_EXPLORED_CELLS_TABLE ();


        /// <summary>
        ///   System.Boolean get_hasTilt()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTilt")]
        ///  extern System.Boolean GET_HAS_TILT ();


        /// <summary>
        ///   System.Boolean get_hasTiltSpeed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTiltSpeed")]
        ///  extern System.Boolean GET_HAS_TILT_SPEED ();


        /// <summary>
        ///   System.Boolean get_hasTimedBuff()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTimedBuff")]
        ///  extern System.Boolean GET_HAS_TIMED_BUFF ();


        /// <summary>
        ///   System.Boolean get_hasTimer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTimer")]
        ///  extern System.Boolean GET_HAS_TIMER ();


        /// <summary>
        ///   System.Boolean get_hasTimerCallback()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTimerCallback")]
        ///  extern System.Boolean GET_HAS_TIMER_CALLBACK ();


        /// <summary>
        ///   System.Boolean get_hasTint()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTint")]
        ///  extern System.Boolean GET_HAS_TINT ();


        /// <summary>
        ///   System.Boolean get_hasTrailRenderer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTrailRenderer")]
        ///  extern System.Boolean GET_HAS_TRAIL_RENDERER ();


        /// <summary>
        ///   System.Boolean get_hasTransform()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTransform")]
        ///  extern System.Boolean GET_HAS_TRANSFORM ();


        /// <summary>
        ///   System.Boolean get_hasTransitioning()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTransitioning")]
        ///  extern System.Boolean GET_HAS_TRANSITIONING ();


        /// <summary>
        ///   System.Boolean get_hasTriggerableInteractableType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTriggerableInteractableType")]
        ///  extern System.Boolean GET_HAS_TRIGGERABLE_INTERACTABLE_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasTriggerHashSet()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTriggerHashSet")]
        ///  extern System.Boolean GET_HAS_TRIGGER_HASH_SET ();


        /// <summary>
        ///   System.Boolean get_hasTurnSpeed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTurnSpeed")]
        ///  extern System.Boolean GET_HAS_TURN_SPEED ();


        /// <summary>
        ///   System.Boolean get_hasUnequipItemCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnequipItemCommand")]
        ///  extern System.Boolean GET_HAS_UNEQUIP_ITEM_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasUnitConfig()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnitConfig")]
        ///  extern System.Boolean GET_HAS_UNIT_CONFIG ();


        /// <summary>
        ///   System.Boolean get_hasUnitLevel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnitLevel")]
        ///  extern System.Boolean GET_HAS_UNIT_LEVEL ();


        /// <summary>
        ///   System.Boolean get_hasUnlockedEquipmentList()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnlockedEquipmentList")]
        ///  extern System.Boolean GET_HAS_UNLOCKED_EQUIPMENT_LIST ();


        /// <summary>
        ///   System.Boolean get_hasUnlockedShipBlueprints()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnlockedShipBlueprints")]
        ///  extern System.Boolean GET_HAS_UNLOCKED_SHIP_BLUEPRINTS ();


        /// <summary>
        ///   System.Boolean get_hasUnlockedShipSpellTable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnlockedShipSpellTable")]
        ///  extern System.Boolean GET_HAS_UNLOCKED_SHIP_SPELL_TABLE ();


        /// <summary>
        ///   System.Boolean get_hasUnlockedSpellTable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnlockedSpellTable")]
        ///  extern System.Boolean GET_HAS_UNLOCKED_SPELL_TABLE ();


        /// <summary>
        ///   System.Boolean get_hasUpdatedGunAmmo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUpdatedGunAmmo")]
        ///  extern System.Boolean GET_HAS_UPDATED_GUN_AMMO ();


        /// <summary>
        ///   System.Boolean get_hasUpdatedGunAmmoListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUpdatedGunAmmoListener")]
        ///  extern System.Boolean GET_HAS_UPDATED_GUN_AMMO_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasVelocityBuffer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasVelocityBuffer")]
        ///  extern System.Boolean GET_HAS_VELOCITY_BUFFER ();


        /// <summary>
        ///   System.Boolean get_hasVFXFollowParent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasVFXFollowParent")]
        ///  extern System.Boolean GET_HAS_VFX_FOLLOW_PARENT ();


        /// <summary>
        ///   System.Boolean get_hasVFXSpawnpoint()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasVFXSpawnpoint")]
        ///  extern System.Boolean GET_HAS_VFX_SPAWNPOINT ();


        /// <summary>
        ///   System.Boolean get_hasWallColliders()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWallColliders")]
        ///  extern System.Boolean GET_HAS_WALL_COLLIDERS ();


        /// <summary>
        ///   System.Boolean get_hasWaterRipplesParticles()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWaterRipplesParticles")]
        ///  extern System.Boolean GET_HAS_WATER_RIPPLES_PARTICLES ();


        /// <summary>
        ///   System.Boolean get_hasWorldUIButtonAnchorPosOffset()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldUIButtonAnchorPosOffset")]
        ///  extern System.Boolean GET_HAS_WORLD_UI_BUTTON_ANCHOR_POS_OFFSET ();


        /// <summary>
        ///   System.Boolean get_hasWorldUIButtonAttachFlipSprite()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldUIButtonAttachFlipSprite")]
        ///  extern System.Boolean GET_HAS_WORLD_UI_BUTTON_ATTACH_FLIP_SPRITE ();


        /// <summary>
        ///   System.Boolean get_hasWorldUIButtonAttachParent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldUIButtonAttachParent")]
        ///  extern System.Boolean GET_HAS_WORLD_UI_BUTTON_ATTACH_PARENT ();


        /// <summary>
        ///   HealCompletedEventComponent get_healCompletedEvent()
        /// </summary>
        /// <returns>class HealCompletedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_healCompletedEvent")]
        ///  extern nint GET_HEAL_COMPLETED_EVENT ();


        /// <summary>
        ///   HealerComponent get_healer()
        /// </summary>
        /// <returns>class HealerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_healer")]
        ///  extern nint GET_HEALER ();


        /// <summary>
        ///   HealStartedEventComponent get_healStartedEvent()
        /// </summary>
        /// <returns>class HealStartedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_healStartedEvent")]
        ///  extern nint GET_HEAL_STARTED_EVENT ();


        /// <summary>
        ///   HealthComponent get_health()
        /// </summary>
        /// <returns>class HealthComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_health")]
        ///  extern nint GET_HEALTH ();


        /// <summary>
        ///   HealthRegenTickCounterComponent get_healthRegenTickCounter()
        /// </summary>
        /// <returns>class HealthRegenTickCounterComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_healthRegenTickCounter")]
        ///  extern nint GET_HEALTH_REGEN_TICK_COUNTER ();


        /// <summary>
        ///   HealthStatComponent get_healthStat()
        /// </summary>
        /// <returns>class HealthStatComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_healthStat")]
        ///  extern nint GET_HEALTH_STAT ();


        /// <summary>
        ///   HitStopComponent get_hitStop()
        /// </summary>
        /// <returns>class HitStopComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hitStop")]
        ///  extern nint GET_HIT_STOP ();


        /// <summary>
        ///   HitStopEventComponent get_hitStopEvent()
        /// </summary>
        /// <returns>class HitStopEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hitStopEvent")]
        ///  extern nint GET_HIT_STOP_EVENT ();


        /// <summary>
        ///   IdComponent get_id()
        /// </summary>
        /// <returns>class IdComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_id")]
        ///  extern nint GET_ID ();


        /// <summary>
        ///   IFrameComponent get_iFrame()
        /// </summary>
        /// <returns>class IFrameComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_iFrame")]
        ///  extern nint GET_I_FRAME ();


        /// <summary>
        ///   InfinityTowerTimerComponent get_infinityTowerTimer()
        /// </summary>
        /// <returns>class InfinityTowerTimerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_infinityTowerTimer")]
        ///  extern nint GET_INFINITY_TOWER_TIMER ();


        /// <summary>
        ///   InHealRegionComponent get_inHealRegion()
        /// </summary>
        /// <returns>class InHealRegionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inHealRegion")]
        ///  extern nint GET_IN_HEAL_REGION ();


        /// <summary>
        ///   InitialDirectionComponent get_initialDirection()
        /// </summary>
        /// <returns>class InitialDirectionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_initialDirection")]
        ///  extern nint GET_INITIAL_DIRECTION ();


        /// <summary>
        ///   InitialPositionComponent get_initialPosition()
        /// </summary>
        /// <returns>class InitialPositionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_initialPosition")]
        ///  extern nint GET_INITIAL_POSITION ();


        /// <summary>
        ///   InPotentialHealRegionComponent get_inPotentialHealRegion()
        /// </summary>
        /// <returns>class InPotentialHealRegionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inPotentialHealRegion")]
        ///  extern nint GET_IN_POTENTIAL_HEAL_REGION ();


        /// <summary>
        ///   InputStateCommandComponent get_inputStateCommand()
        /// </summary>
        /// <returns>class InputStateCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputStateCommand")]
        ///  extern nint GET_INPUT_STATE_COMMAND ();


        /// <summary>
        ///   InstancePortalComponent get_instancePortal()
        /// </summary>
        /// <returns>class InstancePortalComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_instancePortal")]
        ///  extern nint GET_INSTANCE_PORTAL ();


        /// <summary>
        ///   IntCounterComponent get_intCounter()
        /// </summary>
        /// <returns>class IntCounterComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_intCounter")]
        ///  extern nint GET_INT_COUNTER ();


        /// <summary>
        ///   InteractableComponent get_interactable()
        /// </summary>
        /// <returns>class InteractableComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_interactable")]
        ///  extern nint GET_INTERACTABLE ();


        /// <summary>
        ///   InteractableFailInteractableEventComponent get_interactableFailInteractableEvent()
        /// </summary>
        /// <returns>class InteractableFailInteractableEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_interactableFailInteractableEvent")]
        ///  extern nint GET_INTERACTABLE_FAIL_INTERACTABLE_EVENT ();


        /// <summary>
        ///   InteractableFailValidateEventComponent get_interactableFailValidateEvent()
        /// </summary>
        /// <returns>class InteractableFailValidateEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_interactableFailValidateEvent")]
        ///  extern nint GET_INTERACTABLE_FAIL_VALIDATE_EVENT ();


        /// <summary>
        ///   InteractableStatusComponent get_interactableStatus()
        /// </summary>
        /// <returns>class InteractableStatusComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_interactableStatus")]
        ///  extern nint GET_INTERACTABLE_STATUS ();


        /// <summary>
        ///   InteractableStatusUpdatedEventComponent get_interactableStatusUpdatedEvent()
        /// </summary>
        /// <returns>class InteractableStatusUpdatedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_interactableStatusUpdatedEvent")]
        ///  extern nint GET_INTERACTABLE_STATUS_UPDATED_EVENT ();


        /// <summary>
        ///   InteractableTriggeredTargetEntitiesUpdatedEventComponent get_interactableTriggeredTargetEntitiesUpdatedEvent()
        /// </summary>
        /// <returns>class InteractableTriggeredTargetEntitiesUpdatedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_interactableTriggeredTargetEntitiesUpdatedEvent")]
        ///  extern nint GET_INTERACTABLE_TRIGGERED_TARGET_ENTITIES_UPDATED_EVENT ();


        /// <summary>
        ///   InteractCommandComponent get_interactCommand()
        /// </summary>
        /// <returns>class InteractCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_interactCommand")]
        ///  extern nint GET_INTERACT_COMMAND ();


        /// <summary>
        ///   InteractCommandUpdateComponent get_interactCommandUpdate()
        /// </summary>
        /// <returns>class InteractCommandUpdateComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_interactCommandUpdate")]
        ///  extern nint GET_INTERACT_COMMAND_UPDATE ();


        /// <summary>
        ///   InteractLookAtComponent get_interactLookAt()
        /// </summary>
        /// <returns>class InteractLookAtComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_interactLookAt")]
        ///  extern nint GET_INTERACT_LOOK_AT ();


        /// <summary>
        ///   InventoryCommandComponent get_inventoryCommand()
        /// </summary>
        /// <returns>class InventoryCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryCommand")]
        ///  extern nint GET_INVENTORY_COMMAND ();


        /// <summary>
        ///   InventoryLevelComponent get_inventoryLevel()
        /// </summary>
        /// <returns>class InventoryLevelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryLevel")]
        ///  extern nint GET_INVENTORY_LEVEL ();


        /// <summary>
        ///   InventorySpellInfoComponent get_inventorySpellInfo()
        /// </summary>
        /// <returns>class InventorySpellInfoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventorySpellInfo")]
        ///  extern nint GET_INVENTORY_SPELL_INFO ();


        /// <summary>
        ///   InvisibleWallComponent get_invisibleWall()
        /// </summary>
        /// <returns>class InvisibleWallComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_invisibleWall")]
        ///  extern nint GET_INVISIBLE_WALL ();


        /// <summary>
        ///   inWallComponent get_inWall()
        /// </summary>
        /// <returns>class inWallComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inWall")]
        ///  extern nint GET_IN_WALL ();


        /// <summary>
        ///   System.Boolean get_isAddPlayerEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAddPlayerEvent")]
        ///  extern System.Boolean GET_IS_ADD_PLAYER_EVENT ();


        /// <summary>
        ///   System.Boolean get_isAnimationDone()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAnimationDone")]
        ///  extern System.Boolean GET_IS_ANIMATION_DONE ();


        /// <summary>
        ///   System.Boolean get_isAoeCastingHit()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAoeCastingHit")]
        ///  extern System.Boolean GET_IS_AOE_CASTING_HIT ();


        /// <summary>
        ///   System.Boolean get_isAoeCollision()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAoeCollision")]
        ///  extern System.Boolean GET_IS_AOE_COLLISION ();


        /// <summary>
        ///   System.Boolean get_isAoeTick()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAoeTick")]
        ///  extern System.Boolean GET_IS_AOE_TICK ();


        /// <summary>
        ///   System.Boolean get_isAoeTickingHit()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAoeTickingHit")]
        ///  extern System.Boolean GET_IS_AOE_TICKING_HIT ();


        /// <summary>
        ///   System.Boolean get_isAttachedProjectile()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAttachedProjectile")]
        ///  extern System.Boolean GET_IS_ATTACHED_PROJECTILE ();


        /// <summary>
        ///   System.Boolean get_isAttackDoHit()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAttackDoHit")]
        ///  extern System.Boolean GET_IS_ATTACK_DO_HIT ();


        /// <summary>
        ///   System.Boolean get_isAttacking()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAttacking")]
        ///  extern System.Boolean GET_IS_ATTACKING ();


        /// <summary>
        ///   System.Boolean get_isBossTrait()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isBossTrait")]
        ///  extern System.Boolean GET_IS_BOSS_TRAIT ();


        /// <summary>
        ///   System.Boolean get_isChargeAttacking()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isChargeAttacking")]
        ///  extern System.Boolean GET_IS_CHARGE_ATTACKING ();


        /// <summary>
        ///   System.Boolean get_isChargingAttack()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isChargingAttack")]
        ///  extern System.Boolean GET_IS_CHARGING_ATTACK ();


        /// <summary>
        ///   System.Boolean get_isCollectibleMagnetEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCollectibleMagnetEvent")]
        ///  extern System.Boolean GET_IS_COLLECTIBLE_MAGNET_EVENT ();


        /// <summary>
        ///   System.Boolean get_isCombatChecked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCombatChecked")]
        ///  extern System.Boolean GET_IS_COMBAT_CHECKED ();


        /// <summary>
        ///   System.Boolean get_isCulled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCulled")]
        ///  extern System.Boolean GET_IS_CULLED ();


        /// <summary>
        ///   System.Boolean get_isCulledVisuals()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCulledVisuals")]
        ///  extern System.Boolean GET_IS_CULLED_VISUALS ();


        /// <summary>
        ///   System.Boolean get_isCutSceneFastForward()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCutSceneFastForward")]
        ///  extern System.Boolean GET_IS_CUT_SCENE_FAST_FORWARD ();


        /// <summary>
        ///   System.Boolean get_isCutSceneFastForwardBlocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCutSceneFastForwardBlocked")]
        ///  extern System.Boolean GET_IS_CUT_SCENE_FAST_FORWARD_BLOCKED ();


        /// <summary>
        ///   System.Boolean get_isDashAttackUnlocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDashAttackUnlocked")]
        ///  extern System.Boolean GET_IS_DASH_ATTACK_UNLOCKED ();


        /// <summary>
        ///   System.Boolean get_isDeathEventProcessed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDeathEventProcessed")]
        ///  extern System.Boolean GET_IS_DEATH_EVENT_PROCESSED ();


        /// <summary>
        ///   System.Boolean get_isDestroyed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDestroyed")]
        ///  extern System.Boolean GET_IS_DESTROYED ();


        /// <summary>
        ///   System.Boolean get_isDestructible()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDestructible")]
        ///  extern System.Boolean GET_IS_DESTRUCTIBLE ();


        /// <summary>
        ///   System.Boolean get_isDisableHitFlash()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDisableHitFlash")]
        ///  extern System.Boolean GET_IS_DISABLE_HIT_FLASH ();


        /// <summary>
        ///   System.Boolean get_isEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEnabled")]
        ///  extern System.Boolean GET_IS_ENABLED ();


        /// <summary>
        ///   System.Boolean get_isEnemy()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEnemy")]
        ///  extern System.Boolean GET_IS_ENEMY ();


        /// <summary>
        ///   System.Boolean get_isEnemyAllegiance()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEnemyAllegiance")]
        ///  extern System.Boolean GET_IS_ENEMY_ALLEGIANCE ();


        /// <summary>
        ///   System.Boolean get_isEnemyOwnedProxy()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEnemyOwnedProxy")]
        ///  extern System.Boolean GET_IS_ENEMY_OWNED_PROXY ();


        /// <summary>
        ///   System.Boolean get_isEquipmentUpgradeShopInteractable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEquipmentUpgradeShopInteractable")]
        ///  extern System.Boolean GET_IS_EQUIPMENT_UPGRADE_SHOP_INTERACTABLE ();


        /// <summary>
        ///   System.Boolean get_isFacePlayerWhenFlee()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isFacePlayerWhenFlee")]
        ///  extern System.Boolean GET_IS_FACE_PLAYER_WHEN_FLEE ();


        /// <summary>
        ///   System.Boolean get_isFinalPoint()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isFinalPoint")]
        ///  extern System.Boolean GET_IS_FINAL_POINT ();


        /// <summary>
        ///   System.Boolean get_isFleeing()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isFleeing")]
        ///  extern System.Boolean GET_IS_FLEEING ();


        /// <summary>
        ///   System.Boolean get_isFloatBlocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isFloatBlocked")]
        ///  extern System.Boolean GET_IS_FLOAT_BLOCKED ();


        /// <summary>
        ///   System.Boolean get_isFlyingTrait()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isFlyingTrait")]
        ///  extern System.Boolean GET_IS_FLYING_TRAIT ();


        /// <summary>
        ///   System.Boolean get_isFollowing()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isFollowing")]
        ///  extern System.Boolean GET_IS_FOLLOWING ();


        /// <summary>
        ///   System.Boolean get_isFreezeFacing()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isFreezeFacing")]
        ///  extern System.Boolean GET_IS_FREEZE_FACING ();


        /// <summary>
        ///   System.Boolean get_isFSMInteractable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isFSMInteractable")]
        ///  extern System.Boolean GET_IS_FSM_INTERACTABLE ();


        /// <summary>
        ///   System.Boolean get_isGlobalInteractBlocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isGlobalInteractBlocked")]
        ///  extern System.Boolean GET_IS_GLOBAL_INTERACT_BLOCKED ();


        /// <summary>
        ///   System.Boolean get_isHitTarget()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isHitTarget")]
        ///  extern System.Boolean GET_IS_HIT_TARGET ();


        /// <summary>
        ///   System.Boolean get_isHomingAroundSource()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isHomingAroundSource")]
        ///  extern System.Boolean GET_IS_HOMING_AROUND_SOURCE ();


        /// <summary>
        ///   System.Boolean get_isInactive()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInactive")]
        ///  extern System.Boolean GET_IS_INACTIVE ();


        /// <summary>
        ///   System.Boolean get_isInActiveTrap()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInActiveTrap")]
        ///  extern System.Boolean GET_IS_IN_ACTIVE_TRAP ();


        /// <summary>
        ///   System.Boolean get_isInCombatMode()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInCombatMode", CallConvs = [typeof(CallConvCdecl)])]
        extern System.Boolean GET_IS_IN_COMBAT_MODE();


        /// <summary>
        ///   System.Boolean get_isInCutscene()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInCutscene")]
        ///  extern System.Boolean GET_IS_IN_CUTSCENE ();


        /// <summary>
        ///   System.Boolean get_isInfinity()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInfinity")]
        ///  extern System.Boolean GET_IS_INFINITY ();


        /// <summary>
        ///   System.Boolean get_isInShip()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInShip")]
        ///  extern System.Boolean GET_IS_IN_SHIP ();


        /// <summary>
        ///   System.Boolean get_isInteractBlocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInteractBlocked")]
        ///  extern System.Boolean GET_IS_INTERACT_BLOCKED ();


        /// <summary>
        ///   System.Boolean get_isInvincible()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInvincible")]
        ///  extern System.Boolean GET_IS_INVINCIBLE ();


        /// <summary>
        ///   System.Boolean get_isinWater()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isinWater")]
        ///  extern System.Boolean GET_ISIN_WATER ();


        /// <summary>
        ///   System.Boolean get_isJustSpawned()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isJustSpawned")]
        ///  extern System.Boolean GET_IS_JUST_SPAWNED ();


        /// <summary>
        ///   System.Boolean get_isKilled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isKilled")]
        ///  extern System.Boolean GET_IS_KILLED ();


        /// <summary>
        ///   System.Boolean get_isLastBoss()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isLastBoss")]
        ///  extern System.Boolean GET_IS_LAST_BOSS ();


        /// <summary>
        ///   System.Boolean get_isLootDropEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isLootDropEvent")]
        ///  extern System.Boolean GET_IS_LOOT_DROP_EVENT ();


        /// <summary>
        ///   System.Boolean get_isMonster()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isMonster", CallConvs = [typeof(CallConvCdecl)])]
        extern System.Boolean GET_IS_MONSTER();


        /// <summary>
        ///   System.Boolean get_isMonsterCaptured()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isMonsterCaptured")]
        ///  extern System.Boolean GET_IS_MONSTER_CAPTURED ();


        /// <summary>
        ///   System.Boolean get_isMoving()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isMoving")]
        ///  extern System.Boolean GET_IS_MOVING ();


        /// <summary>
        ///   System.Boolean get_isNotEnoughGunAmmoEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isNotEnoughGunAmmoEvent")]
        ///  extern System.Boolean GET_IS_NOT_ENOUGH_GUN_AMMO_EVENT ();


        /// <summary>
        ///   System.Boolean get_isNPC()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isNPC")]
        ///  extern System.Boolean GET_IS_NPC ();




        /// public static partial class Search_GameEntity
        /// {
        /// 
        ///     
        /// 
        /// }

    }

    /// <summary>
    /// ["ProjectStar".""."GameEntity"]
    /// </summary>
    public partial class GameEntity
    {



        /// <summary>
        ///   System.Boolean get_isPlayerAllegiance()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerAllegiance")]
        ///  extern System.Boolean GET_IS_PLAYER_ALLEGIANCE ();


        /// <summary>
        ///   System.Boolean get_isPlayerCannotBeAggroed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerCannotBeAggroed")]
        ///  extern System.Boolean GET_IS_PLAYER_CANNOT_BE_AGGROED ();


        /// <summary>
        ///   System.Boolean get_isPlayerCharacter()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerCharacter", CallConvs = [typeof(CallConvCdecl)])]
        extern System.Boolean GET_IS_PLAYER_CHARACTER();


        /// <summary>
        ///   System.Boolean get_isPlayerControlled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerControlled")]
        ///  extern System.Boolean GET_IS_PLAYER_CONTROLLED ();


        /// <summary>
        ///   System.Boolean get_isPlayerFlinching()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerFlinching")]
        ///  extern System.Boolean GET_IS_PLAYER_FLINCHING ();


        /// <summary>
        ///   System.Boolean get_isPlayerOwnedProxy()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerOwnedProxy")]
        ///  extern System.Boolean GET_IS_PLAYER_OWNED_PROXY ();


        /// <summary>
        ///   System.Boolean get_isPlayerShip()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerShip", CallConvs = [typeof(CallConvCdecl)])]
        extern System.Boolean GET_IS_PLAYER_SHIP();


        /// <summary>
        ///   System.Boolean get_isPlayerShipHealthUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerShipHealthUpdatedEvent")]
        ///  extern System.Boolean GET_IS_PLAYER_SHIP_HEALTH_UPDATED_EVENT ();


        /// <summary>
        ///   System.Boolean get_isPlayerSleeping()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerSleeping")]
        ///  extern System.Boolean GET_IS_PLAYER_SLEEPING ();


        /// <summary>
        ///   System.Boolean get_isPreviouslyRolling()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPreviouslyRolling")]
        ///  extern System.Boolean GET_IS_PREVIOUSLY_ROLLING ();


        /// <summary>
        ///   System.Boolean get_isPreviouslyRunning()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPreviouslyRunning")]
        ///  extern System.Boolean GET_IS_PREVIOUSLY_RUNNING ();


        /// <summary>
        ///   System.Boolean get_isProcessingDestinationRelay()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isProcessingDestinationRelay")]
        ///  extern System.Boolean GET_IS_PROCESSING_DESTINATION_RELAY ();


        /// <summary>
        ///   System.Boolean get_isProjectile()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isProjectile")]
        ///  extern System.Boolean GET_IS_PROJECTILE ();


        /// <summary>
        ///   System.Boolean get_isProjectileCollidable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isProjectileCollidable")]
        ///  extern System.Boolean GET_IS_PROJECTILE_COLLIDABLE ();


        /// <summary>
        ///   System.Boolean get_isPromptAddPlayerEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPromptAddPlayerEvent")]
        ///  extern System.Boolean GET_IS_PROMPT_ADD_PLAYER_EVENT ();


        /// <summary>
        ///   System.Boolean get_isProxyDontDestroyOnCutscene()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isProxyDontDestroyOnCutscene")]
        ///  extern System.Boolean GET_IS_PROXY_DONT_DESTROY_ON_CUTSCENE ();


        /// <summary>
        ///   System.Boolean get_isProxyTargetAllies()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isProxyTargetAllies")]
        ///  extern System.Boolean GET_IS_PROXY_TARGET_ALLIES ();


        /// <summary>
        ///   System.Boolean get_isProxyTargetEnemies()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isProxyTargetEnemies")]
        ///  extern System.Boolean GET_IS_PROXY_TARGET_ENEMIES ();


        /// <summary>
        ///   System.Boolean get_isProxyTargetSelf()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isProxyTargetSelf")]
        ///  extern System.Boolean GET_IS_PROXY_TARGET_SELF ();


        /// <summary>
        ///   System.Boolean get_isQuestFsmUpdateEveryFrame()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isQuestFsmUpdateEveryFrame")]
        ///  extern System.Boolean GET_IS_QUEST_FSM_UPDATE_EVERY_FRAME ();


        /// <summary>
        ///   System.Boolean get_isQuestFsmUpdateNextFrame()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isQuestFsmUpdateNextFrame")]
        ///  extern System.Boolean GET_IS_QUEST_FSM_UPDATE_NEXT_FRAME ();


        /// <summary>
        ///   System.Boolean get_isQuestFsmUpdateThisFrame()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isQuestFsmUpdateThisFrame")]
        ///  extern System.Boolean GET_IS_QUEST_FSM_UPDATE_THIS_FRAME ();


        /// <summary>
        ///   System.Boolean get_isRemovePlayerEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isRemovePlayerEvent")]
        ///  extern System.Boolean GET_IS_REMOVE_PLAYER_EVENT ();


        /// <summary>
        ///   System.Boolean get_isRespawnPlayersEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isRespawnPlayersEvent")]
        ///  extern System.Boolean GET_IS_RESPAWN_PLAYERS_EVENT ();


        /// <summary>
        ///   System.Boolean get_isRevivable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isRevivable")]
        ///  extern System.Boolean GET_IS_REVIVABLE ();


        /// <summary>
        ///   System.Boolean get_isRollBlocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isRollBlocked")]
        ///  extern System.Boolean GET_IS_ROLL_BLOCKED ();


        /// <summary>
        ///   System.Boolean get_isRolling()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isRolling")]
        ///  extern System.Boolean GET_IS_ROLLING ();


        /// <summary>
        ///   System.Boolean get_isSaveParrotDestructibleCollider()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSaveParrotDestructibleCollider")]
        ///  extern System.Boolean GET_IS_SAVE_PARROT_DESTRUCTIBLE_COLLIDER ();


        /// <summary>
        ///   System.Boolean get_isSaveStoneInRange()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSaveStoneInRange")]
        ///  extern System.Boolean GET_IS_SAVE_STONE_IN_RANGE ();


        /// <summary>
        ///   System.Boolean get_isSaveStoneUpdateEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSaveStoneUpdateEvent")]
        ///  extern System.Boolean GET_IS_SAVE_STONE_UPDATE_EVENT ();


        /// <summary>
        ///   System.Boolean get_isSelfHealing()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSelfHealing")]
        ///  extern System.Boolean GET_IS_SELF_HEALING ();


        /// <summary>
        ///   System.Boolean get_isShieldBlocking()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShieldBlocking")]
        ///  extern System.Boolean GET_IS_SHIELD_BLOCKING ();


        /// <summary>
        ///   System.Boolean get_isShieldReflective()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShieldReflective")]
        ///  extern System.Boolean GET_IS_SHIELD_REFLECTIVE ();


        /// <summary>
        ///   System.Boolean get_isShip()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShip", CallConvs = [typeof(CallConvCdecl)])]
        extern System.Boolean GET_IS_SHIP();


        /// <summary>
        ///   System.Boolean get_isShipEnterBlocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShipEnterBlocked")]
        ///  extern System.Boolean GET_IS_SHIP_ENTER_BLOCKED ();


        /// <summary>
        ///   System.Boolean get_isShipEnterEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShipEnterEvent")]
        ///  extern System.Boolean GET_IS_SHIP_ENTER_EVENT ();


        /// <summary>
        ///   System.Boolean get_isShipExitEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShipExitEvent")]
        ///  extern System.Boolean GET_IS_SHIP_EXIT_EVENT ();


        /// <summary>
        ///   System.Boolean get_isShipInteriorEnterEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShipInteriorEnterEvent")]
        ///  extern System.Boolean GET_IS_SHIP_INTERIOR_ENTER_EVENT ();


        /// <summary>
        ///   System.Boolean get_isShipSpecialAmmoCapacityUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShipSpecialAmmoCapacityUpdatedEvent")]
        ///  extern System.Boolean GET_IS_SHIP_SPECIAL_AMMO_CAPACITY_UPDATED_EVENT ();


        /// <summary>
        ///   System.Boolean get_isSideScrollingMode()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSideScrollingMode")]
        ///  extern System.Boolean GET_IS_SIDE_SCROLLING_MODE ();


        /// <summary>
        ///   System.Boolean get_isSpecialAudioPlay()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSpecialAudioPlay")]
        ///  extern System.Boolean GET_IS_SPECIAL_AUDIO_PLAY ();


        /// <summary>
        ///   System.Boolean get_isSpellCastBlocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSpellCastBlocked")]
        ///  extern System.Boolean GET_IS_SPELL_CAST_BLOCKED ();


        /// <summary>
        ///   System.Boolean get_isSpirit()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSpirit")]
        ///  extern System.Boolean GET_IS_SPIRIT ();


        /// <summary>
        ///   System.Boolean get_isSprinting()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSprinting")]
        ///  extern System.Boolean GET_IS_SPRINTING ();


        /// <summary>
        ///   System.Boolean get_isStopAddPlayerEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isStopAddPlayerEvent")]
        ///  extern System.Boolean GET_IS_STOP_ADD_PLAYER_EVENT ();


        /// <summary>
        ///   System.Boolean get_isStrafeMovement()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isStrafeMovement")]
        ///  extern System.Boolean GET_IS_STRAFE_MOVEMENT ();


        /// <summary>
        ///   System.Boolean get_isSwapWeaponBlocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSwapWeaponBlocked")]
        ///  extern System.Boolean GET_IS_SWAP_WEAPON_BLOCKED ();


        /// <summary>
        ///   System.Boolean get_isTargetGroup()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isTargetGroup")]
        ///  extern System.Boolean GET_IS_TARGET_GROUP ();


        /// <summary>
        ///   System.Boolean get_isTrap()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isTrap")]
        ///  extern System.Boolean GET_IS_TRAP ();


        /// <summary>
        ///   System.Boolean get_isTriggerableInteractable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isTriggerableInteractable")]
        ///  extern System.Boolean GET_IS_TRIGGERABLE_INTERACTABLE ();


        /// <summary>
        ///   System.Boolean get_isUndamageableUnit()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isUndamageableUnit")]
        ///  extern System.Boolean GET_IS_UNDAMAGEABLE_UNIT ();


        /// <summary>
        ///   System.Boolean get_isWaterTrait()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isWaterTrait")]
        ///  extern System.Boolean GET_IS_WATER_TRAIT ();


        /// <summary>
        ///   System.Boolean get_isWaypoint()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isWaypoint")]
        ///  extern System.Boolean GET_IS_WAYPOINT ();


        /// <summary>
        ///   System.Boolean get_isXAxisOnly()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isXAxisOnly")]
        ///  extern System.Boolean GET_IS_X_AXIS_ONLY ();


        /// <summary>
        ///   KilledListenerComponent get_killedListener()
        /// </summary>
        /// <returns>class KilledListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_killedListener")]
        ///  extern nint GET_KILLED_LISTENER ();


        /// <summary>
        ///   KnockbackMultiplierComponent get_knockbackMultiplier()
        /// </summary>
        /// <returns>class KnockbackMultiplierComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_knockbackMultiplier")]
        ///  extern nint GET_KNOCKBACK_MULTIPLIER ();


        /// <summary>
        ///   LastSeenDurationComponent get_lastSeenDuration()
        /// </summary>
        /// <returns>class LastSeenDurationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastSeenDuration")]
        ///  extern nint GET_LAST_SEEN_DURATION ();


        /// <summary>
        ///   LatestInfinityTowerClearedWaveComponent get_latestInfinityTowerClearedWave()
        /// </summary>
        /// <returns>class LatestInfinityTowerClearedWaveComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_latestInfinityTowerClearedWave")]
        ///  extern nint GET_LATEST_INFINITY_TOWER_CLEARED_WAVE ();


        /// <summary>
        ///   LifetimeComponent get_lifetime()
        /// </summary>
        /// <returns>class LifetimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lifetime")]
        ///  extern nint GET_LIFETIME ();


        /// <summary>
        ///   LifetimeTargetComponent get_lifetimeTarget()
        /// </summary>
        /// <returns>class LifetimeTargetComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lifetimeTarget")]
        ///  extern nint GET_LIFETIME_TARGET ();


        /// <summary>
        ///   LocationDataComponent get_locationData()
        /// </summary>
        /// <returns>class LocationDataComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_locationData")]
        ///  extern nint GET_LOCATION_DATA ();


        /// <summary>
        ///   LootDropLevelComponent get_lootDropLevel()
        /// </summary>
        /// <returns>class LootDropLevelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lootDropLevel")]
        ///  extern nint GET_LOOT_DROP_LEVEL ();


        /// <summary>
        ///   LootMagnetComponent get_lootMagnet()
        /// </summary>
        /// <returns>class LootMagnetComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lootMagnet")]
        ///  extern nint GET_LOOT_MAGNET ();


        /// <summary>
        ///   LootMultiplierComponent get_lootMultiplier()
        /// </summary>
        /// <returns>class LootMultiplierComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lootMultiplier")]
        ///  extern nint GET_LOOT_MULTIPLIER ();


        /// <summary>
        ///   LootTableComponent get_lootTable()
        /// </summary>
        /// <returns>class LootTableComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lootTable")]
        ///  extern nint GET_LOOT_TABLE ();


        /// <summary>
        ///   LootTimerComponent get_lootTimer()
        /// </summary>
        /// <returns>class LootTimerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lootTimer")]
        ///  extern nint GET_LOOT_TIMER ();


        /// <summary>
        ///   MagicStatComponent get_magicStat()
        /// </summary>
        /// <returns>class MagicStatComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_magicStat")]
        ///  extern nint GET_MAGIC_STAT ();


        /// <summary>
        ///   MainSpriteComponent get_mainSprite()
        /// </summary>
        /// <returns>class MainSpriteComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mainSprite")]
        ///  extern nint GET_MAIN_SPRITE ();


        /// <summary>
        ///   ManaComponent get_mana()
        /// </summary>
        /// <returns>class ManaComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mana")]
        ///  extern nint GET_MANA ();


        /// <summary>
        ///   ManaBarComponent get_manaBar()
        /// </summary>
        /// <returns>class ManaBarComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_manaBar")]
        ///  extern nint GET_MANA_BAR ();


        /// <summary>
        ///   MapIconDisplayLinkComponent get_mapIconDisplayLink()
        /// </summary>
        /// <returns>class MapIconDisplayLinkComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapIconDisplayLink")]
        ///  extern nint GET_MAP_ICON_DISPLAY_LINK ();


        /// <summary>
        ///   MapMarkerWorldComponent get_mapMarkerWorld()
        /// </summary>
        /// <returns>class MapMarkerWorldComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapMarkerWorld")]
        ///  extern nint GET_MAP_MARKER_WORLD ();


        /// <summary>
        ///   MapMarkerWorldIndexComponent get_mapMarkerWorldIndex()
        /// </summary>
        /// <returns>class MapMarkerWorldIndexComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapMarkerWorldIndex")]
        ///  extern nint GET_MAP_MARKER_WORLD_INDEX ();


        /// <summary>
        ///   MaxMoveSpeedComponent get_maxMoveSpeed()
        /// </summary>
        /// <returns>class MaxMoveSpeedComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_maxMoveSpeed")]
        ///  extern nint GET_MAX_MOVE_SPEED ();


        /// <summary>
        ///   MeleeAttackCommandComponent get_meleeAttackCommand()
        /// </summary>
        /// <returns>class MeleeAttackCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_meleeAttackCommand")]
        ///  extern nint GET_MELEE_ATTACK_COMMAND ();


        /// <summary>
        ///   MonsterBehaviourComponent get_monsterBehaviour()
        /// </summary>
        /// <returns>class MonsterBehaviourComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_monsterBehaviour")]
        ///  extern nint GET_MONSTER_BEHAVIOUR ();


        /// <summary>
        ///   MonsterDetectorComponent get_monsterDetector()
        /// </summary>
        /// <returns>class MonsterDetectorComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_monsterDetector")]
        ///  extern nint GET_MONSTER_DETECTOR ();


        /// <summary>
        ///   MonsterDetectorInfoComponent get_monsterDetectorInfo()
        /// </summary>
        /// <returns>class MonsterDetectorInfoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_monsterDetectorInfo")]
        ///  extern nint GET_MONSTER_DETECTOR_INFO ();


        /// <summary>
        ///   MonsterDetectorRequestor get_monsterDetectorRequestor()
        /// </summary>
        /// <returns>class MonsterDetectorRequestor</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_monsterDetectorRequestor")]
        ///  extern nint GET_MONSTER_DETECTOR_REQUESTOR ();


        /// <summary>
        ///   MonsterDetectorResultInfoComponent get_monsterDetectorResultInfo()
        /// </summary>
        /// <returns>class MonsterDetectorResultInfoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_monsterDetectorResultInfo")]
        ///  extern nint GET_MONSTER_DETECTOR_RESULT_INFO ();


        /// <summary>
        ///   MonsterTraitComponent get_monsterTrait()
        /// </summary>
        /// <returns>class MonsterTraitComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_monsterTrait")]
        ///  extern nint GET_MONSTER_TRAIT ();


        /// <summary>
        ///   MoveSpeedComponent get_moveSpeed()
        /// </summary>
        /// <returns>class MoveSpeedComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_moveSpeed")]
        ///  extern nint GET_MOVE_SPEED ();


        /// <summary>
        ///   NavAgentTarget get_navAgentTarget()
        /// </summary>
        /// <returns>class NavAgentTarget</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_navAgentTarget")]
        ///  extern nint GET_NAV_AGENT_TARGET ();


        /// <summary>
        ///   NavMeshAgentComponent get_navMeshAgent()
        /// </summary>
        /// <returns>class NavMeshAgentComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_navMeshAgent")]
        ///  extern nint GET_NAV_MESH_AGENT ();


        /// <summary>
        ///   NavPath get_navPath()
        /// </summary>
        /// <returns>class NavPath</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_navPath")]
        ///  extern nint GET_NAV_PATH ();


        /// <summary>
        ///   NotEnoughGunAmmoEventListenerComponent get_notEnoughGunAmmoEventListener()
        /// </summary>
        /// <returns>class NotEnoughGunAmmoEventListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_notEnoughGunAmmoEventListener")]
        ///  extern nint GET_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER ();


        /// <summary>
        ///   ObjectiveInteractorComponent get_objectiveInteractor()
        /// </summary>
        /// <returns>class ObjectiveInteractorComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_objectiveInteractor")]
        ///  extern nint GET_OBJECTIVE_INTERACTOR ();


        /// <summary>
        ///   OnDeathAnimCompleteEventComponent get_onDeathAnimCompleteEvent()
        /// </summary>
        /// <returns>class OnDeathAnimCompleteEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_onDeathAnimCompleteEvent")]
        ///  extern nint GET_ON_DEATH_ANIM_COMPLETE_EVENT ();


        /// <summary>
        ///   OnDeathEventComponent get_onDeathEvent()
        /// </summary>
        /// <returns>class OnDeathEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_onDeathEvent")]
        ///  extern nint GET_ON_DEATH_EVENT ();


        /// <summary>
        ///   OnHitIFrameDataComponent get_onHitIFrameData()
        /// </summary>
        /// <returns>class OnHitIFrameDataComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_onHitIFrameData")]
        ///  extern nint GET_ON_HIT_I_FRAME_DATA ();


        /// <summary>
        ///   OnReviveCallbackComponent get_onReviveCallback()
        /// </summary>
        /// <returns>class OnReviveCallbackComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_onReviveCallback")]
        ///  extern nint GET_ON_REVIVE_CALLBACK ();


        /// <summary>
        ///   OriginalLocalScaleComponent get_originalLocalScale()
        /// </summary>
        /// <returns>class OriginalLocalScaleComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_originalLocalScale")]
        ///  extern nint GET_ORIGINAL_LOCAL_SCALE ();


        /// <summary>
        ///   OverlapListComponent get_overlapList()
        /// </summary>
        /// <returns>class OverlapListComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_overlapList")]
        ///  extern nint GET_OVERLAP_LIST ();


        /// <summary>
        ///   OverrideCharacterGenderComponent get_overrideCharacterGender()
        /// </summary>
        /// <returns>class OverrideCharacterGenderComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_overrideCharacterGender")]
        ///  extern nint GET_OVERRIDE_CHARACTER_GENDER ();


        /// <summary>
        ///   OwnerComponent get_owner()
        /// </summary>
        /// <returns>class OwnerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_owner")]
        ///  extern nint GET_OWNER ();


        /// <summary>
        ///   ParticleEffectComponent get_particleEffect()
        /// </summary>
        /// <returns>class ParticleEffectComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_particleEffect")]
        ///  extern nint GET_PARTICLE_EFFECT ();


        /// <summary>
        ///   PlayerAddedEventComponent get_playerAddedEvent()
        /// </summary>
        /// <returns>class PlayerAddedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerAddedEvent")]
        ///  extern nint GET_PLAYER_ADDED_EVENT ();


        /// <summary>
        ///   PlayerIdComponent get_playerId()
        /// </summary>
        /// <returns>class PlayerIdComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerId")]
        ///  extern nint GET_PLAYER_ID ();


        /// <summary>
        ///   PlayerIdListenerComponent get_playerIdListener()
        /// </summary>
        /// <returns>class PlayerIdListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerIdListener")]
        ///  extern nint GET_PLAYER_ID_LISTENER ();


        /// <summary>
        ///   PlayerIdReferenceComponent get_playerIdReference()
        /// </summary>
        /// <returns>class PlayerIdReferenceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerIdReference")]
        ///  extern nint GET_PLAYER_ID_REFERENCE ();


        /// <summary>
        ///   PlayerIdRemovedListenerComponent get_playerIdRemovedListener()
        /// </summary>
        /// <returns>class PlayerIdRemovedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerIdRemovedListener")]
        ///  extern nint GET_PLAYER_ID_REMOVED_LISTENER ();


        /// <summary>
        ///   PlayerKilledSourceComponent get_playerKilledSource()
        /// </summary>
        /// <returns>class PlayerKilledSourceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerKilledSource")]
        ///  extern nint GET_PLAYER_KILLED_SOURCE ();


        /// <summary>
        ///   PlayerReferenceComponent get_playerReference()
        /// </summary>
        /// <returns>class PlayerReferenceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerReference")]
        ///  extern nint GET_PLAYER_REFERENCE ();


        /// <summary>
        ///   PlayerRemovedEventComponent get_playerRemovedEvent()
        /// </summary>
        /// <returns>class PlayerRemovedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerRemovedEvent")]
        ///  extern nint GET_PLAYER_REMOVED_EVENT ();


        /// <summary>
        ///   PlayerSleepingSaveStoneComponent get_playerSleepingSaveStone()
        /// </summary>
        /// <returns>class PlayerSleepingSaveStoneComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerSleepingSaveStone")]
        ///  extern nint GET_PLAYER_SLEEPING_SAVE_STONE ();


        /// <summary>
        ///   PlayerStatComponent get_playerStat()
        /// </summary>
        /// <returns>struct PlayerStatComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerStat")]
        ///  extern PlayerStatComponent GET_PLAYER_STAT ();


        /// <summary>
        ///   PlayerVicinityComponent get_playerVicinity()
        /// </summary>
        /// <returns>class PlayerVicinityComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerVicinity")]
        ///  extern nint GET_PLAYER_VICINITY ();


        /// <summary>
        ///   PoolStatusTableComponent get_poolStatusTable()
        /// </summary>
        /// <returns>class PoolStatusTableComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_poolStatusTable")]
        ///  extern nint GET_POOL_STATUS_TABLE ();


        /// <summary>
        ///   PositionComponent get_position()
        /// </summary>
        /// <returns>class PositionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_position")]
        ///  extern nint GET_POSITION ();


        /// <summary>
        ///   PositionAttachComponent get_positionAttach()
        /// </summary>
        /// <returns>class PositionAttachComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_positionAttach")]
        ///  extern nint GET_POSITION_ATTACH ();


        /// <summary>
        ///   PositionHistoryComponent get_positionHistory()
        /// </summary>
        /// <returns>class PositionHistoryComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_positionHistory")]
        ///  extern nint GET_POSITION_HISTORY ();


        /// <summary>
        ///   PositionTweenComponent get_positionTween()
        /// </summary>
        /// <returns>class PositionTweenComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_positionTween")]
        ///  extern nint GET_POSITION_TWEEN ();


        /// <summary>
        ///   ProjectileBehaviourComponent get_projectileBehaviour()
        /// </summary>
        /// <returns>class ProjectileBehaviourComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_projectileBehaviour")]
        ///  extern nint GET_PROJECTILE_BEHAVIOUR ();


        /// <summary>
        ///   ProjectileColliderInfoComponent get_projectileColliderInfo()
        /// </summary>
        /// <returns>class ProjectileColliderInfoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_projectileColliderInfo")]
        ///  extern nint GET_PROJECTILE_COLLIDER_INFO ();


        /// <summary>
        ///   ProjectileInfoComponent get_projectileInfo()
        /// </summary>
        /// <returns>class ProjectileInfoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_projectileInfo")]
        ///  extern nint GET_PROJECTILE_INFO ();


        /// <summary>
        ///   ProjectileMovementComponent get_projectileMovement()
        /// </summary>
        /// <returns>class ProjectileMovementComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_projectileMovement")]
        ///  extern nint GET_PROJECTILE_MOVEMENT ();


        /// <summary>
        ///   ProjectileReferenceComponent get_projectileReference()
        /// </summary>
        /// <returns>class ProjectileReferenceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_projectileReference")]
        ///  extern nint GET_PROJECTILE_REFERENCE ();


        /// <summary>
        ///   ProjectileVfxReferenceComponent get_projectileVfxReference()
        /// </summary>
        /// <returns>class ProjectileVfxReferenceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_projectileVfxReference")]
        ///  extern nint GET_PROJECTILE_VFX_REFERENCE ();


        /// <summary>
        ///   PromptRemovePlayerEventComponent get_promptRemovePlayerEvent()
        /// </summary>
        /// <returns>class PromptRemovePlayerEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_promptRemovePlayerEvent")]
        ///  extern nint GET_PROMPT_REMOVE_PLAYER_EVENT ();


        /// <summary>
        ///   PuzzleAnswerComponent get_puzzleAnswer()
        /// </summary>
        /// <returns>class PuzzleAnswerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_puzzleAnswer")]
        ///  extern nint GET_PUZZLE_ANSWER ();


        /// <summary>
        ///   PuzzleAnswerCompletedEventComponent get_puzzleAnswerCompletedEvent()
        /// </summary>
        /// <returns>class PuzzleAnswerCompletedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_puzzleAnswerCompletedEvent")]
        ///  extern nint GET_PUZZLE_ANSWER_COMPLETED_EVENT ();


        /// <summary>
        ///   PuzzleAnswerStateComponent get_puzzleAnswerState()
        /// </summary>
        /// <returns>class PuzzleAnswerStateComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_puzzleAnswerState")]
        ///  extern nint GET_PUZZLE_ANSWER_STATE ();


        /// <summary>
        ///   PuzzleLootLocationComponent get_puzzleLootLocation()
        /// </summary>
        /// <returns>class PuzzleLootLocationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_puzzleLootLocation")]
        ///  extern nint GET_PUZZLE_LOOT_LOCATION ();


        /// <summary>
        ///   PuzzlePieceIDComponent get_puzzlePieceID()
        /// </summary>
        /// <returns>class PuzzlePieceIDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_puzzlePieceID")]
        ///  extern nint GET_PUZZLE_PIECE_ID ();


        /// <summary>
        ///   PuzzlePieceInteractedCountComponent get_puzzlePieceInteractedCount()
        /// </summary>
        /// <returns>class PuzzlePieceInteractedCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_puzzlePieceInteractedCount")]
        ///  extern nint GET_PUZZLE_PIECE_INTERACTED_COUNT ();


        /// <summary>
        ///   PuzzlePieceInteractedEventComponent get_puzzlePieceInteractedEvent()
        /// </summary>
        /// <returns>class PuzzlePieceInteractedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_puzzlePieceInteractedEvent")]
        ///  extern nint GET_PUZZLE_PIECE_INTERACTED_EVENT ();


        /// <summary>
        ///   QuestFsmComponent get_questFsm()
        /// </summary>
        /// <returns>class QuestFsmComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_questFsm")]
        ///  extern nint GET_QUEST_FSM ();


        /// <summary>
        ///   RecoveryComponent get_recovery()
        /// </summary>
        /// <returns>class RecoveryComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_recovery")]
        ///  extern nint GET_RECOVERY ();


        /// <summary>
        ///   RendererTinterComponent get_rendererTinter()
        /// </summary>
        /// <returns>class RendererTinterComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rendererTinter")]
        ///  extern nint GET_RENDERER_TINTER ();


        /// <summary>
        ///   RenderTransformComponent get_renderTransform()
        /// </summary>
        /// <returns>class RenderTransformComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_renderTransform")]
        ///  extern nint GET_RENDER_TRANSFORM ();


        /// <summary>
        ///   RestTriggeredEventComponent get_restTriggeredEvent()
        /// </summary>
        /// <returns>class RestTriggeredEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_restTriggeredEvent")]
        ///  extern nint GET_REST_TRIGGERED_EVENT ();


        /// <summary>
        ///   System.Int32 get_retainCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_retainCount")]
        ///  extern System.Int32 GET_RETAIN_COUNT ();


        /// <summary>
        ///   ReviveBeaconComponent get_reviveBeacon()
        /// </summary>
        /// <returns>class ReviveBeaconComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reviveBeacon")]
        ///  extern nint GET_REVIVE_BEACON ();


        /// <summary>
        ///   ReviveBeaconReferenceComponent get_reviveBeaconReference()
        /// </summary>
        /// <returns>class ReviveBeaconReferenceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reviveBeaconReference")]
        ///  extern nint GET_REVIVE_BEACON_REFERENCE ();


        /// <summary>
        ///   ReviveEventComponent get_reviveEvent()
        /// </summary>
        /// <returns>class ReviveEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reviveEvent")]
        ///  extern nint GET_REVIVE_EVENT ();


        /// <summary>
        ///   RigidbodyComponent get_rigidbody()
        /// </summary>
        /// <returns>class RigidbodyComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rigidbody")]
        ///  extern nint GET_RIGIDBODY ();


        /// <summary>
        ///   RollCommandComponent get_rollCommand()
        /// </summary>
        /// <returns>class RollCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rollCommand")]
        ///  extern nint GET_ROLL_COMMAND ();


        /// <summary>
        ///   RollCooldownComponent get_rollCooldown()
        /// </summary>
        /// <returns>class RollCooldownComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rollCooldown")]
        ///  extern nint GET_ROLL_COOLDOWN ();


        /// <summary>
        ///   RollCountComponent get_rollCount()
        /// </summary>
        /// <returns>class RollCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rollCount")]
        ///  extern nint GET_ROLL_COUNT ();


        /// <summary>
        ///   RotationTweenComponent get_rotationTween()
        /// </summary>
        /// <returns>class RotationTweenComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rotationTween")]
        ///  extern nint GET_ROTATION_TWEEN ();


        /// <summary>
        ///   SaveStoneComponent get_saveStone()
        /// </summary>
        /// <returns>class SaveStoneComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_saveStone")]
        ///  extern nint GET_SAVE_STONE ();


        /// <summary>
        ///   ScreenEffectComponent get_screenEffect()
        /// </summary>
        /// <returns>class ScreenEffectComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_screenEffect")]
        ///  extern nint GET_SCREEN_EFFECT ();


        /// <summary>
        ///   ScreenEffectPlayerComponent get_screenEffectPlayer()
        /// </summary>
        /// <returns>class ScreenEffectPlayerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_screenEffectPlayer")]
        ///  extern nint GET_SCREEN_EFFECT_PLAYER ();


        /// <summary>
        ///   SecondPlayerComponent get_secondPlayer()
        /// </summary>
        /// <returns>class SecondPlayerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_secondPlayer")]
        ///  extern nint GET_SECOND_PLAYER ();


        /// <summary>
        ///   SelectedTavernTalesDataComponent get_selectedTavernTalesData()
        /// </summary>
        /// <returns>class SelectedTavernTalesDataComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_selectedTavernTalesData")]
        ///  extern nint GET_SELECTED_TAVERN_TALES_DATA ();


        /// <summary>
        ///   ShadowComponent get_shadow()
        /// </summary>
        /// <returns>class ShadowComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shadow")]
        ///  extern nint GET_SHADOW ();


        /// <summary>
        ///   ShipBlueprintEffectsComponent get_shipBlueprintEffects()
        /// </summary>
        /// <returns>class ShipBlueprintEffectsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipBlueprintEffects")]
        ///  extern nint GET_SHIP_BLUEPRINT_EFFECTS ();


        /// <summary>
        ///   ShipBlueprintItemDataComponent get_shipBlueprintItemData()
        /// </summary>
        /// <returns>class ShipBlueprintItemDataComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipBlueprintItemData")]
        ///  extern nint GET_SHIP_BLUEPRINT_ITEM_DATA ();


        /// <summary>
        ///   ShipBlueprintsRefreshedEventComponent get_shipBlueprintsRefreshedEvent()
        /// </summary>
        /// <returns>class ShipBlueprintsRefreshedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipBlueprintsRefreshedEvent")]
        ///  extern nint GET_SHIP_BLUEPRINTS_REFRESHED_EVENT ();


        /// <summary>
        ///   ShipBoostComponent get_shipBoost()
        /// </summary>
        /// <returns>class ShipBoostComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipBoost")]
        ///  extern nint GET_SHIP_BOOST ();


        /// <summary>
        ///   ShipCannonComponent get_shipCannon()
        /// </summary>
        /// <returns>class ShipCannonComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipCannon")]
        ///  extern nint GET_SHIP_CANNON ();


        /// <summary>
        ///   ShipCannonAttackConfigComponent get_shipCannonAttackConfig()
        /// </summary>
        /// <returns>class ShipCannonAttackConfigComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipCannonAttackConfig")]
        ///  extern nint GET_SHIP_CANNON_ATTACK_CONFIG ();


        /// <summary>
        ///   ShipCannonRotationDeltaComponent get_shipCannonRotationDelta()
        /// </summary>
        /// <returns>class ShipCannonRotationDeltaComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipCannonRotationDelta")]
        ///  extern nint GET_SHIP_CANNON_ROTATION_DELTA ();


        /// <summary>
        ///   ShipConfigComponent get_shipConfig()
        /// </summary>
        /// <returns>class ShipConfigComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipConfig")]
        ///  extern nint GET_SHIP_CONFIG ();


        /// <summary>
        ///   ShipDockComponent get_shipDock()
        /// </summary>
        /// <returns>class ShipDockComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipDock")]
        ///  extern nint GET_SHIP_DOCK ();


        /// <summary>
        ///   ShipEnterCamFocusRuntimeScreenEffectComponent get_shipEnterCamFocusRuntimeScreenEffect()
        /// </summary>
        /// <returns>class ShipEnterCamFocusRuntimeScreenEffectComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipEnterCamFocusRuntimeScreenEffect")]
        ///  extern nint GET_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT ();


        /// <summary>
        ///   ShipExitSensorRange get_shipExitSensorRange()
        /// </summary>
        /// <returns>class ShipExitSensorRange</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipExitSensorRange")]
        ///  extern nint GET_SHIP_EXIT_SENSOR_RANGE ();


        /// <summary>
        ///   ShipFeedbackStateComponent get_shipFeedbackState()
        /// </summary>
        /// <returns>class ShipFeedbackStateComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipFeedbackState")]
        ///  extern nint GET_SHIP_FEEDBACK_STATE ();


        /// <summary>
        ///   ShipMovementPoint get_shipMovementPoint()
        /// </summary>
        /// <returns>class ShipMovementPoint</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipMovementPoint")]
        ///  extern nint GET_SHIP_MOVEMENT_POINT ();


        /// <summary>
        ///   ShipPassengerUpdatedEventComponent get_shipPassengerUpdatedEvent()
        /// </summary>
        /// <returns>class ShipPassengerUpdatedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipPassengerUpdatedEvent")]
        ///  extern nint GET_SHIP_PASSENGER_UPDATED_EVENT ();


        /// <summary>
        ///   ShipPathAgent get_shipPathAgent()
        /// </summary>
        /// <returns>class ShipPathAgent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipPathAgent")]
        ///  extern nint GET_SHIP_PATH_AGENT ();


        /// <summary>
        ///   ShipReferenceComponent get_shipReference()
        /// </summary>
        /// <returns>class ShipReferenceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipReference")]
        ///  extern nint GET_SHIP_REFERENCE ();


        /// <summary>
        ///   ShipSailInfoComponent get_shipSailInfo()
        /// </summary>
        /// <returns>class ShipSailInfoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipSailInfo")]
        ///  extern nint GET_SHIP_SAIL_INFO ();


        /// <summary>
        ///   ShipSpecialAttackConfigComponent get_shipSpecialAttackConfig()
        /// </summary>
        /// <returns>class ShipSpecialAttackConfigComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipSpecialAttackConfig")]
        ///  extern nint GET_SHIP_SPECIAL_ATTACK_CONFIG ();


        /// <summary>
        ///   SoundStatesReferenceComponent get_soundStatesReference()
        /// </summary>
        /// <returns>class SoundStatesReferenceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_soundStatesReference")]
        ///  extern nint GET_SOUND_STATES_REFERENCE ();


        /// <summary>
        ///   SourceComponent get_source()
        /// </summary>
        /// <returns>class SourceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_source")]
        ///  extern nint GET_SOURCE ();


        /// <summary>
        ///   SourceTransformComponent get_sourceTransform()
        /// </summary>
        /// <returns>class SourceTransformComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sourceTransform")]
        ///  extern nint GET_SOURCE_TRANSFORM ();


        /// <summary>
        ///   SpawnerOverrideDurationComponent get_spawnerOverrideDuration()
        /// </summary>
        /// <returns>class SpawnerOverrideDurationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spawnerOverrideDuration")]
        ///  extern nint GET_SPAWNER_OVERRIDE_DURATION ();


        /// <summary>
        ///   SpawnTableItemComponent get_spawnTableItem()
        /// </summary>
        /// <returns>class SpawnTableItemComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spawnTableItem")]
        ///  extern nint GET_SPAWN_TABLE_ITEM ();


        /// <summary>
        ///   SpawnTextEventComponent get_spawnTextEvent()
        /// </summary>
        /// <returns>class SpawnTextEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spawnTextEvent")]
        ///  extern nint GET_SPAWN_TEXT_EVENT ();


        /// <summary>
        ///   SpeedTweenComponent get_speedTween()
        /// </summary>
        /// <returns>class SpeedTweenComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_speedTween")]
        ///  extern nint GET_SPEED_TWEEN ();


        /// <summary>
        ///   SpellCommandComponent get_spellCommand()
        /// </summary>
        /// <returns>class SpellCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spellCommand")]
        ///  extern nint GET_SPELL_COMMAND ();


        /// <summary>
        ///   SpellConfigComponent get_spellConfig()
        /// </summary>
        /// <returns>class SpellConfigComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spellConfig")]
        ///  extern nint GET_SPELL_CONFIG ();


        /// <summary>
        ///   SpellLevelConfigComponent get_spellLevelConfig()
        /// </summary>
        /// <returns>class SpellLevelConfigComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spellLevelConfig")]
        ///  extern nint GET_SPELL_LEVEL_CONFIG ();


        /// <summary>
        ///   SpellReferenceComponent get_spellReference()
        /// </summary>
        /// <returns>class SpellReferenceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spellReference")]
        ///  extern nint GET_SPELL_REFERENCE ();


        /// <summary>
        ///   SpellTrackerComponent get_spellTracker()
        /// </summary>
        /// <returns>class SpellTrackerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spellTracker")]
        ///  extern nint GET_SPELL_TRACKER ();


        /// <summary>
        ///   StarGuideComponent get_starGuide()
        /// </summary>
        /// <returns>class StarGuideComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_starGuide")]
        ///  extern nint GET_STAR_GUIDE ();


        /// <summary>
        ///   StarGuideManagerComponent get_starGuideManager()
        /// </summary>
        /// <returns>class StarGuideManagerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_starGuideManager")]
        ///  extern nint GET_STAR_GUIDE_MANAGER ();


        /// <summary>
        ///   StrafeLane get_strafeLane()
        /// </summary>
        /// <returns>class StrafeLane</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_strafeLane")]
        ///  extern nint GET_STRAFE_LANE ();


        /// <summary>
        ///   StrengthStatComponent get_strengthStat()
        /// </summary>
        /// <returns>class StrengthStatComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_strengthStat")]
        ///  extern nint GET_STRENGTH_STAT ();


        /// <summary>
        ///   SwapWeaponCommandComponent get_swapWeaponCommand()
        /// </summary>
        /// <returns>class SwapWeaponCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_swapWeaponCommand")]
        ///  extern nint GET_SWAP_WEAPON_COMMAND ();


        /// <summary>
        ///   TakeDamageEventComponent get_takeDamageEvent()
        /// </summary>
        /// <returns>class TakeDamageEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_takeDamageEvent")]
        ///  extern nint GET_TAKE_DAMAGE_EVENT ();


        /// <summary>
        ///   TargetComponent get_target()
        /// </summary>
        /// <returns>class TargetComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_target")]
        ///  extern nint GET_TARGET ();


        /// <summary>
        ///   TargetListComponent get_targetList()
        /// </summary>
        /// <returns>class TargetListComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_targetList")]
        ///  extern nint GET_TARGET_LIST ();


        /// <summary>
        ///   TargetPositionComponent get_targetPosition()
        /// </summary>
        /// <returns>class TargetPositionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_targetPosition")]
        ///  extern nint GET_TARGET_POSITION ();


        /// <summary>
        ///   TargetTransformComponent get_targetTransform()
        /// </summary>
        /// <returns>class TargetTransformComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_targetTransform")]
        ///  extern nint GET_TARGET_TRANSFORM ();


        /// <summary>
        ///   TeleportCallbackComponent get_teleportCallback()
        /// </summary>
        /// <returns>class TeleportCallbackComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_teleportCallback")]
        ///  extern nint GET_TELEPORT_CALLBACK ();


        /// <summary>
        ///   TerrainExploredCellsTableComponent get_terrainExploredCellsTable()
        /// </summary>
        /// <returns>class TerrainExploredCellsTableComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_terrainExploredCellsTable")]
        ///  extern nint GET_TERRAIN_EXPLORED_CELLS_TABLE ();


        /// <summary>
        ///   TiltComponent get_tilt()
        /// </summary>
        /// <returns>class TiltComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tilt")]
        ///  extern nint GET_TILT ();


        /// <summary>
        ///   TiltSpeedComponent get_tiltSpeed()
        /// </summary>
        /// <returns>class TiltSpeedComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tiltSpeed")]
        ///  extern nint GET_TILT_SPEED ();


        /// <summary>
        ///   TimedBuffComponent get_timedBuff()
        /// </summary>
        /// <returns>class TimedBuffComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_timedBuff")]
        ///  extern nint GET_TIMED_BUFF ();


        /// <summary>
        ///   TimerComponent get_timer()
        /// </summary>
        /// <returns>class TimerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_timer")]
        ///  extern nint GET_TIMER ();


        /// <summary>
        ///   TimerCallbackComponent get_timerCallback()
        /// </summary>
        /// <returns>class TimerCallbackComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_timerCallback")]
        ///  extern nint GET_TIMER_CALLBACK ();


        /// <summary>
        ///   TintComponent get_tint()
        /// </summary>
        /// <returns>class TintComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tint")]
        ///  extern nint GET_TINT ();


        /// <summary>
        ///   System.Int32 get_totalComponents()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_totalComponents")]
        ///  extern System.Int32 GET_TOTAL_COMPONENTS ();


        /// <summary>
        ///   TrailRendererComponent get_trailRenderer()
        /// </summary>
        /// <returns>class TrailRendererComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_trailRenderer")]
        ///  extern nint GET_TRAIL_RENDERER ();


        /// <summary>
        ///   TransformComponent get_transform()
        /// </summary>
        /// <returns>class TransformComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_transform")]
        ///  extern nint GET_TRANSFORM ();


        /// <summary>
        ///   TransitioningComponent get_transitioning()
        /// </summary>
        /// <returns>class TransitioningComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_transitioning")]
        ///  extern nint GET_TRANSITIONING ();


        /// <summary>
        ///   TriggerableInteractableTypeComponent get_triggerableInteractableType()
        /// </summary>
        /// <returns>class TriggerableInteractableTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_triggerableInteractableType")]
        ///  extern nint GET_TRIGGERABLE_INTERACTABLE_TYPE ();


        /// <summary>
        ///   TriggerHashSetComponent get_triggerHashSet()
        /// </summary>
        /// <returns>class TriggerHashSetComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_triggerHashSet")]
        ///  extern nint GET_TRIGGER_HASH_SET ();


        /// <summary>
        ///   TurnSpeedComponent get_turnSpeed()
        /// </summary>
        /// <returns>class TurnSpeedComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_turnSpeed")]
        ///  extern nint GET_TURN_SPEED ();


        /// <summary>
        ///   UnequipItemCommand get_unequipItemCommand()
        /// </summary>
        /// <returns>class UnequipItemCommand</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unequipItemCommand")]
        ///  extern nint GET_UNEQUIP_ITEM_COMMAND ();


        /// <summary>
        ///   UnitConfigComponent get_unitConfig()
        /// </summary>
        /// <returns>class UnitConfigComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unitConfig")]
        ///  extern nint GET_UNIT_CONFIG ();


        /// <summary>
        ///   UnitLevelComponent get_unitLevel()
        /// </summary>
        /// <returns>class UnitLevelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unitLevel")]
        ///  extern nint GET_UNIT_LEVEL ();


        /// <summary>
        ///   UnlockedEquipmentListComponent get_unlockedEquipmentList()
        /// </summary>
        /// <returns>class UnlockedEquipmentListComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedEquipmentList")]
        ///  extern nint GET_UNLOCKED_EQUIPMENT_LIST ();


        /// <summary>
        ///   UnlockedShipBlueprintsComponent get_unlockedShipBlueprints()
        /// </summary>
        /// <returns>class UnlockedShipBlueprintsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedShipBlueprints")]
        ///  extern nint GET_UNLOCKED_SHIP_BLUEPRINTS ();


        /// <summary>
        ///   UnlockedShipSpellTableComponent get_unlockedShipSpellTable()
        /// </summary>
        /// <returns>class UnlockedShipSpellTableComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedShipSpellTable")]
        ///  extern nint GET_UNLOCKED_SHIP_SPELL_TABLE ();


        /// <summary>
        ///   UnlockedSpellTableComponent get_unlockedSpellTable()
        /// </summary>
        /// <returns>class UnlockedSpellTableComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedSpellTable")]
        ///  extern nint GET_UNLOCKED_SPELL_TABLE ();


        /// <summary>
        ///   UpdatedGunAmmoComponent get_updatedGunAmmo()
        /// </summary>
        /// <returns>class UpdatedGunAmmoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_updatedGunAmmo")]
        ///  extern nint GET_UPDATED_GUN_AMMO ();


        /// <summary>
        ///   UpdatedGunAmmoListenerComponent get_updatedGunAmmoListener()
        /// </summary>
        /// <returns>class UpdatedGunAmmoListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_updatedGunAmmoListener")]
        ///  extern nint GET_UPDATED_GUN_AMMO_LISTENER ();


        /// <summary>
        ///   VelocityBufferComponent get_velocityBuffer()
        /// </summary>
        /// <returns>class VelocityBufferComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_velocityBuffer")]
        ///  extern nint GET_VELOCITY_BUFFER ();


        /// <summary>
        ///   VFXFollowParent get_vFXFollowParent()
        /// </summary>
        /// <returns>class VFXFollowParent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_vFXFollowParent")]
        ///  extern nint GET_V_FX_FOLLOW_PARENT ();


        /// <summary>
        ///   VFXSpawnpointComponent get_vFXSpawnpoint()
        /// </summary>
        /// <returns>class VFXSpawnpointComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_vFXSpawnpoint")]
        ///  extern nint GET_V_FX_SPAWNPOINT ();


        /// <summary>
        ///   WallCollidersComponent get_wallColliders()
        /// </summary>
        /// <returns>class WallCollidersComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_wallColliders")]
        ///  extern nint GET_WALL_COLLIDERS ();


        /// <summary>
        ///   WaterRipplesParticlesComponent get_waterRipplesParticles()
        /// </summary>
        /// <returns>class WaterRipplesParticlesComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_waterRipplesParticles")]
        ///  extern nint GET_WATER_RIPPLES_PARTICLES ();


        /// <summary>
        ///   WorldUIButtonAnchorPosOffsetComponent get_worldUIButtonAnchorPosOffset()
        /// </summary>
        /// <returns>class WorldUIButtonAnchorPosOffsetComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldUIButtonAnchorPosOffset")]
        ///  extern nint GET_WORLD_UI_BUTTON_ANCHOR_POS_OFFSET ();


        /// <summary>
        ///   WorldUIButtonAttachFlipSpriteComponent get_worldUIButtonAttachFlipSprite()
        /// </summary>
        /// <returns>class WorldUIButtonAttachFlipSpriteComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldUIButtonAttachFlipSprite")]
        ///  extern nint GET_WORLD_UI_BUTTON_ATTACH_FLIP_SPRITE ();


        /// <summary>
        ///   WorldUIButtonAttachParentComponent get_worldUIButtonAttachParent()
        /// </summary>
        /// <returns>class WorldUIButtonAttachParentComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldUIButtonAttachParent")]
        ///  extern nint GET_WORLD_UI_BUTTON_ATTACH_PARENT ();


        /// <summary>
        ///   Entitas.IComponent GetComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>interface Entitas.IComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent")]
        ///  extern nint GET_COMPONENT (System.Int32 index);


        /// <summary>
        ///   System.Int32[] GetComponentIndices()
        /// </summary>
        /// <returns>class System.Int32[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentIndices")]
        ///  extern nint GET_COMPONENT_INDICES ();


        /// <summary>
        ///   System.Collections.Generic.Stack<Entitas.IComponent> GetComponentPool(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.Stack<Entitas.IComponent></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentPool")]
        ///  extern nint GET_COMPONENT_POOL (System.Int32 index);


        /// <summary>
        ///   Entitas.IComponent[] GetComponents()
        /// </summary>
        /// <returns>class Entitas.IComponent[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents")]
        ///  extern nint GET_COMPONENTS ();


        /// <summary>
        ///   System.Boolean HasAnyComponent(System.Int32[] indices)
        /// </summary>
        /// <param name="indices">class System.Int32[]</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasAnyComponent")]
        ///  extern System.Boolean HAS_ANY_COMPONENT (nint indices);


        /// <summary>
        ///   System.Boolean HasComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasComponent")]
        ///  extern System.Boolean HAS_COMPONENT (System.Int32 index);


        /// <summary>
        ///   System.Boolean HasComponents(System.Int32[] indices)
        /// </summary>
        /// <param name="indices">class System.Int32[]</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasComponents")]
        ///  extern System.Boolean HAS_COMPONENTS (nint indices);


        /// <summary>
        ///   System.Void Initialize(System.Int32 creationIndex, System.Int32 totalComponents, System.Collections.Generic.Stack<Entitas.IComponent>[] componentPools, Entitas.ContextInfo contextInfo, Entitas.IAERC aerc)
        /// </summary>
        /// <param name="creationIndex">struct System.Int32</param>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="componentPools">class System.Collections.Generic.Stack<Entitas.IComponent>[]</param>
        /// <param name="contextInfo">class Entitas.ContextInfo</param>
        /// <param name="aerc">interface Entitas.IAERC</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Initialize")]
        ///  extern void INITIALIZE (System.Int32 creationIndex, System.Int32 totalComponents, nint componentPools, nint contextInfo, nint aerc);


        /// <summary>
        ///   System.Void InternalDestroy()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDestroy")]
        ///  extern void INTERNAL_DESTROY ();


        /// <summary>
        ///   System.Void Reactivate(System.Int32 creationIndex)
        /// </summary>
        /// <param name="creationIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Reactivate")]
        ///  extern void REACTIVATE (System.Int32 creationIndex);


        /// <summary>
        ///   System.Void Release(System.Object owner)
        /// </summary>
        /// <param name="owner">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Release")]
        ///  extern void RELEASE (nint owner);


        /// <summary>
        ///   System.Void remove_OnComponentAdded(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentAdded")]
        ///  extern void REMOVE_ON_COMPONENT_ADDED (nint value);


        /// <summary>
        ///   System.Void remove_OnComponentRemoved(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentRemoved")]
        ///  extern void REMOVE_ON_COMPONENT_REMOVED (nint value);


        /// <summary>
        ///   System.Void remove_OnComponentReplaced(Entitas.EntityComponentReplaced value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentReplaced</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentReplaced")]
        ///  extern void REMOVE_ON_COMPONENT_REPLACED (nint value);


        /// <summary>
        ///   System.Void remove_OnDestroyEntity(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnDestroyEntity")]
        ///  extern void REMOVE_ON_DESTROY_ENTITY (nint value);


        /// <summary>
        ///   System.Void remove_OnEntityReleased(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityReleased")]
        ///  extern void REMOVE_ON_ENTITY_RELEASED (nint value);


        /// <summary>
        ///   System.Void RemoveActiveScreenEffectPlayer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveActiveScreenEffectPlayer")]
        ///  extern void REMOVE_ACTIVE_SCREEN_EFFECT_PLAYER ();


        /// <summary>
        ///   System.Void RemoveActiveWeaponChangedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveActiveWeaponChangedEvent")]
        ///  extern void REMOVE_ACTIVE_WEAPON_CHANGED_EVENT ();


        /// <summary>
        ///   System.Void RemoveAdvancedStatModifiers()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAdvancedStatModifiers")]
        ///  extern void REMOVE_ADVANCED_STAT_MODIFIERS ();


        /// <summary>
        ///   System.Void RemoveAgentDestination()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAgentDestination")]
        ///  extern void REMOVE_AGENT_DESTINATION ();


        /// <summary>
        ///   System.Void RemoveAgentPreviousDestination()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAgentPreviousDestination")]
        ///  extern void REMOVE_AGENT_PREVIOUS_DESTINATION ();


        /// <summary>
        ///   System.Void RemoveAllComponents()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllComponents")]
        ///  extern void REMOVE_ALL_COMPONENTS ();


        /// <summary>
        ///   System.Void RemoveAllOnEntityReleasedHandlers()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllOnEntityReleasedHandlers")]
        ///  extern void REMOVE_ALL_ON_ENTITY_RELEASED_HANDLERS ();


        /// <summary>
        ///   System.Void RemoveAnchorPosOffset()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnchorPosOffset")]
        ///  extern void REMOVE_ANCHOR_POS_OFFSET ();


        /// <summary>
        ///   System.Void RemoveAngleOffset()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAngleOffset")]
        ///  extern void REMOVE_ANGLE_OFFSET ();


        /// <summary>
        ///   System.Void RemoveAnimation()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnimation")]
        ///  extern void REMOVE_ANIMATION ();


        /// <summary>
        ///   System.Void RemoveAnimationFlags()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnimationFlags")]
        ///  extern void REMOVE_ANIMATION_FLAGS ();


        /// <summary>
        ///   System.Void RemoveAnimationProgress()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnimationProgress")]
        ///  extern void REMOVE_ANIMATION_PROGRESS ();


        /// <summary>
        ///   System.Void RemoveAnimator()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnimator")]
        ///  extern void REMOVE_ANIMATOR ();


        /// <summary>
        ///   System.Void RemoveAoeColliderType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAoeColliderType")]
        ///  extern void REMOVE_AOE_COLLIDER_TYPE ();


        /// <summary>
        ///   System.Void RemoveAoeInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAoeInfo")]
        ///  extern void REMOVE_AOE_INFO ();


        /// <summary>
        ///   System.Void RemoveArtPrefabReference()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveArtPrefabReference")]
        ///  extern void REMOVE_ART_PREFAB_REFERENCE ();



        /// <summary>
        ///   System.Void RemoveAnyActiveWeaponChangedEventListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyActiveWeaponChangedEventListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveAnyActiveWeaponChangedEventListener(IAnyActiveWeaponChangedEventListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IAnyActiveWeaponChangedEventListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyActiveWeaponChangedEventListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveAnyShipEnterBlockedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyShipEnterBlockedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_SHIP_ENTER_BLOCKED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveAnyShipEnterBlockedListener(IAnyShipEnterBlockedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IAnyShipEnterBlockedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyShipEnterBlockedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_SHIP_ENTER_BLOCKED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveAnyShipEnterBlockedRemovedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyShipEnterBlockedRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveAnyShipEnterBlockedRemovedListener(IAnyShipEnterBlockedRemovedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IAnyShipEnterBlockedRemovedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyShipEnterBlockedRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// public static partial class Search_GameEntity
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void RemoveAnyActiveWeaponChangedEventListener()
        /// </summary>
        /// public static bool REMOVE_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyActiveWeaponChangedEventListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyActiveWeaponChangedEventListener(IAnyActiveWeaponChangedEventListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyActiveWeaponChangedEventListener", "IAnyActiveWeaponChangedEventListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyShipEnterBlockedListener()
        /// </summary>
        /// public static bool REMOVE_ANY_SHIP_ENTER_BLOCKED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyShipEnterBlockedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyShipEnterBlockedListener(IAnyShipEnterBlockedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_ANY_SHIP_ENTER_BLOCKED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyShipEnterBlockedListener", "IAnyShipEnterBlockedListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyShipEnterBlockedRemovedListener()
        /// </summary>
        /// public static bool REMOVE_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyShipEnterBlockedRemovedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyShipEnterBlockedRemovedListener(IAnyShipEnterBlockedRemovedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyShipEnterBlockedRemovedListener", "IAnyShipEnterBlockedRemovedListener", "System.Boolean");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["ProjectStar".""."GameEntity"]
    /// </summary>
    public partial class GameEntity
    {



        /// <summary>
        ///   System.Void RemoveAttachableFloat()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAttachableFloat")]
        ///  extern void REMOVE_ATTACHABLE_FLOAT ();


        /// <summary>
        ///   System.Void RemoveAttachedVfxTracker()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAttachedVfxTracker")]
        ///  extern void REMOVE_ATTACHED_VFX_TRACKER ();


        /// <summary>
        ///   System.Void RemoveAttackAnimation()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAttackAnimation")]
        ///  extern void REMOVE_ATTACK_ANIMATION ();


        /// <summary>
        ///   System.Void RemoveAttackCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAttackCommand")]
        ///  extern void REMOVE_ATTACK_COMMAND ();


        /// <summary>
        ///   System.Void RemoveAttackEventInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAttackEventInfo")]
        ///  extern void REMOVE_ATTACK_EVENT_INFO ();


        /// <summary>
        ///   System.Void RemoveAttackReference()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAttackReference")]
        ///  extern void REMOVE_ATTACK_REFERENCE ();


        /// <summary>
        ///   System.Void RemoveAttackTellView()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAttackTellView")]
        ///  extern void REMOVE_ATTACK_TELL_VIEW ();


        /// <summary>
        ///   System.Void RemoveAttackTint()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAttackTint")]
        ///  extern void REMOVE_ATTACK_TINT ();


        /// <summary>
        ///   System.Void RemoveAwardedQuestItems()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAwardedQuestItems")]
        ///  extern void REMOVE_AWARDED_QUEST_ITEMS ();


        /// <summary>
        ///   System.Void RemoveBaseEnemyBehaviour()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBaseEnemyBehaviour")]
        ///  extern void REMOVE_BASE_ENEMY_BEHAVIOUR ();


        /// <summary>
        ///   System.Void RemoveBehaviourTree()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBehaviourTree")]
        ///  extern void REMOVE_BEHAVIOUR_TREE ();


        /// <summary>
        ///   System.Void RemoveBlockEffectCooldown()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBlockEffectCooldown")]
        ///  extern void REMOVE_BLOCK_EFFECT_COOLDOWN ();


        /// <summary>
        ///   System.Void RemoveBlockFreezeDuration()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBlockFreezeDuration")]
        ///  extern void REMOVE_BLOCK_FREEZE_DURATION ();


        /// <summary>
        ///   System.Void RemoveBurnCounter()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBurnCounter")]
        ///  extern void REMOVE_BURN_COUNTER ();


        /// <summary>
        ///   System.Void RemoveCannonCooldown()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCannonCooldown")]
        ///  extern void REMOVE_CANNON_COOLDOWN ();


        /// <summary>
        ///   System.Void RemoveCapsule()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCapsule")]
        ///  extern void REMOVE_CAPSULE ();


        /// <summary>
        ///   System.Void RemoveCharacterController()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCharacterController")]
        ///  extern void REMOVE_CHARACTER_CONTROLLER ();


        /// <summary>
        ///   System.Void RemoveCharacterGender()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCharacterGender")]
        ///  extern void REMOVE_CHARACTER_GENDER ();


        /// <summary>
        ///   System.Void RemoveChargeConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveChargeConfig")]
        ///  extern void REMOVE_CHARGE_CONFIG ();


        /// <summary>
        ///   System.Void RemoveChest()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveChest")]
        ///  extern void REMOVE_CHEST ();


        /// <summary>
        ///   System.Void RemoveChestInteractor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveChestInteractor")]
        ///  extern void REMOVE_CHEST_INTERACTOR ();


        /// <summary>
        ///   System.Void RemoveCollatedAoeAttacks()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCollatedAoeAttacks")]
        ///  extern void REMOVE_COLLATED_AOE_ATTACKS ();


        /// <summary>
        ///   System.Void RemoveCollectibleCollectedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCollectibleCollectedEvent")]
        ///  extern void REMOVE_COLLECTIBLE_COLLECTED_EVENT ();


        /// <summary>
        ///   System.Void RemoveCollectibleReference()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCollectibleReference")]
        ///  extern void REMOVE_COLLECTIBLE_REFERENCE ();


        /// <summary>
        ///   System.Void RemoveCollider()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCollider")]
        ///  extern void REMOVE_COLLIDER ();


        /// <summary>
        ///   System.Void RemoveCombatAgent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCombatAgent")]
        ///  extern void REMOVE_COMBAT_AGENT ();


        /// <summary>
        ///   System.Void RemoveCombatAgentHealthUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCombatAgentHealthUpdatedEvent")]
        ///  extern void REMOVE_COMBAT_AGENT_HEALTH_UPDATED_EVENT ();


        /// <summary>
        ///   System.Void RemoveCombatAgentList()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCombatAgentList")]
        ///  extern void REMOVE_COMBAT_AGENT_LIST ();


        /// <summary>
        ///   System.Void RemoveCombatAggroDuration()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCombatAggroDuration")]
        ///  extern void REMOVE_COMBAT_AGGRO_DURATION ();


        /// <summary>
        ///   System.Void RemoveCombatLog()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCombatLog")]
        ///  extern void REMOVE_COMBAT_LOG ();


        /// <summary>
        ///   System.Void RemoveCombatProxyAgent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCombatProxyAgent")]
        ///  extern void REMOVE_COMBAT_PROXY_AGENT ();


        /// <summary>
        ///   System.Void RemoveComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveComponent")]
        ///  extern void REMOVE_COMPONENT (System.Int32 index);


        /// <summary>
        ///   System.Void RemoveCurrentChargerAttackEntities()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCurrentChargerAttackEntities")]
        ///  extern void REMOVE_CURRENT_CHARGER_ATTACK_ENTITIES ();


        /// <summary>
        ///   System.Void RemoveCurrentProjectileHitEntities()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCurrentProjectileHitEntities")]
        ///  extern void REMOVE_CURRENT_PROJECTILE_HIT_ENTITIES ();


        /// <summary>
        ///   System.Void RemoveCurrentSensorRadius()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCurrentSensorRadius")]
        ///  extern void REMOVE_CURRENT_SENSOR_RADIUS ();


        /// <summary>
        ///   System.Void RemoveCutsceneOwner()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCutsceneOwner")]
        ///  extern void REMOVE_CUTSCENE_OWNER ();


        /// <summary>
        ///   System.Void RemoveDashAttackCounter()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDashAttackCounter")]
        ///  extern void REMOVE_DASH_ATTACK_COUNTER ();


        /// <summary>
        ///   System.Void RemoveDestinationRelay()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDestinationRelay")]
        ///  extern void REMOVE_DESTINATION_RELAY ();


        /// <summary>
        ///   System.Void RemoveDestructibleFX()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDestructibleFX")]
        ///  extern void REMOVE_DESTRUCTIBLE_FX ();


        /// <summary>
        ///   System.Void RemoveDialogueSpeaker()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDialogueSpeaker")]
        ///  extern void REMOVE_DIALOGUE_SPEAKER ();


        /// <summary>
        ///   System.Void RemoveDirection()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDirection")]
        ///  extern void REMOVE_DIRECTION ();


        /// <summary>
        ///   System.Void RemoveDockRepair()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDockRepair")]
        ///  extern void REMOVE_DOCK_REPAIR ();


        /// <summary>
        ///   System.Void RemoveDockRepairBeacon()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDockRepairBeacon")]
        ///  extern void REMOVE_DOCK_REPAIR_BEACON ();


        /// <summary>
        ///   System.Void RemoveDockRepairOccupantsUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDockRepairOccupantsUpdatedEvent")]
        ///  extern void REMOVE_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT ();


        /// <summary>
        ///   System.Void RemoveEnemyShipBehaviour()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEnemyShipBehaviour")]
        ///  extern void REMOVE_ENEMY_SHIP_BEHAVIOUR ();


        /// <summary>
        ///   System.Void RemoveEquipItemCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquipItemCommand")]
        ///  extern void REMOVE_EQUIP_ITEM_COMMAND ();


        /// <summary>
        ///   System.Void RemoveEquipment()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquipment")]
        ///  extern void REMOVE_EQUIPMENT ();


        /// <summary>
        ///   System.Void RemoveEquipmentChangedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquipmentChangedEvent")]
        ///  extern void REMOVE_EQUIPMENT_CHANGED_EVENT ();


        /// <summary>
        ///   System.Void RemoveEquipmentEffects()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquipmentEffects")]
        ///  extern void REMOVE_EQUIPMENT_EFFECTS ();


        /// <summary>
        ///   System.Void RemoveEquipmentItemData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquipmentItemData")]
        ///  extern void REMOVE_EQUIPMENT_ITEM_DATA ();


        /// <summary>
        ///   System.Void RemoveEquippedItems()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquippedItems")]
        ///  extern void REMOVE_EQUIPPED_ITEMS ();


        /// <summary>
        ///   System.Void RemoveEquippedPlayerShipSpells()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquippedPlayerShipSpells")]
        ///  extern void REMOVE_EQUIPPED_PLAYER_SHIP_SPELLS ();


        /// <summary>
        ///   System.Void RemoveEquippedShipBlueprints()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquippedShipBlueprints")]
        ///  extern void REMOVE_EQUIPPED_SHIP_BLUEPRINTS ();


        /// <summary>
        ///   System.Void RemoveEquippedSpells()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquippedSpells")]
        ///  extern void REMOVE_EQUIPPED_SPELLS ();


        /// <summary>
        ///   System.Void RemoveFacing()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFacing")]
        ///  extern void REMOVE_FACING ();


        /// <summary>
        ///   System.Void RemoveFadeDuration()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFadeDuration")]
        ///  extern void REMOVE_FADE_DURATION ();


        /// <summary>
        ///   System.Void RemoveFiringPoint()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFiringPoint")]
        ///  extern void REMOVE_FIRING_POINT ();


        /// <summary>
        ///   System.Void RemoveFloatTransitionEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFloatTransitionEvent")]
        ///  extern void REMOVE_FLOAT_TRANSITION_EVENT ();


        /// <summary>
        ///   System.Void RemoveFoam()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFoam")]
        ///  extern void REMOVE_FOAM ();


        /// <summary>
        ///   System.Void RemoveGameDifficulty()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameDifficulty")]
        ///  extern void REMOVE_GAME_DIFFICULTY ();


        /// <summary>
        ///   System.Void RemoveGameDifficultyDamageModifier()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameDifficultyDamageModifier")]
        ///  extern void REMOVE_GAME_DIFFICULTY_DAMAGE_MODIFIER ();


        /// <summary>
        ///   System.Void RemoveGameDifficultyHeathModifier()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameDifficultyHeathModifier")]
        ///  extern void REMOVE_GAME_DIFFICULTY_HEATH_MODIFIER ();


        /// <summary>
        ///   System.Void RemoveGameEntityId()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameEntityId")]
        ///  extern void REMOVE_GAME_ENTITY_ID ();


        /// <summary>
        ///   System.Void RemoveGameOverEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameOverEvent")]
        ///  extern void REMOVE_GAME_OVER_EVENT ();


        /// <summary>
        ///   System.Void RemoveGameOverNoSaveOverride()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameOverNoSaveOverride")]
        ///  extern void REMOVE_GAME_OVER_NO_SAVE_OVERRIDE ();


        /// <summary>
        ///   System.Void RemoveGraphicObjContainer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGraphicObjContainer")]
        ///  extern void REMOVE_GRAPHIC_OBJ_CONTAINER ();


        /// <summary>
        ///   System.Void RemoveGunAmmo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGunAmmo")]
        ///  extern void REMOVE_GUN_AMMO ();


        /// <summary>
        ///   System.Void RemoveGunReload()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGunReload")]
        ///  extern void REMOVE_GUN_RELOAD ();


        /// <summary>
        ///   System.Void RemoveGunReloadProgress()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGunReloadProgress")]
        ///  extern void REMOVE_GUN_RELOAD_PROGRESS ();


        /// <summary>
        ///   System.Void RemoveGunReloadTimer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGunReloadTimer")]
        ///  extern void REMOVE_GUN_RELOAD_TIMER ();


        /// <summary>
        ///   System.Void RemoveHealCompletedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHealCompletedEvent")]
        ///  extern void REMOVE_HEAL_COMPLETED_EVENT ();


        /// <summary>
        ///   System.Void RemoveHealer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHealer")]
        ///  extern void REMOVE_HEALER ();


        /// <summary>
        ///   System.Void RemoveHealStartedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHealStartedEvent")]
        ///  extern void REMOVE_HEAL_STARTED_EVENT ();


        /// <summary>
        ///   System.Void RemoveHealth()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHealth")]
        ///  extern void REMOVE_HEALTH ();


        /// <summary>
        ///   System.Void RemoveHealthRegenTickCounter()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHealthRegenTickCounter")]
        ///  extern void REMOVE_HEALTH_REGEN_TICK_COUNTER ();


        /// <summary>
        ///   System.Void RemoveHealthStat()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHealthStat")]
        ///  extern void REMOVE_HEALTH_STAT ();


        /// <summary>
        ///   System.Void RemoveHitStop()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHitStop")]
        ///  extern void REMOVE_HIT_STOP ();


        /// <summary>
        ///   System.Void RemoveHitStopEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHitStopEvent")]
        ///  extern void REMOVE_HIT_STOP_EVENT ();


        /// <summary>
        ///   System.Void RemoveId()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveId")]
        ///  extern void REMOVE_ID ();


        /// <summary>
        ///   System.Void RemoveIFrame()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveIFrame")]
        ///  extern void REMOVE_I_FRAME ();


        /// <summary>
        ///   System.Void RemoveInfinityTowerTimer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInfinityTowerTimer")]
        ///  extern void REMOVE_INFINITY_TOWER_TIMER ();


        /// <summary>
        ///   System.Void RemoveInHealRegion()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInHealRegion")]
        ///  extern void REMOVE_IN_HEAL_REGION ();


        /// <summary>
        ///   System.Void RemoveInitialDirection()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInitialDirection")]
        ///  extern void REMOVE_INITIAL_DIRECTION ();


        /// <summary>
        ///   System.Void RemoveInitialPosition()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInitialPosition")]
        ///  extern void REMOVE_INITIAL_POSITION ();


        /// <summary>
        ///   System.Void RemoveInPotentialHealRegion()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInPotentialHealRegion")]
        ///  extern void REMOVE_IN_POTENTIAL_HEAL_REGION ();


        /// <summary>
        ///   System.Void RemoveInputStateCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInputStateCommand")]
        ///  extern void REMOVE_INPUT_STATE_COMMAND ();


        /// <summary>
        ///   System.Void RemoveInstancePortal()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInstancePortal")]
        ///  extern void REMOVE_INSTANCE_PORTAL ();


        /// <summary>
        ///   System.Void RemoveIntCounter()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveIntCounter")]
        ///  extern void REMOVE_INT_COUNTER ();


        /// <summary>
        ///   System.Void RemoveInteractable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInteractable")]
        ///  extern void REMOVE_INTERACTABLE ();


        /// <summary>
        ///   System.Void RemoveInteractableFailInteractableEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInteractableFailInteractableEvent")]
        ///  extern void REMOVE_INTERACTABLE_FAIL_INTERACTABLE_EVENT ();


        /// <summary>
        ///   System.Void RemoveInteractableFailValidateEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInteractableFailValidateEvent")]
        ///  extern void REMOVE_INTERACTABLE_FAIL_VALIDATE_EVENT ();


        /// <summary>
        ///   System.Void RemoveInteractableStatus()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInteractableStatus")]
        ///  extern void REMOVE_INTERACTABLE_STATUS ();


        /// <summary>
        ///   System.Void RemoveInteractableStatusUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInteractableStatusUpdatedEvent")]
        ///  extern void REMOVE_INTERACTABLE_STATUS_UPDATED_EVENT ();


        /// <summary>
        ///   System.Void RemoveInteractableTriggeredTargetEntitiesUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInteractableTriggeredTargetEntitiesUpdatedEvent")]
        ///  extern void REMOVE_INTERACTABLE_TRIGGERED_TARGET_ENTITIES_UPDATED_EVENT ();


        /// <summary>
        ///   System.Void RemoveInteractCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInteractCommand")]
        ///  extern void REMOVE_INTERACT_COMMAND ();


        /// <summary>
        ///   System.Void RemoveInteractCommandUpdate()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInteractCommandUpdate")]
        ///  extern void REMOVE_INTERACT_COMMAND_UPDATE ();


        /// <summary>
        ///   System.Void RemoveInteractLookAt()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInteractLookAt")]
        ///  extern void REMOVE_INTERACT_LOOK_AT ();


        /// <summary>
        ///   System.Void RemoveInventoryCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInventoryCommand")]
        ///  extern void REMOVE_INVENTORY_COMMAND ();


        /// <summary>
        ///   System.Void RemoveInventoryLevel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInventoryLevel")]
        ///  extern void REMOVE_INVENTORY_LEVEL ();


        /// <summary>
        ///   System.Void RemoveInventorySpellInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInventorySpellInfo")]
        ///  extern void REMOVE_INVENTORY_SPELL_INFO ();


        /// <summary>
        ///   System.Void RemoveInvisibleWall()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInvisibleWall")]
        ///  extern void REMOVE_INVISIBLE_WALL ();


        /// <summary>
        ///   System.Void RemoveinWall()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveinWall")]
        ///  extern void REMOVEIN_WALL ();


        /// <summary>
        ///   System.Void RemoveKnockbackMultiplier()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveKnockbackMultiplier")]
        ///  extern void REMOVE_KNOCKBACK_MULTIPLIER ();


        /// <summary>
        ///   System.Void RemoveLastSeenDuration()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLastSeenDuration")]
        ///  extern void REMOVE_LAST_SEEN_DURATION ();


        /// <summary>
        ///   System.Void RemoveLatestInfinityTowerClearedWave()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLatestInfinityTowerClearedWave")]
        ///  extern void REMOVE_LATEST_INFINITY_TOWER_CLEARED_WAVE ();


        /// <summary>
        ///   System.Void RemoveLifetime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLifetime")]
        ///  extern void REMOVE_LIFETIME ();


        /// <summary>
        ///   System.Void RemoveLifetimeTarget()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLifetimeTarget")]
        ///  extern void REMOVE_LIFETIME_TARGET ();


        /// <summary>
        ///   System.Void RemoveLocationData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLocationData")]
        ///  extern void REMOVE_LOCATION_DATA ();


        /// <summary>
        ///   System.Void RemoveLootDropLevel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLootDropLevel")]
        ///  extern void REMOVE_LOOT_DROP_LEVEL ();


        /// <summary>
        ///   System.Void RemoveLootMagnet()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLootMagnet")]
        ///  extern void REMOVE_LOOT_MAGNET ();


        /// <summary>
        ///   System.Void RemoveLootMultiplier()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLootMultiplier")]
        ///  extern void REMOVE_LOOT_MULTIPLIER ();


        /// <summary>
        ///   System.Void RemoveLootTable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLootTable")]
        ///  extern void REMOVE_LOOT_TABLE ();


        /// <summary>
        ///   System.Void RemoveLootTimer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLootTimer")]
        ///  extern void REMOVE_LOOT_TIMER ();


        /// <summary>
        ///   System.Void RemoveMagicStat()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMagicStat")]
        ///  extern void REMOVE_MAGIC_STAT ();


        /// <summary>
        ///   System.Void RemoveMainSprite()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMainSprite")]
        ///  extern void REMOVE_MAIN_SPRITE ();


        /// <summary>
        ///   System.Void RemoveMana()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMana")]
        ///  extern void REMOVE_MANA ();


        /// <summary>
        ///   System.Void RemoveManaBar()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveManaBar")]
        ///  extern void REMOVE_MANA_BAR ();


        /// <summary>
        ///   System.Void RemoveMapIconDisplayLink()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapIconDisplayLink")]
        ///  extern void REMOVE_MAP_ICON_DISPLAY_LINK ();


        /// <summary>
        ///   System.Void RemoveMapMarkerWorld()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapMarkerWorld")]
        ///  extern void REMOVE_MAP_MARKER_WORLD ();


        /// <summary>
        ///   System.Void RemoveMapMarkerWorldIndex()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapMarkerWorldIndex")]
        ///  extern void REMOVE_MAP_MARKER_WORLD_INDEX ();


        /// <summary>
        ///   System.Void RemoveMaxMoveSpeed()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMaxMoveSpeed")]
        ///  extern void REMOVE_MAX_MOVE_SPEED ();


        /// <summary>
        ///   System.Void RemoveMeleeAttackCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMeleeAttackCommand")]
        ///  extern void REMOVE_MELEE_ATTACK_COMMAND ();


        /// <summary>
        ///   System.Void RemoveMonsterBehaviour()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMonsterBehaviour")]
        ///  extern void REMOVE_MONSTER_BEHAVIOUR ();


        /// <summary>
        ///   System.Void RemoveMonsterDetector()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMonsterDetector")]
        ///  extern void REMOVE_MONSTER_DETECTOR ();


        /// <summary>
        ///   System.Void RemoveMonsterDetectorInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMonsterDetectorInfo")]
        ///  extern void REMOVE_MONSTER_DETECTOR_INFO ();


        /// <summary>
        ///   System.Void RemoveMonsterDetectorRequestor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMonsterDetectorRequestor")]
        ///  extern void REMOVE_MONSTER_DETECTOR_REQUESTOR ();


        /// <summary>
        ///   System.Void RemoveMonsterDetectorResultInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMonsterDetectorResultInfo")]
        ///  extern void REMOVE_MONSTER_DETECTOR_RESULT_INFO ();


        /// <summary>
        ///   System.Void RemoveMonsterTrait()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMonsterTrait")]
        ///  extern void REMOVE_MONSTER_TRAIT ();


        /// <summary>
        ///   System.Void RemoveMoveSpeed()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMoveSpeed")]
        ///  extern void REMOVE_MOVE_SPEED ();


        /// <summary>
        ///   System.Void RemoveNavAgentTarget()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveNavAgentTarget")]
        ///  extern void REMOVE_NAV_AGENT_TARGET ();


        /// <summary>
        ///   System.Void RemoveNavMeshAgent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveNavMeshAgent")]
        ///  extern void REMOVE_NAV_MESH_AGENT ();


        /// <summary>
        ///   System.Void RemoveNavPath()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveNavPath")]
        ///  extern void REMOVE_NAV_PATH ();


        /// <summary>
        ///   System.Void RemoveObjectiveInteractor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveObjectiveInteractor")]
        ///  extern void REMOVE_OBJECTIVE_INTERACTOR ();


        /// <summary>
        ///   System.Void RemoveOnDeathAnimCompleteEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOnDeathAnimCompleteEvent")]
        ///  extern void REMOVE_ON_DEATH_ANIM_COMPLETE_EVENT ();


        /// <summary>
        ///   System.Void RemoveOnDeathEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOnDeathEvent")]
        ///  extern void REMOVE_ON_DEATH_EVENT ();


        /// <summary>
        ///   System.Void RemoveOnHitIFrameData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOnHitIFrameData")]
        ///  extern void REMOVE_ON_HIT_I_FRAME_DATA ();


        /// <summary>
        ///   System.Void RemoveOnReviveCallback()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOnReviveCallback")]
        ///  extern void REMOVE_ON_REVIVE_CALLBACK ();


        /// <summary>
        ///   System.Void RemoveOriginalLocalScale()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOriginalLocalScale")]
        ///  extern void REMOVE_ORIGINAL_LOCAL_SCALE ();


        /// <summary>
        ///   System.Void RemoveOverlapList()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOverlapList")]
        ///  extern void REMOVE_OVERLAP_LIST ();


        /// <summary>
        ///   System.Void RemoveOverrideCharacterGender()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOverrideCharacterGender")]
        ///  extern void REMOVE_OVERRIDE_CHARACTER_GENDER ();


        /// <summary>
        ///   System.Void RemoveOwner()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOwner")]
        ///  extern void REMOVE_OWNER ();


        /// <summary>
        ///   System.Void RemoveParticleEffect()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveParticleEffect")]
        ///  extern void REMOVE_PARTICLE_EFFECT ();


        /// <summary>
        ///   System.Void RemovePlayerAddedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerAddedEvent")]
        ///  extern void REMOVE_PLAYER_ADDED_EVENT ();


        /// <summary>
        ///   System.Void RemovePlayerId()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerId")]
        ///  extern void REMOVE_PLAYER_ID ();


        /// <summary>
        ///   System.Void RemovePlayerIdReference()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerIdReference")]
        ///  extern void REMOVE_PLAYER_ID_REFERENCE ();


        /// <summary>
        ///   System.Void RemovePlayerKilledSource()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerKilledSource")]
        ///  extern void REMOVE_PLAYER_KILLED_SOURCE ();


        /// <summary>
        ///   System.Void RemovePlayerReference()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerReference")]
        ///  extern void REMOVE_PLAYER_REFERENCE ();


        /// <summary>
        ///   System.Void RemovePlayerRemovedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerRemovedEvent")]
        ///  extern void REMOVE_PLAYER_REMOVED_EVENT ();


        /// <summary>
        ///   System.Void RemovePlayerSleepingSaveStone()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerSleepingSaveStone")]
        ///  extern void REMOVE_PLAYER_SLEEPING_SAVE_STONE ();


        /// <summary>
        ///   System.Void RemovePlayerStat()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerStat")]
        ///  extern void REMOVE_PLAYER_STAT ();


        /// <summary>
        ///   System.Void RemovePlayerVicinity()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerVicinity")]
        ///  extern void REMOVE_PLAYER_VICINITY ();


        /// <summary>
        ///   System.Void RemovePoolStatusTable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePoolStatusTable")]
        ///  extern void REMOVE_POOL_STATUS_TABLE ();


        /// <summary>
        ///   System.Void RemovePosition()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePosition")]
        ///  extern void REMOVE_POSITION ();


        /// <summary>
        ///   System.Void RemovePositionAttach()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePositionAttach")]
        ///  extern void REMOVE_POSITION_ATTACH ();


        /// <summary>
        ///   System.Void RemovePositionHistory()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePositionHistory")]
        ///  extern void REMOVE_POSITION_HISTORY ();


        /// <summary>
        ///   System.Void RemovePositionTween()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePositionTween")]
        ///  extern void REMOVE_POSITION_TWEEN ();


        /// <summary>
        ///   System.Void RemoveProjectileBehaviour()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveProjectileBehaviour")]
        ///  extern void REMOVE_PROJECTILE_BEHAVIOUR ();


        /// <summary>
        ///   System.Void RemoveProjectileColliderInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveProjectileColliderInfo")]
        ///  extern void REMOVE_PROJECTILE_COLLIDER_INFO ();


        /// <summary>
        ///   System.Void RemoveProjectileInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveProjectileInfo")]
        ///  extern void REMOVE_PROJECTILE_INFO ();


        /// <summary>
        ///   System.Void RemoveProjectileMovement()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveProjectileMovement")]
        ///  extern void REMOVE_PROJECTILE_MOVEMENT ();


        /// <summary>
        ///   System.Void RemoveProjectileReference()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveProjectileReference")]
        ///  extern void REMOVE_PROJECTILE_REFERENCE ();


        /// <summary>
        ///   System.Void RemoveProjectileVfxReference()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveProjectileVfxReference")]
        ///  extern void REMOVE_PROJECTILE_VFX_REFERENCE ();


        /// <summary>
        ///   System.Void RemovePromptRemovePlayerEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePromptRemovePlayerEvent")]
        ///  extern void REMOVE_PROMPT_REMOVE_PLAYER_EVENT ();


        /// <summary>
        ///   System.Void RemovePuzzleAnswer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePuzzleAnswer")]
        ///  extern void REMOVE_PUZZLE_ANSWER ();


        /// <summary>
        ///   System.Void RemovePuzzleAnswerCompletedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePuzzleAnswerCompletedEvent")]
        ///  extern void REMOVE_PUZZLE_ANSWER_COMPLETED_EVENT ();


        /// <summary>
        ///   System.Void RemovePuzzleAnswerState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePuzzleAnswerState")]
        ///  extern void REMOVE_PUZZLE_ANSWER_STATE ();


        /// <summary>
        ///   System.Void RemovePuzzleLootLocation()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePuzzleLootLocation")]
        ///  extern void REMOVE_PUZZLE_LOOT_LOCATION ();


        /// <summary>
        ///   System.Void RemovePuzzlePieceID()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePuzzlePieceID")]
        ///  extern void REMOVE_PUZZLE_PIECE_ID ();


        /// <summary>
        ///   System.Void RemovePuzzlePieceInteractedCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePuzzlePieceInteractedCount")]
        ///  extern void REMOVE_PUZZLE_PIECE_INTERACTED_COUNT ();


        /// <summary>
        ///   System.Void RemovePuzzlePieceInteractedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePuzzlePieceInteractedEvent")]
        ///  extern void REMOVE_PUZZLE_PIECE_INTERACTED_EVENT ();


        /// <summary>
        ///   System.Void RemoveQuestFsm()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveQuestFsm")]
        ///  extern void REMOVE_QUEST_FSM ();


        /// <summary>
        ///   System.Void RemoveRecovery()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRecovery")]
        ///  extern void REMOVE_RECOVERY ();


        /// <summary>
        ///   System.Void RemoveRendererTinter()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRendererTinter")]
        ///  extern void REMOVE_RENDERER_TINTER ();


        /// <summary>
        ///   System.Void RemoveRenderTransform()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRenderTransform")]
        ///  extern void REMOVE_RENDER_TRANSFORM ();


        /// <summary>
        ///   System.Void RemoveRestTriggeredEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRestTriggeredEvent")]
        ///  extern void REMOVE_REST_TRIGGERED_EVENT ();


        /// <summary>
        ///   System.Void RemoveReviveBeacon()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveReviveBeacon")]
        ///  extern void REMOVE_REVIVE_BEACON ();


        /// <summary>
        ///   System.Void RemoveReviveBeaconReference()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveReviveBeaconReference")]
        ///  extern void REMOVE_REVIVE_BEACON_REFERENCE ();


        /// <summary>
        ///   System.Void RemoveReviveEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveReviveEvent")]
        ///  extern void REMOVE_REVIVE_EVENT ();


        /// <summary>
        ///   System.Void RemoveRigidbody()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRigidbody")]
        ///  extern void REMOVE_RIGIDBODY ();


        /// <summary>
        ///   System.Void RemoveRollCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRollCommand")]
        ///  extern void REMOVE_ROLL_COMMAND ();


        /// <summary>
        ///   System.Void RemoveRollCooldown()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRollCooldown")]
        ///  extern void REMOVE_ROLL_COOLDOWN ();


        /// <summary>
        ///   System.Void RemoveRollCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRollCount")]
        ///  extern void REMOVE_ROLL_COUNT ();


        /// <summary>
        ///   System.Void RemoveRotationTween()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRotationTween")]
        ///  extern void REMOVE_ROTATION_TWEEN ();


        /// <summary>
        ///   System.Void RemoveSaveStone()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSaveStone")]
        ///  extern void REMOVE_SAVE_STONE ();


        /// <summary>
        ///   System.Void RemoveScreenEffect()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveScreenEffect")]
        ///  extern void REMOVE_SCREEN_EFFECT ();


        /// <summary>
        ///   System.Void RemoveScreenEffectPlayer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveScreenEffectPlayer")]
        ///  extern void REMOVE_SCREEN_EFFECT_PLAYER ();


        /// <summary>
        ///   System.Void RemoveSecondPlayer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSecondPlayer")]
        ///  extern void REMOVE_SECOND_PLAYER ();


        /// <summary>
        ///   System.Void RemoveSelectedTavernTalesData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSelectedTavernTalesData")]
        ///  extern void REMOVE_SELECTED_TAVERN_TALES_DATA ();


        /// <summary>
        ///   System.Void RemoveShadow()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShadow")]
        ///  extern void REMOVE_SHADOW ();


        /// <summary>
        ///   System.Void RemoveShipBlueprintEffects()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipBlueprintEffects")]
        ///  extern void REMOVE_SHIP_BLUEPRINT_EFFECTS ();


        /// <summary>
        ///   System.Void RemoveShipBlueprintItemData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipBlueprintItemData")]
        ///  extern void REMOVE_SHIP_BLUEPRINT_ITEM_DATA ();


        /// <summary>
        ///   System.Void RemoveShipBlueprintsRefreshedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipBlueprintsRefreshedEvent")]
        ///  extern void REMOVE_SHIP_BLUEPRINTS_REFRESHED_EVENT ();


        /// <summary>
        ///   System.Void RemoveShipBoost()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipBoost")]
        ///  extern void REMOVE_SHIP_BOOST ();


        /// <summary>
        ///   System.Void RemoveShipCannon()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipCannon")]
        ///  extern void REMOVE_SHIP_CANNON ();


        /// <summary>
        ///   System.Void RemoveShipCannonAttackConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipCannonAttackConfig")]
        ///  extern void REMOVE_SHIP_CANNON_ATTACK_CONFIG ();


        /// <summary>
        ///   System.Void RemoveShipCannonRotationDelta()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipCannonRotationDelta")]
        ///  extern void REMOVE_SHIP_CANNON_ROTATION_DELTA ();


        /// <summary>
        ///   System.Void RemoveShipConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipConfig")]
        ///  extern void REMOVE_SHIP_CONFIG ();


        /// <summary>
        ///   System.Void RemoveShipDock()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipDock")]
        ///  extern void REMOVE_SHIP_DOCK ();


        /// <summary>
        ///   System.Void RemoveShipEnterCamFocusRuntimeScreenEffect()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipEnterCamFocusRuntimeScreenEffect")]
        ///  extern void REMOVE_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT ();


        /// <summary>
        ///   System.Void RemoveShipExitSensorRange()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipExitSensorRange")]
        ///  extern void REMOVE_SHIP_EXIT_SENSOR_RANGE ();


        /// <summary>
        ///   System.Void RemoveShipFeedbackState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipFeedbackState")]
        ///  extern void REMOVE_SHIP_FEEDBACK_STATE ();


        /// <summary>
        ///   System.Void RemoveShipMovementPoint()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipMovementPoint")]
        ///  extern void REMOVE_SHIP_MOVEMENT_POINT ();


        /// <summary>
        ///   System.Void RemoveShipPassengerUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipPassengerUpdatedEvent")]
        ///  extern void REMOVE_SHIP_PASSENGER_UPDATED_EVENT ();


        /// <summary>
        ///   System.Void RemoveShipPathAgent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipPathAgent")]
        ///  extern void REMOVE_SHIP_PATH_AGENT ();


        /// <summary>
        ///   System.Void RemoveShipReference()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipReference")]
        ///  extern void REMOVE_SHIP_REFERENCE ();


        /// <summary>
        ///   System.Void RemoveShipSailInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipSailInfo")]
        ///  extern void REMOVE_SHIP_SAIL_INFO ();


        /// <summary>
        ///   System.Void RemoveShipSpecialAttackConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipSpecialAttackConfig")]
        ///  extern void REMOVE_SHIP_SPECIAL_ATTACK_CONFIG ();


        /// <summary>
        ///   System.Void RemoveSoundStatesReference()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSoundStatesReference")]
        ///  extern void REMOVE_SOUND_STATES_REFERENCE ();


        /// <summary>
        ///   System.Void RemoveSource()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSource")]
        ///  extern void REMOVE_SOURCE ();


        /// <summary>
        ///   System.Void RemoveSourceTransform()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSourceTransform")]
        ///  extern void REMOVE_SOURCE_TRANSFORM ();


        /// <summary>
        ///   System.Void RemoveSpawnerOverrideDuration()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpawnerOverrideDuration")]
        ///  extern void REMOVE_SPAWNER_OVERRIDE_DURATION ();


        /// <summary>
        ///   System.Void RemoveSpawnTableItem()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpawnTableItem")]
        ///  extern void REMOVE_SPAWN_TABLE_ITEM ();


        /// <summary>
        ///   System.Void RemoveSpawnTextEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpawnTextEvent")]
        ///  extern void REMOVE_SPAWN_TEXT_EVENT ();


        /// <summary>
        ///   System.Void RemoveSpeedTween()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpeedTween")]
        ///  extern void REMOVE_SPEED_TWEEN ();


        /// <summary>
        ///   System.Void RemoveSpellCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpellCommand")]
        ///  extern void REMOVE_SPELL_COMMAND ();


        /// <summary>
        ///   System.Void RemoveSpellConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpellConfig")]
        ///  extern void REMOVE_SPELL_CONFIG ();


        /// <summary>
        ///   System.Void RemoveSpellLevelConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpellLevelConfig")]
        ///  extern void REMOVE_SPELL_LEVEL_CONFIG ();


        /// <summary>
        ///   System.Void RemoveSpellReference()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpellReference")]
        ///  extern void REMOVE_SPELL_REFERENCE ();


        /// <summary>
        ///   System.Void RemoveSpellTracker()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpellTracker")]
        ///  extern void REMOVE_SPELL_TRACKER ();


        /// <summary>
        ///   System.Void RemoveStarGuide()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveStarGuide")]
        ///  extern void REMOVE_STAR_GUIDE ();


        /// <summary>
        ///   System.Void RemoveStarGuideManager()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveStarGuideManager")]
        ///  extern void REMOVE_STAR_GUIDE_MANAGER ();


        /// <summary>
        ///   System.Void RemoveStrafeLane()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveStrafeLane")]
        ///  extern void REMOVE_STRAFE_LANE ();


        /// <summary>
        ///   System.Void RemoveStrengthStat()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveStrengthStat")]
        ///  extern void REMOVE_STRENGTH_STAT ();


        /// <summary>
        ///   System.Void RemoveSwapWeaponCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSwapWeaponCommand")]
        ///  extern void REMOVE_SWAP_WEAPON_COMMAND ();


        /// <summary>
        ///   System.Void RemoveTakeDamageEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTakeDamageEvent")]
        ///  extern void REMOVE_TAKE_DAMAGE_EVENT ();


        /// <summary>
        ///   System.Void RemoveTarget()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTarget")]
        ///  extern void REMOVE_TARGET ();


        /// <summary>
        ///   System.Void RemoveTargetList()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTargetList")]
        ///  extern void REMOVE_TARGET_LIST ();


        /// <summary>
        ///   System.Void RemoveTargetPosition()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTargetPosition")]
        ///  extern void REMOVE_TARGET_POSITION ();


        /// <summary>
        ///   System.Void RemoveTargetTransform()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTargetTransform")]
        ///  extern void REMOVE_TARGET_TRANSFORM ();


        /// <summary>
        ///   System.Void RemoveTeleportCallback()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTeleportCallback")]
        ///  extern void REMOVE_TELEPORT_CALLBACK ();


        /// <summary>
        ///   System.Void RemoveTerrainExploredCellsTable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTerrainExploredCellsTable")]
        ///  extern void REMOVE_TERRAIN_EXPLORED_CELLS_TABLE ();


        /// <summary>
        ///   System.Void RemoveTilt()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTilt")]
        ///  extern void REMOVE_TILT ();


        /// <summary>
        ///   System.Void RemoveTiltSpeed()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTiltSpeed")]
        ///  extern void REMOVE_TILT_SPEED ();


        /// <summary>
        ///   System.Void RemoveTimedBuff()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTimedBuff")]
        ///  extern void REMOVE_TIMED_BUFF ();


        /// <summary>
        ///   System.Void RemoveTimer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTimer")]
        ///  extern void REMOVE_TIMER ();


        /// <summary>
        ///   System.Void RemoveTimerCallback()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTimerCallback")]
        ///  extern void REMOVE_TIMER_CALLBACK ();


        /// <summary>
        ///   System.Void RemoveTint()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTint")]
        ///  extern void REMOVE_TINT ();


        /// <summary>
        ///   System.Void RemoveTrailRenderer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTrailRenderer")]
        ///  extern void REMOVE_TRAIL_RENDERER ();


        /// <summary>
        ///   System.Void RemoveTransform()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTransform")]
        ///  extern void REMOVE_TRANSFORM ();


        /// <summary>
        ///   System.Void RemoveTransitioning()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTransitioning")]
        ///  extern void REMOVE_TRANSITIONING ();


        /// <summary>
        ///   System.Void RemoveTriggerableInteractableType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTriggerableInteractableType")]
        ///  extern void REMOVE_TRIGGERABLE_INTERACTABLE_TYPE ();


        /// <summary>
        ///   System.Void RemoveTriggerHashSet()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTriggerHashSet")]
        ///  extern void REMOVE_TRIGGER_HASH_SET ();


        /// <summary>
        ///   System.Void RemoveTurnSpeed()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTurnSpeed")]
        ///  extern void REMOVE_TURN_SPEED ();


        /// <summary>
        ///   System.Void RemoveUnequipItemCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnequipItemCommand")]
        ///  extern void REMOVE_UNEQUIP_ITEM_COMMAND ();



        /// <summary>
        ///   System.Void RemoveGameDestroyedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameDestroyedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_GAME_DESTROYED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveGameDestroyedListener(IGameDestroyedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IGameDestroyedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameDestroyedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_GAME_DESTROYED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveGunReloadProgressListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGunReloadProgressListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_GUN_RELOAD_PROGRESS_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveGunReloadProgressListener(IGunReloadProgressListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IGunReloadProgressListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGunReloadProgressListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_GUN_RELOAD_PROGRESS_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveKilledListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveKilledListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_KILLED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveKilledListener(IKilledListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IKilledListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveKilledListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_KILLED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveNotEnoughGunAmmoEventListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveNotEnoughGunAmmoEventListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveNotEnoughGunAmmoEventListener(INotEnoughGunAmmoEventListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface INotEnoughGunAmmoEventListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveNotEnoughGunAmmoEventListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemovePlayerIdListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerIdListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_PLAYER_ID_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemovePlayerIdListener(IPlayerIdListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IPlayerIdListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerIdListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_PLAYER_ID_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemovePlayerIdRemovedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerIdRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_PLAYER_ID_REMOVED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemovePlayerIdRemovedListener(IPlayerIdRemovedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IPlayerIdRemovedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerIdRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_PLAYER_ID_REMOVED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// public static partial class Search_GameEntity
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void RemoveGameDestroyedListener()
        /// </summary>
        /// public static bool REMOVE_GAME_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveGameDestroyedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveGameDestroyedListener(IGameDestroyedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_GAME_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveGameDestroyedListener", "IGameDestroyedListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveGunReloadProgressListener()
        /// </summary>
        /// public static bool REMOVE_GUN_RELOAD_PROGRESS_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveGunReloadProgressListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveGunReloadProgressListener(IGunReloadProgressListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_GUN_RELOAD_PROGRESS_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveGunReloadProgressListener", "IGunReloadProgressListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveKilledListener()
        /// </summary>
        /// public static bool REMOVE_KILLED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveKilledListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveKilledListener(IKilledListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_KILLED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveKilledListener", "IKilledListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveNotEnoughGunAmmoEventListener()
        /// </summary>
        /// public static bool REMOVE_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveNotEnoughGunAmmoEventListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveNotEnoughGunAmmoEventListener(INotEnoughGunAmmoEventListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveNotEnoughGunAmmoEventListener", "INotEnoughGunAmmoEventListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePlayerIdListener()
        /// </summary>
        /// public static bool REMOVE_PLAYER_ID_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePlayerIdListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePlayerIdListener(IPlayerIdListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_PLAYER_ID_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePlayerIdListener", "IPlayerIdListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePlayerIdRemovedListener()
        /// </summary>
        /// public static bool REMOVE_PLAYER_ID_REMOVED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePlayerIdRemovedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePlayerIdRemovedListener(IPlayerIdRemovedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_PLAYER_ID_REMOVED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePlayerIdRemovedListener", "IPlayerIdRemovedListener", "System.Boolean");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["ProjectStar".""."GameEntity"]
    /// </summary>
    public partial class GameEntity
    {



        /// <summary>
        ///   System.Void RemoveUnitConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnitConfig")]
        ///  extern void REMOVE_UNIT_CONFIG ();


        /// <summary>
        ///   System.Void RemoveUnitLevel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnitLevel")]
        ///  extern void REMOVE_UNIT_LEVEL ();


        /// <summary>
        ///   System.Void RemoveUnlockedEquipmentList()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnlockedEquipmentList")]
        ///  extern void REMOVE_UNLOCKED_EQUIPMENT_LIST ();


        /// <summary>
        ///   System.Void RemoveUnlockedShipBlueprints()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnlockedShipBlueprints")]
        ///  extern void REMOVE_UNLOCKED_SHIP_BLUEPRINTS ();


        /// <summary>
        ///   System.Void RemoveUnlockedShipSpellTable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnlockedShipSpellTable")]
        ///  extern void REMOVE_UNLOCKED_SHIP_SPELL_TABLE ();


        /// <summary>
        ///   System.Void RemoveUnlockedSpellTable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnlockedSpellTable")]
        ///  extern void REMOVE_UNLOCKED_SPELL_TABLE ();


        /// <summary>
        ///   System.Void RemoveUpdatedGunAmmo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUpdatedGunAmmo")]
        ///  extern void REMOVE_UPDATED_GUN_AMMO ();


        /// <summary>
        ///   System.Void RemoveVelocityBuffer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveVelocityBuffer")]
        ///  extern void REMOVE_VELOCITY_BUFFER ();


        /// <summary>
        ///   System.Void RemoveVFXFollowParent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveVFXFollowParent")]
        ///  extern void REMOVE_VFX_FOLLOW_PARENT ();


        /// <summary>
        ///   System.Void RemoveVFXSpawnpoint()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveVFXSpawnpoint")]
        ///  extern void REMOVE_VFX_SPAWNPOINT ();


        /// <summary>
        ///   System.Void RemoveWallColliders()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWallColliders")]
        ///  extern void REMOVE_WALL_COLLIDERS ();


        /// <summary>
        ///   System.Void RemoveWaterRipplesParticles()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWaterRipplesParticles")]
        ///  extern void REMOVE_WATER_RIPPLES_PARTICLES ();


        /// <summary>
        ///   System.Void RemoveWorldUIButtonAnchorPosOffset()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldUIButtonAnchorPosOffset")]
        ///  extern void REMOVE_WORLD_UI_BUTTON_ANCHOR_POS_OFFSET ();


        /// <summary>
        ///   System.Void RemoveWorldUIButtonAttachFlipSprite()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldUIButtonAttachFlipSprite")]
        ///  extern void REMOVE_WORLD_UI_BUTTON_ATTACH_FLIP_SPRITE ();


        /// <summary>
        ///   System.Void RemoveWorldUIButtonAttachParent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldUIButtonAttachParent")]
        ///  extern void REMOVE_WORLD_UI_BUTTON_ATTACH_PARENT ();


        /// <summary>
        ///   System.Void ReplaceActiveScreenEffectPlayer(ScreenEffectPlayer newValue)
        /// </summary>
        /// <param name="newValue">class ScreenEffectPlayer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceActiveScreenEffectPlayer")]
        ///  extern void REPLACE_ACTIVE_SCREEN_EFFECT_PLAYER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceActiveWeaponChangedEvent(GameEntity newOwner, Equipment newWeapon)
        /// </summary>
        /// <param name="newOwner">class GameEntity</param>
        /// <param name="newWeapon">class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceActiveWeaponChangedEvent")]
        ///  extern void REPLACE_ACTIVE_WEAPON_CHANGED_EVENT (nint newOwner, nint newWeapon);


        /// <summary>
        ///   System.Void ReplaceAdvancedStatModifiers(AdvancedStats newValue)
        /// </summary>
        /// <param name="newValue">class AdvancedStats</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAdvancedStatModifiers")]
        ///  extern void REPLACE_ADVANCED_STAT_MODIFIERS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAgentDestination(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAgentDestination")]
        ///  extern void REPLACE_AGENT_DESTINATION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void ReplaceAgentPreviousDestination(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAgentPreviousDestination")]
        ///  extern void REPLACE_AGENT_PREVIOUS_DESTINATION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void ReplaceAnchorPosOffset(UnityEngine.Vector2 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnchorPosOffset")]
        ///  extern void REPLACE_ANCHOR_POS_OFFSET (UnityEngine.Vector2 newValue);


        /// <summary>
        ///   System.Void ReplaceAngleOffset(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAngleOffset")]
        ///  extern void REPLACE_ANGLE_OFFSET (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceAnimation(UnityEngine.Animation newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Animation</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnimation")]
        ///  extern void REPLACE_ANIMATION (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAnimationFlags(AnimationFlags newValue)
        /// </summary>
        /// <param name="newValue">enum AnimationFlags</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnimationFlags")]
        ///  extern void REPLACE_ANIMATION_FLAGS (AnimationFlags newValue);


        /// <summary>
        ///   System.Void ReplaceAnimationProgress(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnimationProgress")]
        ///  extern void REPLACE_ANIMATION_PROGRESS (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceAnimator(UnityEngine.Animator newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Animator</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnimator")]
        ///  extern void REPLACE_ANIMATOR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAnyActiveWeaponChangedEventListener(System.Collections.Generic.List<IAnyActiveWeaponChangedEventListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyActiveWeaponChangedEventListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnyActiveWeaponChangedEventListener")]
        ///  extern void REPLACE_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAnyShipEnterBlockedListener(System.Collections.Generic.List<IAnyShipEnterBlockedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyShipEnterBlockedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnyShipEnterBlockedListener")]
        ///  extern void REPLACE_ANY_SHIP_ENTER_BLOCKED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAnyShipEnterBlockedRemovedListener(System.Collections.Generic.List<IAnyShipEnterBlockedRemovedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyShipEnterBlockedRemovedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnyShipEnterBlockedRemovedListener")]
        ///  extern void REPLACE_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAoeColliderType(AoeColliderType newValue)
        /// </summary>
        /// <param name="newValue">enum AoeColliderType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAoeColliderType")]
        ///  extern void REPLACE_AOE_COLLIDER_TYPE (AoeColliderType newValue);


        /// <summary>
        ///   System.Void ReplaceAoeInfo(AoeInfo newValue)
        /// </summary>
        /// <param name="newValue">class AoeInfo</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAoeInfo")]
        ///  extern void REPLACE_AOE_INFO (nint newValue);


        /// <summary>
        ///   System.Void ReplaceArtPrefabReference(ArtPrefabReference newValue)
        /// </summary>
        /// <param name="newValue">class ArtPrefabReference</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceArtPrefabReference")]
        ///  extern void REPLACE_ART_PREFAB_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAttachableFloat(UnityEngine.GameObject newAttachableFloat)
        /// </summary>
        /// <param name="newAttachableFloat">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAttachableFloat")]
        ///  extern void REPLACE_ATTACHABLE_FLOAT (nint newAttachableFloat);


        /// <summary>
        ///   System.Void ReplaceAttachedVfxTracker(System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAttachedVfxTracker")]
        ///  extern void REPLACE_ATTACHED_VFX_TRACKER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAttackAnimation(System.Single newPreAttackDuration, System.Single newDuringAttack, System.Single newPostAttackDuration)
        /// </summary>
        /// <param name="newPreAttackDuration">struct System.Single</param>
        /// <param name="newDuringAttack">struct System.Single</param>
        /// <param name="newPostAttackDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAttackAnimation")]
        ///  extern void REPLACE_ATTACK_ANIMATION (System.Single newPreAttackDuration, System.Single newDuringAttack, System.Single newPostAttackDuration);


        /// <summary>
        ///   System.Void ReplaceAttackCommand(UnityEngine.Vector3 newDirection, System.Single newLifetime, System.Boolean newProcessed)
        /// </summary>
        /// <param name="newDirection">struct UnityEngine.Vector3</param>
        /// <param name="newLifetime">struct System.Single</param>
        /// <param name="newProcessed">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAttackCommand")]
        ///  extern void REPLACE_ATTACK_COMMAND (UnityEngine.Vector3 newDirection, System.Single newLifetime, System.Boolean newProcessed);


        /// <summary>
        ///   System.Void ReplaceAttackEventInfo(AttackEventInfo newValue)
        /// </summary>
        /// <param name="newValue">class AttackEventInfo</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAttackEventInfo")]
        ///  extern void REPLACE_ATTACK_EVENT_INFO (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAttackReference(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAttackReference")]
        ///  extern void REPLACE_ATTACK_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAttackTellView(AttackTellView newValue)
        /// </summary>
        /// <param name="newValue">class AttackTellView</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAttackTellView")]
        ///  extern void REPLACE_ATTACK_TELL_VIEW (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAttackTint(UnityEngine.Color newColor)
        /// </summary>
        /// <param name="newColor">struct UnityEngine.Color</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAttackTint")]
        ///  extern void REPLACE_ATTACK_TINT (UnityEngine.Color newColor);


        /// <summary>
        ///   System.Void ReplaceAwardedQuestItems(QuestItemContainer newValue)
        /// </summary>
        /// <param name="newValue">class QuestItemContainer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAwardedQuestItems")]
        ///  extern void REPLACE_AWARDED_QUEST_ITEMS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceBaseEnemyBehaviour(BaseEnemyBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class BaseEnemyBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBaseEnemyBehaviour")]
        ///  extern void REPLACE_BASE_ENEMY_BEHAVIOUR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceBehaviourTree(BehaviorDesigner.Runtime.BehaviorTree newValue)
        /// </summary>
        /// <param name="newValue">class BehaviorDesigner.Runtime.BehaviorTree</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBehaviourTree")]
        ///  extern void REPLACE_BEHAVIOUR_TREE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceBlockEffectCooldown(System.Single newDurationRemaining)
        /// </summary>
        /// <param name="newDurationRemaining">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBlockEffectCooldown")]
        ///  extern void REPLACE_BLOCK_EFFECT_COOLDOWN (System.Single newDurationRemaining);


        /// <summary>
        ///   System.Void ReplaceBlockFreezeDuration(System.Single newDuration)
        /// </summary>
        /// <param name="newDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBlockFreezeDuration")]
        ///  extern void REPLACE_BLOCK_FREEZE_DURATION (System.Single newDuration);


        /// <summary>
        ///   System.Void ReplaceBurnCounter(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBurnCounter")]
        ///  extern void REPLACE_BURN_COUNTER (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceCannonCooldown(System.Single newRegular, System.Single newSpecial, System.Single newRegularCache, System.Single newSpecialCache)
        /// </summary>
        /// <param name="newRegular">struct System.Single</param>
        /// <param name="newSpecial">struct System.Single</param>
        /// <param name="newRegularCache">struct System.Single</param>
        /// <param name="newSpecialCache">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCannonCooldown")]
        ///  extern void REPLACE_CANNON_COOLDOWN (System.Single newRegular, System.Single newSpecial, System.Single newRegularCache, System.Single newSpecialCache);


        /// <summary>
        ///   System.Void ReplaceCapsule(UnityEngine.Vector3 newLocalPoint0, UnityEngine.Vector3 newLocalPoint1)
        /// </summary>
        /// <param name="newLocalPoint0">struct UnityEngine.Vector3</param>
        /// <param name="newLocalPoint1">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCapsule")]
        ///  extern void REPLACE_CAPSULE (UnityEngine.Vector3 newLocalPoint0, UnityEngine.Vector3 newLocalPoint1);


        /// <summary>
        ///   System.Void ReplaceCharacterController(UnityEngine.CharacterController newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.CharacterController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCharacterController")]
        ///  extern void REPLACE_CHARACTER_CONTROLLER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCharacterGender(CharacterGender newValue)
        /// </summary>
        /// <param name="newValue">enum CharacterGender</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCharacterGender")]
        ///  extern void REPLACE_CHARACTER_GENDER (CharacterGender newValue);


        /// <summary>
        ///   System.Void ReplaceChargeConfig(ChargeConfig newValue)
        /// </summary>
        /// <param name="newValue">class ChargeConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceChargeConfig")]
        ///  extern void REPLACE_CHARGE_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void ReplaceChest(ChestBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class ChestBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceChest")]
        ///  extern void REPLACE_CHEST (nint newValue);


        /// <summary>
        ///   System.Void ReplaceChestInteractor(GameEntity newEntity)
        /// </summary>
        /// <param name="newEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceChestInteractor")]
        ///  extern void REPLACE_CHEST_INTERACTOR (nint newEntity);


        /// <summary>
        ///   System.Void ReplaceCollatedAoeAttacks(System.Collections.Generic.Dictionary<DealCollatedAoeDamageEffect,System.Int32> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.Dictionary<DealCollatedAoeDamageEffect,System.Int32></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCollatedAoeAttacks")]
        ///  extern void REPLACE_COLLATED_AOE_ATTACKS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCollectibleCollectedEvent(UnityEngine.Transform newTarget, System.Int32 newValue, DamageTextAnimation newTextAnimationData)
        /// </summary>
        /// <param name="newTarget">class UnityEngine.Transform</param>
        /// <param name="newValue">struct System.Int32</param>
        /// <param name="newTextAnimationData">class DamageTextAnimation</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCollectibleCollectedEvent")]
        ///  extern void REPLACE_COLLECTIBLE_COLLECTED_EVENT (nint newTarget, System.Int32 newValue, nint newTextAnimationData);


        /// <summary>
        ///   System.Void ReplaceCollectibleReference(CollectibleBase newValue)
        /// </summary>
        /// <param name="newValue">abstract class CollectibleBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCollectibleReference")]
        ///  extern void REPLACE_COLLECTIBLE_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCollider(UnityEngine.Collider newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Collider</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCollider")]
        ///  extern void REPLACE_COLLIDER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCombatAgent(CombatAgent newValue)
        /// </summary>
        /// <param name="newValue">class CombatAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCombatAgent")]
        ///  extern void REPLACE_COMBAT_AGENT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCombatAgentHealthUpdatedEvent(CombatAgent newCombatAgent)
        /// </summary>
        /// <param name="newCombatAgent">class CombatAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCombatAgentHealthUpdatedEvent")]
        ///  extern void REPLACE_COMBAT_AGENT_HEALTH_UPDATED_EVENT (nint newCombatAgent);


        /// <summary>
        ///   System.Void ReplaceCombatAgentList(System.Collections.Generic.List<CombatAgent> newList)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<CombatAgent></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCombatAgentList")]
        ///  extern void REPLACE_COMBAT_AGENT_LIST (nint newList);


        /// <summary>
        ///   System.Void ReplaceCombatAggroDuration(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCombatAggroDuration")]
        ///  extern void REPLACE_COMBAT_AGGRO_DURATION (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceCombatLog(CombatLog newValue)
        /// </summary>
        /// <param name="newValue">class CombatLog</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCombatLog")]
        ///  extern void REPLACE_COMBAT_LOG (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCombatProxyAgent(GameEntity newSourceEntity, CombatProxyAgent newValue)
        /// </summary>
        /// <param name="newSourceEntity">class GameEntity</param>
        /// <param name="newValue">class CombatProxyAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCombatProxyAgent")]
        ///  extern void REPLACE_COMBAT_PROXY_AGENT (nint newSourceEntity, nint newValue);


        /// <summary>
        ///   System.Void replaceComponent(System.Int32 index, Entitas.IComponent replacement)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="replacement">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("replaceComponent")]
        ///  extern void REPLACE_COMPONENT (System.Int32 index, nint replacement);


        /// <summary>
        ///   System.Void ReplaceComponent(System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceComponent")]
        ///  extern void REPLACE_COMPONENT (System.Int32 index, nint component);


        /// <summary>
        ///   System.Void ReplaceCurrentChargerAttackEntities(System.Collections.Generic.Dictionary<GameEntity,System.Single> newDictionary)
        /// </summary>
        /// <param name="newDictionary">class System.Collections.Generic.Dictionary<GameEntity,System.Single></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCurrentChargerAttackEntities")]
        ///  extern void REPLACE_CURRENT_CHARGER_ATTACK_ENTITIES (nint newDictionary);


        /// <summary>
        ///   System.Void ReplaceCurrentProjectileHitEntities(System.Collections.Generic.List<GameEntity> newList, System.Collections.Generic.List<System.Single> newTickTime)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newTickTime">class System.Collections.Generic.List<System.Single></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCurrentProjectileHitEntities")]
        ///  extern void REPLACE_CURRENT_PROJECTILE_HIT_ENTITIES (nint newList, nint newTickTime);


        /// <summary>
        ///   System.Void ReplaceCurrentSensorRadius(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCurrentSensorRadius")]
        ///  extern void REPLACE_CURRENT_SENSOR_RADIUS (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceCutsceneOwner(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCutsceneOwner")]
        ///  extern void REPLACE_CUTSCENE_OWNER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceDashAttackCounter(System.Int32 newDoAttackHitCounter)
        /// </summary>
        /// <param name="newDoAttackHitCounter">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDashAttackCounter")]
        ///  extern void REPLACE_DASH_ATTACK_COUNTER (System.Int32 newDoAttackHitCounter);


        /// <summary>
        ///   System.Void ReplaceDestinationRelay(Sigtrap.Relays.Relay newReachedDestinationEvents)
        /// </summary>
        /// <param name="newReachedDestinationEvents">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDestinationRelay")]
        ///  extern void REPLACE_DESTINATION_RELAY (nint newReachedDestinationEvents);


        /// <summary>
        ///   System.Void ReplaceDestructibleFX(DestructibleEffectConfig newConfig)
        /// </summary>
        /// <param name="newConfig">class DestructibleEffectConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDestructibleFX")]
        ///  extern void REPLACE_DESTRUCTIBLE_FX (nint newConfig);


        /// <summary>
        ///   System.Void ReplaceDialogueSpeaker(IDialogueSpeaker newOwner, UIPanelBase newSpeechPanel)
        /// </summary>
        /// <param name="newOwner">interface IDialogueSpeaker</param>
        /// <param name="newSpeechPanel">abstract class UIPanelBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDialogueSpeaker")]
        ///  extern void REPLACE_DIALOGUE_SPEAKER (nint newOwner, nint newSpeechPanel);


        /// <summary>
        ///   System.Void ReplaceDirection(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDirection")]
        ///  extern void REPLACE_DIRECTION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void ReplaceDockRepair(DockRepair newValue)
        /// </summary>
        /// <param name="newValue">class DockRepair</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDockRepair")]
        ///  extern void REPLACE_DOCK_REPAIR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceDockRepairBeacon(GameEntity newOwner, ReviveBeaconBehaviour newValue)
        /// </summary>
        /// <param name="newOwner">class GameEntity</param>
        /// <param name="newValue">class ReviveBeaconBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDockRepairBeacon")]
        ///  extern void REPLACE_DOCK_REPAIR_BEACON (nint newOwner, nint newValue);


        /// <summary>
        ///   System.Void ReplaceDockRepairOccupantsUpdatedEvent(GameEntity newDockRepair)
        /// </summary>
        /// <param name="newDockRepair">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDockRepairOccupantsUpdatedEvent")]
        ///  extern void REPLACE_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT (nint newDockRepair);


        /// <summary>
        ///   System.Void ReplaceEnemyShipBehaviour(EnemyShipBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class EnemyShipBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEnemyShipBehaviour")]
        ///  extern void REPLACE_ENEMY_SHIP_BEHAVIOUR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceEquipItemCommand(System.Int32 newPlayerID, Equipment newTargetEquipment)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newTargetEquipment">class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquipItemCommand")]
        ///  extern void REPLACE_EQUIP_ITEM_COMMAND (System.Int32 newPlayerID, nint newTargetEquipment);


        /// <summary>
        ///   System.Void ReplaceEquipment(Equipment newValue)
        /// </summary>
        /// <param name="newValue">class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquipment")]
        ///  extern void REPLACE_EQUIPMENT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceEquipmentChangedEvent(GameEntity newOwner, Equipment newEquippedEquipment, Equipment newUnequippedEquipment)
        /// </summary>
        /// <param name="newOwner">class GameEntity</param>
        /// <param name="newEquippedEquipment">class Equipment</param>
        /// <param name="newUnequippedEquipment">class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquipmentChangedEvent")]
        ///  extern void REPLACE_EQUIPMENT_CHANGED_EVENT (nint newOwner, nint newEquippedEquipment, nint newUnequippedEquipment);


        /// <summary>
        ///   System.Void ReplaceEquipmentEffects(EquipmentEffects newValue)
        /// </summary>
        /// <param name="newValue">class EquipmentEffects</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquipmentEffects")]
        ///  extern void REPLACE_EQUIPMENT_EFFECTS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceEquipmentItemData(ProjectStar.Data.EquipmentItemData newValue)
        /// </summary>
        /// <param name="newValue">class ProjectStar.Data.EquipmentItemData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquipmentItemData")]
        ///  extern void REPLACE_EQUIPMENT_ITEM_DATA (nint newValue);


        /// <summary>
        ///   System.Void ReplaceEquippedItems(EquippedItems newValue)
        /// </summary>
        /// <param name="newValue">class EquippedItems</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquippedItems")]
        ///  extern void REPLACE_EQUIPPED_ITEMS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceEquippedPlayerShipSpells(EquippedSpells newValue)
        /// </summary>
        /// <param name="newValue">class EquippedSpells</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquippedPlayerShipSpells")]
        ///  extern void REPLACE_EQUIPPED_PLAYER_SHIP_SPELLS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceEquippedShipBlueprints(ShipBlueprintCollection newValue)
        /// </summary>
        /// <param name="newValue">class ShipBlueprintCollection</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquippedShipBlueprints")]
        ///  extern void REPLACE_EQUIPPED_SHIP_BLUEPRINTS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceEquippedSpells(GameEntity newOwner, EquippedSpells newValue)
        /// </summary>
        /// <param name="newOwner">class GameEntity</param>
        /// <param name="newValue">class EquippedSpells</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquippedSpells")]
        ///  extern void REPLACE_EQUIPPED_SPELLS (nint newOwner, nint newValue);


        /// <summary>
        ///   System.Void ReplaceFacing(UnityEngine.Vector3 newValue, System.Boolean newWasFacingRight, System.Boolean newWasFacingBack)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <param name="newWasFacingRight">struct System.Boolean</param>
        /// <param name="newWasFacingBack">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFacing")]
        ///  extern void REPLACE_FACING (UnityEngine.Vector3 newValue, System.Boolean newWasFacingRight, System.Boolean newWasFacingBack);


        /// <summary>
        ///   System.Void ReplaceFadeDuration(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFadeDuration")]
        ///  extern void REPLACE_FADE_DURATION (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceFiringPoint(FiringPoint newValue)
        /// </summary>
        /// <param name="newValue">class FiringPoint</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFiringPoint")]
        ///  extern void REPLACE_FIRING_POINT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceFloatTransitionEvent(FloatTransitionType newTransitionType)
        /// </summary>
        /// <param name="newTransitionType">enum FloatTransitionType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFloatTransitionEvent")]
        ///  extern void REPLACE_FLOAT_TRANSITION_EVENT (FloatTransitionType newTransitionType);


        /// <summary>
        ///   System.Void ReplaceFoam(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFoam")]
        ///  extern void REPLACE_FOAM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceGameDestroyedListener(System.Collections.Generic.List<IGameDestroyedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IGameDestroyedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameDestroyedListener")]
        ///  extern void REPLACE_GAME_DESTROYED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceGameDifficulty(SaveGameDifficulty newValue)
        /// </summary>
        /// <param name="newValue">enum SaveGameDifficulty</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameDifficulty")]
        ///  extern void REPLACE_GAME_DIFFICULTY (SaveGameDifficulty newValue);


        /// <summary>
        ///   System.Void ReplaceGameDifficultyDamageModifier(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameDifficultyDamageModifier")]
        ///  extern void REPLACE_GAME_DIFFICULTY_DAMAGE_MODIFIER (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceGameDifficultyHeathModifier(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameDifficultyHeathModifier")]
        ///  extern void REPLACE_GAME_DIFFICULTY_HEATH_MODIFIER (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceGameEntityId(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameEntityId")]
        ///  extern void REPLACE_GAME_ENTITY_ID (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceGameOverEvent(System.Single newElapsed)
        /// </summary>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameOverEvent")]
        ///  extern void REPLACE_GAME_OVER_EVENT (System.Single newElapsed);


        /// <summary>
        ///   System.Void ReplaceGameOverNoSaveOverride(PortalID newTargetPortal, GameOverOverrideFlags newGameOverOverrideFlags)
        /// </summary>
        /// <param name="newTargetPortal">class PortalID</param>
        /// <param name="newGameOverOverrideFlags">enum GameOverOverrideFlags</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameOverNoSaveOverride")]
        ///  extern void REPLACE_GAME_OVER_NO_SAVE_OVERRIDE (nint newTargetPortal, GameOverOverrideFlags newGameOverOverrideFlags);


        /// <summary>
        ///   System.Void ReplaceGraphicObjContainer(UnityEngine.GameObject newGraphic)
        /// </summary>
        /// <param name="newGraphic">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGraphicObjContainer")]
        ///  extern void REPLACE_GRAPHIC_OBJ_CONTAINER (nint newGraphic);


        /// <summary>
        ///   System.Void ReplaceGunAmmo(ValueGauge newValue, System.Int32 newSpecialAmmoCount)
        /// </summary>
        /// <param name="newValue">class ValueGauge</param>
        /// <param name="newSpecialAmmoCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGunAmmo")]
        ///  extern void REPLACE_GUN_AMMO (nint newValue, System.Int32 newSpecialAmmoCount);


        /// <summary>
        ///   System.Void ReplaceGunReload(System.Single newBulletReloadDuration, System.Single newClipReloadDuration, System.Single newStartDelayDuration)
        /// </summary>
        /// <param name="newBulletReloadDuration">struct System.Single</param>
        /// <param name="newClipReloadDuration">struct System.Single</param>
        /// <param name="newStartDelayDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGunReload")]
        ///  extern void REPLACE_GUN_RELOAD (System.Single newBulletReloadDuration, System.Single newClipReloadDuration, System.Single newStartDelayDuration);


        /// <summary>
        ///   System.Void ReplaceGunReloadProgress(System.Single newProgress)
        /// </summary>
        /// <param name="newProgress">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGunReloadProgress")]
        ///  extern void REPLACE_GUN_RELOAD_PROGRESS (System.Single newProgress);


        /// <summary>
        ///   System.Void ReplaceGunReloadProgressListener(System.Collections.Generic.List<IGunReloadProgressListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IGunReloadProgressListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGunReloadProgressListener")]
        ///  extern void REPLACE_GUN_RELOAD_PROGRESS_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceGunReloadTimer(System.Single newTimeElapsed, System.Single newStartDelay, System.Single newTimeDestination, GunReloadStatus newReloadStatus, System.Action newCallback, System.Single newPauseDuration, System.Int32 newCurrReloadingGunMaxAmmo)
        /// </summary>
        /// <param name="newTimeElapsed">struct System.Single</param>
        /// <param name="newStartDelay">struct System.Single</param>
        /// <param name="newTimeDestination">struct System.Single</param>
        /// <param name="newReloadStatus">enum GunReloadStatus</param>
        /// <param name="newCallback">class System.Action</param>
        /// <param name="newPauseDuration">struct System.Single</param>
        /// <param name="newCurrReloadingGunMaxAmmo">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGunReloadTimer")]
        ///  extern void REPLACE_GUN_RELOAD_TIMER (System.Single newTimeElapsed, System.Single newStartDelay, System.Single newTimeDestination, GunReloadStatus newReloadStatus, nint newCallback, System.Single newPauseDuration, System.Int32 newCurrReloadingGunMaxAmmo);


        /// <summary>
        ///   System.Void ReplaceHealCompletedEvent(GameEntity newHealer)
        /// </summary>
        /// <param name="newHealer">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHealCompletedEvent")]
        ///  extern void REPLACE_HEAL_COMPLETED_EVENT (nint newHealer);


        /// <summary>
        ///   System.Void ReplaceHealer(System.Single newHealFactor, System.Int32 newHealFixedValue, System.Single newHealInterval, System.Boolean newIsHealing)
        /// </summary>
        /// <param name="newHealFactor">struct System.Single</param>
        /// <param name="newHealFixedValue">struct System.Int32</param>
        /// <param name="newHealInterval">struct System.Single</param>
        /// <param name="newIsHealing">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHealer")]
        ///  extern void REPLACE_HEALER (System.Single newHealFactor, System.Int32 newHealFixedValue, System.Single newHealInterval, System.Boolean newIsHealing);


        /// <summary>
        ///   System.Void ReplaceHealStartedEvent(GameEntity newHealer)
        /// </summary>
        /// <param name="newHealer">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHealStartedEvent")]
        ///  extern void REPLACE_HEAL_STARTED_EVENT (nint newHealer);


        /// <summary>
        ///   System.Void ReplaceHealth(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHealth")]
        ///  extern void REPLACE_HEALTH (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceHealthRegenTickCounter(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHealthRegenTickCounter")]
        ///  extern void REPLACE_HEALTH_REGEN_TICK_COUNTER (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceHealthStat(Gentlebros.IntStat newStat)
        /// </summary>
        /// <param name="newStat">class Gentlebros.IntStat</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHealthStat")]
        ///  extern void REPLACE_HEALTH_STAT (nint newStat);


        /// <summary>
        ///   System.Void ReplaceHitStop(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHitStop")]
        ///  extern void REPLACE_HIT_STOP (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceHitStopEvent(UnityEngine.GameObject newTarget)
        /// </summary>
        /// <param name="newTarget">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHitStopEvent")]
        ///  extern void REPLACE_HIT_STOP_EVENT (nint newTarget);


        /// <summary>
        ///   System.Void ReplaceId(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceId")]
        ///  extern void REPLACE_ID (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceIFrame(System.Single newDurationRemaining)
        /// </summary>
        /// <param name="newDurationRemaining">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceIFrame")]
        ///  extern void REPLACE_I_FRAME (System.Single newDurationRemaining);


        /// <summary>
        ///   System.Void ReplaceInfinityTowerTimer(System.Single newSecondsRemaining, System.Single newSecondsTotal, System.Boolean newPaused)
        /// </summary>
        /// <param name="newSecondsRemaining">struct System.Single</param>
        /// <param name="newSecondsTotal">struct System.Single</param>
        /// <param name="newPaused">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInfinityTowerTimer")]
        ///  extern void REPLACE_INFINITY_TOWER_TIMER (System.Single newSecondsRemaining, System.Single newSecondsTotal, System.Boolean newPaused);


        /// <summary>
        ///   System.Void ReplaceInHealRegion(GameEntity newHealer)
        /// </summary>
        /// <param name="newHealer">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInHealRegion")]
        ///  extern void REPLACE_IN_HEAL_REGION (nint newHealer);


        /// <summary>
        ///   System.Void ReplaceInitialDirection(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInitialDirection")]
        ///  extern void REPLACE_INITIAL_DIRECTION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void ReplaceInitialPosition(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInitialPosition")]
        ///  extern void REPLACE_INITIAL_POSITION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void ReplaceInPotentialHealRegion(GameEntity newHealer)
        /// </summary>
        /// <param name="newHealer">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInPotentialHealRegion")]
        ///  extern void REPLACE_IN_POTENTIAL_HEAL_REGION (nint newHealer);


        /// <summary>
        ///   System.Void ReplaceInputStateCommand(InputStateCommand newValue, System.Nullable<InputState> newState)
        /// </summary>
        /// <param name="newValue">enum InputStateCommand</param>
        /// <param name="newState">struct System.Nullable<InputState></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInputStateCommand")]
        ///  extern void REPLACE_INPUT_STATE_COMMAND (InputStateCommand newValue, System.Nullable<InputState> newState);


        /// <summary>
        ///   System.Void ReplaceInstancePortal(InstancePortalBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class InstancePortalBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInstancePortal")]
        ///  extern void REPLACE_INSTANCE_PORTAL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceIntCounter(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceIntCounter")]
        ///  extern void REPLACE_INT_COUNTER (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceInteractable(System.Boolean newEnabledState, InteractableBehaviour newValue)
        /// </summary>
        /// <param name="newEnabledState">struct System.Boolean</param>
        /// <param name="newValue">abstract class InteractableBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInteractable")]
        ///  extern void REPLACE_INTERACTABLE (System.Boolean newEnabledState, nint newValue);


        /// <summary>
        ///   System.Void ReplaceInteractableFailInteractableEvent(GameEntity newInteractableEntity, BaseInteractionCondition newFailedCondition)
        /// </summary>
        /// <param name="newInteractableEntity">class GameEntity</param>
        /// <param name="newFailedCondition">abstract class BaseInteractionCondition</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInteractableFailInteractableEvent")]
        ///  extern void REPLACE_INTERACTABLE_FAIL_INTERACTABLE_EVENT (nint newInteractableEntity, nint newFailedCondition);


        /// <summary>
        ///   System.Void ReplaceInteractableFailValidateEvent(GameEntity newInteractableEntity, BaseInteractionCondition newFailedCondition)
        /// </summary>
        /// <param name="newInteractableEntity">class GameEntity</param>
        /// <param name="newFailedCondition">abstract class BaseInteractionCondition</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInteractableFailValidateEvent")]
        ///  extern void REPLACE_INTERACTABLE_FAIL_VALIDATE_EVENT (nint newInteractableEntity, nint newFailedCondition);


        /// <summary>
        ///   System.Void ReplaceInteractableStatus(System.Boolean newTriggered, System.Collections.Generic.HashSet<GameEntity> newTriggeredTargetEntities, InteractableAcceptDenyState newState, System.Boolean newSuccessfulInteraction)
        /// </summary>
        /// <param name="newTriggered">struct System.Boolean</param>
        /// <param name="newTriggeredTargetEntities">class System.Collections.Generic.HashSet<GameEntity></param>
        /// <param name="newState">enum InteractableAcceptDenyState</param>
        /// <param name="newSuccessfulInteraction">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInteractableStatus")]
        ///  extern void REPLACE_INTERACTABLE_STATUS (System.Boolean newTriggered, nint newTriggeredTargetEntities, InteractableAcceptDenyState newState, System.Boolean newSuccessfulInteraction);


        /// <summary>
        ///   System.Void ReplaceInteractableStatusUpdatedEvent(GameEntity newInteractableOwnerEntity, InteractableAcceptDenyState newPrevState, InteractableAcceptDenyState newCurrState)
        /// </summary>
        /// <param name="newInteractableOwnerEntity">class GameEntity</param>
        /// <param name="newPrevState">enum InteractableAcceptDenyState</param>
        /// <param name="newCurrState">enum InteractableAcceptDenyState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInteractableStatusUpdatedEvent")]
        ///  extern void REPLACE_INTERACTABLE_STATUS_UPDATED_EVENT (nint newInteractableOwnerEntity, InteractableAcceptDenyState newPrevState, InteractableAcceptDenyState newCurrState);


        /// <summary>
        ///   System.Void ReplaceInteractableTriggeredTargetEntitiesUpdatedEvent(GameEntity newInteractableEntity, GameEntity newInteractorEntity)
        /// </summary>
        /// <param name="newInteractableEntity">class GameEntity</param>
        /// <param name="newInteractorEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInteractableTriggeredTargetEntitiesUpdatedEvent")]
        ///  extern void REPLACE_INTERACTABLE_TRIGGERED_TARGET_ENTITIES_UPDATED_EVENT (nint newInteractableEntity, nint newInteractorEntity);


        /// <summary>
        ///   System.Void ReplaceInteractCommand(System.Single newLifetime, System.Boolean newProcessed, PressMode newPressMode, System.Int32 newInputActionID)
        /// </summary>
        /// <param name="newLifetime">struct System.Single</param>
        /// <param name="newProcessed">struct System.Boolean</param>
        /// <param name="newPressMode">enum PressMode</param>
        /// <param name="newInputActionID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInteractCommand")]
        ///  extern void REPLACE_INTERACT_COMMAND (System.Single newLifetime, System.Boolean newProcessed, PressMode newPressMode, System.Int32 newInputActionID);


        /// <summary>
        ///   System.Void ReplaceInteractCommandUpdate(System.Int32 newPlayerID, System.Single newCompletionParam, System.Single newTimeHeld, System.Boolean newIsValid)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newCompletionParam">struct System.Single</param>
        /// <param name="newTimeHeld">struct System.Single</param>
        /// <param name="newIsValid">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInteractCommandUpdate")]
        ///  extern void REPLACE_INTERACT_COMMAND_UPDATE (System.Int32 newPlayerID, System.Single newCompletionParam, System.Single newTimeHeld, System.Boolean newIsValid);


        /// <summary>
        ///   System.Void ReplaceInteractLookAt(UnityEngine.Transform newLookAtTarget, UnityEngine.Transform newSecondaryLookAtTarget, System.Single newViewAngle, System.Collections.Generic.List<UnityEngine.Transform> newPotentialTargets)
        /// </summary>
        /// <param name="newLookAtTarget">class UnityEngine.Transform</param>
        /// <param name="newSecondaryLookAtTarget">class UnityEngine.Transform</param>
        /// <param name="newViewAngle">struct System.Single</param>
        /// <param name="newPotentialTargets">class System.Collections.Generic.List<UnityEngine.Transform></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInteractLookAt")]
        ///  extern void REPLACE_INTERACT_LOOK_AT (nint newLookAtTarget, nint newSecondaryLookAtTarget, System.Single newViewAngle, nint newPotentialTargets);


        /// <summary>
        ///   System.Void ReplaceInventoryCommand(InventoryCommand newValue)
        /// </summary>
        /// <param name="newValue">enum InventoryCommand</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInventoryCommand")]
        ///  extern void REPLACE_INVENTORY_COMMAND (InventoryCommand newValue);


        /// <summary>
        ///   System.Void ReplaceInventoryLevel(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInventoryLevel")]
        ///  extern void REPLACE_INVENTORY_LEVEL (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceInventorySpellInfo(SpellConfigBase newSpellConfig)
        /// </summary>
        /// <param name="newSpellConfig">abstract class SpellConfigBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInventorySpellInfo")]
        ///  extern void REPLACE_INVENTORY_SPELL_INFO (nint newSpellConfig);


        /// <summary>
        ///   System.Void ReplaceInvisibleWall(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInvisibleWall")]
        ///  extern void REPLACE_INVISIBLE_WALL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceinWall(UnityEngine.Transform[] newTransform)
        /// </summary>
        /// <param name="newTransform">class UnityEngine.Transform[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceinWall")]
        ///  extern void REPLACEIN_WALL (nint newTransform);


        /// <summary>
        ///   System.Void ReplaceKilledListener(System.Collections.Generic.List<IKilledListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IKilledListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceKilledListener")]
        ///  extern void REPLACE_KILLED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceKnockbackMultiplier(System.Single newMultiplier)
        /// </summary>
        /// <param name="newMultiplier">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceKnockbackMultiplier")]
        ///  extern void REPLACE_KNOCKBACK_MULTIPLIER (System.Single newMultiplier);


        /// <summary>
        ///   System.Void ReplaceLastSeenDuration(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLastSeenDuration")]
        ///  extern void REPLACE_LAST_SEEN_DURATION (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceLatestInfinityTowerClearedWave(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLatestInfinityTowerClearedWave")]
        ///  extern void REPLACE_LATEST_INFINITY_TOWER_CLEARED_WAVE (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceLifetime(System.Single newValue, System.Single newElapsed)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLifetime")]
        ///  extern void REPLACE_LIFETIME (System.Single newValue, System.Single newElapsed);


        /// <summary>
        ///   System.Void ReplaceLifetimeTarget(UnityEngine.GameObject newValue, System.Single newFlickerElapsed, System.Single newFlickerInterval)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <param name="newFlickerElapsed">struct System.Single</param>
        /// <param name="newFlickerInterval">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLifetimeTarget")]
        ///  extern void REPLACE_LIFETIME_TARGET (nint newValue, System.Single newFlickerElapsed, System.Single newFlickerInterval);


        /// <summary>
        ///   System.Void ReplaceLocationData(UnityEngine.Vector3 newLocation, LocationData newLocationData)
        /// </summary>
        /// <param name="newLocation">struct UnityEngine.Vector3</param>
        /// <param name="newLocationData">class LocationData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLocationData")]
        ///  extern void REPLACE_LOCATION_DATA (UnityEngine.Vector3 newLocation, nint newLocationData);


        /// <summary>
        ///   System.Void ReplaceLootDropLevel(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLootDropLevel")]
        ///  extern void REPLACE_LOOT_DROP_LEVEL (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceLootMagnet(UnityEngine.Collider newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Collider</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLootMagnet")]
        ///  extern void REPLACE_LOOT_MAGNET (nint newValue);


        /// <summary>
        ///   System.Void ReplaceLootMultiplier(System.Int32 newQuantityMultiplier, System.Single newValueMultiplier)
        /// </summary>
        /// <param name="newQuantityMultiplier">struct System.Int32</param>
        /// <param name="newValueMultiplier">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLootMultiplier")]
        ///  extern void REPLACE_LOOT_MULTIPLIER (System.Int32 newQuantityMultiplier, System.Single newValueMultiplier);


        /// <summary>
        ///   System.Void ReplaceLootTable(LootTable newValue)
        /// </summary>
        /// <param name="newValue">class LootTable</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLootTable")]
        ///  extern void REPLACE_LOOT_TABLE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceLootTimer(System.Int32 newCurrIndex, System.Single newElapsed, System.Single newGoal)
        /// </summary>
        /// <param name="newCurrIndex">struct System.Int32</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <param name="newGoal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLootTimer")]
        ///  extern void REPLACE_LOOT_TIMER (System.Int32 newCurrIndex, System.Single newElapsed, System.Single newGoal);


        /// <summary>
        ///   System.Void ReplaceMagicStat(Gentlebros.IntStat newStat)
        /// </summary>
        /// <param name="newStat">class Gentlebros.IntStat</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMagicStat")]
        ///  extern void REPLACE_MAGIC_STAT (nint newStat);


        /// <summary>
        ///   System.Void ReplaceMainSprite(UnityEngine.GameObject newMain, UnityEngine.GameObject newMain_Back)
        /// </summary>
        /// <param name="newMain">class UnityEngine.GameObject</param>
        /// <param name="newMain_Back">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMainSprite")]
        ///  extern void REPLACE_MAIN_SPRITE (nint newMain, nint newMain_Back);


        /// <summary>
        ///   System.Void ReplaceMana(ValueGauge newValue)
        /// </summary>
        /// <param name="newValue">class ValueGauge</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMana")]
        ///  extern void REPLACE_MANA (nint newValue);


        /// <summary>
        ///   System.Void ReplaceManaBar(ManaBarBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class ManaBarBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceManaBar")]
        ///  extern void REPLACE_MANA_BAR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMapIconDisplayLink(MapIconType newDisplayType, GameEntity newOwner)
        /// </summary>
        /// <param name="newDisplayType">enum MapIconType</param>
        /// <param name="newOwner">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapIconDisplayLink")]
        ///  extern void REPLACE_MAP_ICON_DISPLAY_LINK (MapIconType newDisplayType, nint newOwner);


        /// <summary>
        ///   System.Void ReplaceMapMarkerWorld(MapMarkerWorldBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class MapMarkerWorldBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapMarkerWorld")]
        ///  extern void REPLACE_MAP_MARKER_WORLD (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMapMarkerWorldIndex(System.Int32 newIndex)
        /// </summary>
        /// <param name="newIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapMarkerWorldIndex")]
        ///  extern void REPLACE_MAP_MARKER_WORLD_INDEX (System.Int32 newIndex);


        /// <summary>
        ///   System.Void ReplaceMaxMoveSpeed(System.Single newCurrent, System.Single newActual, System.Single newOriginal)
        /// </summary>
        /// <param name="newCurrent">struct System.Single</param>
        /// <param name="newActual">struct System.Single</param>
        /// <param name="newOriginal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMaxMoveSpeed")]
        ///  extern void REPLACE_MAX_MOVE_SPEED (System.Single newCurrent, System.Single newActual, System.Single newOriginal);


        /// <summary>
        ///   System.Void ReplaceMeleeAttackCommand(UnitMainAttackConfig newConfig)
        /// </summary>
        /// <param name="newConfig">class UnitMainAttackConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMeleeAttackCommand")]
        ///  extern void REPLACE_MELEE_ATTACK_COMMAND (nint newConfig);


        /// <summary>
        ///   System.Void ReplaceMonsterBehaviour(MonsterBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class MonsterBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMonsterBehaviour")]
        ///  extern void REPLACE_MONSTER_BEHAVIOUR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMonsterDetector(MonsterDetectorBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class MonsterDetectorBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMonsterDetector")]
        ///  extern void REPLACE_MONSTER_DETECTOR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMonsterDetectorInfo(UnitConfig newTargetUnit, System.Int32 newRequiredCount, System.Single newDetectionRadius, System.Single newDetectionDuration)
        /// </summary>
        /// <param name="newTargetUnit">class UnitConfig</param>
        /// <param name="newRequiredCount">struct System.Int32</param>
        /// <param name="newDetectionRadius">struct System.Single</param>
        /// <param name="newDetectionDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMonsterDetectorInfo")]
        ///  extern void REPLACE_MONSTER_DETECTOR_INFO (nint newTargetUnit, System.Int32 newRequiredCount, System.Single newDetectionRadius, System.Single newDetectionDuration);


        /// <summary>
        ///   System.Void ReplaceMonsterDetectorRequestor(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMonsterDetectorRequestor")]
        ///  extern void REPLACE_MONSTER_DETECTOR_REQUESTOR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMonsterDetectorResultInfo(System.Collections.Generic.HashSet<GameEntity> newPrevDetectedMonsters, System.Collections.Generic.HashSet<GameEntity> newDetectedMonsters)
        /// </summary>
        /// <param name="newPrevDetectedMonsters">class System.Collections.Generic.HashSet<GameEntity></param>
        /// <param name="newDetectedMonsters">class System.Collections.Generic.HashSet<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMonsterDetectorResultInfo")]
        ///  extern void REPLACE_MONSTER_DETECTOR_RESULT_INFO (nint newPrevDetectedMonsters, nint newDetectedMonsters);


        /// <summary>
        ///   System.Void ReplaceMonsterTrait(MonsterTraitsTypes newTraits)
        /// </summary>
        /// <param name="newTraits">enum MonsterTraitsTypes</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMonsterTrait")]
        ///  extern void REPLACE_MONSTER_TRAIT (MonsterTraitsTypes newTraits);


        /// <summary>
        ///   System.Void ReplaceMoveSpeed(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMoveSpeed")]
        ///  extern void REPLACE_MOVE_SPEED (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceNavAgentTarget(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceNavAgentTarget")]
        ///  extern void REPLACE_NAV_AGENT_TARGET (nint newValue);


        /// <summary>
        ///   System.Void ReplaceNavMeshAgent(UnityEngine.AI.NavMeshAgent newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.AI.NavMeshAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceNavMeshAgent")]
        ///  extern void REPLACE_NAV_MESH_AGENT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceNavPath(UnityEngine.AI.NavMeshPath newPath, System.Int32 newCurrPoint)
        /// </summary>
        /// <param name="newPath">class UnityEngine.AI.NavMeshPath</param>
        /// <param name="newCurrPoint">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceNavPath")]
        ///  extern void REPLACE_NAV_PATH (nint newPath, System.Int32 newCurrPoint);


        /// <summary>
        ///   System.Void ReplaceNotEnoughGunAmmoEventListener(System.Collections.Generic.List<INotEnoughGunAmmoEventListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<INotEnoughGunAmmoEventListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceNotEnoughGunAmmoEventListener")]
        ///  extern void REPLACE_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceObjectiveInteractor(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceObjectiveInteractor")]
        ///  extern void REPLACE_OBJECTIVE_INTERACTOR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceOnDeathAnimCompleteEvent(Sigtrap.Relays.Relay newValue)
        /// </summary>
        /// <param name="newValue">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOnDeathAnimCompleteEvent")]
        ///  extern void REPLACE_ON_DEATH_ANIM_COMPLETE_EVENT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceOnDeathEvent(Sigtrap.Relays.Relay newValue)
        /// </summary>
        /// <param name="newValue">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOnDeathEvent")]
        ///  extern void REPLACE_ON_DEATH_EVENT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceOnHitIFrameData(System.Single newIFrameDuration)
        /// </summary>
        /// <param name="newIFrameDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOnHitIFrameData")]
        ///  extern void REPLACE_ON_HIT_I_FRAME_DATA (System.Single newIFrameDuration);


        /// <summary>
        ///   System.Void ReplaceOnReviveCallback(Sigtrap.Relays.Relay newValue)
        /// </summary>
        /// <param name="newValue">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOnReviveCallback")]
        ///  extern void REPLACE_ON_REVIVE_CALLBACK (nint newValue);


        /// <summary>
        ///   System.Void ReplaceOriginalLocalScale(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOriginalLocalScale")]
        ///  extern void REPLACE_ORIGINAL_LOCAL_SCALE (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void ReplaceOverlapList(System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOverlapList")]
        ///  extern void REPLACE_OVERLAP_LIST (nint newList);


        /// <summary>
        ///   System.Void ReplaceOverrideCharacterGender(System.Int32 newPlayerId, CharacterGender newValue)
        /// </summary>
        /// <param name="newPlayerId">struct System.Int32</param>
        /// <param name="newValue">enum CharacterGender</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOverrideCharacterGender")]
        ///  extern void REPLACE_OVERRIDE_CHARACTER_GENDER (System.Int32 newPlayerId, CharacterGender newValue);


        /// <summary>
        ///   System.Void ReplaceOwner(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOwner")]
        ///  extern void REPLACE_OWNER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceParticleEffect(UnityEngine.ParticleSystem newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.ParticleSystem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceParticleEffect")]
        ///  extern void REPLACE_PARTICLE_EFFECT (nint newValue);


        /// <summary>
        ///   System.Void ReplacePlayerAddedEvent(GameEntity newPlayerAddedEntity)
        /// </summary>
        /// <param name="newPlayerAddedEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerAddedEvent")]
        ///  extern void REPLACE_PLAYER_ADDED_EVENT (nint newPlayerAddedEntity);


        /// <summary>
        ///   System.Void ReplacePlayerId(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerId")]
        ///  extern void REPLACE_PLAYER_ID (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplacePlayerIdListener(System.Collections.Generic.List<IPlayerIdListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPlayerIdListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerIdListener")]
        ///  extern void REPLACE_PLAYER_ID_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplacePlayerIdReference(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerIdReference")]
        ///  extern void REPLACE_PLAYER_ID_REFERENCE (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplacePlayerIdRemovedListener(System.Collections.Generic.List<IPlayerIdRemovedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPlayerIdRemovedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerIdRemovedListener")]
        ///  extern void REPLACE_PLAYER_ID_REMOVED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplacePlayerKilledSource(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerKilledSource")]
        ///  extern void REPLACE_PLAYER_KILLED_SOURCE (nint newValue);


        /// <summary>
        ///   System.Void ReplacePlayerReference(System.Collections.Generic.List<GameEntity> newPlayers)
        /// </summary>
        /// <param name="newPlayers">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerReference")]
        ///  extern void REPLACE_PLAYER_REFERENCE (nint newPlayers);


        /// <summary>
        ///   System.Void ReplacePlayerRemovedEvent(GameEntity newPlayerRemovedEntity)
        /// </summary>
        /// <param name="newPlayerRemovedEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerRemovedEvent")]
        ///  extern void REPLACE_PLAYER_REMOVED_EVENT (nint newPlayerRemovedEntity);


        /// <summary>
        ///   System.Void ReplacePlayerSleepingSaveStone(GameEntity newPlayer)
        /// </summary>
        /// <param name="newPlayer">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerSleepingSaveStone")]
        ///  extern void REPLACE_PLAYER_SLEEPING_SAVE_STONE (nint newPlayer);


        /// <summary>
        ///   System.Void ReplacePlayerStat(System.Int32 newLevel, System.Int32 newTrinketSlots)
        /// </summary>
        /// <param name="newLevel">struct System.Int32</param>
        /// <param name="newTrinketSlots">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerStat")]
        ///  extern void REPLACE_PLAYER_STAT (System.Int32 newLevel, System.Int32 newTrinketSlots);


        /// <summary>
        ///   System.Void ReplacePlayerVicinity(System.Int32 newPlayerID, GameEntity newValue)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerVicinity")]
        ///  extern void REPLACE_PLAYER_VICINITY (System.Int32 newPlayerID, nint newValue);


        /// <summary>
        ///   System.Void ReplacePoolStatusTable(System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePoolStatusTable")]
        ///  extern void REPLACE_POOL_STATUS_TABLE (nint newValue);


        /// <summary>
        ///   System.Void ReplacePosition(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePosition")]
        ///  extern void REPLACE_POSITION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void ReplacePositionAttach(UnityEngine.Transform newTarget, UnityEngine.Vector3 newOffset)
        /// </summary>
        /// <param name="newTarget">class UnityEngine.Transform</param>
        /// <param name="newOffset">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePositionAttach")]
        ///  extern void REPLACE_POSITION_ATTACH (nint newTarget, UnityEngine.Vector3 newOffset);


        /// <summary>
        ///   System.Void ReplacePositionHistory(System.Collections.Generic.List<UnityEngine.Vector3> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePositionHistory")]
        ///  extern void REPLACE_POSITION_HISTORY (nint newValue);


        /// <summary>
        ///   System.Void ReplacePositionTween(UnityEngine.Vector3 newFrom, UnityEngine.Vector3 newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed, System.Single newDelay, System.Boolean newIsPaused, System.Action newCompleteCallback)
        /// </summary>
        /// <param name="newFrom">struct UnityEngine.Vector3</param>
        /// <param name="newTo">struct UnityEngine.Vector3</param>
        /// <param name="newDuration">struct System.Single</param>
        /// <param name="newEase">enum EasingFunction.Ease</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <param name="newDelay">struct System.Single</param>
        /// <param name="newIsPaused">struct System.Boolean</param>
        /// <param name="newCompleteCallback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePositionTween")]
        ///  extern void REPLACE_POSITION_TWEEN (UnityEngine.Vector3 newFrom, UnityEngine.Vector3 newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed, System.Single newDelay, System.Boolean newIsPaused, nint newCompleteCallback);


        /// <summary>
        ///   System.Void ReplaceProjectileBehaviour(ProjectileBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class ProjectileBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceProjectileBehaviour")]
        ///  extern void REPLACE_PROJECTILE_BEHAVIOUR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceProjectileColliderInfo(UnityEngine.SphereCollider newColl, UnityEngine.SphereCollider newObstacleColl)
        /// </summary>
        /// <param name="newColl">class UnityEngine.SphereCollider</param>
        /// <param name="newObstacleColl">class UnityEngine.SphereCollider</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceProjectileColliderInfo")]
        ///  extern void REPLACE_PROJECTILE_COLLIDER_INFO (nint newColl, nint newObstacleColl);


        /// <summary>
        ///   System.Void ReplaceProjectileInfo(ProjectileInfo newValue)
        /// </summary>
        /// <param name="newValue">class ProjectileInfo</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceProjectileInfo")]
        ///  extern void REPLACE_PROJECTILE_INFO (nint newValue);


        /// <summary>
        ///   System.Void ReplaceProjectileMovement(System.Single newSpeed, UnityEngine.Vector3 newDirection, ProjectileMovementType newMovementType, UnityEngine.AnimationCurve newSpeedGraph)
        /// </summary>
        /// <param name="newSpeed">struct System.Single</param>
        /// <param name="newDirection">struct UnityEngine.Vector3</param>
        /// <param name="newMovementType">enum ProjectileMovementType</param>
        /// <param name="newSpeedGraph">class UnityEngine.AnimationCurve</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceProjectileMovement")]
        ///  extern void REPLACE_PROJECTILE_MOVEMENT (System.Single newSpeed, UnityEngine.Vector3 newDirection, ProjectileMovementType newMovementType, nint newSpeedGraph);


        /// <summary>
        ///   System.Void ReplaceProjectileReference(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceProjectileReference")]
        ///  extern void REPLACE_PROJECTILE_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceProjectileVfxReference(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceProjectileVfxReference")]
        ///  extern void REPLACE_PROJECTILE_VFX_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void ReplacePromptRemovePlayerEvent(System.Int32 newInitiatorPlayerID)
        /// </summary>
        /// <param name="newInitiatorPlayerID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePromptRemovePlayerEvent")]
        ///  extern void REPLACE_PROMPT_REMOVE_PLAYER_EVENT (System.Int32 newInitiatorPlayerID);


        /// <summary>
        ///   System.Void ReplacePuzzleAnswer(PuzzleAnswerData newPuzzleAnswerData, System.Collections.Generic.List<PuzzlePieceID> newLiveAnswers, GameEntity newInitialActivatedPuzzlePiece)
        /// </summary>
        /// <param name="newPuzzleAnswerData">class PuzzleAnswerData</param>
        /// <param name="newLiveAnswers">class System.Collections.Generic.List<PuzzlePieceID></param>
        /// <param name="newInitialActivatedPuzzlePiece">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePuzzleAnswer")]
        ///  extern void REPLACE_PUZZLE_ANSWER (nint newPuzzleAnswerData, nint newLiveAnswers, nint newInitialActivatedPuzzlePiece);


        /// <summary>
        ///   System.Void ReplacePuzzleAnswerCompletedEvent(GameEntity newPuzzleAnswerEntity)
        /// </summary>
        /// <param name="newPuzzleAnswerEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePuzzleAnswerCompletedEvent")]
        ///  extern void REPLACE_PUZZLE_ANSWER_COMPLETED_EVENT (nint newPuzzleAnswerEntity);


        /// <summary>
        ///   System.Void ReplacePuzzleAnswerState(PuzzleAnswerState newValue)
        /// </summary>
        /// <param name="newValue">enum PuzzleAnswerState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePuzzleAnswerState")]
        ///  extern void REPLACE_PUZZLE_ANSWER_STATE (PuzzleAnswerState newValue);


        /// <summary>
        ///   System.Void ReplacePuzzleLootLocation(PuzzleLootLocation newValue, PuzzleAnswerData newAnswerData)
        /// </summary>
        /// <param name="newValue">class PuzzleLootLocation</param>
        /// <param name="newAnswerData">class PuzzleAnswerData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePuzzleLootLocation")]
        ///  extern void REPLACE_PUZZLE_LOOT_LOCATION (nint newValue, nint newAnswerData);


        /// <summary>
        ///   System.Void ReplacePuzzlePieceID(PuzzlePieceID newValue)
        /// </summary>
        /// <param name="newValue">class PuzzlePieceID</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePuzzlePieceID")]
        ///  extern void REPLACE_PUZZLE_PIECE_ID (nint newValue);


        /// <summary>
        ///   System.Void ReplacePuzzlePieceInteractedCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePuzzlePieceInteractedCount")]
        ///  extern void REPLACE_PUZZLE_PIECE_INTERACTED_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplacePuzzlePieceInteractedEvent(GameEntity newPuzzlePieceEntity)
        /// </summary>
        /// <param name="newPuzzlePieceEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePuzzlePieceInteractedEvent")]
        ///  extern void REPLACE_PUZZLE_PIECE_INTERACTED_EVENT (nint newPuzzlePieceEntity);


        /// <summary>
        ///   System.Void ReplaceQuestFsm(PlayMakerFSM newValue)
        /// </summary>
        /// <param name="newValue">class PlayMakerFSM</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceQuestFsm")]
        ///  extern void REPLACE_QUEST_FSM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceRecovery(Gentlebros.FloatStat newStat, System.Single newElapsed, Gentlebros.FloatStat newAggroDelay, Gentlebros.FloatStat newRecoveryAmt)
        /// </summary>
        /// <param name="newStat">class Gentlebros.FloatStat</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <param name="newAggroDelay">class Gentlebros.FloatStat</param>
        /// <param name="newRecoveryAmt">class Gentlebros.FloatStat</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRecovery")]
        ///  extern void REPLACE_RECOVERY (nint newStat, System.Single newElapsed, nint newAggroDelay, nint newRecoveryAmt);


        /// <summary>
        ///   System.Void ReplaceRendererTinter(RendererTinterBase newValue)
        /// </summary>
        /// <param name="newValue">abstract class RendererTinterBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRendererTinter")]
        ///  extern void REPLACE_RENDERER_TINTER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceRenderTransform(UnityEngine.Transform newValue, UnityEngine.Vector3 newOriginalScale)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <param name="newOriginalScale">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRenderTransform")]
        ///  extern void REPLACE_RENDER_TRANSFORM (nint newValue, UnityEngine.Vector3 newOriginalScale);


        /// <summary>
        ///   System.Void ReplaceRestTriggeredEvent(GameEntity newTriggerSource, GameEntity newRestPortal)
        /// </summary>
        /// <param name="newTriggerSource">class GameEntity</param>
        /// <param name="newRestPortal">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRestTriggeredEvent")]
        ///  extern void REPLACE_REST_TRIGGERED_EVENT (nint newTriggerSource, nint newRestPortal);


        /// <summary>
        ///   System.Void ReplaceReviveBeacon(GameEntity newRevivableEntity, System.Single newCurrentReviveProgress, System.Single newMaxReviveProgress, System.Single newIntervalTimer, System.Boolean newDecaying, System.Boolean newReviving)
        /// </summary>
        /// <param name="newRevivableEntity">class GameEntity</param>
        /// <param name="newCurrentReviveProgress">struct System.Single</param>
        /// <param name="newMaxReviveProgress">struct System.Single</param>
        /// <param name="newIntervalTimer">struct System.Single</param>
        /// <param name="newDecaying">struct System.Boolean</param>
        /// <param name="newReviving">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceReviveBeacon")]
        ///  extern void REPLACE_REVIVE_BEACON (nint newRevivableEntity, System.Single newCurrentReviveProgress, System.Single newMaxReviveProgress, System.Single newIntervalTimer, System.Boolean newDecaying, System.Boolean newReviving);


        /// <summary>
        ///   System.Void ReplaceReviveBeaconReference(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceReviveBeaconReference")]
        ///  extern void REPLACE_REVIVE_BEACON_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceReviveEvent(GameEntity newEntity)
        /// </summary>
        /// <param name="newEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceReviveEvent")]
        ///  extern void REPLACE_REVIVE_EVENT (nint newEntity);


        /// <summary>
        ///   System.Void ReplaceRigidbody(UnityEngine.Rigidbody newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Rigidbody</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRigidbody")]
        ///  extern void REPLACE_RIGIDBODY (nint newValue);


        /// <summary>
        ///   System.Void ReplaceRollCommand(UnityEngine.Vector3 newDirection, System.Single newElapsed, System.Single newLifetime, System.Boolean newProcessed)
        /// </summary>
        /// <param name="newDirection">struct UnityEngine.Vector3</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <param name="newLifetime">struct System.Single</param>
        /// <param name="newProcessed">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRollCommand")]
        ///  extern void REPLACE_ROLL_COMMAND (UnityEngine.Vector3 newDirection, System.Single newElapsed, System.Single newLifetime, System.Boolean newProcessed);


        /// <summary>
        ///   System.Void ReplaceRollCooldown(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRollCooldown")]
        ///  extern void REPLACE_ROLL_COOLDOWN (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceRollCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRollCount")]
        ///  extern void REPLACE_ROLL_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceRotationTween(UnityEngine.Vector3 newFrom, UnityEngine.Vector3 newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed, System.Single newDelay, System.Boolean newIsPaused, System.Action newCompleteCallback)
        /// </summary>
        /// <param name="newFrom">struct UnityEngine.Vector3</param>
        /// <param name="newTo">struct UnityEngine.Vector3</param>
        /// <param name="newDuration">struct System.Single</param>
        /// <param name="newEase">enum EasingFunction.Ease</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <param name="newDelay">struct System.Single</param>
        /// <param name="newIsPaused">struct System.Boolean</param>
        /// <param name="newCompleteCallback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRotationTween")]
        ///  extern void REPLACE_ROTATION_TWEEN (UnityEngine.Vector3 newFrom, UnityEngine.Vector3 newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed, System.Single newDelay, System.Boolean newIsPaused, nint newCompleteCallback);


        /// <summary>
        ///   System.Void ReplaceSaveStone(SaveStoneBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class SaveStoneBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSaveStone")]
        ///  extern void REPLACE_SAVE_STONE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceScreenEffect(ScreenEffectBase newEffect, System.Action newCompleteCallback)
        /// </summary>
        /// <param name="newEffect">abstract class ScreenEffectBase</param>
        /// <param name="newCompleteCallback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceScreenEffect")]
        ///  extern void REPLACE_SCREEN_EFFECT (nint newEffect, nint newCompleteCallback);


        /// <summary>
        ///   System.Void ReplaceScreenEffectPlayer(ScreenEffectPlayer newPlayer, System.Action newCompleteCallback, System.Collections.Generic.List<System.Tuple<System.Action,System.Single>> newParamCompletionCallbacks, ScreenEffectBase newPreStartEffect)
        /// </summary>
        /// <param name="newPlayer">class ScreenEffectPlayer</param>
        /// <param name="newCompleteCallback">class System.Action</param>
        /// <param name="newParamCompletionCallbacks">class System.Collections.Generic.List<System.Tuple<System.Action,System.Single>></param>
        /// <param name="newPreStartEffect">abstract class ScreenEffectBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceScreenEffectPlayer")]
        ///  extern void REPLACE_SCREEN_EFFECT_PLAYER (nint newPlayer, nint newCompleteCallback, nint newParamCompletionCallbacks, nint newPreStartEffect);


        /// <summary>
        ///   System.Void ReplaceSecondPlayer(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSecondPlayer")]
        ///  extern void REPLACE_SECOND_PLAYER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSelectedTavernTalesData(TavernTalesData newValue)
        /// </summary>
        /// <param name="newValue">class TavernTalesData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSelectedTavernTalesData")]
        ///  extern void REPLACE_SELECTED_TAVERN_TALES_DATA (nint newValue);


        /// <summary>
        ///   System.Void ReplaceShadow(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShadow")]
        ///  extern void REPLACE_SHADOW (nint newValue);


        /// <summary>
        ///   System.Void ReplaceShipBlueprintEffects(ShipBlueprintEffects newValue)
        /// </summary>
        /// <param name="newValue">class ShipBlueprintEffects</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipBlueprintEffects")]
        ///  extern void REPLACE_SHIP_BLUEPRINT_EFFECTS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceShipBlueprintItemData(ShipBlueprintItemData newValue)
        /// </summary>
        /// <param name="newValue">class ShipBlueprintItemData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipBlueprintItemData")]
        ///  extern void REPLACE_SHIP_BLUEPRINT_ITEM_DATA (nint newValue);


        /// <summary>
        ///   System.Void ReplaceShipBlueprintsRefreshedEvent(ShipBlueprintsRefreshedEvent newValue)
        /// </summary>
        /// <param name="newValue">class ShipBlueprintsRefreshedEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipBlueprintsRefreshedEvent")]
        ///  extern void REPLACE_SHIP_BLUEPRINTS_REFRESHED_EVENT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceShipBoost(UnityEngine.Vector3 newInitialDirection, System.Single newBoostAmountMultiplier, System.Single newBoostTime, System.Single newBoostDecayTime, System.Single newLifetime)
        /// </summary>
        /// <param name="newInitialDirection">struct UnityEngine.Vector3</param>
        /// <param name="newBoostAmountMultiplier">struct System.Single</param>
        /// <param name="newBoostTime">struct System.Single</param>
        /// <param name="newBoostDecayTime">struct System.Single</param>
        /// <param name="newLifetime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipBoost")]
        ///  extern void REPLACE_SHIP_BOOST (UnityEngine.Vector3 newInitialDirection, System.Single newBoostAmountMultiplier, System.Single newBoostTime, System.Single newBoostDecayTime, System.Single newLifetime);


        /// <summary>
        ///   System.Void ReplaceShipCannon(UnityEngine.GameObject newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.GameObject</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipCannon")]
        ///  extern void REPLACE_SHIP_CANNON (nint newValue);


        /// <summary>
        ///   System.Void ReplaceShipCannonAttackConfig(ShipCannonAttackConfig newValue)
        /// </summary>
        /// <param name="newValue">class ShipCannonAttackConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipCannonAttackConfig")]
        ///  extern void REPLACE_SHIP_CANNON_ATTACK_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void ReplaceShipCannonRotationDelta(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipCannonRotationDelta")]
        ///  extern void REPLACE_SHIP_CANNON_ROTATION_DELTA (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceShipConfig(ShipConfig newValue)
        /// </summary>
        /// <param name="newValue">class ShipConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipConfig")]
        ///  extern void REPLACE_SHIP_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void ReplaceShipDock(ShipDockBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class ShipDockBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipDock")]
        ///  extern void REPLACE_SHIP_DOCK (nint newValue);


        /// <summary>
        ///   System.Void ReplaceShipEnterCamFocusRuntimeScreenEffect(GenericCamFocus newScreenEffect)
        /// </summary>
        /// <param name="newScreenEffect">class GenericCamFocus</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipEnterCamFocusRuntimeScreenEffect")]
        ///  extern void REPLACE_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT (nint newScreenEffect);


        /// <summary>
        ///   System.Void ReplaceShipExitSensorRange(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipExitSensorRange")]
        ///  extern void REPLACE_SHIP_EXIT_SENSOR_RANGE (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceShipFeedbackState(ShipFeedbackState newValue)
        /// </summary>
        /// <param name="newValue">enum ShipFeedbackState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipFeedbackState")]
        ///  extern void REPLACE_SHIP_FEEDBACK_STATE (ShipFeedbackState newValue);


        /// <summary>
        ///   System.Void ReplaceShipMovementPoint(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipMovementPoint")]
        ///  extern void REPLACE_SHIP_MOVEMENT_POINT (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void ReplaceShipPassengerUpdatedEvent(GameEntity newShip)
        /// </summary>
        /// <param name="newShip">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipPassengerUpdatedEvent")]
        ///  extern void REPLACE_SHIP_PASSENGER_UPDATED_EVENT (nint newShip);


        /// <summary>
        ///   System.Void ReplaceShipPathAgent(UnityEngine.AI.NavMeshAgent newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.AI.NavMeshAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipPathAgent")]
        ///  extern void REPLACE_SHIP_PATH_AGENT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceShipReference(GameEntity newEntity)
        /// </summary>
        /// <param name="newEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipReference")]
        ///  extern void REPLACE_SHIP_REFERENCE (nint newEntity);


        /// <summary>
        ///   System.Void ReplaceShipSailInfo(UnityEngine.Cloth newCloth, UnityEngine.Vector3 newDefaultClothValues, System.Single newMaxMoveSpeedReciprocal)
        /// </summary>
        /// <param name="newCloth">class UnityEngine.Cloth</param>
        /// <param name="newDefaultClothValues">struct UnityEngine.Vector3</param>
        /// <param name="newMaxMoveSpeedReciprocal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipSailInfo")]
        ///  extern void REPLACE_SHIP_SAIL_INFO (nint newCloth, UnityEngine.Vector3 newDefaultClothValues, System.Single newMaxMoveSpeedReciprocal);


        /// <summary>
        ///   System.Void ReplaceShipSpecialAttackConfig(ShipCannonAttackConfig newValue)
        /// </summary>
        /// <param name="newValue">class ShipCannonAttackConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipSpecialAttackConfig")]
        ///  extern void REPLACE_SHIP_SPECIAL_ATTACK_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSoundStatesReference(SoundStates newValue)
        /// </summary>
        /// <param name="newValue">class SoundStates</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSoundStatesReference")]
        ///  extern void REPLACE_SOUND_STATES_REFERENCE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSource(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSource")]
        ///  extern void REPLACE_SOURCE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSourceTransform(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSourceTransform")]
        ///  extern void REPLACE_SOURCE_TRANSFORM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSpawnerOverrideDuration(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpawnerOverrideDuration")]
        ///  extern void REPLACE_SPAWNER_OVERRIDE_DURATION (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceSpawnTableItem(SpawnTableItem newValue)
        /// </summary>
        /// <param name="newValue">class SpawnTableItem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpawnTableItem")]
        ///  extern void REPLACE_SPAWN_TABLE_ITEM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSpawnTextEvent(UnityEngine.Vector3 newPosition, System.String newText, CombatTextAnimation newTextAnimation)
        /// </summary>
        /// <param name="newPosition">struct UnityEngine.Vector3</param>
        /// <param name="newText">class System.String</param>
        /// <param name="newTextAnimation">abstract class CombatTextAnimation</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpawnTextEvent")]
        ///  extern void REPLACE_SPAWN_TEXT_EVENT (UnityEngine.Vector3 newPosition, nint newText, nint newTextAnimation);


        /// <summary>
        ///   System.Void ReplaceSpeedTween(System.Single newFrom, System.Single newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed)
        /// </summary>
        /// <param name="newFrom">struct System.Single</param>
        /// <param name="newTo">struct System.Single</param>
        /// <param name="newDuration">struct System.Single</param>
        /// <param name="newEase">enum EasingFunction.Ease</param>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpeedTween")]
        ///  extern void REPLACE_SPEED_TWEEN (System.Single newFrom, System.Single newTo, System.Single newDuration, EasingFunction.Ease newEase, System.Single newElapsed);


        /// <summary>
        ///   System.Void ReplaceSpellCommand(System.Int32 newSpellSlot, System.Int32 newSpellInputActionID, UnityEngine.Vector3 newDirection, System.Single newLifetime, System.Boolean newProcessed)
        /// </summary>
        /// <param name="newSpellSlot">struct System.Int32</param>
        /// <param name="newSpellInputActionID">struct System.Int32</param>
        /// <param name="newDirection">struct UnityEngine.Vector3</param>
        /// <param name="newLifetime">struct System.Single</param>
        /// <param name="newProcessed">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpellCommand")]
        ///  extern void REPLACE_SPELL_COMMAND (System.Int32 newSpellSlot, System.Int32 newSpellInputActionID, UnityEngine.Vector3 newDirection, System.Single newLifetime, System.Boolean newProcessed);



        /// <summary>
        ///   System.Void RemoveUpdatedGunAmmoListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUpdatedGunAmmoListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_UPDATED_GUN_AMMO_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveUpdatedGunAmmoListener(IUpdatedGunAmmoListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IUpdatedGunAmmoListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUpdatedGunAmmoListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_UPDATED_GUN_AMMO_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// public static partial class Search_GameEntity
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void RemoveUpdatedGunAmmoListener()
        /// </summary>
        /// public static bool REMOVE_UPDATED_GUN_AMMO_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUpdatedGunAmmoListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveUpdatedGunAmmoListener(IUpdatedGunAmmoListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_UPDATED_GUN_AMMO_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUpdatedGunAmmoListener", "IUpdatedGunAmmoListener", "System.Boolean");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["ProjectStar".""."GameEntity"]
    /// </summary>
    public partial class GameEntity
    {



        /// <summary>
        ///   System.Void ReplaceSpellConfig(SpellConfig newValue)
        /// </summary>
        /// <param name="newValue">class SpellConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpellConfig")]
        ///  extern void REPLACE_SPELL_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSpellLevelConfig(SpellLevelConfig newValue)
        /// </summary>
        /// <param name="newValue">class SpellLevelConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpellLevelConfig")]
        ///  extern void REPLACE_SPELL_LEVEL_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSpellReference(GameEntity newOwner, SpellLevelConfig newSpell)
        /// </summary>
        /// <param name="newOwner">class GameEntity</param>
        /// <param name="newSpell">class SpellLevelConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpellReference")]
        ///  extern void REPLACE_SPELL_REFERENCE (nint newOwner, nint newSpell);


        /// <summary>
        ///   System.Void ReplaceSpellTracker(System.Collections.Generic.Dictionary<SpellLevelConfig,System.Collections.Generic.List<GameEntity>> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.Dictionary<SpellLevelConfig,System.Collections.Generic.List<GameEntity>></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpellTracker")]
        ///  extern void REPLACE_SPELL_TRACKER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceStarGuide(StarGuideBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class StarGuideBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceStarGuide")]
        ///  extern void REPLACE_STAR_GUIDE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceStarGuideManager(StarGuideManagerBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class StarGuideManagerBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceStarGuideManager")]
        ///  extern void REPLACE_STAR_GUIDE_MANAGER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceStrafeLane(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceStrafeLane")]
        ///  extern void REPLACE_STRAFE_LANE (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceStrengthStat(Gentlebros.IntStat newStat)
        /// </summary>
        /// <param name="newStat">class Gentlebros.IntStat</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceStrengthStat")]
        ///  extern void REPLACE_STRENGTH_STAT (nint newStat);


        /// <summary>
        ///   System.Void ReplaceSwapWeaponCommand(System.Single newLifetime, System.Int32 newProcessingStage, Rewired.InputActionEventData newInputActionEventData)
        /// </summary>
        /// <param name="newLifetime">struct System.Single</param>
        /// <param name="newProcessingStage">struct System.Int32</param>
        /// <param name="newInputActionEventData">struct Rewired.InputActionEventData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSwapWeaponCommand")]
        ///  extern void REPLACE_SWAP_WEAPON_COMMAND (System.Single newLifetime, System.Int32 newProcessingStage, Rewired.InputActionEventData newInputActionEventData);


        /// <summary>
        ///   System.Void ReplaceTakeDamageEvent(GameEntity newTarget)
        /// </summary>
        /// <param name="newTarget">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTakeDamageEvent")]
        ///  extern void REPLACE_TAKE_DAMAGE_EVENT (nint newTarget);


        /// <summary>
        ///   System.Void ReplaceTarget(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTarget")]
        ///  extern void REPLACE_TARGET (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTargetList(System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTargetList")]
        ///  extern void REPLACE_TARGET_LIST (nint newList);


        /// <summary>
        ///   System.Void ReplaceTargetPosition(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTargetPosition")]
        ///  extern void REPLACE_TARGET_POSITION (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void ReplaceTargetTransform(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTargetTransform")]
        ///  extern void REPLACE_TARGET_TRANSFORM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTeleportCallback(Sigtrap.Relays.Relay newValue)
        /// </summary>
        /// <param name="newValue">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTeleportCallback")]
        ///  extern void REPLACE_TELEPORT_CALLBACK (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTerrainExploredCellsTable(System.Collections.Generic.HashSet<UnityEngine.Vector3Int> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.HashSet<UnityEngine.Vector3Int></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTerrainExploredCellsTable")]
        ///  extern void REPLACE_TERRAIN_EXPLORED_CELLS_TABLE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTilt(System.Single newValue, System.Single newGoal)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <param name="newGoal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTilt")]
        ///  extern void REPLACE_TILT (System.Single newValue, System.Single newGoal);


        /// <summary>
        ///   System.Void ReplaceTiltSpeed(System.Single newValue, System.Single newGoal)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <param name="newGoal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTiltSpeed")]
        ///  extern void REPLACE_TILT_SPEED (System.Single newValue, System.Single newGoal);


        /// <summary>
        ///   System.Void ReplaceTimedBuff(System.Collections.Generic.List<CombatTimedBuff> newList, Sigtrap.Relays.Relay<BuffEventType> newBuffRelay)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<CombatTimedBuff></param>
        /// <param name="newBuffRelay">class Sigtrap.Relays.Relay<BuffEventType></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTimedBuff")]
        ///  extern void REPLACE_TIMED_BUFF (nint newList, nint newBuffRelay);


        /// <summary>
        ///   System.Void ReplaceTimer(System.Single newElapsed)
        /// </summary>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTimer")]
        ///  extern void REPLACE_TIMER (System.Single newElapsed);


        /// <summary>
        ///   System.Void ReplaceTimerCallback(System.Collections.Generic.List<TimerCallbackInfo> newInfoTable)
        /// </summary>
        /// <param name="newInfoTable">class System.Collections.Generic.List<TimerCallbackInfo></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTimerCallback")]
        ///  extern void REPLACE_TIMER_CALLBACK (nint newInfoTable);


        /// <summary>
        ///   System.Void ReplaceTint(TintType newTintType, UnityEngine.Color newColor, System.Single newDuration)
        /// </summary>
        /// <param name="newTintType">enum TintType</param>
        /// <param name="newColor">struct UnityEngine.Color</param>
        /// <param name="newDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTint")]
        ///  extern void REPLACE_TINT (TintType newTintType, UnityEngine.Color newColor, System.Single newDuration);


        /// <summary>
        ///   System.Void ReplaceTrailRenderer(UnityEngine.TrailRenderer newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.TrailRenderer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTrailRenderer")]
        ///  extern void REPLACE_TRAIL_RENDERER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTransform(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTransform")]
        ///  extern void REPLACE_TRANSFORM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTransitioning(UnityEngine.Vector3 newTargetPosition, TransitionType newTransitionType)
        /// </summary>
        /// <param name="newTargetPosition">struct UnityEngine.Vector3</param>
        /// <param name="newTransitionType">enum TransitionType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTransitioning")]
        ///  extern void REPLACE_TRANSITIONING (UnityEngine.Vector3 newTargetPosition, TransitionType newTransitionType);


        /// <summary>
        ///   System.Void ReplaceTriggerableInteractableType(WorldUIButton.ButtonIcon newValue)
        /// </summary>
        /// <param name="newValue">enum WorldUIButton.ButtonIcon</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTriggerableInteractableType")]
        ///  extern void REPLACE_TRIGGERABLE_INTERACTABLE_TYPE (WorldUIButton.ButtonIcon newValue);


        /// <summary>
        ///   System.Void ReplaceTriggerHashSet(System.Collections.Generic.HashSet<GameEntity> newHashSet)
        /// </summary>
        /// <param name="newHashSet">class System.Collections.Generic.HashSet<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTriggerHashSet")]
        ///  extern void REPLACE_TRIGGER_HASH_SET (nint newHashSet);


        /// <summary>
        ///   System.Void ReplaceTurnSpeed(System.Single newValue, System.Single newGoal)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <param name="newGoal">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTurnSpeed")]
        ///  extern void REPLACE_TURN_SPEED (System.Single newValue, System.Single newGoal);


        /// <summary>
        ///   System.Void ReplaceUnequipItemCommand(System.Int32 newPlayerID, Equipment newTargetEquipment)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newTargetEquipment">class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnequipItemCommand")]
        ///  extern void REPLACE_UNEQUIP_ITEM_COMMAND (System.Int32 newPlayerID, nint newTargetEquipment);


        /// <summary>
        ///   System.Void ReplaceUnitConfig(UnitConfig newValue)
        /// </summary>
        /// <param name="newValue">class UnitConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnitConfig")]
        ///  extern void REPLACE_UNIT_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUnitLevel(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnitLevel")]
        ///  extern void REPLACE_UNIT_LEVEL (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceUnlockedEquipmentList(System.Collections.Generic.List<Equipment> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<Equipment></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnlockedEquipmentList")]
        ///  extern void REPLACE_UNLOCKED_EQUIPMENT_LIST (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUnlockedShipBlueprints(ShipBlueprintCollection newValue)
        /// </summary>
        /// <param name="newValue">class ShipBlueprintCollection</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnlockedShipBlueprints")]
        ///  extern void REPLACE_UNLOCKED_SHIP_BLUEPRINTS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUnlockedShipSpellTable(ShipSpellCollection newValue)
        /// </summary>
        /// <param name="newValue">class ShipSpellCollection</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnlockedShipSpellTable")]
        ///  extern void REPLACE_UNLOCKED_SHIP_SPELL_TABLE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUnlockedSpellTable(SpellCollection newValue)
        /// </summary>
        /// <param name="newValue">class SpellCollection</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnlockedSpellTable")]
        ///  extern void REPLACE_UNLOCKED_SPELL_TABLE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUpdatedGunAmmo(System.Int32 newPrevValue, System.Int32 newNewValue, System.Int32 newMaxValue)
        /// </summary>
        /// <param name="newPrevValue">struct System.Int32</param>
        /// <param name="newNewValue">struct System.Int32</param>
        /// <param name="newMaxValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUpdatedGunAmmo")]
        ///  extern void REPLACE_UPDATED_GUN_AMMO (System.Int32 newPrevValue, System.Int32 newNewValue, System.Int32 newMaxValue);


        /// <summary>
        ///   System.Void ReplaceUpdatedGunAmmoListener(System.Collections.Generic.List<IUpdatedGunAmmoListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUpdatedGunAmmoListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUpdatedGunAmmoListener")]
        ///  extern void REPLACE_UPDATED_GUN_AMMO_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceVelocityBuffer(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceVelocityBuffer")]
        ///  extern void REPLACE_VELOCITY_BUFFER (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void ReplaceVFXFollowParent(ProjectStar.VFXBehaviour newBehaviour, UnityEngine.GameObject newRefObj, VFXSpawnPosition newSpawnPosition, GameEntity newSource, System.Boolean newOffsetByLocalForward, System.Single newLocalDirectionOffsetDistance)
        /// </summary>
        /// <param name="newBehaviour">class ProjectStar.VFXBehaviour</param>
        /// <param name="newRefObj">class UnityEngine.GameObject</param>
        /// <param name="newSpawnPosition">enum VFXSpawnPosition</param>
        /// <param name="newSource">class GameEntity</param>
        /// <param name="newOffsetByLocalForward">struct System.Boolean</param>
        /// <param name="newLocalDirectionOffsetDistance">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceVFXFollowParent")]
        ///  extern void REPLACE_VFX_FOLLOW_PARENT (nint newBehaviour, nint newRefObj, VFXSpawnPosition newSpawnPosition, nint newSource, System.Boolean newOffsetByLocalForward, System.Single newLocalDirectionOffsetDistance);


        /// <summary>
        ///   System.Void ReplaceVFXSpawnpoint(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceVFXSpawnpoint")]
        ///  extern void REPLACE_VFX_SPAWNPOINT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWallColliders(System.Collections.Generic.List<UnityEngine.Collider> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<UnityEngine.Collider></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWallColliders")]
        ///  extern void REPLACE_WALL_COLLIDERS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWaterRipplesParticles(UnityEngine.ParticleSystem newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.ParticleSystem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWaterRipplesParticles")]
        ///  extern void REPLACE_WATER_RIPPLES_PARTICLES (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWorldUIButtonAnchorPosOffset(UnityEngine.Vector2 newShowOffset, UnityEngine.Vector2 newCannotEnterOffset)
        /// </summary>
        /// <param name="newShowOffset">struct UnityEngine.Vector2</param>
        /// <param name="newCannotEnterOffset">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldUIButtonAnchorPosOffset")]
        ///  extern void REPLACE_WORLD_UI_BUTTON_ANCHOR_POS_OFFSET (UnityEngine.Vector2 newShowOffset, UnityEngine.Vector2 newCannotEnterOffset);


        /// <summary>
        ///   System.Void ReplaceWorldUIButtonAttachFlipSprite(System.Boolean newFlipDisplayedIcon)
        /// </summary>
        /// <param name="newFlipDisplayedIcon">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldUIButtonAttachFlipSprite")]
        ///  extern void REPLACE_WORLD_UI_BUTTON_ATTACH_FLIP_SPRITE (System.Boolean newFlipDisplayedIcon);


        /// <summary>
        ///   System.Void ReplaceWorldUIButtonAttachParent(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldUIButtonAttachParent")]
        ///  extern void REPLACE_WORLD_UI_BUTTON_ATTACH_PARENT (nint newValue);


        /// <summary>
        ///   System.Void Retain(System.Object owner)
        /// </summary>
        /// <param name="owner">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Retain")]
        ///  extern void RETAIN (nint owner);


        /// <summary>
        ///   System.Void set_isAddPlayerEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAddPlayerEvent")]
        ///  extern void SET_IS_ADD_PLAYER_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isAnimationDone(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAnimationDone")]
        ///  extern void SET_IS_ANIMATION_DONE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isAoeCastingHit(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAoeCastingHit")]
        ///  extern void SET_IS_AOE_CASTING_HIT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isAoeCollision(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAoeCollision")]
        ///  extern void SET_IS_AOE_COLLISION (System.Boolean value);


        /// <summary>
        ///   System.Void set_isAoeTick(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAoeTick")]
        ///  extern void SET_IS_AOE_TICK (System.Boolean value);


        /// <summary>
        ///   System.Void set_isAoeTickingHit(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAoeTickingHit")]
        ///  extern void SET_IS_AOE_TICKING_HIT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isAttachedProjectile(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAttachedProjectile")]
        ///  extern void SET_IS_ATTACHED_PROJECTILE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isAttackDoHit(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAttackDoHit")]
        ///  extern void SET_IS_ATTACK_DO_HIT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isAttacking(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAttacking")]
        ///  extern void SET_IS_ATTACKING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isBossTrait(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isBossTrait")]
        ///  extern void SET_IS_BOSS_TRAIT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isChargeAttacking(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isChargeAttacking")]
        ///  extern void SET_IS_CHARGE_ATTACKING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isChargingAttack(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isChargingAttack")]
        ///  extern void SET_IS_CHARGING_ATTACK (System.Boolean value);


        /// <summary>
        ///   System.Void set_isCollectibleMagnetEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isCollectibleMagnetEvent")]
        ///  extern void SET_IS_COLLECTIBLE_MAGNET_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isCombatChecked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isCombatChecked")]
        ///  extern void SET_IS_COMBAT_CHECKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isCulled(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isCulled")]
        ///  extern void SET_IS_CULLED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isCulledVisuals(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isCulledVisuals")]
        ///  extern void SET_IS_CULLED_VISUALS (System.Boolean value);


        /// <summary>
        ///   System.Void set_isCutSceneFastForward(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isCutSceneFastForward")]
        ///  extern void SET_IS_CUT_SCENE_FAST_FORWARD (System.Boolean value);


        /// <summary>
        ///   System.Void set_isCutSceneFastForwardBlocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isCutSceneFastForwardBlocked")]
        ///  extern void SET_IS_CUT_SCENE_FAST_FORWARD_BLOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isDashAttackUnlocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDashAttackUnlocked")]
        ///  extern void SET_IS_DASH_ATTACK_UNLOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isDeathEventProcessed(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDeathEventProcessed")]
        ///  extern void SET_IS_DEATH_EVENT_PROCESSED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isDestroyed(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDestroyed")]
        ///  extern void SET_IS_DESTROYED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isDestructible(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDestructible")]
        ///  extern void SET_IS_DESTRUCTIBLE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isDisableHitFlash(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDisableHitFlash")]
        ///  extern void SET_IS_DISABLE_HIT_FLASH (System.Boolean value);


        /// <summary>
        ///   System.Void set_isEnemy(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isEnemy")]
        ///  extern void SET_IS_ENEMY (System.Boolean value);


        /// <summary>
        ///   System.Void set_isEnemyAllegiance(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isEnemyAllegiance")]
        ///  extern void SET_IS_ENEMY_ALLEGIANCE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isEnemyOwnedProxy(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isEnemyOwnedProxy")]
        ///  extern void SET_IS_ENEMY_OWNED_PROXY (System.Boolean value);


        /// <summary>
        ///   System.Void set_isEquipmentUpgradeShopInteractable(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isEquipmentUpgradeShopInteractable")]
        ///  extern void SET_IS_EQUIPMENT_UPGRADE_SHOP_INTERACTABLE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isFacePlayerWhenFlee(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isFacePlayerWhenFlee")]
        ///  extern void SET_IS_FACE_PLAYER_WHEN_FLEE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isFinalPoint(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isFinalPoint")]
        ///  extern void SET_IS_FINAL_POINT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isFleeing(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isFleeing")]
        ///  extern void SET_IS_FLEEING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isFloatBlocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isFloatBlocked")]
        ///  extern void SET_IS_FLOAT_BLOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isFlyingTrait(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isFlyingTrait")]
        ///  extern void SET_IS_FLYING_TRAIT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isFollowing(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isFollowing")]
        ///  extern void SET_IS_FOLLOWING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isFreezeFacing(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isFreezeFacing")]
        ///  extern void SET_IS_FREEZE_FACING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isFSMInteractable(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isFSMInteractable")]
        ///  extern void SET_IS_FSM_INTERACTABLE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isGlobalInteractBlocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isGlobalInteractBlocked")]
        ///  extern void SET_IS_GLOBAL_INTERACT_BLOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isHitTarget(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isHitTarget")]
        ///  extern void SET_IS_HIT_TARGET (System.Boolean value);


        /// <summary>
        ///   System.Void set_isHomingAroundSource(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isHomingAroundSource")]
        ///  extern void SET_IS_HOMING_AROUND_SOURCE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInactive(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInactive")]
        ///  extern void SET_IS_INACTIVE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInActiveTrap(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInActiveTrap")]
        ///  extern void SET_IS_IN_ACTIVE_TRAP (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInCombatMode(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInCombatMode")]
        ///  extern void SET_IS_IN_COMBAT_MODE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInCutscene(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInCutscene")]
        ///  extern void SET_IS_IN_CUTSCENE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInfinity(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInfinity")]
        ///  extern void SET_IS_INFINITY (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInShip(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInShip")]
        ///  extern void SET_IS_IN_SHIP (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInteractBlocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInteractBlocked")]
        ///  extern void SET_IS_INTERACT_BLOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInvincible(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInvincible")]
        ///  extern void SET_IS_INVINCIBLE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isinWater(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isinWater")]
        ///  extern void SET_ISIN_WATER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isJustSpawned(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isJustSpawned")]
        ///  extern void SET_IS_JUST_SPAWNED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isKilled(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isKilled", CallConvs = [typeof(CallConvCdecl)])]
        extern void SET_IS_KILLED(System.Boolean value);


        /// <summary>
        ///   System.Void set_isLastBoss(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isLastBoss")]
        ///  extern void SET_IS_LAST_BOSS (System.Boolean value);


        /// <summary>
        ///   System.Void set_isLootDropEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isLootDropEvent")]
        ///  extern void SET_IS_LOOT_DROP_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isMonster(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isMonster")]
        ///  extern void SET_IS_MONSTER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isMonsterCaptured(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isMonsterCaptured")]
        ///  extern void SET_IS_MONSTER_CAPTURED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isMoving(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isMoving")]
        ///  extern void SET_IS_MOVING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isNotEnoughGunAmmoEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isNotEnoughGunAmmoEvent")]
        ///  extern void SET_IS_NOT_ENOUGH_GUN_AMMO_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isNPC(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isNPC")]
        ///  extern void SET_IS_NPC (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPlayerAllegiance(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerAllegiance")]
        ///  extern void SET_IS_PLAYER_ALLEGIANCE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPlayerCannotBeAggroed(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerCannotBeAggroed")]
        ///  extern void SET_IS_PLAYER_CANNOT_BE_AGGROED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPlayerCharacter(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerCharacter")]
        ///  extern void SET_IS_PLAYER_CHARACTER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPlayerControlled(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerControlled")]
        ///  extern void SET_IS_PLAYER_CONTROLLED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPlayerFlinching(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerFlinching")]
        ///  extern void SET_IS_PLAYER_FLINCHING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPlayerOwnedProxy(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerOwnedProxy")]
        ///  extern void SET_IS_PLAYER_OWNED_PROXY (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPlayerShip(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerShip")]
        ///  extern void SET_IS_PLAYER_SHIP (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPlayerShipHealthUpdatedEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerShipHealthUpdatedEvent")]
        ///  extern void SET_IS_PLAYER_SHIP_HEALTH_UPDATED_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPlayerSleeping(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerSleeping")]
        ///  extern void SET_IS_PLAYER_SLEEPING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPreviouslyRolling(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPreviouslyRolling")]
        ///  extern void SET_IS_PREVIOUSLY_ROLLING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPreviouslyRunning(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPreviouslyRunning")]
        ///  extern void SET_IS_PREVIOUSLY_RUNNING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isProcessingDestinationRelay(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isProcessingDestinationRelay")]
        ///  extern void SET_IS_PROCESSING_DESTINATION_RELAY (System.Boolean value);


        /// <summary>
        ///   System.Void set_isProjectile(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isProjectile")]
        ///  extern void SET_IS_PROJECTILE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isProjectileCollidable(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isProjectileCollidable")]
        ///  extern void SET_IS_PROJECTILE_COLLIDABLE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPromptAddPlayerEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPromptAddPlayerEvent")]
        ///  extern void SET_IS_PROMPT_ADD_PLAYER_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isProxyDontDestroyOnCutscene(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isProxyDontDestroyOnCutscene")]
        ///  extern void SET_IS_PROXY_DONT_DESTROY_ON_CUTSCENE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isProxyTargetAllies(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isProxyTargetAllies")]
        ///  extern void SET_IS_PROXY_TARGET_ALLIES (System.Boolean value);


        /// <summary>
        ///   System.Void set_isProxyTargetEnemies(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isProxyTargetEnemies")]
        ///  extern void SET_IS_PROXY_TARGET_ENEMIES (System.Boolean value);


        /// <summary>
        ///   System.Void set_isProxyTargetSelf(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isProxyTargetSelf")]
        ///  extern void SET_IS_PROXY_TARGET_SELF (System.Boolean value);


        /// <summary>
        ///   System.Void set_isQuestFsmUpdateEveryFrame(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isQuestFsmUpdateEveryFrame")]
        ///  extern void SET_IS_QUEST_FSM_UPDATE_EVERY_FRAME (System.Boolean value);


        /// <summary>
        ///   System.Void set_isQuestFsmUpdateNextFrame(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isQuestFsmUpdateNextFrame")]
        ///  extern void SET_IS_QUEST_FSM_UPDATE_NEXT_FRAME (System.Boolean value);


        /// <summary>
        ///   System.Void set_isQuestFsmUpdateThisFrame(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isQuestFsmUpdateThisFrame")]
        ///  extern void SET_IS_QUEST_FSM_UPDATE_THIS_FRAME (System.Boolean value);


        /// <summary>
        ///   System.Void set_isRemovePlayerEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isRemovePlayerEvent")]
        ///  extern void SET_IS_REMOVE_PLAYER_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isRespawnPlayersEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isRespawnPlayersEvent")]
        ///  extern void SET_IS_RESPAWN_PLAYERS_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isRevivable(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isRevivable")]
        ///  extern void SET_IS_REVIVABLE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isRollBlocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isRollBlocked")]
        ///  extern void SET_IS_ROLL_BLOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isRolling(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isRolling")]
        ///  extern void SET_IS_ROLLING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSaveParrotDestructibleCollider(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSaveParrotDestructibleCollider")]
        ///  extern void SET_IS_SAVE_PARROT_DESTRUCTIBLE_COLLIDER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSaveStoneInRange(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSaveStoneInRange")]
        ///  extern void SET_IS_SAVE_STONE_IN_RANGE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSaveStoneUpdateEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSaveStoneUpdateEvent")]
        ///  extern void SET_IS_SAVE_STONE_UPDATE_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSelfHealing(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSelfHealing")]
        ///  extern void SET_IS_SELF_HEALING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isShieldBlocking(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShieldBlocking")]
        ///  extern void SET_IS_SHIELD_BLOCKING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isShieldReflective(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShieldReflective")]
        ///  extern void SET_IS_SHIELD_REFLECTIVE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isShip(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShip")]
        ///  extern void SET_IS_SHIP (System.Boolean value);


        /// <summary>
        ///   System.Void set_isShipEnterBlocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShipEnterBlocked")]
        ///  extern void SET_IS_SHIP_ENTER_BLOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isShipEnterEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShipEnterEvent")]
        ///  extern void SET_IS_SHIP_ENTER_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isShipExitEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShipExitEvent")]
        ///  extern void SET_IS_SHIP_EXIT_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isShipInteriorEnterEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShipInteriorEnterEvent")]
        ///  extern void SET_IS_SHIP_INTERIOR_ENTER_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isShipSpecialAmmoCapacityUpdatedEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShipSpecialAmmoCapacityUpdatedEvent")]
        ///  extern void SET_IS_SHIP_SPECIAL_AMMO_CAPACITY_UPDATED_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSideScrollingMode(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSideScrollingMode")]
        ///  extern void SET_IS_SIDE_SCROLLING_MODE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSpecialAudioPlay(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSpecialAudioPlay")]
        ///  extern void SET_IS_SPECIAL_AUDIO_PLAY (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSpellCastBlocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSpellCastBlocked")]
        ///  extern void SET_IS_SPELL_CAST_BLOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSpirit(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSpirit")]
        ///  extern void SET_IS_SPIRIT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSprinting(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSprinting")]
        ///  extern void SET_IS_SPRINTING (System.Boolean value);


        /// <summary>
        ///   System.Void set_isStopAddPlayerEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isStopAddPlayerEvent")]
        ///  extern void SET_IS_STOP_ADD_PLAYER_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isStrafeMovement(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isStrafeMovement")]
        ///  extern void SET_IS_STRAFE_MOVEMENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSwapWeaponBlocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSwapWeaponBlocked")]
        ///  extern void SET_IS_SWAP_WEAPON_BLOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isTargetGroup(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isTargetGroup")]
        ///  extern void SET_IS_TARGET_GROUP (System.Boolean value);


        /// <summary>
        ///   System.Void set_isTrap(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isTrap")]
        ///  extern void SET_IS_TRAP (System.Boolean value);


        /// <summary>
        ///   System.Void set_isTriggerableInteractable(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isTriggerableInteractable")]
        ///  extern void SET_IS_TRIGGERABLE_INTERACTABLE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isUndamageableUnit(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isUndamageableUnit")]
        ///  extern void SET_IS_UNDAMAGEABLE_UNIT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isWaterTrait(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isWaterTrait")]
        ///  extern void SET_IS_WATER_TRAIT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isWaypoint(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isWaypoint")]
        ///  extern void SET_IS_WAYPOINT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isXAxisOnly(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isXAxisOnly")]
        ///  extern void SET_IS_X_AXIS_ONLY (System.Boolean value);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();




        /// public static partial class Search_GameEntity
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}