namespace CompUIWPF
{
    public static class GlobalEvents
    {
        // Raised when vehicle data changes (add/update/delete) so views can refresh.
        public static event System.Action? VehiclesChanged;
        public static void RaiseVehiclesChanged() => VehiclesChanged?.Invoke();

        // Raised when a new competition entry is added, updated or deleted so views can refresh.
        public static event System.Action? CompetitionEntriesChanged;
        public static void RaiseCompetitionEntriesChanged() => CompetitionEntriesChanged?.Invoke();

        // Raised when competition data changes (add/update/delete) so views can refresh.
        public static event System.Action? CompetitionsChanged;
        public static void RaiseCompetitionsChanged() => CompetitionsChanged?.Invoke();
    }
}