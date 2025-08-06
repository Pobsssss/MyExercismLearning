static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
	     string idFormat = id.HasValue ? $"[{id}] - " : string.Empty;
        string deptFormat = $" - {(department ?? "Owner").ToUpper()}";
        
        return $"{idFormat}{name}{deptFormat}";
}
}