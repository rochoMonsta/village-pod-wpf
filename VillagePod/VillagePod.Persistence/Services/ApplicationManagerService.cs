using System;
using VillagePod.Persistence.Models;

namespace VillagePod.Persistence.Services
{
    public static class ApplicationManager
    {
        public static event Action? OnLoginEvent;
        public static event Action? OnLogoutEvent;
        public static event Action<PosDeviceRepresenter>? OnPosDeviceSelectedEvent;

        public static void ExecuteOnLoginEvent() => OnLoginEvent?.Invoke();
        public static void ExecuteOnLogoutEvent() => OnLogoutEvent?.Invoke();
        public static void ExecuteOnPosDeviceSelectedEvent(PosDeviceRepresenter obj) => OnPosDeviceSelectedEvent?.Invoke(obj);
    }
}
