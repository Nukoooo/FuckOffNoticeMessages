using Dalamud.Game.Gui;
using Dalamud.IoC;

namespace FuckOffNoticeMessages;

internal class Service
{
    [PluginService] internal static ChatGui ChatGui { get; private set; } = null!;
}