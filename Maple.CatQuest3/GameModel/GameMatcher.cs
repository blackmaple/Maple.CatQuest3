
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
    /// class ["ProjectStar".""."GameMatcher"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x0200063AU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [71, 97, 109, 101, 77, 97, 116, 99, 104, 101, 114])]

    //  interface static Entitas.IMatcher<GameEntity> _matcherActiveScreenEffectPlayer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherActiveScreenEffectPlayer", "_MATCHER_ACTIVE_SCREEN_EFFECT_PLAYER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherActiveWeaponChangedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherActiveWeaponChangedEvent", "_MATCHER_ACTIVE_WEAPON_CHANGED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAddPlayerEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAddPlayerEvent", "_MATCHER_ADD_PLAYER_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAdvancedStatModifiers
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAdvancedStatModifiers", "_MATCHER_ADVANCED_STAT_MODIFIERS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAgentDestination
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAgentDestination", "_MATCHER_AGENT_DESTINATION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAgentPreviousDestination
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAgentPreviousDestination", "_MATCHER_AGENT_PREVIOUS_DESTINATION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAnchorPosOffset
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAnchorPosOffset", "_MATCHER_ANCHOR_POS_OFFSET", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAngleOffset
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAngleOffset", "_MATCHER_ANGLE_OFFSET", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAnimation
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAnimation", "_MATCHER_ANIMATION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAnimationDone
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAnimationDone", "_MATCHER_ANIMATION_DONE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAnimationFlags
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAnimationFlags", "_MATCHER_ANIMATION_FLAGS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAnimationProgress
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAnimationProgress", "_MATCHER_ANIMATION_PROGRESS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAnimator
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAnimator", "_MATCHER_ANIMATOR", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAnyActiveWeaponChangedEventListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAnyActiveWeaponChangedEventListener", "_MATCHER_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAnyShipEnterBlockedListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAnyShipEnterBlockedListener", "_MATCHER_ANY_SHIP_ENTER_BLOCKED_LISTENER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAnyShipEnterBlockedRemovedListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAnyShipEnterBlockedRemovedListener", "_MATCHER_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAoeCastingHit
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAoeCastingHit", "_MATCHER_AOE_CASTING_HIT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAoeColliderType
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAoeColliderType", "_MATCHER_AOE_COLLIDER_TYPE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAoeCollision
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAoeCollision", "_MATCHER_AOE_COLLISION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAoeInfo
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAoeInfo", "_MATCHER_AOE_INFO", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAoeTick
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAoeTick", "_MATCHER_AOE_TICK", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAoeTickingHit
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAoeTickingHit", "_MATCHER_AOE_TICKING_HIT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherArtPrefabReference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherArtPrefabReference", "_MATCHER_ART_PREFAB_REFERENCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAttachableFloat
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttachableFloat", "_MATCHER_ATTACHABLE_FLOAT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAttachedProjectile
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttachedProjectile", "_MATCHER_ATTACHED_PROJECTILE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAttachedVfxTracker
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttachedVfxTracker", "_MATCHER_ATTACHED_VFX_TRACKER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAttackAnimation
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttackAnimation", "_MATCHER_ATTACK_ANIMATION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAttackCommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttackCommand", "_MATCHER_ATTACK_COMMAND", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAttackDoHit
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttackDoHit", "_MATCHER_ATTACK_DO_HIT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAttackEventInfo
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttackEventInfo", "_MATCHER_ATTACK_EVENT_INFO", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAttacking
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttacking", "_MATCHER_ATTACKING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAttackReference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttackReference", "_MATCHER_ATTACK_REFERENCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAttackTellView
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttackTellView", "_MATCHER_ATTACK_TELL_VIEW", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAttackTint
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttackTint", "_MATCHER_ATTACK_TINT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherAwardedQuestItems
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAwardedQuestItems", "_MATCHER_AWARDED_QUEST_ITEMS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherBaseEnemyBehaviour
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherBaseEnemyBehaviour", "_MATCHER_BASE_ENEMY_BEHAVIOUR", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherBehaviourTree
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherBehaviourTree", "_MATCHER_BEHAVIOUR_TREE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherBlockEffectCooldown
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherBlockEffectCooldown", "_MATCHER_BLOCK_EFFECT_COOLDOWN", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherBlockFreezeDuration
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherBlockFreezeDuration", "_MATCHER_BLOCK_FREEZE_DURATION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherBossTrait
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherBossTrait", "_MATCHER_BOSS_TRAIT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherBurnCounter
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherBurnCounter", "_MATCHER_BURN_COUNTER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCannonCooldown
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCannonCooldown", "_MATCHER_CANNON_COOLDOWN", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCapsule
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCapsule", "_MATCHER_CAPSULE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCharacterController
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCharacterController", "_MATCHER_CHARACTER_CONTROLLER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCharacterGender
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCharacterGender", "_MATCHER_CHARACTER_GENDER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherChargeAttacking
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherChargeAttacking", "_MATCHER_CHARGE_ATTACKING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherChargeConfig
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherChargeConfig", "_MATCHER_CHARGE_CONFIG", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherChargingAttack
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherChargingAttack", "_MATCHER_CHARGING_ATTACK", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherChest
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherChest", "_MATCHER_CHEST", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherChestInteractor
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherChestInteractor", "_MATCHER_CHEST_INTERACTOR", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCollatedAoeAttacks
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCollatedAoeAttacks", "_MATCHER_COLLATED_AOE_ATTACKS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCollectibleCollectedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCollectibleCollectedEvent", "_MATCHER_COLLECTIBLE_COLLECTED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCollectibleMagnetEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCollectibleMagnetEvent", "_MATCHER_COLLECTIBLE_MAGNET_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCollectibleReference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCollectibleReference", "_MATCHER_COLLECTIBLE_REFERENCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCollider
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCollider", "_MATCHER_COLLIDER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCombatAgent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCombatAgent", "_MATCHER_COMBAT_AGENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCombatAgentHealthUpdatedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCombatAgentHealthUpdatedEvent", "_MATCHER_COMBAT_AGENT_HEALTH_UPDATED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCombatAgentList
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCombatAgentList", "_MATCHER_COMBAT_AGENT_LIST", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCombatAggroDuration
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCombatAggroDuration", "_MATCHER_COMBAT_AGGRO_DURATION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCombatChecked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCombatChecked", "_MATCHER_COMBAT_CHECKED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCombatLog
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCombatLog", "_MATCHER_COMBAT_LOG", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCombatProxyAgent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCombatProxyAgent", "_MATCHER_COMBAT_PROXY_AGENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCulled
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCulled", "_MATCHER_CULLED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCulledVisuals
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCulledVisuals", "_MATCHER_CULLED_VISUALS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCurrentChargerAttackEntities
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCurrentChargerAttackEntities", "_MATCHER_CURRENT_CHARGER_ATTACK_ENTITIES", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCurrentProjectileHitEntities
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCurrentProjectileHitEntities", "_MATCHER_CURRENT_PROJECTILE_HIT_ENTITIES", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCurrentSensorRadius
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCurrentSensorRadius", "_MATCHER_CURRENT_SENSOR_RADIUS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCutSceneFastForwardBlocked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCutSceneFastForwardBlocked", "_MATCHER_CUT_SCENE_FAST_FORWARD_BLOCKED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCutSceneFastForward
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCutSceneFastForward", "_MATCHER_CUT_SCENE_FAST_FORWARD", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherCutsceneOwner
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCutsceneOwner", "_MATCHER_CUTSCENE_OWNER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDashAttackCounter
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDashAttackCounter", "_MATCHER_DASH_ATTACK_COUNTER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDashAttackUnlocked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDashAttackUnlocked", "_MATCHER_DASH_ATTACK_UNLOCKED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDeathEventProcessed
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDeathEventProcessed", "_MATCHER_DEATH_EVENT_PROCESSED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDestinationRelay
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDestinationRelay", "_MATCHER_DESTINATION_RELAY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDestroyed
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDestroyed", "_MATCHER_DESTROYED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDestructible
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDestructible", "_MATCHER_DESTRUCTIBLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDestructibleFX
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDestructibleFX", "_MATCHER_DESTRUCTIBLE_FX", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDialogueSpeaker
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDialogueSpeaker", "_MATCHER_DIALOGUE_SPEAKER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDirection
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDirection", "_MATCHER_DIRECTION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDisableHitFlash
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDisableHitFlash", "_MATCHER_DISABLE_HIT_FLASH", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDockRepairBeacon
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDockRepairBeacon", "_MATCHER_DOCK_REPAIR_BEACON", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDockRepair
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDockRepair", "_MATCHER_DOCK_REPAIR", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherDockRepairOccupantsUpdatedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDockRepairOccupantsUpdatedEvent", "_MATCHER_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEnemyAllegiance
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEnemyAllegiance", "_MATCHER_ENEMY_ALLEGIANCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEnemy
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEnemy", "_MATCHER_ENEMY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEnemyOwnedProxy
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEnemyOwnedProxy", "_MATCHER_ENEMY_OWNED_PROXY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEnemyShipBehaviour
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEnemyShipBehaviour", "_MATCHER_ENEMY_SHIP_BEHAVIOUR", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEquipItemCommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEquipItemCommand", "_MATCHER_EQUIP_ITEM_COMMAND", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEquipmentChangedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEquipmentChangedEvent", "_MATCHER_EQUIPMENT_CHANGED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEquipment
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEquipment", "_MATCHER_EQUIPMENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEquipmentEffects
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEquipmentEffects", "_MATCHER_EQUIPMENT_EFFECTS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEquipmentItemData
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEquipmentItemData", "_MATCHER_EQUIPMENT_ITEM_DATA", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEquipmentUpgradeShopInteractable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEquipmentUpgradeShopInteractable", "_MATCHER_EQUIPMENT_UPGRADE_SHOP_INTERACTABLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEquippedItems
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEquippedItems", "_MATCHER_EQUIPPED_ITEMS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEquippedPlayerShipSpells
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEquippedPlayerShipSpells", "_MATCHER_EQUIPPED_PLAYER_SHIP_SPELLS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEquippedShipBlueprints
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEquippedShipBlueprints", "_MATCHER_EQUIPPED_SHIP_BLUEPRINTS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherEquippedSpells
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEquippedSpells", "_MATCHER_EQUIPPED_SPELLS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFacePlayerWhenFlee
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFacePlayerWhenFlee", "_MATCHER_FACE_PLAYER_WHEN_FLEE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFacing
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFacing", "_MATCHER_FACING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFadeDuration
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFadeDuration", "_MATCHER_FADE_DURATION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFinalPoint
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFinalPoint", "_MATCHER_FINAL_POINT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFiringPoint
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFiringPoint", "_MATCHER_FIRING_POINT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFleeing
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFleeing", "_MATCHER_FLEEING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFloatBlocked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFloatBlocked", "_MATCHER_FLOAT_BLOCKED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFloatTransitionEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFloatTransitionEvent", "_MATCHER_FLOAT_TRANSITION_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFlyingTrait
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFlyingTrait", "_MATCHER_FLYING_TRAIT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFoam
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFoam", "_MATCHER_FOAM", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFollowing
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFollowing", "_MATCHER_FOLLOWING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFreezeFacing
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFreezeFacing", "_MATCHER_FREEZE_FACING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherFSMInteractable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFSMInteractable", "_MATCHER_FSM_INTERACTABLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGameDestroyedListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGameDestroyedListener", "_MATCHER_GAME_DESTROYED_LISTENER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGameDifficulty
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGameDifficulty", "_MATCHER_GAME_DIFFICULTY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGameDifficultyDamageModifier
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGameDifficultyDamageModifier", "_MATCHER_GAME_DIFFICULTY_DAMAGE_MODIFIER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGameDifficultyHeathModifier
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGameDifficultyHeathModifier", "_MATCHER_GAME_DIFFICULTY_HEATH_MODIFIER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGameEntityId
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGameEntityId", "_MATCHER_GAME_ENTITY_ID", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGameOverEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGameOverEvent", "_MATCHER_GAME_OVER_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGameOverNoSaveOverride
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGameOverNoSaveOverride", "_MATCHER_GAME_OVER_NO_SAVE_OVERRIDE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGlobalInteractBlocked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGlobalInteractBlocked", "_MATCHER_GLOBAL_INTERACT_BLOCKED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGraphicObjContainer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGraphicObjContainer", "_MATCHER_GRAPHIC_OBJ_CONTAINER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGunAmmo
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGunAmmo", "_MATCHER_GUN_AMMO", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGunReload
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGunReload", "_MATCHER_GUN_RELOAD", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGunReloadProgress
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGunReloadProgress", "_MATCHER_GUN_RELOAD_PROGRESS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGunReloadProgressListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGunReloadProgressListener", "_MATCHER_GUN_RELOAD_PROGRESS_LISTENER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherGunReloadTimer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGunReloadTimer", "_MATCHER_GUN_RELOAD_TIMER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherHealCompletedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHealCompletedEvent", "_MATCHER_HEAL_COMPLETED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherHealer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHealer", "_MATCHER_HEALER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherHealStartedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHealStartedEvent", "_MATCHER_HEAL_STARTED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherHealth
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHealth", "_MATCHER_HEALTH", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherHealthRegenTickCounter
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHealthRegenTickCounter", "_MATCHER_HEALTH_REGEN_TICK_COUNTER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherHealthStat
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHealthStat", "_MATCHER_HEALTH_STAT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherHitStop
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHitStop", "_MATCHER_HIT_STOP", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherHitStopEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHitStopEvent", "_MATCHER_HIT_STOP_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherHitTarget
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHitTarget", "_MATCHER_HIT_TARGET", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherHomingAroundSource
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHomingAroundSource", "_MATCHER_HOMING_AROUND_SOURCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherId
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherId", "_MATCHER_ID", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherIFrame
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherIFrame", "_MATCHER_I_FRAME", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInactive
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInactive", "_MATCHER_INACTIVE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInActiveTrap
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInActiveTrap", "_MATCHER_IN_ACTIVE_TRAP", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInCombatMode
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInCombatMode", "_MATCHER_IN_COMBAT_MODE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInCutscene
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInCutscene", "_MATCHER_IN_CUTSCENE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInfinity
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInfinity", "_MATCHER_INFINITY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInfinityTowerTimer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInfinityTowerTimer", "_MATCHER_INFINITY_TOWER_TIMER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInHealRegion
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInHealRegion", "_MATCHER_IN_HEAL_REGION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInitialDirection
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInitialDirection", "_MATCHER_INITIAL_DIRECTION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInitialPosition
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInitialPosition", "_MATCHER_INITIAL_POSITION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInPotentialHealRegion
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInPotentialHealRegion", "_MATCHER_IN_POTENTIAL_HEAL_REGION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInputStateCommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInputStateCommand", "_MATCHER_INPUT_STATE_COMMAND", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInShip
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInShip", "_MATCHER_IN_SHIP", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInstancePortal
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInstancePortal", "_MATCHER_INSTANCE_PORTAL", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherIntCounter
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherIntCounter", "_MATCHER_INT_COUNTER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInteractable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInteractable", "_MATCHER_INTERACTABLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInteractableFailInteractableEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInteractableFailInteractableEvent", "_MATCHER_INTERACTABLE_FAIL_INTERACTABLE_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInteractableFailValidateEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInteractableFailValidateEvent", "_MATCHER_INTERACTABLE_FAIL_VALIDATE_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInteractableStatus
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInteractableStatus", "_MATCHER_INTERACTABLE_STATUS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInteractableStatusUpdatedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInteractableStatusUpdatedEvent", "_MATCHER_INTERACTABLE_STATUS_UPDATED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInteractableTriggeredTargetEntitiesUpdatedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInteractableTriggeredTargetEntitiesUpdatedEvent", "_MATCHER_INTERACTABLE_TRIGGERED_TARGET_ENTITIES_UPDATED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInteractBlocked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInteractBlocked", "_MATCHER_INTERACT_BLOCKED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInteractCommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInteractCommand", "_MATCHER_INTERACT_COMMAND", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInteractCommandUpdate
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInteractCommandUpdate", "_MATCHER_INTERACT_COMMAND_UPDATE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInteractLookAt
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInteractLookAt", "_MATCHER_INTERACT_LOOK_AT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInventoryCommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInventoryCommand", "_MATCHER_INVENTORY_COMMAND", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInventoryLevel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInventoryLevel", "_MATCHER_INVENTORY_LEVEL", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInventorySpellInfo
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInventorySpellInfo", "_MATCHER_INVENTORY_SPELL_INFO", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInvincible
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInvincible", "_MATCHER_INVINCIBLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherInvisibleWall
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInvisibleWall", "_MATCHER_INVISIBLE_WALL", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherinWall
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherinWall", "_MATCHERIN_WALL", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherinWater
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherinWater", "_MATCHERIN_WATER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherJustSpawned
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherJustSpawned", "_MATCHER_JUST_SPAWNED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherKilled
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherKilled", "_MATCHER_KILLED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherKilledListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherKilledListener", "_MATCHER_KILLED_LISTENER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherKnockbackMultiplier
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherKnockbackMultiplier", "_MATCHER_KNOCKBACK_MULTIPLIER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLastBoss
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLastBoss", "_MATCHER_LAST_BOSS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLastSeenDuration
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLastSeenDuration", "_MATCHER_LAST_SEEN_DURATION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLatestInfinityTowerClearedWave
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLatestInfinityTowerClearedWave", "_MATCHER_LATEST_INFINITY_TOWER_CLEARED_WAVE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLifetime
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLifetime", "_MATCHER_LIFETIME", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLifetimeTarget
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLifetimeTarget", "_MATCHER_LIFETIME_TARGET", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLocationData
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLocationData", "_MATCHER_LOCATION_DATA", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLootDropEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLootDropEvent", "_MATCHER_LOOT_DROP_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLootDropLevel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLootDropLevel", "_MATCHER_LOOT_DROP_LEVEL", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLootMagnet
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLootMagnet", "_MATCHER_LOOT_MAGNET", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLootMultiplier
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLootMultiplier", "_MATCHER_LOOT_MULTIPLIER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLootTable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLootTable", "_MATCHER_LOOT_TABLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherLootTimer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLootTimer", "_MATCHER_LOOT_TIMER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMagicStat
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMagicStat", "_MATCHER_MAGIC_STAT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMainSprite
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMainSprite", "_MATCHER_MAIN_SPRITE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherManaBar
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherManaBar", "_MATCHER_MANA_BAR", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMana
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMana", "_MATCHER_MANA", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMapIconDisplayLink
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapIconDisplayLink", "_MATCHER_MAP_ICON_DISPLAY_LINK", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMapMarkerWorld
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapMarkerWorld", "_MATCHER_MAP_MARKER_WORLD", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMapMarkerWorldIndex
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapMarkerWorldIndex", "_MATCHER_MAP_MARKER_WORLD_INDEX", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMaxMoveSpeed
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMaxMoveSpeed", "_MATCHER_MAX_MOVE_SPEED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMeleeAttackCommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMeleeAttackCommand", "_MATCHER_MELEE_ATTACK_COMMAND", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMonsterBehaviour
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMonsterBehaviour", "_MATCHER_MONSTER_BEHAVIOUR", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMonsterCaptured
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMonsterCaptured", "_MATCHER_MONSTER_CAPTURED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMonster
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMonster", "_MATCHER_MONSTER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMonsterDetector
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMonsterDetector", "_MATCHER_MONSTER_DETECTOR", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMonsterDetectorInfo
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMonsterDetectorInfo", "_MATCHER_MONSTER_DETECTOR_INFO", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMonsterDetectorRequestor
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMonsterDetectorRequestor", "_MATCHER_MONSTER_DETECTOR_REQUESTOR", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMonsterDetectorResultInfo
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMonsterDetectorResultInfo", "_MATCHER_MONSTER_DETECTOR_RESULT_INFO", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMonsterTrait
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMonsterTrait", "_MATCHER_MONSTER_TRAIT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMoveSpeed
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMoveSpeed", "_MATCHER_MOVE_SPEED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherMoving
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMoving", "_MATCHER_MOVING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherNavAgentTarget
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherNavAgentTarget", "_MATCHER_NAV_AGENT_TARGET", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherNavMeshAgent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherNavMeshAgent", "_MATCHER_NAV_MESH_AGENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherNavPath
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherNavPath", "_MATCHER_NAV_PATH", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherNotEnoughGunAmmoEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherNotEnoughGunAmmoEvent", "_MATCHER_NOT_ENOUGH_GUN_AMMO_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherNotEnoughGunAmmoEventListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherNotEnoughGunAmmoEventListener", "_MATCHER_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherNPC
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherNPC", "_MATCHER_NPC", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherObjectiveInteractor
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherObjectiveInteractor", "_MATCHER_OBJECTIVE_INTERACTOR", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherOnDeathAnimCompleteEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherOnDeathAnimCompleteEvent", "_MATCHER_ON_DEATH_ANIM_COMPLETE_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherOnDeathEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherOnDeathEvent", "_MATCHER_ON_DEATH_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherOnHitIFrameData
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherOnHitIFrameData", "_MATCHER_ON_HIT_I_FRAME_DATA", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherOnReviveCallback
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherOnReviveCallback", "_MATCHER_ON_REVIVE_CALLBACK", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherOriginalLocalScale
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherOriginalLocalScale", "_MATCHER_ORIGINAL_LOCAL_SCALE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherOverlapList
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherOverlapList", "_MATCHER_OVERLAP_LIST", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherOverrideCharacterGender
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherOverrideCharacterGender", "_MATCHER_OVERRIDE_CHARACTER_GENDER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherOwner
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherOwner", "_MATCHER_OWNER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherParticleEffect
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherParticleEffect", "_MATCHER_PARTICLE_EFFECT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerAddedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerAddedEvent", "_MATCHER_PLAYER_ADDED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerAllegiance
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerAllegiance", "_MATCHER_PLAYER_ALLEGIANCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerCannotBeAggroed
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerCannotBeAggroed", "_MATCHER_PLAYER_CANNOT_BE_AGGROED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerCharacter
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerCharacter", "_MATCHER_PLAYER_CHARACTER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerControlled
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerControlled", "_MATCHER_PLAYER_CONTROLLED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerFlinching
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerFlinching", "_MATCHER_PLAYER_FLINCHING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerId
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerId", "_MATCHER_PLAYER_ID", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerIdListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerIdListener", "_MATCHER_PLAYER_ID_LISTENER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerIdReference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerIdReference", "_MATCHER_PLAYER_ID_REFERENCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerIdRemovedListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerIdRemovedListener", "_MATCHER_PLAYER_ID_REMOVED_LISTENER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerKilledSource
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerKilledSource", "_MATCHER_PLAYER_KILLED_SOURCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerOwnedProxy
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerOwnedProxy", "_MATCHER_PLAYER_OWNED_PROXY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerReference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerReference", "_MATCHER_PLAYER_REFERENCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerRemovedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerRemovedEvent", "_MATCHER_PLAYER_REMOVED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerShip
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerShip", "_MATCHER_PLAYER_SHIP", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerShipHealthUpdatedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerShipHealthUpdatedEvent", "_MATCHER_PLAYER_SHIP_HEALTH_UPDATED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerSleeping
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerSleeping", "_MATCHER_PLAYER_SLEEPING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerSleepingSaveStone
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerSleepingSaveStone", "_MATCHER_PLAYER_SLEEPING_SAVE_STONE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerStat
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerStat", "_MATCHER_PLAYER_STAT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPlayerVicinity
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerVicinity", "_MATCHER_PLAYER_VICINITY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPoolStatusTable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPoolStatusTable", "_MATCHER_POOL_STATUS_TABLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPositionAttach
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPositionAttach", "_MATCHER_POSITION_ATTACH", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPosition
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPosition", "_MATCHER_POSITION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPositionHistory
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPositionHistory", "_MATCHER_POSITION_HISTORY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPositionTween
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPositionTween", "_MATCHER_POSITION_TWEEN", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPreviouslyRolling
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPreviouslyRolling", "_MATCHER_PREVIOUSLY_ROLLING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPreviouslyRunning
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPreviouslyRunning", "_MATCHER_PREVIOUSLY_RUNNING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProcessingDestinationRelay
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProcessingDestinationRelay", "_MATCHER_PROCESSING_DESTINATION_RELAY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProjectileBehaviour
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProjectileBehaviour", "_MATCHER_PROJECTILE_BEHAVIOUR", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProjectileCollidable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProjectileCollidable", "_MATCHER_PROJECTILE_COLLIDABLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProjectileColliderInfo
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProjectileColliderInfo", "_MATCHER_PROJECTILE_COLLIDER_INFO", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProjectile
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProjectile", "_MATCHER_PROJECTILE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProjectileInfo
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProjectileInfo", "_MATCHER_PROJECTILE_INFO", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProjectileMovement
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProjectileMovement", "_MATCHER_PROJECTILE_MOVEMENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProjectileReference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProjectileReference", "_MATCHER_PROJECTILE_REFERENCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProjectileVfxReference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProjectileVfxReference", "_MATCHER_PROJECTILE_VFX_REFERENCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPromptAddPlayerEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPromptAddPlayerEvent", "_MATCHER_PROMPT_ADD_PLAYER_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPromptRemovePlayerEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPromptRemovePlayerEvent", "_MATCHER_PROMPT_REMOVE_PLAYER_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProxyDontDestroyOnCutscene
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProxyDontDestroyOnCutscene", "_MATCHER_PROXY_DONT_DESTROY_ON_CUTSCENE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProxyTargetAllies
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProxyTargetAllies", "_MATCHER_PROXY_TARGET_ALLIES", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProxyTargetEnemies
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProxyTargetEnemies", "_MATCHER_PROXY_TARGET_ENEMIES", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherProxyTargetSelf
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherProxyTargetSelf", "_MATCHER_PROXY_TARGET_SELF", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPuzzleAnswerCompletedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPuzzleAnswerCompletedEvent", "_MATCHER_PUZZLE_ANSWER_COMPLETED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPuzzleAnswer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPuzzleAnswer", "_MATCHER_PUZZLE_ANSWER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPuzzleAnswerState
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPuzzleAnswerState", "_MATCHER_PUZZLE_ANSWER_STATE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPuzzleLootLocation
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPuzzleLootLocation", "_MATCHER_PUZZLE_LOOT_LOCATION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPuzzlePieceID
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPuzzlePieceID", "_MATCHER_PUZZLE_PIECE_ID", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPuzzlePieceInteractedCount
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPuzzlePieceInteractedCount", "_MATCHER_PUZZLE_PIECE_INTERACTED_COUNT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherPuzzlePieceInteractedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPuzzlePieceInteractedEvent", "_MATCHER_PUZZLE_PIECE_INTERACTED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherQuestFsm
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherQuestFsm", "_MATCHER_QUEST_FSM", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherQuestFsmUpdateEveryFrame
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherQuestFsmUpdateEveryFrame", "_MATCHER_QUEST_FSM_UPDATE_EVERY_FRAME", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherQuestFsmUpdateNextFrame
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherQuestFsmUpdateNextFrame", "_MATCHER_QUEST_FSM_UPDATE_NEXT_FRAME", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherQuestFsmUpdateThisFrame
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherQuestFsmUpdateThisFrame", "_MATCHER_QUEST_FSM_UPDATE_THIS_FRAME", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRecovery
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRecovery", "_MATCHER_RECOVERY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRemovePlayerEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRemovePlayerEvent", "_MATCHER_REMOVE_PLAYER_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRendererTinter
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRendererTinter", "_MATCHER_RENDERER_TINTER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRenderTransform
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRenderTransform", "_MATCHER_RENDER_TRANSFORM", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRespawnPlayersEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRespawnPlayersEvent", "_MATCHER_RESPAWN_PLAYERS_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRestTriggeredEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRestTriggeredEvent", "_MATCHER_REST_TRIGGERED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRevivable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRevivable", "_MATCHER_REVIVABLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherReviveBeacon
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherReviveBeacon", "_MATCHER_REVIVE_BEACON", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherReviveBeaconReference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherReviveBeaconReference", "_MATCHER_REVIVE_BEACON_REFERENCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherReviveEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherReviveEvent", "_MATCHER_REVIVE_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRigidbody
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRigidbody", "_MATCHER_RIGIDBODY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRollBlocked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRollBlocked", "_MATCHER_ROLL_BLOCKED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRollCommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRollCommand", "_MATCHER_ROLL_COMMAND", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRollCooldown
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRollCooldown", "_MATCHER_ROLL_COOLDOWN", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRollCount
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRollCount", "_MATCHER_ROLL_COUNT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRolling
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRolling", "_MATCHER_ROLLING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherRotationTween
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRotationTween", "_MATCHER_ROTATION_TWEEN", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSaveParrotDestructibleCollider
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSaveParrotDestructibleCollider", "_MATCHER_SAVE_PARROT_DESTRUCTIBLE_COLLIDER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSaveStone
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSaveStone", "_MATCHER_SAVE_STONE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSaveStoneInRange
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSaveStoneInRange", "_MATCHER_SAVE_STONE_IN_RANGE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSaveStoneUpdateEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSaveStoneUpdateEvent", "_MATCHER_SAVE_STONE_UPDATE_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherScreenEffect
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherScreenEffect", "_MATCHER_SCREEN_EFFECT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherScreenEffectPlayer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherScreenEffectPlayer", "_MATCHER_SCREEN_EFFECT_PLAYER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSecondPlayer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSecondPlayer", "_MATCHER_SECOND_PLAYER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSelectedTavernTalesData
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSelectedTavernTalesData", "_MATCHER_SELECTED_TAVERN_TALES_DATA", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSelfHealing
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSelfHealing", "_MATCHER_SELF_HEALING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShadow
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShadow", "_MATCHER_SHADOW", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShieldBlocking
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShieldBlocking", "_MATCHER_SHIELD_BLOCKING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShieldReflective
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShieldReflective", "_MATCHER_SHIELD_REFLECTIVE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipBlueprintEffects
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipBlueprintEffects", "_MATCHER_SHIP_BLUEPRINT_EFFECTS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipBlueprintItemData
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipBlueprintItemData", "_MATCHER_SHIP_BLUEPRINT_ITEM_DATA", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipBlueprintsRefreshedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipBlueprintsRefreshedEvent", "_MATCHER_SHIP_BLUEPRINTS_REFRESHED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipBoost
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipBoost", "_MATCHER_SHIP_BOOST", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipCannonAttackConfig
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipCannonAttackConfig", "_MATCHER_SHIP_CANNON_ATTACK_CONFIG", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipCannon
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipCannon", "_MATCHER_SHIP_CANNON", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipCannonRotationDelta
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipCannonRotationDelta", "_MATCHER_SHIP_CANNON_ROTATION_DELTA", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShip
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShip", "_MATCHER_SHIP", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipConfig
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipConfig", "_MATCHER_SHIP_CONFIG", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipDock
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipDock", "_MATCHER_SHIP_DOCK", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipEnterBlocked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipEnterBlocked", "_MATCHER_SHIP_ENTER_BLOCKED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipEnterCamFocusRuntimeScreenEffect
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipEnterCamFocusRuntimeScreenEffect", "_MATCHER_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipEnterEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipEnterEvent", "_MATCHER_SHIP_ENTER_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipExitEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipExitEvent", "_MATCHER_SHIP_EXIT_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipExitSensorRange
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipExitSensorRange", "_MATCHER_SHIP_EXIT_SENSOR_RANGE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipFeedbackState
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipFeedbackState", "_MATCHER_SHIP_FEEDBACK_STATE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipInteriorEnterEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipInteriorEnterEvent", "_MATCHER_SHIP_INTERIOR_ENTER_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipMovementPoint
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipMovementPoint", "_MATCHER_SHIP_MOVEMENT_POINT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipPassengerUpdatedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipPassengerUpdatedEvent", "_MATCHER_SHIP_PASSENGER_UPDATED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipPathAgent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipPathAgent", "_MATCHER_SHIP_PATH_AGENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipReference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipReference", "_MATCHER_SHIP_REFERENCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipSailInfo
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipSailInfo", "_MATCHER_SHIP_SAIL_INFO", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipSpecialAmmoCapacityUpdatedEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipSpecialAmmoCapacityUpdatedEvent", "_MATCHER_SHIP_SPECIAL_AMMO_CAPACITY_UPDATED_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherShipSpecialAttackConfig
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipSpecialAttackConfig", "_MATCHER_SHIP_SPECIAL_ATTACK_CONFIG", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSideScrollingMode
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSideScrollingMode", "_MATCHER_SIDE_SCROLLING_MODE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSoundStatesReference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSoundStatesReference", "_MATCHER_SOUND_STATES_REFERENCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSource
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSource", "_MATCHER_SOURCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSourceTransform
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSourceTransform", "_MATCHER_SOURCE_TRANSFORM", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpawnerOverrideDuration
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpawnerOverrideDuration", "_MATCHER_SPAWNER_OVERRIDE_DURATION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpawnTableItem
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpawnTableItem", "_MATCHER_SPAWN_TABLE_ITEM", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpawnTextEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpawnTextEvent", "_MATCHER_SPAWN_TEXT_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpecialAudioPlay
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpecialAudioPlay", "_MATCHER_SPECIAL_AUDIO_PLAY", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpeedTween
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpeedTween", "_MATCHER_SPEED_TWEEN", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpellCastBlocked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpellCastBlocked", "_MATCHER_SPELL_CAST_BLOCKED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpellCommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpellCommand", "_MATCHER_SPELL_COMMAND", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpellConfig
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpellConfig", "_MATCHER_SPELL_CONFIG", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpellLevelConfig
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpellLevelConfig", "_MATCHER_SPELL_LEVEL_CONFIG", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpellReference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpellReference", "_MATCHER_SPELL_REFERENCE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpellTracker
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpellTracker", "_MATCHER_SPELL_TRACKER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSpirit
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSpirit", "_MATCHER_SPIRIT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSprinting
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSprinting", "_MATCHER_SPRINTING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherStarGuide
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherStarGuide", "_MATCHER_STAR_GUIDE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherStarGuideManager
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherStarGuideManager", "_MATCHER_STAR_GUIDE_MANAGER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherStopAddPlayerEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherStopAddPlayerEvent", "_MATCHER_STOP_ADD_PLAYER_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherStrafeLane
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherStrafeLane", "_MATCHER_STRAFE_LANE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherStrafeMovement
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherStrafeMovement", "_MATCHER_STRAFE_MOVEMENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherStrengthStat
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherStrengthStat", "_MATCHER_STRENGTH_STAT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSwapWeaponBlocked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSwapWeaponBlocked", "_MATCHER_SWAP_WEAPON_BLOCKED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherSwapWeaponCommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSwapWeaponCommand", "_MATCHER_SWAP_WEAPON_COMMAND", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTakeDamageEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTakeDamageEvent", "_MATCHER_TAKE_DAMAGE_EVENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTarget
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTarget", "_MATCHER_TARGET", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTargetGroup
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTargetGroup", "_MATCHER_TARGET_GROUP", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTargetList
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTargetList", "_MATCHER_TARGET_LIST", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTargetPosition
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTargetPosition", "_MATCHER_TARGET_POSITION", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTargetTransform
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTargetTransform", "_MATCHER_TARGET_TRANSFORM", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTeleportCallback
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTeleportCallback", "_MATCHER_TELEPORT_CALLBACK", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTerrainExploredCellsTable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTerrainExploredCellsTable", "_MATCHER_TERRAIN_EXPLORED_CELLS_TABLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTilt
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTilt", "_MATCHER_TILT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTiltSpeed
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTiltSpeed", "_MATCHER_TILT_SPEED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTimedBuff
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTimedBuff", "_MATCHER_TIMED_BUFF", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTimerCallback
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTimerCallback", "_MATCHER_TIMER_CALLBACK", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTimer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTimer", "_MATCHER_TIMER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTint
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTint", "_MATCHER_TINT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTrailRenderer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTrailRenderer", "_MATCHER_TRAIL_RENDERER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTransform
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTransform", "_MATCHER_TRANSFORM", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTransitioning
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTransitioning", "_MATCHER_TRANSITIONING", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTrap
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTrap", "_MATCHER_TRAP", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTriggerableInteractable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTriggerableInteractable", "_MATCHER_TRIGGERABLE_INTERACTABLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTriggerableInteractableType
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTriggerableInteractableType", "_MATCHER_TRIGGERABLE_INTERACTABLE_TYPE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTriggerHashSet
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTriggerHashSet", "_MATCHER_TRIGGER_HASH_SET", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherTurnSpeed
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTurnSpeed", "_MATCHER_TURN_SPEED", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherUndamageableUnit
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUndamageableUnit", "_MATCHER_UNDAMAGEABLE_UNIT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherUnequipItemCommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUnequipItemCommand", "_MATCHER_UNEQUIP_ITEM_COMMAND", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherUnitConfig
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUnitConfig", "_MATCHER_UNIT_CONFIG", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherUnitLevel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUnitLevel", "_MATCHER_UNIT_LEVEL", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherUnlockedEquipmentList
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUnlockedEquipmentList", "_MATCHER_UNLOCKED_EQUIPMENT_LIST", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherUnlockedShipBlueprints
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUnlockedShipBlueprints", "_MATCHER_UNLOCKED_SHIP_BLUEPRINTS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherUnlockedShipSpellTable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUnlockedShipSpellTable", "_MATCHER_UNLOCKED_SHIP_SPELL_TABLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherUnlockedSpellTable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUnlockedSpellTable", "_MATCHER_UNLOCKED_SPELL_TABLE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherUpdatedGunAmmo
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUpdatedGunAmmo", "_MATCHER_UPDATED_GUN_AMMO", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherUpdatedGunAmmoListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUpdatedGunAmmoListener", "_MATCHER_UPDATED_GUN_AMMO_LISTENER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherVelocityBuffer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherVelocityBuffer", "_MATCHER_VELOCITY_BUFFER", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherVFXFollowParent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherVFXFollowParent", "_MATCHER_VFX_FOLLOW_PARENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherVFXSpawnpoint
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherVFXSpawnpoint", "_MATCHER_VFX_SPAWNPOINT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherWallColliders
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWallColliders", "_MATCHER_WALL_COLLIDERS", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherWaterRipplesParticles
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWaterRipplesParticles", "_MATCHER_WATER_RIPPLES_PARTICLES", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherWaterTrait
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWaterTrait", "_MATCHER_WATER_TRAIT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherWaypoint
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWaypoint", "_MATCHER_WAYPOINT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherWorldUIButtonAnchorPosOffset
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldUIButtonAnchorPosOffset", "_MATCHER_WORLD_UI_BUTTON_ANCHOR_POS_OFFSET", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherWorldUIButtonAttachFlipSprite
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldUIButtonAttachFlipSprite", "_MATCHER_WORLD_UI_BUTTON_ATTACH_FLIP_SPRITE", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherWorldUIButtonAttachParent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldUIButtonAttachParent", "_MATCHER_WORLD_UI_BUTTON_ATTACH_PARENT", true)]

    //  interface static Entitas.IMatcher<GameEntity> _matcherXAxisOnly
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherXAxisOnly", "_MATCHER_X_AXIS_ONLY", true)]

    public partial class GameMatcher
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GameMatcher";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 77, 97, 116, 99, 104, 101, 114];

        //public const uint Const_TypeToken = 0x0200063AU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameMatcher(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameMatcher(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameMatcher obj) => obj._ptr;
            public static implicit operator bool(Ptr_GameMatcher obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."GameMatcher"]
    /// </summary>
    public partial class GameMatcher
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ActiveScreenEffectPlayer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ActiveScreenEffectPlayer")]
        /// static extern nint GET_ACTIVE_SCREEN_EFFECT_PLAYER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ActiveWeaponChangedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ActiveWeaponChangedEvent")]
        /// static extern nint GET_ACTIVE_WEAPON_CHANGED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AddPlayerEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AddPlayerEvent")]
        /// static extern nint GET_ADD_PLAYER_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AdvancedStatModifiers()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AdvancedStatModifiers")]
        /// static extern nint GET_ADVANCED_STAT_MODIFIERS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AgentDestination()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AgentDestination")]
        /// static extern nint GET_AGENT_DESTINATION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AgentPreviousDestination()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AgentPreviousDestination")]
        /// static extern nint GET_AGENT_PREVIOUS_DESTINATION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AnchorPosOffset()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AnchorPosOffset")]
        /// static extern nint GET_ANCHOR_POS_OFFSET ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AngleOffset()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AngleOffset")]
        /// static extern nint GET_ANGLE_OFFSET ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Animation()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Animation")]
        /// static extern nint GET_ANIMATION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AnimationDone()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AnimationDone")]
        /// static extern nint GET_ANIMATION_DONE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AnimationFlags()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AnimationFlags")]
        /// static extern nint GET_ANIMATION_FLAGS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AnimationProgress()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AnimationProgress")]
        /// static extern nint GET_ANIMATION_PROGRESS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Animator()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Animator")]
        /// static extern nint GET_ANIMATOR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AnyActiveWeaponChangedEventListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AnyActiveWeaponChangedEventListener")]
        /// static extern nint GET_ANY_ACTIVE_WEAPON_CHANGED_EVENT_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AnyShipEnterBlockedListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AnyShipEnterBlockedListener")]
        /// static extern nint GET_ANY_SHIP_ENTER_BLOCKED_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AnyShipEnterBlockedRemovedListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AnyShipEnterBlockedRemovedListener")]
        /// static extern nint GET_ANY_SHIP_ENTER_BLOCKED_REMOVED_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AoeCastingHit()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AoeCastingHit")]
        /// static extern nint GET_AOE_CASTING_HIT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AoeColliderType()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AoeColliderType")]
        /// static extern nint GET_AOE_COLLIDER_TYPE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AoeCollision()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AoeCollision")]
        /// static extern nint GET_AOE_COLLISION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AoeInfo()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AoeInfo")]
        /// static extern nint GET_AOE_INFO ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AoeTick()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AoeTick")]
        /// static extern nint GET_AOE_TICK ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AoeTickingHit()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AoeTickingHit")]
        /// static extern nint GET_AOE_TICKING_HIT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ArtPrefabReference()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ArtPrefabReference")]
        /// static extern nint GET_ART_PREFAB_REFERENCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AttachableFloat()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttachableFloat")]
        /// static extern nint GET_ATTACHABLE_FLOAT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AttachedProjectile()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttachedProjectile")]
        /// static extern nint GET_ATTACHED_PROJECTILE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AttachedVfxTracker()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttachedVfxTracker")]
        /// static extern nint GET_ATTACHED_VFX_TRACKER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AttackAnimation()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttackAnimation")]
        /// static extern nint GET_ATTACK_ANIMATION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AttackCommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttackCommand")]
        /// static extern nint GET_ATTACK_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AttackDoHit()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttackDoHit")]
        /// static extern nint GET_ATTACK_DO_HIT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AttackEventInfo()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttackEventInfo")]
        /// static extern nint GET_ATTACK_EVENT_INFO ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Attacking()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Attacking")]
        /// static extern nint GET_ATTACKING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AttackReference()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttackReference")]
        /// static extern nint GET_ATTACK_REFERENCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AttackTellView()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttackTellView")]
        /// static extern nint GET_ATTACK_TELL_VIEW ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AttackTint()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttackTint")]
        /// static extern nint GET_ATTACK_TINT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_AwardedQuestItems()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AwardedQuestItems")]
        /// static extern nint GET_AWARDED_QUEST_ITEMS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_BaseEnemyBehaviour()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BaseEnemyBehaviour")]
        /// static extern nint GET_BASE_ENEMY_BEHAVIOUR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_BehaviourTree()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BehaviourTree")]
        /// static extern nint GET_BEHAVIOUR_TREE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_BlockEffectCooldown()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BlockEffectCooldown")]
        /// static extern nint GET_BLOCK_EFFECT_COOLDOWN ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_BlockFreezeDuration()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BlockFreezeDuration")]
        /// static extern nint GET_BLOCK_FREEZE_DURATION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_BossTrait()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BossTrait")]
        /// static extern nint GET_BOSS_TRAIT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_BurnCounter()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BurnCounter")]
        /// static extern nint GET_BURN_COUNTER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CannonCooldown()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CannonCooldown")]
        /// static extern nint GET_CANNON_COOLDOWN ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Capsule()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Capsule")]
        /// static extern nint GET_CAPSULE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CharacterController()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CharacterController")]
        /// static extern nint GET_CHARACTER_CONTROLLER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CharacterGender()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CharacterGender")]
        /// static extern nint GET_CHARACTER_GENDER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ChargeAttacking()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ChargeAttacking")]
        /// static extern nint GET_CHARGE_ATTACKING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ChargeConfig()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ChargeConfig")]
        /// static extern nint GET_CHARGE_CONFIG ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ChargingAttack()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ChargingAttack")]
        /// static extern nint GET_CHARGING_ATTACK ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Chest()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Chest")]
        /// static extern nint GET_CHEST ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ChestInteractor()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ChestInteractor")]
        /// static extern nint GET_CHEST_INTERACTOR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CollatedAoeAttacks()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CollatedAoeAttacks")]
        /// static extern nint GET_COLLATED_AOE_ATTACKS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CollectibleCollectedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CollectibleCollectedEvent")]
        /// static extern nint GET_COLLECTIBLE_COLLECTED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CollectibleMagnetEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CollectibleMagnetEvent")]
        /// static extern nint GET_COLLECTIBLE_MAGNET_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CollectibleReference()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CollectibleReference")]
        /// static extern nint GET_COLLECTIBLE_REFERENCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Collider()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Collider")]
        /// static extern nint GET_COLLIDER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CombatAgent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CombatAgent", CallConvs = [typeof(CallConvCdecl)])]
        static extern nint GET_COMBAT_AGENT();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CombatAgentHealthUpdatedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CombatAgentHealthUpdatedEvent")]
        /// static extern nint GET_COMBAT_AGENT_HEALTH_UPDATED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CombatAgentList()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CombatAgentList")]
        /// static extern nint GET_COMBAT_AGENT_LIST ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CombatAggroDuration()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CombatAggroDuration")]
        /// static extern nint GET_COMBAT_AGGRO_DURATION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CombatChecked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CombatChecked")]
        /// static extern nint GET_COMBAT_CHECKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CombatLog()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CombatLog")]
        /// static extern nint GET_COMBAT_LOG ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CombatProxyAgent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CombatProxyAgent")]
        /// static extern nint GET_COMBAT_PROXY_AGENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Culled()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Culled")]
        /// static extern nint GET_CULLED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CulledVisuals()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CulledVisuals")]
        /// static extern nint GET_CULLED_VISUALS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CurrentChargerAttackEntities()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CurrentChargerAttackEntities")]
        /// static extern nint GET_CURRENT_CHARGER_ATTACK_ENTITIES ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CurrentProjectileHitEntities()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CurrentProjectileHitEntities")]
        /// static extern nint GET_CURRENT_PROJECTILE_HIT_ENTITIES ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CurrentSensorRadius()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CurrentSensorRadius")]
        /// static extern nint GET_CURRENT_SENSOR_RADIUS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CutSceneFastForward()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CutSceneFastForward")]
        /// static extern nint GET_CUT_SCENE_FAST_FORWARD ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CutSceneFastForwardBlocked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CutSceneFastForwardBlocked")]
        /// static extern nint GET_CUT_SCENE_FAST_FORWARD_BLOCKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_CutsceneOwner()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CutsceneOwner")]
        /// static extern nint GET_CUTSCENE_OWNER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_DashAttackCounter()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DashAttackCounter")]
        /// static extern nint GET_DASH_ATTACK_COUNTER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_DashAttackUnlocked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DashAttackUnlocked")]
        /// static extern nint GET_DASH_ATTACK_UNLOCKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_DeathEventProcessed()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DeathEventProcessed")]
        /// static extern nint GET_DEATH_EVENT_PROCESSED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_DestinationRelay()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DestinationRelay")]
        /// static extern nint GET_DESTINATION_RELAY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Destroyed()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Destroyed")]
        /// static extern nint GET_DESTROYED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Destructible()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Destructible")]
        /// static extern nint GET_DESTRUCTIBLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_DestructibleFX()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DestructibleFX")]
        /// static extern nint GET_DESTRUCTIBLE_FX ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_DialogueSpeaker()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DialogueSpeaker")]
        /// static extern nint GET_DIALOGUE_SPEAKER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Direction()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Direction")]
        /// static extern nint GET_DIRECTION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_DisableHitFlash()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DisableHitFlash")]
        /// static extern nint GET_DISABLE_HIT_FLASH ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_DockRepair()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DockRepair")]
        /// static extern nint GET_DOCK_REPAIR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_DockRepairBeacon()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DockRepairBeacon")]
        /// static extern nint GET_DOCK_REPAIR_BEACON ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_DockRepairOccupantsUpdatedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DockRepairOccupantsUpdatedEvent")]
        /// static extern nint GET_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Enemy()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Enemy")]
        /// static extern nint GET_ENEMY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EnemyAllegiance()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EnemyAllegiance")]
        /// static extern nint GET_ENEMY_ALLEGIANCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EnemyOwnedProxy()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EnemyOwnedProxy")]
        /// static extern nint GET_ENEMY_OWNED_PROXY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EnemyShipBehaviour()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EnemyShipBehaviour")]
        /// static extern nint GET_ENEMY_SHIP_BEHAVIOUR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EquipItemCommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EquipItemCommand")]
        /// static extern nint GET_EQUIP_ITEM_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Equipment()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Equipment")]
        /// static extern nint GET_EQUIPMENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EquipmentChangedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EquipmentChangedEvent")]
        /// static extern nint GET_EQUIPMENT_CHANGED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EquipmentEffects()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EquipmentEffects")]
        /// static extern nint GET_EQUIPMENT_EFFECTS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EquipmentItemData()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EquipmentItemData")]
        /// static extern nint GET_EQUIPMENT_ITEM_DATA ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EquipmentUpgradeShopInteractable()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EquipmentUpgradeShopInteractable")]
        /// static extern nint GET_EQUIPMENT_UPGRADE_SHOP_INTERACTABLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EquippedItems()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EquippedItems")]
        /// static extern nint GET_EQUIPPED_ITEMS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EquippedPlayerShipSpells()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EquippedPlayerShipSpells")]
        /// static extern nint GET_EQUIPPED_PLAYER_SHIP_SPELLS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EquippedShipBlueprints()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EquippedShipBlueprints")]
        /// static extern nint GET_EQUIPPED_SHIP_BLUEPRINTS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_EquippedSpells()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EquippedSpells")]
        /// static extern nint GET_EQUIPPED_SPELLS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_FacePlayerWhenFlee()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FacePlayerWhenFlee")]
        /// static extern nint GET_FACE_PLAYER_WHEN_FLEE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Facing()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Facing")]
        /// static extern nint GET_FACING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_FadeDuration()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FadeDuration")]
        /// static extern nint GET_FADE_DURATION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_FinalPoint()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FinalPoint")]
        /// static extern nint GET_FINAL_POINT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_FiringPoint()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FiringPoint")]
        /// static extern nint GET_FIRING_POINT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Fleeing()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Fleeing")]
        /// static extern nint GET_FLEEING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_FloatBlocked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FloatBlocked")]
        /// static extern nint GET_FLOAT_BLOCKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_FloatTransitionEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FloatTransitionEvent")]
        /// static extern nint GET_FLOAT_TRANSITION_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_FlyingTrait()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FlyingTrait")]
        /// static extern nint GET_FLYING_TRAIT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Foam()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Foam")]
        /// static extern nint GET_FOAM ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Following()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Following")]
        /// static extern nint GET_FOLLOWING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_FreezeFacing()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FreezeFacing")]
        /// static extern nint GET_FREEZE_FACING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_FSMInteractable()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FSMInteractable")]
        /// static extern nint GET_FSM_INTERACTABLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GameDestroyedListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameDestroyedListener")]
        /// static extern nint GET_GAME_DESTROYED_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GameDifficulty()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameDifficulty")]
        /// static extern nint GET_GAME_DIFFICULTY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GameDifficultyDamageModifier()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameDifficultyDamageModifier")]
        /// static extern nint GET_GAME_DIFFICULTY_DAMAGE_MODIFIER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GameDifficultyHeathModifier()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameDifficultyHeathModifier")]
        /// static extern nint GET_GAME_DIFFICULTY_HEATH_MODIFIER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GameEntityId()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameEntityId")]
        /// static extern nint GET_GAME_ENTITY_ID ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GameOverEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameOverEvent")]
        /// static extern nint GET_GAME_OVER_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GameOverNoSaveOverride()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameOverNoSaveOverride")]
        /// static extern nint GET_GAME_OVER_NO_SAVE_OVERRIDE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GlobalInteractBlocked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GlobalInteractBlocked")]
        /// static extern nint GET_GLOBAL_INTERACT_BLOCKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GraphicObjContainer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GraphicObjContainer")]
        /// static extern nint GET_GRAPHIC_OBJ_CONTAINER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GunAmmo()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GunAmmo")]
        /// static extern nint GET_GUN_AMMO ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GunReload()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GunReload")]
        /// static extern nint GET_GUN_RELOAD ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GunReloadProgress()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GunReloadProgress")]
        /// static extern nint GET_GUN_RELOAD_PROGRESS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GunReloadProgressListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GunReloadProgressListener")]
        /// static extern nint GET_GUN_RELOAD_PROGRESS_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_GunReloadTimer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GunReloadTimer")]
        /// static extern nint GET_GUN_RELOAD_TIMER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_HealCompletedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HealCompletedEvent")]
        /// static extern nint GET_HEAL_COMPLETED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Healer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Healer")]
        /// static extern nint GET_HEALER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_HealStartedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HealStartedEvent")]
        /// static extern nint GET_HEAL_STARTED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Health()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Health")]
        /// static extern nint GET_HEALTH ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_HealthRegenTickCounter()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HealthRegenTickCounter")]
        /// static extern nint GET_HEALTH_REGEN_TICK_COUNTER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_HealthStat()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HealthStat")]
        /// static extern nint GET_HEALTH_STAT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_HitStop()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HitStop")]
        /// static extern nint GET_HIT_STOP ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_HitStopEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HitStopEvent")]
        /// static extern nint GET_HIT_STOP_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_HitTarget()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HitTarget")]
        /// static extern nint GET_HIT_TARGET ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_HomingAroundSource()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HomingAroundSource")]
        /// static extern nint GET_HOMING_AROUND_SOURCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Id()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Id")]
        /// static extern nint GET_ID ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_IFrame()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IFrame")]
        /// static extern nint GET_I_FRAME ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Inactive()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Inactive")]
        /// static extern nint GET_INACTIVE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InActiveTrap()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InActiveTrap")]
        /// static extern nint GET_IN_ACTIVE_TRAP ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InCombatMode()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InCombatMode")]
        /// static extern nint GET_IN_COMBAT_MODE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InCutscene()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InCutscene")]
        /// static extern nint GET_IN_CUTSCENE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Infinity()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Infinity")]
        /// static extern nint GET_INFINITY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InfinityTowerTimer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InfinityTowerTimer")]
        /// static extern nint GET_INFINITY_TOWER_TIMER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InHealRegion()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InHealRegion")]
        /// static extern nint GET_IN_HEAL_REGION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InitialDirection()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InitialDirection")]
        /// static extern nint GET_INITIAL_DIRECTION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InitialPosition()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InitialPosition")]
        /// static extern nint GET_INITIAL_POSITION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InPotentialHealRegion()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InPotentialHealRegion")]
        /// static extern nint GET_IN_POTENTIAL_HEAL_REGION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InputStateCommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InputStateCommand")]
        /// static extern nint GET_INPUT_STATE_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InShip()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InShip")]
        /// static extern nint GET_IN_SHIP ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InstancePortal()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InstancePortal")]
        /// static extern nint GET_INSTANCE_PORTAL ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_IntCounter()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IntCounter")]
        /// static extern nint GET_INT_COUNTER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Interactable()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Interactable")]
        /// static extern nint GET_INTERACTABLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InteractableFailInteractableEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InteractableFailInteractableEvent")]
        /// static extern nint GET_INTERACTABLE_FAIL_INTERACTABLE_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InteractableFailValidateEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InteractableFailValidateEvent")]
        /// static extern nint GET_INTERACTABLE_FAIL_VALIDATE_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InteractableStatus()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InteractableStatus")]
        /// static extern nint GET_INTERACTABLE_STATUS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InteractableStatusUpdatedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InteractableStatusUpdatedEvent")]
        /// static extern nint GET_INTERACTABLE_STATUS_UPDATED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InteractableTriggeredTargetEntitiesUpdatedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InteractableTriggeredTargetEntitiesUpdatedEvent")]
        /// static extern nint GET_INTERACTABLE_TRIGGERED_TARGET_ENTITIES_UPDATED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InteractBlocked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InteractBlocked")]
        /// static extern nint GET_INTERACT_BLOCKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InteractCommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InteractCommand")]
        /// static extern nint GET_INTERACT_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InteractCommandUpdate()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InteractCommandUpdate")]
        /// static extern nint GET_INTERACT_COMMAND_UPDATE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InteractLookAt()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InteractLookAt")]
        /// static extern nint GET_INTERACT_LOOK_AT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InventoryCommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InventoryCommand")]
        /// static extern nint GET_INVENTORY_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InventoryLevel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InventoryLevel")]
        /// static extern nint GET_INVENTORY_LEVEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InventorySpellInfo()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InventorySpellInfo")]
        /// static extern nint GET_INVENTORY_SPELL_INFO ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Invincible()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Invincible")]
        /// static extern nint GET_INVINCIBLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_InvisibleWall()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InvisibleWall")]
        /// static extern nint GET_INVISIBLE_WALL ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_inWall()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inWall")]
        /// static extern nint GET_IN_WALL ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_inWater()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inWater")]
        /// static extern nint GET_IN_WATER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_JustSpawned()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_JustSpawned")]
        /// static extern nint GET_JUST_SPAWNED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Killed()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Killed")]
        /// static extern nint GET_KILLED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_KilledListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_KilledListener")]
        /// static extern nint GET_KILLED_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_KnockbackMultiplier()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_KnockbackMultiplier")]
        /// static extern nint GET_KNOCKBACK_MULTIPLIER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_LastBoss()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LastBoss")]
        /// static extern nint GET_LAST_BOSS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_LastSeenDuration()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LastSeenDuration")]
        /// static extern nint GET_LAST_SEEN_DURATION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_LatestInfinityTowerClearedWave()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LatestInfinityTowerClearedWave")]
        /// static extern nint GET_LATEST_INFINITY_TOWER_CLEARED_WAVE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Lifetime()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Lifetime")]
        /// static extern nint GET_LIFETIME ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_LifetimeTarget()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LifetimeTarget")]
        /// static extern nint GET_LIFETIME_TARGET ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_LocationData()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LocationData")]
        /// static extern nint GET_LOCATION_DATA ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_LootDropEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LootDropEvent")]
        /// static extern nint GET_LOOT_DROP_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_LootDropLevel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LootDropLevel")]
        /// static extern nint GET_LOOT_DROP_LEVEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_LootMagnet()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LootMagnet")]
        /// static extern nint GET_LOOT_MAGNET ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_LootMultiplier()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LootMultiplier")]
        /// static extern nint GET_LOOT_MULTIPLIER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_LootTable()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LootTable")]
        /// static extern nint GET_LOOT_TABLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_LootTimer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LootTimer")]
        /// static extern nint GET_LOOT_TIMER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MagicStat()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MagicStat")]
        /// static extern nint GET_MAGIC_STAT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MainSprite()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MainSprite")]
        /// static extern nint GET_MAIN_SPRITE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Mana()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Mana")]
        /// static extern nint GET_MANA ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ManaBar()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ManaBar")]
        /// static extern nint GET_MANA_BAR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MapIconDisplayLink()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapIconDisplayLink")]
        /// static extern nint GET_MAP_ICON_DISPLAY_LINK ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MapMarkerWorld()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapMarkerWorld")]
        /// static extern nint GET_MAP_MARKER_WORLD ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MapMarkerWorldIndex()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapMarkerWorldIndex")]
        /// static extern nint GET_MAP_MARKER_WORLD_INDEX ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MaxMoveSpeed()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MaxMoveSpeed")]
        /// static extern nint GET_MAX_MOVE_SPEED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MeleeAttackCommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MeleeAttackCommand")]
        /// static extern nint GET_MELEE_ATTACK_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Monster()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Monster")]
        /// static extern nint GET_MONSTER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MonsterBehaviour()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MonsterBehaviour")]
        /// static extern nint GET_MONSTER_BEHAVIOUR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MonsterCaptured()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MonsterCaptured")]
        /// static extern nint GET_MONSTER_CAPTURED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MonsterDetector()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MonsterDetector")]
        /// static extern nint GET_MONSTER_DETECTOR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MonsterDetectorInfo()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MonsterDetectorInfo")]
        /// static extern nint GET_MONSTER_DETECTOR_INFO ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MonsterDetectorRequestor()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MonsterDetectorRequestor")]
        /// static extern nint GET_MONSTER_DETECTOR_REQUESTOR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MonsterDetectorResultInfo()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MonsterDetectorResultInfo")]
        /// static extern nint GET_MONSTER_DETECTOR_RESULT_INFO ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MonsterTrait()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MonsterTrait")]
        /// static extern nint GET_MONSTER_TRAIT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_MoveSpeed()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MoveSpeed")]
        /// static extern nint GET_MOVE_SPEED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Moving()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Moving")]
        /// static extern nint GET_MOVING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_NavAgentTarget()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NavAgentTarget")]
        /// static extern nint GET_NAV_AGENT_TARGET ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_NavMeshAgent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NavMeshAgent")]
        /// static extern nint GET_NAV_MESH_AGENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_NavPath()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NavPath")]
        /// static extern nint GET_NAV_PATH ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_NotEnoughGunAmmoEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NotEnoughGunAmmoEvent")]
        /// static extern nint GET_NOT_ENOUGH_GUN_AMMO_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_NotEnoughGunAmmoEventListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NotEnoughGunAmmoEventListener")]
        /// static extern nint GET_NOT_ENOUGH_GUN_AMMO_EVENT_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_NPC()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NPC")]
        /// static extern nint GET_NPC ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ObjectiveInteractor()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ObjectiveInteractor")]
        /// static extern nint GET_OBJECTIVE_INTERACTOR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_OnDeathAnimCompleteEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnDeathAnimCompleteEvent")]
        /// static extern nint GET_ON_DEATH_ANIM_COMPLETE_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_OnDeathEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnDeathEvent")]
        /// static extern nint GET_ON_DEATH_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_OnHitIFrameData()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnHitIFrameData")]
        /// static extern nint GET_ON_HIT_I_FRAME_DATA ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_OnReviveCallback()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnReviveCallback")]
        /// static extern nint GET_ON_REVIVE_CALLBACK ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_OriginalLocalScale()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OriginalLocalScale")]
        /// static extern nint GET_ORIGINAL_LOCAL_SCALE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_OverlapList()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OverlapList")]
        /// static extern nint GET_OVERLAP_LIST ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_OverrideCharacterGender()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OverrideCharacterGender")]
        /// static extern nint GET_OVERRIDE_CHARACTER_GENDER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Owner()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Owner")]
        /// static extern nint GET_OWNER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ParticleEffect()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ParticleEffect")]
        /// static extern nint GET_PARTICLE_EFFECT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerAddedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerAddedEvent")]
        /// static extern nint GET_PLAYER_ADDED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerAllegiance()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerAllegiance")]
        /// static extern nint GET_PLAYER_ALLEGIANCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerCannotBeAggroed()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerCannotBeAggroed")]
        /// static extern nint GET_PLAYER_CANNOT_BE_AGGROED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerCharacter()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerCharacter")]
        /// static extern nint GET_PLAYER_CHARACTER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerControlled()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerControlled")]
        /// static extern nint GET_PLAYER_CONTROLLED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerFlinching()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerFlinching")]
        /// static extern nint GET_PLAYER_FLINCHING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerId()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerId")]
        /// static extern nint GET_PLAYER_ID ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerIdListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerIdListener")]
        /// static extern nint GET_PLAYER_ID_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerIdReference()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerIdReference")]
        /// static extern nint GET_PLAYER_ID_REFERENCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerIdRemovedListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerIdRemovedListener")]
        /// static extern nint GET_PLAYER_ID_REMOVED_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerKilledSource()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerKilledSource")]
        /// static extern nint GET_PLAYER_KILLED_SOURCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerOwnedProxy()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerOwnedProxy")]
        /// static extern nint GET_PLAYER_OWNED_PROXY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerReference()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerReference")]
        /// static extern nint GET_PLAYER_REFERENCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerRemovedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerRemovedEvent")]
        /// static extern nint GET_PLAYER_REMOVED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerShip()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerShip")]
        /// static extern nint GET_PLAYER_SHIP ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerShipHealthUpdatedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerShipHealthUpdatedEvent")]
        /// static extern nint GET_PLAYER_SHIP_HEALTH_UPDATED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerSleeping()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerSleeping")]
        /// static extern nint GET_PLAYER_SLEEPING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerSleepingSaveStone()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerSleepingSaveStone")]
        /// static extern nint GET_PLAYER_SLEEPING_SAVE_STONE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerStat()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerStat")]
        /// static extern nint GET_PLAYER_STAT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PlayerVicinity()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerVicinity")]
        /// static extern nint GET_PLAYER_VICINITY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PoolStatusTable()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PoolStatusTable")]
        /// static extern nint GET_POOL_STATUS_TABLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Position()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Position")]
        /// static extern nint GET_POSITION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PositionAttach()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PositionAttach")]
        /// static extern nint GET_POSITION_ATTACH ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PositionHistory()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PositionHistory")]
        /// static extern nint GET_POSITION_HISTORY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PositionTween()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PositionTween")]
        /// static extern nint GET_POSITION_TWEEN ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PreviouslyRolling()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PreviouslyRolling")]
        /// static extern nint GET_PREVIOUSLY_ROLLING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PreviouslyRunning()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PreviouslyRunning")]
        /// static extern nint GET_PREVIOUSLY_RUNNING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProcessingDestinationRelay()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProcessingDestinationRelay")]
        /// static extern nint GET_PROCESSING_DESTINATION_RELAY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Projectile()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Projectile")]
        /// static extern nint GET_PROJECTILE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProjectileBehaviour()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProjectileBehaviour")]
        /// static extern nint GET_PROJECTILE_BEHAVIOUR ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProjectileCollidable()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProjectileCollidable")]
        /// static extern nint GET_PROJECTILE_COLLIDABLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProjectileColliderInfo()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProjectileColliderInfo")]
        /// static extern nint GET_PROJECTILE_COLLIDER_INFO ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProjectileInfo()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProjectileInfo")]
        /// static extern nint GET_PROJECTILE_INFO ();



        /// <summary>
        /// static  Entitas.IAllOfMatcher<GameEntity> AllOf(System.Int32[] indices)
        /// </summary>
        /// <param name="indices">class System.Int32[]</param>
        /// <returns>interface Entitas.IAllOfMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AllOf", Search = typeof(Search_GameMatcher))]
        /// static extern nint ALL_OF_00 (nint indices);


        /// <summary>
        /// static  Entitas.IAllOfMatcher<GameEntity> AllOf(Entitas.IMatcher<GameEntity>[] matchers)
        /// </summary>
        /// <param name="matchers">class Entitas.IMatcher<GameEntity>[]</param>
        /// <returns>interface Entitas.IAllOfMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AllOf", Search = typeof(Search_GameMatcher))]
        /// static extern nint ALL_OF_01 (nint matchers);


        /// <summary>
        /// static  Entitas.IAnyOfMatcher<GameEntity> AnyOf(System.Int32[] indices)
        /// </summary>
        /// <param name="indices">class System.Int32[]</param>
        /// <returns>interface Entitas.IAnyOfMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AnyOf", Search = typeof(Search_GameMatcher))]
        /// static extern nint ANY_OF_00 (nint indices);


        /// <summary>
        /// static  Entitas.IAnyOfMatcher<GameEntity> AnyOf(Entitas.IMatcher<GameEntity>[] matchers)
        /// </summary>
        /// <param name="matchers">class Entitas.IMatcher<GameEntity>[]</param>
        /// <returns>interface Entitas.IAnyOfMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AnyOf", Search = typeof(Search_GameMatcher))]
        /// static extern nint ANY_OF_01 (nint matchers);


        /// public static partial class Search_GameMatcher
        /// {
        /// 
        ///     

        /// <summary>
        /// static  Entitas.IAllOfMatcher<GameEntity> AllOf(System.Int32[] indices)
        /// </summary>
        /// public static bool ALL_OF_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AllOf", "System.Int32[]");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  Entitas.IAllOfMatcher<GameEntity> AllOf(Entitas.IMatcher<GameEntity>[] matchers)
        /// </summary>
        /// public static bool ALL_OF_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AllOf", "Entitas.IMatcher<GameEntity>[]");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  Entitas.IAnyOfMatcher<GameEntity> AnyOf(System.Int32[] indices)
        /// </summary>
        /// public static bool ANY_OF_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AnyOf", "System.Int32[]");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  Entitas.IAnyOfMatcher<GameEntity> AnyOf(Entitas.IMatcher<GameEntity>[] matchers)
        /// </summary>
        /// public static bool ANY_OF_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AnyOf", "Entitas.IMatcher<GameEntity>[]");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["ProjectStar".""."GameMatcher"]
    /// </summary>
    public partial class GameMatcher
    {



        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProjectileMovement()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProjectileMovement")]
        /// static extern nint GET_PROJECTILE_MOVEMENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProjectileReference()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProjectileReference")]
        /// static extern nint GET_PROJECTILE_REFERENCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProjectileVfxReference()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProjectileVfxReference")]
        /// static extern nint GET_PROJECTILE_VFX_REFERENCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PromptAddPlayerEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PromptAddPlayerEvent")]
        /// static extern nint GET_PROMPT_ADD_PLAYER_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PromptRemovePlayerEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PromptRemovePlayerEvent")]
        /// static extern nint GET_PROMPT_REMOVE_PLAYER_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProxyDontDestroyOnCutscene()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProxyDontDestroyOnCutscene")]
        /// static extern nint GET_PROXY_DONT_DESTROY_ON_CUTSCENE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProxyTargetAllies()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProxyTargetAllies")]
        /// static extern nint GET_PROXY_TARGET_ALLIES ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProxyTargetEnemies()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProxyTargetEnemies")]
        /// static extern nint GET_PROXY_TARGET_ENEMIES ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ProxyTargetSelf()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ProxyTargetSelf")]
        /// static extern nint GET_PROXY_TARGET_SELF ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PuzzleAnswer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PuzzleAnswer")]
        /// static extern nint GET_PUZZLE_ANSWER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PuzzleAnswerCompletedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PuzzleAnswerCompletedEvent")]
        /// static extern nint GET_PUZZLE_ANSWER_COMPLETED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PuzzleAnswerState()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PuzzleAnswerState")]
        /// static extern nint GET_PUZZLE_ANSWER_STATE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PuzzleLootLocation()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PuzzleLootLocation")]
        /// static extern nint GET_PUZZLE_LOOT_LOCATION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PuzzlePieceID()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PuzzlePieceID")]
        /// static extern nint GET_PUZZLE_PIECE_ID ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PuzzlePieceInteractedCount()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PuzzlePieceInteractedCount")]
        /// static extern nint GET_PUZZLE_PIECE_INTERACTED_COUNT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_PuzzlePieceInteractedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PuzzlePieceInteractedEvent")]
        /// static extern nint GET_PUZZLE_PIECE_INTERACTED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_QuestFsm()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_QuestFsm")]
        /// static extern nint GET_QUEST_FSM ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_QuestFsmUpdateEveryFrame()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_QuestFsmUpdateEveryFrame")]
        /// static extern nint GET_QUEST_FSM_UPDATE_EVERY_FRAME ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_QuestFsmUpdateNextFrame()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_QuestFsmUpdateNextFrame")]
        /// static extern nint GET_QUEST_FSM_UPDATE_NEXT_FRAME ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_QuestFsmUpdateThisFrame()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_QuestFsmUpdateThisFrame")]
        /// static extern nint GET_QUEST_FSM_UPDATE_THIS_FRAME ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Recovery()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Recovery")]
        /// static extern nint GET_RECOVERY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_RemovePlayerEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RemovePlayerEvent")]
        /// static extern nint GET_REMOVE_PLAYER_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_RendererTinter()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RendererTinter")]
        /// static extern nint GET_RENDERER_TINTER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_RenderTransform()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RenderTransform")]
        /// static extern nint GET_RENDER_TRANSFORM ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_RespawnPlayersEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RespawnPlayersEvent")]
        /// static extern nint GET_RESPAWN_PLAYERS_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_RestTriggeredEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RestTriggeredEvent")]
        /// static extern nint GET_REST_TRIGGERED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Revivable()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Revivable")]
        /// static extern nint GET_REVIVABLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ReviveBeacon()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ReviveBeacon")]
        /// static extern nint GET_REVIVE_BEACON ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ReviveBeaconReference()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ReviveBeaconReference")]
        /// static extern nint GET_REVIVE_BEACON_REFERENCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ReviveEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ReviveEvent")]
        /// static extern nint GET_REVIVE_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Rigidbody()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Rigidbody")]
        /// static extern nint GET_RIGIDBODY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_RollBlocked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RollBlocked")]
        /// static extern nint GET_ROLL_BLOCKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_RollCommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RollCommand")]
        /// static extern nint GET_ROLL_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_RollCooldown()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RollCooldown")]
        /// static extern nint GET_ROLL_COOLDOWN ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_RollCount()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RollCount")]
        /// static extern nint GET_ROLL_COUNT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Rolling()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Rolling")]
        /// static extern nint GET_ROLLING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_RotationTween()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RotationTween")]
        /// static extern nint GET_ROTATION_TWEEN ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SaveParrotDestructibleCollider()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SaveParrotDestructibleCollider")]
        /// static extern nint GET_SAVE_PARROT_DESTRUCTIBLE_COLLIDER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SaveStone()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SaveStone")]
        /// static extern nint GET_SAVE_STONE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SaveStoneInRange()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SaveStoneInRange")]
        /// static extern nint GET_SAVE_STONE_IN_RANGE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SaveStoneUpdateEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SaveStoneUpdateEvent")]
        /// static extern nint GET_SAVE_STONE_UPDATE_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ScreenEffect()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ScreenEffect")]
        /// static extern nint GET_SCREEN_EFFECT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ScreenEffectPlayer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ScreenEffectPlayer")]
        /// static extern nint GET_SCREEN_EFFECT_PLAYER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SecondPlayer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SecondPlayer")]
        /// static extern nint GET_SECOND_PLAYER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SelectedTavernTalesData()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SelectedTavernTalesData")]
        /// static extern nint GET_SELECTED_TAVERN_TALES_DATA ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SelfHealing()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SelfHealing")]
        /// static extern nint GET_SELF_HEALING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Shadow()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Shadow")]
        /// static extern nint GET_SHADOW ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShieldBlocking()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShieldBlocking")]
        /// static extern nint GET_SHIELD_BLOCKING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShieldReflective()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShieldReflective")]
        /// static extern nint GET_SHIELD_REFLECTIVE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Ship()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Ship")]
        /// static extern nint GET_SHIP ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipBlueprintEffects()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipBlueprintEffects")]
        /// static extern nint GET_SHIP_BLUEPRINT_EFFECTS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipBlueprintItemData()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipBlueprintItemData")]
        /// static extern nint GET_SHIP_BLUEPRINT_ITEM_DATA ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipBlueprintsRefreshedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipBlueprintsRefreshedEvent")]
        /// static extern nint GET_SHIP_BLUEPRINTS_REFRESHED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipBoost()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipBoost")]
        /// static extern nint GET_SHIP_BOOST ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipCannon()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipCannon")]
        /// static extern nint GET_SHIP_CANNON ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipCannonAttackConfig()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipCannonAttackConfig")]
        /// static extern nint GET_SHIP_CANNON_ATTACK_CONFIG ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipCannonRotationDelta()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipCannonRotationDelta")]
        /// static extern nint GET_SHIP_CANNON_ROTATION_DELTA ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipConfig()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipConfig")]
        /// static extern nint GET_SHIP_CONFIG ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipDock()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipDock")]
        /// static extern nint GET_SHIP_DOCK ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipEnterBlocked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipEnterBlocked")]
        /// static extern nint GET_SHIP_ENTER_BLOCKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipEnterCamFocusRuntimeScreenEffect()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipEnterCamFocusRuntimeScreenEffect")]
        /// static extern nint GET_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipEnterEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipEnterEvent")]
        /// static extern nint GET_SHIP_ENTER_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipExitEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipExitEvent")]
        /// static extern nint GET_SHIP_EXIT_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipExitSensorRange()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipExitSensorRange")]
        /// static extern nint GET_SHIP_EXIT_SENSOR_RANGE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipFeedbackState()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipFeedbackState")]
        /// static extern nint GET_SHIP_FEEDBACK_STATE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipInteriorEnterEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipInteriorEnterEvent")]
        /// static extern nint GET_SHIP_INTERIOR_ENTER_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipMovementPoint()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipMovementPoint")]
        /// static extern nint GET_SHIP_MOVEMENT_POINT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipPassengerUpdatedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipPassengerUpdatedEvent")]
        /// static extern nint GET_SHIP_PASSENGER_UPDATED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipPathAgent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipPathAgent")]
        /// static extern nint GET_SHIP_PATH_AGENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipReference()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipReference")]
        /// static extern nint GET_SHIP_REFERENCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipSailInfo()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipSailInfo")]
        /// static extern nint GET_SHIP_SAIL_INFO ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipSpecialAmmoCapacityUpdatedEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipSpecialAmmoCapacityUpdatedEvent")]
        /// static extern nint GET_SHIP_SPECIAL_AMMO_CAPACITY_UPDATED_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_ShipSpecialAttackConfig()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipSpecialAttackConfig")]
        /// static extern nint GET_SHIP_SPECIAL_ATTACK_CONFIG ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SideScrollingMode()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SideScrollingMode")]
        /// static extern nint GET_SIDE_SCROLLING_MODE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SoundStatesReference()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SoundStatesReference")]
        /// static extern nint GET_SOUND_STATES_REFERENCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Source()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Source")]
        /// static extern nint GET_SOURCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SourceTransform()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SourceTransform")]
        /// static extern nint GET_SOURCE_TRANSFORM ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SpawnerOverrideDuration()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpawnerOverrideDuration")]
        /// static extern nint GET_SPAWNER_OVERRIDE_DURATION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SpawnTableItem()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpawnTableItem")]
        /// static extern nint GET_SPAWN_TABLE_ITEM ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SpawnTextEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpawnTextEvent")]
        /// static extern nint GET_SPAWN_TEXT_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SpecialAudioPlay()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpecialAudioPlay")]
        /// static extern nint GET_SPECIAL_AUDIO_PLAY ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SpeedTween()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpeedTween")]
        /// static extern nint GET_SPEED_TWEEN ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SpellCastBlocked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpellCastBlocked")]
        /// static extern nint GET_SPELL_CAST_BLOCKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SpellCommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpellCommand")]
        /// static extern nint GET_SPELL_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SpellConfig()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpellConfig")]
        /// static extern nint GET_SPELL_CONFIG ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SpellLevelConfig()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpellLevelConfig")]
        /// static extern nint GET_SPELL_LEVEL_CONFIG ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SpellReference()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpellReference")]
        /// static extern nint GET_SPELL_REFERENCE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SpellTracker()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SpellTracker")]
        /// static extern nint GET_SPELL_TRACKER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Spirit()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Spirit")]
        /// static extern nint GET_SPIRIT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Sprinting()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Sprinting")]
        /// static extern nint GET_SPRINTING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_StarGuide()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_StarGuide")]
        /// static extern nint GET_STAR_GUIDE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_StarGuideManager()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_StarGuideManager")]
        /// static extern nint GET_STAR_GUIDE_MANAGER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_StopAddPlayerEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_StopAddPlayerEvent")]
        /// static extern nint GET_STOP_ADD_PLAYER_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_StrafeLane()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_StrafeLane")]
        /// static extern nint GET_STRAFE_LANE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_StrafeMovement()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_StrafeMovement")]
        /// static extern nint GET_STRAFE_MOVEMENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_StrengthStat()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_StrengthStat")]
        /// static extern nint GET_STRENGTH_STAT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SwapWeaponBlocked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SwapWeaponBlocked")]
        /// static extern nint GET_SWAP_WEAPON_BLOCKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_SwapWeaponCommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SwapWeaponCommand")]
        /// static extern nint GET_SWAP_WEAPON_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TakeDamageEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TakeDamageEvent")]
        /// static extern nint GET_TAKE_DAMAGE_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Target()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Target")]
        /// static extern nint GET_TARGET ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TargetGroup()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TargetGroup")]
        /// static extern nint GET_TARGET_GROUP ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TargetList()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TargetList")]
        /// static extern nint GET_TARGET_LIST ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TargetPosition()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TargetPosition")]
        /// static extern nint GET_TARGET_POSITION ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TargetTransform()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TargetTransform")]
        /// static extern nint GET_TARGET_TRANSFORM ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TeleportCallback()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TeleportCallback")]
        /// static extern nint GET_TELEPORT_CALLBACK ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TerrainExploredCellsTable()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TerrainExploredCellsTable")]
        /// static extern nint GET_TERRAIN_EXPLORED_CELLS_TABLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Tilt()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Tilt")]
        /// static extern nint GET_TILT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TiltSpeed()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TiltSpeed")]
        /// static extern nint GET_TILT_SPEED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TimedBuff()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TimedBuff")]
        /// static extern nint GET_TIMED_BUFF ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Timer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Timer")]
        /// static extern nint GET_TIMER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TimerCallback()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TimerCallback")]
        /// static extern nint GET_TIMER_CALLBACK ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Tint()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Tint")]
        /// static extern nint GET_TINT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TrailRenderer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TrailRenderer")]
        /// static extern nint GET_TRAIL_RENDERER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Transform()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Transform")]
        /// static extern nint GET_TRANSFORM ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Transitioning()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Transitioning")]
        /// static extern nint GET_TRANSITIONING ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Trap()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Trap")]
        /// static extern nint GET_TRAP ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TriggerableInteractable()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TriggerableInteractable")]
        /// static extern nint GET_TRIGGERABLE_INTERACTABLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TriggerableInteractableType()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TriggerableInteractableType")]
        /// static extern nint GET_TRIGGERABLE_INTERACTABLE_TYPE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TriggerHashSet()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TriggerHashSet")]
        /// static extern nint GET_TRIGGER_HASH_SET ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_TurnSpeed()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TurnSpeed")]
        /// static extern nint GET_TURN_SPEED ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_UndamageableUnit()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UndamageableUnit")]
        /// static extern nint GET_UNDAMAGEABLE_UNIT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_UnequipItemCommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UnequipItemCommand")]
        /// static extern nint GET_UNEQUIP_ITEM_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_UnitConfig()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UnitConfig")]
        /// static extern nint GET_UNIT_CONFIG ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_UnitLevel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UnitLevel")]
        /// static extern nint GET_UNIT_LEVEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_UnlockedEquipmentList()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UnlockedEquipmentList")]
        /// static extern nint GET_UNLOCKED_EQUIPMENT_LIST ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_UnlockedShipBlueprints()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UnlockedShipBlueprints")]
        /// static extern nint GET_UNLOCKED_SHIP_BLUEPRINTS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_UnlockedShipSpellTable()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UnlockedShipSpellTable")]
        /// static extern nint GET_UNLOCKED_SHIP_SPELL_TABLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_UnlockedSpellTable()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UnlockedSpellTable")]
        /// static extern nint GET_UNLOCKED_SPELL_TABLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_UpdatedGunAmmo()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UpdatedGunAmmo")]
        /// static extern nint GET_UPDATED_GUN_AMMO ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_UpdatedGunAmmoListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UpdatedGunAmmoListener")]
        /// static extern nint GET_UPDATED_GUN_AMMO_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_VelocityBuffer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_VelocityBuffer")]
        /// static extern nint GET_VELOCITY_BUFFER ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_VFXFollowParent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_VFXFollowParent")]
        /// static extern nint GET_VFX_FOLLOW_PARENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_VFXSpawnpoint()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_VFXSpawnpoint")]
        /// static extern nint GET_VFX_SPAWNPOINT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_WallColliders()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WallColliders")]
        /// static extern nint GET_WALL_COLLIDERS ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_WaterRipplesParticles()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WaterRipplesParticles")]
        /// static extern nint GET_WATER_RIPPLES_PARTICLES ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_WaterTrait()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WaterTrait")]
        /// static extern nint GET_WATER_TRAIT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_Waypoint()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Waypoint")]
        /// static extern nint GET_WAYPOINT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_WorldUIButtonAnchorPosOffset()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldUIButtonAnchorPosOffset")]
        /// static extern nint GET_WORLD_UI_BUTTON_ANCHOR_POS_OFFSET ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_WorldUIButtonAttachFlipSprite()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldUIButtonAttachFlipSprite")]
        /// static extern nint GET_WORLD_UI_BUTTON_ATTACH_FLIP_SPRITE ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_WorldUIButtonAttachParent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldUIButtonAttachParent")]
        /// static extern nint GET_WORLD_UI_BUTTON_ATTACH_PARENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GameEntity> get_XAxisOnly()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_XAxisOnly")]
        /// static extern nint GET_X_AXIS_ONLY ();




        /// public static partial class Search_GameMatcher
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}