﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Snap.Hutao.Core.Windowing;
using Snap.Hutao.ViewModel;
using Windows.Graphics;
using Windows.Win32.UI.WindowsAndMessaging;

namespace Snap.Hutao;

/// <summary>
/// 启动游戏窗口
/// </summary>
[HighQuality]
[Injection(InjectAs.Singleton)]
internal sealed partial class LaunchGameWindow : Window, IDisposable, IExtendedWindowSource
{
    private const int MinWidth = 240;
    private const int MinHeight = 240;

    private const int MaxWidth = 320;
    private const int MaxHeight = 320;

    private readonly IServiceScope scope;

    /// <summary>
    /// 构造一个新的启动游戏窗口
    /// </summary>
    /// <param name="scopeFactory">范围工厂</param>
    public LaunchGameWindow(IServiceScopeFactory scopeFactory)
    {
        InitializeComponent();

        scope = scopeFactory.CreateScope();
        ExtendedWindow<LaunchGameWindow>.Initialize(this, scope.ServiceProvider);
        RootGrid.DataContext = scope.ServiceProvider.GetRequiredService<LaunchGameViewModel>();
        Closed += (s, e) => Dispose();
    }

    /// <inheritdoc/>
    public FrameworkElement TitleBar { get => DragableGrid; }

    /// <inheritdoc/>
    public bool PersistSize { get => false; }

    /// <inheritdoc/>
    public SizeInt32 InitSize { get => new(320, 320); }

    /// <inheritdoc/>
    public void Dispose()
    {
        scope.Dispose();
    }

    /// <inheritdoc/>
    public unsafe void ProcessMinMaxInfo(MINMAXINFO* pInfo, double scalingFactor)
    {
        pInfo->ptMinTrackSize.X = (int)Math.Max(MinWidth * scalingFactor, pInfo->ptMinTrackSize.X);
        pInfo->ptMinTrackSize.Y = (int)Math.Max(MinHeight * scalingFactor, pInfo->ptMinTrackSize.Y);
        pInfo->ptMaxTrackSize.X = (int)Math.Min(MaxWidth * scalingFactor, pInfo->ptMaxTrackSize.X);
        pInfo->ptMaxTrackSize.Y = (int)Math.Min(MaxHeight * scalingFactor, pInfo->ptMaxTrackSize.Y);
    }
}