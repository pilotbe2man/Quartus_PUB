﻿Public Class ENUMS

    Public Enum ClickedButtonEvent
        Enemy
        VisibleEnemy
        Team
        Weapon
        Grenade
        Bomb
        Chicken
    End Enum

    Public Enum ItemDefinitionIndex
        NONE = 0
        DEAGLE = 1
        ELITE = 2
        FIVESEVEN = 3
        GLOCK = 4
        AK47 = 7
        AUG = 8
        AWP = 9
        FAMAS = 10
        G3SG1 = 11
        GALILAR = 13
        M249 = 14
        M4A1 = 16
        MAC10 = 17
        P90 = 19
        MP5SD = 23
        UMP45 = 24
        XM1014 = 25
        BIZON = 26
        MAG7 = 27
        NEGEV = 28
        SAWEDOFF = 29
        TEC9 = 30
        TASER = 31
        HKP2000 = 32
        MP7 = 33
        MP9 = 34
        NOVA = 35
        P250 = 36
        SCAR20 = 38
        SG553 = 39
        SSG08 = 40
        KNIFEGG = 41
        KNIFE = 42
        FLASHBANG = 43
        HEGRENADE = 44
        SMOKEGRENADE = 45
        MOLOTOV = 46
        DECOY = 47
        INCGRENADE = 48
        C4 = 49
        HEALTHSHOT = 57
        KNIFE_T = 59
        M4A1_SILENCER = 60
        USP_SILENCER = 61
        CZ75A = 63
        REVOLVER = 64
        TAGRENADE = 68
        FISTS = 69
        BREACHCHARGE = 70
        TABLET = 72
        MELEE = 74
        AXE = 75
        HAMMER = 76
        SPANNER = 78
        KNIFE_GHOST = 80
        FIREBOMB = 81
        DIVERSION = 82
        FRAG_GRENADE = 83
        KNIFE_BAYONET = 500
        KNIFE_FLIP = 505
        KNIFE_GUT = 506
        KNIFE_KARAMBIT = 507
        KNIFE_M9_BAYONET = 508
        KNIFE_TACTICAL = 509
        KNIFE_FALCHION = 512
        KNIFE_SURVIVAL_BOWIE = 514
        KNIFE_BUTTERFLY = 515
        KNIFE_PUSH = 516
        KNIFE_URSUS = 519
        KNIFE_GYPSY_JACKKNIFE = 520
        KNIFE_STILETTO = 522
        KNIFE_WIDOWMAKER = 523
    End Enum

    Public Enum WeaponType
        Knife = 0
        Pistol = 1
        SMG = 2
        Rifle = 3
        Sniper = 4
        Shotgun = 5
        Heavy = 6
        Grenade = 7
    End Enum

    Public Enum ClassID
        AI_BaseNPC = 0
        AK47 = 1
        BaseAnimating = 2
        BaseAnimatingOverlay = 3
        BaseAttributableItem = 4
        BaseButton = 5
        BaseCombatCharacter = 6
        BaseCombatWeapon = 7
        BaseCSGrenade = 8
        BaseCSGrenadeProjectile = 9
        BaseDoor = 10
        BaseEntity = 11
        BaseFlex = 12
        BaseGrenade = 13
        BaseParticleEntity = 14
        BasePlayer = 15
        BasePropDoor = 16
        BaseTeamObjectiveResource = 17
        BaseTempEntity = 18
        BaseToggle = 19
        BaseTrigger = 20
        BaseViewModel = 21
        BaseVPhysicsTrigger = 22
        BaseWeaponWorldModel = 23
        Beam = 24
        BeamSpotlight = 25
        BoneFollower = 26
        BRC4Target = 27
        BreachCharge = 28
        BreachChargeProjectile = 29
        BreakableProp = 30
        BreakableSurface = 31
        C4 = 32
        CascadeLight = 33
        Chicken = 34
        ColorCorrection = 35
        ColorCorrectionVolume = 36
        CSGameRulesProxy = 37
        CSPlayer = 38
        CSPlayerResource = 39
        CSRagdoll = 40
        CSTeam = 41
        DangerZone = 42
        DangerZoneController = 43
        DEagle = 44
        DecoyGrenade = 45
        DecoyProjectile = 46
        Drone = 47
        Dronegun = 48
        DynamicLight = 49
        DynamicProp = 50
        EconEntity = 51
        EconWearable = 52
        Embers = 53
        EntityDissolve = 54
        EntityFlame = 55
        EntityFreezing = 56
        EntityParticleTrail = 57
        EnvAmbientLight = 58
        EnvDetailController = 59
        EnvDOFController = 60
        EnvGasCanister = 61
        EnvParticleScript = 62
        EnvProjectedTexture = 63
        EnvQuadraticBeam = 64
        EnvScreenEffect = 65
        EnvScreenOverlay = 66
        EnvTonemapController = 67
        EnvWind = 68
        FEPlayerDecal = 69
        FireCrackerBlast = 70
        FireSmoke = 71
        FireTrail = 72
        Fish = 73
        Fists = 74
        Flashbang = 75
        FogController = 76
        FootstepControl = 77
        Func_Dust = 78
        Func_LOD = 79
        FuncAreaPortalWindow = 80
        FuncBrush = 81
        FuncConveyor = 82
        FuncLadder = 83
        FuncMonitor = 84
        FuncMoveLinear = 85
        FuncOccluder = 86
        FuncReflectiveGlass = 87
        FuncRotating = 88
        FuncSmokeVolume = 89
        FuncTrackTrain = 90
        GameRulesProxy = 91
        GrassBurn = 92
        HandleTest = 93
        HEGrenade = 94
        Hostage = 95
        HostageCarriableProp = 96
        IncendiaryGrenade = 97
        Inferno = 98
        InfoLadderDismount = 99
        InfoMapRegion = 100
        InfoOverlayAccessor = 101
        Item_Healthshot = 102
        ItemCash = 103
        ItemDogtags = 104
        Knife = 105
        KnifeGG = 106
        LightGlow = 107
        MaterialModifyControl = 108
        Melee = 109
        MolotovGrenade = 110
        MolotovProjectile = 111
        MovieDisplay = 112
        ParadropChopper = 113
        ParticleFire = 114
        ParticlePerformanceMonitor = 115
        ParticleSystem = 116
        PhysBox = 117
        PhysBoxMultiplayer = 118
        PhysicsProp = 119
        PhysicsPropMultiplayer = 120
        PhysMagnet = 121
        PhysPropAmmoBox = 122
        PhysPropLootCrate = 123
        PhysPropRadarJammer = 124
        PhysPropWeaponUpgrade = 125
        PlantedC4 = 126
        Plasma = 127
        PlayerResource = 128
        PointCamera = 129
        PointCommentaryNode = 130
        PointWorldText = 131
        PoseController = 132
        PostProcessController = 133
        Precipitation = 134
        PrecipitationBlocker = 135
        PredictedViewModel = 136
        Prop_Hallucination = 137
        PropCounter = 138
        PropDoorRotating = 139
        PropJeep = 140
        PropVehicleDriveable = 141
        RagdollManager = 142
        RagdollProp = 143
        RagdollPropAttached = 144
        RopeKeyframe = 145
        SCAR17 = 146
        SceneEntity = 147
        SensorGrenade = 148
        SensorGrenadeProjectile = 149
        ShadowControl = 150
        SlideshowDisplay = 151
        SmokeGrenade = 152
        SmokeGrenadeProjectile = 153
        SmokeStack = 154
        SpatialEntity = 155
        SpotlightEnd = 156
        Sprite = 157
        SpriteOriented = 158
        SpriteTrail = 159
        StatueProp = 160
        SteamJet = 161
        Sun = 162
        SunlightShadowControl = 163
        SurvivalSpawnChopper = 164
        Tablet = 165
        Team = 166
        TeamplayRoundBasedRulesProxy = 167
        TEArmorRicochet = 168
        TEBaseBeam = 169
        TEBeamEntPoint = 170
        TEBeamEnts = 171
        TEBeamFollow = 172
        TEBeamLaser = 173
        TEBeamPoints = 174
        TEBeamRing = 175
        TEBeamRingPoint = 176
        TEBeamSpline = 177
        TEBloodSprite = 178
        TEBloodStream = 179
        TEBreakModel = 180
        TEBSPDecal = 181
        TEBubbles = 182
        TEBubbleTrail = 183
        TEClientProjectile = 184
        TEDecal = 185
        TEDust = 186
        TEDynamicLight = 187
        TEEffectDispatch = 188
        TEEnergySplash = 189
        TEExplosion = 190
        TEFireBullets = 191
        TEFizz = 192
        TEFootprintDecal = 193
        TEFoundryHelpers = 194
        TEGaussExplosion = 195
        TEGlowSprite = 196
        TEImpact = 197
        TEKillPlayerAttachments = 198
        TELargeFunnel = 199
        TEMetalSparks = 200
        TEMuzzleFlash = 201
        TEParticleSystem = 202
        TEPhysicsProp = 203
        TEPlantBomb = 204
        TEPlayerAnimEvent = 205
        TEPlayerDecal = 206
        TEProjectedDecal = 207
        TERadioIcon = 208
        TEShatterSurface = 209
        TEShowLine = 210
        Tesla = 211
        TESmoke = 212
        TESparks = 213
        TESprite = 214
        TESpriteSpray = 215
        Test_ProxyToggle_Networkable = 216
        TestTraceline = 217
        TEWorldDecal = 218
        TriggerPlayerMovement = 219
        TriggerSoundOperator = 220
        VGuiScreen = 221
        VoteController = 222
        WaterBullet = 223
        WaterLODControl = 224
        WeaponAug = 225
        WeaponAWP = 226
        WeaponBaseItem = 227
        WeaponBizon = 228
        WeaponCSBase = 229
        WeaponCSBaseGun = 230
        WeaponCycler = 231
        WeaponElite = 232
        WeaponFamas = 233
        WeaponFiveSeven = 234
        WeaponG3SG1 = 235
        WeaponGalil = 236
        WeaponGalilAR = 237
        WeaponGlock = 238
        WeaponHKP2000 = 239
        WeaponM249 = 240
        WeaponM3 = 241
        WeaponM4A1 = 242
        WeaponMAC10 = 243
        WeaponMag7 = 244
        WeaponMP5Navy = 245
        WeaponMP7 = 246
        WeaponMP9 = 247
        WeaponNegev = 248
        WeaponNOVA = 249
        WeaponP228 = 250
        WeaponP250 = 251
        WeaponP90 = 252
        WeaponSawedoff = 253
        WeaponSCAR20 = 254
        WeaponScout = 255
        WeaponSG550 = 256
        WeaponSG552 = 257
        WeaponSG556 = 258
        WeaponSSG08 = 259
        WeaponTaser = 260
        WeaponTec9 = 261
        WeaponTMP = 262
        WeaponUMP45 = 263
        WeaponUSP = 264
        WeaponXM1014 = 265
        World = 266
        WorldVguiText = 267
        DustTrail = 268
        MovieExplosion = 269
        ParticleSmokeGrenade = 270
        RocketTrail = 271
        SmokeTrail = 272
        SporeExplosion = 273
        SporeTrail = 274
    End Enum

End Class
