using System;
using Dalamud.Game.Text;
using Dalamud.Game.Text.SeStringHandling;
using Dalamud.IoC;
using Dalamud.Plugin;

namespace FuckOffNoticeMessages;

public class Plugin : IDalamudPlugin
{
    public Plugin([RequiredVersion("1.0")] DalamudPluginInterface pi)
    {
        pi.Create<Service>();

        Service.ChatGui.ChatMessage += ChatGui_OnChatMessage;
    }

    private void ChatGui_OnChatMessage(XivChatType type, uint senderid, ref SeString sender, ref SeString message, ref bool ishandled)
    {
        if (type != XivChatType.Notice)
            return;

        ishandled = true;
    }

    public string Name => "FuckOffNoticeMessages";

    protected virtual void Dispose(bool disposing)
    {
        if (!disposing)
            return;
        Service.ChatGui.ChatMessage -= ChatGui_OnChatMessage;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}