﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Snap.Hutao.Model.Metadata;

namespace Snap.Hutao.Service.AvatarInfo.Factory;

/// <summary>
/// 圣遗物评分权重配置
/// </summary>
internal static class ReliquaryWeightConfiguration
{
    /// <summary>
    /// 默认
    /// </summary>
    public static readonly AffixWeight Default = new(0, 100, 75, 0, 100, 100, 0, 55, 0);

    /// <summary>
    /// 词条权重
    /// </summary>
    public static readonly List<AffixWeight> AffixWeights = new()
    {
        new AffixWeight(AvatarIds.Ayaka, 0, 75, 0, 100, 100, 0, 30, 0).Cryo(),
        new AffixWeight(AvatarIds.Qin, 0, 75, 0, 100, 100, 0, 55, 100).Anemo().Phyiscal(),
        new AffixWeight(AvatarIds.Lisa, 0, 75, 0, 100, 100, 75, 0, 0).Electro(),
        new AffixWeight(AvatarIds.Barbara, 100, 50, 0, 50, 50, 0, 55, 100).Hydro(80),
        new AffixWeight(AvatarIds.Kaeya, 0, 75, 0, 100, 100, 0, 30, 0).Cryo().Phyiscal(),
        new AffixWeight(AvatarIds.Diluc, 0, 75, 0, 100, 100, 75, 0, 0).Pyro(),
        new AffixWeight(AvatarIds.Razor, 0, 75, 0, 100, 100, 0, 0, 0).Electro().Phyiscal(),
        new AffixWeight(AvatarIds.Ambor, 0, 75, 0, 100, 100, 75, 0, 0).Pyro().Phyiscal(),
        new AffixWeight(AvatarIds.Venti, 0, 75, 0, 100, 100, 75, 55, 0).Anemo(),
        new AffixWeight(AvatarIds.Xiangling, 0, 75, 0, 100, 100, 75, 55, 0).Pyro(),
        new AffixWeight(AvatarIds.Beidou, 0, 75, 0, 100, 100, 75, 55, 0).Electro(),
        new AffixWeight(AvatarIds.Xingqiu, 0, 75, 0, 100, 100, 0, 75, 0).Hydro(),
        new AffixWeight(AvatarIds.Xiao, 0, 75, 0, 100, 100, 0, 55, 0).Anemo(),
        new AffixWeight(AvatarIds.Ningguang, 0, 75, 0, 100, 100, 0, 30, 0).Geo(),
        new AffixWeight(AvatarIds.Klee, 0, 75, 0, 100, 100, 75, 30, 0).Pyro(),
        new AffixWeight(AvatarIds.Zhongli, 80, 75, 0, 100, 100, 0, 55, 0).Geo().Phyiscal(50),
        new AffixWeight(AvatarIds.Fischl, 0, 75, 0, 100, 100, 75, 0, 0).Electro().Phyiscal(60),
        new AffixWeight(AvatarIds.Bennett, 100, 50, 0, 100, 100, 0, 55, 100).Pyro(80),
        new AffixWeight(AvatarIds.Tartaglia, 0, 75, 0, 100, 100, 75, 30, 0).Hydro(),
        new AffixWeight(AvatarIds.Noel, 0, 50, 90, 100, 100, 0, 70, 0).Geo(),
        new AffixWeight(AvatarIds.Qiqi, 0, 75, 0, 100, 100, 0, 55, 100).Cryo().Phyiscal(),
        new AffixWeight(AvatarIds.Chongyun, 0, 75, 0, 100, 100, 75, 55, 0).Cryo(),
        new AffixWeight(AvatarIds.Ganyu, 0, 75, 0, 100, 100, 75, 0, 0).Cryo(),
        new AffixWeight(AvatarIds.Albedo, 0, 0, 100, 100, 100, 0, 0, 0).Geo(),
        new AffixWeight(AvatarIds.Diona, 100, 50, 0, 50, 50, 0, 90, 100).Cryo(),
        new AffixWeight(AvatarIds.Mona, 0, 75, 0, 100, 100, 75, 75, 0).Hydro(),
        new AffixWeight(AvatarIds.Keqing, 0, 75, 0, 100, 100, 75, 0, 0).Electro().Phyiscal(),
        new AffixWeight(AvatarIds.Sucrose, 0, 75, 0, 100, 100, 100, 55, 0).Anemo(75),
        new AffixWeight(AvatarIds.Xinyan, 0, 75, 75, 100, 100, 0, 0, 0).Pyro().Phyiscal(),
        new AffixWeight(AvatarIds.Rosaria, 0, 75, 0, 100, 100, 0, 30, 0).Cryo(70).Phyiscal(80),
        new AffixWeight(AvatarIds.Hutao, 80, 50, 0, 100, 100, 75, 0, 0).Pyro(),
        new AffixWeight(AvatarIds.Kazuha, 0, 75, 0, 100, 100, 100, 55, 0).Anemo(),
        new AffixWeight(AvatarIds.Feiyan, 0, 75, 0, 100, 100, 75, 30, 0).Pyro(),
        new AffixWeight(AvatarIds.Yoimiya, 0, 75, 0, 100, 100, 75, 0, 0).Pyro(),
        new AffixWeight(AvatarIds.Tohma, 90, 55, 0, 90, 90, 0, 55, 0).Pyro(90),
        new AffixWeight(AvatarIds.Eula, 0, 75, 0, 100, 100, 0, 55, 0).Cryo(40).Phyiscal(100),
        new AffixWeight(AvatarIds.Shougun, 0, 75, 0, 100, 100, 0, 90, 0).Electro(75),
        new AffixWeight(AvatarIds.Sayu, 0, 75, 0, 100, 100, 100, 55, 100).Anemo(),
        new AffixWeight(AvatarIds.Kokomi, 100, 50, 0, 0, 0, 0, 55, 100).Hydro(),
        new AffixWeight(AvatarIds.Gorou, 0, 75, 100, 50, 50, 0, 75, 0).Geo(25),
        new AffixWeight(AvatarIds.Sara, 0, 75, 0, 100, 100, 0, 55, 0).Electro(),
        new AffixWeight(AvatarIds.Itto, 0, 50, 100, 100, 100, 0, 30, 0).Geo(),
        new AffixWeight(AvatarIds.Yae, 0, 75, 0, 100, 100, 75, 55, 0).Electro(),
        new AffixWeight(AvatarIds.Heizo, 0, 75, 0, 100, 100, 75, 30, 0).Anemo(),
        new AffixWeight(AvatarIds.Yelan, 80, 0, 0, 100, 100, 0, 55, 0).Hydro(),
        new AffixWeight(AvatarIds.Aloy, 0, 75, 0, 100, 100, 0, 0, 0).Cryo(),
        new AffixWeight(AvatarIds.Shenhe, 0, 100, 0, 100, 100, 0, 55, 0).Cryo(),
        new AffixWeight(AvatarIds.Yunjin, 0, 75, 100, 80, 80, 0, 80, 0).Geo(80),
        new AffixWeight(AvatarIds.Shinobu, 100, 50, 0, 100, 100, 75, 55, 100).Electro(),
        new AffixWeight(AvatarIds.Ayato, 50, 75, 0, 100, 100, 0, 30, 0).Hydro(),
        new AffixWeight(AvatarIds.Collei, 0, 75, 0, 100, 100, 75, 30, 0).Dendro(),
        new AffixWeight(AvatarIds.Dori, 75, 75, 0, 100, 100, 0, 55, 100).Electro(75),
        new AffixWeight(AvatarIds.Tighnari, 0, 75, 0, 100, 100, 90, 30, 0).Dendro(),
        new AffixWeight(AvatarIds.Nilou, 100, 0, 0, 100, 100, 80, 30, 0).Hydro(),
        new AffixWeight(AvatarIds.Cyno, 0, 75, 0, 100, 100, 75, 55, 0).Electro(),
        new AffixWeight(AvatarIds.Candace, 75, 75, 0, 100, 100, 0, 55, 0).Hydro(),
        new AffixWeight(AvatarIds.Nahida, 0, 55, 0, 100, 100, 100, 55, 0).Dendro(),
        new AffixWeight(AvatarIds.Layla, 100, 75, 0, 100, 100, 0, 35, 0).Cryo(),
        new AffixWeight(AvatarIds.Wanderer, 0, 80, 0, 100, 100, 0, 35, 0).Anemo(),
        new AffixWeight(AvatarIds.Faruzan, 0, 75, 0, 100, 100, 0, 75, 0).Anemo(),
        new AffixWeight(AvatarIds.Yaoyao, 100, 75, 0, 100, 100, 75, 75, 100).Dendro(),
        new AffixWeight(AvatarIds.Alhaitham, 0, 75, 0, 100, 100, 100, 35, 0).Dendro(),
    };
}