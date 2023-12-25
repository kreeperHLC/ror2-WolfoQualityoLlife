using Mono.Cecil.Cil;
using MonoMod.Cil;
using R2API;
using RoR2;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace WolfoQualityOfLife
{
    public class RedMercSkin
    {
        //These were for double checking or smth ideally they should become obsolete
        //public static uint MercSkinExpose = 255;
        public static bool MercExposeIsRed = false;
        //public static uint MercSkinPrimary = 255;
        //public static uint MercSkinSecondary = 255;
        //public static uint MercSkinSecondaryAlt = 255;
        //public static uint MercSkinUtility = 255;
        //public static uint MercSkinUtilityAlt = 255;
        //public static uint MercSkinSpecial = 255;
        //public static uint MercSkinSpecialAlt = 255;

        //public static Texture2D texRampHuntressSoft = null;
        //public static Texture2D texRampHuntressSoftRed = null;

        public static Material matMercDelayedBillboard2Red = null;
        public static Material matMercFocusedAssaultIconRed = null;
        public static Material matMercExposedBackdropRed = null;

        public static Material matMercSwipe1Red = null;
        public static Material matMercSwipe2Red = null;
        public static Material matMercSwipe3Red = null;

        public static Material matMercIgnitionRed = null;

        public static Material matMercExposedSlashRed = null;
        public static Material matOmniHitspark3MercRed = null;
        public static Material matOmniRadialSlash1MercRed = null;
        public static Material matOmniHitspark4MercRed = null;


        //public static Material matMercEnergized = RoR2.LegacyResourcesAPI.Load<Material>("materials/matMercEnergized");
        public static Material matMercEnergizedRed = UnityEngine.Object.Instantiate(RoR2.LegacyResourcesAPI.Load<Material>("materials/matMercEnergized"));
        //public static Material matMercEvisTarget = RoR2.LegacyResourcesAPI.Load<Material>("materials/matMercEvisTarget"); //Visual desplayed over the enemies being hit I guess
        public static Material matMercEvisTargetRed = UnityEngine.Object.Instantiate(RoR2.LegacyResourcesAPI.Load<Material>("materials/matMercEvisTarget"));
        //public static Material matMercHologram = RoR2.LegacyResourcesAPI.Load<Material>("materials/matMercHologram");
        public static Material matMercHologramRed = RoR2.LegacyResourcesAPI.Load<Material>("materials/matMercHologram");


        //public static Material matHuntressFlashBright = RoR2.LegacyResourcesAPI.Load<Material>("materials/matHuntressFlashBright");
        public static Material matHuntressFlashBrightRed = UnityEngine.Object.Instantiate(RoR2.LegacyResourcesAPI.Load<Material>("materials/matHuntressFlashBright"));
        //public static Material matHuntressFlashExpanded = RoR2.LegacyResourcesAPI.Load<Material>("materials/matHuntressFlashExpanded");
        public static Material matHuntressFlashExpandedRed = UnityEngine.Object.Instantiate(RoR2.LegacyResourcesAPI.Load<Material>("materials/matHuntressFlashExpanded"));

        public static GameObject MercFocusedAssaultOrbEffectRed = R2API.PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/effects/orbeffects/MercFocusedAssaultOrbEffect"), "MercFocusedAssaultOrbEffectRed", false);

        //public static GameObject OmniImpactVFXSlashMerc = null; //Primary, Secondary1, Secondary2
        //public static GameObject MercSwordSlash = null; //Primary
        //public static GameObject MercSwordFinisherSlash = null; //Primary, Special2

        //public static GameObject MercSwordSlashWhirlwind = null;  //Secondary1
        //public static GameObject MercDashHitOverlay = null; //Utility1, Utility2

        //public static GameObject MercSwordUppercutSlash = null;  //Secondary2


        public static GameObject OmniImpactVFXSlashMercRed = null; //Primary, Secondary1, Secondary2
        public static GameObject MercSwordSlashRed = null; //Primary
        public static GameObject MercSwordFinisherSlashRed = null; //Primary, Special2

        public static GameObject MercSwordSlashWhirlwindRed = null;  //Secondary1
        public static GameObject MercDashHitOverlayRed = null; //Utility1, Utility2



        //public static GameObject HuntressBlinkEffect = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/effects/HuntressBlinkEffect"); //Special1 (Enter)
        public static GameObject HuntressBlinkEffectRed = R2API.PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/effects/HuntressBlinkEffect"), "HuntressBlinkEffectRed", false); //Special1 (Enter)

        //public static GameObject HuntressFireArrowRain = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/effects/muzzleflashes/HuntressFireArrowRain"); //Special1 (Attack)
        public static GameObject HuntressFireArrowRainRed = R2API.PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/effects/muzzleflashes/HuntressFireArrowRain"), "HuntressFireArrowRainRed", false); //Special1 (Attack)

        //public static GameObject OmniImpactVFXSlashMercEvis = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/effects/omnieffect/OmniImpactVFXSlashMercEvis"); //Special1 (Attack)
        public static GameObject OmniImpactVFXSlashMercEvisRed = R2API.PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/effects/omnieffect/OmniImpactVFXSlashMercEvis"), "OmniImpactVFXSlashMercEvisRed", false); //Special1 (Attack)

        public static Material matHuntressSwipeRed;
        public static Material matHuntressChargedRed;



        public static GameObject MercSwordUppercutSlashRed = null;  //Secondary2
        public static GameObject ImpactMercFocusedAssaultRed = null;  //Utility2
        public static GameObject ImpactMercAssaulterRed = null;  //Utility2
        public static GameObject MercAssaulterEffectRed = null;  //Utility2

        public static GameObject EvisProjectileRed = R2API.PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/projectiles/EvisProjectile"), "EvisProjectileRed", true);  //Special2
        public static GameObject EvisProjectileGhostRed = R2API.PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/projectileghosts/EvisProjectileGhost"), "EvisProjectileGhostRed", false);
        public static GameObject EvisOverlapProjectileRed = R2API.PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/projectiles/EvisOverlapProjectile"), "EvisOverlapProjectileRed", true);
        public static GameObject EvisOverlapProjectileGhostRed = R2API.PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/projectileghosts/EvisOverlapProjectileGhost"), "EvisOverlapProjectileGhostRed", false);

        public static GameObject ImpactMercEvisRed = R2API.PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/effects/impacteffects/ImpactMercEvis"), "ImpactMercEvisRed", false);

        //public static Material matMercExposed;
        public static Material matMercExposedRed;
        //public static Material matMercExposedBackdrop;

        //Needs to be static
        public static GameObject MercExposeEffect = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/temporaryvisualeffects/MercExposeEffect");
        public static GameObject MercExposeConsumeEffect = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/effects/impacteffects/MercExposeConsumeEffect");
        public static GameObject MercExposeEffectRed = R2API.PrefabAPI.InstantiateClone(MercExposeEffect, "MercExposeEffectRed", false);
        public static GameObject MercExposeConsumeEffectRed = R2API.PrefabAPI.InstantiateClone(MercExposeConsumeEffect, "MercExposeConsumeEffectRed", false);



        public static void Start()
        {
            MercSwordSlashRed = R2API.PrefabAPI.InstantiateClone(Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/MercSwordSlash.prefab").WaitForCompletion(), "MercSwordSlashRed", false);

            //MercSwordFinisherSlash = Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/MercSwordFinisherSlash.prefab").WaitForCompletion();
            MercSwordFinisherSlashRed = R2API.PrefabAPI.InstantiateClone(Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/MercSwordFinisherSlash.prefab").WaitForCompletion(), "MercSwordFinisherSlashRed", false);

            //MercSwordSlashWhirlwind = Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/MercSwordSlashWhirlwind.prefab").WaitForCompletion();
            MercSwordSlashWhirlwindRed = R2API.PrefabAPI.InstantiateClone(Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/MercSwordSlashWhirlwind.prefab").WaitForCompletion(), "MercSwordSlashWhirlwindRed", false);
            R2API.ContentAddition.AddEffect(MercSwordSlashWhirlwindRed);

            //MercSwordUppercutSlash = Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/MercSwordUppercutSlash.prefab").WaitForCompletion();
            MercSwordUppercutSlashRed = R2API.PrefabAPI.InstantiateClone(Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/MercSwordUppercutSlash.prefab").WaitForCompletion(), "MercSwordUppercutSlashRed", false);
            R2API.ContentAddition.AddEffect(MercSwordUppercutSlashRed);

            //OmniImpactVFXSlashMerc = Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/OmniImpactVFXSlashMerc.prefab").WaitForCompletion();
            OmniImpactVFXSlashMercRed = R2API.PrefabAPI.InstantiateClone(Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/OmniImpactVFXSlashMerc.prefab").WaitForCompletion(), "OmniImpactVFXSlashMercRed", false);
            R2API.ContentAddition.AddEffect(OmniImpactVFXSlashMercRed);

            //OmniImpactVFXSlashMerc = Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/MercAssaulterEffect.prefab").WaitForCompletion();
            MercAssaulterEffectRed = R2API.PrefabAPI.InstantiateClone(Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/MercAssaulterEffect.prefab").WaitForCompletion(), "MercAssaulterEffectRed", false);
            //R2API.ContentAddition.AddEffect(MercAssaulterEffectRed);

            MercDashHitOverlayRed = R2API.PrefabAPI.InstantiateClone(Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/MercDashHitOverlay.prefab").WaitForCompletion(), "MercDashHitOverlayRed", false);
            //R2API.ContentAddition.AddEffect(MercDashHitOverlayRed);

            ImpactMercAssaulterRed = R2API.PrefabAPI.InstantiateClone(Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/ImpactMercAssaulter.prefab").WaitForCompletion(), "ImpactMercAssaulterRed", false);
            R2API.ContentAddition.AddEffect(ImpactMercAssaulterRed);

            ImpactMercFocusedAssaultRed = R2API.PrefabAPI.InstantiateClone(Addressables.LoadAssetAsync<GameObject>(key: "RoR2/Base/Merc/ImpactMercFocusedAssault.prefab").WaitForCompletion(), "ImpactMercFocusedAssaultRed", false);
            R2API.ContentAddition.AddEffect(ImpactMercFocusedAssaultRed);


            MercRedEffects();
            RedMercHooks();
            if (WConfig.cfgSkinMercRed.Value == true)
            { }
        }


        public static void RedMercHooks()
        {

            SkinDef SkinDefMercOni = Addressables.LoadAssetAsync<SkinDef>(key: "RoR2/Base/Merc/skinMercAlt.asset").WaitForCompletion();

            //Replace this
            if (WConfig.cfgSkinMercRed.Value == true)
            {
                Texture2D texMercOniBlues = new Texture2D(128, 128, TextureFormat.DXT5, false);
                texMercOniBlues.LoadImage(Properties.Resources.texMercOniBlues, true);
                texMercOniBlues.filterMode = FilterMode.Bilinear;
                Sprite texMercOniBluesS = Sprite.Create(texMercOniBlues, v.rec128, v.half);

                LoadoutAPI.SkinDefInfo SkinDefMercOniOriginalSkinInfo = new LoadoutAPI.SkinDefInfo
                {
                    BaseSkins = SkinDefMercOni.baseSkins,
                    Icon = texMercOniBluesS,
                    NameToken = "Oni Traditional",
                    //UnlockableDef = SkinDefMercOni.unlockableDef,
                    RootObject = SkinDefMercOni.rootObject,
                    RendererInfos = SkinDefMercOni.rendererInfos,
                    MeshReplacements = SkinDefMercOni.meshReplacements,
                    GameObjectActivations = SkinDefMercOni.gameObjectActivations,
                    ProjectileGhostReplacements = SkinDefMercOni.projectileGhostReplacements,
                    MinionSkinReplacements = SkinDefMercOni.minionSkinReplacements,
                    Name = "skinMercAltNoEdit",
                };
                LoadoutAPI.AddSkinToCharacter(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/CharacterBodies/MercBody"), SkinDefMercOniOriginalSkinInfo);

            }





            ////Putting it in the attack hooks so it works on Clients too
            //Expose Visual
            //I don't think I can really make these work
            //IL.RoR2.CharacterBody.UpdateAllTemporaryVisualEffects += CharacterBody_UpdateAllTemporaryVisualEffects;
            //IL.RoR2.HealthComponent.TakeDamage += HealthComponent_TakeDamage;

            //This does not run on servers
            /*On.RoR2.HealthComponent.TakeDamage += (orig, self, damageInfo) =>
            {
                orig(self, damageInfo);

                if (damageInfo.damageType == DamageType.ApplyMercExpose)
                {
                    if (damageInfo.attacker.GetComponent<MakeThisMercRed>())
                    {
                        RoR2.CharacterBody.AssetReferences.mercExposeEffectPrefab = MercExposeEffectRed;
                        RoR2.HealthComponent.AssetReferences.mercExposeConsumeEffectPrefab = MercExposeConsumeEffectRed;
                    }
                    else
                    {
                        RoR2.CharacterBody.AssetReferences.mercExposeEffectPrefab = MercExposeEffect;
                        RoR2.HealthComponent.AssetReferences.mercExposeConsumeEffectPrefab = MercExposeConsumeEffect;
                    }
                }
            };*/

            //This is probably more annoying to run than just hooking into some of the Merc Abilities and doing it there
            /*
            On.RoR2.GlobalEventManager.OnHitEnemy += (orig, self, damageInfo, victim) =>
            {
                orig(self, damageInfo, victim);

                if (damageInfo.damageType == DamageType.ApplyMercExpose)
                {
                    if (damageInfo.attacker.GetComponent<MakeThisMercRed>())
                    {
                        RoR2.CharacterBody.AssetReferences.mercExposeEffectPrefab = MercExposeEffectRed;
                        RoR2.HealthComponent.AssetReferences.mercExposeConsumeEffectPrefab = MercExposeConsumeEffectRed;
                    }
                    else
                    {
                        RoR2.CharacterBody.AssetReferences.mercExposeEffectPrefab = MercExposeEffect;
                        RoR2.HealthComponent.AssetReferences.mercExposeConsumeEffectPrefab = MercExposeConsumeEffect;
                    }
                }

            };*/



            //Primary
            On.EntityStates.Merc.Weapon.GroundLight2.OnEnter += (orig, self) =>
            {
                if (self.gameObject.GetComponent<MakeThisMercRed>())
                {
                    self.hitEffectPrefab = OmniImpactVFXSlashMercRed;
                    self.swingEffectPrefab = MercSwordSlashRed;
                    //EntityStates.Merc.Weapon.GroundLight2.comboFinisherSwingEffectPrefab = MercSwordFinisherSlashRed;
                }
                //EntityStates.Merc.Weapon.GroundLight2.comboFinisherSwingEffectPrefab = MercSwordFinisherSlash;
                orig(self);
            };
            IL.EntityStates.Merc.Weapon.GroundLight2.OnEnter += GroundLight2_OnEnter;

            //Secondary
            IL.EntityStates.Merc.WhirlwindBase.OnEnter += WhirlwindBase_OnEnter;
            IL.EntityStates.Merc.WhirlwindBase.FixedUpdate += WhirlwindBase_FixedUpdate;

            //Alt Secondary
            IL.EntityStates.Merc.Uppercut.OnEnter += Uppercut_OnEnter;
            IL.EntityStates.Merc.Uppercut.FixedUpdate += Uppercut_FixedUpdate;

            //Utility 
            IL.EntityStates.Merc.Assaulter2.OnEnter += Assaulter2_OnEnter;
            On.EntityStates.Merc.Assaulter2.OnEnter += (orig, self) =>
            {
                if (self.gameObject.GetComponent<MakeThisMercRed>())
                {
                    self.hitEffectPrefab = OmniImpactVFXSlashMercRed;
                    self.swingEffectPrefab = MercAssaulterEffectRed;
                }
                orig(self);
            };



            //Utility Alt
            On.EntityStates.Merc.FocusedAssaultDash.OnEnter += (orig, self) =>
            {
                if (self.gameObject.GetComponent<MakeThisMercRed>())
                {
                    self.delayedEffectPrefab = ImpactMercFocusedAssaultRed;
                    self.hitEffectPrefab = ImpactMercAssaulterRed;
                    //self.selfOnHitOverlayEffectPrefab = MercDashHitOverlayRed;
                    self.swingEffectPrefab = MercAssaulterEffectRed;
                    self.enterOverlayMaterial = matMercEnergizedRed;
                    self.orbEffect = MercFocusedAssaultOrbEffectRed;
                    RoR2.CharacterBody.AssetReferences.mercExposeEffectPrefab = MercExposeEffectRed;
                    RoR2.HealthComponent.AssetReferences.mercExposeConsumeEffectPrefab = MercExposeConsumeEffectRed;
                }
                else
                {
                    RoR2.CharacterBody.AssetReferences.mercExposeEffectPrefab = MercExposeEffect;
                    RoR2.HealthComponent.AssetReferences.mercExposeConsumeEffectPrefab = MercExposeConsumeEffect;
                }

                orig(self);
            };


            //Utility Dash
            IL.EntityStates.Merc.EvisDash.FixedUpdate += MercRed_Utility1; //Hopefully works better

            //Special Evis
            IL.EntityStates.Merc.Evis.CreateBlinkEffect += MercRed_SpecialEvis;
            IL.EntityStates.Merc.Evis.FixedUpdate += Evis_FixedUpdate;
            IL.EntityStates.Merc.Evis.OnExit += Evis_OnExit;

            //self.outer.commonComponents.characterBody.skinIndex == 1
            //Yeah I have no idea how I'd change this for IL so I could replace the Ghost after the Projectile gets instantiated or smth
            On.EntityStates.Merc.Weapon.ThrowEvisProjectile.OnEnter += (orig, self) =>
            {
                self.effectPrefab = null; //It can't spawn this because it's not an effect for both blue&red
                if (self.gameObject.GetComponent<MakeThisMercRed>())
                {
                    //self.effectPrefab = MercSwordFinisherSlashRed; 
                    self.projectilePrefab = EvisProjectileRed; //Replace Ghost Prefab not actual projectile
                    RoR2.CharacterBody.AssetReferences.mercExposeEffectPrefab = MercExposeEffectRed;
                    RoR2.HealthComponent.AssetReferences.mercExposeConsumeEffectPrefab = MercExposeConsumeEffectRed;
                }
                else
                {
                    RoR2.CharacterBody.AssetReferences.mercExposeEffectPrefab = MercExposeEffect;
                    RoR2.HealthComponent.AssetReferences.mercExposeConsumeEffectPrefab = MercExposeConsumeEffect;
                }
                orig(self);
            };
        }

        private static void Evis_OnExit(ILContext il)
        {
            ILCursor c = new ILCursor(il);

            if (c.TryGotoNext(MoveType.Before,
                    x => x.MatchStfld("RoR2.TemporaryOverlay", "originalMaterial")))
            {
                //First one is matMercEvisTarget probably not needed
                c.Index += 4;
                c.TryGotoNext(MoveType.Before,
                x => x.MatchStfld("RoR2.TemporaryOverlay", "originalMaterial"));
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<Material, EntityStates.Merc.EvisDash, Material>>((material, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        return matHuntressFlashExpandedRed;
                    }
                    return material;
                });
                //Debug.Log("IL Found: Red Merc: IL.EntityStates.Merc.Evis.OnExit");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: IL.EntityStates.Merc.Evis.OnExit");
            }
        }

        private static void HealthComponent_TakeDamage(ILContext il)
        {
            ILCursor c = new ILCursor(il);
            if (c.TryGotoNext(MoveType.After,
            x => x.MatchLdsfld("RoR2.HealthComponent/AssetReferences", "mercExposeConsumeEffectPrefab")))
            {
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<GameObject, CharacterBody, GameObject>>((target, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        return MercExposeConsumeEffect;
                    }
                    return target;
                });
                //Debug.Log("IL Found: Red Merc: HealthComponent_TakeDamage");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: HealthComponent_TakeDamage");
            }
        }

        private static void CharacterBody_UpdateAllTemporaryVisualEffects(ILContext il)
        {
            ILCursor c = new ILCursor(il);
            if (c.TryGotoNext(MoveType.After,
            x => x.MatchLdsfld("RoR2.CharacterBody/AssetReferences", "mercExposeEffectPrefab")))
            {
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<GameObject, CharacterBody, GameObject>>((target, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {

                        return MercExposeEffectRed;
                    }
                    return target;
                });
                //Debug.Log("IL Found: Red Merc: CharacterBody_UpdateAllTemporaryVisualEffects");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: CharacterBody_UpdateAllTemporaryVisualEffects");
            }
        }

        private static void GroundLight2_OnEnter(ILContext il)
        {
            ILCursor c = new ILCursor(il);
            if (c.TryGotoNext(MoveType.After,
            x => x.MatchLdsfld("EntityStates.Merc.Weapon.GroundLight2", "comboFinisherSwingEffectPrefab")))
            {
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<GameObject, EntityStates.Merc.Weapon.GroundLight2, GameObject>>((target, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        RoR2.CharacterBody.AssetReferences.mercExposeEffectPrefab = MercExposeEffectRed;
                        RoR2.HealthComponent.AssetReferences.mercExposeConsumeEffectPrefab = MercExposeConsumeEffectRed;
                        return MercSwordFinisherSlashRed;
                    }
                    else
                    {
                        RoR2.CharacterBody.AssetReferences.mercExposeEffectPrefab = MercExposeEffect;
                        RoR2.HealthComponent.AssetReferences.mercExposeConsumeEffectPrefab = MercExposeConsumeEffect;
                    }
                    return target;
                });
                //Debug.Log("IL Found: Red Merc: GroundLight2_OnEnter");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: GroundLight2_OnEnter");
            }
        }

        private static void WhirlwindBase_FixedUpdate(ILContext il)
        {
            ILCursor c = new ILCursor(il);
            if (c.TryGotoNext(MoveType.After,
            x => x.MatchLdsfld("EntityStates.Merc.WhirlwindBase", "swingEffectPrefab")))
            {
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<GameObject, EntityStates.Merc.WhirlwindBase, GameObject>>((target, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        return MercSwordSlashWhirlwindRed;
                    }
                    return target;
                });
                //Debug.Log("IL Found: Red Merc: WhirlwindBase_FixedUpdate");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: WhirlwindBase_FixedUpdate");
            }
        }

        private static void WhirlwindBase_OnEnter(ILContext il)
        {
            ILCursor c = new ILCursor(il);
            if (c.TryGotoNext(MoveType.After,
            x => x.MatchLdsfld("EntityStates.Merc.WhirlwindBase", "hitEffectPrefab")))
            {
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<GameObject, EntityStates.Merc.WhirlwindBase, GameObject>>((target, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        return OmniImpactVFXSlashMercRed;
                    }
                    return target;
                });
                //Debug.Log("IL Found: Red Merc: WhirlwindBase_OnEnter");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: WhirlwindBase_OnEnter");
            }
        }

        private static void Uppercut_FixedUpdate(ILContext il)
        {
            ILCursor c = new ILCursor(il);

            if (c.TryGotoNext(MoveType.After,
            x => x.MatchLdsfld("EntityStates.Merc.Uppercut", "swingEffectPrefab")))
            {
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<GameObject, EntityStates.Merc.Uppercut, GameObject>>((target, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        return MercSwordUppercutSlashRed;
                    }
                    return target;
                });
                //Debug.Log("IL Found: Red Merc: Uppercut_FixedUpdate");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: Uppercut_FixedUpdate");
            }
        }

        private static void Uppercut_OnEnter(ILContext il)
        {
            ILCursor c = new ILCursor(il);
            if (c.TryGotoNext(MoveType.After,
            x => x.MatchLdsfld("EntityStates.Merc.Uppercut", "hitEffectPrefab")))
            {
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<GameObject, EntityStates.Merc.Uppercut, GameObject>>((target, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        return OmniImpactVFXSlashMercRed;
                    }
                    return target;
                });
                //Debug.Log("IL Found: Red Merc: Uppercut_OnEnter");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: Uppercut_OnEnter");
            }
        }

        private static void Assaulter2_OnEnter(ILContext il)
        {
            ILCursor c = new ILCursor(il);

            if (c.TryGotoNext(MoveType.Before,
            x => x.MatchStfld("RoR2.TemporaryOverlay", "originalMaterial")))
            {
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<Material, EntityStates.Merc.EvisDash, Material>>((material, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        return matMercEnergizedRed;
                    }
                    return material;
                });
                //Debug.Log("IL Found: Red Merc: Assaulter2_OnEnter");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: Assaulter2_OnEnter");
            }
        }

        private static void MercRed_SpecialEvis(ILContext il)
        {
            ILCursor c = new ILCursor(il);

            if (c.TryGotoNext(MoveType.After,
                    x => x.MatchLdsfld("EntityStates.Merc.Evis", "blinkPrefab")))
            {
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<GameObject, EntityStates.Merc.EvisDash, GameObject>>((target, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        return HuntressFireArrowRainRed;
                    }
                    return target;
                });
                //Debug.Log("IL Found: Red Merc: Evis.CreateBlinkEffect");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: Evis.CreateBlinkEffect");
            }
        }

        private static void Evis_FixedUpdate(ILContext il)
        {
            ILCursor c = new ILCursor(il);

            if (c.TryGotoNext(MoveType.After,
                    x => x.MatchLdsfld("EntityStates.Merc.Evis", "hitEffectPrefab")))
            {
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<GameObject, EntityStates.Merc.EvisDash, GameObject>>((target, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        return OmniImpactVFXSlashMercEvisRed;
                    }
                    return target;
                });
                //Debug.Log("IL Found: Red Merc: Evis_FixedUpdate");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: Evis_FixedUpdate");
            }
        }

        public static void MercRed_Utility1(MonoMod.Cil.ILContext il)
        {
            ILCursor c = new ILCursor(il);

            if (c.TryGotoNext(MoveType.Before,
                    x => x.MatchStfld("RoR2.TemporaryOverlay", "originalMaterial")))
            {
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<Material, EntityStates.Merc.EvisDash, Material>>((material, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        return matHuntressFlashBrightRed;
                    }
                    return material;
                });
                c.Index += 4;
                c.TryGotoNext(MoveType.Before,
                x => x.MatchStfld("RoR2.TemporaryOverlay", "originalMaterial"));
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<Material, EntityStates.Merc.EvisDash, Material>>((material, entityState) =>
                {
                    if (entityState.gameObject.GetComponent<MakeThisMercRed>())
                    {
                        return matHuntressFlashExpandedRed;
                    }
                    return material;
                });
                //Debug.Log("IL Found: Red Merc: Merc.EvisDash.FixedUpdate");
            }
            else
            {
                Debug.LogWarning("IL Failed: Red Merc: Merc.EvisDash.FixedUpdate");
            }
        }

        [Obsolete]
        public static void MercRedEffects()
        {
            matHuntressFlashBrightRed.SetColor("_TintColor", new Color(1.3f, 0.6f, 0.6f, 1f));//0.0191 1.1386 1.2973 1 
            matHuntressFlashExpandedRed.SetColor("_TintColor", new Color(0.58f, 0.2f, 0.2f, 1f));//0 0.4367 0.5809 1

            Texture2D texRampFallbootsRed = new Texture2D(256, 16, TextureFormat.DXT1, false);
            texRampFallbootsRed.LoadImage(Properties.Resources.texRampFallbootsRed, true);
            texRampFallbootsRed.filterMode = FilterMode.Bilinear;
            texRampFallbootsRed.wrapMode = TextureWrapMode.Clamp;

            Texture2D texRampMercDustRed = new Texture2D(128, 4, TextureFormat.DXT5, false);
            texRampMercDustRed.LoadImage(Properties.Resources.texRampMercDustRed, true);
            texRampMercDustRed.filterMode = FilterMode.Bilinear;
            texRampMercDustRed.wrapMode = TextureWrapMode.Clamp;

            /*texRampHuntressSoft = new Texture2D(256, 16, TextureFormat.DXT5, false);
            texRampHuntressSoft.LoadImage(Properties.Resources.texRampHuntressSoft, true);
            texRampHuntressSoft.wrapMode = TextureWrapMode.Clamp;
            texRampHuntressSoft.filterMode = FilterMode.Point;*/

            Texture2D texRampHuntressSoftRed = null;
            texRampHuntressSoftRed = new Texture2D(256, 16, TextureFormat.DXT5, false);
            texRampHuntressSoftRed.LoadImage(Properties.Resources.texRampHuntressSoftRed, true);
            texRampHuntressSoftRed.wrapMode = TextureWrapMode.Clamp;
            texRampHuntressSoftRed.filterMode = FilterMode.Point;

            Texture2D texRampHuntressRed = new Texture2D(256, 16, TextureFormat.DXT1, false);
            texRampHuntressRed.LoadImage(Properties.Resources.texRampHuntressRed, true);
            texRampHuntressRed.wrapMode = TextureWrapMode.Clamp;
            texRampHuntressRed.filterMode = FilterMode.Point;

            ParticleSystemRenderer MercSwordSlashRedRenderer0 = MercSwordSlashRed.transform.GetChild(0).GetComponent<ParticleSystemRenderer>();
            matMercSwipe1Red = UnityEngine.Object.Instantiate(MercSwordSlashRedRenderer0.material);
            matMercSwipe1Red.SetTexture("_RemapTex", texRampFallbootsRed);
            matMercSwipe1Red.SetColor("_TintColor", new Color(1, 0, 0, 1));        //Default Color : {r: 0, g: 0.314069, b: 1, a: 1}
            MercSwordSlashRedRenderer0.material = matMercSwipe1Red;

            //Child 0 has weird TracerBright
            ParticleSystem MercSwordFinisherSlashRedParticle0 = MercSwordFinisherSlashRed.transform.GetChild(0).GetComponent<ParticleSystem>();
            MercSwordFinisherSlashRedParticle0.startColor = new Color(1, 0.2f, 0.2f, 1);
            ParticleSystemRenderer MercSwordFinisherSlashRedRenderer1 = MercSwordFinisherSlashRed.transform.GetChild(1).GetComponent<ParticleSystemRenderer>();
            matMercSwipe2Red = UnityEngine.Object.Instantiate(MercSwordFinisherSlashRedRenderer1.material);
            matMercSwipe2Red.SetTexture("_RemapTex", texRampFallbootsRed);
            matMercSwipe2Red.SetColor("_TintColor", new Color(1, 0.22f, 0.22f, 1));  //Default Color r: 0.3632075, g: 0.6593511, b: 1, a: 1
            MercSwordFinisherSlashRedRenderer1.material = matMercSwipe2Red;

            ParticleSystemRenderer MercSwordSlashWhirlwindRedRenderer0 = MercSwordSlashWhirlwindRed.transform.GetChild(0).GetComponent<ParticleSystemRenderer>();
            MercSwordSlashWhirlwindRedRenderer0.material = matMercSwipe1Red;

            ParticleSystemRenderer MercSwordUppercutSlashRedRenderer0 = MercSwordUppercutSlashRed.transform.GetChild(0).GetComponent<ParticleSystemRenderer>();
            ParticleSystemRenderer MercSwordUppercutSlashRedRenderer1 = MercSwordUppercutSlashRed.transform.GetChild(1).GetComponent<ParticleSystemRenderer>();
            MercSwordUppercutSlashRedRenderer0.material = matMercSwipe2Red;
            MercSwordUppercutSlashRedRenderer1.material = matMercSwipe1Red;




            OmniEffect OmniImpactVFXSlashMercRedOmniEffect = OmniImpactVFXSlashMercRed.GetComponent<OmniEffect>();


            //Material matOmniHitspark4Merc = UnityEngine.Object.Instantiate(OmniImpactVFXSlashMercRedOmniEffect.omniEffectGroups[1].omniEffectElements[0].particleSystemOverrideMaterial);
            //OmniImpactVFXSlashMercRedOmniEffect.omniEffectGroups[1].omniEffectElements[0].particleSystemOverrideMaterial = matOmniHitspark4Merc;

            Material matOmniRadialSlash1Merc = UnityEngine.Object.Instantiate(OmniImpactVFXSlashMercRedOmniEffect.omniEffectGroups[3].omniEffectElements[1].particleSystemOverrideMaterial);
            matOmniRadialSlash1Merc.SetTexture("_RemapTex", texRampMercDustRed);
            OmniImpactVFXSlashMercRedOmniEffect.omniEffectGroups[3].omniEffectElements[1].particleSystemOverrideMaterial = matOmniRadialSlash1Merc;

            Material matOmniHitspark3Merc = UnityEngine.Object.Instantiate(OmniImpactVFXSlashMercRedOmniEffect.omniEffectGroups[4].omniEffectElements[1].particleSystemOverrideMaterial);
            matOmniHitspark3Merc.SetTexture("_RemapTex", texRampMercDustRed);
            OmniImpactVFXSlashMercRedOmniEffect.omniEffectGroups[4].omniEffectElements[1].particleSystemOverrideMaterial = matOmniHitspark3Merc;

            Material matOmniHitspark2MercRed = UnityEngine.Object.Instantiate(OmniImpactVFXSlashMercRedOmniEffect.omniEffectGroups[6].omniEffectElements[0].particleSystemOverrideMaterial);
            matOmniHitspark2MercRed.SetTexture("_RemapTex", texRampMercDustRed);
            OmniImpactVFXSlashMercRedOmniEffect.omniEffectGroups[6].omniEffectElements[0].particleSystemOverrideMaterial = matOmniHitspark2MercRed;

            ParticleSystem OmniImpactVFXSlashMercRedParticle1 = OmniImpactVFXSlashMercRed.transform.GetChild(1).GetComponent<ParticleSystem>(); //matOmniHitspark3 (Instance)
            OmniImpactVFXSlashMercRedParticle1.startColor = new Color(0.7264f, 0.3f, 0.3f, 1); //Default C0lor 0 0.7264 0.7039 1

            ParticleSystem OmniImpactVFXSlashMercRedParticle2 = OmniImpactVFXSlashMercRed.transform.GetChild(2).GetComponent<ParticleSystem>(); //matGenericFlash (Instance)
            OmniImpactVFXSlashMercRedParticle2.startColor = new Color(0.9333f, 0.2f, 0.2f, 1); //0 0.4951 0.9333 1

            ParticleSystem OmniImpactVFXSlashMercRedParticle3 = OmniImpactVFXSlashMercRed.transform.GetChild(3).GetComponent<ParticleSystem>(); //matTracerBright (Instance)
            OmniImpactVFXSlashMercRedParticle3.startColor = new Color(0.5f, 0.4245f, 0.0501f, 1); //0.3854 0.4245 0.0501 1





            //Figure out if start color needs to actually be changed because they all use it
            ParticleSystemRenderer MercAssaulterEffectRedRenderer5 = MercAssaulterEffectRed.transform.GetChild(5).GetComponent<ParticleSystemRenderer>();
            matMercIgnitionRed = UnityEngine.Object.Instantiate(MercAssaulterEffectRedRenderer5.material);
            matMercIgnitionRed.SetTexture("_RemapTex", texRampHuntressRed);
            matMercIgnitionRed.SetColor("_TintColor", new Color(0.8867924f, 0.06f, 0.06f, 1)); //{r: 0, g: 0.1362783, b: 0.8867924, a: 1}
            MercAssaulterEffectRedRenderer5.material = matMercIgnitionRed;

            MercAssaulterEffectRed.transform.GetChild(6).GetComponent<ParticleSystem>().startColor = new Color(1f, 0.3f, 0.3f, 1); //0 0.4409 0.9811 1
            MercAssaulterEffectRed.transform.GetChild(8).GetComponent<Light>().color = new Color(0.9804f, 0.3765f, 0.4868f, 1); //0.3765 0.4868 0.9804 1
            MercAssaulterEffectRed.transform.GetChild(9).GetComponent<TrailRenderer>().material = matMercSwipe1Red;
            MercAssaulterEffectRed.transform.GetChild(10).GetChild(2).GetComponent<TrailRenderer>().material = matMercIgnitionRed;
            MercAssaulterEffectRed.transform.GetChild(10).GetChild(3).GetComponent<TrailRenderer>().material = matMercIgnitionRed;




            ParticleSystem particleSystem = ImpactMercAssaulterRed.transform.GetChild(0).GetComponent<ParticleSystem>();
            particleSystem.startColor = new Color(1f, 0.45f, 0.45f, 1f);//0.3538 0.6316 1 1
            particleSystem = ImpactMercAssaulterRed.transform.GetChild(1).GetComponent<ParticleSystem>();
            particleSystem.startColor = new Color(1f, 0.575f, 0.575f, 1f);//0.467 0.7022 1 1

            ParticleSystemRenderer particleSystemRenderer = ImpactMercAssaulterRed.transform.GetChild(2).GetComponent<ParticleSystemRenderer>();
            particleSystemRenderer.material = matMercSwipe1Red;




            particleSystem = ImpactMercFocusedAssaultRed.transform.GetChild(0).GetComponent<ParticleSystem>();
            particleSystem.startColor = new Color(1f, 0.45f, 0.45f, 0.2667f);//0.3538 0.6316 1 0.2667
            particleSystem = ImpactMercFocusedAssaultRed.transform.GetChild(1).GetComponent<ParticleSystem>();
            particleSystem.startColor = new Color(0.934f, 0.26f, 0.26f, 1f);//0.0925 0.4637 0.934 1
            particleSystemRenderer = ImpactMercFocusedAssaultRed.transform.GetChild(2).GetComponent<ParticleSystemRenderer>();
            matMercSwipe3Red = UnityEngine.Object.Instantiate(particleSystemRenderer.material);
            matMercSwipe3Red.SetTexture("_RemapTex", texRampMercDustRed);
            particleSystemRenderer.material = matMercSwipe3Red;



            particleSystemRenderer = MercFocusedAssaultOrbEffectRed.transform.GetChild(0).GetComponent<ParticleSystemRenderer>();
            matMercDelayedBillboard2Red = UnityEngine.Object.Instantiate(particleSystemRenderer.material);
            matMercDelayedBillboard2Red.SetTexture("_RemapTex", texRampMercDustRed);
            particleSystemRenderer.material = matMercDelayedBillboard2Red;

            particleSystemRenderer = MercFocusedAssaultOrbEffectRed.transform.GetChild(1).GetComponent<ParticleSystemRenderer>();
            matMercFocusedAssaultIconRed = UnityEngine.Object.Instantiate(particleSystemRenderer.material);
            matMercFocusedAssaultIconRed.SetTexture("_RemapTex", texRampMercDustRed);
            particleSystemRenderer.material = matMercFocusedAssaultIconRed;

            particleSystemRenderer = MercFocusedAssaultOrbEffectRed.transform.GetChild(2).GetComponent<ParticleSystemRenderer>();
            matMercExposedBackdropRed = UnityEngine.Object.Instantiate(particleSystemRenderer.material);
            //matMercExposedBackdrop = UnityEngine.Object.Instantiate(particleSystemRenderer.material);
            matMercExposedBackdropRed.SetColor("_TintColor", new Color(3, -2, -2, 0.9f));
            particleSystemRenderer.material = matMercExposedBackdropRed;

            particleSystemRenderer = MercFocusedAssaultOrbEffectRed.transform.GetChild(3).GetComponent<ParticleSystemRenderer>();
            matMercExposedSlashRed = UnityEngine.Object.Instantiate(particleSystemRenderer.material);
            matMercExposedSlashRed.SetTexture("_RemapTex", texRampHuntressRed);
            matMercExposedSlashRed.SetColor("_TintColor", new Color(0.8868f, 0.06f, 0.06f, 1)); //r: 0, g: 0.1362783, b: 0.8867924, a: 1
            particleSystemRenderer.material = matMercExposedSlashRed;

            R2API.ContentAddition.AddEffect(MercFocusedAssaultOrbEffectRed);

            matMercEnergizedRed.SetTexture("_RemapTex", texRampHuntressSoftRed);
            matMercEnergizedRed.SetColor("_TintColor", new Color(1.8f, 0.35f, 0.35f, 1));



            //HuntressBlinkEffectRed
            particleSystem = HuntressBlinkEffectRed.transform.GetChild(0).GetChild(0).GetComponent<ParticleSystem>();
            particleSystem.startColor = new Color(0.6324f, 0.154f, 0.154f, 1f);//0.1534 0.1567 0.6324 1
            //particleSystem.colorOverLifetime.SetPropertyValue<bool>("enabled", false);
            var stupid = particleSystem.colorOverLifetime;
            stupid.enabled = false;
            //particleSystem.SetPropertyValue("colorOverLifetime", stupid);

            Light light = HuntressBlinkEffectRed.transform.GetChild(0).GetChild(2).GetComponent<Light>();
            light.color = new Color(1f, 0.6f, 0.6f, 1); //0.2721 0.9699 1 1

            particleSystemRenderer = HuntressBlinkEffectRed.transform.GetChild(0).GetChild(4).GetComponent<ParticleSystemRenderer>();
            matHuntressSwipeRed = UnityEngine.Object.Instantiate(particleSystemRenderer.material);
            matHuntressSwipeRed.SetTexture("_RemapTex", texRampHuntressSoftRed);
            particleSystemRenderer.material = matHuntressSwipeRed;

            particleSystemRenderer = HuntressBlinkEffectRed.transform.GetChild(0).GetChild(5).GetComponent<ParticleSystemRenderer>();
            particleSystemRenderer.material = matHuntressSwipeRed;
            R2API.ContentAddition.AddEffect(HuntressBlinkEffectRed);
            //

            //HuntressFireArrowRainRed
            particleSystemRenderer = HuntressFireArrowRainRed.transform.GetChild(2).GetComponent<ParticleSystemRenderer>();
            particleSystemRenderer.material = matHuntressSwipeRed;

            particleSystemRenderer = HuntressFireArrowRainRed.transform.GetChild(3).GetComponent<ParticleSystemRenderer>();
            particleSystemRenderer.material = matHuntressSwipeRed;

            particleSystemRenderer = HuntressFireArrowRainRed.transform.GetChild(4).GetComponent<ParticleSystemRenderer>();
            matHuntressChargedRed = UnityEngine.Object.Instantiate(particleSystemRenderer.material);
            matHuntressChargedRed.SetTexture("_RemapTex", texRampHuntressRed);
            particleSystemRenderer.material = matHuntressChargedRed;

            light = HuntressFireArrowRainRed.transform.GetChild(5).GetComponent<Light>();
            light.color = new Color(1f, 0.55f, 0.55f, 1f); //0.3456 0.7563 1 1
            R2API.ContentAddition.AddEffect(HuntressFireArrowRainRed);
            //

            //OmniImpactVFXSlashMercEvisRed
            OmniEffect omniEffect = OmniImpactVFXSlashMercEvisRed.GetComponent<OmniEffect>();

            omniEffect.omniEffectGroups[1].omniEffectElements[0].particleSystemOverrideMaterial = matOmniHitspark4MercRed;




            matOmniRadialSlash1MercRed = UnityEngine.Object.Instantiate(omniEffect.omniEffectGroups[3].omniEffectElements[1].particleSystemOverrideMaterial);
            matOmniRadialSlash1MercRed.SetTexture("_RemapTex", texRampMercDustRed);

            omniEffect.omniEffectGroups[3].omniEffectElements[1].particleSystemOverrideMaterial = matOmniRadialSlash1MercRed;


            omniEffect.omniEffectGroups[4].omniEffectElements[1].particleSystemOverrideMaterial = matOmniHitspark3MercRed;
            omniEffect.omniEffectGroups[6].omniEffectElements[0].particleSystemOverrideMaterial = matOmniHitspark2MercRed;

            particleSystemRenderer = OmniImpactVFXSlashMercEvisRed.transform.GetChild(7).GetComponent<ParticleSystemRenderer>();
            matMercHologramRed = UnityEngine.Object.Instantiate(particleSystemRenderer.material);
            matMercHologramRed.SetTexture("_RemapTex", texRampFallbootsRed);
            matMercHologramRed.SetColor("_TintColor", new Color(1.825f, -0.25f, 0f, 1f));//0.2842 0.4328 1.826 1
            particleSystemRenderer.material = matMercHologramRed;


            R2API.ContentAddition.AddEffect(OmniImpactVFXSlashMercEvisRed);




            EvisProjectileRed.GetComponent<RoR2.Projectile.ProjectileController>().ghostPrefab = EvisProjectileGhostRed;
            EvisProjectileRed.GetComponent<RoR2.Projectile.ProjectileImpactExplosion>().impactEffect = MercSwordFinisherSlashRed;
            EvisProjectileRed.GetComponent<RoR2.Projectile.ProjectileImpactExplosion>().childrenProjectilePrefab = EvisOverlapProjectileRed;
            R2API.ContentAddition.AddProjectile(EvisProjectileRed);


            EvisOverlapProjectileRed.GetComponent<RoR2.Projectile.ProjectileController>().ghostPrefab = EvisOverlapProjectileGhostRed;
            EvisOverlapProjectileRed.GetComponent<RoR2.Projectile.ProjectileOverlapAttack>().impactEffect = ImpactMercEvisRed;


            EvisProjectileGhostRed.transform.GetChild(0).GetComponent<ParticleSystemRenderer>().material = matMercSwipe2Red;
            EvisProjectileGhostRed.transform.GetChild(1).GetComponent<ParticleSystemRenderer>().material = matMercSwipe1Red;
            EvisProjectileGhostRed.transform.GetChild(2).GetComponent<ParticleSystemRenderer>().material = matMercIgnitionRed;
            EvisProjectileGhostRed.transform.GetChild(3).GetComponent<ParticleSystem>().startColor = new Color(1f, 0f, 0f, 1f); //0 0.5827 1 1
            EvisProjectileGhostRed.transform.GetChild(5).GetComponent<Light>().color = new Color(1f, 0.3f, 0.3f, 1f); //0.1274 0.4704 1 1


            EvisOverlapProjectileGhostRed.transform.GetChild(0).GetComponent<ParticleSystemRenderer>().material = matMercSwipe2Red;
            EvisOverlapProjectileGhostRed.transform.GetChild(1).GetComponent<ParticleSystemRenderer>().material = matOmniRadialSlash1MercRed;
            EvisOverlapProjectileGhostRed.transform.GetChild(2).GetComponent<ParticleSystemRenderer>().material = matOmniHitspark2MercRed;
            EvisOverlapProjectileGhostRed.transform.GetChild(3).GetComponent<ParticleSystem>().startColor = new Color(1f, 0.51f, 0.51f, 1f);//0.3066 0.7276 1 1
            EvisOverlapProjectileGhostRed.transform.GetChild(4).GetComponent<Light>().color = new Color(1f, 0.3f, 0.3f, 1f);//0.1274 0.4704 1 1
            EvisOverlapProjectileGhostRed.transform.GetChild(5).GetComponent<ParticleSystemRenderer>().material = matMercHologramRed;
            EvisOverlapProjectileGhostRed.transform.GetChild(6).GetComponent<ParticleSystemRenderer>().material = matMercHologramRed;

            ImpactMercEvisRed.transform.GetChild(0).GetComponent<ParticleSystemRenderer>().material = matMercHologramRed;
            ImpactMercEvisRed.transform.GetChild(1).GetComponent<ParticleSystemRenderer>().material = matMercSwipe1Red;
            ImpactMercEvisRed.transform.GetChild(2).GetComponent<ParticleSystemRenderer>().material = matMercSwipe1Red;
            ImpactMercEvisRed.transform.GetChild(3).GetComponent<Light>().color = new Color(1f, 0.425f, 0.425f, 1f);//0 0.8542 1 1

            R2API.ContentAddition.AddEffect(ImpactMercEvisRed);





            particleSystemRenderer = MercExposeEffectRed.transform.GetChild(0).GetChild(0).GetComponent<ParticleSystemRenderer>();
            //matMercExposed = UnityEngine.Object.Instantiate(particleSystemRenderer.material);
            matMercExposedRed = UnityEngine.Object.Instantiate(particleSystemRenderer.material);
            matMercExposedRed.SetTexture("_RemapTex", texRampHuntressRed);
            matMercExposedRed.SetColor("_TintColor", new Color(1f, -0.1f, -0.1f, 1f));//r: 0, g: 0.1362783, b: 0.8867924, a: 1
            particleSystemRenderer.material = matMercExposedRed;
            particleSystemRenderer = MercExposeEffectRed.transform.GetChild(0).GetChild(1).GetComponent<ParticleSystemRenderer>();
            particleSystemRenderer.material = matMercExposedBackdropRed;


            particleSystemRenderer = MercExposeConsumeEffectRed.transform.GetChild(0).GetChild(0).GetComponent<ParticleSystemRenderer>();
            particleSystemRenderer.material = matMercExposedRed;
            particleSystemRenderer = MercExposeConsumeEffectRed.transform.GetChild(0).GetChild(2).GetComponent<ParticleSystemRenderer>();
            particleSystemRenderer.material = matMercExposedSlashRed;


            MercExposeEffectRed.transform.GetChild(0).GetChild(0).GetComponent<ParticleSystemRenderer>().material = matMercExposedRed;
            MercExposeEffectRed.transform.GetChild(0).GetChild(1).GetComponent<ParticleSystem>().startColor = new Color(0.23f, 0.100f, 0.080f, 0.29f);//0.1335 0.1455 0.2264 0.3412
            MercExposeEffectRed.transform.GetChild(0).GetChild(1).GetComponent<ParticleSystemRenderer>().material = matMercExposedBackdropRed;

            MercExposeConsumeEffectRed.transform.GetChild(0).GetChild(0).GetComponent<ParticleSystemRenderer>().material = matMercExposedRed;
            MercExposeConsumeEffectRed.transform.GetChild(0).GetChild(1).GetComponent<ParticleSystemRenderer>().material = matMercExposedBackdropRed;
            MercExposeConsumeEffectRed.transform.GetChild(0).GetChild(1).GetComponent<ParticleSystem>().startColor = new Color(0.35f, 0.2f, 0.2f, 0.175f);

            MercExposeConsumeEffectRed.transform.GetChild(0).GetChild(2).GetComponent<ParticleSystemRenderer>().material = matMercExposedRed;
            ContentAddition.AddEffect(MercExposeConsumeEffectRed);

            //ContentAddition.AddEffect(MercSwordFinisherSlashRed); //Game tries to spawn this as an effect even tho it isn't one

        }


    }
}