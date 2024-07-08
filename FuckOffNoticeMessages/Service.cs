using Dalamud.IoC;
using Dalamud.Plugin.Services;

namespace FuckOffNoticeMessages;

internal class Service
{
    [PluginService] internal static IChatGui ChatGui { get; private set; } = null!;
}