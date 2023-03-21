namespace Profiler
{
    public static class HotkeyService
    {
        public static HotkeyInfo PlayHotkey { get; set; }        
        public static HotkeyInfo StopHotkey { get; set; }

        public static bool IsToggle => StopHotkey == null || Equals(PlayHotkey, StopHotkey);
    }
}