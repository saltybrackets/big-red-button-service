namespace BigRedButtonService
{
	/// <summary>
	/// Enumeration of states the Big Red Button may be in.
	/// </summary>
    public enum ButtonState
    {
        Unknown = 0,
		Inactive = 1,
		Errored = 2,
        LidClosed = 21,
        ButtonPressed = 22,
        LidOpened = 23
    }
}