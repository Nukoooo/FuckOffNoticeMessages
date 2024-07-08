using System;
using Dalamud.Game.Text;
using Dalamud.Game.Text.SeStringHandling;
using Dalamud.Plugin;

namespace FuckOffNoticeMessages;

public class Plugin : IDalamudPlugin
{
    public Plugin(IDalamudPluginInterface pi)
    {
        pi.Create<Service>();

        Service.ChatGui.ChatMessage += ChatGui_OnChatMessage;
    }

    private void ChatGui_OnChatMessage(XivChatType type, int timestamp, ref SeString sender, ref SeString message, ref bool ishandled)
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